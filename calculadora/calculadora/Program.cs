using System;
namespace calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            //preguntar el valor del primer intervalo
            Console.Write("a: ");
            try
            {
                a = Int32.Parse(Console.ReadLine());
            }
            catch (Exception x)
            {
                Console.WriteLine("dato invalido" + x);
                Console.ReadKey();
                return;
                throw;
            }
           
            // preguntar el valor del segundo intervalo
            Console.Write("b: ");
            b = Int32.Parse(Console.ReadLine());
            //sumar intervalo
            c = a + b;
            Console.Write("la suma es" + c);
            Console.ReadKey();

        }
    }
}
