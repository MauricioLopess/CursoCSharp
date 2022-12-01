using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosVetor
{
    /*
     ex 02
    Fazer um programa para ler um número inteiro N e os dados (nome e
    preço) de N Produtos. Armazene os N produtos em um vetor. Em
    seguida, mostrar o preço médio dos produtos.
    */
    internal class Produto
    {
        public string Nome { get; private set; }
        public double Preco { get; private set; }

        
        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }
    }
}
