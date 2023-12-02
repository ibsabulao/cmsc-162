using System.Reflection.PortableExecutable;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using static System.Net.Mime.MediaTypeNames;
using System.Diagnostics.Metrics;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Image_Processing
{
    public partial class Form1 : Form
    {
        private byte bitsPerPixel;
        private int xMin;
        private int yMin;
        private int xMax;
        private int yMax;
        private int bytesPerLine;
        private byte[]? pcxData;
        private Bitmap? originalImage;
        private Bitmap? redChannelImage;
        private Bitmap? greenChannelImage;
        private Bitmap? blueChannelImage;
        private PictureBox? histogramPictureBox;
        private int maxFrequencyIntensity = -1;
        private int maxCount;
        private string? selectedFilePath;

        // Create a new form to display the histogram
        Form histogramForm = new Form();

        // Degraded image
        private Bitmap? degradedImg;

        public Form1()
        {
            InitializeComponent();
            imageLabel.Text = "";
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
                    selectedFilePath = openFileDialog.FileName;

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
                        degradedImg = null; // Empty if there's previous image.
                        originalImageLabel.Text = "Original Image";

                        // Set tooltips for the PictureBox and imageChannel PictureBox to show intensity information.
                        System.Windows.Forms.ToolTip toolTip = new System.Windows.Forms.ToolTip();
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
                    selectedFilePath = openFileDialog_1.FileName;

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
                            degradedImg = null; // Empty if there's previous image.
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
                imageLabel.Text = "Red Channel";
                redChannelImage = SplitChannel(originalImage, ColorChannel.Red); // Extract the Red channel from the original image and store it in redChannelImage.
                histogramForm.Text = "Red Channel Histogram"; // Update the title of the histogramForm
                imageChannel.Image = redChannelImage; // Display the Red channel image in the imageChannel PictureBox.

                // Call the modified ShowHistogram method and get the histogram colors
                Color[] histogramColors = ShowHistogram(redChannelImage); // Call a modified ShowHistogram method to display the histogram for the Red channel.
            }
        }

        // Handle the "Green" button click event to display the Green channel of the original image.
        private void Green_Click(object sender, EventArgs e)
        {
            if (originalImage != null)
            {
                imageLabel.Text = "Green Channel";
                greenChannelImage = SplitChannel(originalImage, ColorChannel.Green); // Extract the Green channel from the original image and store it in greenChannelImage.
                histogramForm.Text = "Green Channel Histogram"; // Update the title of the histogramForm.
                imageChannel.Image = greenChannelImage; // Display the Green channel image in the imageChannel PictureBox.

                // Call the modified ShowHistogram method and get the histogram colors
                Color[] histogramColors = ShowHistogram(greenChannelImage);
            }
        }

        // Handle the "Blue" button click event to display the Blue channel of the original image.
        private void Blue_Click(object sender, EventArgs e)
        {
            if (originalImage != null)
            {
                imageLabel.Text = "Blue Channel";
                blueChannelImage = SplitChannel(originalImage, ColorChannel.Blue); // Extract the Blue channel from the original image and store it in blueChannelImage.
                imageChannel.Image = blueChannelImage; // Display the Blue channel image in the imageChannel PictureBox.

                // Call the modified ShowHistogram method and get the histogram colors
                Color[] histogramColors = ShowHistogram(blueChannelImage);
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
                    // Determine the channel color
                    Color channelColor;
                    if (channelImage == redChannelImage)
                    {
                        channelColor = Color.Pink;
                    }
                    else if (channelImage == greenChannelImage)
                    {
                        channelColor = Color.LightGreen;
                    }
                    else if (channelImage == blueChannelImage)
                    {
                        channelColor = Color.LightBlue;
                    }
                    else
                    {
                        // If none of the three channels, use gray color
                        channelColor = Color.Gray;
                    }

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
                                    channelImage == greenChannelImage ? "Green Channel Histogram" :
                                    channelImage == blueChannelImage ? "Blue Channel Histogram" :
                                    "Histogram";

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
                imageLabel.Text = "Grayscale";
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
                imageLabel.Text = "Negative";
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
                imageLabel.Text = "Black and White";
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
                imageLabel.Text = "Gamma Transform";
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

        // ensures that only numbers, negative symbol, and one decimal point can be input in the gamma textbox
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // only allow numbers and period
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as System.Windows.Forms.TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            // only allow negative values in q value
            if (e.KeyChar == '-' && ((sender as System.Windows.Forms.TextBox) != qValue))
            {
                e.Handled = true;
            }

            // only allow - symbol at the start
            if (e.KeyChar == '-' && ((sender as System.Windows.Forms.TextBox).Text.Length > 0 || ((sender as System.Windows.Forms.TextBox).SelectionStart > 0)))
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

        // Event handler for the originalImage_Click event.
        private void originalImage_Click(object sender, EventArgs e)
        {
            // Display the original grayscale image in the originalGrayscale PictureBox.
            imageChannel.Image = originalImage;
        }

        // Button for Salt and Pepper Noise
        private void saltPepper_Click(object sender, EventArgs e)
        {
            double saltProbability;
            double pepperProbability;

            if (double.TryParse(this.saltProb.Text, out saltProbability) && double.TryParse(this.pepperProb.Text, out pepperProbability))
            {
                if (saltProbability <= 0.5 && pepperProbability <= 0.5)
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

                        // Set the label to indicate the applied noise
                        imageLabel.Text = "Salt-and-Pepper Noise";

                        int w = grayscaleImage.Width;
                        int h = grayscaleImage.Height;

                        BitmapData imageData = grayscaleImage.LockBits(
                            new Rectangle(0, 0, w, h),
                            ImageLockMode.ReadOnly,
                            PixelFormat.Format24bppRgb);

                        int bytes = imageData.Stride * imageData.Height;
                        byte[] buffer = new byte[bytes];
                        byte[] result = new byte[bytes];
                        Marshal.Copy(imageData.Scan0, buffer, 0, bytes);
                        grayscaleImage.UnlockBits(imageData);

                        Random rnd = new Random();
                        double unchangedProbability = 1 - (saltProbability + pepperProbability);

                        for (int i = 0; i < bytes; i += 3)
                        {
                            double rand = rnd.NextDouble();

                            if (rand < saltProbability)
                            {
                                // Salt noise
                                result[i] = 255; // R channel
                                result[i + 1] = 255; // G channel
                                result[i + 2] = 255; // B channel
                            }
                            else if (rand > (1 - pepperProbability))
                            {
                                // Pepper noise
                                result[i] = 0; // R channel
                                result[i + 1] = 0; // G channel
                                result[i + 2] = 0; // B channel
                            }
                            else
                            {
                                // Unchanged
                                result[i] = buffer[i];
                                result[i + 1] = buffer[i + 1];
                                result[i + 2] = buffer[i + 2];
                            }
                        }

                        Bitmap resultImage = new Bitmap(w, h);

                        BitmapData resultData = resultImage.LockBits(
                            new Rectangle(0, 0, w, h),
                            ImageLockMode.WriteOnly,
                            PixelFormat.Format24bppRgb);

                        Marshal.Copy(result, 0, resultData.Scan0, bytes);
                        resultImage.UnlockBits(resultData);

                        // Display the image with salt and pepper noise
                        imageChannel.Image = resultImage;
                        // Store degraded image in separate variable for restoration
                        degradedImg = resultImage;
                        ShowHistogram(resultImage);
                    }
                }
                else if (saltProbability >= 0.6 || pepperProbability >= 0.6)
                {
                    MessageBox.Show("Salt and Pepper Noise probabilities must be less than or equal to 0.5.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Display a message if parsing fails (empty or non-numeric input)
                MessageBox.Show("Please enter valid numeric values for Salt and Pepper Noise probabilities.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gaussianNoise_Click(object sender, EventArgs e)
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

                // Set the label to indicate the applied noise
                imageLabel.Text = "Salt-and-Pepper Noise";

                int w = grayscaleImage.Width;
                int h = grayscaleImage.Height;

                BitmapData imageData = grayscaleImage.LockBits(
                    new Rectangle(0, 0, w, h),
                    ImageLockMode.ReadOnly,
                    PixelFormat.Format24bppRgb);

                int bytes = imageData.Stride * imageData.Height;
                byte[] buffer = new byte[bytes];
                byte[] result = new byte[bytes];
                Marshal.Copy(imageData.Scan0, buffer, 0, bytes);
                grayscaleImage.UnlockBits(imageData);

                Random rnd = new Random();

                // Set the parameters for Gaussian noise
                double mean = 0; // Mean of the Gaussian distribution
                double stdDev = 25; // Standard deviation of the Gaussian distribution

                for (int i = 0; i < bytes; i += 3)
                {
                    // Generate random values from a Gaussian distribution
                    double gaussianValue = GenerateGaussianNoise(rnd, mean, stdDev);

                    // Add Gaussian noise to the pixel value
                    int noisyValue = buffer[i] + (int)gaussianValue;

                    // Ensure that the noisy value is within the valid range [0, 255]
                    noisyValue = Math.Max(0, Math.Min(255, noisyValue));

                    // Assign the noisy value to the result
                    result[i] = (byte)noisyValue;
                    result[i + 1] = (byte)noisyValue;
                    result[i + 2] = (byte)noisyValue;
                }

                // Create a new image with the noisy data
                Bitmap resultImage = new Bitmap(w, h);
                BitmapData resultData = resultImage.LockBits(
                    new Rectangle(0, 0, w, h),
                    ImageLockMode.WriteOnly,
                    PixelFormat.Format24bppRgb);

                // Copy the noisy data to the result image
                Marshal.Copy(result, 0, resultData.Scan0, bytes);
                resultImage.UnlockBits(resultData);

                // Display the image with salt and pepper noise
                imageChannel.Image = resultImage;
                // Store degraded image in separate variable for restoration
                degradedImg = resultImage;
                ShowHistogram(resultImage);
            }
        }

        // Function to generate random values from a Gaussian distribution
        private double GenerateGaussianNoise(Random rand, double mean, double stdDev)
        {
            double u1 = 1.0 - rand.NextDouble();
            double u2 = 1.0 - rand.NextDouble();
            double randStdNormal = Math.Sqrt(-2.0 * Math.Log(u1)) * Math.Sin(2.0 * Math.PI * u2);
            return mean + stdDev * randStdNormal;
        }

        private void rayleighNoise_Click(object sender, EventArgs e)
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

                // Set the label to indicate the applied noise
                imageLabel.Text = "Rayleigh Noise";

                int w = grayscaleImage.Width;
                int h = grayscaleImage.Height;

                BitmapData imageData = grayscaleImage.LockBits(
                    new Rectangle(0, 0, w, h),
                    ImageLockMode.ReadOnly,
                    PixelFormat.Format24bppRgb);

                int bytes = imageData.Stride * imageData.Height;
                byte[] buffer = new byte[bytes];
                byte[] result = new byte[bytes];
                Marshal.Copy(imageData.Scan0, buffer, 0, bytes);
                grayscaleImage.UnlockBits(imageData);

                Random rnd = new Random();

                // Set the parameter for Rayleigh noise
                double scale = 25; // Scale parameter for the Rayleigh distribution

                for (int i = 0; i < bytes; i += 3)
                {
                    // Generate random values from a Rayleigh distribution
                    double rayleighValue = GenerateRayleighNoise(rnd, scale);

                    // Add Rayleigh noise to the pixel value
                    int noisyValue = (int)(buffer[i] + rayleighValue);

                    // Ensure that the noisy value is within the valid range [0, 255]
                    noisyValue = Math.Max(0, Math.Min(255, noisyValue));

                    // Assign the noisy value to the result
                    result[i] = (byte)noisyValue;
                    result[i + 1] = (byte)noisyValue;
                    result[i + 2] = (byte)noisyValue;
                }

                Bitmap resultImage = new Bitmap(w, h);

                BitmapData resultData = resultImage.LockBits(
                    new Rectangle(0, 0, w, h),
                    ImageLockMode.WriteOnly,
                    PixelFormat.Format24bppRgb);

                Marshal.Copy(result, 0, resultData.Scan0, bytes);
                resultImage.UnlockBits(resultData);

                // Display the image with Rayleigh noise
                imageChannel.Image = resultImage;
                // Store degraded image in separate variable for restoration
                degradedImg = resultImage;
                ShowHistogram(resultImage);
            }
        }

        // Function to generate random values from a Rayleigh distribution
        private double GenerateRayleighNoise(Random rand, double scale)
        {
            double u = rand.NextDouble();
            return scale * Math.Sqrt(-2.0 * Math.Log(1 - u));
        }

        static Bitmap ApplyGeometricMeanFilter(Bitmap originalImage)
        {
            int width = originalImage.Width;
            int height = originalImage.Height;

            Bitmap restoredImage = new Bitmap(width, height);

            int filterSize = 3;

            for (int i = 1; i < width - 1; i++)
            {
                for (int j = 1; j < height - 1; j++)
                {
                    double product = 1.0;

                    // Calculate the geometric mean of the neighboring pixels
                    for (int x = -1; x <= 1; x++)
                    {
                        for (int y = -1; y <= 1; y++)
                        {
                            Color pixel = originalImage.GetPixel(i + x, j + y);
                            double grayValue = (pixel.R + pixel.G + pixel.B) / 3.0 / 255.0; // Convert to grayscale

                            product *= grayValue;
                        }
                    }

                    // Take the nth root of the product, where n is the total number of pixels in the filter
                    double geometricMean = Math.Pow(product, 1.0 / (filterSize * filterSize));

                    // Set the restored pixel value
                    int restoredPixelValue = (int)(geometricMean * 255.0);
                    Color restoredColor = Color.FromArgb(restoredPixelValue, restoredPixelValue, restoredPixelValue);
                    restoredImage.SetPixel(i, j, restoredColor);
                }
            }

            return restoredImage;
        }

        static Bitmap ApplyContraharmonicMeanFilter(Bitmap originalImage, double q)
        {
            int width = originalImage.Width;
            int height = originalImage.Height;

            Bitmap filteredImage = new Bitmap(width, height);

            // Define the filter window size (e.g., 3x3)
            int filterSize = 3;

            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    // Apply the filter to each pixel
                    double numerator = 0;
                    double denominator = 0;

                    for (int i = -filterSize / 2; i <= filterSize / 2; i++)
                    {
                        for (int j = -filterSize / 2; j <= filterSize / 2; j++)
                        {
                            int neighborX = Math.Max(0, Math.Min(width - 1, x + i));
                            int neighborY = Math.Max(0, Math.Min(height - 1, y + j));

                            Color neighborPixel = originalImage.GetPixel(neighborX, neighborY);
                            double pixelValue = neighborPixel.R; // Assuming grayscale image

                            numerator += Math.Pow(pixelValue, q + 1);
                            denominator += Math.Pow(pixelValue, q);
                        }
                    }

                    // Update the pixel value in the filtered image
                    int filteredPixelValue = (int)(numerator / denominator);
                    filteredPixelValue = Math.Max(0, Math.Min(255, filteredPixelValue)); // Ensure the value is within the valid range

                    Color filteredColor = Color.FromArgb(filteredPixelValue, filteredPixelValue, filteredPixelValue);
                    filteredImage.SetPixel(x, y, filteredColor);
                }
            }

            return filteredImage;
        }

        static Bitmap ApplyMedianFilter(Bitmap inputImage)
        {
            int width = inputImage.Width;
            int height = inputImage.Height;
            Bitmap outputImage = new Bitmap(width, height);

            // Define a 3x3 median filter kernel
            int[,] medianFilterKernel = {
            {1, 1, 1},
            {1, 1, 1},
            {1, 1, 1}
        };

            // Apply the median filter
            for (int x = 1; x < width - 1; x++)
            {
                for (int y = 1; y < height - 1; y++)
                {
                    int medianPixelValue = GetMedianPixelValue(inputImage, x, y, medianFilterKernel);
                    outputImage.SetPixel(x, y, Color.FromArgb(medianPixelValue, medianPixelValue, medianPixelValue));
                }
            }

            return outputImage;
        }

        static int GetMedianPixelValue(Bitmap image, int x, int y, int[,] kernel)
        {
            int[] pixelValues = new int[9]; // Array to store pixel values in the neighborhood

            int index = 0;
            for (int i = -1; i <= 1; i++)
            {
                for (int j = -1; j <= 1; j++)
                {
                    Color pixel = image.GetPixel(x + i, y + j);
                    int pixelValue = (int)(pixel.R * 0.3 + pixel.G * 0.59 + pixel.B * 0.11); // Convert to grayscale

                    // Apply the kernel
                    pixelValue *= kernel[i + 1, j + 1];

                    // Store the pixel value in the array
                    pixelValues[index] = pixelValue;
                    index++;
                }
            }

            // Sort the array and return the median value
            Array.Sort(pixelValues);
            return pixelValues[4]; // 4 is the index of the median value in a 3x3 neighborhood
        }

        static Bitmap ApplyMinFilter(Bitmap inputImage)
        {
            int width = inputImage.Width;
            int height = inputImage.Height;
            Bitmap outputImage = new Bitmap(width, height);

            // Define a 3x3 min filter kernel
            int[,] minFilterKernel = {
            {1, 1, 1},
            {1, 1, 1},
            {1, 1, 1}
        };

            // Apply the min filter
            for (int x = 1; x < width - 1; x++)
            {
                for (int y = 1; y < height - 1; y++)
                {
                    int minPixelValue = GetMinPixelValue(inputImage, x, y, minFilterKernel);
                    outputImage.SetPixel(x, y, Color.FromArgb(minPixelValue, minPixelValue, minPixelValue));
                }
            }

            return outputImage;
        }

        static int GetMinPixelValue(Bitmap image, int x, int y, int[,] kernel)
        {
            int minPixelValue = 255; // Initialize to maximum possible value (for grayscale images)

            for (int i = -1; i <= 1; i++)
            {
                for (int j = -1; j <= 1; j++)
                {
                    Color pixel = image.GetPixel(x + i, y + j);
                    int pixelValue = (int)(pixel.R * 0.3 + pixel.G * 0.59 + pixel.B * 0.11); // Convert to grayscale

                    // Apply the kernel
                    pixelValue *= kernel[i + 1, j + 1];

                    // Update the minimum pixel value
                    minPixelValue = Math.Min(minPixelValue, pixelValue);
                }
            }

            return minPixelValue;
        }

        static Bitmap ApplyMaxFilter(Bitmap inputImage)
        {
            int width = inputImage.Width;
            int height = inputImage.Height;
            Bitmap outputImage = new Bitmap(width, height);

            // Define a 3x3 max filter kernel
            int[,] maxFilterKernel = {
            {1, 1, 1},
            {1, 1, 1},
            {1, 1, 1}
        };

            // Apply the max filter
            for (int x = 1; x < width - 1; x++)
            {
                for (int y = 1; y < height - 1; y++)
                {
                    int maxPixelValue = GetMaxPixelValue(inputImage, x, y, maxFilterKernel);
                    outputImage.SetPixel(x, y, Color.FromArgb(maxPixelValue, maxPixelValue, maxPixelValue));
                }
            }

            return outputImage;
        }

        static int GetMaxPixelValue(Bitmap image, int x, int y, int[,] kernel)
        {
            int maxPixelValue = 0; // Initialize to minimum possible value (for grayscale images)

            for (int i = -1; i <= 1; i++)
            {
                for (int j = -1; j <= 1; j++)
                {
                    Color pixel = image.GetPixel(x + i, y + j);
                    int pixelValue = (int)(pixel.R * 0.3 + pixel.G * 0.59 + pixel.B * 0.11); // Convert to grayscale

                    // Apply the kernel
                    pixelValue *= kernel[i + 1, j + 1];

                    // Update the maximum pixel value
                    maxPixelValue = Math.Max(maxPixelValue, pixelValue);
                }
            }

            return maxPixelValue;
        }

        static Bitmap ApplyMidpointFilter(Bitmap inputImage)
        {
            int width = inputImage.Width;
            int height = inputImage.Height;
            Bitmap outputImage = new Bitmap(width, height);

            // Define a 3x3 midpoint filter kernel
            int[,] midpointFilterKernel = {
            {1, 1, 1},
            {1, 1, 1},
            {1, 1, 1}
        };

            // Apply the midpoint filter
            for (int x = 1; x < width - 1; x++)
            {
                for (int y = 1; y < height - 1; y++)
                {
                    int midpointPixelValue = GetMidpointPixelValue(inputImage, x, y, midpointFilterKernel);
                    outputImage.SetPixel(x, y, Color.FromArgb(midpointPixelValue, midpointPixelValue, midpointPixelValue));
                }
            }

            return outputImage;
        }

        static int GetMidpointPixelValue(Bitmap image, int x, int y, int[,] kernel)
        {
            int[] pixelValues = new int[9]; // Array to store pixel values in the neighborhood

            int index = 0;
            for (int i = -1; i <= 1; i++)
            {
                for (int j = -1; j <= 1; j++)
                {
                    Color pixel = image.GetPixel(x + i, y + j);
                    int pixelValue = (int)(pixel.R * 0.3 + pixel.G * 0.59 + pixel.B * 0.11); // Convert to grayscale

                    // Apply the kernel
                    pixelValue *= kernel[i + 1, j + 1];

                    // Store the pixel value in the array
                    pixelValues[index] = pixelValue;
                    index++;
                }
            }

            // Find the minimum and maximum pixel values
            int minValue = pixelValues.Min();
            int maxValue = pixelValues.Max();

            // Calculate the midpoint value
            int midpointValue = (minValue + maxValue) / 2;

            return midpointValue;
        }

        private void geometricFilter_Click(object sender, EventArgs e)
        {
            if (originalImage != null)
            {
                if (degradedImg == null)
                {
                    degradedImg = originalImage;
                }
                Bitmap geometric = ApplyGeometricMeanFilter(degradedImg);
                imageChannel.Image = geometric;
            }
        }

        private void contraHarmonicFilter_Click(object sender, EventArgs e)
        {
            if (originalImage != null)
            {
                if (degradedImg == null)
                {
                    degradedImg = originalImage;
                }
                if (string.IsNullOrEmpty(qValue.Text))
                {
                    MessageBox.Show("Please input valid Q value.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Bitmap contraharmonic = ApplyContraharmonicMeanFilter(degradedImg, double.Parse(qValue.Text));
                    imageChannel.Image = contraharmonic;
                }
            }
        }

        private void minFilter_Click(object sender, EventArgs e)
        {
            if (originalImage != null)
            {
                if (degradedImg == null)
                {
                    degradedImg = originalImage;
                }
                Bitmap min = ApplyMinFilter(degradedImg);
                imageChannel.Image = min;
            }
        }

        private void maxFilter_Click(object sender, EventArgs e)
        {
            if (originalImage != null)
            {
                if (degradedImg == null)
                {
                    degradedImg = originalImage;
                }
                Bitmap max = ApplyMaxFilter(degradedImg);
                imageChannel.Image = max;
            }
        }

        private void medianFilter_Click(object sender, EventArgs e)
        {
            if (originalImage != null)
            {
                if (degradedImg == null)
                {
                    degradedImg = originalImage;
                }
                Bitmap median = ApplyMedianFilter(degradedImg);
                imageChannel.Image = median;
            }
        }

        private void midpointFilter_Click(object sender, EventArgs e)
        {
            if (originalImage != null)
            {
                if (degradedImg == null)
                {
                    degradedImg = originalImage;
                }
                Bitmap midpoint = ApplyMidpointFilter(degradedImg);
                imageChannel.Image = midpoint;
            }
        }

        // ---------------- RLE COMPRESSION ----------------

        private void RLECompression_click(object sender, EventArgs e)
        {
            if (originalImage != null && selectedFilePath != null && pcxData != null)
            {
                // Display the original grayscale image in the originalGrayscale PictureBox.
                imageChannel.Image = originalImage;

                string imagePath = selectedFilePath;

                // Read the image file into a byte array
                byte[] imageData = File.ReadAllBytes(imagePath);

                // Perform RLE compression on pixel data
                byte[] compressedData = DecodeRLE(pcxData);

                // Display the compression ratio
                double compressionRatio = (double)pcxData.Length / compressedData.Length;

                MessageBox.Show($"Compression complete!\nOriginal Size: {pcxData.Length} bytes\nCompressed Size: {compressedData.Length} bytes\nCompression Ratio: {compressionRatio:F2}\n",
                        "RLE Compression Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (originalImage != null && selectedFilePath != null)
            {
                // Display the original grayscale image in the originalGrayscale PictureBox.
                imageChannel.Image = originalImage;

                string imagePath = selectedFilePath;

                // Read the image file into a byte array
                byte[] imageData = File.ReadAllBytes(imagePath);

                // Perform RLE compression on pixel data
                byte[] compressedData = CompressRLE(imageData);

                // Display the compression ratio
                double compressionRatio = (double)imageData.Length / compressedData.Length;

                MessageBox.Show($"Compression complete!\nOriginal Size: {imageData.Length} bytes\nCompressed Size: {compressedData.Length} bytes\nCompression Ratio: {compressionRatio:F2}\n",
                        "Compression Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private byte[] CompressRLE(byte[] data)
        {
            using (MemoryStream compressedStream = new MemoryStream())
            {
                int index = 0;
                int n = data.Length;

                while (index < n)
                {
                    byte currentByte = data[index];
                    int runLength = 1;

                    // Check for a run of identical bytes (pixels)
                    while (index < n - 1 && data[index + 1] == currentByte && runLength < 255)
                    {
                        runLength++;
                        index++;
                    }

                    // Write the run to the compressed stream
                    compressedStream.WriteByte((byte)runLength);
                    compressedStream.WriteByte(currentByte);

                    // Move to the next pixel
                    index++;
                }

                return compressedStream.ToArray();
            }
        }

        // ---------------- HUFFMAN CODING COMPRESSION ----------------
        private void huffmanCompression_Click(object sender, EventArgs e)
        {
            if (originalImage != null && pcxData != null)
            {
                // Display the original grayscale image in the originalGrayscale PictureBox.
                imageChannel.Image = originalImage;

                // Perform Huffman compression on pixel data
                byte[] compressedData = CompressHuffman(pcxData);

                // Display the compression ratio
                double compressionRatio = (double)pcxData.Length / compressedData.Length;

                MessageBox.Show($"Compression complete!\nOriginal Size: {pcxData.Length} bytes\nCompressed Size: {compressedData.Length} bytes\nCompression Ratio: {compressionRatio:F2}",
                        "Compression Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (originalImage != null && selectedFilePath != null)
            {
                // Display the original grayscale image in the originalGrayscale PictureBox.
                imageChannel.Image = originalImage;

                string imagePath = selectedFilePath;

                // Read the image file into a byte array
                byte[] imageData = File.ReadAllBytes(imagePath);

                // Perform Huffman compression on pixel data
                byte[] compressedData = CompressHuffman(imageData);

                // Display the compression ratio
                double compressionRatio = (double)imageData.Length / compressedData.Length;

                MessageBox.Show($"Compression complete!\nOriginal Size: {imageData.Length} bytes\nCompressed Size: {compressedData.Length} bytes\nCompression Ratio: {compressionRatio:F2}",
                        "Compression Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private byte[] CompressHuffman(byte[] data)
        {
            // Step 1: Calculate frequencies
            Dictionary<byte, int> frequencies = CalculateFrequencies(data);

            // Step 2: Build Huffman tree
            HuffmanNode root = BuildHuffmanTree(frequencies);

            // Step 3: Build encoding table
            Dictionary<byte, string> encodingTable = BuildEncodingTable(root);

            // Step 4: Encode data
            List<string> encodedDataList = new List<string>();
            foreach (byte symbol in data)
            {
                encodedDataList.Add(encodingTable[symbol]);
            }

            string encodedData = string.Join("", encodedDataList);

            // Step 5: Convert encoded data to bytes
            byte[] compressedData = ConvertToBytes(encodedData);

            return compressedData;
        }

        private static Dictionary<byte, int> CalculateFrequencies(byte[] data)
        {
            Dictionary<byte, int> frequencies = new Dictionary<byte, int>();

            foreach (byte symbol in data)
            {
                if (frequencies.ContainsKey(symbol))
                {
                    frequencies[symbol]++;
                }
                else
                {
                    frequencies[symbol] = 1;
                }
            }

            return frequencies;
        }

        private static HuffmanNode BuildHuffmanTree(Dictionary<byte, int> frequencies)
        {
            PriorityQueue<HuffmanNode> priorityQueue = new PriorityQueue<HuffmanNode>();

            foreach (var kvp in frequencies)
            {
                priorityQueue.Enqueue(new HuffmanNode(kvp.Key, kvp.Value));
            }

            while (priorityQueue.Count > 1)
            {
                HuffmanNode left = priorityQueue.Dequeue();
                HuffmanNode right = priorityQueue.Dequeue();
                HuffmanNode mergedNode = new HuffmanNode(left.Frequency + right.Frequency, left, right);
                priorityQueue.Enqueue(mergedNode);
            }

            return priorityQueue.Dequeue();
        }

        private static Dictionary<byte, string> BuildEncodingTable(HuffmanNode root)
        {
            Dictionary<byte, string> encodingTable = new Dictionary<byte, string>();
            BuildEncodingTableRecursive(root, "", encodingTable);
            return encodingTable;
        }

        private static void BuildEncodingTableRecursive(HuffmanNode node, string currentCode, Dictionary<byte, string> encodingTable)
        {
            if (node.Symbol.HasValue)
            {
                encodingTable[node.Symbol.Value] = currentCode;
            }
            else
            {
                BuildEncodingTableRecursive(node.Left, currentCode + "0", encodingTable);
                BuildEncodingTableRecursive(node.Right, currentCode + "1", encodingTable);
            }
        }

        private static byte[] ConvertToBytes(string encodedData)
        {
            int numBytes = (int)Math.Ceiling(encodedData.Length / 8.0);
            byte[] result = new byte[numBytes];

            for (int i = 0; i < numBytes; i++)
            {
                int startIndex = i * 8;
                int endIndex = Math.Min(startIndex + 8, encodedData.Length);
                string byteString = encodedData.Substring(startIndex, endIndex - startIndex).PadRight(8, '0');
                result[i] = Convert.ToByte(byteString, 2);
            }

            return result;
        }

        public class PriorityQueue<T> where T : IComparable<T>
        {
            private List<T> heap;

            public int Count => heap.Count;

            public PriorityQueue()
            {
                heap = new List<T>();
            }

            public void Enqueue(T item)
            {
                heap.Add(item);
                int currentIndex = heap.Count - 1;

                while (currentIndex > 0)
                {
                    int parentIndex = (currentIndex - 1) / 2;
                    if (heap[currentIndex].CompareTo(heap[parentIndex]) >= 0)
                    {
                        break;
                    }

                    Swap(currentIndex, parentIndex);
                    currentIndex = parentIndex;
                }
            }

            public T Dequeue()
            {
                if (heap.Count == 0)
                {
                    throw new InvalidOperationException("Priority queue is empty.");
                }

                T result = heap[0];
                heap[0] = heap[heap.Count - 1];
                heap.RemoveAt(heap.Count - 1);

                int currentIndex = 0;
                while (true)
                {
                    int leftChildIndex = currentIndex * 2 + 1;
                    int rightChildIndex = currentIndex * 2 + 2;

                    if (leftChildIndex >= heap.Count)
                    {
                        break;
                    }

                    int smallerChildIndex = leftChildIndex;
                    if (rightChildIndex < heap.Count && heap[rightChildIndex].CompareTo(heap[leftChildIndex]) < 0)
                    {
                        smallerChildIndex = rightChildIndex;
                    }

                    if (heap[currentIndex].CompareTo(heap[smallerChildIndex]) <= 0)
                    {
                        break;
                    }

                    Swap(currentIndex, smallerChildIndex);
                    currentIndex = smallerChildIndex;
                }

                return result;
            }

            private void Swap(int index1, int index2)
            {
                T temp = heap[index1];
                heap[index1] = heap[index2];
                heap[index2] = temp;
            }
        }

        public class HuffmanNode : IComparable<HuffmanNode>
        {
            public byte? Symbol { get; set; }
            public int Frequency { get; set; }
            public HuffmanNode Left { get; set; }
            public HuffmanNode Right { get; set; }

            public HuffmanNode(byte? symbol, int frequency)
            {
                Symbol = symbol;
                Frequency = frequency;
            }

            public HuffmanNode(int frequency, HuffmanNode left, HuffmanNode right)
            {
                Frequency = frequency;
                Left = left;
                Right = right;
            }

            public int CompareTo(HuffmanNode other)
            {
                return Frequency - other.Frequency;
            }
        }
    }
}