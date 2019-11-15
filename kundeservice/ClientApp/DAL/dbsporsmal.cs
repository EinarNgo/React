using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace kundeservice
{
    public class dbsporsmal
    {
        [Key]
        public int ID { get; set; }
        public string Navn { get; set; }
        public string Spors { get; set; }
        public string Svar { get; set; }
    }
}
