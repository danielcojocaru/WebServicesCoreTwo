using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DataAccess.Models
{
    public partial class SchoolsAndCreatorContext : DbContext
    {
        public SchoolsAndCreatorContext(DbContextOptions<SchoolsAndCreatorContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Address> Address { get; set; }
        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserRoles> AspNetUserRoles { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<Chapter> Chapter { get; set; }
        public virtual DbSet<Code> Code { get; set; }
        public virtual DbSet<Company> Company { get; set; }
        public virtual DbSet<Country> Country { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<Address>(entity =>
            {
                entity.HasKey(e => e.IdAddress)
                    .HasName("PK_dbo.Address");

                entity.Property(e => e.City)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Fax)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Floor)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Interphone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneSecond)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Plz)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Street)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.StreetNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdCountryNavigation)
                    .WithMany(p => p.Address)
                    .HasForeignKey(d => d.IdCountry)
                    .HasConstraintName("FK_Address_Country");
            });

            modelBuilder.Entity<AspNetRoles>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasMaxLength(128)
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetUserRoles>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId })
                    .HasName("PK_dbo.AspNetUserRoles");

                entity.Property(e => e.UserId).HasMaxLength(128);

                entity.Property(e => e.RoleId).HasMaxLength(128);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_dbo.AspNetUserRoles_dbo.AspNetRoles_RoleId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.AspNetUserRoles_dbo.AspNetUsers_UserId");
            });

            modelBuilder.Entity<AspNetUsers>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasMaxLength(128)
                    .ValueGeneratedNever();

                entity.Property(e => e.DateTimeCreated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.IsApproved).HasDefaultValueSql("((0))");

                entity.Property(e => e.LastName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.LockoutEndDateUtc).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.HasOne(d => d.IdAddressNavigation)
                    .WithMany(p => p.AspNetUsers)
                    .HasForeignKey(d => d.IdAddress)
                    .HasConstraintName("FK_AspNetUsers_Address");

                entity.HasOne(d => d.IdCompanyNavigation)
                    .WithMany(p => p.AspNetUsers)
                    .HasForeignKey(d => d.IdCompany)
                    .HasConstraintName("FK_AspNetUsers_Company");

                entity.HasOne(d => d.IdCountryNavigation)
                    .WithMany(p => p.AspNetUsers)
                    .HasForeignKey(d => d.IdCountry)
                    .HasConstraintName("FK_AspNetUsers_Country");
            });

            modelBuilder.Entity<Chapter>(entity =>
            {
                entity.HasKey(e => e.IdChapter);

                entity.Property(e => e.IdChapter)
                    .HasMaxLength(20)
                    .ValueGeneratedNever();

                entity.Property(e => e.ChapterName)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ChapterShortName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Class)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Details)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.IdChapterParent).HasMaxLength(20);

                entity.HasOne(d => d.IdChapterParentNavigation)
                    .WithMany(p => p.InverseIdChapterParentNavigation)
                    .HasForeignKey(d => d.IdChapterParent)
                    .HasConstraintName("FK_Chapter_Chapter");
            });

            modelBuilder.Entity<Code>(entity =>
            {
                entity.HasKey(e => e.IdCode);

                entity.Property(e => e.Birthdate).HasColumnType("date");

                entity.Property(e => e.City)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Class)
                    .IsRequired()
                    .HasMaxLength(34)
                    .IsUnicode(false);

                entity.Property(e => e.DateTimeCreated).HasColumnType("datetime");

                entity.Property(e => e.DateTimeUpdated).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.EmailSent).HasColumnType("datetime");

                entity.Property(e => e.ExamDate).HasColumnType("date");

                entity.Property(e => e.ExpiringDate).HasColumnType("date");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.IdOwner)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.IdUser)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.LastName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Plz)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SelectedClass)
                    .IsRequired()
                    .HasMaxLength(34)
                    .IsUnicode(false);

                entity.Property(e => e.Street)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.StreetNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TheCode)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdOwnerNavigation)
                    .WithMany(p => p.CodeIdOwnerNavigation)
                    .HasForeignKey(d => d.IdOwner)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Code_AspNetUsersOwner");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.CodeIdUserNavigation)
                    .HasForeignKey(d => d.IdUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Code_AspNetUsersClient");
            });

            modelBuilder.Entity<Company>(entity =>
            {
                entity.HasKey(e => e.IdCompany)
                    .HasName("PK_dbo.Company");

                entity.Property(e => e.BackgroundPic)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Default/Road.jpg')");

                entity.Property(e => e.Color)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyName)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyShortName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.FoundedDate).HasColumnType("date");

                entity.Property(e => e.Layout)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('~/Views/Shared/_LayoutParticles.cshtml')");

                entity.Property(e => e.LogoPicPath)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.OpeningHours)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.SubdomainName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.WelcomeText).IsUnicode(false);

                entity.HasOne(d => d.IdAddressNavigation)
                    .WithMany(p => p.Company)
                    .HasForeignKey(d => d.IdAddress)
                    .HasConstraintName("FK_Company_Address");
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.HasKey(e => e.IdCountry)
                    .HasName("PK_dbo.Country");

                entity.Property(e => e.CountryName)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CountryShortName)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");
            });
        }
    }
}
