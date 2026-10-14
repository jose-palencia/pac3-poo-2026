namespace Project01.IntroductionCSharp.ControlStructures
{
    public class Conditional
    {
        // if => si
        public void If()
        {
            int age = 21;

            if(age >= 18)
            {
                Console.WriteLine("Eres mayor de edad");
                return; // interrumpe la ejecución de la función
            } //else
            //{
                Console.WriteLine("No eres mayor de edad");
            //}
        }

        // switch => evaluar casos
        public void SwitchClassic()
        {
            int numberDay = 0;

            switch (numberDay)
            {
                case 1:
                    Console.WriteLine("Domingo");
                    break;
                case 2: 
                    Console.WriteLine("Lunes");
                    break;               
                case 3: 
                    Console.WriteLine("Martes");
                    break;
                case 4: 
                    Console.WriteLine("Miércoles");
                    break;
                case 5: 
                    Console.WriteLine("Jueves");
                    break;
                case 6: 
                    Console.WriteLine("Viernes");
                    break;
                case 7:
                    Console.WriteLine("Sábado");
                    break;
                default: 
                    Console.WriteLine("Dia no valido");
                    break;
            }
        }

        // switch expressions
        public void SwitchExpressions()
        {
            int numberDay = -3;

            string dayName = numberDay switch
            {
                1 => "Domingo",
                2 => "Lunes",
                3 => "Martes",
                4 => "Miércoles",
                5 => "Jueves",
                6 => "Viernes",
                7 => "Sábado",
                _ => "Día no valido"
            };

            Console.WriteLine(dayName);
        }

        // Operador ternario
        public void OperadorTernario()
        {
            int age = 17;
            string message = (age > 18) ? "Mayor de edad" : "Menor de edad";

            Console.WriteLine(message);
        }
    }
}