using System.Reflection.PortableExecutable;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using static System.Net.Mime.MediaTypeNames;
using System.Diagnostics.Metrics;
using System.Xml.Linq;

namespace Image_Processing
{
    public partial class Form1 : Form
    {
        // bitsPerPixel: Number of bits per pixel in the PCX image.
        private byte bitsPerPixel;

        // xMin, yMin, xMax, yMax: Dimensions of the window in the PCX image.
        private int xMin;
        private int yMin;
        private int xMax;
        private int yMax;

        // bytesPerLine: Number of bytes per scanline in the PCX image.
        private int bytesPerLine;

        // pcxData: Byte array containing PCX image data.
        private byte[]? pcxData;

        // originalImage: Bitmap representing the original image.
        private Bitmap? originalImage;

        // redChannelImage, greenChannelImage, blueChannelImage: Bitmaps representing color channel images.
        private Bitmap? redChannelImage;
        private Bitmap? greenChannelImage;
        private Bitmap? blueChannelImage;

        // histogramPictureBox: PictureBox used for displaying histograms.
        private PictureBox? histogramPictureBox;

        // maxFrequencyIntensity: Intensity value that has the maximum count of pixels in a histogram.
        private int maxFrequencyIntensity = -1;

        // maxCount: Maximum count of pixels in a histogram.
        private int maxCount;

        // Create a new form to display the histogram
        Form histogramForm = new Form();
        public Form1()
        {
            InitializeComponent();
        }

