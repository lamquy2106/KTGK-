namespace KTGK2.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class PhoneContext : DbContext
    {
        public PhoneContext()
            : base("name=PhoneContext")
        {
        }

        public virtual DbSet<phone> phones { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<phone>()
                .Property(e => e.price)
                .HasPrecision(18, 0);

            modelBuilder.Entity<phone>()
                .Property(e => e.gerenal_note)
                .IsFixedLength();
        }
    }
}
