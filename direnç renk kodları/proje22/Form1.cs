using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proje22
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if (trackBar1.Value == 0)
            {
                tabPage1.BackColor = Color.Black;
            }
            else if(trackBar1.Value==1)
            {
                tabPage1.BackColor = Color.Sienna;
            }
            else if (trackBar1.Value == 2)
            {
                tabPage1.BackColor = Color.Red;
            }
            else if(trackBar1.Value==3)
            {
                tabPage1.BackColor = Color.Orange;
            }
            else if(trackBar1.Value==4)
            {
                tabPage1.BackColor = Color.Yellow;
            }
            else if(trackBar1.Value==5)
            {
                tabPage1.BackColor = Color.Green;
            }
            else if(trackBar1.Value==6)
            {
                tabPage1.BackColor = Color.Blue;
            }
            else  if(trackBar1.Value==7)
            {
                tabPage1.BackColor = Color.Purple;
            }
            else if(trackBar1.Value==8)
            {
                tabPage1.BackColor = Color.Gray;
            }
            else if(trackBar1.Value==9)
            {
                tabPage1.BackColor = Color.White;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          tabPage1.BackColor = Color.Black;
            
        }
        public double tolerans()
        {
            double deger = 0;

            if(trackBar5.Value==0)
            {
              deger = 1;
            }

            if (trackBar5.Value == 1)
            {
                deger = 2;
            }

            if (trackBar5.Value == 2)
            {
                deger = 3;
            }

            if (trackBar5.Value == 3)
            {
                deger = 4;
            }

            if (trackBar5.Value == 4)
            {
                deger = 0.5;
            }

            if (trackBar5.Value == 5)
            {
                deger = 0.25;
            }

            if (trackBar5.Value == 6)
            {
                deger = 0.10;
            }

            if (trackBar5.Value == 7)
            {
                deger = 0.05;
            }
            if (trackBar5.Value == 8)
            {
                deger = 5;
            }
            if (trackBar5.Value == 9)
            {
                deger = 10;
            }
            if (trackBar5.Value == 10)
            {
                deger = 20;
            }

            return deger;
        }

        public double tolerans1()
        {
            double deger = 0;

            if (trackBar10.Value == 0)
            {
                deger = 1;
            }

            if (trackBar10.Value == 1)
            {
                deger = 2;
            }

            if (trackBar10.Value == 2)
            {
                deger = 3;
            }

            if (trackBar10.Value == 3)
            {
                deger = 4;
            }

            if (trackBar10.Value == 4)
            {
                deger = 0.5;
            }

            if (trackBar10.Value == 5)
            {
                deger = 0.25;
            }

            if (trackBar10.Value == 6)
            {
                deger = 0.10;
            }

            if (trackBar10.Value == 7)
            {
                deger = 0.05;
            }
            if (trackBar10.Value == 8)
            {
                deger = 5;
            }
            if (trackBar10.Value == 9)
            {
                deger = 10;
            }
            if (trackBar10.Value == 10)
            {
                deger = 20;
            }

            return deger;
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            double fonk = tolerans();
            double sonuc = ((trackBar2.Value * 10 + trackBar3.Value) * Math.Pow(10, trackBar4.Value)) * Math.Pow(10, -6);
            label5.Text = sonuc.ToString() + " M ohm";
            double a= sonuc * fonk/100;
            double b = a + sonuc;
            double c = sonuc - a;
            label6.Text = b.ToString()+" M ohm";
            label7.Text = c.ToString()+" M ohm"; 
        }

        private void button94_Click(object sender, EventArgs e)
        {
            double fonk = tolerans1();
            double sonuc = ((trackBar6.Value * 100 + trackBar7.Value * 10 + trackBar8.Value) * Math.Pow(10, trackBar9.Value)) * Math.Pow(10 ,- 6);
            label19.Text = sonuc.ToString() + " M ohm";
            double a = sonuc * fonk / 100;
            double b = a + sonuc;
            double c = sonuc - a;
            label18.Text = b.ToString() + " M ohm";
            label17.Text = c.ToString() + " M ohm";
        }
    }

}
