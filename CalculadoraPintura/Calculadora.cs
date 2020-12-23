using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraPintura
{
    class Calculadora
    {
        private double areaParedes, areaTeto, rendimentoTinta;

        public double CalcularAreaParedes(double largura, double profundidade, double altura)
        {
            areaParedes = 2 * (largura + profundidade) * altura;
            return areaParedes;
        }

        public double CalcularAreaTeto(double largura, double profundidade)
        {
            areaTeto = largura * profundidade;
            return areaTeto;
        }

        public double CalcularRendimento(double rendimento)
        {
            if (areaParedes == 0 && areaTeto == 0)
            {
                Console.WriteLine("Não é possivel calcular a litragem com os valores informados");
                Console.ReadKey();
                Environment.Exit(1);
            }
            rendimentoTinta = (areaParedes + areaTeto) / rendimento;
            return rendimentoTinta;
        }
    }
}
