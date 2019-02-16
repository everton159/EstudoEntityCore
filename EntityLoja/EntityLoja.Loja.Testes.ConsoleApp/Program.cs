using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EntityLoja.Loja.Testes.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {


            using (var contexto = new LojaContext())
            {
                var promocao = new Promocao();
                promocao.Descricao = "Queima Total Janeiro 2017";
                promocao.DataInicio = new DateTime(2017, 1, 1);
                promocao.DataTermino = new DateTime(2017, 1, 31);

                var produtos = contexto
                    .Produtos
                   // .Where(p => p.Nome != "")
                    .ToList();

                foreach (var item in produtos)
                {
                    promocao.IncluiProduto(item);
                }

                contexto.Promocoes.Add(promocao);
               // ExibeEntries(contexto.ChangeTracker.Entries());
                contexto.SaveChanges();
            }

            using (var contexto2 = new LojaContext())
            {
                var promocao = contexto2.Promocoes.FirstOrDefault();
                Console.WriteLine("\nMotrando os produtos da promoção...");
                foreach (var item in promocao.Produtos)
                {
                    Console.WriteLine(item.Produto);
                }
            }


            Console.ReadKey();


        }

        private static void AdicionaPromocao()
        {
            using (var contexto = new LojaContext())
            {
                var promocao = new Promocao();
                promocao.Descricao = "Queima Total Janeiro 2017";
                promocao.DataInicio = new DateTime(2017, 1, 1);
                promocao.DataTermino = new DateTime(2017, 1, 31);

                var produtos = contexto
                    .Produtos
                    .Where(p => p.Categoria == "Bebidas")
                    .ToList();

                foreach (var item in produtos)
                {
                    promocao.IncluiProduto(item);
                }

                contexto.Promocoes.Add(promocao);
                // ExibeEntries(contexto.ChangeTracker.Entries());
                contexto.SaveChanges();
            }
        }

        private void UmparaUm()
        {
            var fulano = new Cliente();
            fulano.Nome = "Fulaninho de Tal";
            fulano.EnderecoDeEntrega = new Endereco()
            {
                Numero = 12,
                Logradouro = "Rua dos Inválidos",
                Complemento = "sobrado",
                Bairro = "Centro",
                Cidade = "Cidade"
            };

            using (var contexto = new LojaContext())
            {
                //var serviceProvider = contexto.GetInfrastructure<IServiceProvider>();
                //var loggerFactory = serviceProvider.GetService<ILoggerFactory>();
                //  loggerFactory.AddProvider(SqlLoggerProvider.Create());

                contexto.Clientes.Add(fulano);
                contexto.SaveChanges();
            }


        }





        private void MuitoparaMuitos()
        {
            var p1 = new Produto() { Nome = "Suco de Laranja", Categoria = "Bebidas", PrecoUnitario = 8.79, Unidade = 1 };
            var p2 = new Produto() { Nome = "Café", Categoria = "Bebidas", PrecoUnitario = 12.45, Unidade = 1 };
            var p3 = new Produto() { Nome = "Macarrão", Categoria = "Alimentos", PrecoUnitario = 4.23, Unidade = 1 };


            var promocaoDePascoa = new Promocao();
            promocaoDePascoa.Descricao = "Páscoa Feliz";
            promocaoDePascoa.DataInicio = DateTime.Now;
            promocaoDePascoa.DataTermino = DateTime.Now.AddMonths(3);

            promocaoDePascoa.IncluiProduto(p1);
            promocaoDePascoa.IncluiProduto(p2);
            promocaoDePascoa.IncluiProduto(p3);

            using (var contexto = new LojaContext())
            {
                // var serviceProvider = contexto.GetInfrastructure<IServiceProvider>();
                //var loggerFactory = serviceProvider.GetService<ILoggerFactory>();
                //loggerFactory.AddProvider(SqlLoggerProvider.Create());
                contexto.Promocoes.Add(promocaoDePascoa);
                contexto.SaveChanges();
            }


        }





        private static void atualizarProduto()
        {
            using (var contexto = new ProdutoDaoEntity())
            {
                Produto produto = contexto.Produtos()[0];
                produto.Nome = "Nome atualizado cuzão";
                contexto.Atualizar(produto);

            }
        }
        private static void excluirProdutos()
        {
            using (var contexto = new ProdutoDaoEntity())
            {
                IList<Produto> produtos = contexto.Produtos();

                foreach (var item in produtos)
                {
                    Console.WriteLine(item.Nome);
                    contexto.Remover(item)                        ;
                }


            }
        }

        private static void recuperaProdutos()
        {
            using (var contexto = new ProdutoDaoEntity())
            {
                IList<Produto> produtos = contexto.Produtos();
                foreach (var item in produtos)
                {
                    Console.Write(item.Nome);
                }

            }
        }

        private static void GravarUsandoEntity()
        {
            Produto p = new Produto();
            p.Nome = "Ordem das paradas";
            p.Categoria = "Livros";
            p.PrecoUnitario = 19.89;

            using (var contexto = new ProdutoDaoEntity())
            {
                //repo.Adicionar(p);
                contexto.Adicionar(p);
               
               
            }
        }

        
    }
}
