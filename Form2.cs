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
        private Bitmap originalGrayImage; // Field to store the original grayscale image.

        // Constructor for the Spatial Filtering form.
        public Filtering(Bitmap grayscaleImage)
        {
            // Initialize the originalGrayImage field with the provided grayscale image.
            originalGrayImage = new Bitmap(grayscaleImage);
            InitializeComponent();
        }

        // Event handler for the originalImage_Click event.
        private void originalImage_Click(object sender, EventArgs e)
        {
            // Display the original grayscale image in the originalGrayscale PictureBox.
            originalGrayscale.Image = originalGrayImage;

            // Dispose of any previously displayed images to prevent resource leaks.
            image1.Image = null;
            image2.Image = null;
            image3.Image = null;
            image1Label.Text = null;
            image2Label.Text = null;
            image3Label.Text = null;
            laplacianKernel.Text = null;
        }

        // The displayGrayscaleImage method is responsible for displaying a grayscale image in the form.
        public void displayGrayscaleImage(Bitmap grayscaleImage)
        {
            // Dispose of any previously displayed images and clear associated labels to prevent resource leaks.
            image1.Image = null;
            image2.Image = null;
            image3.Image = null;
            image1Label.Text = null;
            image2Label.Text = null;
            image3Label.Text = null;
            laplacianKernel.Text = null;

            // Display the provided grayscale image in the originalGrayscale PictureBox.
            originalGrayscale.Image = originalGrayImage;
        }

        // The averagingFilter_Click event handler is triggered when the "Averaging Filter" button is clicked.
        private void averagingFilter_Click(object sender, EventArgs e)
        {
            // Dispose of the previous images and clear associated labels to prevent resource leaks.
            image1.Image = null;
            image2.Image = null;
            image3.Image = null;
            image1Label.Text = null;
            image2Label.Text = null;
            image3Label.Text = null;
            laplacianKernel.Text = null;

            // Set the label to indicate the applied filter.
            image1Label.Text = "Average Filter";

            // Define the filter size (you can adjust this value as needed).
            int filterSize = 3;

            // Apply the averaging filter to the original grayscale image.
            Bitmap filteredImage = ApplyAveragingFilter(originalGrayImage, filterSize);

            // Display the filtered image in the originalGrayscale PictureBox.
            image1.Image = filteredImage;
        }

        // The medianFilter_Click event handler is triggered when the "Median Filter" button is clicked.
        private void medianFilter_Click(object sender, EventArgs e)
        {
            // Dispose of the previous images and clear associated labels to prevent resource leaks.
            image1.Image = null;
            image2.Image = null;
            image3.Image = null;
            image1Label.Text = null;
            image2Label.Text = null;
            image3Label.Text = null;
            laplacianKernel.Text = null;

            // Set the label to indicate the applied filter.
            image1Label.Text = "Median Filter";

            // Define the filter size (you can adjust this value as needed).
            int filterSize = 3;

            // Apply the median filter to the original grayscale image.
            Bitmap filteredImage = ApplyMedianFilter(originalGrayImage, filterSize);

            // Display the filtered image in the originalGrayscale PictureBox.
            image1.Image = filteredImage;
        }

        // The highpassFilter_Click event handler is triggered when the "Highpass Filter" button is clicked.

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

        // The unsharpMasking_Click event handler is triggered when the "Unsharp Masking" button is clicked.
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

        // The highboostFiltering_Click event handler is triggered when the "Highboost Filtering" button is clicked.
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

            // Create a new Bitmap to store the high-pass image with the same dimensions as the original grayscale image.
            Bitmap highpassImage = new Bitmap(originalGrayImage.Width, originalGrayImage.Height);

            // Iterate through each pixel in the original grayscale image.
            for (int x = 0; x < originalGrayImage.Width; x++)
            {
                for (int y = 0; y < originalGrayImage.Height; y++)
                {
                    // Get the color of the corresponding pixel in the original grayscale image.
                    Color originalColor = originalGrayImage.GetPixel(x, y);
                    // Get the color of the corresponding pixel in the low-pass image.
                    Color lowpassColor = lowpassImage.GetPixel(x, y);
                    // Calculate the high-pass value for the pixel. Assuming grayscale, subtract the low-pass value from the original value.
                    int highpassValue = originalColor.R - lowpassColor.R;
                    // Ensure the high-pass value is within the valid range [0, 255].
                    byte highpassR = (byte)Math.Max(0, Math.Min(255, highpassValue));
                    // Set the corresponding pixel in the high-pass image to the calculated high-pass value, creating a grayscale high-pass image.
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

        // The gradient_Click event handler is triggered
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
            // Calculate the radius of the filter (half of the filter size).
            int filterRadius = filterSize / 2;

            // Initialize variables to accumulate the total color channel values within the neighborhood.
            int totalR = 0, totalG = 0, totalB = 0;

            // Calculate the divisor, which represents the number of pixels in the neighborhood.
            int divisor = filterSize * filterSize;

            // Iterate through the pixels within the neighborhood.
            for (int i = -filterRadius; i <= filterRadius; i++)
            {
                for (int j = -filterRadius; j <= filterRadius; j++)
                {
                    int pixelX = x + i;
                    int pixelY = y + j;

                    // Check if the pixel is within the bounds of the image.
                    if (pixelX >= 0 && pixelX < image.Width && pixelY >= 0 && pixelY < image.Height)
                    {
                        // Get the color of the current pixel.
                        Color pixelColor = image.GetPixel(pixelX, pixelY);

                        // Accumulate the color channel values.
                        totalR += pixelColor.R;
                        totalG += pixelColor.G;
                        totalB += pixelColor.B;
                    }
                }
            }

            // Calculate the averaged color by dividing the accumulated channel values by the divisor.
            byte averagedR = (byte)(totalR / divisor);
            byte averagedG = (byte)(totalG / divisor);
            byte averagedB = (byte)(totalB / divisor);

            // Return the averaged color as a Color object.
            return Color.FromArgb(averagedR, averagedG, averagedB);
        }

        // Apply the median filter to a specific pixel in the image
        private Bitmap ApplyMedianFilter(Bitmap image, int filterSize)
        {
            // Create a new Bitmap to store the filtered image with the same dimensions as the input image.
            Bitmap filteredImage = new Bitmap(image.Width, image.Height);

            // Iterate through each pixel in the input image.
            for (int x = 0; x < image.Width; x++)
            {
                for (int y = 0; y < image.Height; y++)
                {
                    // Calculate the median color for the current pixel using the specified filter size.
                    Color medianColor = CalculateMedianColor(image, x, y, filterSize);

                    // Set the corresponding pixel in the filtered image to the calculated median color.
                    filteredImage.SetPixel(x, y, medianColor);
                }
            }

            // Return the filtered image as a new Bitmap.
            return filteredImage;
        }

        // Calculate the median color for a specific pixel in the image
        private Color CalculateMedianColor(Bitmap image, int x, int y, int filterSize)
        {
            // Calculate the radius of the filter (half of the filter size).
            int filterRadius = filterSize / 2;

            // Initialize lists to store color channel values from the neighborhood.
            List<byte> redValues = new List<byte>();
            List<byte> greenValues = new List<byte>();
            List<byte> blueValues = new List<byte>();

            // Iterate through the pixels within the neighborhood.
            for (int i = -filterRadius; i <= filterRadius; i++)
            {
                for (int j = -filterRadius; j <= filterRadius; j++)
                {
                    int pixelX = x + i;
                    int pixelY = y + j;

                    // Check if the pixel is within the bounds of the image.
                    if (pixelX >= 0 && pixelX < image.Width && pixelY >= 0 && pixelY < image.Height)
                    {
                        // Get the color of the current pixel in the neighborhood.
                        Color pixelColor = image.GetPixel(pixelX, pixelY);

                        // Store the color channel values (R, G, and B) from the current pixel.
                        redValues.Add(pixelColor.R);
                        greenValues.Add(pixelColor.G);
                        blueValues.Add(pixelColor.B);
                    }
                }
            }

            // Calculate the median value for each color channel.
            byte medianR = GetMedianValue(redValues);
            byte medianG = GetMedianValue(greenValues);
            byte medianB = GetMedianValue(blueValues);

            // Return the computed median color as a Color object.
            return Color.FromArgb(medianR, medianG, medianB);
        }

        // GetMedianValue method calculates the median value from a list of byte values.
        // It sorts the values and returns the value at the middle position.
        // Note: The list is assumed to be pre-sorted before calling this method.
        private byte GetMedianValue(List<byte> values)
        {
            // Sort the list of values in ascending order.
            values.Sort();

            // Calculate the index of the middle value in the sorted list.
            int middle = values.Count / 2;

            // Return the value at the middle position, which is the median value.
            return values[middle];
        }

        // Apply the Laplacian filter to an image
        private Bitmap ApplyLaplacianFilter(Bitmap image)
        {
            // Create a new Bitmap to store the filtered image with the same dimensions as the input image.
            Bitmap filteredImage = new Bitmap(image.Width, image.Height);

            // Define the Laplacian kernel used for filtering.
            int[,] laplacianKernel = {
                { -1, -1, -1 },
                { -1,  8, -1 },
                { -1, -1, -1 }
            };

            int kernelSize = 3;
            int kernelOffset = kernelSize / 2;

            // Iterate through each pixel in the input image.
            for (int x = 0; x < image.Width; x++)
            {
                for (int y = 0; y < image.Height; y++)
                {
                    int sumR = 0, sumG = 0, sumB = 0;

                    // Apply the Laplacian kernel to the neighborhood of the current pixel.
                    for (int i = -kernelOffset; i <= kernelOffset; i++)
                    {
                        for (int j = -kernelOffset; j <= kernelOffset; j++)
                        {
                            int pixelX = x + i;
                            int pixelY = y + j;

                            // Check if the pixel is within the bounds of the image.
                            if (pixelX >= 0 && pixelX < image.Width && pixelY >= 0 && pixelY < image.Height)
                            {
                                Color pixelColor = image.GetPixel(pixelX, pixelY);
                                int kernelValue = laplacianKernel[i + kernelOffset, j + kernelOffset];

                                // Apply the kernel value to the color channels and accumulate the results.
                                sumR += pixelColor.R * kernelValue;
                                sumG += pixelColor.G * kernelValue;
                                sumB += pixelColor.B * kernelValue;
                            }
                        }
                    }

                    // Ensure that color channel values are within the valid range [0, 255].
                    sumR = Math.Max(0, Math.Min(255, sumR));
                    sumG = Math.Max(0, Math.Min(255, sumG));
                    sumB = Math.Max(0, Math.Min(255, sumB));

                    // Create a new color using the filtered channel values.
                    Color filteredColor = Color.FromArgb(sumR, sumG, sumB);

                    // Set the corresponding pixel in the filtered image to the filtered color.
                    filteredImage.SetPixel(x, y, filteredColor);
                }
            }

            // Return the filtered image as a new Bitmap.
            return filteredImage;
        }

        // ApplySobelOperator method calculates the gradient in the X and Y directions and the gradient magnitude of the input image using the Sobel operator.
        // It stores the results in three separate Bitmaps (gradientXImage, gradientYImage, and gradientMagnitudeImage).
        private void ApplySobelOperator(Bitmap image, out Bitmap gradientXImage, out Bitmap gradientYImage, out Bitmap gradientMagnitudeImage)
        {
            // Create new Bitmaps to store the gradient images and the gradient magnitude image with the same dimensions as the input image.
            gradientXImage = new Bitmap(image.Width, image.Height);
            gradientYImage = new Bitmap(image.Width, image.Height);
            gradientMagnitudeImage = new Bitmap(image.Width, image.Height);

            // Define Sobel kernels for gradient calculation in the X and Y directions.
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

            // Iterate through the pixels in the interior of the image (excluding the border pixels).
            for (int x = 1; x < width - 1; x++)
            {
                for (int y = 1; y < height - 1; y++)
                {
                    int gradientX = 0;
                    int gradientY = 0;

                    // Apply the Sobel kernels to calculate gradients in the X and Y directions for the current pixel.
                    for (int i = -1; i <= 1; i++)
                    {
                        for (int j = -1; j <= 1; j++)
                        {
                            Color pixelColor = image.GetPixel(x + i, y + j);
                            // Convert the color to grayscale using luminance values.
                            int grayValue = (int)(0.299 * pixelColor.R + 0.587 * pixelColor.G + 0.114 * pixelColor.B);

                            gradientX += sobelX[i + 1, j + 1] * grayValue;
                            gradientY += sobelY[i + 1, j + 1] * grayValue;
                        }
                    }

                    // Ensure that the calculated gradients are within the valid range [0, 255].
                    int normalizedGradientX = Math.Max(0, Math.Min(255, gradientX));
                    int normalizedGradientY = Math.Max(0, Math.Min(255, gradientY));

                    // Set the corresponding pixels in the gradient images to the normalized gradient values.
                    gradientXImage.SetPixel(x, y, Color.FromArgb(normalizedGradientX, normalizedGradientX, normalizedGradientX));
                    gradientYImage.SetPixel(x, y, Color.FromArgb(normalizedGradientY, normalizedGradientY, normalizedGradientY));

                    // Calculate the gradient magnitude and ensure it is within the valid range.
                    int magnitude = (int)Math.Sqrt(gradientX * gradientX + gradientY * gradientY);
                    magnitude = Math.Max(0, Math.Min(255, magnitude));

                    // Set the corresponding pixel in the gradient magnitude image to the calculated magnitude.
                    gradientMagnitudeImage.SetPixel(x, y, Color.FromArgb(magnitude, magnitude, magnitude));
                }
            }
        }

    }
}
