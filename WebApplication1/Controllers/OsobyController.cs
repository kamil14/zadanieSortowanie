using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using WebApplication1.Data;
using WebApplication1.DTO;
using WebApplication1.DTO.Osoba;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OsobyController : ControllerBase
    {
        private readonly AppDbContext _context;

        public OsobyController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> UtworzOsoby(List<OsobaDTO> osoby)
        {

            _context.Osoba.AddRange(osoby.Select(x => new Osoba
            {
                Id_matki = x.Id_matki,
                Id_ojca = x.Id_ojca,
                Imie = x.Imie,
                Nazwisko = x.Nazwisko,
                Plec = x.Plec,
                Rok_urodzenia = x.Rok_urodzenia,

            }).ToList());

            await _context.SaveChangesAsync();

            return Ok(osoby);
        }

        [HttpGet]
        public async Task<IActionResult> NapelnijNowyModel()
        {
            var modelPunktTrzeciCzwarty = new ModelPunktTrzeciCzwarty()
            {
                NowyModelPogrupowanyPoNazwisku = new object(),
                NowyModelPosortowanyPoImieniu = new List<NowyModelPosortowanyPoImieniu>() { }

            };
            var nowyModelPosortowanyPoImieniu = _context.Osoba
                .OrderBy(x => x.Imie)
                .Select(x => new NowyModelPosortowanyPoImieniu
                {
                    Imie = x.Imie,
                    Nazwisko = x.Nazwisko
                })
                .ToList();
            modelPunktTrzeciCzwarty.NowyModelPosortowanyPoImieniu = nowyModelPosortowanyPoImieniu;

            var nowyModelPogrupowanyPoNazwisku = nowyModelPosortowanyPoImieniu
                .GroupBy(x => x.Nazwisko);

            modelPunktTrzeciCzwarty.NowyModelPogrupowanyPoNazwisku = nowyModelPogrupowanyPoNazwisku;

            return Ok(modelPunktTrzeciCzwarty);
        }
    }
}
