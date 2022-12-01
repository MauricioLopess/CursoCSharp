using System.Globalization;

namespace ExerciciosIntPOO
{
    public class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public override string ToString()
        {
            return "Nome: " + Nome + ", Valor: R$ " + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", Quantidade: " + Quantidade + ", valor total no estoque: R$ "+ ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quantity)
        {
            Quantidade += quantity;
        }

        public void RemoverProdutos(int quantity)
        {
            Quantidade -= quantity;
        }
        /*
        */
    }
}
