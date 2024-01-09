using System.Reflection.PortableExecutable;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using static System.Net.Mime.MediaTypeNames;
using System.Diagnostics.Metrics;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Reflection.Emit;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms.DataVisualization.Charting;
using Image = System.Drawing.Image;

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
        private Bitmap? foregroundImage;
        private Bitmap? editedImage;
        private int maxFrequencyIntensity = -1;
        private int maxCount;
        private string? selectedFilePath;
        private string? imageFileName;
        private string imagesPath;
        private string processedFolder;
        private string[] imageFiles;
        private Chart histogramChart;

        private List<Bitmap> processedImages = new List<Bitmap>(); // Declare a list to store processed images
        private List<Bitmap> addColorImages = new List<Bitmap>();
        private List<Bitmap> addImageImages = new List<Bitmap>();

        private bool isNightMode = false;

        // Degraded image
        private Bitmap? degradedImg;
        private Bitmap? originalGrayImage; // Field to store the original grayscale image.

        public void hideFeaturesPanels()
        {
            Panel_Enhancement.Visible = false;
            Panel_Spatial.Visible = false;
            Panel_RestoreDegrade.Visible = false;
        }

        public void changeButtonColor()
        {
            Button_SpatialFiltering.BackColor = SystemColors.ScrollBar;
            Button_BasicEnhancement.BackColor = SystemColors.ControlLightLight;
            Button_RestoreDegrade.BackColor = SystemColors.ScrollBar;
        }

        public void hideEditedImages()
        {
            Panel_CompressedImage.Visible = false;
            Panel_EditedImage.Visible = false;
            Panel_DisplaySpatial.Visible = false;
            Panel_BatchProcessing.Visible = false;
        }

        public void clearSpatialPictureBox()
        {
            PBox_Image1.Image = null;
            PBox_Image2.Image = null;
            PBox_Image3.Image = null;
            PBox_Image4.Image = null;
        }

        public void hideCloseButton()
        {
            imageNameLabel.Text = string.Empty;
            imageNamePanel.Visible = false;
            closeImage.Visible = false;
        }

        public Form1()
        {
            InitializeComponent();
            Load += new EventHandler(MainForm_Load);

            // Features Panels
            Panel_Spatial.Location = Panel_imageEnhancement.Location;
            Panel_Enhancement.Location = Panel_imageEnhancement.Location;
            Panel_RestoreDegrade.Location = Panel_imageEnhancement.Location;

            Panel_Spatial.Dock = DockStyle.Fill;
            Panel_Enhancement.Dock = DockStyle.Fill;
            Panel_RestoreDegrade.Dock = DockStyle.Fill;

            // Dispay Image Panels
            Panel_CompressedImage.Location = Panel_EditedImage.Location;
            Panel_DisplaySpatial.Location = Panel_EditedImage.Location;
            Panel_BatchProcessing.Location = Panel_EditedImage.Location;

            imageChannel.MouseMove += Control_MouseMove;

            InitializeHistogramChart();
            Form histogramForm = new Form();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            hideFeaturesPanels();
            hideEditedImages();
            hideCloseButton();
            changeButtonColor();

            imageChannel.Visible = true;
            Panel_Enhancement.Visible = true;
            Label_Feature.Text = "Image Enhancement";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minWindows_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void modeToggleButton_Click(object sender, EventArgs e)
        {
            // Toggle between night and light mode
            isNightMode = !isNightMode;

            // Update the UI based on the selected mode
            UpdateUI();
        }

        private void UpdateUI()
        {
            if (isNightMode)
            {
                // Night mode settings
                this.BackColor = Color.FromArgb(30, 30, 30);

                tableLayoutPanel1.BackColor = Color.FromArgb(30, 30, 30);
                menuStrip1.BackColor = Color.FromArgb(52, 52, 52);
                displayOriginalPanel.BackColor = Color.FromArgb(56, 56, 56);
                headerinfoPanel.BackColor = Color.FromArgb(56, 56, 56);
                ViewImage.BackColor = Color.FromArgb(56, 56, 56);
                PCXheaderInfoBox.BackColor = Color.FromArgb(56, 56, 56);

                pixelInfoPanel.BackColor = Color.FromArgb(56, 56, 56);
                imageNamePanel.BackColor = Color.FromArgb(56, 56, 56);
                closeImage.BackColor = Color.FromArgb(56, 56, 56);
                tabPanel.BackColor = Color.FromArgb(42, 42, 42);
                editPanel.BackColor = Color.FromArgb(30, 30, 30);
                imageChannel.BackColor = Color.FromArgb(30, 30, 30);
                backgroundButtons.BackColor = Color.FromArgb(56, 56, 56);
                compressionButtons.BackColor = Color.FromArgb(56, 56, 56);
                otherButtons.BackColor = Color.FromArgb(56, 56, 56);
                buttonsPanel.BackColor = Color.FromArgb(30, 30, 30);
                buttonsSection.BackColor = Color.FromArgb(30, 30, 30);

                // Features Panel
                Panel_FeatureButton.BackColor = Color.FromArgb(30, 30, 30);
                featuresPanel.BackColor = Color.FromArgb(30, 30, 30);
                Panel_FeatureName.BackColor = Color.FromArgb(56, 56, 56);
                Panel_ShowNoiseHistogram.BackColor = Color.FromArgb(56, 56, 56);
                allFeaturesPanel.BackColor = Color.FromArgb(30, 30, 30);
                mainFeatures.BackColor = Color.FromArgb(30, 30, 30);

                // RGB Channels
                Panel_Histogram.BackColor = Color.FromArgb(56, 56, 56);
                Panel_HistogramContainer.BackColor = Color.FromArgb(56, 56, 56);
                Panel_Enhancement.BackColor = Color.FromArgb(56, 56, 56);

                Table_RGBChannel.BackColor = Color.FromArgb(56, 56, 56);
                Table_Gray.BackColor = Color.FromArgb(56, 56, 56);
                Table_BW.BackColor = Color.FromArgb(56, 56, 56);
                bw_trackbar.BackColor = Color.FromArgb(56, 56, 56);
                Table_Gamma.BackColor = Color.FromArgb(56, 56, 56);
                Table_ShowHistogram.BackColor = Color.FromArgb(56, 56, 56);

                Label_RGBChannel.ForeColor = SystemColors.ControlLight;
                Label_Grayscale.ForeColor = SystemColors.ControlLight;
                Label_BW.ForeColor = SystemColors.ControlLight;
                Label_BWAdjust.ForeColor = SystemColors.ControlLight;
                Label_Gamma.ForeColor = SystemColors.ControlLight;
                Label_GammaValues.ForeColor = SystemColors.ControlLight;
                Label_Feature.ForeColor = SystemColors.ControlLight;
                Label_Histogram.ForeColor = SystemColors.ControlLight;

                // Spatial Filtering
                Panel_Spatial.BackColor = Color.FromArgb(56, 56, 56);
                Panel_SmoothChannels.BackColor = Color.FromArgb(56, 56, 56);
                Panel_SharpeningFilter.BackColor = Color.FromArgb(56, 56, 56);
                Panel_Gradient.BackColor = Color.FromArgb(56, 56, 56);

                Label_Smooth.ForeColor = SystemColors.ControlLight;
                Label_Sharpening.ForeColor = SystemColors.ControlLight;
                Label_Gradient.ForeColor = SystemColors.ControlLight;

                Panel_Laplacian.BackColor = Color.FromArgb(56, 56, 56);
                Label_Laplacian.ForeColor = SystemColors.ControlLight;
                Label_Laplacian1.ForeColor = SystemColors.ControlLight;
                Label_Laplacian2.ForeColor = SystemColors.ControlLight;
                Label_Laplacian3.ForeColor = SystemColors.ControlLight;

                Table_SmoothChannels.BackColor = Color.FromArgb(56, 56, 56);
                Table_SharpeningFilter.BackColor = Color.FromArgb(56, 56, 56);
                Table_Gradient.BackColor = Color.FromArgb(56, 56, 56);

                // Image Degradation
                Label_Degrade.ForeColor = SystemColors.ControlLight;
                Label_Salt.ForeColor = SystemColors.ControlLight;
                Label_Pepper.ForeColor = SystemColors.ControlLight;
                Label_Restoration.ForeColor = SystemColors.ControlLight;
                Label_Q.ForeColor = SystemColors.ControlLight;
                Label_OrderStat.ForeColor = SystemColors.ControlLight;
                Label_NoiseHistogram.ForeColor = SystemColors.ControlLight;

                Panel_RestoreDegrade.BackColor = Color.FromArgb(56, 56, 56);
                Panel_NoiseHistogram.BackColor = Color.FromArgb(56, 56, 56);

                Table_Degrade.BackColor = Color.FromArgb(56, 56, 56);
                Table_Restoration.BackColor = Color.FromArgb(56, 56, 56);
                Table_NoiseHistogram.BackColor = Color.FromArgb(56, 56, 56);

                // Palette
                paletteDisplay.BackColor = Color.FromArgb(56, 56, 56);
                colorPalettePanel.BackColor = Color.FromArgb(56, 56, 56);

                redPixel.ForeColor = Color.FromArgb(170, 170, 170);
                greenPixel.ForeColor = Color.FromArgb(170, 170, 170);
                bluePixel.ForeColor = Color.FromArgb(170, 170, 170);

                // Light Mode
                darkLightMode.BackColor = Color.White;

                // Menu
                menuStrip1.BackColor = Color.FromArgb(52, 52, 52);
                menuStrip1.RenderMode = ToolStripRenderMode.Professional;
                menuStrip1.Renderer = new MyRenderer(); // Custom renderer for hover and select colors

                // Menu > File
                openImageFileToolStripMenuItem.BackColor = Color.FromArgb(52, 52, 52);
                openPCXFileToolStripMenuItem.BackColor = Color.FromArgb(52, 52, 52);

                menuStrip1.ForeColor = Color.White;
                openImageFileToolStripMenuItem.ForeColor = Color.White;
                openPCXFileToolStripMenuItem.ForeColor = Color.White;

                openImageFileToolStripMenuItem.Image = Properties.Resources.open_light;
                openPCXFileToolStripMenuItem.Image = Properties.Resources.openpcx_light;

                originalImageLabel.ForeColor = Color.FromArgb(212, 212, 212);
                headerInfoLabel.ForeColor = Color.FromArgb(212, 212, 212);
                PCXheaderInfoBox.ForeColor = Color.FromArgb(170, 170, 170);
                colorPalette.ForeColor = Color.FromArgb(170, 170, 170);
                pixelInfo.ForeColor = Color.FromArgb(170, 170, 170);
                imageNameLabel.ForeColor = Color.White;
                editPanel.ForeColor = Color.White;

                darkLightMode.Image = Properties.Resources.lightmode;
            }
            else
            {
                // Light mode settings
                this.BackColor = SystemColors.ControlLight;

                tableLayoutPanel1.BackColor = SystemColors.ControlLight;
                menuStrip1.BackColor = Color.WhiteSmoke;
                displayOriginalPanel.BackColor = SystemColors.ControlLightLight;
                headerinfoPanel.BackColor = SystemColors.ControlLightLight;
                ViewImage.BackColor = SystemColors.ControlLightLight;
                PCXheaderInfoBox.BackColor = SystemColors.ControlLightLight;

                pixelInfoPanel.BackColor = SystemColors.ControlLightLight;
                imageNamePanel.BackColor = SystemColors.ControlLightLight;
                closeImage.BackColor = SystemColors.ControlLightLight;
                tabPanel.BackColor = SystemColors.Control;
                editPanel.BackColor = SystemColors.ControlLight;
                imageChannel.BackColor = SystemColors.ControlLight;
                backgroundButtons.BackColor = SystemColors.ControlLightLight;
                compressionButtons.BackColor = SystemColors.ControlLightLight;
                otherButtons.BackColor = SystemColors.ControlLightLight;
                buttonsPanel.BackColor = SystemColors.ControlLight;
                buttonsSection.BackColor = SystemColors.ControlLight;

                // Features Panel
                Panel_FeatureButton.BackColor = SystemColors.ControlLight;
                featuresPanel.BackColor = SystemColors.ControlLight;
                Panel_FeatureName.BackColor = SystemColors.ControlLightLight;
                Panel_ShowNoiseHistogram.BackColor = SystemColors.ControlLightLight;
                allFeaturesPanel.BackColor = SystemColors.ControlLight;
                mainFeatures.BackColor = SystemColors.ControlLight;

                // RGB Channels
                Panel_Histogram.BackColor = SystemColors.ControlLightLight;
                Panel_HistogramContainer.BackColor = SystemColors.ControlLightLight;
                Panel_Enhancement.BackColor = SystemColors.ControlLightLight;

                Table_RGBChannel.BackColor = SystemColors.ControlLightLight;
                Table_Gray.BackColor = SystemColors.ControlLightLight;
                Table_BW.BackColor = SystemColors.ControlLightLight;
                Table_Gamma.BackColor = SystemColors.ControlLightLight;
                Table_ShowHistogram.BackColor = SystemColors.ControlLightLight;

                Label_RGBChannel.ForeColor = Color.Black;
                Label_Grayscale.ForeColor = Color.Black;
                Label_BW.ForeColor = Color.Black;
                Label_BWAdjust.ForeColor = Color.Black;
                Label_Gamma.ForeColor = Color.Black;
                Label_GammaValues.ForeColor = Color.Black;
                Label_Feature.ForeColor = Color.Black;
                Label_Histogram.ForeColor = Color.Black;

                // Spatial Filtering
                Panel_Spatial.BackColor = SystemColors.ControlLightLight;
                Panel_SmoothChannels.BackColor = SystemColors.ControlLightLight;
                Panel_SharpeningFilter.BackColor = SystemColors.ControlLightLight;
                Panel_Gradient.BackColor = SystemColors.ControlLightLight;

                Label_Smooth.ForeColor = Color.Black;
                Label_Sharpening.ForeColor = Color.Black;
                Label_Gradient.ForeColor = Color.Black;

                Panel_Laplacian.BackColor = SystemColors.ControlLightLight;
                Label_Laplacian.ForeColor = Color.Black;
                Label_Laplacian1.ForeColor = Color.Black;
                Label_Laplacian2.ForeColor = Color.Black;
                Label_Laplacian3.ForeColor = Color.Black;

                Table_SmoothChannels.BackColor = SystemColors.ControlLightLight;
                Table_SharpeningFilter.BackColor = SystemColors.ControlLightLight;
                Table_Gradient.BackColor = SystemColors.ControlLightLight;

                // Image Degradation
                Label_Degrade.ForeColor = Color.Black;
                Label_Salt.ForeColor = Color.Black;
                Label_Pepper.ForeColor = Color.Black;
                Label_Restoration.ForeColor = Color.Black;
                Label_Q.ForeColor = Color.Black;
                Label_OrderStat.ForeColor = Color.Black;
                Label_NoiseHistogram.ForeColor = Color.Black;

                Panel_RestoreDegrade.BackColor = SystemColors.ControlLightLight;
                Panel_NoiseHistogram.BackColor = SystemColors.ControlLightLight;

                Table_Degrade.BackColor = SystemColors.ControlLightLight;
                Table_Restoration.BackColor = SystemColors.ControlLightLight;
                Table_NoiseHistogram.BackColor = SystemColors.ControlLightLight;

                // Palette
                paletteDisplay.BackColor = SystemColors.ControlLightLight;
                colorPalettePanel.BackColor = SystemColors.ControlLightLight;

                redPixel.ForeColor = Color.FromArgb(170, 170, 170);
                greenPixel.ForeColor = Color.FromArgb(170, 170, 170);
                bluePixel.ForeColor = Color.FromArgb(170, 170, 170);

                // Light Mode
                darkLightMode.BackColor = Color.Black;

                // Menu
                menuStrip1.BackColor = Color.WhiteSmoke;
                menuStrip1.RenderMode = ToolStripRenderMode.Professional;
                menuStrip1.Renderer = new MyRenderer(); // Custom renderer for hover and select colors

                // Menu > File
                openImageFileToolStripMenuItem.BackColor = SystemColors.Control;
                openPCXFileToolStripMenuItem.BackColor = SystemColors.Control;

                menuStrip1.ForeColor = Color.Black;
                openImageFileToolStripMenuItem.ForeColor = Color.Black;
                openPCXFileToolStripMenuItem.ForeColor = Color.Black;

                openImageFileToolStripMenuItem.Image = Properties.Resources.open;
                openPCXFileToolStripMenuItem.Image = Properties.Resources.openpcx;

                originalImageLabel.ForeColor = Color.Black;
                headerInfoLabel.ForeColor = Color.Black;
                PCXheaderInfoBox.ForeColor = Color.Black;
                colorPalette.ForeColor = Color.Black;
                pixelInfo.ForeColor = Color.Black;
                imageNameLabel.ForeColor = Color.Black;
                editPanel.ForeColor = Color.Black;

                darkLightMode.Image = Properties.Resources.darkmode_light;
                // Reset other controls or settings modified for night mode
            }
        }

        // Custom renderer class to set hover and select colors
        public class MyRenderer : ToolStripProfessionalRenderer
        {
            public MyRenderer() : base(new MyColors()) { }

            private class MyColors : ProfessionalColorTable
            {
                private Color GradientStartColor { get; } = Color.FromArgb(90, 90, 90);
                private Color GradientEndColor { get; } = Color.FromArgb(50, 50, 50);
                public override Color MenuItemBorder { get; } = Color.FromArgb(90, 90, 90);
                public override Color MenuItemPressedGradientBegin { get; } = Color.FromArgb(90, 90, 90);
                public override Color MenuItemPressedGradientEnd { get; } = Color.FromArgb(90, 90, 90);
                public override Color MenuItemSelected => GradientStartColor;
                public override Color MenuItemSelectedGradientBegin => GradientStartColor;
                public override Color MenuItemSelectedGradientEnd => GradientEndColor;
            }
        }

        // ViewImage_Click event handler is triggered when the "View Image" button is clicked.
        private void ViewImage_Click(object sender, EventArgs e)
        {
            hideEditedImages();
            Panel_EditedImage.Visible = true;

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
                        PCXheaderInfoBox.Clear();

                        if (paletteDisplay.Controls != null)
                        {
                            paletteDisplay.Controls.Clear();
                        }

                        // Extract the filename and extension from the selected file path.
                        string fileName = Path.GetFileName(selectedFilePath);
                        string fileExtension = Path.GetExtension(selectedFilePath);

                        originalImageLabel.Text = "Original Image";

                        // Load the selected image and display it in the "ViewImage" PictureBox.
                        originalImage = new Bitmap(selectedFilePath);
                        ViewImage.Image = originalImage;

                        // Clear any previously displayed image channel and labels.
                        if (editedImage != null)
                        {
                            editedImage = null;
                        }

                        clearSpatialPictureBox();
                        imageChannel.Image = null;
                        degradedImg = null; // Empty if there's previous image.

                        hideCloseButton();
                        closeImage.Visible = true;
                        imageNamePanel.Visible = true;

                        // Now you can use 'fileName' and 'fileExtension' as needed.
                        if (isNightMode)
                        {
                            imageNamePanel.ForeColor = Color.White;
                        }
                        imageNameLabel.Text = $"{fileName}";
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
            hideEditedImages();
            Panel_EditedImage.Visible = true;

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
                        // Extract the filename and extension from the selected file path.
                        string fileName = Path.GetFileName(selectedFilePath);
                        string fileExtension = Path.GetExtension(selectedFilePath);

                        // Read the PCX image file data into a byte array.
                        pcxData = File.ReadAllBytes(selectedFilePath);

                        // Initialize streams and readers for processing the PCX file.
                        using (MemoryStream pcxStream = new MemoryStream(pcxData))
                        using (BinaryReader pcxReader = new BinaryReader(pcxStream))
                        using (FileStream fileStream = new FileStream(selectedFilePath, FileMode.Open, FileAccess.Read))
                        {
                            PCXheaderInfoBox.Clear();

                            if (paletteDisplay.Controls != null)
                            {
                                paletteDisplay.Controls.Clear();
                            }

                            originalImageLabel.Text = "Original Image";

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
                            if (editedImage != null)
                            {
                                editedImage = null;
                            }

                            clearSpatialPictureBox();
                            ViewImage.Image = originalImage;
                            imageChannel.Image = null; // Empty if there's a previously uploaded image.
                            degradedImg = null; // Empty if there's previous image.

                            hideCloseButton();
                            closeImage.Visible = true;
                            imageNamePanel.Visible = true;

                            // Now you can use 'fileName' and 'fileExtension' as needed.
                            imageNameLabel.Text = $"{fileName}";
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

        // MouseMove event for controls
        private void Control_MouseMove(object sender, MouseEventArgs e)
        {
            // Get the screen coordinates of the mouse relative to the control
            Point relativeMousePos = ((Control)sender).PointToScreen(e.Location);

            // Get the color of the pixel at the mouse position on the screen
            Color pixelColor = GetPixelColorAt(relativeMousePos);

            // Display the pixel information in the label or any other control you want
            redPixel.Text = $"{pixelColor.R}";
            greenPixel.Text = $"{pixelColor.G}";
            bluePixel.Text = $"{pixelColor.B}";

            // Update the displayColor PictureBox with the color of the hovered pixel
            displayColor.BackColor = pixelColor;
        }

        private Color GetPixelColorAt(Point location)
        {
            // Get the color of the pixel at the specified location on the screen
            using (Bitmap screen = new Bitmap(1, 1))
            {
                using (Graphics g = Graphics.FromImage(screen))
                {
                    g.CopyFromScreen(location, Point.Empty, new Size(1, 1));
                }

                return screen.GetPixel(0, 0);
            }
        }

        private void FlipHorizontalButton_Click(object sender, EventArgs e)
        {
            hideEditedImages();
            Panel_EditedImage.Visible = true;

            // Check if an image is loaded
            if (originalImage == null)
            {
                return;
            }

            if (editedImage != null)
            {
                // Flip the image horizontally
                editedImage = FlipImage(editedImage, true, false);
            }
            else if (editedImage == null && originalImage != null)
            {
                // Flip the image horizontally
                editedImage = FlipImage(originalImage, true, false);
            }

            imageChannel.Image = editedImage;
        }

        private void FlipVerticalButton_Click(object sender, EventArgs e)
        {
            hideEditedImages();
            Panel_EditedImage.Visible = true;

            // Check if an image is loaded
            if (originalImage == null)
            {
                return;
            }

            if (editedImage != null)
            {
                // Flip the image vertically
                editedImage = FlipImage(editedImage, false, true);
            }
            else if (editedImage == null && originalImage != null)
            {
                // Flip the image vertically
                editedImage = FlipImage(originalImage, false, true);
            }

            imageChannel.Image = editedImage;
        }

        private Bitmap FlipImage(Bitmap image, bool flipHorizontal, bool flipVertical)
        {
            hideEditedImages();
            Panel_EditedImage.Visible = true;

            editedImage = new Bitmap(image.Width, image.Height);

            using (Graphics g = Graphics.FromImage(editedImage))
            {
                if (flipHorizontal)
                {
                    g.DrawImage(image, new Rectangle(image.Width, 0, -image.Width, image.Height),
                                new Rectangle(0, 0, image.Width, image.Height), GraphicsUnit.Pixel);
                }
                else if (flipVertical)
                {
                    g.DrawImage(image, new Rectangle(0, image.Height, image.Width, -image.Height),
                                new Rectangle(0, 0, image.Width, image.Height), GraphicsUnit.Pixel);
                }
            }

            return editedImage;
        }

        private void RotateClockwiseButton_Click(object sender, EventArgs e)
        {
            hideEditedImages();
            Panel_EditedImage.Visible = true;

            // Check if an image is loaded
            if (originalImage == null)
            {
                return;
            }

            if (editedImage != null)
            {
                // Rotate the image 90 degrees clockwise
                editedImage = RotateImage(editedImage, RotateFlipType.Rotate90FlipNone);
            }
            else if (editedImage == null && originalImage != null)
            {
                // Rotate the image 90 degrees clockwise
                editedImage = RotateImage(originalImage, RotateFlipType.Rotate90FlipNone);
            }

            imageChannel.Image = editedImage;
        }

        private void RotateCounterClockwiseButton_Click(object sender, EventArgs e)
        {
            hideEditedImages();
            Panel_EditedImage.Visible = true;

            // Check if an image is loaded
            if (originalImage == null)
            {
                return;
            }

            if (editedImage != null)
            {
                // Rotate the image 90 degrees counter-clockwise
                editedImage = RotateImage(editedImage, RotateFlipType.Rotate270FlipNone);
            }
            else if (editedImage == null && originalImage != null)
            {
                // Rotate the image 90 degrees counter-clockwise
                editedImage = RotateImage(originalImage, RotateFlipType.Rotate270FlipNone);
            }

            imageChannel.Image = editedImage;
        }

        private Bitmap RotateImage(Bitmap image, RotateFlipType rotateFlipType)
        {
            hideEditedImages();
            Panel_EditedImage.Visible = true;

            editedImage = (Bitmap)image.Clone();
            editedImage.RotateFlip(rotateFlipType);
            return editedImage;
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
            PCXheaderInfoBox.AppendText($"Vertical Screen Size: {vscreenSize}");
        }


        private void PCX_DisplayPalette(byte[] paletteData)
        {
            int paletteSize = paletteData.Length / 3;
            int paletteWidth = 10;
            int paletteHeight = 10;

            int rows = (int)Math.Ceiling((double)paletteSize / 16); // Assuming 16 colors per row

            for (int i = 0; i < paletteSize; i++)
            {
                int r = paletteData[i * 3];
                int g = paletteData[i * 3 + 1];
                int b = paletteData[i * 3 + 2];

                // Create a color square
                Panel colorSquare = new Panel();
                colorSquare.BackColor = Color.FromArgb(r, g, b);
                colorSquare.Size = new Size(paletteWidth, paletteHeight);

                // Calculate the center position within paletteDisplay
                int centerX = (paletteDisplay.Width - (16 * paletteWidth)) / 2;
                int centerY = (paletteDisplay.Height - (rows * paletteHeight)) / 2;

                // Calculate the position of the color square within the grid
                int gridX = i % 16;
                int gridY = i / 16;

                // Set the location of the color square
                colorSquare.Location = new Point(centerX + gridX * paletteWidth, centerY + gridY * paletteHeight);

                // Add the color square to the palettePanel
                paletteDisplay.Controls.Add(colorSquare);
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

        // ---------------------- HISTOGRAM ----------------------
        private void InitializeHistogramChart()
        {
            histogramChart = new Chart();
            histogramChart.Dock = DockStyle.Fill;
            histogramChart.Series.Clear();
            histogramChart.ChartAreas.Add("Histogram");
            histogramChart.ChartAreas["Histogram"].AxisX.Title = "Intensity Level";
            histogramChart.ChartAreas["Histogram"].AxisY.Title = "Frequency";

            Series redSeries = new Series("Red");
            Series greenSeries = new Series("Green");
            Series blueSeries = new Series("Blue");
            Series overallSeries = new Series("Overall");

            redSeries.ChartType = SeriesChartType.Column;
            greenSeries.ChartType = SeriesChartType.Column;
            blueSeries.ChartType = SeriesChartType.Column;
            overallSeries.ChartType = SeriesChartType.Column;

            histogramChart.Series.Add(redSeries);
            histogramChart.Series.Add(greenSeries);
            histogramChart.Series.Add(blueSeries);
            histogramChart.Series.Add(overallSeries);

            this.Controls.Add(histogramChart);
        }

        // Handle the "Red" button click event to display the Red channel of the original image.
        private void Red_Click(object sender, EventArgs e)
        {
            hideEditedImages();
            Panel_EditedImage.Visible = true;

            // Check if an image is loaded
            if (originalImage == null)
            {
                return;
            }

            if (editedImage != null)
            {
                redChannelImage = SplitChannel(editedImage, ColorChannel.Red); // Extract the Red channel from the original image and store it in redChannelImage.
                imageChannel.Image = redChannelImage; // Display the Red channel image in the imageChannel PictureBox.
                editedImage = redChannelImage;

                DisplayHistogram(ColorChannel.Red);
            }
            else if (editedImage == null && originalImage != null)
            {
                redChannelImage = SplitChannel(originalImage, ColorChannel.Red); // Extract the Red channel from the original image and store it in redChannelImage.
                imageChannel.Image = redChannelImage; // Display the Red channel image in the imageChannel PictureBox.
                editedImage = redChannelImage;

                DisplayHistogram(ColorChannel.Red);
            }
        }

        // Handle the "Green" button click event to display the Green channel of the original image.
        private void Green_Click(object sender, EventArgs e)
        {
            if (editedImage != null)
            {
                greenChannelImage = SplitChannel(editedImage, ColorChannel.Green); // Extract the Green channel from the original image and store it in greenChannelImage.
                imageChannel.Image = greenChannelImage; // Display the Green channel image in the imageChannel PictureBox.
                editedImage = greenChannelImage;

                DisplayHistogram(ColorChannel.Green);
            }
            else if (editedImage == null && originalImage != null)
            {
                greenChannelImage = SplitChannel(originalImage, ColorChannel.Green); // Extract the Green channel from the original image and store it in greenChannelImage.
                imageChannel.Image = greenChannelImage; // Display the Green channel image in the imageChannel PictureBox.
                editedImage = greenChannelImage;

                DisplayHistogram(ColorChannel.Green);
            }
        }

        // Handle the "Blue" button click event to display the Blue channel of the original image.
        private void Blue_Click(object sender, EventArgs e)
        {
            if (editedImage != null)
            {
                blueChannelImage = SplitChannel(editedImage, ColorChannel.Blue); // Extract the Blue channel from the original image and store it in blueChannelImage.
                imageChannel.Image = blueChannelImage; // Display the Blue channel image in the imageChannel PictureBox.
                editedImage = blueChannelImage;

                DisplayHistogram(ColorChannel.Blue);
            }
            else if (editedImage == null && originalImage != null)
            {
                blueChannelImage = SplitChannel(originalImage, ColorChannel.Blue); // Extract the Blue channel from the original image and store it in blueChannelImage.
                imageChannel.Image = blueChannelImage; // Display the Blue channel image in the imageChannel PictureBox.
                editedImage = blueChannelImage;

                DisplayHistogram(ColorChannel.Blue);
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

        private void DisplayHistogram(ColorChannel channel)
        {
            Bitmap image = (Bitmap)imageChannel.Image;

            // Clear all chart series
            foreach (var series in histogramChart.Series)
            {
                series.Points.Clear();
            }

            if (image != null)
            {
                int[] histogram = Calculate(image, channel);

                switch (channel)
                {
                    case ColorChannel.Red:
                        histogramChart.Series["Red"].Points.Clear();

                        for (int i = 0; i < histogram.Length; i++)
                        {
                            histogramChart.Series["Red"].Points.AddXY(i, histogram[i]);
                        }
                        break;

                    case ColorChannel.Green:
                        histogramChart.Series["Green"].Points.Clear();

                        for (int i = 0; i < histogram.Length; i++)
                        {
                            histogramChart.Series["Green"].Points.AddXY(i, histogram[i]);
                        }
                        break;

                    case ColorChannel.Blue:
                        histogramChart.Series["Blue"].Points.Clear();

                        for (int i = 0; i < histogram.Length; i++)
                        {
                            histogramChart.Series["Blue"].Points.AddXY(i, histogram[i]);
                        }
                        break;
                }

                var chart = histogramChart;
                chart.Parent = Panel_HistogramContainer;
                // Optionally clear the panel after some time or user interaction
                ClearPanelAfterDelay(chart, Panel_HistogramContainer, TimeSpan.FromSeconds(10));
            }
        }

        private void ClearPanelAfterDelay(Chart chart, Panel panel, TimeSpan delay)
        {
            Task.Delay(delay).ContinueWith(_ =>
            {
                // Clear the panel after the specified delay
                chart.Parent = null;
            }, TaskScheduler.FromCurrentSynchronizationContext());
        }

        private void DisplayOverallHistogram(Bitmap image)
        {
            // Clear all chart series
            foreach (var series in histogramChart.Series)
            {
                series.Points.Clear();
            }

            if (image != null)
            {
                int[] overallHistogram = CalculateOverallHistogram(image);

                // Display overall histogram
                histogramChart.Series["Overall"].Points.Clear();
                for (int i = 0; i < overallHistogram.Length; i++)
                {
                    histogramChart.Series["Overall"].Points.AddXY(i, overallHistogram[i]);
                }

                var chart = histogramChart;
                chart.Parent = Panel_ShowNoiseHistogram;
            }
        }

        private int[] Calculate(Bitmap image, ColorChannel channel)
        {
            int[] histogram = new int[256];
            for (int x = 0; x < image.Width; x++)
            {
                for (int y = 0; y < image.Height; y++)
                {
                    Color pixelColor = image.GetPixel(x, y);
                    int intensity = 0;

                    switch (channel)
                    {
                        case ColorChannel.Red:
                            intensity = pixelColor.R;
                            break;
                        case ColorChannel.Green:
                            intensity = pixelColor.G;
                            break;
                        case ColorChannel.Blue:
                            intensity = pixelColor.B;
                            break;
                    }

                    histogram[intensity]++;
                }
            }
            return histogram;
        }

        private int[] CalculateOverallHistogram(Bitmap image)
        {
            int[] overallHistogram = new int[256];
            for (int x = 0; x < image.Width; x++)
            {
                for (int y = 0; y < image.Height; y++)
                {
                    Color pixelColor = image.GetPixel(x, y);
                    int intensity = (pixelColor.R + pixelColor.G + pixelColor.B) / 3; // Calculate overall intensity

                    overallHistogram[intensity]++;
                }
            }
            return overallHistogram;
        }

        // Define an enumeration called ColorChannel to represent the three primary color channels.
        private enum ColorChannel
        {
            Red, // Represents the red color channel.
            Green, // Represents the green color channel.
            Blue // Represents the blue color channel.
        }

        // ------------------ Grayscale ------------------------
        private void Grayscale_Click(object sender, EventArgs e)
        {

            // Check if an image is loaded
            if (originalImage == null)
            {
                return;
            }

            if (editedImage != null)
            {
                // store original in a separate variable
                Bitmap sourceImage = editedImage;

                Grayscale(sourceImage);
            }
            else if (editedImage == null && originalImage != null)
            {
                Bitmap sourceImage = originalImage;

                Grayscale(sourceImage);
            }
        }

        private void Grayscale(Bitmap image)
        {
            // new bitmap for the grayscale image
            Bitmap grayscaleImage = new Bitmap(image.Width, image.Height);

            // iterate through each pixel
            for (int x = 0; x < image.Width; x++)
            {
                for (int y = 0; y < image.Height; y++)
                {
                    Color pixel = image.GetPixel(x, y); // get color of pixel
                    int grayValue = (int)(0.3 * pixel.R + 0.59 * pixel.G + 0.11 * pixel.B); // calculate grayscale value
                    grayscaleImage.SetPixel(x, y, Color.FromArgb(grayValue, grayValue, grayValue)); // set pixel w the grayscale value
                }
            }

            // display the transformed image
            imageChannel.Image = grayscaleImage;
            editedImage = grayscaleImage;
        }

        // ------------------ Negative ------------------------
        private void Negative_Click(object sender, EventArgs e)
        {

            // Check if an image is loaded
            if (originalImage == null)
            {
                return;
            }

            if (editedImage != null)
            {
                // store original in a separate variable
                Bitmap sourceImage = editedImage;

                Negative(sourceImage);
            }
            else if (editedImage == null && originalImage != null)
            {
                // store original in a separate variable
                Bitmap sourceImage = originalImage;

                Negative(sourceImage);
            }
        }

        private void Negative(Bitmap image)
        {
            // new bitmap for the negative image
            Bitmap negativeImage = new Bitmap(image.Width, image.Height);

            // iterate through each pixel
            for (int x = 0; x < image.Width; x++)
            {
                for (int y = 0; y < image.Height; y++)
                {
                    Color pixel = image.GetPixel(x, y); // get color
                    Color negativePixel = Color.FromArgb(255 - pixel.R, 255 - pixel.G, 255 - pixel.B); // calculate negative value
                    negativeImage.SetPixel(x, y, negativePixel); // set pixel w the negative value
                }
            }

            // display the transformed image
            imageChannel.Image = negativeImage;
            editedImage = negativeImage;
        }

        // ------------------ BLACK AND WHITE ------------------------
        private void BW_Scroll(object sender, EventArgs e)
        {

            if (originalImage == null)
            {
                return;
            }

            int threshold = bw_trackbar.Value;

            if (editedImage != null)
            {
                // store original in a separate variable
                Bitmap sourceImage = originalImage;

                BlackWhite(sourceImage, threshold);
            }
            else if (editedImage == null && originalImage != null)
            {
                // store original in a separate variable
                Bitmap sourceImage = originalImage;

                BlackWhite(sourceImage, threshold);
            }
        }

        private void BlackWhite(Bitmap image, int threshold)
        {
            // new bitmap for the bw image
            Bitmap bw_image = new Bitmap(image.Width, image.Height);

            // iterate through each pixel
            for (int y = 0; y < image.Height; y++)
            {
                for (int x = 0; x < image.Width; x++)
                {
                    Color pixel = image.GetPixel(x, y); // get color

                    // calculate bw value
                    int average = (pixel.R + pixel.G + pixel.B) / 3;
                    Color bwColor = (average >= threshold) ? Color.White : Color.Black;

                    bw_image.SetPixel(x, y, bwColor); // set pixel w bw value
                }
            }

            // display the transformed image
            imageChannel.Image = bw_image;
            editedImage = bw_image;
        }

        // function for gamma transformation
        private void GammaTransform_Click(object sender, EventArgs e)
        {


            // if an image is loaded and gamma textbox is not empty
            if (originalImage != null && !string.IsNullOrEmpty(gamma_textbox.Text))
            {
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
            hideEditedImages();
            Panel_DisplaySpatial.Visible = true;

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
                        DisplayOverallHistogram(resultImage);
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
                DisplayOverallHistogram(resultImage);
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
                DisplayOverallHistogram(resultImage);
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
            hideEditedImages();
            Panel_CompressedImage.Visible = true;

            if (originalImage != null && selectedFilePath != null && pcxData != null)
            {
                // Display the original image
                showOriginal.Image = originalImage;
                showCompressed.Image = originalImage;

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
                showOriginal.Image = originalImage;
                showCompressed.Image = originalImage;

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
            hideEditedImages();
            Panel_CompressedImage.Visible = true;

            if (originalImage != null && pcxData != null)
            {
                // Display the original grayscale image in the originalGrayscale PictureBox.
                showOriginal.Image = originalImage;
                showCompressed.Image = originalImage;

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
                showOriginal.Image = originalImage;
                showCompressed.Image = originalImage;

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

        // ------------------- FINAL PROJECT: BACKGROUND REMOVAL ----------------
        private Color selectedBackgroundColor = Color.White; // Default background color

        private void SaveImagesToFolder(List<Bitmap> images)
        {
            try
            {
                using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
                {
                    folderBrowserDialog.Description = "Select a folder to save the images";
                    DialogResult result = folderBrowserDialog.ShowDialog();

                    if (result == DialogResult.OK)
                    {
                        string baseFolderPath = folderBrowserDialog.SelectedPath;

                        // Create the folder if it doesn't exist
                        Directory.CreateDirectory(baseFolderPath);

                        // Save each image in the selected folder
                        for (int i = 0; i < images.Count; i++)
                        {
                            string filePath = Path.Combine(baseFolderPath, $"Image_{i + 1}.png"); // You can adjust the filename as needed
                            images[i].Save(filePath, ImageFormat.Png);
                        }

                        MessageBox.Show($"Images saved successfully to {baseFolderPath}.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving images: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void BatchProcessImages_Click(object sender, EventArgs e)
        {
            processedImages.Clear();

            // Clear the existing PictureBox controls in flowLayoutPanelImages
            flowLayoutPanelImages.Controls.Clear();

            hideEditedImages();
            Panel_BatchProcessing.Visible = true;

            // Show folder browser dialog to allow the user to choose a folder
            using (FolderBrowserDialog folderBrowser = new FolderBrowserDialog())
            {
                DialogResult result = folderBrowser.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowser.SelectedPath))
                {
                    // Load images from the selected folder
                    LoadImagesFromFolder(folderBrowser.SelectedPath);
                }
            }

            SaveImagesToFolder(processedImages);
        }

        private void LoadImagesFromFolder(string folderPath)
        {
            try
            {
                // Get all files with supported image extensions from the folder
                imageFiles = Directory.GetFiles(folderPath, "*.*", SearchOption.TopDirectoryOnly)
                    .Where(s => s.EndsWith(".png", StringComparison.OrdinalIgnoreCase) ||
                                s.EndsWith(".jpg", StringComparison.OrdinalIgnoreCase) ||
                                s.EndsWith(".jpeg", StringComparison.OrdinalIgnoreCase) ||
                                s.EndsWith(".gif", StringComparison.OrdinalIgnoreCase) ||
                                s.EndsWith(".bmp", StringComparison.OrdinalIgnoreCase))
                    .ToArray();

                // Enable vertical scrolling and disable horizontal scrolling for flowLayoutPanelImages
                flowLayoutPanelImages.AutoScroll = true;
                flowLayoutPanelImages.HorizontalScroll.Enabled = false;
                flowLayoutPanelImages.HorizontalScroll.Visible = false;
                flowLayoutPanelImages.HorizontalScroll.Maximum = 0;
                flowLayoutPanelImages.AutoScrollMinSize = new Size(0, 0);

                // Show color picker to choose the background color
                if (ChooseBackgroundColor())
                {
                    // Display the loaded images (you may want to perform further processing here)
                    foreach (string imagesPath in imageFiles)
                    {
                        // User selected a background color
                        // Remove the background
                        Bitmap ogImage = new Bitmap(imagesPath);
                        foregroundImage = RemoveBackground(ogImage, selectedBackgroundColor);

                        // Manually resize the image to fit within the PictureBox size
                        Size pictureBoxSize = new Size(200, 200); // Set the size
                        Bitmap resizedImage = new Bitmap(foregroundImage, pictureBoxSize);

                        PictureBox pictureBox = new PictureBox
                        {
                            Image = resizedImage,
                            SizeMode = PictureBoxSizeMode.AutoSize, // Set size mode to AutoSize
                            Tag = imagesPath  // Store the original image path in the Tag property for reference
                        };

                        // Add PictureBox to the form
                        flowLayoutPanelImages.Controls.Add(pictureBox);

                        // Add the processed image to the list
                        processedImages.Add(foregroundImage);
                    }

                    MessageBox.Show($"Background removed.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading images: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ChooseBackgroundColor()
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                colorDialog.AllowFullOpen = true;
                colorDialog.ShowHelp = true;

                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    // User selected a background color.
                    selectedBackgroundColor = colorDialog.Color;

                    // Reset the custom colors to forget the selected color.
                    colorDialog.CustomColors = new int[16];

                    return true;
                }

                // User canceled the operation.
                return false;
            }
        }

        private void btnChooseBackgroundColor_Click(object sender, EventArgs e)
        {
            // Clear existing PictureBox controls in flowLayoutPanelImages
            flowLayoutPanelImages.Controls.Clear();

            if (processedImages == null)
            {
                // No image is loaded. Display a message to the user.
                MessageBox.Show("Please load a folder and remove the background of its images first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                // Show a dialog for the user to choose the background color.
                Color backgroundColor = GetBackgroundColor();

                if (backgroundColor == Color.Empty)
                {
                    // User canceled the operation or didn't choose a color.
                    return;
                }

                AddColor(processedImages, backgroundColor);

                SaveImagesToFolder(addColorImages);
            }
        }

        private void AddColor(List<Bitmap> images, Color backgroundColor)
        {
            try
            {
                // Clear existing PictureBox controls in flowLayoutPanelImages
                flowLayoutPanelImages.Controls.Clear();

                // Display the images in flowLayoutPanelImages
                foreach (Bitmap processedImage in images)
                {
                    try
                    {
                        Bitmap tempImage = processedImage;
                        Bitmap withColor = FillBackgroundWithColor(tempImage, backgroundColor);

                        // Manually resize the image to fit within the PictureBox size
                        Size pictureBoxSize = new Size(200, 200); // Set the size
                        Bitmap resizedImage = new Bitmap(withColor, pictureBoxSize);

                        // Convert Bitmap to Image
                        Image imageForPictureBox = (Image)resizedImage;

                        // Create a new PictureBox with the converted image
                        PictureBox pictureBox = new PictureBox
                        {
                            Image = imageForPictureBox,
                            SizeMode = PictureBoxSizeMode.AutoSize, // Set size mode to AutoSize
                            Tag = "Added Background Color"  // You can set any tag value here
                        };

                        // Add PictureBox to the form
                        flowLayoutPanelImages.Controls.Add(pictureBox);

                        addColorImages.Add(withColor);
                    }
                    catch (Exception ex)
                    {
                        throw new Exception($"Error displaying processed image: {ex.Message}");
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error displaying processed images: {ex.Message}");
            }
        }

        private void btnChooseBackgroundImage_Click(object sender, EventArgs e)
        {
            // Clear existing PictureBox controls in flowLayoutPanelImages
            flowLayoutPanelImages.Controls.Clear();

            if (processedImages == null)
            {
                // No image is loaded. Display a message to the user.
                MessageBox.Show("Please load a folder and remove the background of its images first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Show a dialog for the user to choose the background image file.
            string backgroundImageFilePath = GetBackgroundImageFilePath();

            if (backgroundImageFilePath == null)
            {
                // User canceled the operation.
                return;
            }

            // Call the image processing method with the chosen background image.
            AddImage(processedImages, backgroundImageFilePath);

            SaveImagesToFolder(addImageImages);
        }

        private void AddImage(List<Bitmap> images, string backgroundImageFilePath)
        {
            try
            {
                // Clear existing PictureBox controls in flowLayoutPanelImages
                flowLayoutPanelImages.Controls.Clear();

                // Display the images in flowLayoutPanelImages
                foreach (Bitmap processedImage in images)
                {
                    try
                    {
                        if (!string.IsNullOrEmpty(backgroundImageFilePath) && File.Exists(backgroundImageFilePath))
                        {
                            Bitmap tempImage = processedImage;
                            Bitmap backgroundImage = new Bitmap(backgroundImageFilePath);
                            Bitmap withImage = FillBackgroundWithImage(tempImage, backgroundImage);
                            backgroundImage.Dispose();

                            // Manually resize the image to fit within the PictureBox size
                            Size pictureBoxSize = new Size(200, 200); // Set the size
                            Bitmap resizedImage = new Bitmap(withImage, pictureBoxSize);

                            // Convert Bitmap to Image
                            Image imageForPictureBox = (Image)resizedImage;

                            // Create a new PictureBox with the converted image
                            PictureBox pictureBox = new PictureBox
                            {
                                Image = imageForPictureBox,
                                SizeMode = PictureBoxSizeMode.AutoSize, // Set size mode to AutoSize
                                Tag = "Added Background Color"  // You can set any tag value here
                            };

                            // Add PictureBox to the form
                            flowLayoutPanelImages.Controls.Add(pictureBox);

                            addImageImages.Add(withImage);
                        }
                    }
                    catch (Exception ex)
                    {
                        throw new Exception($"Error displaying processed image: {ex.Message}");
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error displaying processed images: {ex.Message}");
            }
        }

        private string GetBackgroundImageFilePath()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Choose Background Image File";
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.ico;*.tiff;*.jfif|All Files|*.*";
                openFileDialog.FilterIndex = 1;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    return openFileDialog.FileName;
                }

                // User canceled the operation.
                return null;
            }
        }

        private Color GetBackgroundColor()
        {
            using (ColorDialog colorDialog2 = new ColorDialog())
            {
                colorDialog2.AllowFullOpen = true;
                colorDialog2.ShowHelp = true;

                if (colorDialog2.ShowDialog() == DialogResult.OK)
                {
                    return colorDialog2.Color;
                }

                // User canceled the operation.
                return Color.White; // You can choose a default color here.
            }
        }

        private Bitmap RemoveBackground(Bitmap originalImage, Color backgroundColor)
        {
            // Create a new bitmap with the same size as the original image.
            Bitmap resultImage = new Bitmap(originalImage.Width, originalImage.Height);

            // Define a threshold for color similarity (adjust as needed).
            int colorThreshold = 100;

            for (int x = 0; x < originalImage.Width; x++)
            {
                for (int y = 0; y < originalImage.Height; y++)
                {
                    // Get the color of the current pixel in the original image.
                    Color pixelColor = originalImage.GetPixel(x, y);

                    // Check if the pixel color is similar to the background color.
                    if (ColorSimilarity(pixelColor, backgroundColor) < colorThreshold)
                    {
                        // If similar, set the pixel in the result image to a transparent color.
                        resultImage.SetPixel(x, y, Color.Transparent);
                    }
                    else
                    {
                        // If not similar, copy the pixel from the original image to the result image.
                        resultImage.SetPixel(x, y, pixelColor);
                    }
                }
            }

            return resultImage;
        }

        private int ColorSimilarity(Color color1, Color color2)
        {
            // Calculate the Euclidean distance between two colors.
            int redDiff = color1.R - color2.R;
            int greenDiff = color1.G - color2.G;
            int blueDiff = color1.B - color2.B;

            return (int)Math.Sqrt(redDiff * redDiff + greenDiff * greenDiff + blueDiff * blueDiff);
        }

        private Bitmap FillBackgroundWithColor(Bitmap foregroundImage, Color backgroundColor)
        {
            // Create a new bitmap with the same size as the foreground image.
            Bitmap resultImage = new Bitmap(foregroundImage.Width, foregroundImage.Height);

            using (Graphics g = Graphics.FromImage(resultImage))
            {
                // Fill the background with the specified color.
                g.Clear(backgroundColor);

                // Draw the foreground image on top.
                g.DrawImage(foregroundImage, Point.Empty);
            }

            return resultImage;
        }

        private Bitmap FillBackgroundWithImage(Bitmap foregroundImage, Bitmap backgroundImage)
        {
            // Resize the background image to match the size of the foreground image.
            Bitmap resizedBackgroundImage = new Bitmap(foregroundImage.Width, foregroundImage.Height);
            using (Graphics g = Graphics.FromImage(resizedBackgroundImage))
            {
                g.DrawImage(backgroundImage, 0, 0, foregroundImage.Width, foregroundImage.Height);
            }

            // Create a new bitmap with the same size as the foreground image.
            Bitmap resultImage = new Bitmap(foregroundImage.Width, foregroundImage.Height);

            using (Graphics g = Graphics.FromImage(resultImage))
            {
                // Draw the resized background image.
                g.DrawImage(resizedBackgroundImage, Point.Empty);

                // Draw the foreground image on top.
                g.DrawImage(foregroundImage, Point.Empty);
            }

            return resultImage;
        }

        private void removeBG_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(removeBG, "Remove Background");
        }

        private void colorBG_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(colorBG, "Add Background Color");
        }

        private void imageBG_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(imageBG, "Add Background Image");
        }

        private void rleFeature_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(rleFeature, "Run-Length Encoding");
        }

        private void huffman_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(Button_Huffman, "Huffman Coding");
        }

        private void rawImage_Click(object sender, EventArgs e)
        {

            if (originalImage == null)
            {
                return;
            }
            else if (editedImage != null)
            {
                editedImage = null;
            }

            PBox_Image2.Image = null;
            PBox_Image3.Image = null;
            PBox_Image4.Image = null;
            Panel_Laplacian.Visible = false;
            imageChannel.Image = originalImage;

            Label_Spatial1.Text = null;
            Label_Spatial2.Text = null;
            Label_Spatial3.Text = null;
        }

        // -------------------------- CLOSING IMAGE ----------------------------
        private void closeImage_Click(object sender, EventArgs e)
        {

            // Display a message box asking the user if they want to close or save the image
            DialogResult result = MessageBox.Show("Save changes before closing?", "Close Image", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (result == DialogResult.No) // Close without saving
            {

                if (originalImage == null)
                {
                    return;
                }

                // Clear any existing information and loaded images.
                if (paletteDisplay != null)
                {
                    paletteDisplay.Controls.Clear();
                }

                PCXheaderInfoBox.Controls.Clear();
                PCXheaderInfoBox.Clear();

                // Dispose the Bitmap objects
                originalImage = null;
                editedImage = null;
                imageChannel.Image = null;
                ViewImage.Image = null;
                PBox_Image1.Image = null;
                PBox_Image2.Image = null;
                PBox_Image3.Image = null;
                PBox_Image4.Image = null;

                hideCloseButton();
                hideEditedImages();
            }
            else if (result == DialogResult.Yes) // Save and close
            {
                if (originalImage == null)
                {
                    return;
                }

                if (editedImage == null)
                {
                    return;
                }

                // Save the edited image
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "JPEG Image|*.jpg|PNG Image|*.png|BMP Image|*.bmp|All Files|*.*";
                saveFileDialog.Title = "Save Image";
                saveFileDialog.ShowDialog();

                if (!string.IsNullOrEmpty(saveFileDialog.FileName))
                {
                    // Save the edited image to the selected file
                    editedImage.Save(saveFileDialog.FileName);

                    PCXheaderInfoBox.Controls.Clear();
                    PCXheaderInfoBox.Clear();

                    // Dispose the Bitmap objects
                    originalImage = null;
                    editedImage = null;
                    imageChannel.Image = null;
                    ViewImage.Image = null;
                    PBox_Image1.Image = null;
                    PBox_Image2.Image = null;
                    PBox_Image3.Image = null;
                    PBox_Image4.Image = null;
                    paletteDisplay.Visible = false;

                    hideCloseButton();
                    hideEditedImages();
                }
            }
            else if (result == DialogResult.Cancel) // Do nothing and keep editing
            {
                // Do nothing, let the user continue editing
            }
        }

        private void SpatialFiltering_Click(object sender, EventArgs e)
        {
            hideFeaturesPanels();
            hideEditedImages();
            Panel_Spatial.Visible = true;
            Panel_DisplaySpatial.Visible = true;

            Label_Spatial1.Text = null;
            Label_Spatial2.Text = null;
            Label_Spatial3.Text = null;
            Panel_Laplacian.Visible = false;

            Label_Feature.Text = "Spatial Filtering";

            changeButtonColor();
            if (isNightMode)
            {
                Button_RestoreDegrade.BackColor = SystemColors.ScrollBar;
                Button_SpatialFiltering.BackColor = Color.FromArgb(56, 56, 56);
                Button_BasicEnhancement.BackColor = SystemColors.ScrollBar;
                Button_SpatialFiltering.Image = Properties.Resources.filter_light;
                Button_BasicEnhancement.Image = Properties.Resources.basic;
                Button_RestoreDegrade.Image = Properties.Resources.restore;
            }
            else
            {
                Button_RestoreDegrade.BackColor = SystemColors.ScrollBar;
                Button_SpatialFiltering.BackColor = SystemColors.ControlLightLight;
                Button_BasicEnhancement.BackColor = SystemColors.ScrollBar;
                Button_SpatialFiltering.Image = Properties.Resources.filter;
                Button_BasicEnhancement.Image = Properties.Resources.basic;
                Button_RestoreDegrade.Image = Properties.Resources.restore;
            }

            // Check if the originalImage has been loaded
            if (originalImage != null)
            {
                clearSpatialPictureBox();

                Bitmap sourceImage = originalImage; // Create a new Bitmap object to hold the source image
                originalGrayImage = new Bitmap(sourceImage.Width, sourceImage.Height); // Create a new Bitmap object to hold the grayscale version of the source image

                // Loop through each pixel in the source image
                for (int x = 0; x < sourceImage.Width; x++)
                {
                    for (int y = 0; y < sourceImage.Height; y++)
                    {
                        Color pixel = sourceImage.GetPixel(x, y); // Get the color of the current pixel
                        int grayValue = (int)(0.3 * pixel.R + 0.59 * pixel.G + 0.11 * pixel.B); // Calculate the grayscale value for the pixel using the specified weights
                        originalGrayImage.SetPixel(x, y, Color.FromArgb(grayValue, grayValue, grayValue)); // Set the corresponding pixel in the grayscale image to the calculated gray value
                    }
                }

                displayGrayscaleImage(originalGrayImage); // Display the grayscale image using the displayGrayscaleImage methodm
            }
        }

        private void basicEnhancement_Click(object sender, EventArgs e)
        {
            hideFeaturesPanels();
            hideEditedImages();
            Panel_EditedImage.Visible = true;
            Panel_Enhancement.Visible = true;

            Label_Feature.Text = "Image Enhancement";

            changeButtonColor();
            if (isNightMode)
            {
                Button_RestoreDegrade.BackColor = SystemColors.ScrollBar;
                Button_SpatialFiltering.BackColor = SystemColors.ScrollBar;
                Button_BasicEnhancement.BackColor = Color.FromArgb(56, 56, 56);
                Button_SpatialFiltering.Image = Properties.Resources.filter;
                Button_BasicEnhancement.Image = Properties.Resources.basic_light;
                Button_RestoreDegrade.Image = Properties.Resources.restore;
            }
            else
            {
                Button_RestoreDegrade.BackColor = SystemColors.ScrollBar;
                Button_SpatialFiltering.BackColor = SystemColors.ScrollBar;
                Button_BasicEnhancement.BackColor = SystemColors.ControlLightLight;
                Button_SpatialFiltering.Image = Properties.Resources.filter;
                Button_BasicEnhancement.Image = Properties.Resources.basic;
                Button_RestoreDegrade.Image = Properties.Resources.restore;
            }
        }

        private void Button_RestoreDegrade_Click(object sender, EventArgs e)
        {
            hideFeaturesPanels();
            hideEditedImages();
            Panel_EditedImage.Visible = true;
            Panel_RestoreDegrade.Visible = true;

            Label_Feature.Text = "Image Restoration and Degradation";

            changeButtonColor();
            if (isNightMode)
            {
                Button_RestoreDegrade.BackColor = Color.FromArgb(56, 56, 56);
                Button_SpatialFiltering.BackColor = SystemColors.ScrollBar;
                Button_BasicEnhancement.BackColor = SystemColors.ScrollBar;
                Button_SpatialFiltering.Image = Properties.Resources.filter;
                Button_BasicEnhancement.Image = Properties.Resources.basic;
                Button_RestoreDegrade.Image = Properties.Resources.restore_light;
            }
            else
            {
                Button_RestoreDegrade.BackColor = SystemColors.ControlLightLight;
                Button_SpatialFiltering.BackColor = SystemColors.ScrollBar;
                Button_BasicEnhancement.BackColor = SystemColors.ScrollBar;
                Button_SpatialFiltering.Image = Properties.Resources.filter;
                Button_BasicEnhancement.Image = Properties.Resources.basic;
                Button_RestoreDegrade.Image = Properties.Resources.restore;
            }
        }

        // ------------------ SPATIAL FILTERING ------------------

        // Enum to represent background fill options.
        private enum BackgroundFillOption
        {
            Transparent,
            Color,
            Image
        }

        // The displayGrayscaleImage method is responsible for displaying a grayscale image in the form.
        public void displayGrayscaleImage(Bitmap grayscaleImage)
        {
            if (originalGrayImage == null)
            {
                return;
            }

            // Dispose of any previously displayed images and clear associated labels to prevent resource leaks.
            PBox_Image1.Image = null;
            PBox_Image2.Image = null;
            PBox_Image3.Image = null;
            PBox_Image4.Image = null;

            // Display the provided grayscale image in the originalGrayscale PictureBox.
            PBox_Image1.Image = originalGrayImage;
        }

        // The averagingFilter_Click event handler is triggered when the "Averaging Filter" button is clicked.
        private void averagingFilter_Click(object sender, EventArgs e)
        {
            if (originalGrayImage == null)
            {
                return;
            }
            // Dispose of the previous images and clear associated labels to prevent resource leaks.
            PBox_Image1.Image = null;
            PBox_Image2.Image = null;
            PBox_Image3.Image = null;
            PBox_Image4.Image = null;

            Label_Spatial1.Text = null;
            Label_Spatial2.Text = null;
            Label_Spatial3.Text = null;
            Panel_Laplacian.Visible = false;

            // Set the label to indicate the applied filter.
            Label_Spatial1.Text = "Average Filter";

            // Define the filter size (you can adjust this value as needed).
            int filterSize = 3;

            // Apply the averaging filter to the original grayscale image.
            Bitmap filteredImage = ApplyAveragingFilter(originalGrayImage, filterSize);

            // Display the filtered image in the originalGrayscale PictureBox.
            displayGrayscaleImage(originalGrayImage);
            PBox_Image2.Image = filteredImage;
        }
        // The medianFilter_Click event handler is triggered when the "Median Filter" button is clicked.
        private void median_Click(object sender, EventArgs e)
        {
            if (originalGrayImage == null)
            {
                return;
            }

            // Dispose of the previous images and clear associated labels to prevent resource leaks.
            PBox_Image1.Image = null;
            PBox_Image2.Image = null;
            PBox_Image3.Image = null;
            PBox_Image4.Image = null;

            Label_Spatial1.Text = null;
            Label_Spatial2.Text = null;
            Label_Spatial3.Text = null;
            Panel_Laplacian.Visible = false;

            // Set the label to indicate the applied filter.
            Label_Spatial1.Text = "Median Filter";

            // Define the filter size (you can adjust this value as needed).
            int filterSize = 3;

            // Apply the median filter to the original grayscale image.
            Bitmap filteredImage = ApplyMedian(originalGrayImage, filterSize);

            // Display the filtered image in the originalGrayscale PictureBox.
            displayGrayscaleImage(originalGrayImage);
            PBox_Image2.Image = filteredImage;
        }

        // Apply the median filter to a specific pixel in the image
        private Bitmap ApplyMedian(Bitmap image, int filterSize)
        {
            // Create a new Bitmap to store the filtered image with the same dimensions as the input image.
            Bitmap filteredImage = new Bitmap(image.Width, image.Height);

            // Iterate through each pixel in the input image.
            for (int x = 0; x < image.Width; x++)
            {
                for (int y = 0; y < image.Height; y++)
                {
                    // Calculate the median color for the current pixel using the specified filter size.
                    Color medianColor = CalculateMedianColor(image, x, y, filterSize);

                    // Set the corresponding pixel in the filtered image to the calculated median color.
                    filteredImage.SetPixel(x, y, medianColor);
                }
            }

            // Return the filtered image as a new Bitmap.
            return filteredImage;
        }

        // Calculate the median color for a specific pixel in the image
        private Color CalculateMedianColor(Bitmap image, int x, int y, int filterSize)
        {
            // Calculate the radius of the filter (half of the filter size).
            int filterRadius = filterSize / 2;

            // Initialize lists to store color channel values from the neighborhood.
            List<byte> redValues = new List<byte>();
            List<byte> greenValues = new List<byte>();
            List<byte> blueValues = new List<byte>();

            // Iterate through the pixels within the neighborhood.
            for (int i = -filterRadius; i <= filterRadius; i++)
            {
                for (int j = -filterRadius; j <= filterRadius; j++)
                {
                    int pixelX = x + i;
                    int pixelY = y + j;

                    // Check if the pixel is within the bounds of the image.
                    if (pixelX >= 0 && pixelX < image.Width && pixelY >= 0 && pixelY < image.Height)
                    {
                        // Get the color of the current pixel in the neighborhood.
                        Color pixelColor = image.GetPixel(pixelX, pixelY);

                        // Store the color channel values (R, G, and B) from the current pixel.
                        redValues.Add(pixelColor.R);
                        greenValues.Add(pixelColor.G);
                        blueValues.Add(pixelColor.B);
                    }
                }
            }

            // Calculate the median value for each color channel.
            byte medianR = GetMedianValue(redValues);
            byte medianG = GetMedianValue(greenValues);
            byte medianB = GetMedianValue(blueValues);

            // Return the computed median color as a Color object.
            return Color.FromArgb(medianR, medianG, medianB);
        }

        // GetMedianValue method calculates the median value from a list of byte values.
        // It sorts the values and returns the value at the middle position.
        // Note: The list is assumed to be pre-sorted before calling this method.
        private byte GetMedianValue(List<byte> values)
        {
            // Sort the list of values in ascending order.
            values.Sort();

            // Calculate the index of the middle value in the sorted list.
            int middle = values.Count / 2;

            // Return the value at the middle position, which is the median value.
            return values[middle];
        }

        // The highpassFilter_Click event handler is triggered when the "Highpass Filter" button is clicked.
        private void highpassFilter_Click(object sender, EventArgs e)
        {
            if (originalGrayImage == null)
            {
                return;
            }

            // Dispose of the previous image (if any) to prevent resource leaks
            PBox_Image1.Image = null;
            PBox_Image2.Image = null;
            PBox_Image3.Image = null;
            PBox_Image4.Image = null;

            Label_Spatial1.Text = null;
            Label_Spatial2.Text = null;
            Label_Spatial3.Text = null;
            Panel_Laplacian.Visible = true;

            Label_Spatial1.Text = "Highpass Filter";
            Panel_Laplacian.Visible = true;

            // Apply the Laplacian filter to the originalGrayImage
            Bitmap laplacianImage = ApplyLaplacianFilter(originalGrayImage);

            // Display the Laplacian image in the originalGrayscale PictureBox
            displayGrayscaleImage(originalGrayImage);
            PBox_Image2.Image = laplacianImage;
        }

        // The unsharpMasking_Click event handler is triggered when the "Unsharp Masking" button is clicked.
        private void unsharpMasking_Click(object sender, EventArgs e)
        {
            if (originalGrayImage == null)
            {
                return;
            }
            // Dispose of the previous image (if any) to prevent resource leaks
            PBox_Image1.Image = null;
            PBox_Image2.Image = null;
            PBox_Image3.Image = null;
            PBox_Image4.Image = null;

            Label_Spatial1.Text = null;
            Label_Spatial2.Text = null;
            Label_Spatial3.Text = null;
            Panel_Laplacian.Visible = false;

            Label_Spatial1.Text = "Blurred using Averaging Filter";
            Label_Spatial2.Text = "Subtracted";
            Label_Spatial3.Text = "Unsharp Masking"; ;

            // Define the filter size for the averaging filter
            int filterSize = 3; // You can adjust this value

            // Define the sharpening factor (alpha)
            double alpha = 1; // You can adjust this value

            // Apply the averaging filter to the originalGrayImage to create a blurred version
            Bitmap blurredImage = ApplyAveragingFilter(originalGrayImage, filterSize);

            // Calculate the difference between the originalGrayImage and the blurred image
            Bitmap differenceImage = new Bitmap(originalGrayImage.Width, originalGrayImage.Height);
            for (int x = 0; x < originalGrayImage.Width; x++)
            {
                for (int y = 0; y < originalGrayImage.Height; y++)
                {
                    Color originalColor = originalGrayImage.GetPixel(x, y);
                    Color blurredColor = blurredImage.GetPixel(x, y);

                    int diffValue = originalColor.R - blurredColor.R; // Assuming grayscale

                    byte diffR = (byte)Math.Max(0, Math.Min(255, diffValue));

                    differenceImage.SetPixel(x, y, Color.FromArgb(diffR, diffR, diffR));
                }
            }

            // Combine the original image with the difference image using alpha
            Bitmap sharpenedImage = new Bitmap(originalGrayImage.Width, originalGrayImage.Height);
            for (int x = 0; x < originalGrayImage.Width; x++)
            {
                for (int y = 0; y < originalGrayImage.Height; y++)
                {
                    Color originalColor = originalGrayImage.GetPixel(x, y);
                    Color diffColor = differenceImage.GetPixel(x, y);

                    int sharpenedValue = originalColor.R + (int)(alpha * diffColor.R);

                    byte sharpenedR = (byte)Math.Max(0, Math.Min(255, sharpenedValue));

                    sharpenedImage.SetPixel(x, y, Color.FromArgb(sharpenedR, sharpenedR, sharpenedR));
                }
            }

            // Display the sharpened image in the originalGrayscale PictureBox
            displayGrayscaleImage(originalGrayImage);
            PBox_Image2.Image = blurredImage;
            PBox_Image3.Image = differenceImage;
            PBox_Image4.Image = sharpenedImage;
        }

        // The highboostFiltering_Click event handler is triggered when the "Highboost Filtering" button is clicked.
        private void highboostFiltering_Click(object sender, EventArgs e)
        {
            if (originalGrayImage == null)
            {
                return;
            }
            // Dispose of the previous image (if any) to prevent resource leaks
            PBox_Image1.Image = null;
            PBox_Image2.Image = null;
            PBox_Image3.Image = null;
            PBox_Image4.Image = null;

            Label_Spatial1.Text = null;
            Label_Spatial2.Text = null;
            Label_Spatial3.Text = null;
            Panel_Laplacian.Visible = false;

            // Define the filter size for the low-pass filter (averaging filter)
            int filterSize = 3; // You can adjust this value

            // Define the amplification factor (A)
            double A = 3.2; // You can adjust this value
            Label_Spatial1.Text = "Highboost Filtering (Amplication Parameter: " + A + ")";

            // Apply the averaging filter to the originalGrayImage to create a low-pass version
            Bitmap lowpassImage = ApplyAveragingFilter(originalGrayImage, filterSize);

            // Create a new Bitmap to store the high-pass image with the same dimensions as the original grayscale image.
            Bitmap highpassImage = new Bitmap(originalGrayImage.Width, originalGrayImage.Height);

            // Iterate through each pixel in the original grayscale image.
            for (int x = 0; x < originalGrayImage.Width; x++)
            {
                for (int y = 0; y < originalGrayImage.Height; y++)
                {
                    // Get the color of the corresponding pixel in the original grayscale image.
                    Color originalColor = originalGrayImage.GetPixel(x, y);
                    // Get the color of the corresponding pixel in the low-pass image.
                    Color lowpassColor = lowpassImage.GetPixel(x, y);
                    // Calculate the high-pass value for the pixel. Assuming grayscale, subtract the low-pass value from the original value.
                    int highpassValue = originalColor.R - lowpassColor.R;
                    // Ensure the high-pass value is within the valid range [0, 255].
                    byte highpassR = (byte)Math.Max(0, Math.Min(255, highpassValue));
                    // Set the corresponding pixel in the high-pass image to the calculated high-pass value, creating a grayscale high-pass image.
                    highpassImage.SetPixel(x, y, Color.FromArgb(highpassR, highpassR, highpassR));
                }
            }

            // Calculate the high-boost image (High boost = (A-1)(Original) + Highpass)
            Bitmap highboostImage = new Bitmap(originalGrayImage.Width, originalGrayImage.Height);
            for (int x = 0; x < originalGrayImage.Width; x++)
            {
                for (int y = 0; y < originalGrayImage.Height; y++)
                {
                    Color originalColor = originalGrayImage.GetPixel(x, y);
                    Color highpassColor = highpassImage.GetPixel(x, y);

                    int highboostValue = (int)((A - 1.0) * originalColor.R) + highpassColor.R;

                    byte highboostR = (byte)Math.Max(0, Math.Min(255, highboostValue));

                    highboostImage.SetPixel(x, y, Color.FromArgb(highboostR, highboostR, highboostR));
                }
            }

            // Display the high-boost image in the originalGrayscale PictureBox
            displayGrayscaleImage(originalGrayImage);
            PBox_Image2.Image = highboostImage;
        }

        // The gradient_Click event handler is triggered
        private void gradient_Click(object sender, EventArgs e)
        {
            if (originalGrayImage == null)
            {
                return;
            }
            // Dispose of the previous image (if any) to prevent resource leaks
            PBox_Image1.Image = null;
            PBox_Image2.Image = null;
            PBox_Image3.Image = null;
            PBox_Image4.Image = null;

            Label_Spatial1.Text = null;
            Label_Spatial2.Text = null;
            Label_Spatial3.Text = null;
            Panel_Laplacian.Visible = false;

            Label_Spatial1.Text = "Sobel Operator (XY)";
            Label_Spatial2.Text = "Sobel Operator (X)";
            Label_Spatial3.Text = "Sobel Operator (Y)";

            // Apply the Sobel operator to the originalGrayImage to calculate the gradient
            Bitmap gradientXImage, gradientYImage, gradientMagnitudeImage;
            ApplySobelOperator(originalGrayImage, out gradientXImage, out gradientYImage, out gradientMagnitudeImage);

            // Display the gradient images in respective PictureBox controls
            displayGrayscaleImage(originalGrayImage);
            PBox_Image2.Image = gradientMagnitudeImage;
            PBox_Image3.Image = gradientXImage;
            PBox_Image4.Image = gradientMagnitudeImage;
        }

        // Apply the averaging filter to a specific pixel in the image
        private Bitmap ApplyAveragingFilter(Bitmap image, int filterSize)
        {
            Bitmap filteredImage = new Bitmap(image.Width, image.Height);

            for (int x = 0; x < image.Width; x++)
            {
                for (int y = 0; y < image.Height; y++)
                {
                    Color averagedColor = CalculateAveragedColor(image, x, y, filterSize);
                    filteredImage.SetPixel(x, y, averagedColor);
                }
            }

            return filteredImage;
        }

        // Calculate the averaged color for a specific pixel in the image
        private Color CalculateAveragedColor(Bitmap image, int x, int y, int filterSize)
        {
            // Calculate the radius of the filter (half of the filter size).
            int filterRadius = filterSize / 2;

            // Initialize variables to accumulate the total color channel values within the neighborhood.
            int totalR = 0, totalG = 0, totalB = 0;

            // Calculate the divisor, which represents the number of pixels in the neighborhood.
            int divisor = filterSize * filterSize;

            // Iterate through the pixels within the neighborhood.
            for (int i = -filterRadius; i <= filterRadius; i++)
            {
                for (int j = -filterRadius; j <= filterRadius; j++)
                {
                    int pixelX = x + i;
                    int pixelY = y + j;

                    // Check if the pixel is within the bounds of the image.
                    if (pixelX >= 0 && pixelX < image.Width && pixelY >= 0 && pixelY < image.Height)
                    {
                        // Get the color of the current pixel.
                        Color pixelColor = image.GetPixel(pixelX, pixelY);

                        // Accumulate the color channel values.
                        totalR += pixelColor.R;
                        totalG += pixelColor.G;
                        totalB += pixelColor.B;
                    }
                }
            }

            // Calculate the averaged color by dividing the accumulated channel values by the divisor.
            byte averagedR = (byte)(totalR / divisor);
            byte averagedG = (byte)(totalG / divisor);
            byte averagedB = (byte)(totalB / divisor);

            // Return the averaged color as a Color object.
            return Color.FromArgb(averagedR, averagedG, averagedB);
        }

        // Apply the Laplacian filter to an image
        private Bitmap ApplyLaplacianFilter(Bitmap image)
        {
            // Create a new Bitmap to store the filtered image with the same dimensions as the input image.
            Bitmap filteredImage = new Bitmap(image.Width, image.Height);

            // Define the Laplacian kernel used for filtering.
            int[,] laplacianKernel = {
                { -1, -1, -1 },
                { -1,  8, -1 },
                { -1, -1, -1 }
            };

            int kernelSize = 3;
            int kernelOffset = kernelSize / 2;

            // Iterate through each pixel in the input image.
            for (int x = 0; x < image.Width; x++)
            {
                for (int y = 0; y < image.Height; y++)
                {
                    int sumR = 0, sumG = 0, sumB = 0;

                    // Apply the Laplacian kernel to the neighborhood of the current pixel.
                    for (int i = -kernelOffset; i <= kernelOffset; i++)
                    {
                        for (int j = -kernelOffset; j <= kernelOffset; j++)
                        {
                            int pixelX = x + i;
                            int pixelY = y + j;

                            // Check if the pixel is within the bounds of the image.
                            if (pixelX >= 0 && pixelX < image.Width && pixelY >= 0 && pixelY < image.Height)
                            {
                                Color pixelColor = image.GetPixel(pixelX, pixelY);
                                int kernelValue = laplacianKernel[i + kernelOffset, j + kernelOffset];

                                // Apply the kernel value to the color channels and accumulate the results.
                                sumR += pixelColor.R * kernelValue;
                                sumG += pixelColor.G * kernelValue;
                                sumB += pixelColor.B * kernelValue;
                            }
                        }
                    }

                    // Ensure that color channel values are within the valid range [0, 255].
                    sumR = Math.Max(0, Math.Min(255, sumR));
                    sumG = Math.Max(0, Math.Min(255, sumG));
                    sumB = Math.Max(0, Math.Min(255, sumB));

                    // Create a new color using the filtered channel values.
                    Color filteredColor = Color.FromArgb(sumR, sumG, sumB);

                    // Set the corresponding pixel in the filtered image to the filtered color.
                    filteredImage.SetPixel(x, y, filteredColor);
                }
            }

            // Return the filtered image as a new Bitmap.
            return filteredImage;
        }

        // ApplySobelOperator method calculates the gradient in the X and Y directions and the gradient magnitude of the input image using the Sobel operator.
        // It stores the results in three separate Bitmaps (gradientXImage, gradientYImage, and gradientMagnitudeImage).
        private void ApplySobelOperator(Bitmap image, out Bitmap gradientXImage, out Bitmap gradientYImage, out Bitmap gradientMagnitudeImage)
        {
            // Create new Bitmaps to store the gradient images and the gradient magnitude image with the same dimensions as the input image.
            gradientXImage = new Bitmap(image.Width, image.Height);
            gradientYImage = new Bitmap(image.Width, image.Height);
            gradientMagnitudeImage = new Bitmap(image.Width, image.Height);

            // Define Sobel kernels for gradient calculation in the X and Y directions.
            int[,] sobelX = {
                { -1, 0, 1 },
                { -2, 0, 2 },
                { -1, 0, 1 }
            };

            int[,] sobelY = {
                { -1, -2, -1 },
                { 0, 0, 0 },
                { 1, 2, 1 }
            };

            int width = image.Width;
            int height = image.Height;

            // Iterate through the pixels in the interior of the image (excluding the border pixels).
            for (int x = 1; x < width - 1; x++)
            {
                for (int y = 1; y < height - 1; y++)
                {
                    int gradientX = 0;
                    int gradientY = 0;

                    // Apply the Sobel kernels to calculate gradients in the X and Y directions for the current pixel.
                    for (int i = -1; i <= 1; i++)
                    {
                        for (int j = -1; j <= 1; j++)
                        {
                            Color pixelColor = image.GetPixel(x + i, y + j);
                            // Convert the color to grayscale using luminance values.
                            int grayValue = (int)(0.299 * pixelColor.R + 0.587 * pixelColor.G + 0.114 * pixelColor.B);

                            gradientX += sobelX[i + 1, j + 1] * grayValue;
                            gradientY += sobelY[i + 1, j + 1] * grayValue;
                        }
                    }

                    // Ensure that the calculated gradients are within the valid range [0, 255].
                    int normalizedGradientX = Math.Max(0, Math.Min(255, gradientX));
                    int normalizedGradientY = Math.Max(0, Math.Min(255, gradientY));

                    // Set the corresponding pixels in the gradient images to the normalized gradient values.
                    gradientXImage.SetPixel(x, y, Color.FromArgb(normalizedGradientX, normalizedGradientX, normalizedGradientX));
                    gradientYImage.SetPixel(x, y, Color.FromArgb(normalizedGradientY, normalizedGradientY, normalizedGradientY));

                    // Calculate the gradient magnitude and ensure it is within the valid range.
                    int magnitude = (int)Math.Sqrt(gradientX * gradientX + gradientY * gradientY);
                    magnitude = Math.Max(0, Math.Min(255, magnitude));

                    // Set the corresponding pixel in the gradient magnitude image to the calculated magnitude.
                    gradientMagnitudeImage.SetPixel(x, y, Color.FromArgb(magnitude, magnitude, magnitude));
                }
            }
        }
    }
}