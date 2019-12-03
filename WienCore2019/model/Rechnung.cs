namespace WienCore2019
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
 
    [Table("Rechnung")]
    public partial class Rechnung
    {
        public int Id { get; set; }

        public int? KundenID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Datum { get; set; }

        public double? Summe { get; set; }
       virtual public ICollection<Positionen> Positionen { get; set; }
       
    }
}
