using System.Windows.Forms;

namespace Image_Processing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ViewImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.ico;*.tiff|All Files|*.*";
                openFileDialog.FilterIndex = 1;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedFilePath = openFileDialog.FileName;

                    try
                    {
                        // Load the image and display it in the PictureBox control
                        using (FileStream fileStream = new FileStream(selectedFilePath, FileMode.Open))
                        {
                            ViewImage.Image = Image.FromStream(fileStream);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error loading the image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        static void RunLength_PCX(string inputFilePath)
        {
            byte[] PCX_data = File.ReadAllBytes(inputFilePath);

            try
            {

            }

            catch (Exception ex)
            {

            }
        }

        private void ViewPCX_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog_1 = new OpenFileDialog())
            {
                openFileDialog_1.Filter = "PCX Files | *.pcx";
                openFileDialog_1.FilterIndex = 1;

                if (openFileDialog_1.ShowDialog() == DialogResult.OK)
                {
                    string selectedFilePath = openFileDialog_1.FileName;



                }
            }
        }
    }
}