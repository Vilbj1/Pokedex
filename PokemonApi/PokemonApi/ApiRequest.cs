using Newtonsoft.Json;
using PokemonApi.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace PokemonApi
{
    public class ApiRequest
    {
        public string url {  get; set; }
        private int actual = 494;
        
        public ApiRequest()
        {
            url = "https://pokeapi.co/api/v2/pokemon?limit=10&offset=";
        }

        public PokeLista ObterLista()
        {
            var consulta = (HttpWebRequest)WebRequest.Create(url + actual);
            consulta.Method = "GET";
            consulta.ContentType = "application/json";
            consulta.Accept = "application/json";

            try
            {
                using (WebResponse response = consulta.GetResponse())
                {
                    using (Stream stream = response.GetResponseStream())                      
                    {
                        if (stream == null)
                        {
                            return null;
                        }
                        using (StreamReader leitor = new StreamReader(stream))
                        {
                            string responseTexto = leitor.ReadToEnd();
                            PokeLista pokelista = JsonConvert.DeserializeObject<PokeLista>(responseTexto);
                            actual += 10;

                            return pokelista;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }

        }
    }
}
