using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerciseWithObjectAndHole
{
    class Program
    {
        static void Main(string[] args)
        {
            int hight=0;
            int width=0;
            int objectHight = 0;
            int objectWidth = 0;
            int objectDepth = 0;
            bool check = true;
            while(check==true)
            {
                try
                  {
                    Console.Clear();
                    Console.Write("Enter your hight of the hole: ");
                    hight = int.Parse(Console.ReadLine());
                    check = false;
                  }
                catch (FormatException)
                  {
                    Console.WriteLine("Please , enter only digits");
                    Console.ReadLine();
                  }
            }
            check = true;
            while(check==true)
            {
                try
                {
                    Console.Write("Enter your width of the hole: ");
                    width = int.Parse(Console.ReadLine());
                    check = false;
                }
                catch(FormatException)
                {
                    Console.WriteLine("Please , enter only digits");
                    Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("Enter your hight of the hole: {0}", hight);
                }
            }
            check = true;
             while(check==true)
            {
                try
                {
                    Console.Write("Enter hight of your object: ");
                    objectHight = int.Parse(Console.ReadLine());
                    check = false;
                }
                catch(FormatException)
                {
                    Console.WriteLine("Please , enter only digits");
                    Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("Enter your hight of the hole: {0}\nEnter your width of the hole: {1}", hight, width);
                }
            }
            check = true;
            while (check == true)
            {
                try
                {
                    Console.Write("Enter width of your object: ");
                    objectWidth = int.Parse(Console.ReadLine());
                    check = false;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please , enter only digits");
                    Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("Enter your hight of the hole: {0}\nEnter your width of the hole: {1}\nEnter hight of your object: {2}", hight, width, objectHight);
                }
            }
            check= true;
            while(check==true)
            {
                try
                {
                    Console.Write("Enter depth of your object: ");
                    objectDepth = int.Parse(Console.ReadLine());
                    check = false;
                }
                catch
                {
                    Console.WriteLine("Please , enter only digits");
                    Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("Enter your hight of the hole: {0}\nEnter your width of the hole: {1}\nEnter hight of your object: {2}\nEnter width of your object: {3}", hight, width, objectHight,objectWidth);
                }
            }
            if (hight >= objectHight && width >= objectWidth)
            {
                Console.WriteLine("Congratulations , your object will enter in the hole");
            }
            else if (hight >= objectWidth && width >= objectHight)
            {
                Console.WriteLine("Congratulations , your object will enter in the hole");
            }
            else if (hight >= objectDepth && width >= objectHight)
            {
                Console.WriteLine("Congratulations , your object will enter in the hole");
            }
            else if (hight >= objectHight && width >= objectDepth)
            {
                Console.WriteLine("Congratulations , your object will enter in the hole");
            }
            else if (hight >= objectDepth && width >= objectWidth)
            {
                Console.WriteLine("Congratulations , your object will enter in the hole");
            }
            else if (hight >= objectWidth && width >= objectDepth)
            {
                Console.WriteLine("Congratulations , your object will enter in the hole");
            }
            else
            {
                Console.WriteLine("Sorry , but your object can't enter in the hole");
            }
            Console.ReadLine();
        }

    }
}
