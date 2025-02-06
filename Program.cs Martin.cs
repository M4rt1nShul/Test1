namespace ForPyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Millist kujundit soovid? ");
            Console.Write("(kolmnurk, ruut, ristkylik, teemant, ring)");
            Console.Write("\n\n");

            string figur = Console.ReadLine();

            if (figur == "kolmnurk")
            {
                Console.WriteLine("Siseta kolmnurk kylje pikkud: ");
                int i, j, n;
                //i - row
                //j - sizq
                //n - column
                n = Convert.ToInt32(Console.ReadLine());

                for (i = 0; i <= n; i++)
                {
                    for (j = 1; j <= n-i; j++)
                    {
                        Console.Write(" ");
                    }
                    for (j = 1; j <= 2*i-1; j++)
                    {
                        Console.Write("*");
                    }
                    Console.Write("\n");
                }
                Console.Write("Kolmurk ümbermõõt on " + i * 3 + "ja pindala on " + n * n / 2  );
            }
            else if (figur == "ruut")
                {
                    Console.WriteLine("Siseta ruudu kylje pikkud: ");
                    int q = Int32.Parse(Console.ReadLine());
                    for (int row = 1; row <= q; row++)
                    {
                        for (int column = 1; column <= q; column++)
                        {
                            string variable = (row == column || row + column == q + 1) ? " * " : " * ";
                            Console.Write(variable);
                        }
                        Console.WriteLine();
                    }
                    Console.ReadKey();
                Console.Write("Kolmurk ümbermõõt on " + q * 2 + "ja pindala on " + q * q);
            }
                else if (figur == "ring")
                {
                    Console.WriteLine("Siseta ring kylje pikkud: ");
                double radius;
                double thickness = 0.4;
                char symbol = '*';

                do
                {
                    if (!double.TryParse(Console.ReadLine(), out radius) || radius <= 0)
                    {
                        Console.WriteLine("Radius have to be positive number");
                    }
                }
                while (radius <= 0);

                Console.WriteLine();
                double rIn = radius - thickness, rOut = radius + thickness;
                for (double y = radius; y >= -radius; --y)
                {
                    for (double x = -radius; x < rOut; x += 0.5)
                    {
                        double value = x * x + y * y;
                        if (value >= rIn * rIn && value <= rOut * rOut)
                        {
                            Console.Write(symbol);
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                    Console.WriteLine();
                }
            }
                else if (figur == "ristkylik")
                {
                    Console.WriteLine("Siseta ristkylik kylje pikkud: ");
                int q = Int32.Parse(Console.ReadLine());
                for (int row = 1; row <= q; row++)
                {
                    for (int column = -3; column <= q; column++)
                    {
                        string variable = (row == column || row + column == q + 1) ? " * " : " * ";
                        Console.Write(variable);
                    }
                    Console.WriteLine();
                }
                Console.ReadKey();
                Console.Write("\n");
            }
        }
    }
}

