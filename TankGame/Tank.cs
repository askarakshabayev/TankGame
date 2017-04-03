using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

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
            Brush a = new SolidBrush (Color.Red);
            Brush b = new SolidBrush(Color.Green);
            Brush c = new SolidBrush(Color.Black);
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
            Brush a = new SolidBrush(Color.Red);
            Brush b = new SolidBrush(Color.Green);
            Brush c = new SolidBrush(Color.Black);
            g.FillRectangle(b, location.X - length / 2, location.Y - length / 2, length, length);
            g.FillEllipse(a, location.X - radius / 2, location.Y - radius / 2, radius, radius);
            g.FillRectangle(c, location.X - gunW / 4, location.Y - gunH / 10, gunH, gunW);

        }

        public void move(int dx, int dy)
        {

        }
    }
}
