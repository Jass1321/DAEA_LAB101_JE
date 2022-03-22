using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB01_JE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Procedimientos y funciones";
            string opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("[1] Suma de dos números");
                Console.WriteLine("[2] Resta de dos números");
                Console.WriteLine("[3] Divisi´´on de dos números");
                Console.WriteLine("[4] Multiplicación de dos números");
                Console.WriteLine("[5] Los 10 primeros numero primos");
                Console.WriteLine("[6] La raíz cuadrada de los 10 primeros números enteros");
                Console.WriteLine("[7] Conversión de temperatura en °C");
                Console.WriteLine("[8] Conversión de temperatura en °F");
                Console.WriteLine("[0] Salir");
                Console.WriteLine("Ingrese una opción y presione ENTER");
                opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("Ingrese el primer número");
                        int a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        int b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La suma de {0} y {1} es {2}", a, b, Suma(a, b));
                        Console.ReadKey();
                        break;
                    case "2":
                        Console.WriteLine("Ingrese el primer número");
                        int r1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        int r2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La resta de {0} y {1} es {2}", r1, r2, Resta(r1, r2));
                        Console.ReadKey();
                        break;
                    case "3":
                        Console.WriteLine("Ingrese el primer número");
                        int d1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        int d2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La division de {0} y {1} es {2}", d1, d2, Division(d1, d2));
                        Console.ReadKey();
                        break;
                    case "4":
                        Console.WriteLine("Ingrese el primer número");
                        int m1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        int m2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La multiplicación de {0} y {1} es {2}", m1, m2, Multiplicacion(m1, m2));
                        Console.ReadKey();
                        break;
                    case "5":
                        Console.WriteLine("Calculando...");
                        Console.WriteLine("----------------------------------");
                        Console.WriteLine("Los 10 primeros numeros primos son:");
                        Primos();
                        Console.ReadKey();
                        break;
                    case "6":
                        Console.WriteLine("Calculando...");
                        Raiz();
                        Console.ReadKey();
                        break;
                    case "7":
                        Console.WriteLine("Ingrese el valor en °F");
                        Double c1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Calculando...");
                        Console.WriteLine("----------------------------------");
                        Console.WriteLine("La conversion de °{0}F a grado celsius es °{1}C", c1, Centigrados(c1));
                        Console.ReadKey();
                        break;
                    case "8":
                        Console.WriteLine("Ingrese el valor en °F");
                        Double f1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Calculando...");
                        Console.WriteLine("----------------------------------");
                        Console.WriteLine("La conversion de °{0}C a grado fahrenheit es °{1}F", f1, Fahrenheit(f1));
                        Console.ReadKey();
                        break;
                }
            } while (!opcion.Equals("0"));
        }
        //Func de Suma
        static int Suma(int a, int b)
        {
            return a + b;
        }
        //Func de Resta
        static int Resta(int r1, int r2)
        {
            return r1 - r2;
        }
        //Func de Division
        static int Division(int d1, int d2)
        {
            return d1/d2;
        }
        //Func de Multiplicacion
        static int Multiplicacion(int m1, int m2)
        {
            return m1*m2;
        }
        //Func de Temperatura en Centigrados C°
        static Double Centigrados(double c1)
        {
            return (5*(c1-32))/9;
        }
        //Func de Temperatura en Farenheit F°
        static Double Fahrenheit(double f1)
        {
            return ((9*f1)/5)+32;
        }
        //Func 10 primeros números primos
        static void Primos()
        {
            int num = 2, divisible = 0;
            while (num<=30)
            { 
                for (int i = 1; i <= num; i++)
                {
                    if (num % i == 0)
                    {
                        divisible++;
                    }
                    if (divisible > 2)
                    {
                        break;
                    }
                }
                if (divisible == 2)
                {
                    Console.WriteLine("{0}",num);
                }
                divisible = 0;
                num++;
            }
            
            Console.ReadKey();
            Console.WriteLine("----------------------------------");
        }
        //Fun Raiz Cuadrada
        static void Raiz()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("La raíz cuadrada de {0} es: {1}", i, Math.Sqrt(i));
            }
        }
    }
}
