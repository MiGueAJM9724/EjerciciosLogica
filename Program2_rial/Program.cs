using System;

namespace Program2_rial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese numero 1");
            int num1, num2;
            num1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese numero 2");
            num2 = Int32.Parse(Console.ReadLine());

            if (num1 > num2) {
                Console.WriteLine("El numero1 es mayor al numero2");
            }
            else
            {
                String suma = "";
                for (int i = num1; i <= num2; i++) {
                    suma += i.ToString();
                    //Console.WriteLine(" ");
                    Console.WriteLine(" " + suma);
                }
                        
            }

        }
    }
}
