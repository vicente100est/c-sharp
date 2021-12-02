using System;

namespace RetoIntroCS
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            int option;

            Console.WriteLine("Ingresa tu nombre: ");
            name = Console.ReadLine();
            Console.WriteLine("Bienvenida " + name);
            menu();

            Console.WriteLine("Ingrese el numero de la opcion: ");
            option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    string namePersonX;
                    Console.WriteLine("Ingresa el nombre de la persona que quieras saludar");
                    namePersonX = Console.ReadLine();
                    saludo(namePersonX);
                    menu();
                    break;
                case 2:
                    int edad;
                    bool persona;
                    bool dinero;

                    Console.WriteLine("Ingresa tu edad: ");
                    edad = int.Parse(Console.ReadLine());

                    if (edad < 18)
                    {
                        Console.WriteLine("Lo siento, eres menor de edad perrin, no puedes pasar");
                    }
                    else if (edad <= 22)
                    {
                        Console.WriteLine("Eres una persona?");
                        persona = bool.Parse(Console.ReadLine());
                        Console.WriteLine("Tienes dinero?");
                        dinero = bool.Parse(Console.ReadLine());
                        bool decision = cervezaSi(persona, dinero);
                        if (decision)
                        {
                            Console.WriteLine("Ay perro, puedes pasar");
                        }
                        else
                        {
                            Console.WriteLine("Lo siento, llegale perrin");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Lo siento, te hace falta madurar perrin");
                    }
                    menu();
                    break;
                case 3:
                    mis3Mejores();
                    menu();
                    break;
                case 4:
                    double r;
                    Console.WriteLine("Ingresa el valor del radio: ");
                    r = double.Parse(Console.ReadLine());
                    double area = areaCirculo(r);
                    Console.WriteLine("El area del circulo con radio de " + r +
                        " es de " + area);
                    menu();
                    break;
                case 5:
                    int tablaDel;

                    Console.WriteLine("Ingrese la tabla que quiera ver");
                    tablaDel = int.Parse(Console.ReadLine());
                    tabla(tablaDel);
                    menu();
                    break;
                case 6:
                    tablaCero215();
                    menu();
                    break;
                case 7:
                    string nombreParaSaludoFinDeAno;
                    Console.WriteLine("Ingresa el nombre de la persona para el mensaje " +
                        "de fin de año");
                    nombreParaSaludoFinDeAno = Console.ReadLine();
                    saludoFinDeAno(nombreParaSaludoFinDeAno);
                    menu();
                    break;
                case 8:
                    Environment.Exit(0);
                    break;
            }
        }

        static void menu()
        {
            Console.WriteLine("Menu principal");
            Console.WriteLine("1.- Saludo personalizado");
            Console.WriteLine("2.- Puedes ir por cerveza?");
            Console.WriteLine("3.- Mi lista de mis 3 mejores amigos");
            Console.WriteLine("4.- Area de un Circulo");
            Console.WriteLine("5.- Una tabla de multiplicacion especifico");
            Console.WriteLine("6.- Las primeras 15 tablas de multiplicar");
            Console.WriteLine("7.- Saludo de fin de año");
            Console.WriteLine("8.- Salir");
        }

        static void saludo(string name)
        {
            Console.WriteLine("Estimad@ " + name + " eres una de las personas mas " +
                " importantes de mi vida");
        }

        static bool cervezaSi(bool person, bool money)
        {
            if (person)
            {
                if (money)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        static void mis3Mejores()
        {
            int index;
            string[] friends = new string[3];

            Console.WriteLine("Ingresa el nombre del primer wey");
            friends[0] = Console.ReadLine();
            Console.WriteLine("Ingresa el nomvre del segundo wey");
            friends[1] = Console.ReadLine();
            Console.WriteLine("Ingresa del tercer wey");
            friends[2] = Console.ReadLine();

            for (index = 0; index<friends.Length; index++)
            {
                Console.WriteLine("Tus mejores amigos son: " + friends[index]);
            }
        }

        static double areaCirculo(double r)
        {
            double radio = Math.Pow(r, 2);
            double a = Math.PI * radio;

            return a;
        }

        static void tabla(int num)
        {
            int i = 0;
            int result;
            while (i <= 10)
            {
                result = num * i;
                Console.WriteLine(num + " X " + i + " = " + result);
                i++;
            }
        }

        static void tablaCero215()
        {
            int result;

            for (int i = 0; i <= 15; i++)
            {
                for (int j = 0; j <= 10; j++)
                {
                    result = i * j;

                    Console.WriteLine(i + " X " + j + " = " + result);
                }
            }
        }

        static void saludoFinDeAno(string name)
        {
            Console.WriteLine("Querid@ " + name + " espero que este 2022 " +
                "cumplas todos tus sueños y objetivo; besos, abrazos y mas");
        }
    }
}
