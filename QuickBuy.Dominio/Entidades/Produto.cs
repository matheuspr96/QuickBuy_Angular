using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Dominio.Entidades
{
    public class Produto : Entidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }

        public override void Validate()
        {
            LimparMensagemValidacao();
            if (string.IsNullOrEmpty(Nome))
                AdicionarCritica("Nome não informado");
            if (string.IsNullOrEmpty(Nome))
                AdicionarCritica("Descricao não informada");
            if (string.IsNullOrEmpty(Nome))
                AdicionarCritica("Preco não informado");

        }
    }
}
