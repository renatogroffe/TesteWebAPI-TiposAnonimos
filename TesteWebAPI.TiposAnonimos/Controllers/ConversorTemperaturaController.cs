using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TesteWebAPI.TiposAnonimos.Controllers
{
    public class ConversorTemperaturaController : ApiController
    {
        public object Get(double grausCelsius)
        {
            if (grausCelsius < -273.15)
            {
                var resp = new HttpResponseMessage(HttpStatusCode.BadRequest)
                {
                    Content = new StringContent("Erro de processamento"),
                    ReasonPhrase = "Temperatura inferior a -273.15 graus Celsius."
                };

                throw new HttpResponseException(resp);
            }
            return new
            {
                Celsius = grausCelsius,
                Fahrenheit = ((9.0 / 5.0) * grausCelsius) + 32,
                Kelvin = grausCelsius + 273.15
            };
        }
    }
}