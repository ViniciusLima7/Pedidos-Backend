using System;
using System.Collections.Generic;
using System.Text;
using EXERCICIO01___ENUMERAÇÃO_E_COMPOSIÇÃO.Entities.Enums;
using System.Globalization;

namespace EXERCICIO01___ENUMERAÇÃO_E_COMPOSIÇÃO.Entities
{
    class Pedido
    {
        public DateTime Momento { get; set; }
        public OrderStatus Status { get; set; }

        public Cliente Cliente { get; set; }

        public List<ItemPedido> Items { get; set; } = new List<ItemPedido>();

        public Pedido()
        {
        }

        public Pedido(DateTime momento, OrderStatus status, Cliente cliente)
        {
            Momento = momento;
            Status = status;
            Cliente = cliente;
        }

        public void AdicionarItem(ItemPedido item)
        {
            Items.Add(item);
        }

        public void RemoverItem(ItemPedido item)
        {
            Items.Remove(item);

        }

        public double Total()
        {
            double total = 0;
            foreach (ItemPedido item in Items)
            {
                total = total + item.SubTotal();

            }
            return total;
        }

        public override string ToString()
        {

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Resumo do Pedido");
            sb.AppendLine("Momento do Pedido: " + Momento);
            sb.AppendLine("Status do Pedido: " + Status);
            sb.AppendLine("Cliente: " + Cliente.Nome + " " + Cliente.DataNascimento + " - " + Cliente.Email);
            sb.AppendLine("Itens do Pedido: ");
            foreach (ItemPedido item in Items)
            {
                sb.AppendLine(item.Produto.NomeProduto + ",  $" + item.Preco.ToString("F2", CultureInfo.InvariantCulture) + 
                    ", Quantidade: " +item.Quantidade + ", Subtotal: $" + item.SubTotal().ToString("F2" , CultureInfo.InvariantCulture));
            }

            sb.AppendLine("PREÇO TOTAL: $" + Total().ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();
        }
    }
}
