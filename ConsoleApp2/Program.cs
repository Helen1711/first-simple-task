using System;

namespace ConsoleApp2
{
    class Program
    {
        static string message = " and press enter";
        static double width, height, deep;
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of your floor " + message);
            double floor = Convert.ToInt16(Console.ReadLine());

            if (floor != 1)
            {
                Console.WriteLine("Delivery via window impossible");
                CheckDelivery();
            }
            else if (floor == 1)
            {
                Console.WriteLine("If you want to try delivery via door enter 1, for window - enter 2 " + message);
                double type = Convert.ToInt16(Console.ReadLine());
                CheckDelivery();
            }

        }

        static void CheckDelivery()
        {
            Console.WriteLine("Choose type  of canal. Enter 1 for rectangle or 2 for circle." +
                "Warning!!!! Enter size of canal element that can be opened " + message);
            double type = Convert.ToInt16(Console.ReadLine());
            if (type == 1)
            {
                AddFridgeParams();

                Console.WriteLine("Enter width of canal" + message);
                double canalWidth = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter height of canal" + message);
                double canalHeight = Convert.ToDouble(Console.ReadLine());

                if ((width < canalWidth && height < canalHeight) || (width < canalWidth && deep < canalHeight))
                {
                    Console.WriteLine("You can bring a fridge into the house");
                } else
                {
                    Console.WriteLine("You can't bring a fridge into the house");
                }
            }
            else if (type == 2)
            {
                AddFridgeParams();

                double diagonal = Math.Sqrt(Math.Pow(width, 2) + Math.Pow(deep, 2));
                double diagonal2 = Math.Sqrt(Math.Pow(width, 2) + Math.Pow(height, 2));

                Console.WriteLine("Enter diametr of canal" + message);
                double canalDiametr = Convert.ToDouble(Console.ReadLine());

                if ((diagonal < canalDiametr) || (diagonal2 < canalDiametr))
                {
                    Console.WriteLine("You can bring a fridge into the house");
                } else
                {
                    Console.WriteLine("You can't bring a fridge into the house");
                }
            }
            else
            {
                Console.WriteLine("Invalid type");
            }
        }

        static void AddFridgeParams()
        {
            Console.WriteLine("Enter width of fridge" + message);
            width = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter deep of fridge" + message);
            deep = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter height of fridge" + message);
            height = Convert.ToDouble(Console.ReadLine());
        }

    }
}

