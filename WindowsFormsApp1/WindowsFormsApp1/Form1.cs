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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public Bitmap bmp;
        public Graphics g;
        int x = 1;
        int y = 1;
        private void Form1_Load(object sender, EventArgs e)
        {
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(bmp);
            pictureBox1.Image = bmp;
            pictureBox1.Invalidate();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            x++;

            if(x > 50)
            {
                g.Clear(Color.White);
                g.DrawLine(Pens.Black, 20 + x, 270 + y, 20 + x, 300 + y);
                g.DrawLine(Pens.Black, 20 + x, 300 + y, 150 + x, 300 + y);
                g.DrawLine(Pens.Black, 150 + x, 300 + y, 180 + x, 260 + y);
                g.DrawLine(Pens.Black, 120 + x, 260 + y, 180 + x, 260 + y);
                g.DrawLine(Pens.Black, 110 + x, 270 + y, 120 + x, 260 + y);
                g.DrawLine(Pens.Black, 20 + x, 270 + y, 110 + x, 270 + y);
                g.DrawLine(Pens.Black, 150 + x, 250 + y, 150 + x, 260 +y);
                g.DrawLine(Pens.Black, 50 + x, 250 + y, 150 + x, 250 + y);
                g.DrawLine(Pens.Black, 50 + x, 260 + y, 50 + x, 250 + y);
                g.DrawLine(Pens.Black, 40 + x, 270 + y, 50 + x, 260 + y);
                g.DrawLine(Pens.Black, 60 + x, 260 + y, 100 + x, 260 + y);
                g.DrawLine(Pens.Black, 90 + x, 240 + y, 120 + x, 240 + y);
                g.DrawLine(Pens.Black, 120 + x, 250 + y, 120 + x, 240 + y);
                g.DrawLine(Pens.Black, 90 + x, 250 + y, 90 + x, 240 + y);
                g.DrawLine(Pens.Black, 90 + x, 240 + y, 90 + x, 220 + y);
                g.DrawLine(Pens.Black, 80 + x, 220 + y, 90 + x, 220 + y);
                g.DrawLine(Pens.Black, 80 + x, 220 + y, 80 + x, 250 + y);
                g.DrawLine(Pens.Black, 110 + x, 240 + y, 110 + x, 200 + y);
                g.DrawLine(Pens.Black, 180 + x, 260 + y, 110 + x, 190 + y);
                g.DrawLine(Pens.Black, 20 + x, 270 + y, 110 + x, 190 + y);


                // разрушения
                g.DrawLine(Pens.Black, 90 + x, 270 + y, 130 + x, 280 + y);
                g.DrawLine(Pens.Black, 130 + x, 280 + y, 100 + x, 290 + y);
                g.DrawLine(Pens.Black, 100 + x, 290 + y, 125 + x, 300 + y);

                y++;
            }
            else
            {
                g.Clear(Color.White);
                g.DrawLine(Pens.Black, 20 + x, 270, 20 + x, 300);
                g.DrawLine(Pens.Black, 20 + x, 300, 150 + x, 300);
                g.DrawLine(Pens.Black, 150 + x, 300, 180 + x, 260);
                g.DrawLine(Pens.Black, 120 + x, 260, 180 + x, 260);
                g.DrawLine(Pens.Black, 110 + x, 270, 120 + x, 260);
                g.DrawLine(Pens.Black, 20 + x, 270, 110 + x, 270);
                g.DrawLine(Pens.Black, 150 + x, 250, 150 + x, 260);
                g.DrawLine(Pens.Black, 50 + x, 250, 150 + x, 250);
                g.DrawLine(Pens.Black, 50 + x, 260, 50 + x, 250);
                g.DrawLine(Pens.Black, 40 + x, 270, 50 + x, 260);
                g.DrawLine(Pens.Black, 60 + x, 260, 100 + x, 260);
                g.DrawLine(Pens.Black, 90 + x, 240, 120 + x, 240);
                g.DrawLine(Pens.Black, 120 + x, 250, 120 + x, 240);
                g.DrawLine(Pens.Black, 90 + x, 250, 90 + x, 240);
                g.DrawLine(Pens.Black, 90 + x, 240, 90 + x, 220);
                g.DrawLine(Pens.Black, 80 + x, 220, 90 + x, 220);
                g.DrawLine(Pens.Black, 80 + x, 220, 80 + x, 250);
                g.DrawLine(Pens.Black, 110 + x, 240, 110 + x, 200);
                g.DrawLine(Pens.Black, 180 + x, 260, 110 + x, 190);
                g.DrawLine(Pens.Black, 20 + x, 270, 110 + x, 190);
            }
            pictureBox1.Invalidate();
        }
    }
}