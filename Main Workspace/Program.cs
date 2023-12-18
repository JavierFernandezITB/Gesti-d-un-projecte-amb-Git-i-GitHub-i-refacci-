// Author: Javier Fernández Cano
// Date: 18 Dec 2023


namespace myWorkspace
{
    public class myClass
    {
        public static void Main(string[] args)
        {
            const string pressAnyKey = "Presiona cualquier tecla para continuar.";
            const string inputSideMessage = "Introduce la longitud de un lado: ";
            const string inputAnotherSideMessage = "Introduce la longitud de otro lado: ";
            const string inputRadiusMessage = "Introduce el radio: ";
            const string outputMessage = "El resultado es: {0}";
            const string errorWrongChoice = "Esa opción no es valida.";
            const string askForChoice = "Introduce una opción: ";
            const string choices = "1.Cuadrado\n2.Rectángulo\n3.Círculo\n4.Pentágono\n5.Salir";

            bool isRunning = true;

            double result = 0;

            while (isRunning)
            {
                Console.Clear();
                Console.WriteLine(askForChoice);
                Console.WriteLine(choices);
                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        double firstSide;
                        Console.WriteLine(inputSideMessage);
                        firstSide = Convert.ToInt32((Console.ReadLine()));
                        result = CalcAreaRectanguloCuadrado(firstSide);
                        break;
                    case 2:
                        double secondSide;
                        Console.WriteLine(inputSideMessage);
                        firstSide = Convert.ToInt32((Console.ReadLine()));
                        Console.WriteLine(inputAnotherSideMessage);
                        secondSide = Convert.ToInt32((Console.ReadLine()));
                        result = CalcAreaRectanguloCuadrado(firstSide, secondSide);
                        break;
                    case 3:
                        double radius;
                        Console.WriteLine(inputRadiusMessage);
                        radius = Convert.ToInt32((Console.ReadLine()));
                        result = CalcAreaCirculo(radius);
                        break;
                    case 4:
                        Console.WriteLine(inputSideMessage);
                        firstSide = Convert.ToInt32((Console.ReadLine()));
                        result = CalcAreaPentagono(firstSide);
                        break;
                    case 5:
                        isRunning = false;
                        break;
                    default:
                        Console.WriteLine(errorWrongChoice);
                        result = -1337;
                        break;
                }
                if (result != -1337)
                    Console.WriteLine(outputMessage, result);
                Console.WriteLine(pressAnyKey);
                Console.ReadKey();
            }
        }

        public static double CalcAreaRectanguloCuadrado(double lado1)
        {
            return lado1 * lado1;
        }
        public static double CalcAreaRectanguloCuadrado(double lado1, double lado2)
        {
            return lado1 * lado2;
        }
        public static double CalcAreaCirculo(double radio)
        {
            return Math.PI * Math.Pow(radio, 2);
        }
        public static double CalcAreaPentagono(double lado)
        {
            return 0.0;
        }
    }
}