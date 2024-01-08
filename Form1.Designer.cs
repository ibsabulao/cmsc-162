using System.Windows.Forms;

namespace Image_Processing
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            menu1ToolStripMenuItem = new ToolStripMenuItem();
            openImageFileToolStripMenuItem = new ToolStripMenuItem();
            openPCXFileToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            saveAsToolStripMenuItem = new ToolStripMenuItem();
            menu2ToolStripMenuItem = new ToolStripMenuItem();
            huffmanCodingToolStripMenuItem = new ToolStripMenuItem();
            filterToolStripMenuItem = new ToolStripMenuItem();
            spatialFiltering = new ToolStripMenuItem();
            button4 = new Button();
            Label_Degrade = new Label();
            Label_Salt = new Label();
            pepperProb = new TextBox();
            saltProb = new TextBox();
            Label_Pepper = new Label();
            button6 = new Button();
            button5 = new Button();
            midpointFilter = new Button();
            maxFilter = new Button();
            minFilter = new Button();
            medianFilter = new Button();
            qValue = new TextBox();
            Label_Q = new Label();
            contraHarmonicFilter = new Button();
            geometricFilter = new Button();
            PCXheaderInfoBox = new RichTextBox();
            imageChannel = new PictureBox();
            editPanel = new Panel();
            counterClockwise = new Button();
            clockwise = new Button();
            flipHorizontal = new Button();
            flipVertical = new Button();
            originalLabel = new Label();
            compressedLabel = new Label();
            showCompressed = new PictureBox();
            showOriginal = new PictureBox();
            Panel_Enhancement = new Panel();
            Table_ShowHistogram = new TableLayoutPanel();
            Panel_Histogram = new Panel();
            Panel_HistogramContainer = new Panel();
            Label_Histogram = new Label();
            tableLayoutPanel6 = new TableLayoutPanel();
            Label_Gamma = new Label();
            panel5 = new Panel();
            Label_GammaValues = new Label();
            button10 = new Button();
            gamma_textbox = new TextBox();
            Table_BW = new TableLayoutPanel();
            Label_BW = new Label();
            Panel_BW = new Panel();
            Label_BWAdjust = new Label();
            bw_trackbar = new TrackBar();
            Table_Gray = new TableLayoutPanel();
            Label_Grayscale = new Label();
            Panel_Gray = new Panel();
            button7 = new Button();
            button8 = new Button();
            Table_RGBChannel = new TableLayoutPanel();
            Label_RGBChannel = new Label();
            Panel_RGBChannel = new Panel();
            Button_Red = new Button();
            Button_Green = new Button();
            Button_Blue = new Button();
            Panel_Spatial = new Panel();
            Table_Gradient = new TableLayoutPanel();
            Label_Gradient = new Label();
            Panel_Gradient = new Panel();
            Button_Gradient = new Button();
            Table_SharpeningFilter = new TableLayoutPanel();
            Label_Sharpening = new Label();
            Panel_SharpeningFilter = new Panel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            Table_SmoothChannels = new TableLayoutPanel();
            Label_Smooth = new Label();
            Panel_SmoothChannels = new Panel();
            Button_Median = new Button();
            Button_Averaging = new Button();
            Panel_RestoreDegrade = new Panel();
            Table_NoiseHistogram = new TableLayoutPanel();
            Panel_NoiseHistogram = new Panel();
            Panel_ShowNoiseHistogram = new Panel();
            Label_NoiseHistogram = new Label();
            Table_Restoration = new TableLayoutPanel();
            Panel_OrderStat = new Panel();
            Label_OrderStat = new Label();
            Panel_Geometric = new Panel();
            Label_Restoration = new Label();
            Panel_Contraharmonic = new Panel();
            Table_Degrade = new TableLayoutPanel();
            Panel_OtherNoise = new Panel();
            Panel_SaltPepperNoise = new Panel();
            Panel_imageEnhancement = new Panel();
            redPixel = new Label();
            displayColor = new PictureBox();
            headerInfoLabel = new Label();
            colorPalette = new Label();
            blueBox = new Button();
            pixelInfo = new Label();
            greenBox = new Button();
            redBox = new Button();
            greenPixel = new Label();
            bluePixel = new Label();
            originalImagePanel = new Panel();
            originalImageLabel = new Label();
            ViewImage = new PictureBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            headerinfoPanel = new Panel();
            colorPalettePanel = new Panel();
            paletteDisplay = new Panel();
            pixelInfoPanel = new Panel();
            displayOriginalPanel = new Panel();
            displayTable = new TableLayoutPanel();
            tabPanel = new Panel();
            closeButtonPanel = new Panel();
            closeImage = new Button();
            imageNamePanel = new Panel();
            imageNameLabel = new Label();
            featuresPanel = new TableLayoutPanel();
            buttonsPanel = new Panel();
            buttonsSection = new TableLayoutPanel();
            otherButtons = new FlowLayoutPanel();
            rawImage = new Button();
            darkLightMode = new Button();
            backgroundButtons = new FlowLayoutPanel();
            removeBG = new Button();
            colorBG = new Button();
            imageBG = new Button();
            compressionButtons = new FlowLayoutPanel();
            rleFeature = new Button();
            Button_Huffman = new Button();
            mainFeatures = new TableLayoutPanel();
            allFeaturesPanel = new Panel();
            Panel_FeatureButton = new FlowLayoutPanel();
            Button_BasicEnhancement = new Button();
            Button_SpatialFiltering = new Button();
            Button_RestoreDegrade = new Button();
            Panel_FeatureName = new Panel();
            Label_Feature = new Label();
            toolTip1 = new ToolTip(components);
            panel1 = new Panel();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imageChannel).BeginInit();
            editPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)showCompressed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)showOriginal).BeginInit();
            Panel_Enhancement.SuspendLayout();
            Table_ShowHistogram.SuspendLayout();
            Panel_Histogram.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            panel5.SuspendLayout();
            Table_BW.SuspendLayout();
            Panel_BW.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bw_trackbar).BeginInit();
            Table_Gray.SuspendLayout();
            Panel_Gray.SuspendLayout();
            Table_RGBChannel.SuspendLayout();
            Panel_RGBChannel.SuspendLayout();
            Panel_Spatial.SuspendLayout();
            Table_Gradient.SuspendLayout();
            Panel_Gradient.SuspendLayout();
            Table_SharpeningFilter.SuspendLayout();
            Panel_SharpeningFilter.SuspendLayout();
            Table_SmoothChannels.SuspendLayout();
            Panel_SmoothChannels.SuspendLayout();
            Panel_RestoreDegrade.SuspendLayout();
            Table_NoiseHistogram.SuspendLayout();
            Panel_NoiseHistogram.SuspendLayout();
            Table_Restoration.SuspendLayout();
            Panel_OrderStat.SuspendLayout();
            Panel_Geometric.SuspendLayout();
            Panel_Contraharmonic.SuspendLayout();
            Table_Degrade.SuspendLayout();
            Panel_OtherNoise.SuspendLayout();
            Panel_SaltPepperNoise.SuspendLayout();
            Panel_imageEnhancement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)displayColor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ViewImage).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            headerinfoPanel.SuspendLayout();
            colorPalettePanel.SuspendLayout();
            pixelInfoPanel.SuspendLayout();
            displayOriginalPanel.SuspendLayout();
            displayTable.SuspendLayout();
            tabPanel.SuspendLayout();
            closeButtonPanel.SuspendLayout();
            imageNamePanel.SuspendLayout();
            featuresPanel.SuspendLayout();
            buttonsPanel.SuspendLayout();
            buttonsSection.SuspendLayout();
            otherButtons.SuspendLayout();
            backgroundButtons.SuspendLayout();
            compressionButtons.SuspendLayout();
            mainFeatures.SuspendLayout();
            allFeaturesPanel.SuspendLayout();
            Panel_FeatureButton.SuspendLayout();
            Panel_FeatureName.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.WhiteSmoke;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menu1ToolStripMenuItem, menu2ToolStripMenuItem, filterToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.RenderMode = ToolStripRenderMode.Professional;
            menuStrip1.Size = new Size(1424, 25);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // menu1ToolStripMenuItem
            // 
            menu1ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openImageFileToolStripMenuItem, openPCXFileToolStripMenuItem, saveToolStripMenuItem, saveAsToolStripMenuItem });
            menu1ToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            menu1ToolStripMenuItem.Name = "menu1ToolStripMenuItem";
            menu1ToolStripMenuItem.Size = new Size(39, 19);
            menu1ToolStripMenuItem.Text = "File";
            // 
            // openImageFileToolStripMenuItem
            // 
            openImageFileToolStripMenuItem.Image = Properties.Resources.open;
            openImageFileToolStripMenuItem.Name = "openImageFileToolStripMenuItem";
            openImageFileToolStripMenuItem.Size = new Size(165, 22);
            openImageFileToolStripMenuItem.Text = "Open Image File";
            openImageFileToolStripMenuItem.Click += ViewImage_Click;
            // 
            // openPCXFileToolStripMenuItem
            // 
            openPCXFileToolStripMenuItem.Image = Properties.Resources.openpcx;
            openPCXFileToolStripMenuItem.Name = "openPCXFileToolStripMenuItem";
            openPCXFileToolStripMenuItem.Size = new Size(165, 22);
            openPCXFileToolStripMenuItem.Text = "Open PCX File";
            openPCXFileToolStripMenuItem.Click += ViewPCX_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Image = Properties.Resources.save;
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(165, 22);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // saveAsToolStripMenuItem
            // 
            saveAsToolStripMenuItem.Image = Properties.Resources.saveas;
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            saveAsToolStripMenuItem.Size = new Size(165, 22);
            saveAsToolStripMenuItem.Text = "Save As";
            saveAsToolStripMenuItem.Click += saveAsToolStripMenuItem_Click;
            // 
            // menu2ToolStripMenuItem
            // 
            menu2ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { huffmanCodingToolStripMenuItem });
            menu2ToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            menu2ToolStripMenuItem.Name = "menu2ToolStripMenuItem";
            menu2ToolStripMenuItem.Size = new Size(92, 19);
            menu2ToolStripMenuItem.Text = "Compression";
            // 
            // huffmanCodingToolStripMenuItem
            // 
            huffmanCodingToolStripMenuItem.Name = "huffmanCodingToolStripMenuItem";
            huffmanCodingToolStripMenuItem.Size = new Size(180, 22);
            huffmanCodingToolStripMenuItem.Text = "Huffman Coding";
            huffmanCodingToolStripMenuItem.Click += huffmanCompression_Click;
            // 
            // filterToolStripMenuItem
            // 
            filterToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { spatialFiltering });
            filterToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            filterToolStripMenuItem.Name = "filterToolStripMenuItem";
            filterToolStripMenuItem.Size = new Size(46, 19);
            filterToolStripMenuItem.Text = "Filter";
            // 
            // spatialFiltering
            // 
            spatialFiltering.Name = "spatialFiltering";
            spatialFiltering.Size = new Size(180, 22);
            spatialFiltering.Text = "Spatial Filtering";
            spatialFiltering.Click += spatialFiltering_Click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ControlLightLight;
            button4.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = SystemColors.ControlText;
            button4.Location = new Point(189, 33);
            button4.Margin = new Padding(4);
            button4.Name = "button4";
            button4.Size = new Size(100, 41);
            button4.TabIndex = 20;
            button4.Text = "Salt-and-Pepper Noise";
            button4.UseVisualStyleBackColor = false;
            button4.Click += saltPepper_Click;
            // 
            // Label_Degrade
            // 
            Label_Degrade.AutoSize = true;
            Label_Degrade.Font = new Font("Inter Semi Bold", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            Label_Degrade.ForeColor = SystemColors.ControlText;
            Label_Degrade.Location = new Point(4, 4);
            Label_Degrade.Margin = new Padding(2, 2, 2, 0);
            Label_Degrade.Name = "Label_Degrade";
            Label_Degrade.Size = new Size(110, 14);
            Label_Degrade.TabIndex = 19;
            Label_Degrade.Text = "Image Degradation";
            // 
            // Label_Salt
            // 
            Label_Salt.AutoSize = true;
            Label_Salt.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            Label_Salt.ForeColor = SystemColors.ControlText;
            Label_Salt.Location = new Point(9, 9);
            Label_Salt.Margin = new Padding(2, 0, 2, 0);
            Label_Salt.Name = "Label_Salt";
            Label_Salt.Size = new Size(100, 12);
            Label_Salt.TabIndex = 19;
            Label_Salt.Text = "Salt Probability [0, 0.5]";
            // 
            // pepperProb
            // 
            pepperProb.BackColor = SystemColors.ControlLightLight;
            pepperProb.Location = new Point(11, 68);
            pepperProb.Margin = new Padding(4);
            pepperProb.Name = "pepperProb";
            pepperProb.Size = new Size(165, 21);
            pepperProb.TabIndex = 23;
            pepperProb.KeyPress += textBox1_KeyPress;
            // 
            // saltProb
            // 
            saltProb.BackColor = SystemColors.ControlLightLight;
            saltProb.Location = new Point(11, 25);
            saltProb.Margin = new Padding(4);
            saltProb.Name = "saltProb";
            saltProb.Size = new Size(165, 21);
            saltProb.TabIndex = 21;
            saltProb.KeyPress += textBox1_KeyPress;
            // 
            // Label_Pepper
            // 
            Label_Pepper.AutoSize = true;
            Label_Pepper.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            Label_Pepper.ForeColor = SystemColors.ControlText;
            Label_Pepper.Location = new Point(9, 53);
            Label_Pepper.Margin = new Padding(2, 0, 2, 0);
            Label_Pepper.Name = "Label_Pepper";
            Label_Pepper.Size = new Size(116, 12);
            Label_Pepper.TabIndex = 22;
            Label_Pepper.Text = "Pepper Probability [0, 0.5]";
            // 
            // button6
            // 
            button6.BackColor = SystemColors.ControlLightLight;
            button6.ForeColor = SystemColors.ActiveCaptionText;
            button6.Location = new Point(155, 11);
            button6.Margin = new Padding(4);
            button6.Name = "button6";
            button6.Size = new Size(115, 37);
            button6.TabIndex = 25;
            button6.Text = "Rayleigh Noise";
            button6.UseVisualStyleBackColor = false;
            button6.Click += rayleighNoise_Click;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.ControlLightLight;
            button5.ForeColor = SystemColors.ActiveCaptionText;
            button5.Location = new Point(32, 11);
            button5.Margin = new Padding(4);
            button5.Name = "button5";
            button5.Size = new Size(115, 37);
            button5.TabIndex = 24;
            button5.Text = "Gaussian Noise";
            button5.UseVisualStyleBackColor = false;
            button5.Click += gaussianNoise_Click;
            // 
            // midpointFilter
            // 
            midpointFilter.BackColor = SystemColors.ControlLightLight;
            midpointFilter.ForeColor = SystemColors.ActiveCaptionText;
            midpointFilter.Location = new Point(159, 59);
            midpointFilter.Margin = new Padding(4);
            midpointFilter.Name = "midpointFilter";
            midpointFilter.Size = new Size(101, 29);
            midpointFilter.TabIndex = 31;
            midpointFilter.Text = "Midpoint Filter";
            midpointFilter.UseVisualStyleBackColor = false;
            midpointFilter.Click += midpointFilter_Click;
            // 
            // maxFilter
            // 
            maxFilter.BackColor = SystemColors.ControlLightLight;
            maxFilter.ForeColor = SystemColors.ActiveCaptionText;
            maxFilter.Location = new Point(159, 26);
            maxFilter.Margin = new Padding(4);
            maxFilter.Name = "maxFilter";
            maxFilter.Size = new Size(101, 29);
            maxFilter.TabIndex = 30;
            maxFilter.Text = "Max Filter";
            maxFilter.UseVisualStyleBackColor = false;
            maxFilter.Click += maxFilter_Click;
            // 
            // minFilter
            // 
            minFilter.BackColor = SystemColors.ControlLightLight;
            minFilter.ForeColor = SystemColors.ActiveCaptionText;
            minFilter.Location = new Point(41, 26);
            minFilter.Margin = new Padding(4);
            minFilter.Name = "minFilter";
            minFilter.Size = new Size(101, 29);
            minFilter.TabIndex = 29;
            minFilter.Text = "Min Filter";
            minFilter.UseVisualStyleBackColor = false;
            minFilter.Click += minFilter_Click;
            // 
            // medianFilter
            // 
            medianFilter.BackColor = SystemColors.ControlLightLight;
            medianFilter.ForeColor = SystemColors.ActiveCaptionText;
            medianFilter.Location = new Point(41, 59);
            medianFilter.Margin = new Padding(4);
            medianFilter.Name = "medianFilter";
            medianFilter.Size = new Size(101, 29);
            medianFilter.TabIndex = 28;
            medianFilter.Text = "Median Filter";
            medianFilter.UseVisualStyleBackColor = false;
            medianFilter.Click += medianFilter_Click;
            // 
            // qValue
            // 
            qValue.BackColor = SystemColors.ControlLightLight;
            qValue.Location = new Point(9, 28);
            qValue.Margin = new Padding(4);
            qValue.Name = "qValue";
            qValue.Size = new Size(146, 21);
            qValue.TabIndex = 24;
            qValue.KeyPress += textBox1_KeyPress;
            // 
            // Label_Q
            // 
            Label_Q.AutoSize = true;
            Label_Q.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            Label_Q.ForeColor = SystemColors.ControlText;
            Label_Q.Location = new Point(9, 10);
            Label_Q.Margin = new Padding(2, 0, 2, 0);
            Label_Q.Name = "Label_Q";
            Label_Q.Size = new Size(41, 12);
            Label_Q.TabIndex = 24;
            Label_Q.Text = "Q value:";
            // 
            // contraHarmonicFilter
            // 
            contraHarmonicFilter.BackColor = SystemColors.ControlLightLight;
            contraHarmonicFilter.ForeColor = SystemColors.ActiveCaptionText;
            contraHarmonicFilter.Location = new Point(179, 10);
            contraHarmonicFilter.Margin = new Padding(4);
            contraHarmonicFilter.Name = "contraHarmonicFilter";
            contraHarmonicFilter.Size = new Size(110, 39);
            contraHarmonicFilter.TabIndex = 27;
            contraHarmonicFilter.Text = "Contraharmonic Filter";
            contraHarmonicFilter.UseVisualStyleBackColor = false;
            contraHarmonicFilter.Click += contraHarmonicFilter_Click;
            // 
            // geometricFilter
            // 
            geometricFilter.BackColor = SystemColors.ControlLightLight;
            geometricFilter.ForeColor = SystemColors.ActiveCaptionText;
            geometricFilter.Location = new Point(96, 8);
            geometricFilter.Margin = new Padding(4);
            geometricFilter.Name = "geometricFilter";
            geometricFilter.Size = new Size(116, 36);
            geometricFilter.TabIndex = 26;
            geometricFilter.Text = "Geometric Filter";
            geometricFilter.UseVisualStyleBackColor = false;
            geometricFilter.Click += geometricFilter_Click;
            // 
            // PCXheaderInfoBox
            // 
            PCXheaderInfoBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PCXheaderInfoBox.BackColor = SystemColors.ControlLightLight;
            PCXheaderInfoBox.BorderStyle = BorderStyle.None;
            PCXheaderInfoBox.Font = new Font("Inter", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            PCXheaderInfoBox.ForeColor = SystemColors.MenuText;
            PCXheaderInfoBox.Location = new Point(4, 30);
            PCXheaderInfoBox.Margin = new Padding(2, 3, 2, 3);
            PCXheaderInfoBox.MaxLength = 21474;
            PCXheaderInfoBox.Name = "PCXheaderInfoBox";
            PCXheaderInfoBox.ReadOnly = true;
            PCXheaderInfoBox.ScrollBars = RichTextBoxScrollBars.None;
            PCXheaderInfoBox.Size = new Size(225, 214);
            PCXheaderInfoBox.TabIndex = 2;
            PCXheaderInfoBox.Text = "";
            // 
            // imageChannel
            // 
            imageChannel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            imageChannel.Location = new Point(116, 79);
            imageChannel.Margin = new Padding(4);
            imageChannel.Name = "imageChannel";
            imageChannel.Size = new Size(536, 536);
            imageChannel.SizeMode = PictureBoxSizeMode.Zoom;
            imageChannel.TabIndex = 0;
            imageChannel.TabStop = false;
            // 
            // editPanel
            // 
            editPanel.BackColor = SystemColors.ControlLight;
            editPanel.Controls.Add(panel1);
            editPanel.Controls.Add(counterClockwise);
            editPanel.Controls.Add(clockwise);
            editPanel.Controls.Add(flipHorizontal);
            editPanel.Controls.Add(flipVertical);
            editPanel.Controls.Add(originalLabel);
            editPanel.Controls.Add(compressedLabel);
            editPanel.Controls.Add(showCompressed);
            editPanel.Controls.Add(showOriginal);
            editPanel.Controls.Add(imageChannel);
            editPanel.Dock = DockStyle.Fill;
            editPanel.Location = new Point(0, 33);
            editPanel.Margin = new Padding(0);
            editPanel.Name = "editPanel";
            editPanel.Size = new Size(787, 740);
            editPanel.TabIndex = 34;
            // 
            // counterClockwise
            // 
            counterClockwise.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            counterClockwise.ForeColor = SystemColors.ActiveCaptionText;
            counterClockwise.Image = Properties.Resources.rotate_counter;
            counterClockwise.Location = new Point(10, 703);
            counterClockwise.Margin = new Padding(4, 3, 4, 3);
            counterClockwise.Name = "counterClockwise";
            counterClockwise.Size = new Size(35, 35);
            counterClockwise.TabIndex = 40;
            counterClockwise.UseVisualStyleBackColor = true;
            counterClockwise.Click += RotateCounterClockwiseButton_Click;
            // 
            // clockwise
            // 
            clockwise.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            clockwise.ForeColor = SystemColors.ActiveCaptionText;
            clockwise.Image = Properties.Resources.rotate_clockwise;
            clockwise.Location = new Point(53, 703);
            clockwise.Margin = new Padding(4, 3, 4, 3);
            clockwise.Name = "clockwise";
            clockwise.Size = new Size(35, 35);
            clockwise.TabIndex = 40;
            clockwise.UseVisualStyleBackColor = true;
            clockwise.Click += RotateClockwiseButton_Click;
            // 
            // flipHorizontal
            // 
            flipHorizontal.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            flipHorizontal.ForeColor = SystemColors.ActiveCaptionText;
            flipHorizontal.Image = Properties.Resources.flip_horizontal;
            flipHorizontal.Location = new Point(96, 703);
            flipHorizontal.Margin = new Padding(4, 3, 4, 3);
            flipHorizontal.Name = "flipHorizontal";
            flipHorizontal.Size = new Size(35, 35);
            flipHorizontal.TabIndex = 40;
            flipHorizontal.UseVisualStyleBackColor = true;
            flipHorizontal.Click += FlipHorizontalButton_Click;
            // 
            // flipVertical
            // 
            flipVertical.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            flipVertical.ForeColor = SystemColors.ActiveCaptionText;
            flipVertical.Image = Properties.Resources.flip_vertical;
            flipVertical.Location = new Point(139, 703);
            flipVertical.Margin = new Padding(4, 3, 4, 3);
            flipVertical.Name = "flipVertical";
            flipVertical.Size = new Size(35, 35);
            flipVertical.TabIndex = 40;
            flipVertical.UseVisualStyleBackColor = true;
            flipVertical.Click += FlipVerticalButton_Click;
            // 
            // originalLabel
            // 
            originalLabel.Anchor = AnchorStyles.Top;
            originalLabel.ForeColor = SystemColors.AppWorkspace;
            originalLabel.Location = new Point(162, 474);
            originalLabel.MaximumSize = new Size(270, 30);
            originalLabel.Name = "originalLabel";
            originalLabel.Size = new Size(158, 18);
            originalLabel.TabIndex = 4;
            originalLabel.Text = "Original Image";
            originalLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // compressedLabel
            // 
            compressedLabel.Anchor = AnchorStyles.Top;
            compressedLabel.ForeColor = SystemColors.AppWorkspace;
            compressedLabel.Location = new Point(449, 474);
            compressedLabel.Name = "compressedLabel";
            compressedLabel.Size = new Size(146, 18);
            compressedLabel.TabIndex = 3;
            compressedLabel.Text = "Compressed Image";
            compressedLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // showCompressed
            // 
            showCompressed.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            showCompressed.Location = new Point(403, 222);
            showCompressed.Name = "showCompressed";
            showCompressed.Size = new Size(249, 249);
            showCompressed.TabIndex = 2;
            showCompressed.TabStop = false;
            // 
            // showOriginal
            // 
            showOriginal.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            showOriginal.Location = new Point(116, 222);
            showOriginal.Name = "showOriginal";
            showOriginal.Size = new Size(249, 249);
            showOriginal.TabIndex = 1;
            showOriginal.TabStop = false;
            // 
            // Panel_Enhancement
            // 
            Panel_Enhancement.BackColor = SystemColors.ControlLightLight;
            Panel_Enhancement.Controls.Add(Table_ShowHistogram);
            Panel_Enhancement.Controls.Add(tableLayoutPanel6);
            Panel_Enhancement.Controls.Add(Table_BW);
            Panel_Enhancement.Controls.Add(Table_Gray);
            Panel_Enhancement.Controls.Add(Table_RGBChannel);
            Panel_Enhancement.Location = new Point(11, 47);
            Panel_Enhancement.Name = "Panel_Enhancement";
            Panel_Enhancement.Size = new Size(341, 706);
            Panel_Enhancement.TabIndex = 42;
            // 
            // Table_ShowHistogram
            // 
            Table_ShowHistogram.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Table_ShowHistogram.CellBorderStyle = TableLayoutPanelCellBorderStyle.Outset;
            Table_ShowHistogram.ColumnCount = 1;
            Table_ShowHistogram.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            Table_ShowHistogram.Controls.Add(Panel_Histogram, 0, 0);
            Table_ShowHistogram.Location = new Point(15, 360);
            Table_ShowHistogram.Name = "Table_ShowHistogram";
            Table_ShowHistogram.RowCount = 1;
            Table_ShowHistogram.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            Table_ShowHistogram.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Table_ShowHistogram.Size = new Size(307, 318);
            Table_ShowHistogram.TabIndex = 45;
            // 
            // Panel_Histogram
            // 
            Panel_Histogram.BackColor = SystemColors.Control;
            Panel_Histogram.Controls.Add(Panel_HistogramContainer);
            Panel_Histogram.Controls.Add(Label_Histogram);
            Panel_Histogram.Dock = DockStyle.Fill;
            Panel_Histogram.Location = new Point(2, 2);
            Panel_Histogram.Margin = new Padding(0);
            Panel_Histogram.Name = "Panel_Histogram";
            Panel_Histogram.Size = new Size(303, 314);
            Panel_Histogram.TabIndex = 21;
            // 
            // Panel_HistogramContainer
            // 
            Panel_HistogramContainer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Panel_HistogramContainer.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Panel_HistogramContainer.BorderStyle = BorderStyle.FixedSingle;
            Panel_HistogramContainer.Location = new Point(8, 27);
            Panel_HistogramContainer.Margin = new Padding(5);
            Panel_HistogramContainer.Name = "Panel_HistogramContainer";
            Panel_HistogramContainer.Size = new Size(286, 279);
            Panel_HistogramContainer.TabIndex = 14;
            // 
            // Label_Histogram
            // 
            Label_Histogram.Anchor = AnchorStyles.Top;
            Label_Histogram.BackColor = Color.Transparent;
            Label_Histogram.Font = new Font("Inter Semi Bold", 8.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            Label_Histogram.ForeColor = SystemColors.ActiveCaptionText;
            Label_Histogram.Location = new Point(36, 0);
            Label_Histogram.Name = "Label_Histogram";
            Label_Histogram.Size = new Size(231, 24);
            Label_Histogram.TabIndex = 13;
            Label_Histogram.Text = "Histogram";
            Label_Histogram.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel6.BackColor = SystemColors.Control;
            tableLayoutPanel6.CellBorderStyle = TableLayoutPanelCellBorderStyle.Outset;
            tableLayoutPanel6.ColumnCount = 1;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.Controls.Add(Label_Gamma, 0, 0);
            tableLayoutPanel6.Controls.Add(panel5, 0, 1);
            tableLayoutPanel6.Location = new Point(16, 272);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 2;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 59F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel6.Size = new Size(307, 82);
            tableLayoutPanel6.TabIndex = 44;
            // 
            // Label_Gamma
            // 
            Label_Gamma.AutoSize = true;
            Label_Gamma.Font = new Font("Inter Semi Bold", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            Label_Gamma.ForeColor = SystemColors.ControlText;
            Label_Gamma.Location = new Point(4, 4);
            Label_Gamma.Margin = new Padding(2, 2, 2, 0);
            Label_Gamma.Name = "Label_Gamma";
            Label_Gamma.Size = new Size(132, 14);
            Label_Gamma.TabIndex = 19;
            Label_Gamma.Text = "Gamma Transformation";
            // 
            // panel5
            // 
            panel5.Controls.Add(Label_GammaValues);
            panel5.Controls.Add(button10);
            panel5.Controls.Add(gamma_textbox);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(2, 21);
            panel5.Margin = new Padding(0);
            panel5.Name = "panel5";
            panel5.Size = new Size(303, 59);
            panel5.TabIndex = 20;
            // 
            // Label_GammaValues
            // 
            Label_GammaValues.AutoSize = true;
            Label_GammaValues.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            Label_GammaValues.ForeColor = SystemColors.ControlText;
            Label_GammaValues.Location = new Point(10, 9);
            Label_GammaValues.Margin = new Padding(2, 0, 2, 0);
            Label_GammaValues.Name = "Label_GammaValues";
            Label_GammaValues.Size = new Size(111, 12);
            Label_GammaValues.TabIndex = 19;
            Label_GammaValues.Text = "Input Gamma (𝛾) values";
            // 
            // button10
            // 
            button10.Anchor = AnchorStyles.Top;
            button10.BackColor = Color.DimGray;
            button10.FlatStyle = FlatStyle.System;
            button10.ForeColor = SystemColors.ButtonHighlight;
            button10.Location = new Point(198, 19);
            button10.Margin = new Padding(4);
            button10.Name = "button10";
            button10.Size = new Size(91, 31);
            button10.TabIndex = 18;
            button10.Text = "Transform";
            button10.UseVisualStyleBackColor = false;
            button10.Click += GammaTransform_Click;
            // 
            // gamma_textbox
            // 
            gamma_textbox.BackColor = SystemColors.ControlLightLight;
            gamma_textbox.Location = new Point(11, 28);
            gamma_textbox.Margin = new Padding(4);
            gamma_textbox.Name = "gamma_textbox";
            gamma_textbox.Size = new Size(170, 21);
            gamma_textbox.TabIndex = 20;
            // 
            // Table_BW
            // 
            Table_BW.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Table_BW.BackColor = SystemColors.Control;
            Table_BW.CellBorderStyle = TableLayoutPanelCellBorderStyle.Outset;
            Table_BW.ColumnCount = 1;
            Table_BW.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            Table_BW.Controls.Add(Label_BW, 0, 0);
            Table_BW.Controls.Add(Panel_BW, 0, 1);
            Table_BW.Location = new Point(16, 184);
            Table_BW.Name = "Table_BW";
            Table_BW.RowCount = 2;
            Table_BW.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            Table_BW.RowStyles.Add(new RowStyle(SizeType.Absolute, 59F));
            Table_BW.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Table_BW.Size = new Size(307, 82);
            Table_BW.TabIndex = 43;
            // 
            // Label_BW
            // 
            Label_BW.AutoSize = true;
            Label_BW.Font = new Font("Inter Semi Bold", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            Label_BW.ForeColor = SystemColors.ControlText;
            Label_BW.Location = new Point(4, 4);
            Label_BW.Margin = new Padding(2, 2, 2, 0);
            Label_BW.Name = "Label_BW";
            Label_BW.Size = new Size(156, 14);
            Label_BW.TabIndex = 19;
            Label_BW.Text = "Black/White Transformation";
            // 
            // Panel_BW
            // 
            Panel_BW.Controls.Add(Label_BWAdjust);
            Panel_BW.Controls.Add(bw_trackbar);
            Panel_BW.Dock = DockStyle.Fill;
            Panel_BW.Location = new Point(2, 21);
            Panel_BW.Margin = new Padding(0);
            Panel_BW.Name = "Panel_BW";
            Panel_BW.Size = new Size(303, 59);
            Panel_BW.TabIndex = 20;
            // 
            // Label_BWAdjust
            // 
            Label_BWAdjust.AutoSize = true;
            Label_BWAdjust.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            Label_BWAdjust.ForeColor = SystemColors.ControlText;
            Label_BWAdjust.Location = new Point(7, 7);
            Label_BWAdjust.Margin = new Padding(2, 0, 2, 0);
            Label_BWAdjust.Name = "Label_BWAdjust";
            Label_BWAdjust.Size = new Size(134, 12);
            Label_BWAdjust.TabIndex = 19;
            Label_BWAdjust.Text = "Adjust B/W Threshold [0, 255]";
            // 
            // bw_trackbar
            // 
            bw_trackbar.BackColor = SystemColors.Control;
            bw_trackbar.Location = new Point(1, 23);
            bw_trackbar.Margin = new Padding(2, 3, 2, 3);
            bw_trackbar.Maximum = 255;
            bw_trackbar.Name = "bw_trackbar";
            bw_trackbar.Size = new Size(300, 45);
            bw_trackbar.TabIndex = 18;
            bw_trackbar.TickFrequency = 15;
            bw_trackbar.TickStyle = TickStyle.TopLeft;
            // 
            // Table_Gray
            // 
            Table_Gray.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Table_Gray.BackColor = SystemColors.Control;
            Table_Gray.CellBorderStyle = TableLayoutPanelCellBorderStyle.Outset;
            Table_Gray.ColumnCount = 1;
            Table_Gray.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            Table_Gray.Controls.Add(Label_Grayscale, 0, 0);
            Table_Gray.Controls.Add(Panel_Gray, 0, 1);
            Table_Gray.Location = new Point(16, 100);
            Table_Gray.Name = "Table_Gray";
            Table_Gray.RowCount = 2;
            Table_Gray.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            Table_Gray.RowStyles.Add(new RowStyle(SizeType.Absolute, 53F));
            Table_Gray.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Table_Gray.Size = new Size(307, 78);
            Table_Gray.TabIndex = 42;
            // 
            // Label_Grayscale
            // 
            Label_Grayscale.AutoSize = true;
            Label_Grayscale.Font = new Font("Inter Semi Bold", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            Label_Grayscale.ForeColor = SystemColors.ControlText;
            Label_Grayscale.Location = new Point(4, 4);
            Label_Grayscale.Margin = new Padding(2, 2, 2, 0);
            Label_Grayscale.Name = "Label_Grayscale";
            Label_Grayscale.Size = new Size(219, 14);
            Label_Grayscale.TabIndex = 19;
            Label_Grayscale.Text = "Grayscale and Negative Transformation";
            // 
            // Panel_Gray
            // 
            Panel_Gray.Controls.Add(button7);
            Panel_Gray.Controls.Add(button8);
            Panel_Gray.Dock = DockStyle.Fill;
            Panel_Gray.Location = new Point(2, 23);
            Panel_Gray.Margin = new Padding(0);
            Panel_Gray.Name = "Panel_Gray";
            Panel_Gray.Size = new Size(303, 53);
            Panel_Gray.TabIndex = 20;
            // 
            // button7
            // 
            button7.Anchor = AnchorStyles.Top;
            button7.BackColor = Color.Gray;
            button7.FlatStyle = FlatStyle.Flat;
            button7.ForeColor = SystemColors.ButtonHighlight;
            button7.Image = Properties.Resources.bw;
            button7.ImageAlign = ContentAlignment.MiddleLeft;
            button7.Location = new Point(26, 5);
            button7.Margin = new Padding(4);
            button7.Name = "button7";
            button7.Padding = new Padding(7, 0, 7, 0);
            button7.Size = new Size(124, 42);
            button7.TabIndex = 11;
            button7.Text = "Grayscale";
            button7.TextAlign = ContentAlignment.MiddleRight;
            button7.UseVisualStyleBackColor = false;
            button7.Click += Grayscale_Click;
            // 
            // button8
            // 
            button8.Anchor = AnchorStyles.Top;
            button8.BackColor = Color.DarkSlateGray;
            button8.FlatStyle = FlatStyle.Flat;
            button8.ForeColor = SystemColors.ButtonHighlight;
            button8.Image = Properties.Resources.negative1;
            button8.ImageAlign = ContentAlignment.MiddleLeft;
            button8.Location = new Point(158, 5);
            button8.Margin = new Padding(4);
            button8.Name = "button8";
            button8.Padding = new Padding(7, 0, 7, 0);
            button8.Size = new Size(118, 42);
            button8.TabIndex = 12;
            button8.Text = "Negative";
            button8.TextAlign = ContentAlignment.MiddleRight;
            button8.UseVisualStyleBackColor = false;
            button8.Click += Negative_Click;
            // 
            // Table_RGBChannel
            // 
            Table_RGBChannel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Table_RGBChannel.BackColor = SystemColors.Control;
            Table_RGBChannel.CellBorderStyle = TableLayoutPanelCellBorderStyle.Outset;
            Table_RGBChannel.ColumnCount = 1;
            Table_RGBChannel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            Table_RGBChannel.Controls.Add(Label_RGBChannel, 0, 0);
            Table_RGBChannel.Controls.Add(Panel_RGBChannel, 0, 1);
            Table_RGBChannel.Location = new Point(16, 16);
            Table_RGBChannel.Name = "Table_RGBChannel";
            Table_RGBChannel.RowCount = 2;
            Table_RGBChannel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            Table_RGBChannel.RowStyles.Add(new RowStyle(SizeType.Absolute, 53F));
            Table_RGBChannel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Table_RGBChannel.Size = new Size(307, 78);
            Table_RGBChannel.TabIndex = 41;
            // 
            // Label_RGBChannel
            // 
            Label_RGBChannel.AutoSize = true;
            Label_RGBChannel.Font = new Font("Inter Semi Bold", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            Label_RGBChannel.ForeColor = SystemColors.ControlText;
            Label_RGBChannel.Location = new Point(4, 4);
            Label_RGBChannel.Margin = new Padding(2, 2, 2, 0);
            Label_RGBChannel.Name = "Label_RGBChannel";
            Label_RGBChannel.Size = new Size(83, 14);
            Label_RGBChannel.TabIndex = 19;
            Label_RGBChannel.Text = "RGB Channels";
            // 
            // Panel_RGBChannel
            // 
            Panel_RGBChannel.Controls.Add(Button_Red);
            Panel_RGBChannel.Controls.Add(Button_Green);
            Panel_RGBChannel.Controls.Add(Button_Blue);
            Panel_RGBChannel.Dock = DockStyle.Fill;
            Panel_RGBChannel.Location = new Point(2, 23);
            Panel_RGBChannel.Margin = new Padding(0);
            Panel_RGBChannel.Name = "Panel_RGBChannel";
            Panel_RGBChannel.Size = new Size(303, 53);
            Panel_RGBChannel.TabIndex = 20;
            // 
            // Button_Red
            // 
            Button_Red.Anchor = AnchorStyles.Top;
            Button_Red.BackColor = Color.FromArgb(241, 76, 76);
            Button_Red.FlatStyle = FlatStyle.Flat;
            Button_Red.ForeColor = SystemColors.ButtonHighlight;
            Button_Red.ImageAlign = ContentAlignment.MiddleLeft;
            Button_Red.Location = new Point(10, 5);
            Button_Red.Margin = new Padding(4);
            Button_Red.Name = "Button_Red";
            Button_Red.Size = new Size(89, 42);
            Button_Red.TabIndex = 9;
            Button_Red.Text = "Red";
            Button_Red.UseVisualStyleBackColor = false;
            Button_Red.Click += Red_Click;
            // 
            // Button_Green
            // 
            Button_Green.Anchor = AnchorStyles.Top;
            Button_Green.BackColor = Color.FromArgb(69, 165, 73);
            Button_Green.FlatStyle = FlatStyle.Flat;
            Button_Green.ForeColor = SystemColors.ButtonHighlight;
            Button_Green.Location = new Point(107, 5);
            Button_Green.Margin = new Padding(4);
            Button_Green.Name = "Button_Green";
            Button_Green.Size = new Size(89, 42);
            Button_Green.TabIndex = 10;
            Button_Green.Text = "Green";
            Button_Green.UseVisualStyleBackColor = false;
            Button_Green.Click += Green_Click;
            // 
            // Button_Blue
            // 
            Button_Blue.Anchor = AnchorStyles.Top;
            Button_Blue.BackColor = Color.FromArgb(70, 124, 229);
            Button_Blue.FlatStyle = FlatStyle.Flat;
            Button_Blue.ForeColor = SystemColors.ButtonHighlight;
            Button_Blue.Location = new Point(204, 5);
            Button_Blue.Margin = new Padding(4);
            Button_Blue.Name = "Button_Blue";
            Button_Blue.Size = new Size(89, 42);
            Button_Blue.TabIndex = 11;
            Button_Blue.Text = "Blue";
            Button_Blue.UseVisualStyleBackColor = false;
            Button_Blue.Click += Blue_Click;
            // 
            // Panel_Spatial
            // 
            Panel_Spatial.BackColor = SystemColors.ControlLightLight;
            Panel_Spatial.Controls.Add(Table_Gradient);
            Panel_Spatial.Controls.Add(Table_SharpeningFilter);
            Panel_Spatial.Controls.Add(Table_SmoothChannels);
            Panel_Spatial.Location = new Point(88, 5);
            Panel_Spatial.Name = "Panel_Spatial";
            Panel_Spatial.Size = new Size(341, 706);
            Panel_Spatial.TabIndex = 41;
            // 
            // Table_Gradient
            // 
            Table_Gradient.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Table_Gradient.BackColor = SystemColors.Control;
            Table_Gradient.CellBorderStyle = TableLayoutPanelCellBorderStyle.Outset;
            Table_Gradient.ColumnCount = 1;
            Table_Gradient.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            Table_Gradient.Controls.Add(Label_Gradient, 0, 0);
            Table_Gradient.Controls.Add(Panel_Gradient, 0, 1);
            Table_Gradient.Location = new Point(16, 171);
            Table_Gradient.Name = "Table_Gradient";
            Table_Gradient.RowCount = 2;
            Table_Gradient.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            Table_Gradient.RowStyles.Add(new RowStyle(SizeType.Absolute, 47F));
            Table_Gradient.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Table_Gradient.Size = new Size(307, 71);
            Table_Gradient.TabIndex = 44;
            // 
            // Label_Gradient
            // 
            Label_Gradient.AutoSize = true;
            Label_Gradient.Font = new Font("Inter Semi Bold", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            Label_Gradient.ForeColor = SystemColors.ControlText;
            Label_Gradient.Location = new Point(4, 4);
            Label_Gradient.Margin = new Padding(2, 2, 2, 0);
            Label_Gradient.Name = "Label_Gradient";
            Label_Gradient.Size = new Size(54, 14);
            Label_Gradient.TabIndex = 19;
            Label_Gradient.Text = "Gradient";
            // 
            // Panel_Gradient
            // 
            Panel_Gradient.Controls.Add(Button_Gradient);
            Panel_Gradient.Dock = DockStyle.Fill;
            Panel_Gradient.Location = new Point(2, 22);
            Panel_Gradient.Margin = new Padding(0);
            Panel_Gradient.Name = "Panel_Gradient";
            Panel_Gradient.Size = new Size(303, 47);
            Panel_Gradient.TabIndex = 20;
            // 
            // Button_Gradient
            // 
            Button_Gradient.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Button_Gradient.ForeColor = SystemColors.ActiveCaptionText;
            Button_Gradient.Location = new Point(69, 9);
            Button_Gradient.Name = "Button_Gradient";
            Button_Gradient.Size = new Size(167, 30);
            Button_Gradient.TabIndex = 19;
            Button_Gradient.Text = "Sobel Magnitude Operator";
            Button_Gradient.UseVisualStyleBackColor = true;
            // 
            // Table_SharpeningFilter
            // 
            Table_SharpeningFilter.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Table_SharpeningFilter.BackColor = SystemColors.Control;
            Table_SharpeningFilter.CellBorderStyle = TableLayoutPanelCellBorderStyle.Outset;
            Table_SharpeningFilter.ColumnCount = 1;
            Table_SharpeningFilter.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            Table_SharpeningFilter.Controls.Add(Label_Sharpening, 0, 0);
            Table_SharpeningFilter.Controls.Add(Panel_SharpeningFilter, 0, 1);
            Table_SharpeningFilter.Location = new Point(16, 94);
            Table_SharpeningFilter.Name = "Table_SharpeningFilter";
            Table_SharpeningFilter.RowCount = 2;
            Table_SharpeningFilter.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            Table_SharpeningFilter.RowStyles.Add(new RowStyle(SizeType.Absolute, 47F));
            Table_SharpeningFilter.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Table_SharpeningFilter.Size = new Size(307, 71);
            Table_SharpeningFilter.TabIndex = 43;
            // 
            // Label_Sharpening
            // 
            Label_Sharpening.AutoSize = true;
            Label_Sharpening.Font = new Font("Inter Semi Bold", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            Label_Sharpening.ForeColor = SystemColors.ControlText;
            Label_Sharpening.Location = new Point(4, 4);
            Label_Sharpening.Margin = new Padding(2, 2, 2, 0);
            Label_Sharpening.Name = "Label_Sharpening";
            Label_Sharpening.Size = new Size(101, 14);
            Label_Sharpening.TabIndex = 19;
            Label_Sharpening.Text = "Sharpening Filter";
            // 
            // Panel_SharpeningFilter
            // 
            Panel_SharpeningFilter.Controls.Add(button1);
            Panel_SharpeningFilter.Controls.Add(button2);
            Panel_SharpeningFilter.Controls.Add(button3);
            Panel_SharpeningFilter.Dock = DockStyle.Fill;
            Panel_SharpeningFilter.Location = new Point(2, 22);
            Panel_SharpeningFilter.Margin = new Padding(0);
            Panel_SharpeningFilter.Name = "Panel_SharpeningFilter";
            Panel_SharpeningFilter.Size = new Size(303, 47);
            Panel_SharpeningFilter.TabIndex = 20;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(204, 4);
            button1.Name = "button1";
            button1.Size = new Size(93, 39);
            button1.TabIndex = 21;
            button1.Text = "Highboost Filtering";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(6, 4);
            button2.Name = "button2";
            button2.Size = new Size(93, 39);
            button2.TabIndex = 19;
            button2.Text = "Highpass Filter";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button3.ForeColor = SystemColors.ActiveCaptionText;
            button3.Location = new Point(105, 4);
            button3.Name = "button3";
            button3.Size = new Size(93, 39);
            button3.TabIndex = 20;
            button3.Text = "Unsharp Masking";
            button3.UseVisualStyleBackColor = true;
            // 
            // Table_SmoothChannels
            // 
            Table_SmoothChannels.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Table_SmoothChannels.BackColor = SystemColors.Control;
            Table_SmoothChannels.CellBorderStyle = TableLayoutPanelCellBorderStyle.Outset;
            Table_SmoothChannels.ColumnCount = 1;
            Table_SmoothChannels.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            Table_SmoothChannels.Controls.Add(Label_Smooth, 0, 0);
            Table_SmoothChannels.Controls.Add(Panel_SmoothChannels, 0, 1);
            Table_SmoothChannels.Location = new Point(16, 17);
            Table_SmoothChannels.Name = "Table_SmoothChannels";
            Table_SmoothChannels.RowCount = 2;
            Table_SmoothChannels.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            Table_SmoothChannels.RowStyles.Add(new RowStyle(SizeType.Absolute, 47F));
            Table_SmoothChannels.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Table_SmoothChannels.Size = new Size(307, 71);
            Table_SmoothChannels.TabIndex = 42;
            // 
            // Label_Smooth
            // 
            Label_Smooth.AutoSize = true;
            Label_Smooth.Font = new Font("Inter Semi Bold", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            Label_Smooth.ForeColor = SystemColors.ControlText;
            Label_Smooth.Location = new Point(4, 4);
            Label_Smooth.Margin = new Padding(2, 2, 2, 0);
            Label_Smooth.Name = "Label_Smooth";
            Label_Smooth.Size = new Size(103, 14);
            Label_Smooth.TabIndex = 19;
            Label_Smooth.Text = "Smooth Channels";
            // 
            // Panel_SmoothChannels
            // 
            Panel_SmoothChannels.Controls.Add(Button_Median);
            Panel_SmoothChannels.Controls.Add(Button_Averaging);
            Panel_SmoothChannels.Dock = DockStyle.Fill;
            Panel_SmoothChannels.Location = new Point(2, 22);
            Panel_SmoothChannels.Margin = new Padding(0);
            Panel_SmoothChannels.Name = "Panel_SmoothChannels";
            Panel_SmoothChannels.Size = new Size(303, 47);
            Panel_SmoothChannels.TabIndex = 20;
            // 
            // Button_Median
            // 
            Button_Median.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Button_Median.ForeColor = SystemColors.ActiveCaptionText;
            Button_Median.Location = new Point(165, 10);
            Button_Median.Name = "Button_Median";
            Button_Median.Size = new Size(116, 27);
            Button_Median.TabIndex = 15;
            Button_Median.Text = "Median Filter";
            Button_Median.UseVisualStyleBackColor = true;
            // 
            // Button_Averaging
            // 
            Button_Averaging.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Button_Averaging.ForeColor = SystemColors.ActiveCaptionText;
            Button_Averaging.Location = new Point(23, 10);
            Button_Averaging.Name = "Button_Averaging";
            Button_Averaging.Size = new Size(116, 27);
            Button_Averaging.TabIndex = 14;
            Button_Averaging.Text = "Averaging Filter";
            Button_Averaging.UseVisualStyleBackColor = true;
            // 
            // Panel_RestoreDegrade
            // 
            Panel_RestoreDegrade.BackColor = SystemColors.ControlLightLight;
            Panel_RestoreDegrade.Controls.Add(Table_NoiseHistogram);
            Panel_RestoreDegrade.Controls.Add(Table_Restoration);
            Panel_RestoreDegrade.Controls.Add(Table_Degrade);
            Panel_RestoreDegrade.Location = new Point(68, 22);
            Panel_RestoreDegrade.Name = "Panel_RestoreDegrade";
            Panel_RestoreDegrade.Size = new Size(341, 706);
            Panel_RestoreDegrade.TabIndex = 42;
            // 
            // Table_NoiseHistogram
            // 
            Table_NoiseHistogram.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Table_NoiseHistogram.CellBorderStyle = TableLayoutPanelCellBorderStyle.Outset;
            Table_NoiseHistogram.ColumnCount = 1;
            Table_NoiseHistogram.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            Table_NoiseHistogram.Controls.Add(Panel_NoiseHistogram, 0, 0);
            Table_NoiseHistogram.Location = new Point(16, 459);
            Table_NoiseHistogram.Name = "Table_NoiseHistogram";
            Table_NoiseHistogram.RowCount = 1;
            Table_NoiseHistogram.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            Table_NoiseHistogram.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Table_NoiseHistogram.Size = new Size(307, 232);
            Table_NoiseHistogram.TabIndex = 30;
            // 
            // Panel_NoiseHistogram
            // 
            Panel_NoiseHistogram.BackColor = SystemColors.Control;
            Panel_NoiseHistogram.Controls.Add(Panel_ShowNoiseHistogram);
            Panel_NoiseHistogram.Controls.Add(Label_NoiseHistogram);
            Panel_NoiseHistogram.Dock = DockStyle.Fill;
            Panel_NoiseHistogram.Location = new Point(2, 2);
            Panel_NoiseHistogram.Margin = new Padding(0);
            Panel_NoiseHistogram.Name = "Panel_NoiseHistogram";
            Panel_NoiseHistogram.Size = new Size(303, 228);
            Panel_NoiseHistogram.TabIndex = 22;
            // 
            // Panel_ShowNoiseHistogram
            // 
            Panel_ShowNoiseHistogram.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Panel_ShowNoiseHistogram.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Panel_ShowNoiseHistogram.BorderStyle = BorderStyle.FixedSingle;
            Panel_ShowNoiseHistogram.Location = new Point(12, 33);
            Panel_ShowNoiseHistogram.Margin = new Padding(5);
            Panel_ShowNoiseHistogram.Name = "Panel_ShowNoiseHistogram";
            Panel_ShowNoiseHistogram.Size = new Size(280, 185);
            Panel_ShowNoiseHistogram.TabIndex = 14;
            // 
            // Label_NoiseHistogram
            // 
            Label_NoiseHistogram.Anchor = AnchorStyles.Top;
            Label_NoiseHistogram.BackColor = Color.Transparent;
            Label_NoiseHistogram.Font = new Font("Inter Semi Bold", 8.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            Label_NoiseHistogram.ForeColor = SystemColors.ActiveCaptionText;
            Label_NoiseHistogram.Location = new Point(35, 3);
            Label_NoiseHistogram.Name = "Label_NoiseHistogram";
            Label_NoiseHistogram.Size = new Size(231, 24);
            Label_NoiseHistogram.TabIndex = 13;
            Label_NoiseHistogram.Text = "Histogram";
            Label_NoiseHistogram.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Table_Restoration
            // 
            Table_Restoration.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Table_Restoration.BackColor = SystemColors.Control;
            Table_Restoration.CellBorderStyle = TableLayoutPanelCellBorderStyle.Outset;
            Table_Restoration.ColumnCount = 1;
            Table_Restoration.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            Table_Restoration.Controls.Add(Panel_OrderStat, 0, 3);
            Table_Restoration.Controls.Add(Panel_Geometric, 0, 2);
            Table_Restoration.Controls.Add(Label_Restoration, 0, 0);
            Table_Restoration.Controls.Add(Panel_Contraharmonic, 0, 1);
            Table_Restoration.Location = new Point(16, 203);
            Table_Restoration.Name = "Table_Restoration";
            Table_Restoration.RowCount = 4;
            Table_Restoration.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            Table_Restoration.RowStyles.Add(new RowStyle(SizeType.Absolute, 64F));
            Table_Restoration.RowStyles.Add(new RowStyle(SizeType.Absolute, 55F));
            Table_Restoration.RowStyles.Add(new RowStyle(SizeType.Absolute, 98F));
            Table_Restoration.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Table_Restoration.Size = new Size(307, 247);
            Table_Restoration.TabIndex = 29;
            // 
            // Panel_OrderStat
            // 
            Panel_OrderStat.Controls.Add(Label_OrderStat);
            Panel_OrderStat.Controls.Add(minFilter);
            Panel_OrderStat.Controls.Add(maxFilter);
            Panel_OrderStat.Controls.Add(medianFilter);
            Panel_OrderStat.Controls.Add(midpointFilter);
            Panel_OrderStat.Dock = DockStyle.Fill;
            Panel_OrderStat.Location = new Point(2, 147);
            Panel_OrderStat.Margin = new Padding(0);
            Panel_OrderStat.Name = "Panel_OrderStat";
            Panel_OrderStat.Size = new Size(303, 98);
            Panel_OrderStat.TabIndex = 22;
            // 
            // Label_OrderStat
            // 
            Label_OrderStat.Anchor = AnchorStyles.Top;
            Label_OrderStat.AutoSize = true;
            Label_OrderStat.Font = new Font("Inter", 8.25F, FontStyle.Italic, GraphicsUnit.Point);
            Label_OrderStat.ForeColor = SystemColors.ControlText;
            Label_OrderStat.Location = new Point(92, 8);
            Label_OrderStat.Margin = new Padding(2, 0, 2, 0);
            Label_OrderStat.Name = "Label_OrderStat";
            Label_OrderStat.Size = new Size(119, 14);
            Label_OrderStat.TabIndex = 26;
            Label_OrderStat.Text = "Order-Statistics Filter";
            // 
            // Panel_Geometric
            // 
            Panel_Geometric.Controls.Add(geometricFilter);
            Panel_Geometric.Dock = DockStyle.Fill;
            Panel_Geometric.Location = new Point(2, 90);
            Panel_Geometric.Margin = new Padding(0);
            Panel_Geometric.Name = "Panel_Geometric";
            Panel_Geometric.Size = new Size(303, 55);
            Panel_Geometric.TabIndex = 21;
            // 
            // Label_Restoration
            // 
            Label_Restoration.AutoSize = true;
            Label_Restoration.Font = new Font("Inter Semi Bold", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            Label_Restoration.ForeColor = SystemColors.ControlText;
            Label_Restoration.Location = new Point(4, 4);
            Label_Restoration.Margin = new Padding(2, 2, 2, 0);
            Label_Restoration.Name = "Label_Restoration";
            Label_Restoration.Size = new Size(106, 14);
            Label_Restoration.TabIndex = 19;
            Label_Restoration.Text = "Image Restoration";
            // 
            // Panel_Contraharmonic
            // 
            Panel_Contraharmonic.Controls.Add(qValue);
            Panel_Contraharmonic.Controls.Add(Label_Q);
            Panel_Contraharmonic.Controls.Add(contraHarmonicFilter);
            Panel_Contraharmonic.Dock = DockStyle.Fill;
            Panel_Contraharmonic.Location = new Point(2, 24);
            Panel_Contraharmonic.Margin = new Padding(0);
            Panel_Contraharmonic.Name = "Panel_Contraharmonic";
            Panel_Contraharmonic.Size = new Size(303, 64);
            Panel_Contraharmonic.TabIndex = 20;
            // 
            // Table_Degrade
            // 
            Table_Degrade.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Table_Degrade.BackColor = SystemColors.Control;
            Table_Degrade.CellBorderStyle = TableLayoutPanelCellBorderStyle.Outset;
            Table_Degrade.ColumnCount = 1;
            Table_Degrade.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            Table_Degrade.Controls.Add(Panel_OtherNoise, 0, 2);
            Table_Degrade.Controls.Add(Label_Degrade, 0, 0);
            Table_Degrade.Controls.Add(Panel_SaltPepperNoise, 0, 1);
            Table_Degrade.Location = new Point(16, 11);
            Table_Degrade.Name = "Table_Degrade";
            Table_Degrade.RowCount = 3;
            Table_Degrade.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            Table_Degrade.RowStyles.Add(new RowStyle(SizeType.Absolute, 98F));
            Table_Degrade.RowStyles.Add(new RowStyle(SizeType.Absolute, 58F));
            Table_Degrade.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Table_Degrade.Size = new Size(307, 183);
            Table_Degrade.TabIndex = 28;
            // 
            // Panel_OtherNoise
            // 
            Panel_OtherNoise.Controls.Add(button5);
            Panel_OtherNoise.Controls.Add(button6);
            Panel_OtherNoise.Dock = DockStyle.Fill;
            Panel_OtherNoise.Location = new Point(2, 123);
            Panel_OtherNoise.Margin = new Padding(0);
            Panel_OtherNoise.Name = "Panel_OtherNoise";
            Panel_OtherNoise.Size = new Size(303, 58);
            Panel_OtherNoise.TabIndex = 21;
            // 
            // Panel_SaltPepperNoise
            // 
            Panel_SaltPepperNoise.Controls.Add(Label_Salt);
            Panel_SaltPepperNoise.Controls.Add(saltProb);
            Panel_SaltPepperNoise.Controls.Add(pepperProb);
            Panel_SaltPepperNoise.Controls.Add(button4);
            Panel_SaltPepperNoise.Controls.Add(Label_Pepper);
            Panel_SaltPepperNoise.Dock = DockStyle.Fill;
            Panel_SaltPepperNoise.Location = new Point(2, 23);
            Panel_SaltPepperNoise.Margin = new Padding(0);
            Panel_SaltPepperNoise.Name = "Panel_SaltPepperNoise";
            Panel_SaltPepperNoise.Size = new Size(303, 98);
            Panel_SaltPepperNoise.TabIndex = 20;
            // 
            // Panel_imageEnhancement
            // 
            Panel_imageEnhancement.Controls.Add(Panel_Spatial);
            Panel_imageEnhancement.Controls.Add(Panel_RestoreDegrade);
            Panel_imageEnhancement.Controls.Add(Panel_Enhancement);
            Panel_imageEnhancement.Location = new Point(0, 65);
            Panel_imageEnhancement.Margin = new Padding(0);
            Panel_imageEnhancement.Name = "Panel_imageEnhancement";
            Panel_imageEnhancement.Size = new Size(341, 706);
            Panel_imageEnhancement.TabIndex = 2;
            // 
            // redPixel
            // 
            redPixel.Anchor = AnchorStyles.Left;
            redPixel.ForeColor = SystemColors.ActiveCaptionText;
            redPixel.Location = new Point(4, 60);
            redPixel.Margin = new Padding(4, 0, 4, 0);
            redPixel.Name = "redPixel";
            redPixel.Size = new Size(39, 20);
            redPixel.TabIndex = 38;
            redPixel.Text = "0";
            redPixel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // displayColor
            // 
            displayColor.Anchor = AnchorStyles.Left;
            displayColor.Location = new Point(125, 33);
            displayColor.Margin = new Padding(4, 3, 4, 3);
            displayColor.Name = "displayColor";
            displayColor.Size = new Size(94, 43);
            displayColor.TabIndex = 39;
            displayColor.TabStop = false;
            // 
            // headerInfoLabel
            // 
            headerInfoLabel.Anchor = AnchorStyles.Top;
            headerInfoLabel.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            headerInfoLabel.ForeColor = SystemColors.ActiveCaptionText;
            headerInfoLabel.Location = new Point(21, 4);
            headerInfoLabel.Margin = new Padding(4, 0, 4, 0);
            headerInfoLabel.Name = "headerInfoLabel";
            headerInfoLabel.RightToLeft = RightToLeft.No;
            headerInfoLabel.Size = new Size(191, 23);
            headerInfoLabel.TabIndex = 46;
            headerInfoLabel.Text = "PCX Header Information";
            headerInfoLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // colorPalette
            // 
            colorPalette.Anchor = AnchorStyles.Top;
            colorPalette.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            colorPalette.ForeColor = SystemColors.ActiveCaptionText;
            colorPalette.Location = new Point(36, 5);
            colorPalette.Margin = new Padding(4, 0, 4, 0);
            colorPalette.Name = "colorPalette";
            colorPalette.RightToLeft = RightToLeft.No;
            colorPalette.Size = new Size(155, 15);
            colorPalette.TabIndex = 46;
            colorPalette.Text = "Color Palette";
            colorPalette.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // blueBox
            // 
            blueBox.Anchor = AnchorStyles.Left;
            blueBox.BackColor = Color.FromArgb(18, 135, 220);
            blueBox.Enabled = false;
            blueBox.FlatStyle = FlatStyle.Flat;
            blueBox.Location = new Point(86, 34);
            blueBox.Name = "blueBox";
            blueBox.Size = new Size(25, 25);
            blueBox.TabIndex = 53;
            blueBox.UseVisualStyleBackColor = false;
            // 
            // pixelInfo
            // 
            pixelInfo.Anchor = AnchorStyles.Top;
            pixelInfo.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            pixelInfo.ForeColor = SystemColors.ActiveCaptionText;
            pixelInfo.Location = new Point(36, 2);
            pixelInfo.Margin = new Padding(4, 0, 4, 0);
            pixelInfo.Name = "pixelInfo";
            pixelInfo.RightToLeft = RightToLeft.No;
            pixelInfo.Size = new Size(160, 29);
            pixelInfo.TabIndex = 49;
            pixelInfo.Text = "Pixel Information";
            pixelInfo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // greenBox
            // 
            greenBox.Anchor = AnchorStyles.Left;
            greenBox.BackColor = Color.FromArgb(18, 220, 50);
            greenBox.Enabled = false;
            greenBox.FlatStyle = FlatStyle.Flat;
            greenBox.Location = new Point(48, 33);
            greenBox.Name = "greenBox";
            greenBox.Size = new Size(25, 25);
            greenBox.TabIndex = 52;
            greenBox.UseVisualStyleBackColor = false;
            // 
            // redBox
            // 
            redBox.Anchor = AnchorStyles.Left;
            redBox.BackColor = Color.FromArgb(220, 18, 18);
            redBox.Enabled = false;
            redBox.FlatStyle = FlatStyle.Flat;
            redBox.Location = new Point(11, 32);
            redBox.Name = "redBox";
            redBox.Size = new Size(25, 25);
            redBox.TabIndex = 49;
            redBox.UseVisualStyleBackColor = false;
            // 
            // greenPixel
            // 
            greenPixel.Anchor = AnchorStyles.Left;
            greenPixel.ForeColor = SystemColors.ActiveCaptionText;
            greenPixel.Location = new Point(41, 60);
            greenPixel.Margin = new Padding(4, 0, 4, 0);
            greenPixel.Name = "greenPixel";
            greenPixel.Size = new Size(39, 20);
            greenPixel.TabIndex = 50;
            greenPixel.Text = "0";
            greenPixel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // bluePixel
            // 
            bluePixel.Anchor = AnchorStyles.Left;
            bluePixel.ForeColor = SystemColors.ActiveCaptionText;
            bluePixel.Location = new Point(80, 60);
            bluePixel.Margin = new Padding(4, 0, 4, 0);
            bluePixel.Name = "bluePixel";
            bluePixel.Size = new Size(39, 20);
            bluePixel.TabIndex = 51;
            bluePixel.Text = "0";
            bluePixel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // originalImagePanel
            // 
            originalImagePanel.AutoSize = true;
            originalImagePanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            originalImagePanel.BackColor = SystemColors.ControlLightLight;
            originalImagePanel.Location = new Point(0, 31);
            originalImagePanel.Name = "originalImagePanel";
            originalImagePanel.Size = new Size(0, 0);
            originalImagePanel.TabIndex = 44;
            // 
            // originalImageLabel
            // 
            originalImageLabel.Anchor = AnchorStyles.Top;
            originalImageLabel.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            originalImageLabel.ForeColor = SystemColors.ActiveCaptionText;
            originalImageLabel.Location = new Point(41, 7);
            originalImageLabel.Margin = new Padding(4, 0, 4, 0);
            originalImageLabel.Name = "originalImageLabel";
            originalImageLabel.Size = new Size(141, 18);
            originalImageLabel.TabIndex = 50;
            originalImageLabel.Text = "Original Image";
            originalImageLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ViewImage
            // 
            ViewImage.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ViewImage.BackColor = SystemColors.ControlLightLight;
            ViewImage.Location = new Point(2, 30);
            ViewImage.Margin = new Padding(0);
            ViewImage.Name = "ViewImage";
            ViewImage.Size = new Size(227, 197);
            ViewImage.SizeMode = PictureBoxSizeMode.Zoom;
            ViewImage.TabIndex = 49;
            ViewImage.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.BackColor = SystemColors.ControlLight;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 235F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 400F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(displayTable, 1, 0);
            tableLayoutPanel1.Controls.Add(featuresPanel, 2, 0);
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(0, 32, 0, 0);
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1422, 803);
            tableLayoutPanel1.TabIndex = 54;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.Controls.Add(headerinfoPanel, 0, 1);
            tableLayoutPanel2.Controls.Add(colorPalettePanel, 0, 2);
            tableLayoutPanel2.Controls.Add(pixelInfoPanel, 0, 3);
            tableLayoutPanel2.Controls.Add(displayOriginalPanel, 0, 0);
            tableLayoutPanel2.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            tableLayoutPanel2.Location = new Point(3, 32);
            tableLayoutPanel2.Margin = new Padding(3, 0, 3, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 4;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 237F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.Size = new Size(229, 771);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // headerinfoPanel
            // 
            headerinfoPanel.BackColor = SystemColors.ControlLightLight;
            headerinfoPanel.Controls.Add(headerInfoLabel);
            headerinfoPanel.Controls.Add(PCXheaderInfoBox);
            headerinfoPanel.Dock = DockStyle.Fill;
            headerinfoPanel.Location = new Point(0, 237);
            headerinfoPanel.Margin = new Padding(0, 0, 0, 3);
            headerinfoPanel.Name = "headerinfoPanel";
            headerinfoPanel.Size = new Size(231, 247);
            headerinfoPanel.TabIndex = 1;
            // 
            // colorPalettePanel
            // 
            colorPalettePanel.BackColor = SystemColors.ControlLightLight;
            colorPalettePanel.Controls.Add(colorPalette);
            colorPalettePanel.Controls.Add(paletteDisplay);
            colorPalettePanel.Dock = DockStyle.Fill;
            colorPalettePanel.Location = new Point(0, 487);
            colorPalettePanel.Margin = new Padding(0, 0, 0, 3);
            colorPalettePanel.Name = "colorPalettePanel";
            colorPalettePanel.Size = new Size(231, 196);
            colorPalettePanel.TabIndex = 2;
            // 
            // paletteDisplay
            // 
            paletteDisplay.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            paletteDisplay.Location = new Point(11, 27);
            paletteDisplay.Margin = new Padding(0);
            paletteDisplay.Name = "paletteDisplay";
            paletteDisplay.Size = new Size(207, 165);
            paletteDisplay.TabIndex = 1;
            // 
            // pixelInfoPanel
            // 
            pixelInfoPanel.BackColor = SystemColors.ControlLightLight;
            pixelInfoPanel.Controls.Add(displayColor);
            pixelInfoPanel.Controls.Add(redPixel);
            pixelInfoPanel.Controls.Add(bluePixel);
            pixelInfoPanel.Controls.Add(greenPixel);
            pixelInfoPanel.Controls.Add(blueBox);
            pixelInfoPanel.Controls.Add(pixelInfo);
            pixelInfoPanel.Controls.Add(greenBox);
            pixelInfoPanel.Controls.Add(redBox);
            pixelInfoPanel.Dock = DockStyle.Fill;
            pixelInfoPanel.Location = new Point(0, 686);
            pixelInfoPanel.Margin = new Padding(0);
            pixelInfoPanel.Name = "pixelInfoPanel";
            pixelInfoPanel.Size = new Size(231, 85);
            pixelInfoPanel.TabIndex = 3;
            // 
            // displayOriginalPanel
            // 
            displayOriginalPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            displayOriginalPanel.BackColor = SystemColors.ControlLightLight;
            displayOriginalPanel.Controls.Add(originalImageLabel);
            displayOriginalPanel.Controls.Add(ViewImage);
            displayOriginalPanel.Location = new Point(0, 0);
            displayOriginalPanel.Margin = new Padding(0, 0, 0, 3);
            displayOriginalPanel.Name = "displayOriginalPanel";
            displayOriginalPanel.Size = new Size(231, 234);
            displayOriginalPanel.TabIndex = 0;
            // 
            // displayTable
            // 
            displayTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            displayTable.ColumnCount = 1;
            displayTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            displayTable.Controls.Add(tabPanel, 0, 0);
            displayTable.Controls.Add(editPanel, 0, 1);
            displayTable.Location = new Point(235, 32);
            displayTable.Margin = new Padding(0);
            displayTable.Name = "displayTable";
            displayTable.RowCount = 2;
            displayTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 33F));
            displayTable.RowStyles.Add(new RowStyle());
            displayTable.Size = new Size(787, 771);
            displayTable.TabIndex = 35;
            // 
            // tabPanel
            // 
            tabPanel.BackColor = SystemColors.Control;
            tabPanel.Controls.Add(closeButtonPanel);
            tabPanel.Controls.Add(imageNamePanel);
            tabPanel.Dock = DockStyle.Fill;
            tabPanel.Location = new Point(0, 0);
            tabPanel.Margin = new Padding(0);
            tabPanel.Name = "tabPanel";
            tabPanel.Size = new Size(787, 33);
            tabPanel.TabIndex = 1;
            // 
            // closeButtonPanel
            // 
            closeButtonPanel.AutoSize = true;
            closeButtonPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            closeButtonPanel.BackColor = Color.Transparent;
            closeButtonPanel.Controls.Add(closeImage);
            closeButtonPanel.Dock = DockStyle.Left;
            closeButtonPanel.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            closeButtonPanel.Location = new Point(72, 0);
            closeButtonPanel.Margin = new Padding(0);
            closeButtonPanel.MinimumSize = new Size(72, 33);
            closeButtonPanel.Name = "closeButtonPanel";
            closeButtonPanel.Size = new Size(72, 33);
            closeButtonPanel.TabIndex = 3;
            // 
            // closeImage
            // 
            closeImage.AutoSize = true;
            closeImage.BackColor = SystemColors.ControlLightLight;
            closeImage.Dock = DockStyle.Left;
            closeImage.FlatAppearance.BorderSize = 0;
            closeImage.FlatStyle = FlatStyle.Flat;
            closeImage.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            closeImage.ForeColor = SystemColors.ActiveCaptionText;
            closeImage.Image = Properties.Resources.close;
            closeImage.Location = new Point(0, 0);
            closeImage.Margin = new Padding(0);
            closeImage.Name = "closeImage";
            closeImage.Padding = new Padding(0, 0, 2, 0);
            closeImage.Size = new Size(27, 33);
            closeImage.TabIndex = 2;
            closeImage.TextAlign = ContentAlignment.MiddleRight;
            closeImage.UseVisualStyleBackColor = false;
            closeImage.Click += closeImage_Click;
            // 
            // imageNamePanel
            // 
            imageNamePanel.AutoSize = true;
            imageNamePanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            imageNamePanel.BackColor = SystemColors.ControlLightLight;
            imageNamePanel.Controls.Add(imageNameLabel);
            imageNamePanel.Dock = DockStyle.Left;
            imageNamePanel.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            imageNamePanel.Location = new Point(0, 0);
            imageNamePanel.Margin = new Padding(0);
            imageNamePanel.MinimumSize = new Size(72, 33);
            imageNamePanel.Name = "imageNamePanel";
            imageNamePanel.Size = new Size(72, 33);
            imageNamePanel.TabIndex = 1;
            // 
            // imageNameLabel
            // 
            imageNameLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            imageNameLabel.AutoSize = true;
            imageNameLabel.FlatStyle = FlatStyle.Flat;
            imageNameLabel.ForeColor = SystemColors.ActiveCaptionText;
            imageNameLabel.Location = new Point(3, 10);
            imageNameLabel.Name = "imageNameLabel";
            imageNameLabel.Size = new Size(41, 13);
            imageNameLabel.TabIndex = 44;
            imageNameLabel.Text = "label10";
            imageNameLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // featuresPanel
            // 
            featuresPanel.BackColor = SystemColors.ControlLight;
            featuresPanel.ColumnCount = 2;
            featuresPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 13.5F));
            featuresPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 86.5F));
            featuresPanel.Controls.Add(buttonsPanel, 0, 0);
            featuresPanel.Controls.Add(mainFeatures, 1, 0);
            featuresPanel.Dock = DockStyle.Fill;
            featuresPanel.Location = new Point(1022, 32);
            featuresPanel.Margin = new Padding(0);
            featuresPanel.Name = "featuresPanel";
            featuresPanel.RowCount = 1;
            featuresPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            featuresPanel.Size = new Size(400, 771);
            featuresPanel.TabIndex = 36;
            // 
            // buttonsPanel
            // 
            buttonsPanel.BackColor = SystemColors.ControlLight;
            buttonsPanel.Controls.Add(buttonsSection);
            buttonsPanel.Dock = DockStyle.Fill;
            buttonsPanel.Location = new Point(2, 0);
            buttonsPanel.Margin = new Padding(2, 0, 0, 0);
            buttonsPanel.Name = "buttonsPanel";
            buttonsPanel.Size = new Size(52, 771);
            buttonsPanel.TabIndex = 0;
            // 
            // buttonsSection
            // 
            buttonsSection.BackColor = SystemColors.ControlLight;
            buttonsSection.ColumnCount = 1;
            buttonsSection.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            buttonsSection.Controls.Add(otherButtons, 0, 2);
            buttonsSection.Controls.Add(backgroundButtons, 0, 0);
            buttonsSection.Controls.Add(compressionButtons, 0, 1);
            buttonsSection.Dock = DockStyle.Top;
            buttonsSection.Location = new Point(0, 0);
            buttonsSection.Margin = new Padding(0, 3, 0, 0);
            buttonsSection.Name = "buttonsSection";
            buttonsSection.RowCount = 3;
            buttonsSection.RowStyles.Add(new RowStyle(SizeType.Absolute, 150F));
            buttonsSection.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            buttonsSection.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            buttonsSection.Size = new Size(52, 351);
            buttonsSection.TabIndex = 0;
            // 
            // otherButtons
            // 
            otherButtons.BackColor = SystemColors.ControlLightLight;
            otherButtons.Controls.Add(rawImage);
            otherButtons.Controls.Add(darkLightMode);
            otherButtons.Dock = DockStyle.Fill;
            otherButtons.FlowDirection = FlowDirection.TopDown;
            otherButtons.Location = new Point(0, 250);
            otherButtons.Margin = new Padding(0, 0, 0, 2);
            otherButtons.Name = "otherButtons";
            otherButtons.Padding = new Padding(7, 6, 6, 6);
            otherButtons.Size = new Size(52, 99);
            otherButtons.TabIndex = 4;
            // 
            // rawImage
            // 
            rawImage.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rawImage.BackColor = Color.FromArgb(217, 217, 217);
            rawImage.FlatStyle = FlatStyle.Flat;
            rawImage.Image = Properties.Resources.raw;
            rawImage.Location = new Point(7, 6);
            rawImage.Margin = new Padding(0, 0, 0, 5);
            rawImage.Name = "rawImage";
            rawImage.Size = new Size(40, 40);
            rawImage.TabIndex = 4;
            rawImage.UseVisualStyleBackColor = false;
            rawImage.Click += rawImage_Click;
            // 
            // darkLightMode
            // 
            darkLightMode.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            darkLightMode.BackColor = Color.Black;
            darkLightMode.FlatStyle = FlatStyle.Flat;
            darkLightMode.Image = Properties.Resources.darkmode_light;
            darkLightMode.Location = new Point(7, 51);
            darkLightMode.Margin = new Padding(0);
            darkLightMode.Name = "darkLightMode";
            darkLightMode.Size = new Size(40, 40);
            darkLightMode.TabIndex = 5;
            darkLightMode.UseVisualStyleBackColor = false;
            darkLightMode.Click += modeToggleButton_Click;
            // 
            // backgroundButtons
            // 
            backgroundButtons.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            backgroundButtons.BackColor = SystemColors.ControlLightLight;
            backgroundButtons.Controls.Add(removeBG);
            backgroundButtons.Controls.Add(colorBG);
            backgroundButtons.Controls.Add(imageBG);
            backgroundButtons.FlowDirection = FlowDirection.TopDown;
            backgroundButtons.Location = new Point(0, 0);
            backgroundButtons.Margin = new Padding(0, 0, 0, 2);
            backgroundButtons.Name = "backgroundButtons";
            backgroundButtons.Padding = new Padding(7, 6, 6, 6);
            backgroundButtons.Size = new Size(52, 148);
            backgroundButtons.TabIndex = 2;
            // 
            // removeBG
            // 
            removeBG.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            removeBG.BackColor = Color.FromArgb(217, 217, 217);
            removeBG.FlatStyle = FlatStyle.Flat;
            removeBG.Image = Properties.Resources.removebg;
            removeBG.Location = new Point(7, 6);
            removeBG.Margin = new Padding(0, 0, 0, 5);
            removeBG.Name = "removeBG";
            removeBG.Size = new Size(40, 40);
            removeBG.TabIndex = 1;
            removeBG.UseVisualStyleBackColor = false;
            removeBG.Click += BatchProcessImages_Click;
            removeBG.MouseHover += removeBG_MouseHover;
            // 
            // colorBG
            // 
            colorBG.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            colorBG.BackColor = Color.FromArgb(217, 217, 217);
            colorBG.FlatStyle = FlatStyle.Flat;
            colorBG.Image = Properties.Resources.colorbg;
            colorBG.Location = new Point(7, 51);
            colorBG.Margin = new Padding(0, 0, 0, 5);
            colorBG.Name = "colorBG";
            colorBG.Size = new Size(40, 40);
            colorBG.TabIndex = 2;
            colorBG.UseVisualStyleBackColor = false;
            colorBG.Click += btnChooseBackgroundColor_Click;
            colorBG.MouseHover += colorBG_MouseHover;
            // 
            // imageBG
            // 
            imageBG.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            imageBG.BackColor = Color.FromArgb(217, 217, 217);
            imageBG.FlatStyle = FlatStyle.Flat;
            imageBG.Image = Properties.Resources.imagebg;
            imageBG.Location = new Point(7, 96);
            imageBG.Margin = new Padding(0);
            imageBG.Name = "imageBG";
            imageBG.Size = new Size(40, 40);
            imageBG.TabIndex = 3;
            imageBG.UseVisualStyleBackColor = false;
            imageBG.Click += btnChooseBackgroundImage_Click;
            imageBG.MouseHover += imageBG_MouseHover;
            // 
            // compressionButtons
            // 
            compressionButtons.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            compressionButtons.BackColor = SystemColors.ControlLightLight;
            compressionButtons.Controls.Add(rleFeature);
            compressionButtons.Controls.Add(Button_Huffman);
            compressionButtons.FlowDirection = FlowDirection.TopDown;
            compressionButtons.Location = new Point(0, 150);
            compressionButtons.Margin = new Padding(0, 0, 0, 2);
            compressionButtons.Name = "compressionButtons";
            compressionButtons.Padding = new Padding(7, 6, 6, 6);
            compressionButtons.Size = new Size(52, 98);
            compressionButtons.TabIndex = 3;
            // 
            // rleFeature
            // 
            rleFeature.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            rleFeature.BackColor = Color.FromArgb(217, 217, 217);
            rleFeature.FlatStyle = FlatStyle.Flat;
            rleFeature.Image = Properties.Resources.rle;
            rleFeature.Location = new Point(7, 6);
            rleFeature.Margin = new Padding(0, 0, 0, 5);
            rleFeature.Name = "rleFeature";
            rleFeature.Size = new Size(40, 40);
            rleFeature.TabIndex = 4;
            rleFeature.UseVisualStyleBackColor = false;
            rleFeature.Click += RLECompression_click;
            rleFeature.MouseHover += rleFeature_MouseHover;
            // 
            // Button_Huffman
            // 
            Button_Huffman.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            Button_Huffman.BackColor = Color.FromArgb(217, 217, 217);
            Button_Huffman.FlatStyle = FlatStyle.Flat;
            Button_Huffman.Image = Properties.Resources.huffman;
            Button_Huffman.Location = new Point(7, 51);
            Button_Huffman.Margin = new Padding(0);
            Button_Huffman.Name = "Button_Huffman";
            Button_Huffman.Size = new Size(40, 40);
            Button_Huffman.TabIndex = 5;
            Button_Huffman.UseVisualStyleBackColor = false;
            // 
            // mainFeatures
            // 
            mainFeatures.BackColor = SystemColors.ControlLight;
            mainFeatures.ColumnCount = 1;
            mainFeatures.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            mainFeatures.Controls.Add(allFeaturesPanel, 0, 0);
            mainFeatures.Dock = DockStyle.Fill;
            mainFeatures.ForeColor = SystemColors.ActiveCaption;
            mainFeatures.Location = new Point(57, 0);
            mainFeatures.Margin = new Padding(3, 0, 0, 0);
            mainFeatures.Name = "mainFeatures";
            mainFeatures.RowCount = 1;
            mainFeatures.RowStyles.Add(new RowStyle());
            mainFeatures.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            mainFeatures.Size = new Size(343, 771);
            mainFeatures.TabIndex = 1;
            // 
            // allFeaturesPanel
            // 
            allFeaturesPanel.Controls.Add(Panel_FeatureButton);
            allFeaturesPanel.Controls.Add(Panel_FeatureName);
            allFeaturesPanel.Controls.Add(Panel_imageEnhancement);
            allFeaturesPanel.Dock = DockStyle.Fill;
            allFeaturesPanel.Location = new Point(0, 0);
            allFeaturesPanel.Margin = new Padding(0, 0, 2, 0);
            allFeaturesPanel.Name = "allFeaturesPanel";
            allFeaturesPanel.Size = new Size(341, 771);
            allFeaturesPanel.TabIndex = 0;
            // 
            // Panel_FeatureButton
            // 
            Panel_FeatureButton.BackColor = SystemColors.ControlLight;
            Panel_FeatureButton.Controls.Add(Button_BasicEnhancement);
            Panel_FeatureButton.Controls.Add(Button_SpatialFiltering);
            Panel_FeatureButton.Controls.Add(Button_RestoreDegrade);
            Panel_FeatureButton.Dock = DockStyle.Top;
            Panel_FeatureButton.Location = new Point(0, 25);
            Panel_FeatureButton.Margin = new Padding(2, 2, 0, 0);
            Panel_FeatureButton.Name = "Panel_FeatureButton";
            Panel_FeatureButton.Size = new Size(341, 40);
            Panel_FeatureButton.TabIndex = 1;
            // 
            // Button_BasicEnhancement
            // 
            Button_BasicEnhancement.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Button_BasicEnhancement.BackColor = SystemColors.ControlLightLight;
            Button_BasicEnhancement.FlatAppearance.BorderSize = 0;
            Button_BasicEnhancement.FlatAppearance.MouseOverBackColor = SystemColors.ControlLightLight;
            Button_BasicEnhancement.FlatStyle = FlatStyle.Flat;
            Button_BasicEnhancement.Image = Properties.Resources.basic;
            Button_BasicEnhancement.Location = new Point(0, 3);
            Button_BasicEnhancement.Margin = new Padding(0, 3, 0, 0);
            Button_BasicEnhancement.Name = "Button_BasicEnhancement";
            Button_BasicEnhancement.Size = new Size(38, 38);
            Button_BasicEnhancement.TabIndex = 2;
            Button_BasicEnhancement.UseVisualStyleBackColor = false;
            Button_BasicEnhancement.Click += basicEnhancement_Click;
            // 
            // Button_SpatialFiltering
            // 
            Button_SpatialFiltering.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Button_SpatialFiltering.BackColor = SystemColors.ScrollBar;
            Button_SpatialFiltering.FlatAppearance.BorderSize = 0;
            Button_SpatialFiltering.FlatAppearance.MouseOverBackColor = SystemColors.ControlLightLight;
            Button_SpatialFiltering.FlatStyle = FlatStyle.Flat;
            Button_SpatialFiltering.Image = Properties.Resources.filter;
            Button_SpatialFiltering.Location = new Point(38, 3);
            Button_SpatialFiltering.Margin = new Padding(0, 3, 0, 0);
            Button_SpatialFiltering.Name = "Button_SpatialFiltering";
            Button_SpatialFiltering.Size = new Size(38, 38);
            Button_SpatialFiltering.TabIndex = 3;
            Button_SpatialFiltering.UseVisualStyleBackColor = false;
            Button_SpatialFiltering.Click += SpatialFiltering_Click;
            // 
            // Button_RestoreDegrade
            // 
            Button_RestoreDegrade.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Button_RestoreDegrade.BackColor = SystemColors.ScrollBar;
            Button_RestoreDegrade.FlatAppearance.BorderSize = 0;
            Button_RestoreDegrade.FlatAppearance.MouseOverBackColor = SystemColors.ControlLightLight;
            Button_RestoreDegrade.FlatStyle = FlatStyle.Flat;
            Button_RestoreDegrade.Image = Properties.Resources.restore;
            Button_RestoreDegrade.Location = new Point(76, 3);
            Button_RestoreDegrade.Margin = new Padding(0, 3, 0, 0);
            Button_RestoreDegrade.Name = "Button_RestoreDegrade";
            Button_RestoreDegrade.Size = new Size(38, 38);
            Button_RestoreDegrade.TabIndex = 4;
            Button_RestoreDegrade.UseVisualStyleBackColor = false;
            Button_RestoreDegrade.Click += Button_RestoreDegrade_Click;
            // 
            // Panel_FeatureName
            // 
            Panel_FeatureName.BackColor = SystemColors.ControlLightLight;
            Panel_FeatureName.Controls.Add(Label_Feature);
            Panel_FeatureName.Dock = DockStyle.Top;
            Panel_FeatureName.Location = new Point(0, 0);
            Panel_FeatureName.Margin = new Padding(2, 0, 0, 3);
            Panel_FeatureName.Name = "Panel_FeatureName";
            Panel_FeatureName.Size = new Size(341, 25);
            Panel_FeatureName.TabIndex = 0;
            // 
            // Label_Feature
            // 
            Label_Feature.AutoSize = true;
            Label_Feature.ForeColor = SystemColors.ActiveCaptionText;
            Label_Feature.Location = new Point(3, 5);
            Label_Feature.Name = "Label_Feature";
            Label_Feature.Size = new Size(48, 15);
            Label_Feature.TabIndex = 0;
            Label_Feature.Text = "label10";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.Location = new Point(72, 32);
            panel1.Name = "panel1";
            panel1.Size = new Size(648, 589);
            panel1.TabIndex = 41;
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1424, 811);
            Controls.Add(originalImagePanel);
            Controls.Add(menuStrip1);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = SystemColors.ActiveBorder;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 3, 4, 3);
            MinimumSize = new Size(1440, 850);
            Name = "Form1";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Image Processing";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imageChannel).EndInit();
            editPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)showCompressed).EndInit();
            ((System.ComponentModel.ISupportInitialize)showOriginal).EndInit();
            Panel_Enhancement.ResumeLayout(false);
            Table_ShowHistogram.ResumeLayout(false);
            Panel_Histogram.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            Table_BW.ResumeLayout(false);
            Table_BW.PerformLayout();
            Panel_BW.ResumeLayout(false);
            Panel_BW.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bw_trackbar).EndInit();
            Table_Gray.ResumeLayout(false);
            Table_Gray.PerformLayout();
            Panel_Gray.ResumeLayout(false);
            Table_RGBChannel.ResumeLayout(false);
            Table_RGBChannel.PerformLayout();
            Panel_RGBChannel.ResumeLayout(false);
            Panel_Spatial.ResumeLayout(false);
            Table_Gradient.ResumeLayout(false);
            Table_Gradient.PerformLayout();
            Panel_Gradient.ResumeLayout(false);
            Table_SharpeningFilter.ResumeLayout(false);
            Table_SharpeningFilter.PerformLayout();
            Panel_SharpeningFilter.ResumeLayout(false);
            Table_SmoothChannels.ResumeLayout(false);
            Table_SmoothChannels.PerformLayout();
            Panel_SmoothChannels.ResumeLayout(false);
            Panel_RestoreDegrade.ResumeLayout(false);
            Table_NoiseHistogram.ResumeLayout(false);
            Panel_NoiseHistogram.ResumeLayout(false);
            Table_Restoration.ResumeLayout(false);
            Table_Restoration.PerformLayout();
            Panel_OrderStat.ResumeLayout(false);
            Panel_OrderStat.PerformLayout();
            Panel_Geometric.ResumeLayout(false);
            Panel_Contraharmonic.ResumeLayout(false);
            Panel_Contraharmonic.PerformLayout();
            Table_Degrade.ResumeLayout(false);
            Table_Degrade.PerformLayout();
            Panel_OtherNoise.ResumeLayout(false);
            Panel_SaltPepperNoise.ResumeLayout(false);
            Panel_SaltPepperNoise.PerformLayout();
            Panel_imageEnhancement.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)displayColor).EndInit();
            ((System.ComponentModel.ISupportInitialize)ViewImage).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            headerinfoPanel.ResumeLayout(false);
            colorPalettePanel.ResumeLayout(false);
            pixelInfoPanel.ResumeLayout(false);
            displayOriginalPanel.ResumeLayout(false);
            displayTable.ResumeLayout(false);
            tabPanel.ResumeLayout(false);
            tabPanel.PerformLayout();
            closeButtonPanel.ResumeLayout(false);
            closeButtonPanel.PerformLayout();
            imageNamePanel.ResumeLayout(false);
            imageNamePanel.PerformLayout();
            featuresPanel.ResumeLayout(false);
            buttonsPanel.ResumeLayout(false);
            buttonsSection.ResumeLayout(false);
            otherButtons.ResumeLayout(false);
            backgroundButtons.ResumeLayout(false);
            compressionButtons.ResumeLayout(false);
            mainFeatures.ResumeLayout(false);
            allFeaturesPanel.ResumeLayout(false);
            Panel_FeatureButton.ResumeLayout(false);
            Panel_FeatureName.ResumeLayout(false);
            Panel_FeatureName.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem menu1ToolStripMenuItem;
        private ToolStripMenuItem menu2ToolStripMenuItem;
        private ToolStripMenuItem filterToolStripMenuItem;
        private RichTextBox PCXheaderInfoBox;
        private ToolStripMenuItem spatialFiltering;
        private PictureBox imageChannel;
        private Button button4;
        private Label Label_Degrade;
        private Button button6;
        private Button button5;
        private TextBox pepperProb;
        private Label Label_Pepper;
        private TextBox saltProb;
        private Label Label_Salt;
        private Button geometricFilter;
        private Button contraHarmonicFilter;
        private Button minFilter;
        private Button medianFilter;
        private TextBox qValue;
        private Label Label_Q;
        private Button midpointFilter;
        private Button maxFilter;
        private ToolStripMenuItem huffmanCodingToolStripMenuItem;
        private Panel editPanel;
        private Label redPixel;
        private PictureBox displayColor;
        private Button flipHorizontal;
        private Button flipVertical;
        private Button clockwise;
        private Button counterClockwise;
        private ToolStripMenuItem openImageFileToolStripMenuItem;
        private ToolStripMenuItem openPCXFileToolStripMenuItem;
        private Label headerInfoLabel;
        private Label colorPalette;
        private Label pixelInfo;
        private Button redBox;
        private Label bluePixel;
        private Label greenPixel;
        private Button blueBox;
        private Button greenBox;
        private Panel originalImagePanel;
        private Label originalImageLabel;
        private PictureBox ViewImage;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel displayOriginalPanel;
        private Panel headerinfoPanel;
        private Panel colorPalettePanel;
        private Panel pixelInfoPanel;
        private Panel paletteDisplay;
        private TableLayoutPanel displayTable;
        private Panel tabPanel;
        private TableLayoutPanel featuresPanel;
        private Panel buttonsPanel;
        private TableLayoutPanel buttonsSection;
        private Button removeBG;
        private FlowLayoutPanel backgroundButtons;
        private Button colorBG;
        private Button imageBG;
        private ToolTip toolTip1;
        private FlowLayoutPanel compressionButtons;
        private Button rleFeature;
        private Label compressedLabel;
        private PictureBox showCompressed;
        private PictureBox showOriginal;
        private Label originalLabel;
        private FlowLayoutPanel otherButtons;
        private Button rawImage;
        private Button darkLightMode;
        private Button closeImage;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private Panel closeButtonPanel;
        private Panel imageNamePanel;
        private Label imageNameLabel;
        private TableLayoutPanel mainFeatures;
        private Panel allFeaturesPanel;
        private FlowLayoutPanel Panel_FeatureButton;
        private Panel Panel_FeatureName;
        private Label Label_Feature;
        private Panel Panel_imageEnhancement;
        private Button Button_BasicEnhancement;
        private Button Button_SpatialFiltering;
        private Button Button_Huffman;
        private Panel Panel_Spatial;
        private Button Button_Gradient;
        private Button Button_Averaging;
        private Button Button_Median;
        private Button Button_RestoreDegrade;
        private Panel Panel_RestoreDegrade;
        private Label Label_OrderStat;
        private TableLayoutPanel Table_Degrade;
        private Panel Panel_SaltPepperNoise;
        private Panel Panel_OtherNoise;
        private TableLayoutPanel Table_Restoration;
        private Panel Panel_OrderStat;
        private Panel Panel_Geometric;
        private Label Label_Restoration;
        private Panel Panel_Contraharmonic;
        private TableLayoutPanel Table_NoiseHistogram;
        private Panel Panel_NoiseHistogram;
        private Panel Panel_ShowNoiseHistogram;
        private Label Label_NoiseHistogram;
        private TableLayoutPanel Table_RGBChannel;
        private Label Label_RGBChannel;
        private Panel Panel_RGBChannel;
        private Button Button_Red;
        private Button Button_Green;
        private Button Button_Blue;
        private Panel Panel_Enhancement;
        private TableLayoutPanel tableLayoutPanel6;
        private Label Label_Gamma;
        private Panel panel5;
        private TableLayoutPanel Table_BW;
        private Label Label_BW;
        private Panel Panel_BW;
        private Label Label_BWAdjust;
        private TrackBar bw_trackbar;
        private TableLayoutPanel Table_Gray;
        private Label Label_Grayscale;
        private Panel Panel_Gray;
        private Button button7;
        private Button button8;
        private TableLayoutPanel Table_ShowHistogram;
        private Panel Panel_Histogram;
        private Panel Panel_HistogramContainer;
        private Label Label_Histogram;
        private Label Label_GammaValues;
        private Button button10;
        private TextBox gamma_textbox;
        private TableLayoutPanel Table_SmoothChannels;
        private Label Label_Smooth;
        private Panel Panel_SmoothChannels;
        private TableLayoutPanel Table_Gradient;
        private Label Label_Gradient;
        private Panel Panel_Gradient;
        private TableLayoutPanel Table_SharpeningFilter;
        private Label Label_Sharpening;
        private Panel Panel_SharpeningFilter;
        private Button button1;
        private Button button2;
        private Button button3;
        private Panel panel1;
    }
}