using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TankGame
{
    public partial class Form1 : Form
    {
        Graphics g;
        Tank tank = new Tank(200, 200);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //tank.DrawUp(e.Graphics);
            tank.DrawDown(e.Graphics);
            StreamReader sr = new StreamReader(@"1.txt");
            string[] s = sr.ReadLine().Split();
            Image wall = Image.FromFile("wall.jpg");
            foreach (string p in s)
            {
                if (int.Parse(p) == 1)
                    e.Graphics.DrawImage(wall, 400, 400, 400 , 400);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
