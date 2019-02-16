namespace EntityLoja.Loja.Testes.ConsoleApp
{
    internal class Compra
    {
       
        public int Id { get; internal set; }
        public Produto produto { get; internal set; }
        public int ProdutoID { get; internal set; }
        public int quantidade { get; internal set; }
        public double preco { get; internal set; }
    }
}