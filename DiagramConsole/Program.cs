using System;
using System.Collections.Generic;

namespace DiagramConsole
{
    class Program
    {        
        static void Main(string[] args)
        {

            List<Coordinates> coordinates = new();
            Console.WriteLine("To form Circle using X and Y");            
            Dictionary<string, Coordinates> diagram_item = new ();
            Console.WriteLine("Enter number of Items");
            int count = Convert.ToInt32(Console.ReadLine());
            int point = 1;
            int radius = 5;
            double interval = 6;
            double angleInterval = 360 / count;
            
            try
            {
                if (interval < 2 * Math.PI)
                {
                    for (interval = angleInterval; interval <= 360; interval += angleInterval)
                    {
                        Coordinates coordinate = new Coordinates();
                        coordinate.x = radius * Math.Cos(interval);
                        coordinate.y = radius * Math.Sin(interval);
                        coordinates.Add(coordinate);
                    }
                    foreach (var points in coordinates)
                    {
                        Console.WriteLine("Point:" + point++ + "X: " + points.x + " Y:" + points.y);
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Exception" + ex);
            }
            Console.ReadLine();
        }
    }
}
