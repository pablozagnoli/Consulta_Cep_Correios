using Consulta_Cep_Correios.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;


namespace Consulta_Cep_Correios.Services
{
    class Request
    {
        public static void Request_Cep()
        {
            try
            {

               

                var vClient = new HttpClient();
                vClient.BaseAddress = new Uri("https://buscacepinter.correios.com.br");

                var vDict = new Dictionary<string, string>();
                vDict.Add("Content-Type", "application/x-www-form-urlencoded");
                vDict.Add("pagina", "/app/endereco/index.php");
                vDict.Add("cepaux", "");
                vDict.Add("mensagem_alerta", "");
                vDict.Add("endereco", "");
                vDict.Add("tipoCEP", "ALL");

                var vResult = vClient.PostAsync("/app/endereco/carrega-cep-endereco.php", new FormUrlEncodedContent(vDict)).Result;

                var vResulStr = vResult.Content.ReadAsStringAsync().Result;
                var vResponseJsonDesserialized = JsonConvert.DeserializeObject<Models_Response_Cep>(vResulStr.ToString());

                Console.WriteLine("Os dados do CEP Solcitado são:");

                Console.WriteLine(vResponseJsonDesserialized.Dados[0].cep);
                Console.WriteLine(vResponseJsonDesserialized.Dados[0].logradouroTexto);
                Console.WriteLine(vResponseJsonDesserialized.Dados[0].numeroLocalidade);
                Console.WriteLine(vResponseJsonDesserialized.Dados[0].localidade);
                Console.WriteLine(vResponseJsonDesserialized.Dados[0].bairro);
                Console.WriteLine(vResponseJsonDesserialized.Dados[0].uf);
                Console.WriteLine("-----------------------------------------------------------------");
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERRO");
                Console.WriteLine(ex.Message.ToString());
            }
        }
    }
}
