namespace Project01.IntroductionCSharp.ControlStructures
{
    public class Loops
    {
        string[] products = {"Laptop", "Mouse", "Teclado", "Monitor"};

        public void ForEach()
        {
            // for (int i = 0; i <= 3; i++)
            // {
            //     Console.WriteLine(products[i]);
            // }

            foreach(string product in products)
            {
                Console.WriteLine(product);
            }
        }

        public void For()
        {            
            for(int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"Iteración: {i}");
            }
        }

        public void ForDesc()
        {
            for (int i = 5; i > 0; i--)
            {
                Console.WriteLine($"Iteración: {i}");
            }
        }

        public void WhileDesc()
        {
            int i = 5;

            while(i > 0)
            {
                Console.WriteLine($"Iteración: {i}");
                i--;
            }
        }

        public void While()
        {
            int i = 1;
            while (i <= 5)
            {
                Console.WriteLine($"Iteración: {i}");
                i++;
            }
        }

        public void Multiply(int number)
        {
            for (int j = 1; j <= 12; j++)
            {
                Console.WriteLine($"{j} X {number} = {j*number}");
            }
        }

        public void Multiply(int number, int limit)
        {
            for (int j = 1; j <= limit; j++)
            {
                Console.WriteLine($"{j} X {number} = {j*number}");
            }
        }

        public void WhileMultiply(int number)
        {
            int i = 1;

            while(i <= 12)
            {
                Console.WriteLine($"{i} X {number} = {i*number}");
                i++;
            }
        }

        public void WhileMultiply(int number, int limit)
        {
            int i = 1;

            while(i <= limit)
            {
                Console.WriteLine($"{i} X {number} = {i*number}");
                i++;
            }
        }

        /**
        *    1
        *   1 2
        *  1 2 3
        * 1 2 3 4
        *1 2 3 4 5
        */

        public void PrintNumberPyramid(int n)
        {
            int digits = n.ToString().Length;

            for (int row = 1; row <= n; row++)
            {
                for (int space = 1; space <= n - row; space++)
                {
                    Console.Write(" ");
                }

                for (int number = 1; number <= row; number++)
                {
                    Console.Write(number.ToString().PadLeft(digits, ' '));
                    if(number < row) Console.Write(" "); 
                }
                Console.WriteLine();
            }
        }

    }
}