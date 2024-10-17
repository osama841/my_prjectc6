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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //openFileDialog1.Filter = "JPEG Picture{*.jpg}|*.jpg";
            //openFileDialog1.Filter = "Picture {*.jpg;*.png}|*.jpg;*.png";
            //openFileDialog1.Filter = "Picture {*.jpg;*.png}|*.jpg;*.png;|bmp Picture{*.bmp}|*.bmp";
      
            pictureBox1.Width = pictureBox1.Height = 300;
            this.AutoSize = true;  
      
              pictureBox1.Image =Image.FromFile(@textBox1.Text.Trim());
              toolTip1.SetToolTip(pictureBox1, "pictureBox1");
              pictureBox1.BackgroundImage = Image.FromFile(@"C:\Users\Osama\Desktop\quiz11\imgs1.jpg");
        }

        private void Form2_Load(object sender, EventArgs e)
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
            colorDialog1.Color = this.BackColor;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = colorDialog1.Color;
            }
        }
    }
}
