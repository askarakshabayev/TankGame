using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Threading;

namespace TankGame
{
    class tank
    {
        public Point location;
        public int length;
        public int radius = 15;
        public int gunW, gunH;
        Pen pen = new Pen(Color.Black);
        public int x, y;
        

        public void DrawUp(Graphics g)
        {
            x = 20;
            y = 20;
            length = 40;
            location.X = 30;
            location.Y = 30;
            pen.Color = Color.Black;
            g.DrawEllipse(pen, location.X, location.Y , length, length);
            g.DrawRectangle(pen, location.X, location.Y, length ,length);
            g.DrawRectangle(pen, location.X + 10, location.Y - 20, length / 2, length);
        }

        public void DrawDown(Graphics g)
        {

        }

        public void DrawLeft(Graphics g)
        {
            x = 20;
            y = 20;
            length = 40;
            location.X = 30;
            location.Y = 30;
            pen.Color = Color.Black;
            g.DrawEllipse(pen, location.X, location.Y, length, length);
            g.DrawRectangle(pen, location.X, location.Y, length, length);
            //g.DrawRectangle(pen, location.X + 10, location.Y - 20, length / 2, length);
            g.DrawRectangle(pen, location.X-20, location.Y+10,length,length/2);
        }

        public void DrawRight(Graphics g)
        {

        }

        public void move(int dx, int dy)
        {
           
        }
        public void bulletright(Graphics g)
        {
            //g.DrawEllipse(pen, location.X + 10, location.Y + 10, radius, radius);
            while (true)
            {

                g.Clear(Color.White);
                g.DrawEllipse(pen, location.X + 10, location.Y + 10, radius, radius);

                location.X++;
                Thread.Sleep(10);
            }
            
        }
        public void bulletleft(Graphics g)
        {
            //g.DrawEllipse(pen, location.X + 10, location.Y + 10, radius, radius);
            while (true)
            {

                g.Clear(Color.White);
                g.DrawEllipse(pen, location.X + 150, location.Y + 10, radius, radius);
                location.X--;
                if (location.X == 0)
                {
                    break;
                }
                Thread.Sleep(10);
            }
        }
        public void bulletup(Graphics g)
        {
            //g.DrawEllipse(pen, location.X + 10, location.Y + 10, radius, radius);
            while (true)
            {
                g.Clear(Color.White);
                g.DrawEllipse(pen, location.X + 100, location.Y + 10, radius, radius);
                location.Y--;
                Thread.Sleep(10);
            }
        }
        public void bulletdown(Graphics g)
        {
            //g.DrawEllipse(pen, location.X + 10, location.Y + 10, radius, radius);
            while (true)
            {
                g.Clear(Color.White);
                g.DrawEllipse(pen, location.X + 100, location.Y + 10, radius, radius);
                location.Y++;
                Thread.Sleep(10);
            }
        }
        public int d;
        public void Movebullet(Graphics g)
        {
            switch (d){ 
                case 1:
                while (true)//bullet right
                {
                    g.Clear(Color.White);
                    g.DrawEllipse(pen, location.X + 10, location.Y + 10, radius, radius);
                    location.X++;
                    Thread.Sleep(10);
                }
                case 2:
                while (true)//left
                {
                    g.Clear(Color.White);
                    g.DrawEllipse(pen, location.X + 150, location.Y + 10, radius, radius);
                    location.X--;
                    Thread.Sleep(10);
                }
                case 3:
                while (true)//up
                {
                    g.Clear(Color.White);
                    g.DrawEllipse(pen, location.X + 150, location.Y + 10, radius, radius);
                    location.Y--;
                    Thread.Sleep(10);
                }
                case 4:
                while (true)//down
                {
                    g.Clear(Color.White);
                    g.DrawEllipse(pen, location.X + 150, location.Y + 10, radius, radius);
                    location.Y--;
                    Thread.Sleep(10);
                }
            }
        }
        public void bullet(Graphics g)
        {
            g.DrawEllipse(pen, location.X + 10, location.Y + 10, radius,radius);
        }
    }
}
