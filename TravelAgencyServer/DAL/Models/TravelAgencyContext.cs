using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace DAL.Models
{
    public partial class TravelAgencyContext : DbContext
    {
        public TravelAgencyContext()
        {
        }

        public TravelAgencyContext(DbContextOptions<TravelAgencyContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Airline> Airlines { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Credit> Credits { get; set; }
        public virtual DbSet<Flight> Flights { get; set; }
        public virtual DbSet<FlightDetail> FlightDetails { get; set; }
        public virtual DbSet<Message> Messages { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Update> Updates { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=TravelAgency;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Airline>(entity =>
            {
                entity.Property(e => e.AirlineId).HasColumnName("airlineId");

                entity.Property(e => e.AirlineName)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("airlineName");
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.Property(e => e.CountryId).HasColumnName("countryId");

                entity.Property(e => e.CountryName)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("countryName");
            });

            modelBuilder.Entity<Credit>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__Credits__CB9A1CFF8D689814");

                entity.Property(e => e.UserId)
                    .ValueGeneratedNever()
                    .HasColumnName("userId");

                entity.Property(e => e.CreditNum).HasColumnName("creditNum");

                entity.Property(e => e.Cvv).HasColumnName("cvv");

                entity.Property(e => e.Month).HasColumnName("month");

                entity.Property(e => e.Year).HasColumnName("year");

                entity.HasOne(d => d.User)
                    .WithOne(p => p.Credit)
                    .HasForeignKey<Credit>(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Credits__userId__59063A47");
            });

            modelBuilder.Entity<Flight>(entity =>
            {
                entity.Property(e => e.AirlineId).HasColumnName("airlineId");

                entity.Property(e => e.CountryId).HasColumnName("countryId");

                entity.Property(e => e.DepartureDate)
                    .HasColumnType("date")
                    .HasColumnName("departureDate");

                entity.Property(e => e.Image)
                    .HasColumnType("text")
                    .HasColumnName("image");

                entity.Property(e => e.NumPassengers).HasColumnName("numPassengers");

                entity.Property(e => e.NumSeats).HasColumnName("numSeats");

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.ReturnDate)
                    .HasColumnType("date")
                    .HasColumnName("returnDate");

                entity.Property(e => e.Update)
                    .HasMaxLength(50)
                    .HasColumnName("update");

                entity.HasOne(d => d.Airline)
                    .WithMany(p => p.Flights)
                    .HasForeignKey(d => d.AirlineId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Flights__airline__4E88ABD4");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.Flights)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Flights__country__4F7CD00D");
            });

            modelBuilder.Entity<FlightDetail>(entity =>
            {
                entity.HasKey(e => e.OrderId)
                    .HasName("PK__FlightDe__0809335D7A02AEF7");

                entity.Property(e => e.OrderId).HasColumnName("orderId");

                entity.Property(e => e.FlightId).HasColumnName("flightId");

                entity.Property(e => e.UserId).HasColumnName("userId");

                entity.HasOne(d => d.Flight)
                    .WithMany(p => p.FlightDetails)
                    .HasForeignKey(d => d.FlightId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__FlightDet__fligh__5535A963");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.FlightDetails)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__FlightDet__userI__5629CD9C");
            });

            modelBuilder.Entity<Message>(entity =>
            {
                entity.Property(e => e.Answer)
                    .HasMaxLength(200)
                    .HasColumnName("answer");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("email");

                entity.Property(e => e.Message1)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("message");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("name");

                entity.Property(e => e.Subject)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("subject");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.Property(e => e.RoleId).HasColumnName("roleId");

                entity.Property(e => e.RoleName)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("roleName");
            });

            modelBuilder.Entity<Update>(entity =>
            {
                entity.Property(e => e.Update1)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("update");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Advertisements).HasColumnName("advertisements");

                entity.Property(e => e.Email)
                    .HasMaxLength(20)
                    .HasColumnName("email");

                entity.Property(e => e.Name)
                    .HasMaxLength(20)
                    .HasColumnName("name");

                entity.Property(e => e.Password)
                    .HasMaxLength(14)
                    .HasColumnName("password");

                entity.Property(e => e.RoleId).HasColumnName("roleId");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Users__roleId__52593CB8");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
