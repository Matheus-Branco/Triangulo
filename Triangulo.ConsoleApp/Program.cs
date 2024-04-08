using System.Diagnostics;

namespace Triangulo.ConsoleApp
{
    internal class Program
    {
        public static class Triangulo
        {
            public static decimal lado1;
            public static decimal lado2;
            public static decimal lado3;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Informe por favor os 3 lados do triângulo e informaremos qual tipo ele pertence:");
            Triangulo.lado1 = Convert.ToDecimal(Console.ReadLine());
            Triangulo.lado2 = Convert.ToDecimal(Console.ReadLine());
            Triangulo.lado3 = Convert.ToDecimal(Console.ReadLine());

            TrianguloEquilatero();

            TrianguloIsoceles();

            TrianguloEscaleno();
        }

        private static void TrianguloEquilatero()
        {
            if (Triangulo.lado1 == Triangulo.lado2 && Triangulo.lado2 == Triangulo.lado3)
            {
                Console.WriteLine("Este é um triângulo Equilátero");
            }
        }

        private static void TrianguloIsoceles()
        {
            if (Triangulo.lado1 == Triangulo.lado2 && Triangulo.lado2 != Triangulo.lado3 || Triangulo.lado1 != Triangulo.lado2 && Triangulo.lado2 == Triangulo.lado3 || Triangulo.lado1 != Triangulo.lado3 && Triangulo.lado2 == Triangulo.lado3)
            {
                Console.WriteLine("Este é um triângulo Isóceles");
            }
        }

        private static void TrianguloEscaleno()
        {
            if (Triangulo.lado1 != Triangulo.lado2 && Triangulo.lado2 != Triangulo.lado3 && Triangulo.lado1 != Triangulo.lado3)
            {
                Console.WriteLine("Este é um triângulo Escaleno");
            }
        }
    }
}
