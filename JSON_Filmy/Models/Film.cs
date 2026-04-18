using System.Text.Json.Serialization;
namespace JSON_Filmy.Models
{
    public class Film
    {
        // Vlastnosti dodržují C# konvence a jsou namapovány na JSON klíče
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("nazev")]
        public string Nazev { get; set; }

        [JsonPropertyName("rokVydani")]
        public int RokVydani { get; set; }

        [JsonPropertyName("reziser")]
        public string Reziser { get; set; }

    }
}
