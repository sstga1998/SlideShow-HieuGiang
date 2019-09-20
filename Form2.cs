using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private int imageNumber = 1, img1,img2, img3, img4, img5, img6, img7;

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void ListBox1_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {
            imageNumber++;
            if (imageNumber == 11)
            {
                imageNumber = 1;
            }
            LoadNextImage();
        }

        private void Label1_Click(object sender, EventArgs e)
        {
            imageNumber--;
            if (imageNumber == 0)
            {
                imageNumber = 10;
            }
            LoadNextImage();
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void LoadNextImage()
        {
            if (imageNumber == 10)
            {
                imageNumber = 1;
            }
            slidePic.ImageLocation = string.Format(@"Img/{0}.jpg", imageNumber);

            if (imageNumber == 1) img1 = 8;
            else if (imageNumber == 2) img1 = 9;
            else if (imageNumber == 3) img1 = 10;
            else img1 = imageNumber - 3;
            pictureBox1.ImageLocation = string.Format(@"Img\{0}.jpg", img1);

            if (imageNumber == 1) img2 = 9;
            else if (imageNumber == 2) img2 = 10;
            else img2 = imageNumber - 2;
            pictureBox2.ImageLocation = string.Format(@"Img\{0}.jpg", img2);

            if (imageNumber == 1) img3 = 10;
            else img3 = imageNumber - 1;
            pictureBox3.ImageLocation = string.Format(@"Img\{0}.jpg", img3);

            img4 = imageNumber;
            pictureBox4.ImageLocation = string.Format(@"Img\{0}.jpg", img4);

            if (imageNumber == 10) img5 = 1;
            else img5 = imageNumber + 1;
            pictureBox5.ImageLocation = string.Format(@"Img\{0}.jpg", img5);

            if (imageNumber == 10) img6 = 2;
            else if (imageNumber == 9) img6 = 1;
            else img6 = imageNumber + 2;
            pictureBox6.ImageLocation = string.Format(@"Img\{0}.jpg", img6);

            if (imageNumber == 10) img7 = 3;
            else if (imageNumber == 9) img7 = 2;
            else if (imageNumber == 8) img7 = 1;
            else img7 = imageNumber + 3;
            pictureBox7.ImageLocation = string.Format(@"Img\{0}.jpg", img7);

            imageNumber++;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            LoadNextImage();
        }
    }
}
