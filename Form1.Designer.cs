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
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            panel4 = new Panel();
            maxFrequency = new Label();
            imageChannel = new PictureBox();
            channelLabel = new Label();
            panel1 = new Panel();
            panel5 = new Panel();
            PCXheaderInfoBox = new RichTextBox();
            originalImageLabel = new Label();
            ViewImage = new PictureBox();
            menuStrip1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel3.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bw_trackbar).BeginInit();
            panel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imageChannel).BeginInit();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
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
            menuStrip1.Padding = new Padding(6, 3, 0, 3);
            menuStrip1.Size = new Size(1518, 30);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // menu1ToolStripMenuItem
            // 
            menu1ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openImageToolStripMenuItem });
            menu1ToolStripMenuItem.Name = "menu1ToolStripMenuItem";
            menu1ToolStripMenuItem.Size = new Size(46, 24);
            menu1ToolStripMenuItem.Text = "File";
            // 
            // openImageToolStripMenuItem
            // 
            openImageToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openImageFileToolStripMenuItem, openPCXFileToolStripMenuItem });
            openImageToolStripMenuItem.Name = "openImageToolStripMenuItem";
            openImageToolStripMenuItem.Size = new Size(164, 26);
            openImageToolStripMenuItem.Text = "Open File...";
            // 
            // openImageFileToolStripMenuItem
            // 
            openImageFileToolStripMenuItem.Name = "openImageFileToolStripMenuItem";
            openImageFileToolStripMenuItem.Size = new Size(210, 26);
            openImageFileToolStripMenuItem.Text = "Open Image File...";
            openImageFileToolStripMenuItem.Click += ViewImage_Click;
            // 
            // openPCXFileToolStripMenuItem
            // 
            openPCXFileToolStripMenuItem.Name = "openPCXFileToolStripMenuItem";
            openPCXFileToolStripMenuItem.Size = new Size(210, 26);
            openPCXFileToolStripMenuItem.Text = "Open PCX File...";
            openPCXFileToolStripMenuItem.Click += ViewPCX_Click;
            // 
            // menu2ToolStripMenuItem
            // 
            menu2ToolStripMenuItem.Name = "menu2ToolStripMenuItem";
            menu2ToolStripMenuItem.Size = new Size(49, 24);
            menu2ToolStripMenuItem.Text = "Edit";
            // 
            // processToolStripMenuItem
            // 
            processToolStripMenuItem.Name = "processToolStripMenuItem";
            processToolStripMenuItem.Size = new Size(72, 24);
            processToolStripMenuItem.Text = "Process";
            // 
            // filterToolStripMenuItem
            // 
            filterToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { spatialFiltering });
            filterToolStripMenuItem.Name = "filterToolStripMenuItem";
            filterToolStripMenuItem.Size = new Size(56, 24);
            filterToolStripMenuItem.Text = "Filter";
            // 
            // spatialFiltering
            // 
            spatialFiltering.Name = "spatialFiltering";
            spatialFiltering.Size = new Size(196, 26);
            spatialFiltering.Text = "Spatial Filtering";
            spatialFiltering.Click += spatialFiltering_Click;
            // 
            // animationToolStripMenuItem
            // 
            animationToolStripMenuItem.Name = "animationToolStripMenuItem";
            animationToolStripMenuItem.Size = new Size(92, 24);
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
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 190F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 2, 0);
            tableLayoutPanel1.Controls.Add(panel1, 1, 0);
            tableLayoutPanel1.ForeColor = SystemColors.GrayText;
            tableLayoutPanel1.Location = new Point(0, 29);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel1.Size = new Size(1518, 1002);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(panel3, 0, 1);
            tableLayoutPanel2.Controls.Add(panel2, 0, 0);
            tableLayoutPanel2.Location = new Point(2, 3);
            tableLayoutPanel2.Margin = new Padding(2, 3, 2, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 14.4897957F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 23.4693871F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 62.0408173F));
            tableLayoutPanel2.Size = new Size(344, 784);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel6);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(bw_trackbar);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 303);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(338, 477);
            panel3.TabIndex = 4;
            // 
            // panel6
            // 
            panel6.Controls.Add(button3);
            panel6.Controls.Add(label2);
            panel6.Controls.Add(gamma_textbox);
            panel6.Controls.Add(label4);
            panel6.Location = new Point(0, 113);
            panel6.Margin = new Padding(3, 4, 3, 4);
            panel6.Name = "panel6";
            panel6.Size = new Size(337, 89);
            panel6.TabIndex = 20;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.None;
            button3.AutoSize = true;
            button3.BackColor = Color.DimGray;
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(178, 40);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(129, 40);
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
            label2.Location = new Point(16, 25);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(133, 15);
            label2.TabIndex = 16;
            label2.Text = "Input Gamma (𝛾) values";
            // 
            // gamma_textbox
            // 
            gamma_textbox.Location = new Point(19, 47);
            gamma_textbox.Margin = new Padding(3, 4, 3, 4);
            gamma_textbox.Name = "gamma_textbox";
            gamma_textbox.Size = new Size(147, 27);
            gamma_textbox.TabIndex = 17;
            gamma_textbox.KeyPress += textBox1_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ControlText;
            label4.Location = new Point(16, 5);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(165, 20);
            label4.TabIndex = 18;
            label4.Text = "Gamma Transformation\r\n";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(19, 35);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(163, 15);
            label3.TabIndex = 17;
            label3.Text = "Adjust B/W Threshold [0, 255]";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(19, 13);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(193, 20);
            label1.TabIndex = 15;
            label1.Text = "Black/White Transformation\r\n";
            // 
            // bw_trackbar
            // 
            bw_trackbar.Location = new Point(19, 55);
            bw_trackbar.Margin = new Padding(2, 3, 2, 3);
            bw_trackbar.Maximum = 255;
            bw_trackbar.Name = "bw_trackbar";
            bw_trackbar.Size = new Size(297, 56);
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
            panel2.Location = new Point(3, 4);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(338, 291);
            panel2.TabIndex = 3;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.AutoSize = true;
            button2.BackColor = Color.DarkSlateGray;
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(79, 152);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(94, 47);
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
            button1.Location = new Point(178, 152);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(97, 47);
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
            Red.Location = new Point(20, 104);
            Red.Margin = new Padding(3, 4, 3, 4);
            Red.Name = "Red";
            Red.Size = new Size(97, 47);
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
            Green.Location = new Point(123, 104);
            Green.Margin = new Padding(3, 4, 3, 4);
            Green.Name = "Green";
            Green.Size = new Size(95, 47);
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
            Blue.Location = new Point(225, 104);
            Blue.Margin = new Padding(3, 4, 3, 4);
            Blue.Name = "Blue";
            Blue.Size = new Size(91, 47);
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
            tableLayoutPanel3.Location = new Point(807, 4);
            tableLayoutPanel3.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(707, 994);
            tableLayoutPanel3.TabIndex = 4;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 59.3800964F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40.6199036F));
            tableLayoutPanel4.Controls.Add(panel4, 0, 0);
            tableLayoutPanel4.Location = new Point(3, 4);
            tableLayoutPanel4.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(701, 986);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Controls.Add(maxFrequency);
            panel4.Controls.Add(imageChannel);
            panel4.Controls.Add(channelLabel);
            panel4.Location = new Point(3, 4);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(409, 448);
            panel4.TabIndex = 0;
            // 
            // maxFrequency
            // 
            maxFrequency.AutoSize = true;
            maxFrequency.Location = new Point(9, 407);
            maxFrequency.Name = "maxFrequency";
            maxFrequency.Size = new Size(0, 20);
            maxFrequency.TabIndex = 1;
            // 
            // imageChannel
            // 
            imageChannel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            imageChannel.Location = new Point(9, 48);
            imageChannel.Margin = new Padding(3, 4, 3, 4);
            imageChannel.Name = "imageChannel";
            imageChannel.Size = new Size(390, 333);
            imageChannel.SizeMode = PictureBoxSizeMode.Zoom;
            imageChannel.TabIndex = 0;
            imageChannel.TabStop = false;
            // 
            // channelLabel
            // 
            channelLabel.AutoSize = true;
            channelLabel.Location = new Point(0, 0);
            channelLabel.Name = "channelLabel";
            channelLabel.Size = new Size(0, 20);
            channelLabel.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonFace;
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(originalImageLabel);
            panel1.Controls.Add(ViewImage);
            panel1.Location = new Point(352, 4);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(448, 994);
            panel1.TabIndex = 5;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel5.AutoScroll = true;
            panel5.Controls.Add(PCXheaderInfoBox);
            panel5.Location = new Point(3, 415);
            panel5.Margin = new Padding(3, 4, 3, 4);
            panel5.Name = "panel5";
            panel5.Size = new Size(441, 575);
            panel5.TabIndex = 3;
            // 
            // PCXheaderInfoBox
            // 
            PCXheaderInfoBox.BackColor = SystemColors.ButtonFace;
            PCXheaderInfoBox.BorderStyle = BorderStyle.None;
            PCXheaderInfoBox.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            PCXheaderInfoBox.ForeColor = SystemColors.MenuText;
            PCXheaderInfoBox.Location = new Point(0, 3);
            PCXheaderInfoBox.Margin = new Padding(2, 3, 2, 3);
            PCXheaderInfoBox.MaxLength = 21474;
            PCXheaderInfoBox.MinimumSize = new Size(390, 333);
            PCXheaderInfoBox.Name = "PCXheaderInfoBox";
            PCXheaderInfoBox.ReadOnly = true;
            PCXheaderInfoBox.ScrollBars = RichTextBoxScrollBars.None;
            PCXheaderInfoBox.Size = new Size(441, 600);
            PCXheaderInfoBox.TabIndex = 2;
            PCXheaderInfoBox.Text = "";
            // 
            // originalImageLabel
            // 
            originalImageLabel.AutoSize = true;
            originalImageLabel.Location = new Point(3, 4);
            originalImageLabel.Name = "originalImageLabel";
            originalImageLabel.Size = new Size(0, 20);
            originalImageLabel.TabIndex = 2;
            // 
            // ViewImage
            // 
            ViewImage.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ViewImage.BackColor = SystemColors.ButtonFace;
            ViewImage.Location = new Point(27, 56);
            ViewImage.MinimumSize = new Size(390, 333);
            ViewImage.Name = "ViewImage";
            ViewImage.Size = new Size(390, 333);
            ViewImage.SizeMode = PictureBoxSizeMode.Zoom;
            ViewImage.TabIndex = 1;
            ViewImage.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(1518, 1055);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(menuStrip1);
            ForeColor = SystemColors.ActiveBorder;
            MainMenuStrip = menuStrip1;
            MinimumSize = new Size(1533, 651);
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
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
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
            panel5.ResumeLayout(false);
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
        private Panel panel5;
        private Panel panel6;
        private Label maxFrequency;
    }
}