using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Clinic_DbModel.Models
{
    public partial class clinic_dbContext : IdentityDbContext<ApplicationUser>
    {
        public clinic_dbContext()
        {
        }

        public clinic_dbContext(DbContextOptions<clinic_dbContext> options)
            : base(options)
        {

        }

        public virtual DbSet<Appointment> Appointments { get; set; }
        public virtual DbSet<Blog> Blogs { get; set; }
        public virtual DbSet<Doctor> Doctors { get; set; }
        public virtual DbSet<Review> Reviews { get; set; }
        public virtual DbSet<Scheduletiming> Scheduletimings { get; set; }
        public virtual DbSet<Socialmediaurl> Socialmediaurls { get; set; }
        public virtual DbSet<Specialization> Specializations { get; set; }

   
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IdentityUserLogin<string>>().HasNoKey();
            modelBuilder.Entity<IdentityUserRole<string>>().HasNoKey();
            modelBuilder.Entity<IdentityUserToken<string>>().HasNoKey();


            modelBuilder.Entity<Appointment>(entity =>
            {
                entity.ToTable("appointment");

                entity.HasIndex(e => e.Id, "Id_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.DoctorId, "fk_appointment_doctor_idx");

                entity.HasIndex(e => e.UserId, "fk_appointment_user_idx");

                entity.Property(e => e.Day)
                    .IsRequired()
                    .HasMaxLength(45);

                entity.Property(e => e.DoctorId).HasColumnName("Doctor_Id");

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("tinyint")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.UserId).HasColumnName("User_Id");

                entity.HasOne(d => d.Doctor)
                    .WithMany(p => p.Appointments)
                    .HasForeignKey(d => d.DoctorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_appointment_doctor");

                entity.HasOne(d => d.ApplicationUser)
                    .WithMany(p => p.Appointments)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_appointment_patient");
            });

            modelBuilder.Entity<Blog>(entity =>
            {
                entity.ToTable("blog");

                entity.HasIndex(e => e.Id, "Id_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.DoctorId, "fk_blog_doctor_idx");

                entity.Property(e => e.Content);

                entity.Property(e => e.DoctorId).HasColumnName("Doctor_Id");

                entity.Property(e => e.Image).HasMaxLength(45);

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("tinyint")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Title).HasMaxLength(255);

                entity.HasOne(d => d.Doctor)
                    .WithMany(p => p.Blogs)
                    .HasForeignKey(d => d.DoctorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_blog_doctor");
            });


            modelBuilder.Entity<Doctor>(entity =>
            {
                entity.ToTable("doctor");

               
                entity.HasIndex(e => e.Id, "Id_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.SpecialtyId, "fk_doctor_specialty_idx");

                entity.Property(e => e.Address).HasMaxLength(255);


                entity.Property(e => e.College).HasMaxLength(255);

               
                entity.Property(e => e.Degree).HasMaxLength(255);

                entity.Property(e => e.DoctorServices).HasMaxLength(255);

                entity.Property(e => e.DoctorSpecialization).HasMaxLength(255);

                entity.Property(e => e.SpecialtyId).HasColumnName("Specialty_Id");


                entity.Property(e => e.YearOfCompletion).HasMaxLength(255);

                entity.HasOne(d => d.Specialty)
                    .WithMany(p => p.Doctors)
                    .HasForeignKey(d => d.SpecialtyId)
                    .HasConstraintName("fk_doctor_specialization");
            });


            modelBuilder.Entity<Review>(entity =>
            {
                entity.ToTable("review");

                entity.HasIndex(e => e.Id, "Id_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.UserId, "fk_review_user_idx");

                entity.Property(e => e.UserId).HasColumnName("User_Id");

                entity.HasOne(d => d.ApplicationUser)
                    .WithMany(p => p.Reviews)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_review_user");
            });

            modelBuilder.Entity<Scheduletiming>(entity =>
            {
                entity.ToTable("scheduletimings");

                entity.HasIndex(e => e.Id, "Id_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.DoctorId, "fk_scheduletiming_doctor_idx");

                entity.Property(e => e.Day).HasMaxLength(45);

                entity.Property(e => e.DoctorId).HasColumnName("Doctor_Id");

                entity.HasOne(d => d.Doctor)
                    .WithMany(p => p.Scheduletimings)
                    .HasForeignKey(d => d.DoctorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_scheduletiming_doctor");
            });

            modelBuilder.Entity<Socialmediaurl>(entity =>
            {
                entity.ToTable("socialmediaurl");

                entity.HasIndex(e => e.Id, "Id_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.DoctorId, "fk_socialmediaurl_doctor_idx");

                entity.Property(e => e.DoctorId).HasColumnName("Doctor_Id");

                entity.Property(e => e.FacebookUrl)
                    .HasMaxLength(255)
                    .HasColumnName("FacebookURL");

                entity.Property(e => e.InstagramUrl)
                    .HasMaxLength(255)
                    .HasColumnName("InstagramURL");

                entity.Property(e => e.LinkedInUrl)
                    .HasMaxLength(255)
                    .HasColumnName("LinkedInURL");

                entity.Property(e => e.TwitterUrl)
                    .HasMaxLength(255)
                    .HasColumnName("TwitterURL");

                entity.Property(e => e.WebsiteUrl)
                    .HasMaxLength(255)
                    .HasColumnName("WebsiteURL");

                entity.HasOne(d => d.Doctor)
                    .WithMany(p => p.Socialmediaurls)
                    .HasForeignKey(d => d.DoctorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_socialmediaurl_doctor");
            });

            modelBuilder.Entity<Specialization>(entity =>
            {
                entity.ToTable("specialization");

                entity.HasIndex(e => e.Id, "Id_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.IsDelete)
                    .HasColumnType("tinyint")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.SpecialtyName)
                    .IsRequired()
                    .HasMaxLength(45);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
