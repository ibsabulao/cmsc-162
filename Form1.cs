using System.Reflection.PortableExecutable;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using static System.Net.Mime.MediaTypeNames;
using System.Diagnostics.Metrics;

namespace Image_Processing
{
    public partial class Form1 : Form
    {
        private Bitmap? originalImage;
        private Bitmap? redChannelImage;
        private Bitmap? greenChannelImage;
        private Bitmap? blueChannelImage;
        private PictureBox? histogramPictureBox;

        private int maxFrequencyIntensity; // Declare the variable outside the method

        // Create a new form to display the histogram
        Form histogramForm = new Form();
        public Form1()
        {
            InitializeComponent();
        }

        private void ViewImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.ico;*.tiff;*.jfif|All Files|*.*";
                openFileDialog.FilterIndex = 1;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedFilePath = openFileDialog.FileName;

                    try
                    {
                        PCXheaderInfoBox.Controls.Clear();
                        PCXheaderInfoBox.Clear();

                        originalImage = new Bitmap(selectedFilePath);
                        ViewImage.Image = originalImage;
                        imageChannel.Image = null; // empty if there's previously uploaded img

                        originalImageLabel.Text = "Original Image";
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
            PCXheaderInfoBox.Controls.Clear();

            PCXheaderInfoBox.AppendText("\nColor Palette:" + Environment.NewLine);

            int paletteSize = paletteData.Length / 3;
            int paletteWidth = 10;
            int paletteHeight = 10;

            // Calculate the starting Y coordinate for appending below the text
            int startY = PCXheaderInfoBox.GetPositionFromCharIndex(PCXheaderInfoBox.Text.Length - 1).Y + PCXheaderInfoBox.Font.Height;

            for (int i = 0; i < paletteSize; i++)
            {
                int r = paletteData[i * 3];
                int g = paletteData[i * 3 + 1];
                int b = paletteData[i * 3 + 2];

                // Create a color square
                Panel colorSquare = new Panel();
                colorSquare.BackColor = Color.FromArgb(r, g, b);
                colorSquare.Size = new Size(paletteWidth, paletteHeight);
                colorSquare.Location = new Point(i % 16 * paletteWidth, startY + (i / 16 * paletteHeight));

                // Add the color square to the palettePanel
                PCXheaderInfoBox.Controls.Add(colorSquare);
            }
        }

