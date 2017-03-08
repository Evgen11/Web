

namespace FinalWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    [Table("public.Test_RegCit")]
    public partial class Test_RegCit
    {
        public string Region_user { get; set; }
        public string City_user { get; set; }
        public int Id { get; set; }
    }
}