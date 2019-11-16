using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace kundeservice
{

    public class KundeserviceContext : DbContext
    {

        public KundeserviceContext(DbContextOptions<KundeserviceContext> options) : base(options)
        {
        }

        public DbSet<dbsporsmal> sporsmals { get; set; }
        public DbSet<dbinnsendt> innsendt { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<dbsporsmal>().ToTable("dbsporsmal").HasData(new dbsporsmal[]
            {
                new dbsporsmal {
                    ID = 1,
                    ask = "Hvordan kan jeg endre eller avbestille billetten?",
                    ans = "For å endre billetten din, må du først avbestille den og så kjøpe ny billett til avgangen du skal reise med.",
                    kat = "Billett",
                    pRat = 0,
                    nRat = 0,
                },
                new dbsporsmal {
                    ID = 2,
                    ask = "Toget mitt var forsinket – hvilken erstatning har jeg krav på og hvordan søker jeg om dette?",
                    ans = "Du kan ikke kreve refusjon av billettprisen dersom du ble varslet om forsinkelser på 30 minutter/én time før billetten ble kjøpt.",
                    kat = "Refundering",
                    pRat = 0,
                    nRat = 0,
                },
                new dbsporsmal {
                    ID = 3,
                    ask = "Kan jeg få erstatning for merkostnader ved forsinkelse?",
                    ans = "I situasjoner der du må ta i bruk alternativ transport eller får andre utgifter i forbindelse med forsinkelse eller kansellering av tog, kan du få refundert hele eller deler av utleggene. Dette må gjøres skriftlig med vedlagt dokumentasjon innen tre måneder etter hendelsen.",
                    kat = "Refundering",
                    pRat = 0,
                    nRat = 0,
                },
                new dbsporsmal {
                    ID = 4,
                    ask = "Jeg har fått kontrollgebyr på toget– hvordan klager jeg på denne?",
                    ans = "Ta kontakt med oss dersom du mener at du urettmessig har fått et kontrollgebyr, eller om du vil utsette betalingen av et gebyr. Du har 14 dagers klagerett fra utstedelsesdato.",
                    kat = "Refundering",
                    pRat = 0,
                    nRat = 0,
                },
                new dbsporsmal {
                    ID = 5,
                    ask = "Jeg rakk ikke toget. Kan jeg få refundert billetten?",
                    ans = "Alle billetter må refunderes før avgang, du vil ikke ha krav på refusjon etter togavgangen dersom du ikke rekker toget ditt.",
                    kat = "Refundering",
                    pRat = 0,
                    nRat = 0,
                },
                new dbsporsmal {
                    ID = 6,
                    ask = "Hvordan endrer jeg betalingskortet tilknyttet Vy-profilen min?",
                    ans = "Du kan slette og legge til betalingskort ved å logge inn på vy.no og gå til «Min profil». I appen går du til «Profil», så velger du «Betaling».",
                    kat = "Billett",
                    pRat = 0,
                    nRat = 0,
                },

            }); 

        }
    }
}
