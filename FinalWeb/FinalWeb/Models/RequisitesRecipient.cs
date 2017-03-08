namespace FinalWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.RequisitesRecipient")]
    public partial class RequisitesRecipient
    {
        public string Pol { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long PolINN { get; set; }

        public long? PolKPP { get; set; }

        public double? PolSchet { get; set; }

        public int? PolBIK { get; set; }

        public int? PolKorSchet { get; set; }

        public string PolBank { get; set; }

        public int? PolKod { get; set; }

        public int? Index { get; set; }

        public long? OKATO { get; set; }

        public string PolType { get; set; }
    }
}
