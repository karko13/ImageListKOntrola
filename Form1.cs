using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageListKomponenta1
{
    public partial class Form1 : Form
    {
        int brojac = 0;
        public Form1()
        {
            InitializeComponent();
            pictureBox1.Image = Lista.Images[0];
        }
        private void gumb_Click(object sender, EventArgs e)
        {
            brojac++;
            if(brojac == 2)
            {
                pictureBox1.Image = Lista.Images[0];
            }
            else
            {
                pictureBox1.Image = Lista.Images[1];
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
