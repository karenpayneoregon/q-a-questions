using System;
using System.IO;
using System.Windows.Forms;
using GetImageFromSqlServerFormApp.Classes;

namespace GetImageFromSqlServerFormApp
{
    public partial class VarForm : Form
    {
        private readonly PhotoContainer _photoContainer;

        public VarForm()
        {
            InitializeComponent();

            // hard coded do same for OpenFileDialog
            _photoContainer = new PhotoContainer()
            {
                FileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Bootstrap.png"),
                Picture = ImageHelpers.ByteArrayToImage(File.ReadAllBytes("Bootstrap.png"))
            };

            pictureBox2.Image = _photoContainer.Picture;

        }

        private void InsertImageButton_Click(object sender, EventArgs e)
        {
            // hard coded do same for OpenFileDialog
            PhotoOperations.InsertImage(File.ReadAllBytes("bag.png"));
        }

        private void ReadButton_Click(object sender, EventArgs e)
        {
            PhotoContainer container = PhotoOperations.ReadImage(1);
            pictureBox1.Image = container.Picture;
        }

        private void InsertFromPictureBoxButton_Click(object sender, EventArgs e)
        {
            var picture = ImageHelpers.ImageToByte(pictureBox2.Image);
            PhotoOperations.InsertImage(picture);
        }

        private void PeekButton_Click(object sender, EventArgs e)
        {
            var fileName = _photoContainer.FileName;
            Console.WriteLine(fileName);
        }

        private void TruncateButton_Click(object sender, EventArgs e)
        {
            PhotoOperations.TruncateTable();
        }
    }
}
