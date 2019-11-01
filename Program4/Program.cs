using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
   
            int valida = 0;
            do
            {
                try
                {
                    double numero, e = 0;
                    string mensaje = " e = ";
                    do
                    {
                        Console.WriteLine("Ingrese valor de x");
                        numero = Convert.ToDouble(Console.ReadLine());
                        if (numero < 0)
                        {
                            Console.WriteLine("El número ingresado no puede ser negativo\n");
                        }
                    } while (numero < 0);
                    for (int i = 0; i <= numero; i++)
                    {
                        e += 1 + (Math.Pow(numero, i) / factorial(i));
                        mensaje += "1/" + i + "! +";
                    }
                    mensaje = mensaje.Remove(mensaje.Length - 1);
                    Console.WriteLine(" e = " + e + "\n" + mensaje);
                    Console.ReadLine();
                }
                catch (Exception)
                {
                    Console.WriteLine("Ingreso no válido\n");
                    valida = 1;
                }
            } while (valida == 1);

        }
        static double factorial(int n)
        {
            double fact = 1;
            for (int i = 1; i <= n; i++)
            {
                fact = fact * i;
            }
            return fact;
        }
    }
}