using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1, 3, '*');
            p1.x = 1;
            p1.Draw();

            Point p2 = new Point(4, 5, '#');
            p2.Draw();

            List<Point> plist = new List<Point>();
            plist.Add(p1);
            plist.Add(p2);

            Console.ReadLine();
        }
    }
}
