namespace FinalWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.RequisitesPayer")]
    public partial class RequisitesPayer
    {
        public int Id { get; set; }

        public int Tax_user { get; set; }

        [Required]
        [StringLength(250)]
        public string Surname_user { get; set; }

        [Required]
        [StringLength(30)]
        public string TypeFace_user { get; set; }

        public int? ReqNumber { get; set; }
    }
}
