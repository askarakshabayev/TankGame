using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Threading;
namespace TankGame
{
    class Tank
    {
        public Point location;
        public int length;
        public int radius;
        public int gunW, gunH;
        public Tank (int x, int y)
        {
            length = 200;
            radius = 150;
            location.X = x;
            location.Y = y;
            gunW = 30;
            gunH = 150;
        }
        public void DrawUp(Graphics g)
        {
            g.Clear(Color.White);
            Brush a = new SolidBrush (Color.Red);
            Brush b = new SolidBrush(Color.Green);
            Brush c = new SolidBrush(Color.Black);
            g.DrawString(Form1.d.ToString (), new Font("Arial", 10), new SolidBrush(Color.Blue), 300, 300);
            g.FillRectangle(b, location.X - length / 2, location.Y - length / 2, length, length);
            g.FillEllipse(a, location.X - radius / 2, location.Y - radius / 2, radius, radius);
            g.FillRectangle(c, location.X - gunW / 2, location.Y - gunH, gunW, gunH);
        }

        public void DrawDown(Graphics g)
        {

        }

        public void DrawLeft(Graphics g)
        {

        }

        public void DrawRight(Graphics g)
        {

        }
        public void Move ()
        {
            while (true)
            {
                if (Form1.d == 0)
                    move(-1, 0);
                if (Form1.d == 1)
                    move(0, -1);
                if (Form1.d == 2)
                    move(1, 0);
                if (Form1.d == 3)
                    move(0, 1);
                Thread.Sleep(1000);
            }
        }
        public void move(int dx, int dy)
        {
            location.X += dx;
            location.Y += dy;
        }
    }
}
