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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Size = new Size(200, 200);
            Bitmap mybtmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            int x, y;
            // رسم خط قطري
            //for (x = 0; x < 100; x++)
            //{
            //    y = x;
            //    mybtmp.SetPixel(x, y, Color.Red); // رسم نقطة باللون الأحمر على الخط القطري
            //}
            //int x, y;

            for (x = 10; x < 180; x++)
            {
                for (y = 10; y <180; y++)
                {
                    if (x == 10 || x == mybtmp.Width - 22 || y == 10 || y == mybtmp.Height - 22)
                    {
                        mybtmp.SetPixel(x, y, Color.Black);
                    }             
                }
            }
            pictureBox1.Image = mybtmp;
            this.CreateGraphics().DrawImage(mybtmp, 0, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }
          
        private void Form4_Load(object sender, EventArgs e)
        {
            
        }

     
    }
}
