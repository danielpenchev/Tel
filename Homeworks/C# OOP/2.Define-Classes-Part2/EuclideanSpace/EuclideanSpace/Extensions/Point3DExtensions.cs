using EuclideanSpace.Models;

namespace EuclideanSpace.Extensions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public static class Point3DExtensions
    {
        public static double CalculateDistance(Point3D firstPoint, Point3D secondPoint)
        {
            double distance = 0.0;

            distance = Math.Sqrt(
                (firstPoint.X - secondPoint.X) * (firstPoint.X - secondPoint.X) +
                (firstPoint.Y - secondPoint.Y) * (firstPoint.Y - secondPoint.Y) +
                (firstPoint.Z - secondPoint.Z) * (firstPoint.Z - secondPoint.Z));

            return distance;
        }
    }
}
