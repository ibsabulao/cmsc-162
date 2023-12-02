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
            menuStrip1 = new MenuStrip();
            menu1ToolStripMenuItem = new ToolStripMenuItem();
            openImageToolStripMenuItem = new ToolStripMenuItem();
            openImageFileToolStripMenuItem = new ToolStripMenuItem();
            openPCXFileToolStripMenuItem = new ToolStripMenuItem();
            menu2ToolStripMenuItem = new ToolStripMenuItem();
            imageDegradationToolStripMenuItem = new ToolStripMenuItem();
            huffmanCodingToolStripMenuItem = new ToolStripMenuItem();
            filterToolStripMenuItem = new ToolStripMenuItem();
            spatialFiltering = new ToolStripMenuItem();
            animationToolStripMenuItem = new ToolStripMenuItem();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel3 = new Panel();
            panel6 = new Panel();
            button3 = new Button();
            label2 = new Label();
            gamma_textbox = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            bw_trackbar = new TrackBar();
            panel2 = new Panel();
            button2 = new Button();
            button1 = new Button();
            Red = new Button();
            Green = new Button();
            Blue = new Button();
            panel5 = new Panel();
            button4 = new Button();
            label5 = new Label();
            label6 = new Label();
            pepperProb = new TextBox();
            saltProb = new TextBox();
            label7 = new Label();
            panel8 = new Panel();
            button6 = new Button();
            button5 = new Button();
            panel9 = new Panel();
            midpointFilter = new Button();
            maxFilter = new Button();
            minFilter = new Button();
            medianFilter = new Button();
            qValue = new TextBox();
            label9 = new Label();
            contraHarmonicFilter = new Button();
            geometricFilter = new Button();
            label8 = new Label();
            panel1 = new Panel();
            originalImageLabel = new Label();
            ViewImage = new PictureBox();
            PCXheaderInfoBox = new RichTextBox();
            panel4 = new Panel();
            imageLabel = new Label();
            button7 = new Button();
            imageChannel = new PictureBox();
            menuStrip1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel3.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bw_trackbar).BeginInit();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            panel8.SuspendLayout();
            panel9.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ViewImage).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imageChannel).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.Menu;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menu1ToolStripMenuItem, menu2ToolStripMenuItem, filterToolStripMenuItem, animationToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(1324, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // menu1ToolStripMenuItem
            // 
            menu1ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openImageToolStripMenuItem });
            menu1ToolStripMenuItem.Name = "menu1ToolStripMenuItem";
            menu1ToolStripMenuItem.Size = new Size(37, 20);
            menu1ToolStripMenuItem.Text = "File";
            // 
            // openImageToolStripMenuItem
            // 
            openImageToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openImageFileToolStripMenuItem, openPCXFileToolStripMenuItem });
            openImageToolStripMenuItem.Name = "openImageToolStripMenuItem";
            openImageToolStripMenuItem.Size = new Size(133, 22);
            openImageToolStripMenuItem.Text = "Open File...";
            // 
            // openImageFileToolStripMenuItem
            // 
            openImageFileToolStripMenuItem.Name = "openImageFileToolStripMenuItem";
            openImageFileToolStripMenuItem.Size = new Size(169, 22);
            openImageFileToolStripMenuItem.Text = "Open Image File...";
            openImageFileToolStripMenuItem.Click += ViewImage_Click;
            // 
            // openPCXFileToolStripMenuItem
            // 
            openPCXFileToolStripMenuItem.Name = "openPCXFileToolStripMenuItem";
            openPCXFileToolStripMenuItem.Size = new Size(169, 22);
            openPCXFileToolStripMenuItem.Text = "Open PCX File...";
            openPCXFileToolStripMenuItem.Click += ViewPCX_Click;
            // 
            // menu2ToolStripMenuItem
            // 
            menu2ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { imageDegradationToolStripMenuItem, huffmanCodingToolStripMenuItem });
            menu2ToolStripMenuItem.Name = "menu2ToolStripMenuItem";
            menu2ToolStripMenuItem.Size = new Size(89, 20);
            menu2ToolStripMenuItem.Text = "Compression";
            // 
            // imageDegradationToolStripMenuItem
            // 
            imageDegradationToolStripMenuItem.Name = "imageDegradationToolStripMenuItem";
            imageDegradationToolStripMenuItem.Size = new Size(179, 22);
            imageDegradationToolStripMenuItem.Text = "Run-Length Coding";
            imageDegradationToolStripMenuItem.Click += RLECompression_click;
            // 
            // huffmanCodingToolStripMenuItem
            // 
            huffmanCodingToolStripMenuItem.Name = "huffmanCodingToolStripMenuItem";
            huffmanCodingToolStripMenuItem.Size = new Size(179, 22);
            huffmanCodingToolStripMenuItem.Text = "Huffman Coding";
            huffmanCodingToolStripMenuItem.Click += huffmanCompression_Click;
            // 
            // filterToolStripMenuItem
            // 
            filterToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { spatialFiltering });
            filterToolStripMenuItem.Name = "filterToolStripMenuItem";
            filterToolStripMenuItem.Size = new Size(45, 20);
            filterToolStripMenuItem.Text = "Filter";
            // 
            // spatialFiltering
            // 
            spatialFiltering.Name = "spatialFiltering";
            spatialFiltering.Size = new Size(155, 22);
            spatialFiltering.Text = "Spatial Filtering";
            spatialFiltering.Click += spatialFiltering_Click;
            // 
            // animationToolStripMenuItem
            // 
            animationToolStripMenuItem.Name = "animationToolStripMenuItem";
            animationToolStripMenuItem.Size = new Size(75, 20);
            animationToolStripMenuItem.Text = "Animation";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.BackColor = SystemColors.ControlLight;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6267948F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 51.3756F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 31.9976082F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 166F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(panel1, 2, 0);
            tableLayoutPanel1.Controls.Add(panel4, 1, 0);
            tableLayoutPanel1.ForeColor = SystemColors.GrayText;
            tableLayoutPanel1.Location = new Point(0, 26);
            tableLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1668, 1114);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(panel3, 0, 1);
            tableLayoutPanel2.Controls.Add(panel2, 0, 0);
            tableLayoutPanel2.Controls.Add(panel5, 0, 2);
            tableLayoutPanel2.Controls.Add(panel8, 0, 3);
            tableLayoutPanel2.Controls.Add(panel9, 0, 4);
            tableLayoutPanel2.Location = new Point(2, 2);
            tableLayoutPanel2.Margin = new Padding(2);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 5;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 14.4897957F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 23.4693871F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 122F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 173F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 62.0408173F));
            tableLayoutPanel2.Size = new Size(273, 588);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel6);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(bw_trackbar);
            panel3.Location = new Point(3, 97);
            panel3.Name = "panel3";
            panel3.Size = new Size(267, 147);
            panel3.TabIndex = 4;
            // 
            // panel6
            // 
            panel6.Controls.Add(button3);
            panel6.Controls.Add(label2);
            panel6.Controls.Add(gamma_textbox);
            panel6.Controls.Add(label4);
            panel6.Location = new Point(0, 85);
            panel6.Name = "panel6";
            panel6.Size = new Size(271, 67);
            panel6.TabIndex = 20;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.None;
            button3.AutoSize = true;
            button3.BackColor = Color.DimGray;
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(152, 31);
            button3.Name = "button3";
            button3.Size = new Size(101, 35);
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
            label2.Location = new Point(14, 19);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(111, 12);
            label2.TabIndex = 16;
            label2.Text = "Input Gamma (𝛾) values";
            // 
            // gamma_textbox
            // 
            gamma_textbox.Location = new Point(17, 35);
            gamma_textbox.Name = "gamma_textbox";
            gamma_textbox.Size = new Size(129, 23);
            gamma_textbox.TabIndex = 17;
            gamma_textbox.KeyPress += textBox1_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlText;
            label4.Location = new Point(14, 4);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(144, 15);
            label4.TabIndex = 18;
            label4.Text = "Gamma Transformation\r\n";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(17, 26);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(134, 12);
            label3.TabIndex = 17;
            label3.Text = "Adjust B/W Threshold [0, 255]";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(17, 10);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(170, 15);
            label1.TabIndex = 15;
            label1.Text = "Black/White Transformation\r\n";
            // 
            // bw_trackbar
            // 
            bw_trackbar.Location = new Point(17, 41);
            bw_trackbar.Margin = new Padding(2);
            bw_trackbar.Maximum = 255;
            bw_trackbar.Name = "bw_trackbar";
            bw_trackbar.Size = new Size(240, 45);
            bw_trackbar.TabIndex = 13;
            bw_trackbar.TickFrequency = 15;
            bw_trackbar.ValueChanged += BW_Scroll;
            // 
            // panel2
            // 
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(Red);
            panel2.Controls.Add(Green);
            panel2.Controls.Add(Blue);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(267, 88);
            panel2.TabIndex = 3;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.AutoSize = true;
            button2.BackColor = Color.DarkSlateGray;
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(52, 44);
            button2.Name = "button2";
            button2.Size = new Size(92, 35);
            button2.TabIndex = 10;
            button2.Text = "Negative";
            button2.UseVisualStyleBackColor = false;
            button2.Click += Negative_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.AutoSize = true;
            button1.BackColor = Color.Gray;
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(144, 44);
            button1.Name = "button1";
            button1.Size = new Size(96, 35);
            button1.TabIndex = 9;
            button1.Text = "Greyscale";
            button1.UseVisualStyleBackColor = false;
            button1.Click += Grayscale_Click;
            // 
            // Red
            // 
            Red.Anchor = AnchorStyles.None;
            Red.AutoSize = true;
            Red.BackColor = Color.FromArgb(192, 0, 0);
            Red.ForeColor = SystemColors.ButtonHighlight;
            Red.Location = new Point(5, 3);
            Red.Name = "Red";
            Red.Size = new Size(85, 35);
            Red.TabIndex = 6;
            Red.Text = "Red";
            Red.UseVisualStyleBackColor = false;
            Red.Click += Red_Click;
            // 
            // Green
            // 
            Green.Anchor = AnchorStyles.None;
            Green.AutoSize = true;
            Green.BackColor = Color.Green;
            Green.ForeColor = SystemColors.ButtonHighlight;
            Green.Location = new Point(94, 3);
            Green.Name = "Green";
            Green.Size = new Size(83, 35);
            Green.TabIndex = 7;
            Green.Text = "Green";
            Green.UseVisualStyleBackColor = false;
            Green.Click += Green_Click;
            // 
            // Blue
            // 
            Blue.Anchor = AnchorStyles.None;
            Blue.AutoSize = true;
            Blue.BackColor = Color.MidnightBlue;
            Blue.ForeColor = SystemColors.ButtonHighlight;
            Blue.Location = new Point(183, 3);
            Blue.Name = "Blue";
            Blue.Size = new Size(80, 35);
            Blue.TabIndex = 8;
            Blue.Text = "Blue";
            Blue.UseVisualStyleBackColor = false;
            Blue.Click += Blue_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(button4);
            panel5.Controls.Add(label5);
            panel5.Controls.Add(label6);
            panel5.Controls.Add(pepperProb);
            panel5.Controls.Add(saltProb);
            panel5.Controls.Add(label7);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(3, 250);
            panel5.Name = "panel5";
            panel5.Size = new Size(267, 116);
            panel5.TabIndex = 5;
            // 
            // button4
            // 
            button4.Location = new Point(163, 58);
            button4.Name = "button4";
            button4.Size = new Size(101, 40);
            button4.TabIndex = 20;
            button4.Text = "Salt-and-Pepper Noise";
            button4.UseVisualStyleBackColor = true;
            button4.Click += saltPepper_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ControlText;
            label5.Location = new Point(16, 5);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(116, 15);
            label5.TabIndex = 19;
            label5.Text = "Image Degradation";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ControlText;
            label6.Location = new Point(16, 31);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(100, 12);
            label6.TabIndex = 19;
            label6.Text = "Salt Probability [0, 0.5]";
            // 
            // pepperProb
            // 
            pepperProb.Location = new Point(16, 88);
            pepperProb.Name = "pepperProb";
            pepperProb.Size = new Size(129, 23);
            pepperProb.TabIndex = 23;
            pepperProb.KeyPress += textBox1_KeyPress;
            // 
            // saltProb
            // 
            saltProb.Location = new Point(16, 46);
            saltProb.Name = "saltProb";
            saltProb.Size = new Size(129, 23);
            saltProb.TabIndex = 21;
            saltProb.KeyPress += textBox1_KeyPress;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ControlText;
            label7.Location = new Point(16, 73);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(116, 12);
            label7.TabIndex = 22;
            label7.Text = "Pepper Probability [0, 0.5]";
            // 
            // panel8
            // 
            panel8.Controls.Add(button6);
            panel8.Controls.Add(button5);
            panel8.Dock = DockStyle.Fill;
            panel8.Location = new Point(3, 372);
            panel8.Name = "panel8";
            panel8.Size = new Size(267, 39);
            panel8.TabIndex = 6;
            // 
            // button6
            // 
            button6.BackColor = SystemColors.ControlLightLight;
            button6.Location = new Point(145, 5);
            button6.Name = "button6";
            button6.Size = new Size(101, 31);
            button6.TabIndex = 25;
            button6.Text = "Rayleigh Noise";
            button6.UseVisualStyleBackColor = false;
            button6.Click += rayleighNoise_Click;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.ControlLightLight;
            button5.Location = new Point(38, 5);
            button5.Name = "button5";
            button5.Size = new Size(101, 31);
            button5.TabIndex = 24;
            button5.Text = "Gaussian Noise";
            button5.UseVisualStyleBackColor = false;
            button5.Click += gaussianNoise_Click;
            // 
            // panel9
            // 
            panel9.Controls.Add(midpointFilter);
            panel9.Controls.Add(maxFilter);
            panel9.Controls.Add(minFilter);
            panel9.Controls.Add(medianFilter);
            panel9.Controls.Add(qValue);
            panel9.Controls.Add(label9);
            panel9.Controls.Add(contraHarmonicFilter);
            panel9.Controls.Add(geometricFilter);
            panel9.Controls.Add(label8);
            panel9.Dock = DockStyle.Fill;
            panel9.Location = new Point(3, 417);
            panel9.Name = "panel9";
            panel9.Size = new Size(267, 168);
            panel9.TabIndex = 7;
            // 
            // midpointFilter
            // 
            midpointFilter.BackColor = SystemColors.ControlLightLight;
            midpointFilter.Location = new Point(140, 133);
            midpointFilter.Name = "midpointFilter";
            midpointFilter.Size = new Size(113, 24);
            midpointFilter.TabIndex = 31;
            midpointFilter.Text = "Midpoint Filter";
            midpointFilter.UseVisualStyleBackColor = false;
            midpointFilter.Click += midpointFilter_Click;
            // 
            // maxFilter
            // 
            maxFilter.BackColor = SystemColors.ControlLightLight;
            maxFilter.Location = new Point(140, 104);
            maxFilter.Name = "maxFilter";
            maxFilter.Size = new Size(113, 24);
            maxFilter.TabIndex = 30;
            maxFilter.Text = "Max Filter";
            maxFilter.UseVisualStyleBackColor = false;
            maxFilter.Click += maxFilter_Click;
            // 
            // minFilter
            // 
            minFilter.BackColor = SystemColors.ControlLightLight;
            minFilter.Location = new Point(17, 103);
            minFilter.Name = "minFilter";
            minFilter.Size = new Size(113, 24);
            minFilter.TabIndex = 29;
            minFilter.Text = "Min Filter";
            minFilter.UseVisualStyleBackColor = false;
            minFilter.Click += minFilter_Click;
            // 
            // medianFilter
            // 
            medianFilter.BackColor = SystemColors.ControlLightLight;
            medianFilter.Location = new Point(17, 133);
            medianFilter.Name = "medianFilter";
            medianFilter.Size = new Size(113, 24);
            medianFilter.TabIndex = 28;
            medianFilter.Text = "Median Filter";
            medianFilter.UseVisualStyleBackColor = false;
            medianFilter.Click += medianFilter_Click;
            // 
            // qValue
            // 
            qValue.Location = new Point(17, 79);
            qValue.Name = "qValue";
            qValue.Size = new Size(114, 23);
            qValue.TabIndex = 24;
            qValue.KeyPress += textBox1_KeyPress;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.ControlText;
            label9.Location = new Point(16, 64);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(41, 12);
            label9.TabIndex = 24;
            label9.Text = "Q value:";
            // 
            // contraHarmonicFilter
            // 
            contraHarmonicFilter.BackColor = SystemColors.ControlLightLight;
            contraHarmonicFilter.Location = new Point(140, 57);
            contraHarmonicFilter.Name = "contraHarmonicFilter";
            contraHarmonicFilter.Size = new Size(113, 41);
            contraHarmonicFilter.TabIndex = 27;
            contraHarmonicFilter.Text = "Contraharmonic Filter";
            contraHarmonicFilter.UseVisualStyleBackColor = false;
            contraHarmonicFilter.Click += contraHarmonicFilter_Click;
            // 
            // geometricFilter
            // 
            geometricFilter.BackColor = SystemColors.ControlLightLight;
            geometricFilter.Location = new Point(17, 27);
            geometricFilter.Name = "geometricFilter";
            geometricFilter.Size = new Size(236, 24);
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
            label8.Location = new Point(17, 9);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(111, 15);
            label8.TabIndex = 26;
            label8.Text = "Image Restoration";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(originalImageLabel);
            panel1.Controls.Add(ViewImage);
            panel1.Controls.Add(PCXheaderInfoBox);
            panel1.Location = new Point(1136, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(239, 762);
            panel1.TabIndex = 5;
            // 
            // originalImageLabel
            // 
            originalImageLabel.AutoSize = true;
            originalImageLabel.Location = new Point(3, 3);
            originalImageLabel.Name = "originalImageLabel";
            originalImageLabel.Size = new Size(0, 15);
            originalImageLabel.TabIndex = 2;
            // 
            // ViewImage
            // 
            ViewImage.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ViewImage.BackColor = SystemColors.ControlLight;
            ViewImage.Location = new Point(3, 27);
            ViewImage.Margin = new Padding(3, 2, 3, 2);
            ViewImage.Name = "ViewImage";
            ViewImage.Size = new Size(185, 162);
            ViewImage.SizeMode = PictureBoxSizeMode.Zoom;
            ViewImage.TabIndex = 1;
            ViewImage.TabStop = false;
            // 
            // PCXheaderInfoBox
            // 
            PCXheaderInfoBox.BackColor = SystemColors.ControlLight;
            PCXheaderInfoBox.BorderStyle = BorderStyle.None;
            PCXheaderInfoBox.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            PCXheaderInfoBox.ForeColor = SystemColors.MenuText;
            PCXheaderInfoBox.Location = new Point(3, 193);
            PCXheaderInfoBox.Margin = new Padding(2);
            PCXheaderInfoBox.MaxLength = 21474;
            PCXheaderInfoBox.Name = "PCXheaderInfoBox";
            PCXheaderInfoBox.ReadOnly = true;
            PCXheaderInfoBox.ScrollBars = RichTextBoxScrollBars.None;
            PCXheaderInfoBox.Size = new Size(185, 569);
            PCXheaderInfoBox.TabIndex = 2;
            PCXheaderInfoBox.Text = "";
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.Control;
            panel4.Controls.Add(imageLabel);
            panel4.Controls.Add(button7);
            panel4.Controls.Add(imageChannel);
            panel4.Location = new Point(280, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(850, 762);
            panel4.TabIndex = 6;
            // 
            // imageLabel
            // 
            imageLabel.AutoSize = true;
            imageLabel.Location = new Point(3, 3);
            imageLabel.Name = "imageLabel";
            imageLabel.Size = new Size(38, 15);
            imageLabel.TabIndex = 2;
            imageLabel.Text = "label9";
            // 
            // button7
            // 
            button7.Location = new Point(730, 3);
            button7.Name = "button7";
            button7.Size = new Size(115, 23);
            button7.TabIndex = 1;
            button7.Text = "Use Original Image";
            button7.UseVisualStyleBackColor = true;
            button7.Click += originalImage_Click;
            // 
            // imageChannel
            // 
            imageChannel.Anchor = AnchorStyles.None;
            imageChannel.Location = new Point(185, 94);
            imageChannel.Name = "imageChannel";
            imageChannel.Size = new Size(423, 423);
            imageChannel.SizeMode = PictureBoxSizeMode.Zoom;
            imageChannel.TabIndex = 0;
            imageChannel.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(1324, 630);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(menuStrip1);
            ForeColor = SystemColors.ActiveBorder;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimumSize = new Size(1338, 626);
            Name = "Form1";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "View";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bw_trackbar).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel8.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ViewImage).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imageChannel).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem menu1ToolStripMenuItem;
        private ToolStripMenuItem menu2ToolStripMenuItem;
        private ToolStripMenuItem filterToolStripMenuItem;
        private ToolStripMenuItem animationToolStripMenuItem;
        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox ViewImage;
        private ToolStripMenuItem openImageToolStripMenuItem;
        private ToolStripMenuItem openImageFileToolStripMenuItem;
        private ToolStripMenuItem openPCXFileToolStripMenuItem;
        private TableLayoutPanel tableLayoutPanel2;
        private RichTextBox PCXheaderInfoBox;
        private Panel panel2;
        private Button Red;
        private Button Green;
        private Button Blue;
        private Panel panel1;
        private Label originalImageLabel;
        private Button button2;
        private Button button1;
        private Panel panel3;
        private TrackBar bw_trackbar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button3;
        private TextBox gamma_textbox;
        private ToolStripMenuItem spatialFiltering;
        private Panel panel6;
        private ToolStripMenuItem imageDegradationToolStripMenuItem;
        private Panel panel4;
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
        private Button button7;
        private Label imageLabel;
        private Panel panel5;
        private Panel panel8;
        private Panel panel9;
        private Button geometricFilter;
        private Button contraHarmonicFilter;
        private Button minFilter;
        private Button medianFilter;
        private TextBox qValue;
        private Label label9;
        private Button midpointFilter;
        private Button maxFilter;
        private ToolStripMenuItem huffmanCodingToolStripMenuItem;
    }
}