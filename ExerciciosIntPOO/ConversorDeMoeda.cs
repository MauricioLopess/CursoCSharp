using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosIntPOO
{
    public class ConversorDeMoeda
    {
        /*
        ex 04 
        Faça um programa para ler a cotação do dólar, e depois um valor em dólares a ser comprado por
        uma pessoa em reais. Informar quantos reais a pessoa vai pagar pelos dólares, considerando ainda
        que a pessoa terá que pagar 6% de IOF sobre o valor em dólar. Criar uma classe ConversorDeMoeda
        para ser responsável pelos cálculos.
        -- refazer --
         */
        public static double Iof = 6.0;

        public static double ConveterDpR(double cotacao, double dolarCompra)
        {
            double total = cotacao * dolarCompra;
            return total + (total * Iof / 100);
        }

    }
}
