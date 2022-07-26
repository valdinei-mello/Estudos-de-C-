

namespace Produto_Estoque
{
    internal class Estoque
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double VAlorTotalEstoque()
        {
            return this.Quantidade * this.Preco;

        }

        public void AdicionarProduto(int qtde)
        {
            this.Quantidade+= qtde;
        }

        public void RemoverProduto(int qtde)
        {
            this.Quantidade-= qtde;
        }

        public override string ToString()
        {
            return base.ToString();
        }

    }
}
