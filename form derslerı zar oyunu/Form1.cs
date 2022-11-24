using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form_derslerı_zar_oyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rndm = new Random();
        int total = 0;
        int TotalYou = 0;
        int TotalMy = 0;
        

        private void button1_Click(object sender, EventArgs e)
        {
            int a = rndm.Next(0, 7);
            int b = rndm.Next(0, 7);

            label4.Text = a.ToString();
            label3.Text = b.ToString();

            total = a + b;
            label7.Text = total.ToString();

            TotalMy = TotalMy + a + b;
            label16.Text = TotalMy.ToString();
            if (a == 1)
            {
                pictureBox1.ImageLocation="C:\\Users\\yilma\\Desktop\\1.png";
            }
            if (a == 2)
            {
                pictureBox1.ImageLocation = "C:\\Users\\yilma\\Desktop\\22.png";
            }
            if (a == 3)
            {
                pictureBox1.ImageLocation = "C:\\Users\\yilma\\Desktop\\3.png";
            }
            if (a == 4)
            {
                pictureBox1.ImageLocation = "C:\\Users\\yilma\\Desktop\\zar4.png";
            }
            if (a == 5)
            {
                pictureBox1.ImageLocation = "C:\\Users\\yilma\\Desktop\\5.png";
            }
            if (a == 6)
            {
                pictureBox1.ImageLocation = "C:\\Users\\yilma\\Desktop\\6.png";

            }
            if (b  == 1)
            {
                pictureBox2.ImageLocation = "C:\\Users\\yilma\\Desktop\\1.png";
            }
            if (b == 2)
            {
                pictureBox2.ImageLocation = "C:\\Users\\yilma\\Desktop\\22.png";
            }
            if (b == 3)
            {
                pictureBox2.ImageLocation = "C:\\Users\\yilma\\Desktop\\3.png";
            }
            if (b == 4)
            {
                pictureBox2.ImageLocation = "C:\\Users\\yilma\\Desktop\\zar4.png";
            }
            if (b== 5)
            {
                pictureBox2.ImageLocation = "C:\\Users\\yilma\\Desktop\\5.png";
            }
            if (b  == 6)
            {
                pictureBox2.ImageLocation = "C:\\Users\\yilma\\Desktop\\6.png";

            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            int c = rndm.Next(0, 7);
            int d = rndm.Next(0, 7);

            label9.Text = c.ToString();
            label10.Text = d.ToString();

            total = c + d;
            label5.Text = total.ToString();

            TotalYou = TotalYou + c + d;
            label15.Text = TotalYou.ToString();
            if (c  == 1)
            {
                pictureBox1.ImageLocation = "C:\\Users\\yilma\\Desktop\\1.png";
            }
            if (c  == 2)
            {
                pictureBox1.ImageLocation = "C:\\Users\\yilma\\Desktop\\22.png";
            }
            if (c == 3)
            {
                pictureBox1.ImageLocation = "C:\\Users\\yilma\\Desktop\\3.png";
            }
            if (c  == 4)
            {
                pictureBox1.ImageLocation = "C:\\Users\\yilma\\Desktop\\zar4.png";
            }
            if (c  == 5)
            {
                pictureBox1.ImageLocation = "C:\\Users\\yilma\\Desktop\\5.png";
            }
            if (c  == 6)
            {
                pictureBox1.ImageLocation = "C:\\Users\\yilma\\Desktop\\6.png";

            }
            if (d  == 1)
            {
                pictureBox2.ImageLocation = "C:\\Users\\yilma\\Desktop\\1.png";
            }
            if (d  == 2)
            {
                pictureBox2.ImageLocation = "C:\\Users\\yilma\\Desktop\\22.png";
            }
            if (d == 3) 
            {
                pictureBox2.ImageLocation = "C:\\Users\\yilma\\Desktop\\3.png";
            }
            if (d == 4) 
            {
                pictureBox2.ImageLocation = "C:\\Users\\yilma\\Desktop\\zar4.png";
            }
            if (d == 5) 
            {
                pictureBox2.ImageLocation = "C:\\Users\\yilma\\Desktop\\5.png";
            }
            if (d == 6) 
            {
                pictureBox2.ImageLocation = "C:\\Users\\yilma\\Desktop\\6.png";

            }





        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
