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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {      
            pictureBox1.Width=pictureBox1.Height=300;
            //pictureBox1.BackColor = Color.Red;
            pictureBox1.Image = Image.FromFile(@"E:\blototh\IMG_٢٠٢٢١١١٨_٢٢١٨٥١.jpg");
            pictureBox1.BackgroundImage = Image.FromFile(@"C:\Users\Osama\Desktop\quiz11\imgs1.jpg");
            toolTip1.SetToolTip(pictureBox1, "pictureBox1");
            this.AutoSize = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
        }       
        }
    }

