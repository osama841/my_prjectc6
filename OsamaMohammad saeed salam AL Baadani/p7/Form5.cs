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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            // إعداد المؤقت ليعمل كل ثانية
            timer1.Interval = 1000; // 1000ms = 1s
            timer1.Start(); // بدء المؤقت
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // إيقاف المؤقت
            timer1.Stop();
        }

        // تعريف المتغيرات لحساب الثواني، الدقائق، الساعات، والأيام
        int s = 0, m = 0, h = 0, y = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            // زيادة الثواني
            s++;
            //timer1.Interval = 10;
          
            if (s >= 10)
                label1.Text = s.ToString();
            else
                label1.Text = "0" + s.ToString(); 

            // إذا تجاوزت الثواني 59، قم بتصفيتها وزيادة الدقائق
            if (s > 59)
            {
                s = 0;  // تصفير الثواني
                //timer1.Interval = 4;
                m++;   // زيادة الدقائق

                // تحديث عرض الدقائق على الـ label2
                if (m >= 10)
                    label6.Text = m.ToString();
                else
                    label6.Text = "0" + m.ToString(); // إضافة صفر قبل الأرقام الأقل من 10
            }

            // إذا تجاوزت الدقائق 59، قم بتصفيتها وزيادة الساعات
            if (m > 59)
            {
                m = 0; // تصفير الدقائق
                h++;   // زيادة الساعات

                // تحديث عرض الساعات على الـ label3
                if (h >= 10)
                    label4.Text = h.ToString();
                else
                    label4.Text = "0" + h.ToString(); // إضافة صفر قبل الأرقام الأقل من 10
            }

            // إذا تجاوزت الساعات 12 (نظام 12 ساعة)، قم بتصفيتها وزيادة الأيام
            if (h >= 12)
            {
                h = 0; // تصفير الساعات
                y++;   // زيادة الأيام

                // تحديث عرض الأيام على الـ label4
                label8.Text = y.ToString();
            }
        }
    }
}
