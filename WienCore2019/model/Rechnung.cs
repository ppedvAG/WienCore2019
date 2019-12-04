namespace WienCore2019
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
 
    [Table("Rechnung")]
    public partial class Rechnung
    {
        public Rechnung()
        {
            Positionen = new List<Positionen>();
        }

        public int Id { get; set; }
        [Display(Name = "Kunden ID")]

        public int? KundenID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Datum { get; set; }

        public double? Summe { get; set; }
       virtual public ICollection<Positionen> Positionen { get; set; }
       
    }
}
