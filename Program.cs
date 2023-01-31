using System;
namespace Bucles
{
    class Program
    {

        static void Main(string[] args)
        {
            //EJERCICIO 1 While
            Console.WriteLine("Introduce un numero para saber su tabla");
            int num1 = int.Parse(Console.ReadLine());
            int i = 0;
            int resultado;
            Console.WriteLine("La tabla del {0}", num1);
            while (i <= 10)
            {
                resultado = num1 * i;
                Console.WriteLine(num1 + "x" + i + "=" + resultado);
                i++;
            }


            //EJERCICIO 2 Do...While
            Console.WriteLine("Introduce un nuevo numero, positivo o negativo");
            int number = int.Parse(Console.ReadLine());
            if (number < 0)
            {
                Console.WriteLine("Es negativo");
            }
            else
            {
                Console.WriteLine("Es positivo");
            }

            do
            {
                if (number < 0)
                {
                    Console.WriteLine(number + " ");
                    number++;
                }
                else if (number > 0)
                {
                    Console.WriteLine(number + " ");
                    number--;
                };

            } while (number != 0);


            //EJERCIO 3 For
            Console.WriteLine("introduce el alto ");
            int alto = int.Parse(Console.ReadLine());
            
            Console.WriteLine("introduce el ancho ");
            int ancho = int.Parse(Console.ReadLine());
            
            int k, j;
            
            for (k = 1; k <= alto; k++)
            {
                for (j = 1; j <= ancho; j++)
                    Console.Write("*", j);
                Console.WriteLine(" ");
            }
        }

    }

}

