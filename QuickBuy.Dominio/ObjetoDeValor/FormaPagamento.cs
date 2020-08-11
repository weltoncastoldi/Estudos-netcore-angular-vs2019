using System;
using System.Collections.Generic;
using System.Text;
using QuickBuy.Dominio.Enumerados;

namespace QuickBuy.Dominio.ObjetoDeValor
{
    public class FormaPagamento
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string  Descricao { get; set; }
        public bool EhBoleto => Id == (int) TipoFormaPagamentoEnum.Boleto;
        public bool EhCartaoCredito => Id == (int) TipoFormaPagamentoEnum.CartaCredito;
        public bool EhDeposito => Id == (int)TipoFormaPagamentoEnum.Deposito;
        public bool NaoFoiDefino => Id == (int)TipoFormaPagamentoEnum.NaoDefinido;
    }
}
