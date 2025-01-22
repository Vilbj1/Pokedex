using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PokemonApi.Models
{
    public class PokeLista
    {
        [JsonProperty("count")]
        public long Quantidade { get; set; }
        
        [JsonProperty("next")]
        public string Proximo {  get; set; }
        
        [JsonProperty("previous")]
        public object Anterior { get; set; }
        
        [JsonProperty("results")]
        public List<Pokemon> ListaPokemons { get; set; }
    }
}
