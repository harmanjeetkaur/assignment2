namespace Assignment1Furniture.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Assignment1FurnitureModel : DbContext
    {
        public Assignment1FurnitureModel()
            : base("name=DefaultConnection")
        {
        }

        public virtual DbSet<table1furniture> table1furniture { get; set; }
        public virtual DbSet<table2furniture> table2furniture { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<table1furniture>()
                .Property(e => e.Brand)
                .IsUnicode(false);

            modelBuilder.Entity<table1furniture>()
                .Property(e => e.RoomColor)
                .IsUnicode(false);

            modelBuilder.Entity<table2furniture>()
                .Property(e => e.Brand)
                .IsUnicode(false);

            modelBuilder.Entity<table2furniture>()
                .Property(e => e.Furniture_type)
                .IsUnicode(false);

            modelBuilder.Entity<table2furniture>()
                .Property(e => e.FloorTiles)
                .IsUnicode(false);
        }
    }
}
