using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Turnuri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            int i, x1, y1, w, h;
            System.Drawing.Graphics Desen;
            System.Drawing.SolidBrush Pens_g, Pens_w;
            System.Drawing.Pen Creion_g;
            Desen = this.CreateGraphics();
            Pens_g = new System.Drawing.SolidBrush(System.Drawing.Color.LightGray);
            Pens_w = new System.Drawing.SolidBrush(System.Drawing.Color.WhiteSmoke);
            Creion_g = new System.Drawing.Pen(System.Drawing.Color.Gray, 3);
            System.Random n = new System.Random();
            Desen.Clear(this.BackColor);
            i = 0;
            while (i <= 50)
            {
                x1 = n.Next(this.Width);
                y1 = n.Next(this.Height);
                w = n.Next(75);
                h = this.Height - y1;
                if (i % 2 == 0)
                {
                    Desen.DrawRectangle(Creion_g, x1, y1, w, h);
                    Desen.FillRectangle(Pens_g, x1 + 1, y1 + 1, w - 1, h - 1);
                }
                else
                {
                    Desen.DrawRectangle(Creion_g, x1, y1, w, h);
                    Desen.FillRectangle(Pens_w, x1 + 1, y1 + 1, w - 1, h - 1);
                }
                i++;
            }
        }
    }
}
