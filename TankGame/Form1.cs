using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace TankGame
{
    public partial class Form1 : Form
    {
        tank Tanks = new tank();
        
        public Form1()
        {
            InitializeComponent();
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Tanks.DrawLeft(e.Graphics);
            Tanks.bullet(e.Graphics);
          //  Tanks.bulletright(e.Graphics);
            Tanks.bulletdown(e.Graphics);
        }
    }
}
