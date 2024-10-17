using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p7
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
              
   
        private void button2_Click_1(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "JPEG Picture{*.jpg}|*.jpg";
            openFileDialog1.Filter = "Picture {*.jpg;*.png}|*.jpg;*.png";
            openFileDialog1.Filter = "Picture {*.jpg;*.png}|*.jpg;*.png;|bmp Picture{*.bmp}|*.bmp";
            if (openFileDialog1.ShowDialog() ==DialogResult.OK )
            {
                string filname = openFileDialog1.FileName;
                Bitmap mybitmap = new Bitmap(filname);
                pictureBox1.Image = mybitmap;
                System.Drawing.Image.FromFile(openFileDialog1.FileName);
            }

            //pictureBox1.Width = pictureBox1.Height = 300;
            this.AutoSize = true;  
      
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
