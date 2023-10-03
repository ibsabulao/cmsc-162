using System.Windows.Forms;

namespace Image_Processing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ViewImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.ico;*.tiff|All Files|*.*";
                openFileDialog.FilterIndex = 1;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedFilePath = openFileDialog.FileName;

                    try
                    {
                        // Load the image and display it in the PictureBox control
                        using (FileStream fileStream = new FileStream(selectedFilePath, FileMode.Open))
                        {
                            ViewImage.Image = Image.FromStream(fileStream);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error loading the image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void PCX_DisplayHeaderInfo(byte[] header)
        {
            PCXheaderInfoBox.AppendText("PCX Header Information: " + Environment.NewLine + Environment.NewLine);
            PCXheaderInfoBox.AppendText($"Manufacturer: {header[0]}" + Environment.NewLine);
            PCXheaderInfoBox.AppendText($"Version: {header[1]}" + Environment.NewLine);
            PCXheaderInfoBox.AppendText($"Encoding: {header[2]}" + Environment.NewLine);
            PCXheaderInfoBox.AppendText($"Bits Per Pixel: {header[3]}" + Environment.NewLine);

            // image dimensions
            int xmin = BitConverter.ToInt16(header, 4);
            int ymin = BitConverter.ToInt16(header, 6);
            int xmax = BitConverter.ToInt16(header, 8);
            int ymax = BitConverter.ToInt16(header, 10);
            PCXheaderInfoBox.AppendText($"Window Dimensions: {xmin} {ymin} {xmax} {ymax}" + Environment.NewLine);

            int hdpi = BitConverter.ToUInt16(header, 12);
            int vdpi = BitConverter.ToUInt16(header, 14);
            PCXheaderInfoBox.AppendText($"Horizontal Resolution (DPI): {hdpi}" + Environment.NewLine);
            PCXheaderInfoBox.AppendText($"Vertical Resolution (DPI): {vdpi}" + Environment.NewLine);

            int colormap = BitConverter.ToUInt16(header, 16);
            PCXheaderInfoBox.AppendText($"Colormap: {colormap}" + Environment.NewLine);

            int nplanes = header[65];
            PCXheaderInfoBox.AppendText($"Number of Color Planes: {nplanes}" + Environment.NewLine);

            int bytesPerLine = BitConverter.ToUInt16(header, 66);
            PCXheaderInfoBox.AppendText($"Bytes Per Line: {bytesPerLine}" + Environment.NewLine);

            int paletteInfo = BitConverter.ToUInt16(header, 68);
            PCXheaderInfoBox.AppendText($"Palette Information: {paletteInfo}" + Environment.NewLine);

            int hscreenSize = BitConverter.ToUInt16(header, 70);
            int vscreenSize = BitConverter.ToUInt16(header, 72);
            PCXheaderInfoBox.AppendText($"Horizontal Screen Size: {hscreenSize}" + Environment.NewLine);
            PCXheaderInfoBox.AppendText($"Vertical Screen Size: {vscreenSize}" + Environment.NewLine);
        }

        private void PCX_DisplayPalette(byte[] paletteData)
        {
            PCXheaderInfoBox.AppendText("\nColor Palette:" + Environment.NewLine);

            int paletteSize = paletteData.Length / 3;
            int paletteWidth = 10;
            int paletteHeight = 10;

            for (int i = 0; i < paletteSize; i++)
            {
                int r = paletteData[i * 3];
                int g = paletteData[i * 3 + 1];
                int b = paletteData[i * 3 + 2];

                // Create a color square
                Panel colorSquare = new Panel();
                colorSquare.BackColor = Color.FromArgb(r, g, b);
                colorSquare.Size = new Size(paletteWidth, paletteHeight);
                colorSquare.Location = new Point(i % 16 * paletteWidth, i / 16 * paletteHeight);

                // Add the color square to the palettePanel
                pcxPalette.Controls.Add(colorSquare);
            }
        }

        private void ViewPCX_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog_1 = new OpenFileDialog())
            {
                openFileDialog_1.Filter = "PCX Files|*.pcx";
                openFileDialog_1.FilterIndex = 1;

                if (openFileDialog_1.ShowDialog() == DialogResult.OK)
                {
                    string selectedFilePath = openFileDialog_1.FileName;

                    try
                    {
                        using (FileStream fileStream = new FileStream(selectedFilePath, FileMode.Open, FileAccess.Read))
                        {
                            pcxLabel.Text = "Original Image";

                            // header
                            byte[] header = new byte[128];
                            fileStream.Read(header, 0, 128);
                            PCX_DisplayHeaderInfo(header);

                            // color palette
                            byte[] paletteData = new byte[768];
                            fileStream.Seek(-768, SeekOrigin.End);
                            fileStream.Read(paletteData, 0, 768);
                            PCX_DisplayPalette(paletteData);

                            // pcx image
                            PCXviewImg.Image = Image.FromStream(fileStream);
                        }

                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error loading the file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}