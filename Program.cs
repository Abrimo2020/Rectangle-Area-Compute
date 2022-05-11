using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RectangleApp
{
    class Rectangle
    {
        double length;
        double width;
        public void AcceptDetails()
        {
            //length = 2; width = 3;
            Console.WriteLine("please Enter the length of the rectangle:");
            length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter the width of the rectangle:");
            width = Convert.ToInt32(Console.ReadLine());
            Console.ReadKey();
        }
        public double getArea()
        {
            return length * width;
        }
     public void Display()
     {
         Console.WriteLine("The length:{0}",length);
         Console.WriteLine("The width:{0}",width);
         Console.WriteLine("The Area of Rectangle:{0}",getArea());
         
     }
    

    
    }
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            r.AcceptDetails();
            r.Display();
            //r.Display();
            Console.ReadKey();
        }
    }
}
