using System;
using System.Drawing;
using System.Windows.Forms;

namespace Speakerbooth
{
    public partial class ImageViewer : Form
    {

        string CurrentImage;

        public ImageViewer()
        {
            InitializeComponent();
            BackColor = Color.FromArgb(0, 255, 0);
            ImageBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        public void SetImage(string imagePath)
        {
            if ( imagePath.Length == 0 || imagePath == CurrentImage ) return;
            
            if (ImageBox.Image != null ) {
                ImageBox.Image.Dispose();
            }

            CurrentImage = imagePath;
            ImageBox.Image = (Image) new Bitmap(imagePath);
            
        }

        public void ToggleImage()
        {
            ImageBox.Visible = !ImageBox.Visible;
        }

        private void ImageViewer_FormClosing(object sender, FormClosingEventArgs e)
        {
            ImageBox.Dispose();
            Dispose();
        }
    }
}
