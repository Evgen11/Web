namespace FinalWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.Registration")]
    public partial class Registration
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string User_login { get; set; }

        [Required]
        [StringLength(50)]
        public string User_password { get; set; }

        public string User_hash { get; set; }

        public bool? User_confirm_login { get; set; }

        [StringLength(50)]
        public string User_comfirm_password { get; set; }
    }
}
