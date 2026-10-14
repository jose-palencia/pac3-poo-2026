namespace Project01.IntroductionCSharp.Operators.Logic
{
    public class Compare
    {
        private int x = 20;
        private int y = 25;
        private int z = 22;

        public void Valid()
        {
            Console.WriteLine("Es igual x y y: " + (x == y));
            Console.WriteLine("Es diferente x y y: " + (x != y));
            Console.WriteLine("Es mayor x que y: " + (x > y));
            Console.WriteLine("Es menor x que y: " + (x < y));
            Console.WriteLine("Es mayor o igual x que y: " + (x >= y));
            Console.WriteLine("Es menor o igual x que y: " + (x <= y)); 

            // && AND
            Console.WriteLine("Z es mayor que X y menor que Y: " + (z > x && z < y ));
            // || OR
            Console.WriteLine("Z es mayor que X ó menor que Y: " + (z > x || z < y));
        }

        public void ValidInterpolation()
        {
            Console.WriteLine($"Es igual {x} y {y}: {x == y}");

            // Interpolación de strings
            Console.WriteLine($"{z} es mayor que {x} y menor que {y}: {z > x && z < y}");
        }

    }
}