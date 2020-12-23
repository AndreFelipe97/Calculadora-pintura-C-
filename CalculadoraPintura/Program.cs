using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraPintura
{
    class Program : Calculadora
    {
        static void Main(string[] args)
        {
            double largura, profundidade;
            const double Altura = 2.9;
            const double Rendimento = 10;

            Calculadora calculadora = new Calculadora();

            Console.WriteLine("Digite a largura");
            largura = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a profundidade");
            profundidade = double.Parse(Console.ReadLine());
            Console.WriteLine("Área das paredes");
            Console.WriteLine(calculadora.CalcularAreaParedes(largura, profundidade, Altura));
            Console.WriteLine("Área do teto");
            Console.WriteLine(calculadora.CalcularAreaTeto(largura, profundidade));
            Console.WriteLine("A litragem de tinta necessária é:");
            Console.WriteLine(calculadora.CalcularRendimento(Rendimento));
            Console.ReadKey();
        }
    }
}
