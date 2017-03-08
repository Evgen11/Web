namespace FinalWeb.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class FinalDBContext : DbContext
    {
        public FinalDBContext()
            : base("name=FinalDBContext")
        {
        }

        public virtual DbSet<Address> Addresses { get; set; }
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<Region> Regions { get; set; }
        public virtual DbSet<Registration> Registrations { get; set; }
        public virtual DbSet<RequisitesPayer> RequisitesPayers { get; set; }
        public virtual DbSet<RequisitesReceiptOne> RequisitesReceiptOnes { get; set; }
        public virtual DbSet<RequisitesReceiptTwo> RequisitesReceiptTwoes { get; set; }
        public virtual DbSet<RequisitesRecipient> RequisitesRecipients { get; set; }
        public virtual DbSet<Test_RegCit> Test_ReqCitys { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
