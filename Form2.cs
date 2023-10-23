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

            // Dispose of the previous image (if any) to prevent resource leaks
            image1.Image = null;
            image2.Image = null;
            image3.Image = null;
            image1Label.Text = null;
            image2Label.Text = null;
            image3Label.Text = null;
            laplacianKernel.Text = null;
        }

        public void displayGrayscaleImage(Bitmap grayscaleImage)
        {
            // Dispose of the previous image (if any) to prevent resource leaks
            image1.Image = null;
            image2.Image = null;
            image3.Image = null;
            image1Label.Text = null;
            image2Label.Text = null;
            image3Label.Text = null;
            laplacianKernel.Text = null;

            originalGrayscale.Image = originalGrayImage;
        }

        private void averagingFilter_Click(object sender, EventArgs e)
        {
            // Dispose of the previous image (if any) to prevent resource leaks
            image1.Image = null;
            image2.Image = null;
            image3.Image = null;
            image1Label.Text = null;
            image2Label.Text = null;
            image3Label.Text = null;
            laplacianKernel.Text = null;

            image1Label.Text = "Average Filter";

            // Define the filter size
            int filterSize = 3; // You can adjust this value

            // Apply the averaging filter to the originalGrayImage
            Bitmap filteredImage = ApplyAveragingFilter(originalGrayImage, filterSize);

            // Display the filtered image in the originalGrayscale PictureBox
            image1.Image = filteredImage;
        }

        private void medianFilter_Click(object sender, EventArgs e)
        {
            // Dispose of the previous image (if any) to prevent resource leaks
            image1.Image = null;
            image2.Image = null;
            image3.Image = null;
            image1Label.Text = null;
            image2Label.Text = null;
            image3Label.Text = null;
            laplacianKernel.Text = null;

            image1Label.Text = "Median Filter";

            // Define the filter size
            int filterSize = 3; // You can adjust this value

            // Apply the median filter to the originalGrayImage
            Bitmap filteredImage = ApplyMedianFilter(originalGrayImage, filterSize);

            // Display the filtered image in the originalGrayscale PictureBox
            image1.Image = filteredImage;
        }

        private void highpassFilter_Click(object sender, EventArgs e)
        {
            // Dispose of the previous image (if any) to prevent resource leaks
            image1.Image = null;
            image2.Image = null;
            image3.Image = null;
            image1Label.Text = null;
            image2Label.Text = null;
            image3Label.Text = null;
            laplacianKernel.Text = null;

            image1Label.Text = "Highpass Filter";
            laplacianKernel.Text = "Filter used in\r\nLaplacian operator\r\n[ -1, -1, -1 ]\r\n[ -1,  8, -1 ]\r\n[ -1, -1, -1 ]";
            // Apply the Laplacian filter to the originalGrayImage
            Bitmap laplacianImage = ApplyLaplacianFilter(originalGrayImage);

            // Display the Laplacian image in the originalGrayscale PictureBox
            image1.Image = laplacianImage;
        }

        private void unsharpMasking_Click(object sender, EventArgs e)
        {
            // Dispose of the previous image (if any) to prevent resource leaks
            image1.Image = null;
            image2.Image = null;
            image3.Image = null;
            image1Label.Text = null;
            image2Label.Text = null;
            image3Label.Text = null;
            laplacianKernel.Text = null;

            image1Label.Text = "Blurred using Averaging Filter";
            image2Label.Text = "Subtracted";
            image3Label.Text = "Unsharp Masking";

            // Define the filter size for the averaging filter
            int filterSize = 3; // You can adjust this value

            // Define the sharpening factor (alpha)
            double alpha = 1; // You can adjust this value

            // Apply the averaging filter to the originalGrayImage to create a blurred version
            Bitmap blurredImage = ApplyAveragingFilter(originalGrayImage, filterSize);

            // Calculate the difference between the originalGrayImage and the blurred image
            Bitmap differenceImage = new Bitmap(originalGrayImage.Width, originalGrayImage.Height);
            for (int x = 0; x < originalGrayImage.Width; x++)
            {
                for (int y = 0; y < originalGrayImage.Height; y++)
                {
                    Color originalColor = originalGrayImage.GetPixel(x, y);
                    Color blurredColor = blurredImage.GetPixel(x, y);

                    int diffValue = originalColor.R - blurredColor.R; // Assuming grayscale

                    byte diffR = (byte)Math.Max(0, Math.Min(255, diffValue));

                    differenceImage.SetPixel(x, y, Color.FromArgb(diffR, diffR, diffR));
                }
            }

            // Combine the original image with the difference image using alpha
            Bitmap sharpenedImage = new Bitmap(originalGrayImage.Width, originalGrayImage.Height);
            for (int x = 0; x < originalGrayImage.Width; x++)
            {
                for (int y = 0; y < originalGrayImage.Height; y++)
                {
                    Color originalColor = originalGrayImage.GetPixel(x, y);
                    Color diffColor = differenceImage.GetPixel(x, y);

                    int sharpenedValue = originalColor.R + (int)(alpha * diffColor.R);

                    byte sharpenedR = (byte)Math.Max(0, Math.Min(255, sharpenedValue));

                    sharpenedImage.SetPixel(x, y, Color.FromArgb(sharpenedR, sharpenedR, sharpenedR));
                }
            }

            // Display the sharpened image in the originalGrayscale PictureBox
            image1.Image = blurredImage;
            image2.Image = differenceImage;
            image3.Image = sharpenedImage;
        }

        private void highboostFiltering_Click(object sender, EventArgs e)
        {
            // Dispose of the previous image (if any) to prevent resource leaks
            image1.Image = null;
            image2.Image = null;
            image3.Image = null;
            image1Label.Text = null;
            image2Label.Text = null;
            image3Label.Text = null;
            laplacianKernel.Text = null;

            // Define the filter size for the low-pass filter (averaging filter)
            int filterSize = 3; // You can adjust this value

            // Define the amplification factor (A)
            double A = 3.2; // You can adjust this value
            image1Label.Text = "Highboost Filtering (Amplication Parameter: " + A + ")";

            // Apply the averaging filter to the originalGrayImage to create a low-pass version
            Bitmap lowpassImage = ApplyAveragingFilter(originalGrayImage, filterSize);

            // Calculate the high-pass image (Highpass = Original - Lowpass)
            Bitmap highpassImage = new Bitmap(originalGrayImage.Width, originalGrayImage.Height);
            for (int x = 0; x < originalGrayImage.Width; x++)
            {
                for (int y = 0; y < originalGrayImage.Height; y++)
                {
                    Color originalColor = originalGrayImage.GetPixel(x, y);
                    Color lowpassColor = lowpassImage.GetPixel(x, y);

                    int highpassValue = originalColor.R - lowpassColor.R; // Assuming grayscale

                    byte highpassR = (byte)Math.Max(0, Math.Min(255, highpassValue));

                    highpassImage.SetPixel(x, y, Color.FromArgb(highpassR, highpassR, highpassR));
                }
            }

            // Calculate the high-boost image (High boost = (A-1)(Original) + Highpass)
            Bitmap highboostImage = new Bitmap(originalGrayImage.Width, originalGrayImage.Height);
            for (int x = 0; x < originalGrayImage.Width; x++)
            {
                for (int y = 0; y < originalGrayImage.Height; y++)
                {
                    Color originalColor = originalGrayImage.GetPixel(x, y);
                    Color highpassColor = highpassImage.GetPixel(x, y);

                    int highboostValue = (int)((A - 1.0) * originalColor.R) + highpassColor.R;

                    byte highboostR = (byte)Math.Max(0, Math.Min(255, highboostValue));

                    highboostImage.SetPixel(x, y, Color.FromArgb(highboostR, highboostR, highboostR));
                }
            }

            // Display the high-boost image in the originalGrayscale PictureBox
            image1.Image = highboostImage;
        }

        private void gradient_Click(object sender, EventArgs e)
        {
            // Dispose of the previous image (if any) to prevent resource leaks
            image1.Image = null;
            image2.Image = null;
            image3.Image = null;
            image1Label.Text = null;
            image2Label.Text = null;
            image3Label.Text = null;
            laplacianKernel.Text = null;

            image1Label.Text = "Sobel Operator (XY)";
            image2Label.Text = "Sobel Operator (X)";
            image3Label.Text = "Sobel Operator (Y)";

            // Apply the Sobel operator to the originalGrayImage to calculate the gradient
            Bitmap gradientXImage, gradientYImage, gradientMagnitudeImage;
            ApplySobelOperator(originalGrayImage, out gradientXImage, out gradientYImage, out gradientMagnitudeImage);

            // Display the gradient images in respective PictureBox controls
            image2.Image = gradientXImage;
            image3.Image = gradientYImage;
            image1.Image = gradientMagnitudeImage;
        }

        // Apply the averaging filter to a specific pixel in the image
        private Bitmap ApplyAveragingFilter(Bitmap image, int filterSize)
        {
            Bitmap filteredImage = new Bitmap(image.Width, image.Height);

            for (int x = 0; x < image.Width; x++)
            {
                for (int y = 0; y < image.Height; y++)
                {
                    Color averagedColor = CalculateAveragedColor(image, x, y, filterSize);
                    filteredImage.SetPixel(x, y, averagedColor);
                }
            }

            return filteredImage;
        }

        // Calculate the averaged color for a specific pixel in the image
        private Color CalculateAveragedColor(Bitmap image, int x, int y, int filterSize)
        {
            int filterRadius = filterSize / 2;
            int totalR = 0, totalG = 0, totalB = 0;
            int divisor = filterSize * filterSize;

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

            byte averagedR = (byte)(totalR / divisor);
            byte averagedG = (byte)(totalG / divisor);
            byte averagedB = (byte)(totalB / divisor);

            return Color.FromArgb(averagedR, averagedG, averagedB);
        }

        // Apply the median filter to a specific pixel in the image
        private Bitmap ApplyMedianFilter(Bitmap image, int filterSize)
        {
            Bitmap filteredImage = new Bitmap(image.Width, image.Height);

            for (int x = 0; x < image.Width; x++)
            {
                for (int y = 0; y < image.Height; y++)
                {
                    Color medianColor = CalculateMedianColor(image, x, y, filterSize);
                    filteredImage.SetPixel(x, y, medianColor);
                }
            }

            return filteredImage;
        }

        // Calculate the median color for a specific pixel in the image
        private Color CalculateMedianColor(Bitmap image, int x, int y, int filterSize)
        {
            int filterRadius = filterSize / 2;
            List<byte> redValues = new List<byte>();
            List<byte> greenValues = new List<byte>();
            List<byte> blueValues = new List<byte>();

            for (int i = -filterRadius; i <= filterRadius; i++)
            {
                for (int j = -filterRadius; j <= filterRadius; j++)
                {
                    int pixelX = x + i;
                    int pixelY = y + j;

                    if (pixelX >= 0 && pixelX < image.Width && pixelY >= 0 && pixelY < image.Height)
                    {
                        Color pixelColor = image.GetPixel(pixelX, pixelY);
                        redValues.Add(pixelColor.R);
                        greenValues.Add(pixelColor.G);
                        blueValues.Add(pixelColor.B);
                    }
                }
            }

            byte medianR = GetMedianValue(redValues);
            byte medianG = GetMedianValue(greenValues);
            byte medianB = GetMedianValue(blueValues);

            return Color.FromArgb(medianR, medianG, medianB);
        }

        private byte GetMedianValue(List<byte> values)
        {
            values.Sort();
            int middle = values.Count / 2;
            return values[middle];
        }

        // Apply the Laplacian filter to an image
        private Bitmap ApplyLaplacianFilter(Bitmap image)
        {
            Bitmap filteredImage = new Bitmap(image.Width, image.Height);

            int[,] laplacianKernel = {
            { -1, -1, -1 },
            { -1,  8, -1 },
            { -1, -1, -1 }
        };

            int kernelSize = 3;
            int kernelOffset = kernelSize / 2;

            for (int x = 0; x < image.Width; x++)
            {
                for (int y = 0; y < image.Height; y++)
                {
                    int sumR = 0, sumG = 0, sumB = 0;

                    for (int i = -kernelOffset; i <= kernelOffset; i++)
                    {
                        for (int j = -kernelOffset; j <= kernelOffset; j++)
                        {
                            int pixelX = x + i;
                            int pixelY = y + j;

                            if (pixelX >= 0 && pixelX < image.Width && pixelY >= 0 && pixelY < image.Height)
                            {
                                Color pixelColor = image.GetPixel(pixelX, pixelY);
                                int kernelValue = laplacianKernel[i + kernelOffset, j + kernelOffset];

                                sumR += pixelColor.R * kernelValue;
                                sumG += pixelColor.G * kernelValue;
                                sumB += pixelColor.B * kernelValue;
                            }
                        }
                    }

                    sumR = Math.Max(0, Math.Min(255, sumR));
                    sumG = Math.Max(0, Math.Min(255, sumG));
                    sumB = Math.Max(0, Math.Min(255, sumB));

                    Color filteredColor = Color.FromArgb(sumR, sumG, sumB);
                    filteredImage.SetPixel(x, y, filteredColor);
                }
            }

            return filteredImage;
        }

        private void ApplySobelOperator(Bitmap image, out Bitmap gradientXImage, out Bitmap gradientYImage, out Bitmap gradientMagnitudeImage)
        {
            gradientXImage = new Bitmap(image.Width, image.Height);
            gradientYImage = new Bitmap(image.Width, image.Height);
            gradientMagnitudeImage = new Bitmap(image.Width, image.Height);

            int[,] sobelX = {
                { -1, 0, 1 },
                { -2, 0, 2 },
                { -1, 0, 1 }
            };

            int[,] sobelY = {
                { -1, -2, -1 },
                { 0, 0, 0 },
                { 1, 2, 1 }
            };

            int width = image.Width;
            int height = image.Height;

            for (int x = 1; x < width - 1; x++)
            {
                for (int y = 1; y < height - 1; y++)
                {
                    int gradientX = 0;
                    int gradientY = 0;

                    for (int i = -1; i <= 1; i++)
                    {
                        for (int j = -1; j <= 1; j++)
                        {
                            Color pixelColor = image.GetPixel(x + i, y + j);
                            int grayValue = (int)(0.299 * pixelColor.R + 0.587 * pixelColor.G + 0.114 * pixelColor.B);

                            gradientX += sobelX[i + 1, j + 1] * grayValue;
                            gradientY += sobelY[i + 1, j + 1] * grayValue;
                        }
                    }

                    int normalizedGradientX = Math.Max(0, Math.Min(255, gradientX));
                    int normalizedGradientY = Math.Max(0, Math.Min(255, gradientY));

                    gradientXImage.SetPixel(x, y, Color.FromArgb(normalizedGradientX, normalizedGradientX, normalizedGradientX));
                    gradientYImage.SetPixel(x, y, Color.FromArgb(normalizedGradientY, normalizedGradientY, normalizedGradientY));

                    int magnitude = (int)Math.Sqrt(gradientX * gradientX + gradientY * gradientY);
                    magnitude = Math.Max(0, Math.Min(255, magnitude));
                    gradientMagnitudeImage.SetPixel(x, y, Color.FromArgb(magnitude, magnitude, magnitude));
                }
            }
        }
    }
}
