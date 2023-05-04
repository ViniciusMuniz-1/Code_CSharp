using System;

namespace Boleto
{
    enum Pagamento{EmAberto, PagoParcial, Pago}

    class Boleto
    {
        private string codBarras;
        private DateTime dataEmissao, dataVencimento, dataPagto;
        private double valorBoleto, valorPago;
        private Pagamento situacaoPagamento;

        public Boleto(string cod, DateTime emissao, DateTime venc, double valor){
            this.codBarras = cod;
            this.dataEmissao = emissao;
            this.dataVencimento = venc;
            this.valorBoleto = valor;
            this.valorPago = 0;
            this.situacaoPagamento = EmAberto;

        }

        public void Pagar(double valorPago){
                this.valorPago = valorPago;
                this.dataPagto = DateTime.Now;
                if(valorPago < valorBoleto) this.situacaoPagamento = Pagamento.PagoParcial;
                else this.situacaoPagamento = Pagamento.Pago;
                valorBoleto-=valorPago;
            }
        }

        public Pagamento Situacao(){
            return situacaoPagamento;
        }

        public override string ToString(){
            return $"{codbarra} - Data de emissão: {dataEmissao:dd/MM/yyyy} - {dataVenc:dd/MM/yyyy} - {dataPagto:dd/MM/yyyy} - {valorBoleto:0.00} - {valorPago:0.00}"
        }

        static void Main(string[] args)
        {
            Boleto b = new Boleto("1234", DateTime.Parse("2023-05-01"), 
            DateTime.Parse("2023-05-15"), 248.43);
            Console.WriteLine(b);
            Console.WriteLine(b.Situacao());
            b.Pagar(100);
            Console.WriteLine(b);
            Console.WriteLine(b.Situacao());
        }
    }
}
