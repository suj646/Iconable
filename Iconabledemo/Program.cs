using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;

namespace Iconabledemo
{
    class Car : ICloneable
    {
        int width;

        public Car(int width)
        {
            this.width = width;
        }

        public object Clone()
        {
            return new Car(this.width);
        }

        public override string ToString()
        {
            return string.Format("Width of car = {0}", this.width);
        }
    }


    class Program
    {
        static void Main()
        {
            Car carOne = new Car(1695);
            Car carTwo = carOne.Clone() as Car;

            Console.WriteLine("{0}mm", carOne);
            Console.WriteLine("{0}mm", carTwo);



        }
    }
}