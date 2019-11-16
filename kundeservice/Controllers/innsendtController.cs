using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;


namespace kundeservice.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class innsendtController : Controller
    {
        private readonly KundeserviceContext _context;

        public innsendtController(KundeserviceContext context)
        {
            _context = context;
        }

        [HttpGet("[action]")]
        public List<dbsporsmal> HentSporsmal()
        {
            var listAns = _context.sporsmals.ToList();
            var returList = new List<dbsporsmal>();
            foreach (var spors in listAns)
            {
                var DBsporsmal = new dbsporsmal
                {
                    ID = spors.ID,
                    ask = spors.ask,
                    ans = spors.ans,
                    kat = spors.kat,
                    pRat = spors.pRat,
                    nRat = spors.nRat,
                };

                returList.Add(DBsporsmal);
            }

            return returList;
        }


    }
}
