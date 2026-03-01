namespace JSON_Filmy.Models
{
    public class Film
    {
        // Názvy vlastností musí přesně odpovídat klíčům v JSON souboru
        public int id { get; set; }
        public string nazev { get; set; }
        public int rokVydani { get; set; }
        public string reziser { get; set; }
    }
}
