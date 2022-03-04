using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebAPI.Models.DataBase
{
    public partial class MovieDBContext : DbContext
    {
        public MovieDBContext()
        {
        }

        public MovieDBContext(DbContextOptions<MovieDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BinhLuan> BinhLuan { get; set; }
        public virtual DbSet<ChatLuong> ChatLuong { get; set; }
        public virtual DbSet<DanhGia> DanhGia { get; set; }
        public virtual DbSet<DanhMuc> DanhMuc { get; set; }
        public virtual DbSet<DaoDien> DaoDien { get; set; }
        public virtual DbSet<HangSanXuat> HangSanXuat { get; set; }
        public virtual DbSet<NguoiDung> NguoiDung { get; set; }
        public virtual DbSet<Phim> Phim { get; set; }
        public virtual DbSet<PhimBinhLuan> PhimBinhLuan { get; set; }
        public virtual DbSet<PhimDanhGia> PhimDanhGia { get; set; }
        public virtual DbSet<PhimDanhMuc> PhimDanhMuc { get; set; }
        public virtual DbSet<PhimDaoDien> PhimDaoDien { get; set; }
        public virtual DbSet<PhimHangSanXuat> PhimHangSanXuat { get; set; }
        public virtual DbSet<PhimTap> PhimTap { get; set; }
        public virtual DbSet<Tap> Tap { get; set; }
        public virtual DbSet<TapBinhLuan> TapBinhLuan { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=MovieDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BinhLuan>(entity =>
            {
                entity.Property(e => e.BinhLuanId)
                    .HasColumnName("BinhLuanID")
                    .ValueGeneratedNever();

                entity.Property(e => e.NguoiDungId).HasColumnName("NguoiDungID");

                entity.Property(e => e.NoiDung)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.ThoiGianKhoiTao).HasColumnType("datetime");

                entity.HasOne(d => d.NguoiDung)
                    .WithMany(p => p.BinhLuan)
                    .HasForeignKey(d => d.NguoiDungId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("NguoiDung_BinhLuan");
            });

            modelBuilder.Entity<ChatLuong>(entity =>
            {
                entity.Property(e => e.ChatLuongId)
                    .HasColumnName("ChatLuongID")
                    .ValueGeneratedNever();

                entity.Property(e => e.TenChatLuong)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<DanhGia>(entity =>
            {
                entity.Property(e => e.DanhGiaId)
                    .HasColumnName("DanhGiaID")
                    .ValueGeneratedNever();

                entity.Property(e => e.NoiDung).HasMaxLength(1000);
            });

            modelBuilder.Entity<DanhMuc>(entity =>
            {
                entity.Property(e => e.DanhMucId)
                    .HasColumnName("DanhMucID")
                    .ValueGeneratedNever();

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.TenDanhMuc)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UuTienHienThi).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<DaoDien>(entity =>
            {
                entity.Property(e => e.DaoDienId)
                    .HasColumnName("DaoDienID")
                    .ValueGeneratedNever();

                entity.Property(e => e.TenDaoDien)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<HangSanXuat>(entity =>
            {
                entity.Property(e => e.HangSanXuatId)
                    .HasColumnName("HangSanXuatID")
                    .ValueGeneratedNever();

                entity.Property(e => e.TenHangSanXuat)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<NguoiDung>(entity =>
            {
                entity.Property(e => e.NguoiDungId)
                    .HasColumnName("NguoiDungID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.HoVaTen)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MatKhau)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TenDangNhap)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TrangThaiHoatDong)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('Y')");
            });

            modelBuilder.Entity<Phim>(entity =>
            {
                entity.Property(e => e.PhimId)
                    .HasColumnName("PhimID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ChatLuongId).HasColumnName("ChatLuongID");

                entity.Property(e => e.DuongDanAnhBia).HasMaxLength(500);

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.MoTa).HasMaxLength(1000);

                entity.Property(e => e.SoTap).HasDefaultValueSql("((1))");

                entity.Property(e => e.TenPhim)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.ThoiGianKhoiTao).HasColumnType("datetime");

                entity.Property(e => e.UuTienHienThi).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.ChatLuong)
                    .WithMany(p => p.Phim)
                    .HasForeignKey(d => d.ChatLuongId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ChatLuong_Phim");
            });

            modelBuilder.Entity<PhimBinhLuan>(entity =>
            {
                entity.HasIndex(e => e.BinhLuanId)
                    .HasName("CC_PhimBinhLuan_BinhLuanID")
                    .IsUnique();

                entity.Property(e => e.PhimBinhLuanId)
                    .HasColumnName("PhimBinhLuanID")
                    .ValueGeneratedNever();

                entity.Property(e => e.BinhLuanId).HasColumnName("BinhLuanID");

                entity.Property(e => e.PhimId).HasColumnName("PhimID");

                entity.HasOne(d => d.BinhLuan)
                    .WithOne(p => p.PhimBinhLuan)
                    .HasForeignKey<PhimBinhLuan>(d => d.BinhLuanId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("BinhLuan_PhimBinhLuan");

                entity.HasOne(d => d.Phim)
                    .WithMany(p => p.PhimBinhLuan)
                    .HasForeignKey(d => d.PhimId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Phim_PhimBinhLuan");
            });

            modelBuilder.Entity<PhimDanhGia>(entity =>
            {
                entity.Property(e => e.PhimDanhGiaId)
                    .HasColumnName("PhimDanhGiaID")
                    .ValueGeneratedNever();

                entity.Property(e => e.DanhGiaId).HasColumnName("DanhGiaID");

                entity.Property(e => e.PhimId).HasColumnName("PhimID");

                entity.HasOne(d => d.DanhGia)
                    .WithMany(p => p.PhimDanhGia)
                    .HasForeignKey(d => d.DanhGiaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("DanhGia_PhimDanhGia");

                entity.HasOne(d => d.Phim)
                    .WithMany(p => p.PhimDanhGia)
                    .HasForeignKey(d => d.PhimId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Phim_PhimDanhGia");
            });

            modelBuilder.Entity<PhimDanhMuc>(entity =>
            {
                entity.Property(e => e.PhimDanhMucId)
                    .HasColumnName("PhimDanhMucID")
                    .ValueGeneratedNever();

                entity.Property(e => e.DanhMucId).HasColumnName("DanhMucID");

                entity.Property(e => e.PhimId).HasColumnName("PhimID");

                entity.HasOne(d => d.DanhMuc)
                    .WithMany(p => p.PhimDanhMuc)
                    .HasForeignKey(d => d.DanhMucId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("DanhMuc_PhimDanhMuc");

                entity.HasOne(d => d.Phim)
                    .WithMany(p => p.PhimDanhMuc)
                    .HasForeignKey(d => d.PhimId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Phim_PhimDanhMuc");
            });

            modelBuilder.Entity<PhimDaoDien>(entity =>
            {
                entity.HasIndex(e => e.PhimId)
                    .HasName("CC_PhimDaoDien_PhimID")
                    .IsUnique();

                entity.Property(e => e.PhimDaoDienId)
                    .HasColumnName("PhimDaoDienID")
                    .ValueGeneratedNever();

                entity.Property(e => e.DaoDienId).HasColumnName("DaoDienID");

                entity.Property(e => e.PhimId).HasColumnName("PhimID");

                entity.HasOne(d => d.DaoDien)
                    .WithMany(p => p.PhimDaoDien)
                    .HasForeignKey(d => d.DaoDienId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("DaoDien_PhimDaoDien");

                entity.HasOne(d => d.Phim)
                    .WithOne(p => p.PhimDaoDien)
                    .HasForeignKey<PhimDaoDien>(d => d.PhimId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Phim_PhimDaoDien");
            });

            modelBuilder.Entity<PhimHangSanXuat>(entity =>
            {
                entity.Property(e => e.PhimHangSanXuatId)
                    .HasColumnName("PhimHangSanXuatID")
                    .ValueGeneratedNever();

                entity.Property(e => e.HangSanXuatId).HasColumnName("HangSanXuatID");

                entity.Property(e => e.PhimId).HasColumnName("PhimID");

                entity.HasOne(d => d.HangSanXuat)
                    .WithMany(p => p.PhimHangSanXuat)
                    .HasForeignKey(d => d.HangSanXuatId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("HangSanXuat_PhimHangSanXuat");

                entity.HasOne(d => d.Phim)
                    .WithMany(p => p.PhimHangSanXuat)
                    .HasForeignKey(d => d.PhimId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Phim_PhimHangSanXuat");
            });

            modelBuilder.Entity<PhimTap>(entity =>
            {
                entity.HasIndex(e => e.TapId)
                    .HasName("CC_PhimTap_TapID")
                    .IsUnique();

                entity.Property(e => e.PhimTapId)
                    .HasColumnName("PhimTapID")
                    .ValueGeneratedNever();

                entity.Property(e => e.PhimId).HasColumnName("PhimID");

                entity.Property(e => e.TapId).HasColumnName("TapID");

                entity.HasOne(d => d.Phim)
                    .WithMany(p => p.PhimTap)
                    .HasForeignKey(d => d.PhimId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Phim_PhimTap");

                entity.HasOne(d => d.Tap)
                    .WithOne(p => p.PhimTap)
                    .HasForeignKey<PhimTap>(d => d.TapId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Tap_PhimTap");
            });

            modelBuilder.Entity<Tap>(entity =>
            {
                entity.Property(e => e.TapId)
                    .HasColumnName("TapID")
                    .ValueGeneratedNever();

                entity.Property(e => e.DuongDan)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.ThoiGianKhoiTao).HasColumnType("datetime");
            });

            modelBuilder.Entity<TapBinhLuan>(entity =>
            {
                entity.HasKey(e => e.TapBinhLuan1);

                entity.HasIndex(e => e.BinhLuanId)
                    .HasName("CC_TapBinhLuan_BinhLuanID")
                    .IsUnique();

                entity.Property(e => e.TapBinhLuan1)
                    .HasColumnName("TapBinhLuan")
                    .ValueGeneratedNever();

                entity.Property(e => e.BinhLuanId).HasColumnName("BinhLuanID");

                entity.Property(e => e.TapId).HasColumnName("TapID");

                entity.HasOne(d => d.BinhLuan)
                    .WithOne(p => p.TapBinhLuan)
                    .HasForeignKey<TapBinhLuan>(d => d.BinhLuanId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("BinhLuan_TapBinhLuan");

                entity.HasOne(d => d.Tap)
                    .WithMany(p => p.TapBinhLuan)
                    .HasForeignKey(d => d.TapId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Tap_TapBinhLuan");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
