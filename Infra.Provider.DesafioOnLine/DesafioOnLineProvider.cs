using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;
using WebMotors.Domain.Interfaces.Provider;
using WebMotors.Domain.Entities;
using System.Net.Http;
using RestSharp;

namespace WebMotors.Infra.Provider.DesafioOnLine
{
    public class DesafioOnLineProvider : IProvider
    {
        private const string urlMarcas = "https://desafioonline.webmotors.com.br/api/OnlineChallenge/Make";
        private const string urlModelos = "https://desafioonline.webmotors.com.br/api/OnlineChallenge/Model?MakeID=";
        private const string urlVersoes = "https://desafioonline.webmotors.com.br/api/OnlineChallenge/Version?ModelID=";

        public IEnumerable<Marca> ObterMarcas()
        {
            var client = new RestClient(urlMarcas);
            client.Timeout = -1;

            var request = new RestRequest(Method.GET);

            request.AddHeader("Content-Type", "application/json");

            IRestResponse response = client.Execute(request);

            var retorno = System.Text.Json.JsonSerializer.Deserialize<List<Marca>>(response.Content);

            return retorno;
        }

        public IEnumerable<Modelo> ObterModelos(int id)
        {
            var client = new RestClient(urlModelos + id.ToString());
            client.Timeout = -1;

            var request = new RestRequest(Method.GET);

            request.AddHeader("Content-Type", "application/json");

            IRestResponse response = client.Execute(request);

            var retorno = System.Text.Json.JsonSerializer.Deserialize<List<Modelo>>(response.Content);

            return retorno;
        }

        public IEnumerable<Versao> ObterVersoes(int id)
        {
            var client = new RestClient(urlVersoes + id.ToString());
            client.Timeout = -1;

            var request = new RestRequest(Method.GET);

            request.AddHeader("Content-Type", "application/json");

            IRestResponse response = client.Execute(request);

            var retorno = System.Text.Json.JsonSerializer.Deserialize<List<Versao>>(response.Content);

            return retorno;
        }
    }
}