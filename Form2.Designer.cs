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
            gradient = new Button();
            highboostFiltering = new Button();
            unsharpMasking = new Button();
            highpassFilter = new Button();
            medianFilter = new Button();
            averagingFilter = new Button();
            originalImage = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel2 = new Panel();
            originalGrayscaleLabel = new Label();
            originalGrayscale = new PictureBox();
            panel3 = new Panel();
            image1Label = new Label();
            image1 = new PictureBox();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)originalGrayscale).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)image1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(gradient);
            panel1.Controls.Add(highboostFiltering);
            panel1.Controls.Add(unsharpMasking);
            panel1.Controls.Add(highpassFilter);
            panel1.Controls.Add(medianFilter);
            panel1.Controls.Add(averagingFilter);
            panel1.Controls.Add(originalImage);
            panel1.Location = new Point(2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(129, 533);
            panel1.TabIndex = 0;
            // 
            // gradient
            // 
            gradient.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            gradient.Location = new Point(3, 178);
            gradient.Name = "gradient";
            gradient.Size = new Size(123, 23);
            gradient.TabIndex = 6;
            gradient.Text = "Gradient";
            gradient.UseVisualStyleBackColor = true;
            // 
            // highboostFiltering
            // 
            highboostFiltering.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            highboostFiltering.Location = new Point(3, 149);
            highboostFiltering.Name = "highboostFiltering";
            highboostFiltering.Size = new Size(123, 23);
            highboostFiltering.TabIndex = 5;
            highboostFiltering.Text = "Highboost Filtering";
            highboostFiltering.UseVisualStyleBackColor = true;
            // 
            // unsharpMasking
            // 
            unsharpMasking.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            unsharpMasking.Location = new Point(3, 120);
            unsharpMasking.Name = "unsharpMasking";
            unsharpMasking.Size = new Size(123, 23);
            unsharpMasking.TabIndex = 4;
            unsharpMasking.Text = "Unsharp Masking";
            unsharpMasking.UseVisualStyleBackColor = true;
            // 
            // highpassFilter
            // 
            highpassFilter.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            highpassFilter.Location = new Point(3, 91);
            highpassFilter.Name = "highpassFilter";
            highpassFilter.Size = new Size(123, 23);
            highpassFilter.TabIndex = 3;
            highpassFilter.Text = "Highpass Filter";
            highpassFilter.UseVisualStyleBackColor = true;
            // 
            // medianFilter
            // 
            medianFilter.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            medianFilter.Location = new Point(3, 62);
            medianFilter.Name = "medianFilter";
            medianFilter.Size = new Size(123, 23);
            medianFilter.TabIndex = 2;
            medianFilter.Text = "Median Filter";
            medianFilter.UseVisualStyleBackColor = true;
            // 
            // averagingFilter
            // 
            averagingFilter.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            averagingFilter.Location = new Point(3, 33);
            averagingFilter.Name = "averagingFilter";
            averagingFilter.Size = new Size(123, 23);
            averagingFilter.TabIndex = 1;
            averagingFilter.Text = "Averaging Filter";
            averagingFilter.UseVisualStyleBackColor = true;
            averagingFilter.Click += averagingFilter_Click;
            // 
            // originalImage
            // 
            originalImage.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            originalImage.Location = new Point(3, 4);
            originalImage.Name = "originalImage";
            originalImage.Size = new Size(123, 23);
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
            tableLayoutPanel1.Controls.Add(panel3, 1, 0);
            tableLayoutPanel1.Controls.Add(panel2, 0, 0);
            tableLayoutPanel1.Location = new Point(134, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(727, 533);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(originalGrayscaleLabel);
            panel2.Controls.Add(originalGrayscale);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(357, 260);
            panel2.TabIndex = 0;
            // 
            // originalGrayscaleLabel
            // 
            originalGrayscaleLabel.AutoSize = true;
            originalGrayscaleLabel.Location = new Point(3, 1);
            originalGrayscaleLabel.Name = "originalGrayscaleLabel";
            originalGrayscaleLabel.Size = new Size(102, 15);
            originalGrayscaleLabel.TabIndex = 1;
            originalGrayscaleLabel.Text = "Original Grayscale";
            // 
            // originalGrayscale
            // 
            originalGrayscale.Location = new Point(0, 19);
            originalGrayscale.Name = "originalGrayscale";
            originalGrayscale.Size = new Size(357, 241);
            originalGrayscale.SizeMode = PictureBoxSizeMode.Zoom;
            originalGrayscale.TabIndex = 0;
            originalGrayscale.TabStop = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(image1Label);
            panel3.Controls.Add(image1);
            panel3.Location = new Point(366, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(357, 260);
            panel3.TabIndex = 1;
            // 
            // image1Label
            // 
            image1Label.AutoSize = true;
            image1Label.Location = new Point(3, 1);
            image1Label.Name = "image1Label";
            image1Label.Size = new Size(46, 15);
            image1Label.TabIndex = 1;
            image1Label.Text = "Image1";
            // 
            // image1
            // 
            image1.Location = new Point(0, 19);
            image1.Name = "image1";
            image1.Size = new Size(357, 241);
            image1.SizeMode = PictureBoxSizeMode.Zoom;
            image1.TabIndex = 0;
            image1.TabStop = false;
            // 
            // Filtering
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(862, 537);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel1);
            Name = "Filtering";
            Text = "Form2";
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)originalGrayscale).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)image1).EndInit();
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
        private Label image1Label;
        private PictureBox image1;
    }
}