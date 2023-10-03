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
            PCXviewImg = new PictureBox();
            pcxLabel = new Label();
            PCXheaderInfoBox = new RichTextBox();
            pcxPalette = new Panel();
            ViewImage = new PictureBox();
            menuStrip1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PCXviewImg).BeginInit();
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
            menuStrip1.Padding = new Padding(8, 2, 0, 2);
            menuStrip1.Size = new Size(1898, 33);
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
            tableLayoutPanel1.BackColor = SystemColors.ButtonHighlight;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23.0263176F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 53.9473724F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23.0263176F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(ViewImage, 1, 0);
            tableLayoutPanel1.ForeColor = SystemColors.GrayText;
            tableLayoutPanel1.Location = new Point(0, 37);
            tableLayoutPanel1.Margin = new Padding(4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1898, 987);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(PCXviewImg, 0, 1);
            tableLayoutPanel2.Controls.Add(pcxLabel, 0, 0);
            tableLayoutPanel2.Controls.Add(PCXheaderInfoBox, 0, 2);
            tableLayoutPanel2.Controls.Add(pcxPalette, 0, 3);
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 4;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 2.691249F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 29.2976322F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 46.3545036F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 21.65662F));
            tableLayoutPanel2.Size = new Size(431, 981);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // PCXviewImg
            // 
            PCXviewImg.BackColor = SystemColors.Desktop;
            PCXviewImg.Dock = DockStyle.Fill;
            PCXviewImg.Location = new Point(3, 29);
            PCXviewImg.Name = "PCXviewImg";
            PCXviewImg.Size = new Size(425, 281);
            PCXviewImg.TabIndex = 0;
            PCXviewImg.TabStop = false;
            // 
            // pcxLabel
            // 
            pcxLabel.AutoSize = true;
            pcxLabel.BackColor = SystemColors.Desktop;
            pcxLabel.Dock = DockStyle.Fill;
            pcxLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            pcxLabel.ForeColor = SystemColors.ControlText;
            pcxLabel.Location = new Point(3, 0);
            pcxLabel.Name = "pcxLabel";
            pcxLabel.Size = new Size(425, 26);
            pcxLabel.TabIndex = 1;
            // 
            // PCXheaderInfoBox
            // 
            PCXheaderInfoBox.BackColor = SystemColors.Desktop;
            PCXheaderInfoBox.BorderStyle = BorderStyle.None;
            PCXheaderInfoBox.Dock = DockStyle.Fill;
            PCXheaderInfoBox.Enabled = false;
            PCXheaderInfoBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            PCXheaderInfoBox.ForeColor = SystemColors.MenuText;
            PCXheaderInfoBox.Location = new Point(3, 316);
            PCXheaderInfoBox.Name = "PCXheaderInfoBox";
            PCXheaderInfoBox.ReadOnly = true;
            PCXheaderInfoBox.ScrollBars = RichTextBoxScrollBars.None;
            PCXheaderInfoBox.Size = new Size(425, 448);
            PCXheaderInfoBox.TabIndex = 2;
            PCXheaderInfoBox.Text = "";
            // 
            // pcxPalette
            // 
            pcxPalette.BackColor = SystemColors.Desktop;
            pcxPalette.Dock = DockStyle.Fill;
            pcxPalette.Location = new Point(3, 770);
            pcxPalette.Name = "pcxPalette";
            pcxPalette.Size = new Size(425, 208);
            pcxPalette.TabIndex = 3;
            // 
            // ViewImage
            // 
            ViewImage.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ViewImage.BackColor = SystemColors.Menu;
            ViewImage.Location = new Point(441, 4);
            ViewImage.Margin = new Padding(4);
            ViewImage.Name = "ViewImage";
            ViewImage.Size = new Size(1015, 979);
            ViewImage.SizeMode = PictureBoxSizeMode.Zoom;
            ViewImage.TabIndex = 1;
            ViewImage.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(1898, 1024);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(menuStrip1);
            ForeColor = SystemColors.ActiveBorder;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4);
            Name = "Form1";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.WindowsDefaultBounds;
            Text = "View";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PCXviewImg).EndInit();
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
        private PictureBox PCXviewImg;
        private Label pcxLabel;
        private RichTextBox PCXheaderInfoBox;
        private Panel pcxPalette;
    }
}