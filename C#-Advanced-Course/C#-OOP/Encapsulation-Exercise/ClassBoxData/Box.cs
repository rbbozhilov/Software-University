using System;
using System.Collections.Generic;
using System.Text;

namespace ClassBoxData
{
    public class Box
    {

        private double length;
        private double width;
        private double height;

        public Box(double length , double width, double height)
        {

            this.Length = length;
            this.Width = width;
            this.Height = height;

        }

        public double Length { get { return this.length; } private set { if (value <= 0) { Console.WriteLine("Length cannot be zero or negative."); Environment.Exit(0); } this.length = value; } }

        public double Width { get { return this.width; } private set { if (value <= 0) { Console.WriteLine("Width cannot be zero or negative."); Environment.Exit(0); } this.width = value; }  }

        public double Height { get { return this.height; } private set { if (value <= 0) { Console.WriteLine("Height cannot be zero or negative."); Environment.Exit(0); } this.height = value; } }
    


        public void SurfaceArea()
        {
            double sum = 0;

            sum = (2 * length * width) + (2 * length * height) + (2 * width * height);

            Console.WriteLine("Surface Area - {0:F2}",sum);
        }

        public void LateralSurfaceArea()
        {

            double sum = 0;

            sum = (2 * length * height) + (2 * width * height);

            Console.WriteLine("Lateral Surface Area - {0:F2}",sum);

        }

        public void Volume()
        {

            double sum = 0;
            sum = length * height * width;

            Console.WriteLine("Volume - {0:F2}",sum);

        }


    }
}
