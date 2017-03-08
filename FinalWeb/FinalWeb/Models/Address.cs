namespace FinalWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.Address")]
    public partial class Address
    {
        public int Id { get; set; }

        public string Locality { get; set; }

        [Required]
        public string Street { get; set; }

        public int House { get; set; }

        public int Housing { get; set; }

        public int? Apartment { get; set; }

        public int Postcode { get; set; }

        

    }
}
