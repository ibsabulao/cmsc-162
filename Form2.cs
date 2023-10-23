using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Image_Processing
{
    public partial class Filtering : Form
    {
        private Bitmap originalGrayImage;
        public Filtering(Bitmap grayscaleImage)
        {
            originalGrayImage = new Bitmap(grayscaleImage);
            InitializeComponent();
        }

        private void originalImage_Click(object sender, EventArgs e)
        {
            originalGrayscale.Image = originalGrayImage;
        }

        public void displayGrayscaleImage(Bitmap grayscaleImage)
        {
            originalGrayscale.Image = originalGrayImage;
        }

        private void averagingFilter_Click(object sender, EventArgs e)
        {
            // Create a blank output image with the same dimensions
            Bitmap averageFilteredImage = new Bitmap(originalGrayImage.Width, originalGrayscale.Height);

            // Define the filter size
            int filterSize = 3;

            // Apply the averaging filter to each pixel in the image
            for (int x = 0; x < originalGrayImage.Width; x++)
            {
                for (int y = 0; y < originalGrayImage.Height; y++)
                {
                    Color averagedColor = ApplyAveragingFilter(originalGrayImage, x, y, filterSize);
                    averageFilteredImage.SetPixel(x, y, averagedColor);
                }
            }

            image1.Image = averageFilteredImage;
        }

        // Apply the averaging filter to a specific pixel in the image
        static Color ApplyAveragingFilter(Bitmap image, int x, int y, int filterSize)
        {
            int filterRadius = filterSize / 2;
            int totalR = 0, totalG = 0, totalB = 0;

            for (int i = -filterRadius; i <= filterRadius; i++)
            {
                for (int j = -filterRadius; j <= filterRadius; j++)
                {
                    int pixelX = x + i;
                    int pixelY = y + j;

                    if (pixelX >= 0 && pixelX < image.Width && pixelY >= 0 && pixelY < image.Height)
                    {
                        Color pixelColor = image.GetPixel(pixelX, pixelY);
                        totalR += pixelColor.R;
                        totalG += pixelColor.G;
                        totalB += pixelColor.B;
                    }
                }
            }

            int divisor = filterSize * filterSize;
            byte averagedR = (byte)(totalR / divisor);
            byte averagedG = (byte)(totalG / divisor);
            byte averagedB = (byte)(totalB / divisor);

            return Color.FromArgb(averagedR, averagedG, averagedB);
        }
    }
}
