﻿using System.Windows.Forms;

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
            panel3 = new Panel();
            button3 = new Button();
            gamma_textbox = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            bw_trackbar = new TrackBar();
            button4 = new Button();
            PCXheaderInfoBox = new RichTextBox();
            panel2 = new Panel();
            button2 = new Button();
            button1 = new Button();
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
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bw_trackbar).BeginInit();
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
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(1897, 35);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // menu1ToolStripMenuItem
            // 
            menu1ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openImageToolStripMenuItem });
            menu1ToolStripMenuItem.Name = "menu1ToolStripMenuItem";
            menu1ToolStripMenuItem.Size = new Size(54, 29);
            menu1ToolStripMenuItem.Text = "File";
            // 
            // openImageToolStripMenuItem
            // 
            openImageToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openImageFileToolStripMenuItem, openPCXFileToolStripMenuItem });
            openImageToolStripMenuItem.Name = "openImageToolStripMenuItem";
            openImageToolStripMenuItem.Size = new Size(201, 34);
            openImageToolStripMenuItem.Text = "Open File...";
            // 
            // openImageFileToolStripMenuItem
            // 
            openImageFileToolStripMenuItem.Name = "openImageFileToolStripMenuItem";
            openImageFileToolStripMenuItem.Size = new Size(256, 34);
            openImageFileToolStripMenuItem.Text = "Open Image File...";
            openImageFileToolStripMenuItem.Click += ViewImage_Click;
            // 
            // openPCXFileToolStripMenuItem
            // 
            openPCXFileToolStripMenuItem.Name = "openPCXFileToolStripMenuItem";
            openPCXFileToolStripMenuItem.Size = new Size(256, 34);
            openPCXFileToolStripMenuItem.Text = "Open PCX File...";
            openPCXFileToolStripMenuItem.Click += ViewPCX_Click;
            // 
            // menu2ToolStripMenuItem
            // 
            menu2ToolStripMenuItem.Name = "menu2ToolStripMenuItem";
            menu2ToolStripMenuItem.Size = new Size(58, 29);
            menu2ToolStripMenuItem.Text = "Edit";
            // 
            // processToolStripMenuItem
            // 
            processToolStripMenuItem.Name = "processToolStripMenuItem";
            processToolStripMenuItem.Size = new Size(88, 29);
            processToolStripMenuItem.Text = "Process";
            // 
            // filterToolStripMenuItem
            // 
            filterToolStripMenuItem.Name = "filterToolStripMenuItem";
            filterToolStripMenuItem.Size = new Size(66, 29);
            filterToolStripMenuItem.Text = "Filter";
            // 
            // animationToolStripMenuItem
            // 
            animationToolStripMenuItem.Name = "animationToolStripMenuItem";
            animationToolStripMenuItem.Size = new Size(110, 29);
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
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 237F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 2, 0);
            tableLayoutPanel1.Controls.Add(panel1, 1, 0);
            tableLayoutPanel1.ForeColor = SystemColors.GrayText;
            tableLayoutPanel1.Location = new Point(0, 37);
            tableLayoutPanel1.Margin = new Padding(4, 3, 4, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 33F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 33F));
            tableLayoutPanel1.Size = new Size(1897, 1098);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(panel3, 0, 1);
            tableLayoutPanel2.Controls.Add(PCXheaderInfoBox, 0, 2);
            tableLayoutPanel2.Controls.Add(panel2, 0, 0);
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 14.4897957F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 23.4693871F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 62.0408173F));
            tableLayoutPanel2.Size = new Size(430, 980);
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
            panel3.Controls.Add(button4);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(4, 147);
            panel3.Margin = new Padding(4, 5, 4, 5);
            panel3.Name = "panel3";
            panel3.Size = new Size(422, 220);
            panel3.TabIndex = 4;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.None;
            button3.AutoSize = true;
            button3.BackColor = Color.DimGray;
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(233, 167);
            button3.Margin = new Padding(4, 5, 4, 5);
            button3.Name = "button3";
            button3.Size = new Size(162, 35);
            button3.TabIndex = 11;
            button3.Text = "Transform";
            button3.UseVisualStyleBackColor = false;
            button3.Click += GammaTransform_Click;
            // 
            // gamma_textbox
            // 
            gamma_textbox.Location = new Point(35, 169);
            gamma_textbox.Name = "gamma_textbox";
            gamma_textbox.Size = new Size(182, 31);
            gamma_textbox.TabIndex = 19;
            gamma_textbox.TabStop = false;
            gamma_textbox.KeyPress += textBox1_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ControlText;
            label4.Location = new Point(24, 117);
            label4.Name = "label4";
            label4.Size = new Size(198, 25);
            label4.TabIndex = 18;
            label4.Text = "Gamma Transformation\r\n";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(24, 43);
            label3.Name = "label3";
            label3.Size = new Size(193, 19);
            label3.TabIndex = 17;
            label3.Text = "Adjust B/W Threshold [0, 255]";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(24, 141);
            label2.Name = "label2";
            label2.Size = new Size(155, 19);
            label2.TabIndex = 16;
            label2.Text = "Input Gamma (𝛾) values";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(24, 16);
            label1.Name = "label1";
            label1.Size = new Size(229, 25);
            label1.TabIndex = 15;
            label1.Text = "Black/White Transformation\r\n";
            // 
            // bw_trackbar
            // 
            bw_trackbar.Location = new Point(24, 69);
            bw_trackbar.Maximum = 255;
            bw_trackbar.Name = "bw_trackbar";
            bw_trackbar.Size = new Size(371, 69);
            bw_trackbar.TabIndex = 13;
            bw_trackbar.TickFrequency = 15;
            bw_trackbar.ValueChanged += BW_Scroll;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.None;
            button4.AutoSize = true;
            button4.BackColor = Color.DarkSlateBlue;
            button4.ForeColor = SystemColors.ButtonHighlight;
            button4.Location = new Point(135, 285);
            button4.Margin = new Padding(4, 5, 4, 5);
            button4.Name = "button4";
            button4.Size = new Size(208, 58);
            button4.TabIndex = 12;
            button4.Text = "Gamma Transformation";
            button4.UseVisualStyleBackColor = false;
            // 
            // PCXheaderInfoBox
            // 
            PCXheaderInfoBox.BackColor = SystemColors.ButtonHighlight;
            PCXheaderInfoBox.BorderStyle = BorderStyle.None;
            PCXheaderInfoBox.Dock = DockStyle.Fill;
            PCXheaderInfoBox.Enabled = false;
            PCXheaderInfoBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            PCXheaderInfoBox.ForeColor = SystemColors.MenuText;
            PCXheaderInfoBox.Location = new Point(3, 375);
            PCXheaderInfoBox.Name = "PCXheaderInfoBox";
            PCXheaderInfoBox.ReadOnly = true;
            PCXheaderInfoBox.ScrollBars = RichTextBoxScrollBars.None;
            PCXheaderInfoBox.Size = new Size(424, 602);
            PCXheaderInfoBox.TabIndex = 2;
            PCXheaderInfoBox.Text = "";
            // 
            // panel2
            // 
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(Red);
            panel2.Controls.Add(Green);
            panel2.Controls.Add(Blue);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(4, 5);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(422, 132);
            panel2.TabIndex = 3;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.AutoSize = true;
            button2.BackColor = Color.DarkSlateGray;
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(97, 74);
            button2.Margin = new Padding(4, 5, 4, 5);
            button2.Name = "button2";
            button2.Size = new Size(117, 58);
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
            button1.Location = new Point(222, 74);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(121, 58);
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
            Red.Location = new Point(24, 13);
            Red.Margin = new Padding(4, 5, 4, 5);
            Red.Name = "Red";
            Red.Size = new Size(121, 58);
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
            Green.Location = new Point(153, 13);
            Green.Margin = new Padding(4, 5, 4, 5);
            Green.Name = "Green";
            Green.Size = new Size(119, 58);
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
            Blue.Location = new Point(280, 13);
            Blue.Margin = new Padding(4, 5, 4, 5);
            Blue.Name = "Blue";
            Blue.Size = new Size(115, 58);
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
            tableLayoutPanel3.Location = new Point(1009, 5);
            tableLayoutPanel3.Margin = new Padding(4, 5, 4, 5);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 552F));
            tableLayoutPanel3.Size = new Size(884, 977);
            tableLayoutPanel3.TabIndex = 4;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(imageChannel, 0, 0);
            tableLayoutPanel4.Controls.Add(showHistogram, 1, 0);
            tableLayoutPanel4.Location = new Point(4, 5);
            tableLayoutPanel4.Margin = new Padding(4, 5, 4, 5);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(876, 415);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // imageChannel
            // 
            imageChannel.Location = new Point(4, 5);
            imageChannel.Margin = new Padding(4, 5, 4, 5);
            imageChannel.Name = "imageChannel";
            imageChannel.Size = new Size(429, 405);
            imageChannel.SizeMode = PictureBoxSizeMode.Zoom;
            imageChannel.TabIndex = 0;
            imageChannel.TabStop = false;
            // 
            // showHistogram
            // 
            showHistogram.Location = new Point(442, 5);
            showHistogram.Margin = new Padding(4, 5, 4, 5);
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
            panel1.Location = new Point(440, 5);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(560, 978);
            panel1.TabIndex = 5;
            // 
            // originalImageLabel
            // 
            originalImageLabel.AutoSize = true;
            originalImageLabel.Location = new Point(4, 5);
            originalImageLabel.Margin = new Padding(4, 0, 4, 0);
            originalImageLabel.Name = "originalImageLabel";
            originalImageLabel.Size = new Size(0, 25);
            originalImageLabel.TabIndex = 2;
            // 
            // ViewImage
            // 
            ViewImage.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ViewImage.BackColor = SystemColors.ButtonFace;
            ViewImage.Location = new Point(34, 70);
            ViewImage.Margin = new Padding(4, 3, 4, 3);
            ViewImage.Name = "ViewImage";
            ViewImage.Size = new Size(487, 727);
            ViewImage.SizeMode = PictureBoxSizeMode.Zoom;
            ViewImage.TabIndex = 1;
            ViewImage.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(1897, 1023);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(menuStrip1);
            ForeColor = SystemColors.ActiveBorder;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 3, 4, 3);
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
        private Button button2;
        private Button button1;
        private Panel panel3;
        private Button button4;
        private TrackBar bw_trackbar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button3;
        private TextBox gamma_textbox;
    }
}