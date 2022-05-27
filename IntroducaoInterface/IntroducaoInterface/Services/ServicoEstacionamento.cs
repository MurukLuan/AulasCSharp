using IntroducaoInterface.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace IntroducaoInterface.Services
{
    class ServicoEstacionamento
    {
        public double PrecoHora { get; private set; }
        public double PrecoDia { get; private set; }

        //private ImpostoEstacionamento ie = new ImpostoEstacionamento();
        private ITaxas _itaxas;
        public ServicoEstacionamento(double precoHora, double precoDia, ITaxas itaxas)
        {
            PrecoHora = precoHora;
            PrecoDia = precoDia;
            _itaxas = itaxas;
        }

        public void processarPagamento(Estacionado estacionado)
        {
            TimeSpan duracao = estacionado.Saida.Subtract(estacionado.Entrada);

            double pagamentoBase;

            if( duracao.TotalHours <= 3)
            {
               pagamentoBase = PrecoHora * Math.Round(duracao.TotalHours);
            }
            else
            {
                pagamentoBase = PrecoDia * Math.Round(duracao.TotalDays);
            }

            double taxa = _itaxas.ImpostoEst(pagamentoBase);
            //double taxa = ie.ImpostoEst(pagamentoBase);
            estacionado.Fatura = new Fatura(pagamentoBase, taxa);
        }
    }
}
