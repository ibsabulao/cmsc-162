namespace Image_Processing
{
    partial class Filtering
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            laplacianKernel = new Label();
            gradient = new Button();
            highboostFiltering = new Button();
            unsharpMasking = new Button();
            highpassFilter = new Button();
            medianFilter = new Button();
            averagingFilter = new Button();
            originalImage = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel5 = new Panel();
            image2Label = new Label();
            image2 = new PictureBox();
            panel4 = new Panel();
            image3Label = new Label();
            image3 = new PictureBox();
            panel3 = new Panel();
            image1Label = new Label();
            image1 = new PictureBox();
            panel2 = new Panel();
            originalGrayscaleLabel = new Label();
            originalGrayscale = new PictureBox();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)image2).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)image3).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)image1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)originalGrayscale).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(laplacianKernel);
            panel1.Controls.Add(gradient);
            panel1.Controls.Add(highboostFiltering);
            panel1.Controls.Add(unsharpMasking);
            panel1.Controls.Add(highpassFilter);
            panel1.Controls.Add(medianFilter);
            panel1.Controls.Add(averagingFilter);
            panel1.Controls.Add(originalImage);
            panel1.Location = new Point(3, 3);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(184, 888);
            panel1.TabIndex = 0;
            // 
            // laplacianKernel
            // 
            laplacianKernel.AutoSize = true;
            laplacianKernel.Dock = DockStyle.Bottom;
            laplacianKernel.Location = new Point(0, 863);
            laplacianKernel.Margin = new Padding(4, 0, 4, 0);
            laplacianKernel.Name = "laplacianKernel";
            laplacianKernel.Size = new Size(0, 25);
            laplacianKernel.TabIndex = 7;
            laplacianKernel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // gradient
            // 
            gradient.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            gradient.Location = new Point(4, 297);
            gradient.Margin = new Padding(4, 5, 4, 5);
            gradient.Name = "gradient";
            gradient.Size = new Size(176, 38);
            gradient.TabIndex = 6;
            gradient.Text = "Gradient";
            gradient.UseVisualStyleBackColor = true;
            gradient.Click += gradient_Click;
            // 
            // highboostFiltering
            // 
            highboostFiltering.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            highboostFiltering.Location = new Point(4, 248);
            highboostFiltering.Margin = new Padding(4, 5, 4, 5);
            highboostFiltering.Name = "highboostFiltering";
            highboostFiltering.Size = new Size(176, 38);
            highboostFiltering.TabIndex = 5;
            highboostFiltering.Text = "Highboost Filtering";
            highboostFiltering.UseVisualStyleBackColor = true;
            highboostFiltering.Click += highboostFiltering_Click;
            // 
            // unsharpMasking
            // 
            unsharpMasking.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            unsharpMasking.Location = new Point(4, 200);
            unsharpMasking.Margin = new Padding(4, 5, 4, 5);
            unsharpMasking.Name = "unsharpMasking";
            unsharpMasking.Size = new Size(176, 38);
            unsharpMasking.TabIndex = 4;
            unsharpMasking.Text = "Unsharp Masking";
            unsharpMasking.UseVisualStyleBackColor = true;
            unsharpMasking.Click += unsharpMasking_Click;
            // 
            // highpassFilter
            // 
            highpassFilter.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            highpassFilter.Location = new Point(4, 152);
            highpassFilter.Margin = new Padding(4, 5, 4, 5);
            highpassFilter.Name = "highpassFilter";
            highpassFilter.Size = new Size(176, 38);
            highpassFilter.TabIndex = 3;
            highpassFilter.Text = "Highpass Filter";
            highpassFilter.UseVisualStyleBackColor = true;
            highpassFilter.Click += highpassFilter_Click;
            // 
            // medianFilter
            // 
            medianFilter.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            medianFilter.Location = new Point(4, 103);
            medianFilter.Margin = new Padding(4, 5, 4, 5);
            medianFilter.Name = "medianFilter";
            medianFilter.Size = new Size(176, 38);
            medianFilter.TabIndex = 2;
            medianFilter.Text = "Median Filter";
            medianFilter.UseVisualStyleBackColor = true;
            medianFilter.Click += medianFilter_Click;
            // 
            // averagingFilter
            // 
            averagingFilter.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            averagingFilter.Location = new Point(4, 55);
            averagingFilter.Margin = new Padding(4, 5, 4, 5);
            averagingFilter.Name = "averagingFilter";
            averagingFilter.Size = new Size(176, 38);
            averagingFilter.TabIndex = 1;
            averagingFilter.Text = "Averaging Filter";
            averagingFilter.UseVisualStyleBackColor = true;
            averagingFilter.Click += averagingFilter_Click;
            // 
            // originalImage
            // 
            originalImage.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            originalImage.Location = new Point(4, 7);
            originalImage.Margin = new Padding(4, 5, 4, 5);
            originalImage.Name = "originalImage";
            originalImage.Size = new Size(176, 38);
            originalImage.TabIndex = 0;
            originalImage.Text = "Use Original Image";
            originalImage.UseVisualStyleBackColor = true;
            originalImage.Click += originalImage_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(panel5, 0, 1);
            tableLayoutPanel1.Controls.Add(panel4, 0, 1);
            tableLayoutPanel1.Controls.Add(panel3, 1, 0);
            tableLayoutPanel1.Controls.Add(panel2, 0, 0);
            tableLayoutPanel1.Location = new Point(191, 3);
            tableLayoutPanel1.Margin = new Padding(4, 5, 4, 5);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1039, 888);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.Controls.Add(image2Label);
            panel5.Controls.Add(image2);
            panel5.Location = new Point(4, 449);
            panel5.Margin = new Padding(4, 5, 4, 5);
            panel5.Name = "panel5";
            panel5.Size = new Size(510, 433);
            panel5.TabIndex = 3;
            // 
            // image2Label
            // 
            image2Label.AutoSize = true;
            image2Label.Location = new Point(7, 3);
            image2Label.Margin = new Padding(4, 0, 4, 0);
            image2Label.Name = "image2Label";
            image2Label.Size = new Size(59, 25);
            image2Label.TabIndex = 1;
            image2Label.Text = "label1";
            // 
            // image2
            // 
            image2.Location = new Point(0, 32);
            image2.Margin = new Padding(4, 5, 4, 5);
            image2.Name = "image2";
            image2.Size = new Size(510, 402);
            image2.SizeMode = PictureBoxSizeMode.Zoom;
            image2.TabIndex = 0;
            image2.TabStop = false;
            // 
            // panel4
            // 
            panel4.Controls.Add(image3Label);
            panel4.Controls.Add(image3);
            panel4.Location = new Point(523, 449);
            panel4.Margin = new Padding(4, 5, 4, 5);
            panel4.Name = "panel4";
            panel4.Size = new Size(510, 433);
            panel4.TabIndex = 2;
            // 
            // image3Label
            // 
            image3Label.AutoSize = true;
            image3Label.Location = new Point(3, 3);
            image3Label.Margin = new Padding(4, 0, 4, 0);
            image3Label.Name = "image3Label";
            image3Label.Size = new Size(59, 25);
            image3Label.TabIndex = 1;
            image3Label.Text = "label1";
            // 
            // image3
            // 
            image3.Location = new Point(0, 32);
            image3.Margin = new Padding(4, 5, 4, 5);
            image3.Name = "image3";
            image3.Size = new Size(510, 402);
            image3.SizeMode = PictureBoxSizeMode.Zoom;
            image3.TabIndex = 0;
            image3.TabStop = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(image1Label);
            panel3.Controls.Add(image1);
            panel3.Location = new Point(523, 5);
            panel3.Margin = new Padding(4, 5, 4, 5);
            panel3.Name = "panel3";
            panel3.Size = new Size(510, 433);
            panel3.TabIndex = 1;
            // 
            // image1Label
            // 
            image1Label.AutoSize = true;
            image1Label.Location = new Point(3, 3);
            image1Label.Margin = new Padding(4, 0, 4, 0);
            image1Label.Name = "image1Label";
            image1Label.Size = new Size(59, 25);
            image1Label.TabIndex = 1;
            image1Label.Text = "label1";
            // 
            // image1
            // 
            image1.Location = new Point(0, 32);
            image1.Margin = new Padding(4, 5, 4, 5);
            image1.Name = "image1";
            image1.Size = new Size(510, 402);
            image1.SizeMode = PictureBoxSizeMode.Zoom;
            image1.TabIndex = 0;
            image1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(originalGrayscaleLabel);
            panel2.Controls.Add(originalGrayscale);
            panel2.Location = new Point(4, 5);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(510, 433);
            panel2.TabIndex = 0;
            // 
            // originalGrayscaleLabel
            // 
            originalGrayscaleLabel.AutoSize = true;
            originalGrayscaleLabel.Location = new Point(4, 2);
            originalGrayscaleLabel.Margin = new Padding(4, 0, 4, 0);
            originalGrayscaleLabel.Name = "originalGrayscaleLabel";
            originalGrayscaleLabel.Size = new Size(153, 25);
            originalGrayscaleLabel.TabIndex = 1;
            originalGrayscaleLabel.Text = "Original Grayscale";
            // 
            // originalGrayscale
            // 
            originalGrayscale.Location = new Point(0, 32);
            originalGrayscale.Margin = new Padding(4, 5, 4, 5);
            originalGrayscale.Name = "originalGrayscale";
            originalGrayscale.Size = new Size(510, 402);
            originalGrayscale.SizeMode = PictureBoxSizeMode.Zoom;
            originalGrayscale.TabIndex = 0;
            originalGrayscale.TabStop = false;
            // 
            // Filtering
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1220, 912);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel1);
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            MaximumSize = new Size(1242, 968);
            MinimizeBox = false;
            MinimumSize = new Size(1242, 968);
            Name = "Filtering";
            Text = "Form2";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)image2).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)image3).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)image1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)originalGrayscale).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button originalImage;
        private Button averagingFilter;
        private Button highpassFilter;
        private Button medianFilter;
        private Button unsharpMasking;
        private Button gradient;
        private Button highboostFiltering;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel2;
        private PictureBox originalGrayscale;
        private Label originalGrayscaleLabel;
        private Panel panel3;
        private PictureBox image1;
        private Panel panel4;
        private PictureBox image3;
        private Panel panel5;
        private PictureBox image2;
        private Label image1Label;
        private Label image2Label;
        private Label image3Label;
        private Label laplacianKernel;
    }
}