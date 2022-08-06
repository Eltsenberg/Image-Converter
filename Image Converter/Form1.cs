using System.Drawing.Imaging;

namespace Image_Converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void OpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new()
            {
                Filter = "Image Files(*.BMP;*.JPG;*.PNG)|*.BMP;*.JPG;*.PNG|All files (*.*)|*.*"
            };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    PictureBox.Image = new Bitmap(ofd.FileName);
                }
                catch
                {
                    MessageBox.Show("The selected file cannot be opened!");
                }
            }
        }
        private void ConversionFile_Click(object sender, EventArgs e)
        {
            PictureBox.Image = Conversion(PictureBox.Image);
        }
        private void SaveFile_Click(object sender, EventArgs e)
        {
            if (PictureBox.Image != null)
            {
                SaveFileDialog sfd = new()
                {
                    Title = "Save image as",
                    OverwritePrompt = true,
                    CheckPathExists = true,
                    Filter = "Image File(PNG)|*.PNG;|Image File(JPG)|*.JPG;|Image File(BMP)|*.BMP;",
                    ShowHelp = true
                };
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        PictureBox.Image.Save(sfd.FileName);
                    }
                    catch
                    {
                        ErrorBox.Text = "Unable to save image!";
                    }
                }
            }
            else
            {
                ErrorBox.Text = "Nothing to save!";
            }
        }
        private void CleanPBox_Click(object sender, EventArgs e)
        {
            if (PictureBox.Image != null)
            {
                PictureBox.Image = null;
            }
            else
            {
                ErrorBox.Text = "Nothing to to clean up!";
            }
        }
        public Bitmap Conversion(Image image)
        {
            Bitmap? bmp = new(image.Width, image.Height);

            using (Graphics g = Graphics.FromImage(bmp))
            {

                ColorMatrix colorMatrixElements = new(
                   new float[][]
                   {
                    new float[] {.3f, .3f, .3f, 0, 0},
                    new float[] {.59f, .59f, .59f, 0, 0},
                    new float[] {.11f, .11f, .11f, 0, 0},
                    new float[] {0, 0, 0, 1, 0},
                    new float[] {0, 0, 0, 0, 1}
                   });

                using ImageAttributes imageAttributes = new();

                imageAttributes.SetColorMatrix(colorMatrixElements);

                g.DrawImage(image, new Rectangle(0, 0, image.Width, image.Height),
                            0, 0, image.Width, image.Height, GraphicsUnit.Pixel, imageAttributes);
            }
            ErrorBox.Text = "Finished!";
            return bmp;
        }

        private void CleanTextBox_Click(object sender, EventArgs e)
        {
            ErrorBox.Clear();
        }
    }
}