using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace HHclientmanager.Models
{
    public partial class ClientManager1Context : DbContext
    {
        public ClientManager1Context()
        {
        }

        public ClientManager1Context(DbContextOptions<ClientManager1Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Cfar> Cfar { get; set; }
        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<Pcl> Pcl { get; set; }
        public virtual DbSet<Ppsr> Ppsr { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=ClientManager1;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cfar>(entity =>
            {
                entity.Property(e => e.EmotionalityIndex).HasColumnName("Emotionality Index");

                entity.Property(e => e.TraumaticStress).HasColumnName("Traumatic_Stress");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.Cfar)
                    .HasForeignKey(d => d.ClientId)
                    .HasConstraintName("FK_Post_Client_ClientId2");
            });

            modelBuilder.Entity<Client>(entity =>
            {
                entity.Property(e => e.AdvocateName).HasColumnName("Advocate_Name");

                entity.Property(e => e.DateEnrolled)
                    .HasColumnName("Date_Enrolled")
                    .HasColumnType("date");

                entity.Property(e => e.Dob).HasColumnType("date");

                entity.Property(e => e.ExitDate)
                    .HasColumnName("Exit_Date")
                    .HasColumnType("date");

                entity.Property(e => e.PartnerGender).HasColumnName("Partner_Gender");

                entity.Property(e => e.RelationshipStatus).HasColumnName("Relationship_Status");
            });

            modelBuilder.Entity<Pcl>(entity =>
            {
                entity.Property(e => e.SeverityScore).HasColumnName("Severity_Score");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.Pcl)
                    .HasForeignKey(d => d.ClientId)
                    .HasConstraintName("FK_Post_Client_ClientId");
            });

            modelBuilder.Entity<Ppsr>(entity =>
            {
                entity.HasOne(d => d.Client)
                    .WithMany(p => p.Ppsr)
                    .HasForeignKey(d => d.ClientId);
            });
        }
    }
}
