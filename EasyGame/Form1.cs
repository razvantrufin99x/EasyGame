using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EasyGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Text = e.KeyChar.ToString();

            if (e.KeyChar == 'W' || e.KeyChar == 'w' )
            {
                if (PLAYER.Top > 40)
                {
                    PLAYER.Top -= 40;
                }
            }
            else if (e.KeyChar == 'A' || e.KeyChar == 'a')
            {
                if (PLAYER.Left > 40)
                {
                    PLAYER.Left -= 40;
                }
            }
            else if (e.KeyChar == 'D' || e.KeyChar == 'd')
            {
                if (PLAYER.Left < 560)
                {
                    PLAYER.Left += 40;
                }
            }
            else if (e.KeyChar == 'S' || e.KeyChar == 's')
            {
                if (PLAYER.Top < 560)
                {
                    PLAYER.Top += 40;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Y < PLAYER.Top)
            {
                if (PLAYER.Top > 40)
                {
                    PLAYER.Top -= 40;
                }
            }
            else if (e.X < PLAYER.Left)
            {
                if (PLAYER.Left > 40)
                {
                    PLAYER.Left -= 40;
                }
            }
            else if (e.X > PLAYER.Left+41)
            {
                if (PLAYER.Left < 560)
                {
                    PLAYER.Left += 40;
                }
            }
            else if (e.Y > PLAYER.Top+41)
            {
                Text = "debug";
                if (PLAYER.Top < 560)
                {
                    PLAYER.Top += 40;
                }
            }
        }
    }
}
