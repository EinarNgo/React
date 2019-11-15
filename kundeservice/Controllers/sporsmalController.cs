using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;



namespace kundeservice.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class sporsmalController : Controller
    {
        private readonly KundeserviceContext _context;

        public sporsmalController(KundeserviceContext context)
        {
            _context = context;
        }

        [HttpGet("[action]")]
        public List<dbsporsmal> HentSporsmal()
        {
            var listSporsmal = _context.sporsmals.ToList();
            var returListe = new List<dbsporsmal>();
            foreach (var sporsmal in listSporsmal)
            {
                var DBsporsmal = new dbsporsmal();

                DBsporsmal.ID = sporsmal.ID;
                DBsporsmal.Navn = sporsmal.Navn;
                DBsporsmal.Spors = sporsmal.Spors;
                DBsporsmal.Svar = sporsmal.Svar;

                returListe.Add(DBsporsmal);
            }

            return returListe;
        }


    }
}
