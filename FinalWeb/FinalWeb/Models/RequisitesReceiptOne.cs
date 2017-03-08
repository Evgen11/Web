namespace FinalWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.RequisitesReceiptOne")]
    public partial class RequisitesReceiptOne
    {
        public string KBK { get; set; }

        public int? Index { get; set; }

        public string Name { get; set; }

        public int Id { get; set; }
    }
}
