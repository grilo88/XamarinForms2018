using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using App01_ConsultarCEP.Servico.Modelo;

namespace App01_ConsultarCEP
{
    public class ViaCEPServico
    {
        private static string EnderecoURL = "http://viacep.com.br/ws/{0}/json/";

        public static Endereco BuscarEnderecoViaCEP(string cep)
        {
            string NovoEnderecoURL = string.Format(EnderecoURL, cep);

            WebClient wc = new WebClient();
            string Conteudo = wc.DownloadString(NovoEnderecoURL);

            Endereco end = Newtonsoft.Json.JsonConvert.DeserializeObject<Endereco>(Conteudo);

            return end;
        }
    }
}
