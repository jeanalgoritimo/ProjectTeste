using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1
{
    public class Calcular
    {
        private double TBI = 1.08;
        private double CDI = 0.009;
        private double TBI_CDI = 0.0;
        private double TBI_CDI_Imposto = 0.0;
        private double valorInicial_Imposto = 0.0;
        private double ImpostoFinal = 0.0;
        public List<Calculo> CalcularParametros(string valorInicial, string meses)
        {
            List<Calculo> calculos = new List<Calculo>();
            Calculo calculo = new Calculo();
            calculo.ValorBruto = valorInicial;
            calculo.ValorLiquido = CalculoValorLiquido(valorInicial, meses);
            calculos.Add(calculo);

            return calculos;
        }
        private double CalculoValorLiquido(string valorInicial, string meses)
        {
            double meuValor = 0;

            meuValor = Math.Round(Convert.ToDouble(valorInicial), 2);
            var porcentagem = returnTabelaImposto(meses);

            TBI_CDI = TBI * CDI;
            TBI_CDI_Imposto = porcentagem + TBI_CDI;
            valorInicial_Imposto = Convert.ToDouble(valorInicial);

            ImpostoFinal = meuValor * TBI_CDI_Imposto;
            var ValorLiquido = meuValor + ImpostoFinal;

            return Math.Round(Convert.ToDouble(ValorLiquido), 2);
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
