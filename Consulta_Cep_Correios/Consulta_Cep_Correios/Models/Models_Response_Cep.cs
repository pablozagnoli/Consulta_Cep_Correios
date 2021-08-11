using System.Collections.Generic;

namespace Consulta_Cep_Correios.Models
{
    class Models_Response_Cep
    {
        public List<Dadoscep> Dados { get; set; }
    }
    class Dadoscep 
    {
        public string uf { get; set; }
        public string localidade { get; set; }
        public string locNoSem { get; set; }
        public string locNu { get; set; }
        public string localidadeSubordinada { get; set; }
        public string logradouroDNEC { get; set; }
        public string logradouroTextoAdicional { get; set; }
        public string logradouroTexto { get; set; }
        public string bairro { get; set; }
        public string baiNu { get; set; }
        public string nomeUnidade { get; set; }
        public string cep { get; set; }
        public string tipoCep { get; set; }
        public string numeroLocalidade { get; set; }
        public string situacao { get; set; }
    }
}
