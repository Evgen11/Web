namespace FinalWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.City")]
    public partial class City
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int? Region_id { get; set; }

        public string Name_city { get; set; }

        public virtual Region Region { get; set; }
    }
}
