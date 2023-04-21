using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace WebApplication5.Model
{
    public partial class WebsitePhongTroContext : DbContext
    {
        public WebsitePhongTroContext()
        {
        }

        public WebsitePhongTroContext(DbContextOptions<WebsitePhongTroContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Phongtro> Phongtros { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Userdatphong> Userdatphongs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-NNCH2H2\\CSDL;Database=WebsitePhongTro;Integrated Security=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Phongtro>(entity =>
            {
                entity.HasKey(e => e.Maphong);

                entity.ToTable("phongtro");

                entity.Property(e => e.Maphong).HasColumnName("maphong");

                entity.Property(e => e.Conphong).HasColumnName("conphong");

                entity.Property(e => e.Diachi).HasColumnName("diachi");

                entity.Property(e => e.Dientich).HasColumnName("dientich");

                entity.Property(e => e.Gia).HasColumnName("gia");

                entity.Property(e => e.Guixe).HasColumnName("guixe");

                entity.Property(e => e.Hinhanh1)
                    .HasColumnType("text")
                    .HasColumnName("hinhanh1");

                entity.Property(e => e.Hinhanh2)
                    .HasColumnType("text")
                    .HasColumnName("hinhanh2");

                entity.Property(e => e.Hinhanh3)
                    .HasColumnType("text")
                    .HasColumnName("hinhanh3");

                entity.Property(e => e.Loai)
                    .HasMaxLength(50)
                    .HasColumnName("loai");

                entity.Property(e => e.Maylanh).HasColumnName("maylanh");

                entity.Property(e => e.Mota)
                    .HasColumnType("text")
                    .HasColumnName("mota");

                entity.Property(e => e.Nhatam).HasColumnName("nhatam");

                entity.Property(e => e.Phongngu).HasColumnName("phongngu");

                entity.Property(e => e.Wifi).HasColumnName("wifi");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.Mauser);

                entity.ToTable("user");

                entity.Property(e => e.Mauser).HasColumnName("mauser");

                entity.Property(e => e.Anhdaidien)
                    .HasColumnType("text")
                    .HasColumnName("anhdaidien");

                entity.Property(e => e.Diachiuser).HasColumnName("diachiuser");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .HasColumnName("email");

                entity.Property(e => e.Password)
                    .HasMaxLength(10)
                    .HasColumnName("password");

                entity.Property(e => e.Quyenhan)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("quyenhan")
                    .IsFixedLength(true);

                entity.Property(e => e.Sodienthoai)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("sodienthoai")
                    .IsFixedLength(true);

                entity.Property(e => e.Tenuser)
                    .HasMaxLength(50)
                    .HasColumnName("tenuser");
            });

            modelBuilder.Entity<Userdatphong>(entity =>
            {
                entity.HasKey(e => new { e.Maphong, e.Mauser });

                entity.ToTable("userdatphong");

                entity.Property(e => e.Maphong).HasColumnName("maphong");

                entity.Property(e => e.Mauser).HasColumnName("mauser");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .HasColumnName("email");

                entity.Property(e => e.Sodienthoai)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("sodienthoai")
                    .IsFixedLength(true);

                entity.Property(e => e.Tenuser)
                    .HasMaxLength(50)
                    .HasColumnName("tenuser");

                entity.HasOne(d => d.MaphongNavigation)
                    .WithMany(p => p.Userdatphongs)
                    .HasForeignKey(d => d.Maphong)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_userdatphong_phongtro");

                entity.HasOne(d => d.MauserNavigation)
                    .WithMany(p => p.Userdatphongs)
                    .HasForeignKey(d => d.Mauser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_userdatphong_user");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
