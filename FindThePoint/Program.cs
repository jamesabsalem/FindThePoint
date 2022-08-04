using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FindThePoint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var r = findPoint(0, 0, 1, 1);
           var n = r.Aggregate<int,string>(null,(x, y) => x +" "+ y);
            Console.WriteLine(n);

        }
        public static List<int> findPoint(int px, int py, int qx, int qy)
        {
            var list = new List<int>();
            var rx =qx + (qx - px);
            list.Add(rx);
            var ry =qy + (qy - py);
            list.Add(ry);
            return list;
        }
    }
}
