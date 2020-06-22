namespace CouchDBClient.ModelEF
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

        public virtual DbSet<Cinema> Cinema { get; set; }
        public virtual DbSet<Film> Film { get; set; }
        public virtual DbSet<FilmShow> FilmShow { get; set; }
        public virtual DbSet<Person> Person { get; set; }
        public virtual DbSet<Ticket> Ticket { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cinema>()
                .Property(e => e.Street)
                .IsFixedLength();

            modelBuilder.Entity<Cinema>()
                .Property(e => e.City)
                .IsFixedLength();

            modelBuilder.Entity<Cinema>()
                .HasMany(e => e.FilmShow)
                .WithRequired(e => e.Cinema)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Film>()
                .Property(e => e.Title)
                .IsFixedLength();

            modelBuilder.Entity<Film>()
                .Property(e => e.FilmDescription)
                .IsUnicode(false);

            modelBuilder.Entity<Film>()
                .HasMany(e => e.FilmShow)
                .WithRequired(e => e.Film)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FilmShow>()
                .Property(e => e.HallName)
                .IsFixedLength();

            modelBuilder.Entity<FilmShow>()
                .HasMany(e => e.Ticket)
                .WithRequired(e => e.FilmShow)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Person>()
                .Property(e => e.FirstName)
                .IsFixedLength();

            modelBuilder.Entity<Person>()
                .Property(e => e.LastName)
                .IsFixedLength();

            modelBuilder.Entity<Person>()
                .HasMany(e => e.Ticket)
                .WithRequired(e => e.Person)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Ticket>()
                .Property(e => e.TicketType)
                .IsFixedLength();
        }
    }
}
