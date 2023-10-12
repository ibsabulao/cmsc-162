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
            animationToolStripMenuItem = new ToolStripMenuItem();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            PCXheaderInfoBox = new RichTextBox();
            panel2 = new Panel();
            Red = new Button();
            Green = new Button();
            Blue = new Button();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            imageChannel = new PictureBox();
            showHistogram = new PictureBox();
            panel1 = new Panel();
            originalImageLabel = new Label();
            ViewImage = new PictureBox();
            menuStrip1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imageChannel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)showHistogram).BeginInit();
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
            filterToolStripMenuItem.Name = "filterToolStripMenuItem";
            filterToolStripMenuItem.Size = new Size(45, 20);
            filterToolStripMenuItem.Text = "Filter";
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
            tableLayoutPanel1.Size = new Size(1328, 659);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(PCXheaderInfoBox, 0, 1);
            tableLayoutPanel2.Controls.Add(panel2, 0, 0);
            tableLayoutPanel2.Location = new Point(2, 2);
            tableLayoutPanel2.Margin = new Padding(2);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 4.50802565F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 59.21565F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 36.27632F));
            tableLayoutPanel2.Size = new Size(301, 588);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // PCXheaderInfoBox
            // 
            PCXheaderInfoBox.BackColor = SystemColors.ButtonHighlight;
            PCXheaderInfoBox.BorderStyle = BorderStyle.None;
            PCXheaderInfoBox.Enabled = false;
            PCXheaderInfoBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            PCXheaderInfoBox.ForeColor = SystemColors.MenuText;
            PCXheaderInfoBox.Location = new Point(2, 43);
            PCXheaderInfoBox.Margin = new Padding(2);
            PCXheaderInfoBox.Name = "PCXheaderInfoBox";
            PCXheaderInfoBox.ReadOnly = true;
            PCXheaderInfoBox.ScrollBars = RichTextBoxScrollBars.None;
            PCXheaderInfoBox.Size = new Size(297, 543);
            PCXheaderInfoBox.TabIndex = 2;
            PCXheaderInfoBox.Text = "";
            // 
            // panel2
            // 
            panel2.Controls.Add(Red);
            panel2.Controls.Add(Green);
            panel2.Controls.Add(Blue);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(295, 35);
            panel2.TabIndex = 3;
            // 
            // Red
            // 
            Red.Anchor = AnchorStyles.None;
            Red.AutoSize = true;
            Red.BackColor = Color.FromArgb(192, 0, 0);
            Red.ForeColor = SystemColors.ButtonHighlight;
            Red.Location = new Point(29, 7);
            Red.Name = "Red";
            Red.Size = new Size(75, 25);
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
            Green.Location = new Point(110, 7);
            Green.Name = "Green";
            Green.Size = new Size(75, 25);
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
            Blue.Location = new Point(191, 7);
            Blue.Name = "Blue";
            Blue.Size = new Size(75, 25);
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
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 331F));
            tableLayoutPanel3.Size = new Size(619, 586);
            tableLayoutPanel3.TabIndex = 4;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(imageChannel, 0, 0);
            tableLayoutPanel4.Controls.Add(showHistogram, 1, 0);
            tableLayoutPanel4.Location = new Point(3, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(613, 249);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // imageChannel
            // 
            imageChannel.Location = new Point(3, 3);
            imageChannel.Name = "imageChannel";
            imageChannel.Size = new Size(300, 243);
            imageChannel.SizeMode = PictureBoxSizeMode.Zoom;
            imageChannel.TabIndex = 0;
            imageChannel.TabStop = false;
            // 
            // showHistogram
            // 
            showHistogram.Location = new Point(309, 3);
            showHistogram.Name = "showHistogram";
            showHistogram.Size = new Size(301, 243);
            showHistogram.SizeMode = PictureBoxSizeMode.AutoSize;
            showHistogram.TabIndex = 1;
            showHistogram.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonFace;
            panel1.Controls.Add(originalImageLabel);
            panel1.Controls.Add(ViewImage);
            panel1.Location = new Point(308, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(392, 587);
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
            ViewImage.BackColor = SystemColors.ButtonFace;
            ViewImage.Location = new Point(24, 42);
            ViewImage.Margin = new Padding(3, 2, 3, 2);
            ViewImage.Name = "ViewImage";
            ViewImage.Size = new Size(341, 436);
            ViewImage.SizeMode = PictureBoxSizeMode.Zoom;
            ViewImage.TabIndex = 1;
            ViewImage.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(1328, 614);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(menuStrip1);
            ForeColor = SystemColors.ActiveBorder;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.WindowsDefaultBounds;
            Text = "View";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imageChannel).EndInit();
            ((System.ComponentModel.ISupportInitialize)showHistogram).EndInit();
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
        private PictureBox showHistogram;
        private Panel panel2;
        private Button Red;
        private Button Green;
        private Button Blue;
        private Panel panel1;
        private Label originalImageLabel;
    }
}