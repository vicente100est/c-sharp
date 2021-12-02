using System;

namespace CS_Course
{
    class Program
    {
        static void Main(string[] args)
        {
            //Este bloque de código pertenece a la clase funciones
            int a = 5;
            int b = 10;

            Show();
            Sum(a, b);
            int m = Mul(a, b);
            Console.WriteLine(m);
        }

        static int Mul(int num1, int num2)
        {
            int x = num1 * num2;
            return x;
        }

        static void Sum(int num1, int num2)
        {
            int x = num1 + num2;
            Console.WriteLine(x);
        }

        static void Show()
        {
            Console.WriteLine("Hola soy un texto que se imprime desde funcion");
        }
    }
}
