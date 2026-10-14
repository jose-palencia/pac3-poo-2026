using Project01.IntroductionCSharp.ControlStructures;
using Project01.IntroductionCSharp.Operators.Arithmetic;
using Project01.IntroductionCSharp.Operators.Logic;
using Project01.IntroductionCSharp.Variables;

Numbers numbers = new Numbers();

//numbers.Variables();

Strings strings = new Strings();

//strings.Variables();

Calculator calculator = new Calculator();

// Console.WriteLine("La suma de 2 + 2 es: " + calculator.Sum(2, 2));
// Console.WriteLine("La resta de 4 - 2 es: " + calculator.Subtract(4, 2));
// Console.WriteLine("La multiplicación de 4 * 2 es: " + calculator.Multiply(4, 2));
// Console.WriteLine("La división de 11 / 3 es: " + calculator.Divide(11, 3));
// Console.WriteLine("El valor de PI es: " + (int)calculator.Pi());
// Console.WriteLine("El residuo de 11 / 3 es: " + calculator.Module(11, 3));

Compare compare = new Compare();
//compare.Valid();

Conditional conditional = new Conditional();

//conditional.If();
// conditional.OperadorTernario();
// conditional.SwitchClassic();
// conditional.SwitchExpressions();

Loops loops = new Loops();
// loops.For();

//Console.WriteLine("Ingrese el numero de tabla que desea ver: ");
// int n1 = int.Parse(Console.ReadLine());
//int n2 = int.TryParse(Console.ReadLine(), out int nro) ? nro : 0;

//loops.Multiply(n2);
// loops.Multiply(n2);
// loops.Multiply(n2, 5);

// loops.ForDesc();

// loops.While();
// loops.WhileDesc();
// loops.WhileMultiply(2);
// loops.WhileMultiply(2, 5);
// loops.ForEach();


loops.PrintNumberPyramid(15);