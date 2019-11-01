using System;
namespace Example{
  class Progra{
       static void Main(string[] args){
             int iter = 98;int num;int primo; Random rand = new Random();
            for (int i = 0; i < iter; i++)
            {
                primo = 0;
                num = rand.Next(10, 200);
                for (int j = 2; j < num; j++)
                {
                    if (num % j == 0)
                    {
                        primo++;
                    }
                }
                if (primo == 0){
                    
                    Console.Write("#" + num + "# "); 
                }
                if (num % 5 == 0){

                    Console.Write("[" + num + "] ");
                }
                if (primo > 0 && num % 5 != 0)
                {
                    Console.Write(num + " ");
                }
             }
        }
    }
}