        // ViewImage_Click event handler is triggered when the "View Image" button is clicked.
        private void ViewImage_Click(object sender, EventArgs e)
        {
            // Create an OpenFileDialog to allow the user to select an image file.
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                // Set the filter for allowed image file formats in the file dialog.
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.ico;*.tiff;*.jfif|All Files|*.*";
                openFileDialog.FilterIndex = 1;

                // Check if the user selects an image file and clicks "OK" in the file dialog.
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Get the path of the selected image file.
                    string selectedFilePath = openFileDialog.FileName;

                    try
                    {
                        // Clear any existing information and loaded images.
                        PCXheaderInfoBox.Controls.Clear();
                        PCXheaderInfoBox.Clear();

                        // Load the selected image and display it in the "ViewImage" PictureBox.
                        originalImage = new Bitmap(selectedFilePath);
                        ViewImage.Image = originalImage;

                        // Clear any previously displayed image channel and labels.
                        imageChannel.Image = null;
                        originalImageLabel.Text = "Original Image";
                        channelLabel.Text = null;
                        maxFrequency.Text = null;

                        // Set tooltips for the PictureBox and imageChannel PictureBox to show intensity information.
                        ToolTip toolTip = new ToolTip();
                        toolTip.SetToolTip(ViewImage, "Intensity: "); // Initial tooltip text for "ViewImage".
                        toolTip.SetToolTip(imageChannel, "Intensity: "); // Initial tooltip text for "imageChannel".
                    }
                    catch (Exception ex)
                    {
                        // Display an error message if there is an issue loading the image.
                        MessageBox.Show($"Error loading the image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        // ViewPCX_Click event handler is triggered when the "View PCX" button is clicked.
        private void ViewPCX_Click(object sender, EventArgs e)
        {
            // Create an OpenFileDialog to allow the user to select a PCX image file.
            using (OpenFileDialog openFileDialog_1 = new OpenFileDialog())
            {
                // Set the filter to allow only PCX image files in the file dialog.
                openFileDialog_1.Filter = "PCX Files|*.pcx";
                openFileDialog_1.FilterIndex = 1;

                // Check if the user selects a PCX image file and clicks "OK" in the file dialog.
                if (openFileDialog_1.ShowDialog() == DialogResult.OK)
                {
                    // Get the path of the selected PCX image file.
                    string selectedFilePath = openFileDialog_1.FileName;

                    try
                    {
                        // Read the PCX image file data into a byte array.
                        pcxData = File.ReadAllBytes(selectedFilePath);

                        // Initialize streams and readers for processing the PCX file.
                        using (MemoryStream pcxStream = new MemoryStream(pcxData))
                        using (BinaryReader pcxReader = new BinaryReader(pcxStream))
                        using (FileStream fileStream = new FileStream(selectedFilePath, FileMode.Open, FileAccess.Read))
                        {
                            // Clear any existing information and loaded images.
                            PCXheaderInfoBox.Clear();
                            originalImageLabel.Text = "Original PCX Image";
                            channelLabel.Text = null;
                            maxFrequency.Text = null;

                            // Read and display the PCX image header information.
                            byte[] header = new byte[128];
                            fileStream.Read(header, 0, 128);
                            PCX_DisplayHeaderInfo(header);

                            // Read and display the color palette information.
                            byte[] paletteData = new byte[768];
                            fileStream.Seek(-768, SeekOrigin.End);
                            fileStream.Read(paletteData, 0, 768);
                            PCX_DisplayPalette(paletteData);

                            // Extract image dimensions and calculate bytes per line.
                            int width = (header[8] - header[4]) + 1;
                            int height = (header[10] - header[6]) + 1;
                            int bytesPerLine = (int)Math.Ceiling(header[3] * width / 8.0);

                            // Initialize a Bitmap to store the PCX image.
                            originalImage = new Bitmap(width, height);

                            // Read and decode the RLE-encoded pixel data.
                            int pixelDataSize = pcxData.Length - 128 - 768;
                            byte[] compressedData = new byte[pixelDataSize];
                            fileStream.Seek(128, SeekOrigin.Begin); // Seek to the start of the pixel data
                            fileStream.Read(compressedData, 0, pixelDataSize);
                            byte[] decodedPixelData = DecodeRLE(compressedData);

                            // Create a Bitmap from the decoded pixel data and set pixel colors.
                            int index = 0;
                            for (int y = 0; y < height; y++)
                            {
                                for (int x = 0; x < width; x++)
                                {
                                    int colorIndex = decodedPixelData[index++];
                                    Color pixelColor = Color.FromArgb(paletteData[colorIndex * 3], paletteData[colorIndex * 3 + 1], paletteData[colorIndex * 3 + 2]);
                                    originalImage.SetPixel(x, y, pixelColor);
                                }
                            }

                            // Display the PCX image in the PictureBox control.
                            ViewImage.Image = originalImage;
                            imageChannel.Image = null; // Empty if there's a previously uploaded image.
                        }
                    }
                    catch (Exception ex)
                    {
                        // Display an error message if there is an issue loading the PCX image.
                        MessageBox.Show($"Error loading the file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        // PCX_DisplayHeaderInfo method displays header information of a PCX image.
        private void PCX_DisplayHeaderInfo(byte[] header)
        {
            // Determine the manufacturer based on the value in the PCX header.
            string manufacturer;
            if (header[0] == 10)
            {
                manufacturer = "Zsoft .pcx";
            }
            else
            {
                manufacturer = "";
            }

            // Extract and display header information in the PCXheaderInfoBox.
            bitsPerPixel = header[3];
            PCXheaderInfoBox.AppendText("PCX Header Information: " + Environment.NewLine + Environment.NewLine);
            PCXheaderInfoBox.AppendText($"Manufacturer: {manufacturer}" + Environment.NewLine);
            PCXheaderInfoBox.AppendText($"Version: {header[1]}" + Environment.NewLine);
            PCXheaderInfoBox.AppendText($"Encoding: {header[2]}" + Environment.NewLine);
            PCXheaderInfoBox.AppendText($"Bits Per Pixel: {bitsPerPixel}" + Environment.NewLine);

            // Extract and display image dimensions.
            xMin = BitConverter.ToInt16(header, 4);
            yMin = BitConverter.ToInt16(header, 6);
            xMax = BitConverter.ToInt16(header, 8);
            yMax = BitConverter.ToInt16(header, 10);
            PCXheaderInfoBox.AppendText($"Window Dimensions: {xMin} {yMin} {xMax} {yMax}" + Environment.NewLine);

            // Extract and display horizontal and vertical resolution (DPI).
            int hdpi = BitConverter.ToUInt16(header, 12);
            int vdpi = BitConverter.ToUInt16(header, 14);
            PCXheaderInfoBox.AppendText($"Horizontal Resolution (DPI): {hdpi}" + Environment.NewLine);
            PCXheaderInfoBox.AppendText($"Vertical Resolution (DPI): {vdpi}" + Environment.NewLine);

            // Extract and display colormap information.
            int colormap = BitConverter.ToUInt16(header, 16);
            PCXheaderInfoBox.AppendText($"Colormap: {colormap}" + Environment.NewLine);

            // Extract and display the number of color planes.
            int nplanes = header[65];
            PCXheaderInfoBox.AppendText($"Number of Color Planes: {nplanes}" + Environment.NewLine);

            // Extract and display bytes per line.
            bytesPerLine = BitConverter.ToUInt16(header, 66);
            PCXheaderInfoBox.AppendText($"Bytes Per Line: {bytesPerLine}" + Environment.NewLine);

            // Extract and display palette information.
            int paletteInfo = BitConverter.ToUInt16(header, 68);
            PCXheaderInfoBox.AppendText($"Palette Information: {paletteInfo}" + Environment.NewLine);

            // Extract and display horizontal and vertical screen sizes.
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

        // using RLE to decode the pixel data
        public static byte[] DecodeRLE(byte[] data)
        {
            using (MemoryStream decompressedStream = new MemoryStream())
            {
                int index = 0;
                int count;

                // traverse through pixel data to decompress
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

        // Handle the "Red" button click event to display the Red channel of the original image.
        private void Red_Click(object sender, EventArgs e)
        {
            if (originalImage != null)
            {
                maxFrequency.Text = null; // Clear the text in the maxFrequency label.
                redChannelImage = SplitChannel(originalImage, ColorChannel.Red); // Extract the Red channel from the original image and store it in redChannelImage.
                channelLabel.Text = "Red Channel"; // Update the label to indicate the currently displayed channel.
                histogramForm.Text = "Red Channel Histogram"; // Update the title of the histogramForm
                imageChannel.Image = redChannelImage; // Display the Red channel image in the imageChannel PictureBox.

                // Call the modified ShowHistogram method and get the histogram colors
                Color[] histogramColors = ShowHistogram(redChannelImage); // Call a modified ShowHistogram method to display the histogram for the Red channel.

                // Display information about the maximum pixel count in the maxFrequency label.
                maxFrequency.Text = "Intensity that has the Max Count of Pixels: " + maxFrequencyIntensity + "\r\nMax Count of Pixels: " + maxCount;
            }
        }

        // Handle the "Green" button click event to display the Green channel of the original image.
        private void Green_Click(object sender, EventArgs e)
        {
            if (originalImage != null)
            {
                maxFrequency.Text = null; // Clear the text in the maxFrequency label.
                greenChannelImage = SplitChannel(originalImage, ColorChannel.Green); // Extract the Green channel from the original image and store it in greenChannelImage.
                channelLabel.Text = "Green Channel"; // Update the label to indicate the currently displayed channel.
                histogramForm.Text = "Green Channel Histogram"; // Update the title of the histogramForm.
                imageChannel.Image = greenChannelImage; // Display the Green channel image in the imageChannel PictureBox.

                // Call the modified ShowHistogram method and get the histogram colors
                Color[] histogramColors = ShowHistogram(greenChannelImage);

                // Display information about the maximum pixel count in the maxFrequency label.
                maxFrequency.Text = "Intensity that has the Max Count of Pixels: " + maxFrequencyIntensity + "\r\nMax Count of Pixels: " + maxCount;
            }
        }

        // Handle the "Blue" button click event to display the Blue channel of the original image.
        private void Blue_Click(object sender, EventArgs e)
        {
            if (originalImage != null)
            {
                maxFrequency.Text = null; // Clear the text in the maxFrequency label.
                blueChannelImage = SplitChannel(originalImage, ColorChannel.Blue); // Extract the Blue channel from the original image and store it in blueChannelImage.
                channelLabel.Text = "Blue Channel"; // Update the label to indicate the currently displayed channel.
                imageChannel.Image = blueChannelImage; // Display the Blue channel image in the imageChannel PictureBox.

                // Call the modified ShowHistogram method and get the histogram colors
                Color[] histogramColors = ShowHistogram(blueChannelImage);

                // Display information about the maximum pixel count in the maxFrequency label.
                maxFrequency.Text = "Intensity that has the Max Count of Pixels: " + maxFrequencyIntensity + "\r\nMax Count of Pixels: " + maxCount;
            }
        }

        // SplitChannel method takes an input image and extracts a specific color channel (Red, Green, or Blue).
        // It returns a new Bitmap containing only the selected color channel while setting the others to zero.
        private Bitmap SplitChannel(Bitmap sourceImage, ColorChannel channel)
        {
            // Create a new Bitmap to store the extracted color channel with the same dimensions as the source image.
            Bitmap channelImage = new Bitmap(sourceImage.Width, sourceImage.Height);

            // Loop through each pixel in the source image.
            for (int x = 0; x < sourceImage.Width; x++)
            {
                for (int y = 0; y < sourceImage.Height; y++)
                {
                    Color pixel = sourceImage.GetPixel(x, y); // Get the color of the current pixel.

                    // Create a new pixel with the specified color channel set to its original value and others set to zero.
                    Color newPixel = Color.FromArgb(
                        channel == ColorChannel.Red ? pixel.R : 0,
                        channel == ColorChannel.Green ? pixel.G : 0,
                        channel == ColorChannel.Blue ? pixel.B : 0
                    );
                    // Set the corresponding pixel in the channelImage to the new pixel.
                    channelImage.SetPixel(x, y, newPixel);
                }
            }
            // Return the channelImage containing the extracted color channel.
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
            maxCount = histogram.Max();
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

        // Define an enumeration called ColorChannel to represent the three primary color channels.
        private enum ColorChannel
        {
            Red, // Represents the red color channel.
            Green, // Represents the green color channel.
            Blue // Represents the blue color channel.
        }

        // function for greyscale transformation
        private void Grayscale_Click(object sender, EventArgs e)
        {
            if (originalImage != null) // if an image is loaded
            {
                maxFrequency.Text = null; // remove color channel related text
                channelLabel.Text = "Grayscale Transformation";

                // store original in a separate variable
                Bitmap sourceImage = originalImage;

                // new bitmap for the grayscale image
                Bitmap grayscaleImage = new Bitmap(sourceImage.Width, sourceImage.Height);

                // iterate through each pixel
                for (int x = 0; x < sourceImage.Width; x++)
                {
                    for (int y = 0; y < sourceImage.Height; y++)
                    {
                        Color pixel = sourceImage.GetPixel(x, y); // get color of pixel
                        int grayValue = (int)(0.3 * pixel.R + 0.59 * pixel.G + 0.11 * pixel.B); // calculate grayscale value
                        grayscaleImage.SetPixel(x, y, Color.FromArgb(grayValue, grayValue, grayValue)); // set pixel w the grayscale value
                    }
                }

                // display the transformed image
                imageChannel.Image = grayscaleImage;

            }
        }

        // function for negative transformation 
        private void Negative_Click(object sender, EventArgs e)
        {
            if (originalImage != null) // if an image is loaded
            {
                maxFrequency.Text = null;  // remove color channel related text
                channelLabel.Text = "Negative Transformation";

                // store original in a separate variable
                Bitmap sourceImage = originalImage;

                // new bitmap for the negative image
                Bitmap negativeImage = new Bitmap(sourceImage.Width, sourceImage.Height);

                // iterate through each pixel
                for (int x = 0; x < sourceImage.Width; x++)
                {
                    for (int y = 0; y < sourceImage.Height; y++)
                    {
                        Color pixel = sourceImage.GetPixel(x, y); // get color
                        Color negativePixel = Color.FromArgb(255 - pixel.R, 255 - pixel.G, 255 - pixel.B); // calculate negative value
                        negativeImage.SetPixel(x, y, negativePixel); // set pixel w the negative value
                    }
                }

                // display the transformed image
                imageChannel.Image = negativeImage; 

            }
        }

        // function for black and white transformation
        private void BW_Scroll(object sender, EventArgs e)
        {
            if (originalImage != null) // if an image is loaded
            {
                maxFrequency.Text = null;  // remove color channel related text
                channelLabel.Text = "Black and White";
                int threshold = bw_trackbar.Value;

                // store original in a separate variable
                Bitmap sourceImage = originalImage;

                // new bitmap for the bw image
                Bitmap bw_image = new Bitmap(sourceImage.Width, sourceImage.Height);

                // iterate through each pixel
                for (int y = 0; y < sourceImage.Height; y++)
                {
                    for (int x = 0; x < sourceImage.Width; x++)
                    {
                        Color pixel = sourceImage.GetPixel(x, y); // get color

                        // calculate bw value
                        int average = (pixel.R + pixel.G + pixel.B) / 3;
                        Color bwColor = (average >= threshold) ? Color.White : Color.Black;

                        bw_image.SetPixel(x, y, bwColor); // set pixel w bw value
                    }
                }

                // display the transformed image
                imageChannel.Image = bw_image;
            }
        }

        // function for gamma transformation
        private void GammaTransform_Click(object sender, EventArgs e)
        {
            // if an image is loaded and gamma textbox is not empty
            if (originalImage != null && !string.IsNullOrEmpty(gamma_textbox.Text))
            {
                maxFrequency.Text = null;  // remove color channel related text
                channelLabel.Text = "Gamma Transformation";

                // store original in a separate variable
                Bitmap sourceImage = originalImage;

                // new bitmap for the gamma image
                Bitmap gamma_img = new Bitmap(sourceImage.Width, sourceImage.Height);

                // convert input string to float
                float gamma = float.Parse(gamma_textbox.Text);

                // iterate through each pixel
                for (int x = 0; x < sourceImage.Width; x++)
                {
                    for (int y = 0; y < sourceImage.Height; y++)
                    {
                        Color pixel = sourceImage.GetPixel(x, y); // get color

                        // calculate gamma value
                        int gray = (int)(0.299 * pixel.R + 0.587 * pixel.G + 0.114 * pixel.B);
                        int newGray = (int)(Math.Pow(gray / 255.0, gamma) * 255);
                        Color newPixel = Color.FromArgb(newGray, newGray, newGray);

                        gamma_img.SetPixel(x, y, newPixel); // set pixel with gamma value
                    }
                }

                // display the transformed image
                imageChannel.Image = gamma_img;
            }
        }

        // ensures that only numbers and one decimal point can be input in the gamma textbox
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            maxFrequency.Text = null; // remove color channel related text

            // only allow numbers and period
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

        // Button for Spatial Filtering
        private void spatialFiltering_Click(object sender, EventArgs e)
        {
            // Check if the originalImage has been loaded
            if (originalImage != null)
            {
                Bitmap sourceImage = originalImage; // Create a new Bitmap object to hold the source image
                Bitmap grayscaleImage = new Bitmap(sourceImage.Width, sourceImage.Height); // Create a new Bitmap object to hold the grayscale version of the source image

                // Loop through each pixel in the source image
                for (int x = 0; x < sourceImage.Width; x++)
                {
                    for (int y = 0; y < sourceImage.Height; y++)
                    {
                        Color pixel = sourceImage.GetPixel(x, y); // Get the color of the current pixel
                        int grayValue = (int)(0.3 * pixel.R + 0.59 * pixel.G + 0.11 * pixel.B); // Calculate the grayscale value for the pixel using the specified weights
                        grayscaleImage.SetPixel(x, y, Color.FromArgb(grayValue, grayValue, grayValue)); // Set the corresponding pixel in the grayscale image to the calculated gray value
                    }
                }

                Filtering spatialFiltering = new Filtering(grayscaleImage); // Create a new Filtering object with the grayscale image
                spatialFiltering.Text = "Spatial Filtering"; // Set the text for the spatialFiltering object
                spatialFiltering.displayGrayscaleImage(grayscaleImage); // Display the grayscale image using the displayGrayscaleImage method
                spatialFiltering.Show(); // Show the spatialFiltering form
            }
        }
    }
}