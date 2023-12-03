using ApiTeste.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiTeste.Interface
{
    public interface ICalcular
    {
        List<Calculo> CalcularParametros(string valorInicial, string meses);
    }
}