        public static byte[] DecodeRLE(byte[] data)
        {
            using (MemoryStream decompressedStream = new MemoryStream())
            {
                int index = 0;
                int count;

                while (index < data.Length)
                {
                    byte currentByte = data[index++];
                    if ((currentByte & 0xC0) == 0xC0)
                    {
                        count = currentByte & 0x3F;
                        byte value = data[index++];
                        for (int i = 0; i < count; i++)
                            decompressedStream.WriteByte(value);
                    }
                    else
                    {
                        count = 1;
                        decompressedStream.WriteByte(currentByte);
                    }
                }

                return decompressedStream.ToArray();
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
                            PCXheaderInfoBox.Clear();

                            originalImageLabel.Text = "Original PCX Image";

                            // header
                            byte[] header = new byte[128];
                            fileStream.Read(header, 0, 128);
                            PCX_DisplayHeaderInfo(header);

                            // color palette
                            byte[] paletteData = new byte[768];
                            fileStream.Seek(-768, SeekOrigin.End);
                            fileStream.Read(paletteData, 0, 768);
                            PCX_DisplayPalette(paletteData);

                            // image
                            int width = header[8] + (header[9] << 8) + 1;
                            int height = header[10] + (header[11] << 8) + 1;

                            originalImage = new Bitmap(width, height);

                            // Read the RLE-encoded pixel data
                            int pixelDataSize = width * height * (header[3] / 8);
                            byte[] compressedData = new byte[pixelDataSize];
                            fileStream.Seek(128, SeekOrigin.Begin); // Seek to the start of the pixel data
                            fileStream.Read(compressedData, 0, pixelDataSize);

                            // Decode the RLE-encoded pixel data
                            byte[] decompressedData = DecodeRLE(compressedData);

                            // Create a Bitmap from the decoded pixel data
                            int index = 0;
                            for (int y = 0; y < height; y++)
                            {
                                for (int x = 0; x < width; x++)
                                {
                                    int colorIndex = decompressedData[index++];
                                    Color pixelColor = Color.FromArgb(paletteData[colorIndex * 3], paletteData[colorIndex * 3 + 1], paletteData[colorIndex * 3 + 2]);
                                    originalImage.SetPixel(x, y, pixelColor);
                                }
                            }

                            // Display the PCX image in the PictureBox control
                            ViewImage.Image = originalImage;
                            imageChannel.Image = null; // empty if there's previously uploaded img
                        }
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error loading the file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void Red_Click(object sender, EventArgs e)
        {
            if (originalImage != null)
            {
                redChannelImage = SplitChannel(originalImage, ColorChannel.Red);
                channelLabel.Text = "Red Channel";
                histogramForm.Text = "Red Channel Histogram";
                imageChannel.Image = redChannelImage;

                // Call the modified ShowHistogram method and get the histogram colors
                Color[] histogramColors = ShowHistogram(redChannelImage);
            }
        }

        private void Green_Click(object sender, EventArgs e)
        {
            if (originalImage != null)
            {
                greenChannelImage = SplitChannel(originalImage, ColorChannel.Green);
                channelLabel.Text = "Green Channel";
                histogramForm.Text = "Green Channel Histogram";
                imageChannel.Image = greenChannelImage;

                // Call the modified ShowHistogram method and get the histogram colors
                Color[] histogramColors = ShowHistogram(greenChannelImage);
            }
        }

        private void Blue_Click(object sender, EventArgs e)
        {
            if (originalImage != null)
            {
                blueChannelImage = SplitChannel(originalImage, ColorChannel.Blue);
                channelLabel.Text = "Blue Channel";
                imageChannel.Image = blueChannelImage;

                // Call the modified ShowHistogram method and get the histogram colors
                Color[] histogramColors = ShowHistogram(blueChannelImage);
            }
        }

        private Bitmap SplitChannel(Bitmap sourceImage, ColorChannel channel)
        {
            Bitmap channelImage = new Bitmap(sourceImage.Width, sourceImage.Height);

            for (int x = 0; x < sourceImage.Width; x++)
            {
                for (int y = 0; y < sourceImage.Height; y++)
                {
                    Color pixel = sourceImage.GetPixel(x, y);
                    Color newPixel = Color.FromArgb(
                        channel == ColorChannel.Red ? pixel.R : 0,
                        channel == ColorChannel.Green ? pixel.G : 0,
                        channel == ColorChannel.Blue ? pixel.B : 0
                    );
                    channelImage.SetPixel(x, y, newPixel);
                }
            }

            return channelImage;
        }

        private Color[] ShowHistogram(Bitmap channelImage)
        {
            Size pictureBoxSize = new Size(600, 600); // Set the desired PictureBox size

            // Ensure the channelImage is not null
            if (channelImage == null)
            {
                return new Color[256]; // Return an empty color array
            }

            // Initialize an array to store the histogram data for each intensity level
            int[] histogram = new int[256];
            float max = 0;
            int maxFrequencyIntensity = -1;

            // Iterate through each pixel in the image and update the histogram
            for (int x = 0; x < channelImage.Width; x++)
            {
                for (int y = 0; y < channelImage.Height; y++)
                {
                    Color pixel = channelImage.GetPixel(x, y);
                    int value = channelImage == redChannelImage ? pixel.R :
                                channelImage == greenChannelImage ? pixel.G : pixel.B;

                    histogram[value]++;
                    if (max < histogram[value])
                    {
                        max = histogram[value];
                        maxFrequencyIntensity = value;
                    }
                }
            }

            // Find the maximum count in the histogram for scaling
            int maxCount = histogram.Max();
            int histWidth = 550; // Set the width of the histogram
            int histHeight = 350; // Set the height of the histogram

            Color[] histogramColors = new Color[256];

            using (Bitmap histogramBitmap = new Bitmap(histWidth, histHeight))
            using (Graphics g = Graphics.FromImage(histogramBitmap))
            {
                g.Clear(Color.White);

                // Add vertical lines every 50 intensity levels and display intensity values
                for (int i = 50; i < 256; i += 50)
                {
                    int x = i * (histWidth / 256);
                    g.DrawLine(Pens.Black, x, 0, x, histHeight);
                }

                // Add horizontal lines every 200 pixels
                for (int i = 500; i < maxCount; i += 500)
                {
                    int y = histHeight - (int)((i / (float)maxCount) * histHeight);
                    g.DrawLine(Pens.Black, 0, y, histWidth, y);
                }

                for (int i = 0; i < histogram.Length; i++)
                {
                    float pct = histogram[i] / max; // Calculate the percentage of the max pixel count

                    // Calculate the height of the bar based on the percentage
                    int barHeight = (int)(pct * histHeight);

                    // Calculate vertical position for bars
                    int barY = histHeight - barHeight;

                    // Draw the histogram bar for the channel
                    Color channelColor = channelImage == redChannelImage ? Color.Pink :
                                         channelImage == greenChannelImage ? Color.LightGreen : Color.LightBlue;

                    g.FillRectangle(new SolidBrush(channelColor),
                        new Rectangle(i * (histWidth / 256), barY, histWidth / 256, barHeight)
                    );

                    histogramColors[i] = channelColor;
                }

                // Add vertical lines every 50 intensity levels and display intensity values
                for (int i = 50; i < 256; i += 50)
                {
                    int x = i * (histWidth / 256);
                    g.DrawLine(Pens.Black, x, 0, x, histHeight);
                    g.DrawString(i.ToString(), new Font("Arial", 8), Brushes.Black, x, histHeight - 20);
                }

                // Add horizontal lines every 200 pixels
                for (int i = 500; i < maxCount; i += 500)
                {
                    int y = histHeight - (int)((i / (float)maxCount) * histHeight);
                    g.DrawLine(Pens.Black, 0, y, histWidth, y);
                    g.DrawString(i.ToString(), new Font("Arial", 8), Brushes.Black, 5, y);
                }

                histogramForm.Text = channelImage == redChannelImage ? "Red Channel Histogram" :
                                    channelImage == greenChannelImage ? "Green Channel Histogram" : "Blue Channel Histogram";
                histogramForm.Size = pictureBoxSize;

                // Create the PictureBox for the histogram if it's not already created
                if (histogramPictureBox == null)
                {
                    histogramPictureBox = new PictureBox();
                    histogramPictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
                    histogramPictureBox.Dock = DockStyle.Fill;

                    // Calculate the location to center the PictureBox
                    int pictureBoxX = (histogramForm.Width - histogramPictureBox.Width) / 2;
                    int pictureBoxY = (histogramForm.Height - histogramPictureBox.Height) / 2;
                    histogramPictureBox.Location = new Point(pictureBoxX, pictureBoxY);

                    // Add the PictureBox to the form
                    histogramForm.Controls.Add(histogramPictureBox);
                }

                // Clear the existing image
                if (histogramPictureBox.Image != null)
                {
                    histogramPictureBox.Image.Dispose();
                    histogramPictureBox.Image = null;
                }

                // Set the Image property if histogramPictureBox is not null
                if (histogramPictureBox != null)
                {
                    histogramPictureBox.Image = histogramBitmap;
                }

                // Show the form as a dialog
                histogramForm.ShowDialog();
            }

            return histogramColors;
        }

        private enum ColorChannel
        {
            Red,
            Green,
            Blue
        }

        private void Grayscale_Click(object sender, EventArgs e)
        {
            if (originalImage != null)
            {
                channelLabel.Text = "Grayscale Transformation";
                Bitmap sourceImage = originalImage;
                Bitmap grayscaleImage = new Bitmap(sourceImage.Width, sourceImage.Height);

                for (int x = 0; x < sourceImage.Width; x++)
                {
                    for (int y = 0; y < sourceImage.Height; y++)
                    {
                        Color pixel = sourceImage.GetPixel(x, y);
                        int grayValue = (int)(0.3 * pixel.R + 0.59 * pixel.G + 0.11 * pixel.B);
                        grayscaleImage.SetPixel(x, y, Color.FromArgb(grayValue, grayValue, grayValue));
                    }
                }

                imageChannel.Image = grayscaleImage;

            }
        }

        private void Negative_Click(object sender, EventArgs e)
        {
            if (originalImage != null)
            {
                channelLabel.Text = "Negative Transformation";
                Bitmap sourceImage = originalImage;
                Bitmap negativeImage = new Bitmap(sourceImage.Width, sourceImage.Height);

                for (int x = 0; x < sourceImage.Width; x++)
                {
                    for (int y = 0; y < sourceImage.Height; y++)
                    {
                        Color pixel = sourceImage.GetPixel(x, y);
                        Color negativePixel = Color.FromArgb(255 - pixel.R, 255 - pixel.G, 255 - pixel.B);
                        negativeImage.SetPixel(x, y, negativePixel);
                    }
                }

                imageChannel.Image = negativeImage;

            }
        }

        private void BW_Scroll(object sender, EventArgs e)
        {
            if (originalImage != null)
            {
                channelLabel.Text = "Black and White";
                Bitmap sourceImage = originalImage;
                Bitmap bw_image = new Bitmap(sourceImage.Width, sourceImage.Height);
                int threshold = bw_trackbar.Value;

                for (int y = 0; y < sourceImage.Height; y++)
                {
                    for (int x = 0; x < sourceImage.Width; x++)
                    {
                        Color pixel = sourceImage.GetPixel(x, y);
                        int average = (pixel.R + pixel.G + pixel.B) / 3;

                        Color bwColor = (average >= threshold) ? Color.White : Color.Black;
                        bw_image.SetPixel(x, y, bwColor);
                    }
                }

                imageChannel.Image = bw_image;
            }
        }

        private void GammaTransform_Click(object sender, EventArgs e)
        {
            if (originalImage != null && !string.IsNullOrEmpty(gamma_textbox.Text))
            {
                channelLabel.Text = "Gamma Transformation";
                Bitmap sourceImage = originalImage;
                Bitmap gamma_img = new Bitmap(sourceImage.Width, sourceImage.Height);
                float gamma = float.Parse(gamma_textbox.Text);

                for (int x = 0; x < sourceImage.Width; x++)
                {
                    for (int y = 0; y < sourceImage.Height; y++)
                    {
                        Color pixel = sourceImage.GetPixel(x, y);

                        int gray = (int)(0.299 * pixel.R + 0.587 * pixel.G + 0.114 * pixel.B);
                        int newGray = (int)(Math.Pow(gray / 255.0, gamma) * 255);

                        Color newPixel = Color.FromArgb(newGray, newGray, newGray);
                        gamma_img.SetPixel(x, y, newPixel);
                    }
                }

                imageChannel.Image = gamma_img;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}