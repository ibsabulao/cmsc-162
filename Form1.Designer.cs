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
            pcxLabel = new Label();
            PCXheaderInfoBox = new RichTextBox();
            ViewImage = new PictureBox();
            menuStrip1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
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
            menuStrip1.Size = new Size(1518, 28);
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
            filterToolStripMenuItem.Name = "filterToolStripMenuItem";
            filterToolStripMenuItem.Size = new Size(56, 24);
            filterToolStripMenuItem.Text = "Filter";
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
            tableLayoutPanel1.BackColor = SystemColors.ButtonHighlight;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23.0263176F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 53.9473724F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23.0263176F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(ViewImage, 1, 0);
            tableLayoutPanel1.ForeColor = SystemColors.GrayText;
            tableLayoutPanel1.Location = new Point(0, 30);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1518, 790);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(pcxLabel, 0, 0);
            tableLayoutPanel2.Controls.Add(PCXheaderInfoBox, 0, 1);
            tableLayoutPanel2.Location = new Point(2, 2);
            tableLayoutPanel2.Margin = new Padding(2);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 4.50802565F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 59.21565F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 36.27632F));
            tableLayoutPanel2.Size = new Size(345, 785);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // pcxLabel
            // 
            pcxLabel.AutoSize = true;
            pcxLabel.BackColor = Color.Transparent;
            pcxLabel.Dock = DockStyle.Fill;
            pcxLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            pcxLabel.ForeColor = SystemColors.ControlText;
            pcxLabel.Location = new Point(2, 0);
            pcxLabel.Margin = new Padding(2, 0, 2, 0);
            pcxLabel.Name = "pcxLabel";
            pcxLabel.Size = new Size(341, 55);
            pcxLabel.TabIndex = 1;
            // 
            // PCXheaderInfoBox
            // 
            PCXheaderInfoBox.BackColor = SystemColors.ButtonHighlight;
            PCXheaderInfoBox.BorderStyle = BorderStyle.None;
            PCXheaderInfoBox.Dock = DockStyle.Fill;
            PCXheaderInfoBox.Enabled = false;
            PCXheaderInfoBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            PCXheaderInfoBox.ForeColor = SystemColors.MenuText;
            PCXheaderInfoBox.Location = new Point(2, 57);
            PCXheaderInfoBox.Margin = new Padding(2);
            PCXheaderInfoBox.Name = "PCXheaderInfoBox";
            PCXheaderInfoBox.ReadOnly = true;
            PCXheaderInfoBox.ScrollBars = RichTextBoxScrollBars.None;
            PCXheaderInfoBox.Size = new Size(341, 726);
            PCXheaderInfoBox.TabIndex = 2;
            PCXheaderInfoBox.Text = "";
            // 
            // ViewImage
            // 
            ViewImage.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ViewImage.BackColor = SystemColors.Menu;
            ViewImage.Location = new Point(352, 3);
            ViewImage.Name = "ViewImage";
            ViewImage.Size = new Size(812, 784);
            ViewImage.SizeMode = PictureBoxSizeMode.Zoom;
            ViewImage.TabIndex = 1;
            ViewImage.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(1518, 819);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(menuStrip1);
            ForeColor = SystemColors.ActiveBorder;
            MainMenuStrip = menuStrip1;
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
        private Label pcxLabel;
        private RichTextBox PCXheaderInfoBox;
    }
}