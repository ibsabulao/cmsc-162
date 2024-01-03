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
            button3 = new Button();
            label2 = new Label();
            gamma_textbox = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            bw_trackbar = new TrackBar();
            button2 = new Button();
            button1 = new Button();
            Red = new Button();
            Green = new Button();
            Blue = new Button();
            button4 = new Button();
            label5 = new Label();
            label6 = new Label();
            pepperProb = new TextBox();
            saltProb = new TextBox();
            label7 = new Label();
            button6 = new Button();
            button5 = new Button();
            midpointFilter = new Button();
            maxFilter = new Button();
            minFilter = new Button();
            medianFilter = new Button();
            qValue = new TextBox();
            label9 = new Label();
            contraHarmonicFilter = new Button();
            geometricFilter = new Button();
            label8 = new Label();
            PCXheaderInfoBox = new RichTextBox();
            imageChannel = new PictureBox();
            editPanel = new Panel();
            counterClockwise = new Button();
            originalLabel = new Label();
            clockwise = new Button();
            compressedLabel = new Label();
            flipVertical = new Button();
            showCompressed = new PictureBox();
            flipHorizontal = new Button();
            showOriginal = new PictureBox();
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
            tableLayoutPanel4 = new TableLayoutPanel();
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
            tableLayoutPanel3 = new TableLayoutPanel();
            featuresTab = new TabControl();
            imageEnhancement = new TabPage();
            rgbChannel_Label = new Label();
            pointProcessing = new TabPage();
            tabPage3 = new TabPage();
            toolTip1 = new ToolTip(components);
            displayHistogram = new PictureBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bw_trackbar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imageChannel).BeginInit();
            editPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)showCompressed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)showOriginal).BeginInit();
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
            tableLayoutPanel4.SuspendLayout();
            buttonsPanel.SuspendLayout();
            buttonsSection.SuspendLayout();
            otherButtons.SuspendLayout();
            backgroundButtons.SuspendLayout();
            compressionButtons.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            featuresTab.SuspendLayout();
            imageEnhancement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)displayHistogram).BeginInit();
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
            menuStrip1.Size = new Size(1422, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // menu1ToolStripMenuItem
            // 
            menu1ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openImageFileToolStripMenuItem, openPCXFileToolStripMenuItem, saveToolStripMenuItem, saveAsToolStripMenuItem });
            menu1ToolStripMenuItem.Font = new Font("Inter", 9F, FontStyle.Regular, GraphicsUnit.Point);
            menu1ToolStripMenuItem.Name = "menu1ToolStripMenuItem";
            menu1ToolStripMenuItem.Size = new Size(48, 22);
            menu1ToolStripMenuItem.Text = "File";
            // 
            // openImageFileToolStripMenuItem
            // 
            openImageFileToolStripMenuItem.Image = Properties.Resources.open;
            openImageFileToolStripMenuItem.Name = "openImageFileToolStripMenuItem";
            openImageFileToolStripMenuItem.Size = new Size(205, 26);
            openImageFileToolStripMenuItem.Text = "Open Image File";
            openImageFileToolStripMenuItem.Click += ViewImage_Click;
            // 
            // openPCXFileToolStripMenuItem
            // 
            openPCXFileToolStripMenuItem.Image = Properties.Resources.openpcx;
            openPCXFileToolStripMenuItem.Name = "openPCXFileToolStripMenuItem";
            openPCXFileToolStripMenuItem.Size = new Size(205, 26);
            openPCXFileToolStripMenuItem.Text = "Open PCX File";
            openPCXFileToolStripMenuItem.Click += ViewPCX_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Image = Properties.Resources.save;
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(205, 26);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // saveAsToolStripMenuItem
            // 
            saveAsToolStripMenuItem.Image = Properties.Resources.saveas;
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            saveAsToolStripMenuItem.Size = new Size(205, 26);
            saveAsToolStripMenuItem.Text = "Save As";
            saveAsToolStripMenuItem.Click += saveAsToolStripMenuItem_Click;
            // 
            // menu2ToolStripMenuItem
            // 
            menu2ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { huffmanCodingToolStripMenuItem });
            menu2ToolStripMenuItem.Font = new Font("Inter", 9F, FontStyle.Regular, GraphicsUnit.Point);
            menu2ToolStripMenuItem.Name = "menu2ToolStripMenuItem";
            menu2ToolStripMenuItem.Size = new Size(117, 22);
            menu2ToolStripMenuItem.Text = "Compression";
            // 
            // huffmanCodingToolStripMenuItem
            // 
            huffmanCodingToolStripMenuItem.Name = "huffmanCodingToolStripMenuItem";
            huffmanCodingToolStripMenuItem.Size = new Size(205, 26);
            huffmanCodingToolStripMenuItem.Text = "Huffman Coding";
            huffmanCodingToolStripMenuItem.Click += huffmanCompression_Click;
            // 
            // filterToolStripMenuItem
            // 
            filterToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { spatialFiltering });
            filterToolStripMenuItem.Font = new Font("Inter", 9F, FontStyle.Regular, GraphicsUnit.Point);
            filterToolStripMenuItem.Name = "filterToolStripMenuItem";
            filterToolStripMenuItem.Size = new Size(59, 22);
            filterToolStripMenuItem.Text = "Filter";
            // 
            // spatialFiltering
            // 
            spatialFiltering.Name = "spatialFiltering";
            spatialFiltering.Size = new Size(201, 26);
            spatialFiltering.Text = "Spatial Filtering";
            spatialFiltering.Click += spatialFiltering_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.None;
            button3.AutoSize = true;
            button3.BackColor = Color.DimGray;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(209, 286);
            button3.Margin = new Padding(4);
            button3.Name = "button3";
            button3.Size = new Size(107, 40);
            button3.TabIndex = 11;
            button3.Text = "Transform";
            button3.UseVisualStyleBackColor = false;
            button3.Click += GammaTransform_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(26, 269);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(133, 15);
            label2.TabIndex = 16;
            label2.Text = "Input Gamma (𝛾) values";
            // 
            // gamma_textbox
            // 
            gamma_textbox.BackColor = SystemColors.ControlLight;
            gamma_textbox.Location = new Point(29, 289);
            gamma_textbox.Margin = new Padding(4);
            gamma_textbox.Name = "gamma_textbox";
            gamma_textbox.Size = new Size(165, 25);
            gamma_textbox.TabIndex = 17;
            gamma_textbox.KeyPress += textBox1_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlText;
            label4.Location = new Point(26, 251);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(183, 20);
            label4.TabIndex = 18;
            label4.Text = "Gamma Transformation\r\n";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(26, 167);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(163, 15);
            label3.TabIndex = 17;
            label3.Text = "Adjust B/W Threshold [0, 255]";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(26, 147);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(215, 20);
            label1.TabIndex = 15;
            label1.Text = "Black/White Transformation\r\n";
            // 
            // bw_trackbar
            // 
            bw_trackbar.BackColor = SystemColors.Window;
            bw_trackbar.Location = new Point(16, 193);
            bw_trackbar.Margin = new Padding(2, 3, 2, 3);
            bw_trackbar.Maximum = 255;
            bw_trackbar.Name = "bw_trackbar";
            bw_trackbar.Size = new Size(300, 56);
            bw_trackbar.TabIndex = 13;
            bw_trackbar.TickFrequency = 15;
            bw_trackbar.TickStyle = TickStyle.TopLeft;
            bw_trackbar.ValueChanged += BW_Scroll;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.AutoSize = true;
            button2.BackColor = Color.DarkSlateGray;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Image = Properties.Resources.negative1;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(46, 93);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Padding = new Padding(7, 0, 7, 0);
            button2.Size = new Size(118, 42);
            button2.TabIndex = 10;
            button2.Text = "Negative";
            button2.TextAlign = ContentAlignment.MiddleRight;
            button2.UseVisualStyleBackColor = false;
            button2.Click += Negative_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.AutoSize = true;
            button1.BackColor = Color.Gray;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Image = Properties.Resources.bw;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(172, 93);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Padding = new Padding(7, 0, 7, 0);
            button1.Size = new Size(124, 42);
            button1.TabIndex = 9;
            button1.Text = "Greyscale";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = false;
            button1.Click += Grayscale_Click;
            // 
            // Red
            // 
            Red.Anchor = AnchorStyles.Top;
            Red.BackColor = Color.FromArgb(241, 76, 76);
            Red.FlatStyle = FlatStyle.Flat;
            Red.ForeColor = SystemColors.ButtonHighlight;
            Red.ImageAlign = ContentAlignment.MiddleLeft;
            Red.Location = new Point(26, 38);
            Red.Margin = new Padding(4);
            Red.Name = "Red";
            Red.Size = new Size(89, 42);
            Red.TabIndex = 6;
            Red.Text = "Red";
            Red.UseVisualStyleBackColor = false;
            Red.Click += Red_Click;
            // 
            // Green
            // 
            Green.Anchor = AnchorStyles.Top;
            Green.BackColor = Color.FromArgb(69, 165, 73);
            Green.FlatStyle = FlatStyle.Flat;
            Green.ForeColor = SystemColors.ButtonHighlight;
            Green.Location = new Point(123, 37);
            Green.Margin = new Padding(4);
            Green.Name = "Green";
            Green.Size = new Size(89, 42);
            Green.TabIndex = 7;
            Green.Text = "Green";
            Green.UseVisualStyleBackColor = false;
            Green.Click += Green_Click;
            // 
            // Blue
            // 
            Blue.Anchor = AnchorStyles.Top;
            Blue.BackColor = Color.FromArgb(70, 124, 229);
            Blue.FlatStyle = FlatStyle.Flat;
            Blue.ForeColor = SystemColors.ButtonHighlight;
            Blue.Location = new Point(220, 38);
            Blue.Margin = new Padding(4);
            Blue.Name = "Blue";
            Blue.Size = new Size(89, 42);
            Blue.TabIndex = 8;
            Blue.Text = "Blue";
            Blue.UseVisualStyleBackColor = false;
            Blue.Click += Blue_Click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ControlLightLight;
            button4.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = SystemColors.GrayText;
            button4.Location = new Point(485, 223);
            button4.Margin = new Padding(4);
            button4.Name = "button4";
            button4.Size = new Size(130, 48);
            button4.TabIndex = 20;
            button4.Text = "Salt-and-Pepper Noise";
            button4.UseVisualStyleBackColor = false;
            button4.Click += saltPepper_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ControlText;
            label5.Location = new Point(308, 174);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(148, 20);
            label5.TabIndex = 19;
            label5.Text = "Image Degradation";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ControlText;
            label6.Location = new Point(309, 201);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(124, 15);
            label6.TabIndex = 19;
            label6.Text = "Salt Probability [0, 0.5]";
            // 
            // pepperProb
            // 
            pepperProb.Location = new Point(56, 38);
            pepperProb.Margin = new Padding(4);
            pepperProb.Name = "pepperProb";
            pepperProb.Size = new Size(165, 25);
            pepperProb.TabIndex = 23;
            pepperProb.KeyPress += textBox1_KeyPress;
            // 
            // saltProb
            // 
            saltProb.Location = new Point(309, 219);
            saltProb.Margin = new Padding(4);
            saltProb.Name = "saltProb";
            saltProb.Size = new Size(165, 25);
            saltProb.TabIndex = 21;
            saltProb.KeyPress += textBox1_KeyPress;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ControlText;
            label7.Location = new Point(56, 20);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(142, 15);
            label7.TabIndex = 22;
            label7.Text = "Pepper Probability [0, 0.5]";
            // 
            // button6
            // 
            button6.BackColor = SystemColors.ControlLightLight;
            button6.Location = new Point(475, 305);
            button6.Margin = new Padding(4);
            button6.Name = "button6";
            button6.Size = new Size(139, 37);
            button6.TabIndex = 25;
            button6.Text = "Rayleigh Noise";
            button6.UseVisualStyleBackColor = false;
            button6.Click += rayleighNoise_Click;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.ControlLightLight;
            button5.Location = new Point(309, 305);
            button5.Margin = new Padding(4);
            button5.Name = "button5";
            button5.Size = new Size(157, 37);
            button5.TabIndex = 24;
            button5.Text = "Gaussian Noise";
            button5.UseVisualStyleBackColor = false;
            button5.Click += gaussianNoise_Click;
            // 
            // midpointFilter
            // 
            midpointFilter.BackColor = SystemColors.ControlLightLight;
            midpointFilter.Location = new Point(264, 683);
            midpointFilter.Margin = new Padding(4);
            midpointFilter.Name = "midpointFilter";
            midpointFilter.Size = new Size(145, 29);
            midpointFilter.TabIndex = 31;
            midpointFilter.Text = "Midpoint Filter";
            midpointFilter.UseVisualStyleBackColor = false;
            midpointFilter.Click += midpointFilter_Click;
            // 
            // maxFilter
            // 
            maxFilter.BackColor = SystemColors.ControlLightLight;
            maxFilter.Location = new Point(264, 648);
            maxFilter.Margin = new Padding(4);
            maxFilter.Name = "maxFilter";
            maxFilter.Size = new Size(145, 29);
            maxFilter.TabIndex = 30;
            maxFilter.Text = "Max Filter";
            maxFilter.UseVisualStyleBackColor = false;
            maxFilter.Click += maxFilter_Click;
            // 
            // minFilter
            // 
            minFilter.BackColor = SystemColors.ControlLightLight;
            minFilter.Location = new Point(105, 647);
            minFilter.Margin = new Padding(4);
            minFilter.Name = "minFilter";
            minFilter.Size = new Size(145, 29);
            minFilter.TabIndex = 29;
            minFilter.Text = "Min Filter";
            minFilter.UseVisualStyleBackColor = false;
            minFilter.Click += minFilter_Click;
            // 
            // medianFilter
            // 
            medianFilter.BackColor = SystemColors.ControlLightLight;
            medianFilter.Location = new Point(105, 683);
            medianFilter.Margin = new Padding(4);
            medianFilter.Name = "medianFilter";
            medianFilter.Size = new Size(145, 29);
            medianFilter.TabIndex = 28;
            medianFilter.Text = "Median Filter";
            medianFilter.UseVisualStyleBackColor = false;
            medianFilter.Click += medianFilter_Click;
            // 
            // qValue
            // 
            qValue.Location = new Point(105, 618);
            qValue.Margin = new Padding(4);
            qValue.Name = "qValue";
            qValue.Size = new Size(146, 25);
            qValue.TabIndex = 24;
            qValue.KeyPress += textBox1_KeyPress;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.ControlText;
            label9.Location = new Point(105, 600);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(50, 15);
            label9.TabIndex = 24;
            label9.Text = "Q value:";
            // 
            // contraHarmonicFilter
            // 
            contraHarmonicFilter.BackColor = SystemColors.ControlLightLight;
            contraHarmonicFilter.Location = new Point(264, 592);
            contraHarmonicFilter.Margin = new Padding(4);
            contraHarmonicFilter.Name = "contraHarmonicFilter";
            contraHarmonicFilter.Size = new Size(145, 50);
            contraHarmonicFilter.TabIndex = 27;
            contraHarmonicFilter.Text = "Contraharmonic Filter";
            contraHarmonicFilter.UseVisualStyleBackColor = false;
            contraHarmonicFilter.Click += contraHarmonicFilter_Click;
            // 
            // geometricFilter
            // 
            geometricFilter.BackColor = SystemColors.ControlLightLight;
            geometricFilter.Location = new Point(105, 558);
            geometricFilter.Margin = new Padding(4);
            geometricFilter.Name = "geometricFilter";
            geometricFilter.Size = new Size(304, 29);
            geometricFilter.TabIndex = 26;
            geometricFilter.Text = "Geometric Filter";
            geometricFilter.UseVisualStyleBackColor = false;
            geometricFilter.Click += geometricFilter_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ControlText;
            label8.Location = new Point(105, 534);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(142, 20);
            label8.TabIndex = 26;
            label8.Text = "Image Restoration";
            // 
            // PCXheaderInfoBox
            // 
            PCXheaderInfoBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PCXheaderInfoBox.BackColor = SystemColors.ControlLightLight;
            PCXheaderInfoBox.BorderStyle = BorderStyle.None;
            PCXheaderInfoBox.Font = new Font("Inter", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
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
            imageChannel.Size = new Size(557, 513);
            imageChannel.SizeMode = PictureBoxSizeMode.Zoom;
            imageChannel.TabIndex = 0;
            imageChannel.TabStop = false;
            // 
            // editPanel
            // 
            editPanel.BackColor = SystemColors.ControlLight;
            editPanel.Controls.Add(label8);
            editPanel.Controls.Add(geometricFilter);
            editPanel.Controls.Add(counterClockwise);
            editPanel.Controls.Add(originalLabel);
            editPanel.Controls.Add(clockwise);
            editPanel.Controls.Add(midpointFilter);
            editPanel.Controls.Add(compressedLabel);
            editPanel.Controls.Add(flipVertical);
            editPanel.Controls.Add(showCompressed);
            editPanel.Controls.Add(flipHorizontal);
            editPanel.Controls.Add(showOriginal);
            editPanel.Controls.Add(imageChannel);
            editPanel.Controls.Add(pepperProb);
            editPanel.Controls.Add(label7);
            editPanel.Controls.Add(contraHarmonicFilter);
            editPanel.Controls.Add(label9);
            editPanel.Controls.Add(qValue);
            editPanel.Controls.Add(medianFilter);
            editPanel.Controls.Add(minFilter);
            editPanel.Controls.Add(maxFilter);
            editPanel.Dock = DockStyle.Fill;
            editPanel.Location = new Point(0, 33);
            editPanel.Margin = new Padding(0);
            editPanel.Name = "editPanel";
            editPanel.Size = new Size(787, 740);
            editPanel.TabIndex = 34;
            // 
            // counterClockwise
            // 
            counterClockwise.Location = new Point(640, 653);
            counterClockwise.Margin = new Padding(4, 3, 4, 3);
            counterClockwise.Name = "counterClockwise";
            counterClockwise.Size = new Size(121, 55);
            counterClockwise.TabIndex = 43;
            counterClockwise.Text = "90-counter-clockwise";
            counterClockwise.UseVisualStyleBackColor = true;
            counterClockwise.Click += RotateCounterClockwiseButton_Click;
            // 
            // originalLabel
            // 
            originalLabel.Anchor = AnchorStyles.Top;
            originalLabel.ForeColor = SystemColors.AppWorkspace;
            originalLabel.Location = new Point(173, 474);
            originalLabel.MaximumSize = new Size(270, 30);
            originalLabel.Name = "originalLabel";
            originalLabel.Size = new Size(158, 18);
            originalLabel.TabIndex = 4;
            originalLabel.Text = "Original Image";
            originalLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // clockwise
            // 
            clockwise.Location = new Point(640, 620);
            clockwise.Margin = new Padding(4, 3, 4, 3);
            clockwise.Name = "clockwise";
            clockwise.Size = new Size(121, 30);
            clockwise.TabIndex = 42;
            clockwise.Text = "90-clockwise";
            clockwise.UseVisualStyleBackColor = true;
            clockwise.Click += RotateClockwiseButton_Click;
            // 
            // compressedLabel
            // 
            compressedLabel.Anchor = AnchorStyles.Top;
            compressedLabel.ForeColor = SystemColors.AppWorkspace;
            compressedLabel.Location = new Point(460, 474);
            compressedLabel.Name = "compressedLabel";
            compressedLabel.Size = new Size(146, 18);
            compressedLabel.TabIndex = 3;
            compressedLabel.Text = "Compressed Image";
            compressedLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // flipVertical
            // 
            flipVertical.Location = new Point(514, 653);
            flipVertical.Margin = new Padding(4, 3, 4, 3);
            flipVertical.Name = "flipVertical";
            flipVertical.Size = new Size(118, 30);
            flipVertical.TabIndex = 41;
            flipVertical.Text = "vertical";
            flipVertical.UseVisualStyleBackColor = true;
            flipVertical.Click += FlipVerticalButton_Click;
            // 
            // showCompressed
            // 
            showCompressed.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            showCompressed.Location = new Point(403, 197);
            showCompressed.Name = "showCompressed";
            showCompressed.Size = new Size(270, 270);
            showCompressed.TabIndex = 2;
            showCompressed.TabStop = false;
            // 
            // flipHorizontal
            // 
            flipHorizontal.Location = new Point(514, 620);
            flipHorizontal.Margin = new Padding(4, 3, 4, 3);
            flipHorizontal.Name = "flipHorizontal";
            flipHorizontal.Size = new Size(118, 30);
            flipHorizontal.TabIndex = 40;
            flipHorizontal.Text = "horizontal";
            flipHorizontal.UseVisualStyleBackColor = true;
            flipHorizontal.Click += FlipHorizontalButton_Click;
            // 
            // showOriginal
            // 
            showOriginal.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            showOriginal.Location = new Point(116, 197);
            showOriginal.Name = "showOriginal";
            showOriginal.Size = new Size(270, 270);
            showOriginal.TabIndex = 1;
            showOriginal.TabStop = false;
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
            headerInfoLabel.Font = new Font("Inter Medium", 9F, FontStyle.Regular, GraphicsUnit.Point);
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
            colorPalette.Font = new Font("Inter Medium", 9F, FontStyle.Regular, GraphicsUnit.Point);
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
            pixelInfo.Font = new Font("Inter Medium", 9F, FontStyle.Regular, GraphicsUnit.Point);
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
            originalImageLabel.Font = new Font("Inter Medium", 9F, FontStyle.Regular, GraphicsUnit.Point);
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
            tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 2, 0);
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
            closeButtonPanel.Font = new Font("Inter Semi Bold", 8F, FontStyle.Regular, GraphicsUnit.Point);
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
            closeImage.Font = new Font("Inter Semi Bold", 8F, FontStyle.Regular, GraphicsUnit.Point);
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
            imageNamePanel.Font = new Font("Inter Semi Bold", 8F, FontStyle.Regular, GraphicsUnit.Point);
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
            imageNameLabel.Location = new Point(3, 7);
            imageNameLabel.Name = "imageNameLabel";
            imageNameLabel.Size = new Size(55, 16);
            imageNameLabel.TabIndex = 44;
            imageNameLabel.Text = "label10";
            imageNameLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.BackColor = SystemColors.ControlLight;
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 13.5F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 86.5F));
            tableLayoutPanel4.Controls.Add(buttonsPanel, 0, 0);
            tableLayoutPanel4.Controls.Add(tableLayoutPanel3, 1, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(1022, 32);
            tableLayoutPanel4.Margin = new Padding(0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(400, 771);
            tableLayoutPanel4.TabIndex = 36;
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
            buttonsSection.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            buttonsSection.Controls.Add(otherButtons, 0, 2);
            buttonsSection.Controls.Add(backgroundButtons, 0, 0);
            buttonsSection.Controls.Add(compressionButtons, 0, 1);
            buttonsSection.Dock = DockStyle.Top;
            buttonsSection.Location = new Point(0, 0);
            buttonsSection.Margin = new Padding(0, 3, 0, 0);
            buttonsSection.Name = "buttonsSection";
            buttonsSection.RowCount = 3;
            buttonsSection.RowStyles.Add(new RowStyle(SizeType.Percent, 49.14676F));
            buttonsSection.RowStyles.Add(new RowStyle(SizeType.Percent, 50.85324F));
            buttonsSection.RowStyles.Add(new RowStyle(SizeType.Absolute, 140F));
            buttonsSection.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            buttonsSection.Size = new Size(52, 434);
            buttonsSection.TabIndex = 0;
            // 
            // otherButtons
            // 
            otherButtons.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            otherButtons.BackColor = SystemColors.ControlLightLight;
            otherButtons.Controls.Add(rawImage);
            otherButtons.Controls.Add(darkLightMode);
            otherButtons.FlowDirection = FlowDirection.TopDown;
            otherButtons.Location = new Point(0, 293);
            otherButtons.Margin = new Padding(0, 0, 0, 2);
            otherButtons.Name = "otherButtons";
            otherButtons.Padding = new Padding(7, 6, 6, 6);
            otherButtons.Size = new Size(52, 139);
            otherButtons.TabIndex = 4;
            // 
            // rawImage
            // 
            rawImage.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
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
            backgroundButtons.Size = new Size(52, 142);
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
            compressionButtons.FlowDirection = FlowDirection.TopDown;
            compressionButtons.Location = new Point(0, 144);
            compressionButtons.Margin = new Padding(0, 0, 0, 2);
            compressionButtons.Name = "compressionButtons";
            compressionButtons.Padding = new Padding(7, 6, 6, 6);
            compressionButtons.Size = new Size(52, 147);
            compressionButtons.TabIndex = 3;
            // 
            // rleFeature
            // 
            rleFeature.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            rleFeature.BackColor = Color.FromArgb(217, 217, 217);
            rleFeature.FlatStyle = FlatStyle.Flat;
            rleFeature.Image = Properties.Resources.rle;
            rleFeature.Location = new Point(7, 6);
            rleFeature.Margin = new Padding(0);
            rleFeature.Name = "rleFeature";
            rleFeature.Size = new Size(40, 40);
            rleFeature.TabIndex = 4;
            rleFeature.UseVisualStyleBackColor = false;
            rleFeature.Click += RLECompression_click;
            rleFeature.MouseHover += rleFeature_MouseHover;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.BackColor = SystemColors.ControlLight;
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(featuresTab, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.ForeColor = SystemColors.ActiveCaption;
            tableLayoutPanel3.Location = new Point(56, 0);
            tableLayoutPanel3.Margin = new Padding(2, 0, 0, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 88.93229F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 11.067708F));
            tableLayoutPanel3.Size = new Size(344, 771);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // featuresTab
            // 
            featuresTab.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            featuresTab.Controls.Add(imageEnhancement);
            featuresTab.Controls.Add(pointProcessing);
            featuresTab.Controls.Add(tabPage3);
            featuresTab.Location = new Point(0, 0);
            featuresTab.Margin = new Padding(0);
            featuresTab.Name = "featuresTab";
            featuresTab.SelectedIndex = 0;
            featuresTab.Size = new Size(344, 685);
            featuresTab.TabIndex = 1;
            // 
            // imageEnhancement
            // 
            imageEnhancement.BackColor = SystemColors.ControlLightLight;
            imageEnhancement.Controls.Add(displayHistogram);
            imageEnhancement.Controls.Add(rgbChannel_Label);
            imageEnhancement.Controls.Add(button3);
            imageEnhancement.Controls.Add(Red);
            imageEnhancement.Controls.Add(Green);
            imageEnhancement.Controls.Add(label2);
            imageEnhancement.Controls.Add(Blue);
            imageEnhancement.Controls.Add(bw_trackbar);
            imageEnhancement.Controls.Add(gamma_textbox);
            imageEnhancement.Controls.Add(button1);
            imageEnhancement.Controls.Add(label4);
            imageEnhancement.Controls.Add(label3);
            imageEnhancement.Controls.Add(button2);
            imageEnhancement.Controls.Add(label1);
            imageEnhancement.Font = new Font("Inter", 9F, FontStyle.Regular, GraphicsUnit.Point);
            imageEnhancement.Location = new Point(4, 27);
            imageEnhancement.Margin = new Padding(0);
            imageEnhancement.Name = "imageEnhancement";
            imageEnhancement.Size = new Size(336, 654);
            imageEnhancement.TabIndex = 0;
            imageEnhancement.Text = "Basic Image Enhancement";
            // 
            // rgbChannel_Label
            // 
            rgbChannel_Label.Anchor = AnchorStyles.Top;
            rgbChannel_Label.Font = new Font("Inter Semi Bold", 7.8F, FontStyle.Italic, GraphicsUnit.Point);
            rgbChannel_Label.ForeColor = SystemColors.ActiveCaptionText;
            rgbChannel_Label.Location = new Point(116, 9);
            rgbChannel_Label.Name = "rgbChannel_Label";
            rgbChannel_Label.Size = new Size(103, 25);
            rgbChannel_Label.TabIndex = 11;
            rgbChannel_Label.Text = "RGB Channels";
            rgbChannel_Label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pointProcessing
            // 
            pointProcessing.Font = new Font("Inter Medium", 9F, FontStyle.Bold, GraphicsUnit.Point);
            pointProcessing.Location = new Point(4, 29);
            pointProcessing.Name = "pointProcessing";
            pointProcessing.Padding = new Padding(3);
            pointProcessing.Size = new Size(336, 652);
            pointProcessing.TabIndex = 1;
            pointProcessing.Text = "tabPage2";
            pointProcessing.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Font = new Font("Inter Medium", 9F, FontStyle.Bold, GraphicsUnit.Point);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(336, 652);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "tabPage3";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // displayHistogram
            // 
            displayHistogram.BorderStyle = BorderStyle.FixedSingle;
            displayHistogram.Location = new Point(16, 354);
            displayHistogram.Name = "displayHistogram";
            displayHistogram.Size = new Size(300, 267);
            displayHistogram.SizeMode = PictureBoxSizeMode.Zoom;
            displayHistogram.TabIndex = 19;
            displayHistogram.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1422, 803);
            Controls.Add(originalImagePanel);
            Controls.Add(button4);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(menuStrip1);
            Controls.Add(saltProb);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Inter", 9F, FontStyle.Regular, GraphicsUnit.Point);
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
            ((System.ComponentModel.ISupportInitialize)bw_trackbar).EndInit();
            ((System.ComponentModel.ISupportInitialize)imageChannel).EndInit();
            editPanel.ResumeLayout(false);
            editPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)showCompressed).EndInit();
            ((System.ComponentModel.ISupportInitialize)showOriginal).EndInit();
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
            tableLayoutPanel4.ResumeLayout(false);
            buttonsPanel.ResumeLayout(false);
            buttonsSection.ResumeLayout(false);
            otherButtons.ResumeLayout(false);
            backgroundButtons.ResumeLayout(false);
            compressionButtons.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            featuresTab.ResumeLayout(false);
            imageEnhancement.ResumeLayout(false);
            imageEnhancement.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)displayHistogram).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem menu1ToolStripMenuItem;
        private ToolStripMenuItem menu2ToolStripMenuItem;
        private ToolStripMenuItem filterToolStripMenuItem;
        private RichTextBox PCXheaderInfoBox;
        private Button Red;
        private Button Green;
        private Button Blue;
        private Button button2;
        private Button button1;
        private TrackBar bw_trackbar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button3;
        private TextBox gamma_textbox;
        private ToolStripMenuItem spatialFiltering;
        private PictureBox imageChannel;
        private Button button4;
        private Label label5;
        private Label label8;
        private Button button6;
        private Button button5;
        private TextBox pepperProb;
        private Label label7;
        private TextBox saltProb;
        private Label label6;
        private Button geometricFilter;
        private Button contraHarmonicFilter;
        private Button minFilter;
        private Button medianFilter;
        private TextBox qValue;
        private Label label9;
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
        private TableLayoutPanel tableLayoutPanel4;
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
        private TabControl featuresTab;
        private TabPage imageEnhancement;
        private TabPage pointProcessing;
        private TabPage tabPage3;
        private TableLayoutPanel tableLayoutPanel3;
        private Label rgbChannel_Label;
        private PictureBox displayHistogram;
    }
}