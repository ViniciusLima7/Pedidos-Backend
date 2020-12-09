using System;
using EXERCICIO01___ENUMERAÇÃO_E_COMPOSIÇÃO.Entities;
using EXERCICIO01___ENUMERAÇÃO_E_COMPOSIÇÃO.Entities.Enums;
using System.Globalization;

namespace EXERCICIO01___ENUMERAÇÃO_E_COMPOSIÇÃO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite os dados do Cliente");
            Console.Write("Nome: ");
            string name = Console.ReadLine();

            Console.Write("Email: ");
            string email = Console.ReadLine();

            Console.Write("Data de Nascimento: (DD/MM/AAAA) ");
            DateTime nascimento = DateTime.Parse(Console.ReadLine());

            Cliente c1 = new Cliente(name, email, nascimento);
            Console.WriteLine("Digite os dados do Pedido");
            Console.Write("Status do pedido: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Console.Write("Quantos items tem esse pedido? ");
            int n = int.Parse(Console.ReadLine());
            Pedido p1 = new Pedido();
            p1 = new Pedido(DateTime.Now, status, c1);

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Digite os dados do " + i + " item");
                Console.Write("Nome do Produto: ");
                string nomeProduto = Console.ReadLine();
                Console.Write("Preço do Produto: ");
                double precoProduto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantidade: ");
                int qtd = int.Parse(Console.ReadLine());

                
                Produto prod = new Produto(nomeProduto, precoProduto);
                ItemPedido itemPedido = new ItemPedido(qtd, precoProduto,prod);
                p1.AdicionarItem(itemPedido);
                //Console.WriteLine(p1);
;               


            }

            Console.WriteLine(p1);


        }
    }
}
