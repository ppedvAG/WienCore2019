namespace WienCore2019
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Positionen")]
    public partial class Positionen
    {
        public int Id { get; set; }

        public int RechnungID { get; set; }

        public int? Anzahl { get; set; }

        [StringLength(50)]
        public string Text { get; set; }

        public double? Preis { get; set; }
        virtual public Rechnung Rechnung { get; set; }
    }
}
