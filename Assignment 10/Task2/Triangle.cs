using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Triangle
    {
        private double _s1 { get; set; }
        private double _s2 { get; set; }
        private double _s3 { get; set; }

        public Triangle(double side_1, double side_2, double side_3)
        {
            this._s1 = side_1;
            this._s2 = side_2;
            this._s3 = side_3;
            checkEqualityTriangle();
        }

        public double S1 { get { return _s1;} }
        public double S2 { get { return _s2;} }
        public double S3 { get { return _s3;} }

        public double Parameter()
        {
            double parameter = _s1 + _s2 + _s3;
            return parameter;
        }

        public double Area()
        {
            double semiPerimeter = (_s1 + _s2 + _s3) / 2;
            double area = Math.Sqrt(semiPerimeter * (semiPerimeter - _s1) * (semiPerimeter - _s2) * (semiPerimeter - _s3));

            return area;
        }

        public static bool operator ==(Triangle a, Triangle b)
        {
            return a._s1 == b._s1 && a._s2 == b._s2 && a._s3 == b._s3;
        }

        public static bool operator !=(Triangle a, Triangle b)
        {
            return a._s1 != b._s1 || a._s2 != b._s2 || a._s3 != b._s3;
        }

        public static bool operator <(Triangle a, Triangle b)
        {
            return a.Area() < b.Area();
        }

        public static bool operator >(Triangle a, Triangle b)
        {
            return a.Area() > b.Area();
        }

        public static Triangle operator +(Triangle a, Triangle b)
        {
            long totalArea = (long)(a.Area() + b.Area());
            double side = Math.Sqrt((double)totalArea);

            Triangle result = new Triangle(side, side, Math.Sqrt(2) * side);
            return result;
        }

        public bool checkEqualityTriangle()
        {
            if(_s1 + _s2 <= _s3 || _s1 + _s3 <= _s2 || _s2 + _s3 <= _s1)
            {
                return false;
            }
            return true;
        }

        public static explicit operator Triangle(double side)
        {
            Triangle equilateralTriangle = new Triangle(side, side, side);
            return equilateralTriangle;
        }

    }
}
