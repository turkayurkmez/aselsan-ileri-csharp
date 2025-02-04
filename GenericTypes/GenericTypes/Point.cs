using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericTypes
{
    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public void Reset()
        {
            X = 0;
            Y = 0;
        }

        public override string ToString()
        {
            return $"{X};{Y}";
        }


    }

    public class PointDouble
    {
        public double? X { get; set; }
        public double Y { get; set; }

        public void Reset()
        {
            X = 0.0;
            Y = 0.0;
        }

        public override string ToString()
        {
            return $"{X};{Y}";
        }




    }

    public class PointGeneric<T> where T:struct, IEquatable<T>
    {

        public T? X { get; set; }
        public T? Y { get; set; }

        public void Reset()
        {
            X = default(T);
            Y = default(T);
        }

        override public string ToString()
        {
            return $"{X};{Y}";
        }
    }
}
