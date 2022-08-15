using System;
using System.Windows.Forms;
using ChangeImage.Classes;
using ChangeImage.Extensions;

namespace ChangeImage
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            
            Shown += OnShown;
        }

        private void OnShown(object? sender, EventArgs e)
        {
            var allImages = ResourceImages.Instance.Images();
            
            /*
             * Do we have images from resources?
             */
            if (allImages is null)
            {
                MessageBox.Show("No images located");
                SelectFromAllImagesButton.Enabled = false;
            }
            
            AllImagesListBox.DataSource = allImages;

            ChangeFromAllImage();

            IconListBox.DataSource = allImages.Icons();

            BitmapListBox.DataSource = allImages.BitMaps();
        }

        private void SelectFromAllImagesButton_Click(object sender, EventArgs e)
        {
            ChangeFromAllImage();
        }

        private void ChangeFromAllImage()
        {
            if (AllImagesListBox.SelectedIndex <= -1) return;

            var item = (ResourceItem) AllImagesListBox.SelectedItem;
            pictureBox1.SizeMode = item.IsIcon ? PictureBoxSizeMode.Normal : PictureBoxSizeMode.Zoom;
            pictureBox1.Image = item.Image;
        }

        private void button1_Click(object sender, EventArgs e)
        {
             ResourceHelpers.Test();
        }
    }
}
