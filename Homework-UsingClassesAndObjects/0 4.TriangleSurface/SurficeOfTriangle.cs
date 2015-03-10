using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write methods that calculate the surface of a triangle by given:
//Side and an altitude to it;
//Three sides;
//Two sides and an angle between them;
//Use System.Math.
namespace _0_4.TriangleSurface
{

    class SurficeOfTriangle
    {
        static void Main()
        {
            Console.WriteLine("Choose operation to perform !!!"
                +"\nPress \"1\" to use The Three Side Formula "
                +"\nPress \"2\" to use One Seide and Altitude Formula "
                + "\nPress \"3\" to use Two Sides and Angle between them Formula ");
            string choose = Console.ReadLine();
            if (choose=="1")
            {
                Console.Clear();
                ThreeSideFormula();
            }
            else if (choose=="2")
            {
                Console.Clear();
                SideAndAltitude();
            }
            else if (choose=="3")
            {
                Console.Clear();
                SidesAndAngleBetweenThem();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Wrong paramiters!!!");
            }
       

        }
        static double ThreeSideFormula()
        {
            Console.Write("Enter side A = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter side B = ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Enter side C = ");
            double c = double.Parse(Console.ReadLine());
            double semiPerimeter = (a + b + c) / 2;
            double area = Math.Sqrt((semiPerimeter*(semiPerimeter-a)*(semiPerimeter-b)*(semiPerimeter-c)));
            Console.WriteLine("The sutfice is {0:F2} cm2 ",area);
            return area;
        }
        static double SidesAndAngleBetweenThem()
        {
            Console.Write("Enter degrees for A = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter side B = ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Enter side C = ");
            double c = double.Parse(Console.ReadLine());
            double firstPart = ((b * c) / 2);
            double area = firstPart * (Math.Sin(a * Math.PI / 180));
            Console.WriteLine("The surfice is : {0:F2}",area);
            return area;
        }

        static double SideAndAltitude ()
        {
            Console.Write("Enter BASE side B = ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Enter high H = ");
            double h = double.Parse(Console.ReadLine());
            double area = h * b / 2;
            Console.WriteLine("The area is : {0}",area);
            return area;
        }
    }
}
