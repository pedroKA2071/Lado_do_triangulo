using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace att6_dia_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float lado1, lado2, lado3;





            Console.WriteLine("informe o primeiro lado do triangulo: ");
            lado1 = float.Parse(Console.ReadLine());



            Console.WriteLine("informe o segundo lado do triangulo: ");
            lado2 = float.Parse(Console.ReadLine());



            Console.WriteLine("informe o terceiro lado do triangulo: ");
            lado3 = float.Parse(Console.ReadLine());





            if (lado1 == lado2 && lado1 == lado3)
            {
                Console.WriteLine("este triangulo eh equilatero");
            }
            else if (lado1 == lado2 || lado2 == lado3 || lado3 == lado1)
            {
                Console.WriteLine("este triangulo eh isoceles");
            }
            else
            {
                Console.WriteLine("este triangulo eh escaleno");
            }









            Console.ReadKey();
        }
    }
}