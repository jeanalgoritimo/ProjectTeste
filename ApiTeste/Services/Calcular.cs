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
            var porcentagem = returnTabelaImposto(meses);

            List<Calculo> calculos = new List<Calculo>();
            Calculo calculo = new Calculo();
            calculo.ValorBruto = "75";
            calculo.ValorLiquido = "68";
            calculos.Add(calculo);

            return calculos;
        }

        private string returnTabelaImposto(string faixaImposto)
        {
            string porcentagemImposto = "";

            int faixaImpostoInt =Convert.ToInt32(faixaImposto);
            if (faixaImpostoInt <= 6)
            {
                porcentagemImposto = "22,5";
            }
            else if (faixaImpostoInt <= 12)
            {
                porcentagemImposto = "20";
            }
            else if (faixaImpostoInt <= 24)
            {
                porcentagemImposto = "17,5";
            }
            else if (faixaImpostoInt > 24)
            {
                porcentagemImposto = "15";
            }


            return porcentagemImposto;
        }
    }
}