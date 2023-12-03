using ApiTeste.Interface;
using ApiTeste.Models;
using ApiTeste.Services;
using Microsoft.AspNetCore.Cors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using Unity;

namespace ApiTeste.Controllers
{
    [System.Web.Http.Cors.EnableCors(origins: "http://localhost:9646", headers: "*", methods: "*")]
    public class CalculoController : ApiController
    {
        
        [DisableCors]
        public IEnumerable<Calculo> Post([FromBody] ParamtrosCalculo paramtrosCalculo)
        {
            Calcular calcular =new Calcular();
            return calcular.CalcularParametros(paramtrosCalculo.ValorInicial, paramtrosCalculo.Prazo);
        }


    }

    
}
