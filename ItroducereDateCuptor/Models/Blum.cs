using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ItroducereDateCuptor
{
    public class Blum
    {
        public int Id { get; set; }
        public int Diametru { get; set; }
        [MaxLength(8)]
        public string Sarja { get; set; }
        [MaxLength(2)]
        public string Furnizor { get; set; }
        [MaxLength(10)]
        public string Calitate { get; set; }
        [DisplayName("Dat afara")]
        public bool IsDatAfara { get; set; }
        [DisplayName("Retur")]
        public bool IsRetur { get; set; }
        public bool IsRebut { get; set; }
        [DisplayName("Ora data afara")]
        public string DataOraLaminare { get; set; }
    }
}
