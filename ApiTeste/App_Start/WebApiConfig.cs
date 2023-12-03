//using Microsoft.AspNetCore.Cors;
//using System;
//using System.Collections.Generic;

//using System.Linq;
using Swashbuckle.Application;
using System.Web.Http;
using System.Web.Http.Cors;

namespace ApiTeste
{
    public static class WebApiConfig
    {
        public static void Register(System.Web.Http.HttpConfiguration config)
        {
            // Configuração e serviços de API Web

            var cors = new EnableCorsAttribute("http://localhost:9646", "*", "*");
            config.EnableCors(cors); 



            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
