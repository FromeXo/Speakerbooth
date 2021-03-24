using System.Drawing;
using System.Windows.Forms;

namespace Speakerbooth
{
    public partial class ImageViewer : Form
    {
        public ImageViewer()
        {
            InitializeComponent();
            ImageBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        public void SetImage(string imagePath)
        {
            if ( imagePath.Length == 0 ) return;

            Bitmap cardImage = new Bitmap(imagePath);
            ImageBox.Image = (Image) cardImage;
        }

        public void HideImage()
        {
            ImageBox.Visible = false;
        }

    }
}
