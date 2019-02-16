using System.Collections.Generic;

namespace EntityLoja.Loja.Testes.ConsoleApp
{
    public class Produto
    {
        public int Id { get; internal set; }
        public string Nome { get; internal set; }
        public string Categoria { get; internal set; }
        public double PrecoUnitario { get; internal set; }
        public double Unidade { get; internal set; }
        public string Descricao { get; internal set; }
        public IList<PromocaoProduto> Promocoes { get; set; }


        public override string ToString()
        {
            return ($"Id:{Id} Nome{Nome} Categoria{Categoria} Descricao{Descricao} Preco{PrecoUnitario}");
        }

    }
}