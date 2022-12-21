using System;

namespace velikdenski_qica
{
    class Program
    {
        static void Main(string[] args)
        {
            byte n = byte.Parse(Console.ReadLine());
            byte green = 0;
            byte red = 0;
            byte orange = 0;
            byte blue = 0;
            byte max = 0;
            string colorMax = "";
            for (int i = 0; i < n; i++)
            {
                string color = Console.ReadLine().ToLower();
                if (color == "blue")
                {
                    blue++;
                }
                else if (color == "red")
                {
                    red++;
                }
                else if (color == "orange")
                {
                    orange++;
                }
                else if (color == "green")
                {
                    green++;
                }

                if (max <= red)
                {
                    max = red;
                    colorMax = "Red";
                }
                else if(max <= green)
                {
                    max = green;
                    colorMax = "green";
                }
                else if (max <= orange)
                {
                    max = orange;
                    colorMax = "orange";
                }
                else if (max <= blue)
                {
                    max = blue;
                    colorMax = "blue";
                }

            }
            Console.WriteLine($"Red eggs: {red}");
            Console.WriteLine($"Orange eggs: {orange}");
            Console.WriteLine($"Green eggs: {green}");
            Console.WriteLine($"Blue eggs: {blue}");
            Console.WriteLine($"Max eggs: {max} -> {colorMax}");
        }
    }
}
