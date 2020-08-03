﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuickBuy.Dominio.ObjetoDeValor;

namespace QuickBuy.Dominio.Entidades
{
    public class Pedido : Entidade
    {
        public int Id { get; set; }
        public DateTime DataPedido { get; set; }
        public int UsuarioId { get; set; }
        public DateTime DataPrevisaoEntrega { get; set; }
        public string Cep { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string EnderecoCompleto { get; set; }
        public int NumeroEndereco { get; set; }
        public int FormaPagamentoId { get; set; }
        public FormaPagamento FormaPagamento { get; set; }
        /// <summary>
        /// Pedido deve ter pelo menos um pedido
        /// ou muitos pedidos
        /// </summary>
        public ICollection<ItemPedido> ItensPedidos { get; set; }

        public override void Validate()
        {
            LimparMensagensValidacao();
            if(ItensPedidos.Any())
                AdicionarCritica("Critica - Pedido não pode ficar sem item de pedido");

            if(string.IsNullOrEmpty(Cep))
                AdicionarCritica("Critica - Ne necessário fornecer um CEP");
        }
    }
}
