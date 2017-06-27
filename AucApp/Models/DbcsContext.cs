namespace AucApp.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DbcsContext : DbContext
    {
        public DbcsContext()
            : base("name=DbcsContext")
        {
        }

        public virtual DbSet<bidData> bidDatas { get; set; }
        public virtual DbSet<product> products { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<product>()
                .HasMany(e => e.bidDatas)
                .WithRequired(e => e.product)
                .HasForeignKey(e => e.prod_id)
                .WillCascadeOnDelete(false);
        }

        public System.Data.Entity.DbSet<AucApp.Models.categories> categories { get; set; }
    }
}
