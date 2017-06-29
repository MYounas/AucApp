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
        public virtual DbSet<category> categories { get; set; }
        public virtual DbSet<product> products { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<category>()
                .HasMany(e => e.products)
                .WithRequired(e => e.category)
                .HasForeignKey(e => e.Cid)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<product>()
                .HasMany(e => e.bidDatas)
                .WithRequired(e => e.product)
                .HasForeignKey(e => e.prod_id)
                .WillCascadeOnDelete(false);
        }
    }
}
