using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game4
{
    public class PositionOnMap
    {
        public List<Point> GetPoints(int size)
        {
            int minCoordinate = 0;
            int maxCoordinate = 19;
            List<Point> points = new List<Point>();
            for (int i=0;i<size;i++)
            {
               points.Add( new Point { X = RandomNumber.Get(minCoordinate, maxCoordinate), Y = RandomNumber.Get(minCoordinate, maxCoordinate) });
            }
            return points;
        }
    }
}
