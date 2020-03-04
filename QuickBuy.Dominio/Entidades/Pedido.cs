using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Dominio.Entidades
{
    public class Pedido
    {
        public int Id { get; set; }
        public DateTime DataPedido { get; set; }
        public DateTime DataPrevisaoEntraga { get; set; }
        public int UsuarioId { get; set; }

        public string CEP { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string Endereco { get; set; }
        public string NumeroEndereco { get; set; }
        public int FormaPagementoId { get; set; }
        public FormaPagamento FormaPagamento { get; set; }
        public ICollection<ItemPedido> ItensPedido { get; set; }

    }
}
