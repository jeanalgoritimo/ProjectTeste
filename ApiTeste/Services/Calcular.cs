using ApiTeste.Interface;
using ApiTeste.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using System.Web;

namespace ApiTeste.Services
{
    public class Calcular
    {
        public List<Calculo> CalcularParametros(string valorInicial, string meses)
        {
            List<Calculo> calculos = new List<Calculo>();
            Calculo calculo = new Calculo();

            if ((!string.IsNullOrEmpty(valorInicial) && !string.IsNullOrEmpty(meses)))
            {
                calculo.ValorBruto = CalculoValorFinal(valorInicial, meses);
                calculo.ValorLiquido = CalculoValorLiquido(valorInicial, calculo.ValorBruto);

                calculos.Add(calculo);
            }
            else
            {
                calculos = new List<Calculo>();
            }
         
            return calculos;
        }
        private double CalculoValorFinal(string valorInicial, string meses)
        {
            double meuValor = 0;
            meuValor = Math.Round(Convert.ToDouble(valorInicial), 2);
            var porcentagem = returnTabelaImposto(meses);
            var TBI_CDI = 1.08 * 0.009;
            var TBI_CDI_Imposto = porcentagem + TBI_CDI;
            var ImpostoFinal = meuValor * TBI_CDI_Imposto;
            var ValorFinal = meuValor + ImpostoFinal;

            return Math.Round(Convert.ToDouble(ValorFinal), 2);
        }
        private double CalculoValorLiquido(string valorbruto, double valorInvestido)
        {
            double meuValor = 0;
            meuValor = Math.Round(Convert.ToDouble(valorbruto), 2);
            var ValorFinal = valorInvestido - meuValor;

            return Math.Round(Convert.ToDouble(ValorFinal), 2);
        }
        private double returnTabelaImposto(string faixaImposto)
        {
            double porcentagemImposto = 0;

            int faixaImpostoInt = Convert.ToInt32(faixaImposto);
            if (faixaImpostoInt <= 6)
            {
                porcentagemImposto = 0.225;
            }
            else if (faixaImpostoInt <= 12)
            {
                porcentagemImposto = 0.2;
            }
            else if (faixaImpostoInt <= 24)
            {
                porcentagemImposto = 0.175;
            }
            else if (faixaImpostoInt > 24)
            {
                porcentagemImposto = 0.15;
            }


            return porcentagemImposto;
        }
    }
}