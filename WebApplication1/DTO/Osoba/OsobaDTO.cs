using WebApplication1.Models;

namespace WebApplication1.DTO.Osoba
{
    public class OsobaDTO
    {
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public Plec Plec { get; set; }
        public int? Id_ojca { get; set; }
        public int? Id_matki { get; set; }
        public int Rok_urodzenia { get; set; }
    }
}
