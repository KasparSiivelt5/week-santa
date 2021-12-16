using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Santa_claus
{
    public partial class Form1 : Form
    {
        int gravity = 10;
        int snowspeed = 6;
        int treespeed = 6;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {

        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            Santa.Top += gravity;
            Snow.Left -= snowspeed;
            Tree.Left -= treespeed;
            if (Snow.Left < -100)
            {
                Snow.Left = 500;
            }
            if (Tree.Left < -100)
            {
                Tree.Left = 600;
            }
        
        
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)

       
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -5;
            }
        
        
        
        
        
        }
        
        private void Form1_KeyUp(object sender, KeyEventArgs e)

        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 5;          
            }

            if(Santa.Bounds.IntersectsWith         )
            {

            }


        
        
        }
    }
}
