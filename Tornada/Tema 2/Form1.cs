using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Tema_2
{
    public partial class Form1 : Form
    {
        System.Drawing.Graphics Desen;
        System.Drawing.Pen Creion_rosu;

        public Form1()
        {
            InitializeComponent();
            Desen = this.CreateGraphics();
            Creion_rosu = new System.Drawing.Pen(System.Drawing.Color.Red);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            deseneaza();
        }
        void deseneaza()
        {
            int i;
            for (i = 0; i <= 75; i+=5)
            {
                Desen.DrawEllipse(Creion_rosu, 200 - i, 200 - 2 * i, 50 + 2 * i, 10 + 2 * i);
            }
        }

    }
}
