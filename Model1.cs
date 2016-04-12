namespace Delivery
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<AGENT> AGENTs { get; set; }
        public virtual DbSet<IBE_LOG_TABLES> IBE_LOG_TABLES { get; set; }
        public virtual DbSet<LOG_FILE> LOG_FILE { get; set; }
        public virtual DbSet<OPERATION> OPERATIONs { get; set; }
        public virtual DbSet<TOVAR> TOVARs { get; set; }
        public virtual DbSet<TOVAR_WH> TOVAR_WH { get; set; }
        public virtual DbSet<WAREHOUSE> WAREHOUSEs { get; set; }
        public virtual DbSet<IBE_LOG_BLOB_FIELDS> IBE_LOG_BLOB_FIELDS { get; set; }
        public virtual DbSet<IBE_LOG_FIELDS> IBE_LOG_FIELDS { get; set; }
        public virtual DbSet<IBE_LOG_KEYS> IBE_LOG_KEYS { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AGENT>()
                .Property(e => e.ID_AG)
                .IsFixedLength();

            modelBuilder.Entity<AGENT>()
                .Property(e => e.NAME_AG)
                .IsFixedLength();

            modelBuilder.Entity<AGENT>()
                .Property(e => e.TOWN)
                .IsFixedLength();

            modelBuilder.Entity<AGENT>()
                .Property(e => e.PHONE)
                .IsFixedLength();

            modelBuilder.Entity<AGENT>()
                .HasMany(e => e.OPERATIONs)
                .WithRequired(e => e.AGENT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<IBE_LOG_TABLES>()
                .Property(e => e.ID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<LOG_FILE>()
                .Property(e => e.INFORM)
                .IsFixedLength();

            modelBuilder.Entity<OPERATION>()
                .Property(e => e.ID_TOVAR)
                .IsFixedLength();

            modelBuilder.Entity<OPERATION>()
                .Property(e => e.ID_AG)
                .IsFixedLength();

            modelBuilder.Entity<OPERATION>()
                .Property(e => e.ID_WH)
                .IsFixedLength();

            modelBuilder.Entity<OPERATION>()
                .Property(e => e.TYPEOP)
                .IsFixedLength();

            modelBuilder.Entity<OPERATION>()
                .Property(e => e.KOL)
                .HasPrecision(15, 2);

            modelBuilder.Entity<OPERATION>()
                .Property(e => e.PRICE)
                .HasPrecision(15, 2);

            modelBuilder.Entity<TOVAR>()
                .Property(e => e.ID_TOVAR)
                .IsFixedLength();

            modelBuilder.Entity<TOVAR>()
                .Property(e => e.NOMENCLATURE)
                .IsFixedLength();

            modelBuilder.Entity<TOVAR>()
                .Property(e => e.E_IZM)
                .IsFixedLength();

            modelBuilder.Entity<TOVAR>()
                .HasMany(e => e.OPERATIONs)
                .WithRequired(e => e.TOVAR)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TOVAR>()
                .HasMany(e => e.TOVAR_WH)
                .WithRequired(e => e.TOVAR)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TOVAR_WH>()
                .Property(e => e.ID_WH)
                .IsFixedLength();

            modelBuilder.Entity<TOVAR_WH>()
                .Property(e => e.ID_TOVAR)
                .IsFixedLength();

            modelBuilder.Entity<TOVAR_WH>()
                .Property(e => e.KOL)
                .HasPrecision(15, 2);

            modelBuilder.Entity<WAREHOUSE>()
                .Property(e => e.ID_WH)
                .IsFixedLength();

            modelBuilder.Entity<WAREHOUSE>()
                .Property(e => e.NAIMEN)
                .IsFixedLength();

            modelBuilder.Entity<WAREHOUSE>()
                .Property(e => e.TOWN)
                .IsFixedLength();

            modelBuilder.Entity<WAREHOUSE>()
                .HasMany(e => e.OPERATIONs)
                .WithRequired(e => e.WAREHOUSE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<WAREHOUSE>()
                .HasMany(e => e.TOVAR_WH)
                .WithRequired(e => e.WAREHOUSE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<IBE_LOG_BLOB_FIELDS>()
                .Property(e => e.LOG_TABLES_ID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<IBE_LOG_FIELDS>()
                .Property(e => e.LOG_TABLES_ID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<IBE_LOG_KEYS>()
                .Property(e => e.LOG_TABLES_ID)
                .HasPrecision(18, 0);
        }
    }
}
