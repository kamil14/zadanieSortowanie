using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Osoba
    {
        [Key]
        public int Id_osoba { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public Plec Plec { get; set; }
        public int? Id_ojca { get; set; }
        public int? Id_matki { get; set; }
        public int Rok_urodzenia { get; set; }
    }
}
