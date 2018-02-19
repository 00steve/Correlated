namespace Maintain.Objects
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Correlated : DbContext
    {
        public Correlated()
            : base("name=Correlated")
        {
        }

        public virtual DbSet<DCategory> Categories { get; set; }
        public virtual DbSet<Date> Dates { get; set; }
        public virtual DbSet<Point> Points { get; set; }
        public virtual DbSet<Unit> Units { get; set; }
        public virtual DbSet<MCategory> Category1 { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Measure> Measures { get; set; }
        public virtual DbSet<MeasureCategory> MeasureCategories { get; set; }
        public virtual DbSet<Region> Regions { get; set; }
        public virtual DbSet<Source> Sources { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DCategory>()
                .Property(e => e.CategoryID)
                .HasPrecision(20, 0);

            modelBuilder.Entity<DCategory>()
                .Property(e => e.CategoryName)
                .IsUnicode(false);

            modelBuilder.Entity<DCategory>()
                .HasMany(e => e.Units)
                .WithRequired(e => e.Category)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Date>()
                .Property(e => e.DateID)
                .HasPrecision(20, 0);

            modelBuilder.Entity<Date>()
                .Property(e => e.DT)
                .HasPrecision(0);

            modelBuilder.Entity<Date>()
                .HasMany(e => e.Points)
                .WithRequired(e => e.Date)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Point>()
                .Property(e => e.PointID)
                .HasPrecision(30, 0);

            modelBuilder.Entity<Point>()
                .Property(e => e.DateID)
                .HasPrecision(20, 0);

            modelBuilder.Entity<Point>()
                .Property(e => e.NValue)
                .HasPrecision(38, 15);

            modelBuilder.Entity<Point>()
                .Property(e => e.SValue)
                .IsUnicode(false);

            modelBuilder.Entity<Unit>()
                .Property(e => e.UnitID)
                .HasPrecision(20, 0);

            modelBuilder.Entity<Unit>()
                .Property(e => e.CategoryID)
                .HasPrecision(20, 0);

            modelBuilder.Entity<Unit>()
                .Property(e => e.UnitName)
                .IsUnicode(false);

            modelBuilder.Entity<Unit>()
                .Property(e => e.UnitDescription)
                .IsUnicode(false);

            modelBuilder.Entity<Unit>()
                .HasMany(e => e.Measures)
                .WithRequired(e => e.Unit)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MCategory>()
                .Property(e => e.CategoryID)
                .HasPrecision(20, 0);

            modelBuilder.Entity<MCategory>()
                .Property(e => e.CategoryName)
                .IsUnicode(false);

            modelBuilder.Entity<MCategory>()
                .HasMany(e => e.Measures)
                .WithRequired(e => e.Category1)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MCategory>()
                .HasMany(e => e.MeasureCategories)
                .WithRequired(e => e.Category1)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Country>()
                .Property(e => e.CountryID)
                .HasPrecision(20, 0);

            modelBuilder.Entity<Country>()
                .Property(e => e.CurrentRegionID)
                .HasPrecision(20, 0);

            modelBuilder.Entity<Country>()
                .Property(e => e.CountryName)
                .IsUnicode(false);

            modelBuilder.Entity<Measure>()
                .Property(e => e.MeasureID)
                .HasPrecision(20, 0);

            modelBuilder.Entity<Measure>()
                .Property(e => e.UnitID)
                .HasPrecision(20, 0);

            modelBuilder.Entity<Measure>()
                .Property(e => e.CategoryID)
                .HasPrecision(20, 0);

            modelBuilder.Entity<Measure>()
                .Property(e => e.RegionID)
                .HasPrecision(20, 0);

            modelBuilder.Entity<Measure>()
                .Property(e => e.CountryID)
                .HasPrecision(20, 0);

            modelBuilder.Entity<Measure>()
                .Property(e => e.MeasureName)
                .IsUnicode(false);

            modelBuilder.Entity<Measure>()
                .Property(e => e.MeasureDescription)
                .IsUnicode(false);

            modelBuilder.Entity<Measure>()
                .HasMany(e => e.MeasureCategories)
                .WithRequired(e => e.Measure)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Measure>()
                .HasMany(e => e.Sources)
                .WithRequired(e => e.Measure)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MeasureCategory>()
                .Property(e => e.MeasureCategoryID)
                .HasPrecision(20, 0);

            modelBuilder.Entity<MeasureCategory>()
                .Property(e => e.MeasureID)
                .HasPrecision(20, 0);

            modelBuilder.Entity<MeasureCategory>()
                .Property(e => e.CategoryID)
                .HasPrecision(20, 0);

            modelBuilder.Entity<Region>()
                .Property(e => e.RegionID)
                .HasPrecision(20, 0);

            modelBuilder.Entity<Region>()
                .Property(e => e.RegionName)
                .IsUnicode(false);

            modelBuilder.Entity<Source>()
                .Property(e => e.SourceID)
                .HasPrecision(20, 0);

            modelBuilder.Entity<Source>()
                .Property(e => e.MeasureID)
                .HasPrecision(20, 0);

            modelBuilder.Entity<Source>()
                .Property(e => e.SourceName)
                .IsUnicode(false);

            modelBuilder.Entity<Source>()
                .Property(e => e.SourceDescription)
                .IsUnicode(false);

            modelBuilder.Entity<Source>()
                .Property(e => e.SourceURL)
                .IsUnicode(false);
        }
    }
}
