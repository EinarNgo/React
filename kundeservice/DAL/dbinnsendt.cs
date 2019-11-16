using System;
using System.ComponentModel.DataAnnotations;

namespace kundeservice
{
    public class dbinnsendt
    {
            [Key]
            public int IID { get; set; }
            public string epost { get; set; }
            public string ask { get; set; }
            
    }
}
