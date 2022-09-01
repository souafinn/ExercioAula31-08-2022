using System;

namespace AulaQuinta
{
    class Program
    {
        static void Main(string[] args)
        {
            // Informe 10 numeros e separe em 2 listas de inteiro, onde lsta 1 contenha somente numeros pares, e lista 2 somente numeros impares 

            int[] numeros = new int[10];
            int[] pares = new int[10];
            int[] impares = new int[10];


            {
                Console.WriteLine("Informe 10 numeros");
                numeros[0] = int.Parse(Console.ReadLine()); 

               

            }
            for (int i = 0; i < 10; i++)

               


            {

                if (numeros[i] % 2 == 0)
                {
                   
                    Console.WriteLine("Esse numero é par");
                    pares[0] = int.Parse(Console.ReadLine());


                }

                else

                
                Console.WriteLine("Esse numero é impar");
                impares[0] = int.Parse(Console.ReadLine());



            }
            
            
        }
    }
}
