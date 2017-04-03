using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace TankGame
{
    public partial class Form1 : Form
    {
        Tank tank = new Tank(200, 200);
        public static int d = 0;
        public Form1()
        {
            InitializeComponent();
        }
        public static string s;
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Thread thread = new Thread(tank.Move);
            thread.Start();

            while (true)
            {
                tank.DrawUp(e.Graphics);
                Thread.Sleep(1000);
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Down)
                d = 1;
            if (e.KeyCode == Keys.Up)
                d = 2;
            if (e.KeyCode == Keys.Right)
                d = 3;
            if (e.KeyCode == Keys.Left)
                d = 0;
        }
    }
}
