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
            processToolStripMenuItem = new ToolStripMenuItem();
            filterToolStripMenuItem = new ToolStripMenuItem();
            spatialFiltering = new ToolStripMenuItem();
            animationToolStripMenuItem = new ToolStripMenuItem();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel3 = new Panel();
            button3 = new Button();
            gamma_textbox = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            bw_trackbar = new TrackBar();
            panel2 = new Panel();
            button2 = new Button();
            button1 = new Button();
            Red = new Button();
            Green = new Button();
            Blue = new Button();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            panel4 = new Panel();
            imageChannel = new PictureBox();
            channelLabel = new Label();
            panel1 = new Panel();
            originalImageLabel = new Label();
            PCXheaderInfoBox = new RichTextBox();
            ViewImage = new PictureBox();
            menuStrip1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bw_trackbar).BeginInit();
            panel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imageChannel).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ViewImage).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.Menu;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menu1ToolStripMenuItem, menu2ToolStripMenuItem, processToolStripMenuItem, filterToolStripMenuItem, animationToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(1328, 24);
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
            menu2ToolStripMenuItem.Name = "menu2ToolStripMenuItem";
            menu2ToolStripMenuItem.Size = new Size(39, 20);
            menu2ToolStripMenuItem.Text = "Edit";
            // 
            // processToolStripMenuItem
            // 
            processToolStripMenuItem.Name = "processToolStripMenuItem";
            processToolStripMenuItem.Size = new Size(59, 20);
            processToolStripMenuItem.Text = "Process";
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
            spatialFiltering.Size = new Size(180, 22);
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
            tableLayoutPanel1.BackColor = SystemColors.ButtonFace;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23.0263176F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30.0451813F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 46.9879532F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 166F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 2, 0);
            tableLayoutPanel1.Controls.Add(panel1, 1, 0);
            tableLayoutPanel1.ForeColor = SystemColors.GrayText;
            tableLayoutPanel1.Location = new Point(0, 22);
            tableLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1328, 885);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(panel3, 0, 1);
            tableLayoutPanel2.Controls.Add(panel2, 0, 0);
            tableLayoutPanel2.Location = new Point(2, 2);
            tableLayoutPanel2.Margin = new Padding(2);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 14.4897957F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 23.4693871F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 62.0408173F));
            tableLayoutPanel2.Size = new Size(301, 588);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.Controls.Add(button3);
            panel3.Controls.Add(gamma_textbox);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(bw_trackbar);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 227);
            panel3.Name = "panel3";
            panel3.Size = new Size(295, 358);
            panel3.TabIndex = 4;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.None;
            button3.AutoSize = true;
            button3.BackColor = Color.DimGray;
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(158, 101);
            button3.Name = "button3";
            button3.Size = new Size(113, 25);
            button3.TabIndex = 11;
            button3.Text = "Transform";
            button3.UseVisualStyleBackColor = false;
            button3.Click += GammaTransform_Click;
            // 
            // gamma_textbox
            // 
            gamma_textbox.Location = new Point(24, 101);
            gamma_textbox.Margin = new Padding(2);
            gamma_textbox.Name = "gamma_textbox";
            gamma_textbox.Size = new Size(129, 23);
            gamma_textbox.TabIndex = 19;
            gamma_textbox.TabStop = false;
            gamma_textbox.KeyPress += textBox1_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ControlText;
            label4.Location = new Point(17, 70);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(132, 15);
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(17, 85);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(111, 12);
            label2.TabIndex = 16;
            label2.Text = "Input Gamma (𝛾) values";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(17, 10);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(154, 15);
            label1.TabIndex = 15;
            label1.Text = "Black/White Transformation\r\n";
            // 
            // bw_trackbar
            // 
            bw_trackbar.Location = new Point(17, 41);
            bw_trackbar.Margin = new Padding(2);
            bw_trackbar.Maximum = 255;
            bw_trackbar.Name = "bw_trackbar";
            bw_trackbar.Size = new Size(260, 45);
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
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(295, 218);
            panel2.TabIndex = 3;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.AutoSize = true;
            button2.BackColor = Color.DarkSlateGray;
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(68, 114);
            button2.Name = "button2";
            button2.Size = new Size(82, 35);
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
            button1.Location = new Point(155, 114);
            button1.Name = "button1";
            button1.Size = new Size(85, 35);
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
            Red.Location = new Point(17, 78);
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
            Green.Location = new Point(107, 78);
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
            Blue.Location = new Point(196, 78);
            Blue.Name = "Blue";
            Blue.Size = new Size(80, 35);
            Blue.TabIndex = 8;
            Blue.Text = "Blue";
            Blue.UseVisualStyleBackColor = false;
            Blue.Click += Blue_Click;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 51.495018F));
            tableLayoutPanel3.Controls.Add(tableLayoutPanel4, 0, 0);
            tableLayoutPanel3.Location = new Point(706, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(619, 803);
            tableLayoutPanel3.TabIndex = 4;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 59.3800964F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40.6199036F));
            tableLayoutPanel4.Controls.Add(panel4, 0, 0);
            tableLayoutPanel4.Location = new Point(3, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(613, 797);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Controls.Add(imageChannel);
            panel4.Controls.Add(channelLabel);
            panel4.Location = new Point(3, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(358, 305);
            panel4.TabIndex = 0;
            // 
            // imageChannel
            // 
            imageChannel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            imageChannel.Location = new Point(8, 36);
            imageChannel.Name = "imageChannel";
            imageChannel.Size = new Size(341, 250);
            imageChannel.SizeMode = PictureBoxSizeMode.Zoom;
            imageChannel.TabIndex = 0;
            imageChannel.TabStop = false;
            // 
            // channelLabel
            // 
            channelLabel.AutoSize = true;
            channelLabel.Location = new Point(0, 0);
            channelLabel.Name = "channelLabel";
            channelLabel.Size = new Size(0, 15);
            channelLabel.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonFace;
            panel1.Controls.Add(originalImageLabel);
            panel1.Controls.Add(PCXheaderInfoBox);
            panel1.Controls.Add(ViewImage);
            panel1.Location = new Point(308, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(392, 803);
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
            // PCXheaderInfoBox
            // 
            PCXheaderInfoBox.BackColor = SystemColors.ButtonHighlight;
            PCXheaderInfoBox.BorderStyle = BorderStyle.None;
            PCXheaderInfoBox.Enabled = false;
            PCXheaderInfoBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            PCXheaderInfoBox.ForeColor = SystemColors.MenuText;
            PCXheaderInfoBox.Location = new Point(24, 309);
            PCXheaderInfoBox.Margin = new Padding(2);
            PCXheaderInfoBox.Name = "PCXheaderInfoBox";
            PCXheaderInfoBox.ReadOnly = true;
            PCXheaderInfoBox.ScrollBars = RichTextBoxScrollBars.None;
            PCXheaderInfoBox.Size = new Size(341, 473);
            PCXheaderInfoBox.TabIndex = 2;
            PCXheaderInfoBox.Text = "";
            // 
            // ViewImage
            // 
            ViewImage.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ViewImage.BackColor = SystemColors.ButtonFace;
            ViewImage.Location = new Point(24, 42);
            ViewImage.Margin = new Padding(3, 2, 3, 2);
            ViewImage.Name = "ViewImage";
            ViewImage.Size = new Size(341, 250);
            ViewImage.SizeMode = PictureBoxSizeMode.Zoom;
            ViewImage.TabIndex = 1;
            ViewImage.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(1328, 840);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(menuStrip1);
            ForeColor = SystemColors.ActiveBorder;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(1344, 879);
            Name = "Form1";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.WindowsDefaultBounds;
            Text = "View";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bw_trackbar).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imageChannel).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ViewImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem menu1ToolStripMenuItem;
        private ToolStripMenuItem menu2ToolStripMenuItem;
        private ToolStripMenuItem processToolStripMenuItem;
        private ToolStripMenuItem filterToolStripMenuItem;
        private ToolStripMenuItem animationToolStripMenuItem;
        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox ViewImage;
        private ToolStripMenuItem openImageToolStripMenuItem;
        private ToolStripMenuItem openImageFileToolStripMenuItem;
        private ToolStripMenuItem openPCXFileToolStripMenuItem;
        private TableLayoutPanel tableLayoutPanel2;
        private RichTextBox PCXheaderInfoBox;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
        private PictureBox imageChannel;
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
        private Panel panel4;
        private Label channelLabel;
        private ToolStripMenuItem spatialFiltering;
    }
}