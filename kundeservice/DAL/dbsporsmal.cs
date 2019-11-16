using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace kundeservice
{
    public class dbsporsmal
    {
        [Key]
        public int ID { get; set; }
        public string ask { get; set; }
        public string ans { get; set; }
        public string kat { get; set; }
        public int pRat { get; set; }
        public int nRat { get; set; }
    }
}
