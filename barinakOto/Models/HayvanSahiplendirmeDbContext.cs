using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace barinakOto.Models;

public partial class HayvanSahiplendirmeDbContext : DbContext
{
    public HayvanSahiplendirmeDbContext()
    {
    }

    public HayvanSahiplendirmeDbContext(DbContextOptions<HayvanSahiplendirmeDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Asilar> Asilars { get; set; }

    public virtual DbSet<Barinaklar> Barinaklars { get; set; }

    public virtual DbSet<Hayvanlar> Hayvanlars { get; set; }

    public virtual DbSet<Personeller> Personellers { get; set; }

    public virtual DbSet<SaglikKayitlari> SaglikKayitlaris { get; set; }

    public virtual DbSet<Sahiplenenler> Sahiplenenlers { get; set; }

    public virtual DbSet<Sahiplenmeler> Sahiplenmelers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=LAPTOP-4LBTGGRB\\SQLEXPRESS;Initial Catalog=HayvanSahiplendirmeDb;Integrated Security=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Asilar>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Asilar__3214EC073C18FABA");

            entity.ToTable("Asilar");

            entity.Property(e => e.AsiAdi).HasMaxLength(100);
            entity.Property(e => e.AsiTarihi).HasColumnType("datetime");
            entity.Property(e => e.SonrakiAsiTarihi).HasColumnType("datetime");
            entity.Property(e => e.VeterinerAd).HasMaxLength(100);

            entity.HasOne(d => d.Hayvan).WithMany(p => p.Asilars)
                .HasForeignKey(d => d.HayvanId)
                .HasConstraintName("FK__Asilar__HayvanId__47DBAE45");
        });

        modelBuilder.Entity<Barinaklar>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Barinakl__3214EC0770CA4B43");

            entity.ToTable("Barinaklar");

            entity.Property(e => e.Ad).HasMaxLength(100);
            entity.Property(e => e.Adres).HasMaxLength(250);
            entity.Property(e => e.Eposta).HasMaxLength(100);
            entity.Property(e => e.Kapasite).HasDefaultValue(0);
            entity.Property(e => e.Telefon).HasMaxLength(20);
        });

        modelBuilder.Entity<Hayvanlar>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Hayvanla__3214EC07DDC0A58A");

            entity.ToTable("Hayvanlar");

            entity.Property(e => e.Ad).HasMaxLength(50);
            entity.Property(e => e.Cins).HasMaxLength(50);
            entity.Property(e => e.Cinsiyet).HasMaxLength(10);
            entity.Property(e => e.KayitTarihi)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.SahiplenildiMi).HasDefaultValue(false);
            entity.Property(e => e.Tur).HasMaxLength(50);

            entity.HasOne(d => d.Barinak).WithMany(p => p.Hayvanlars)
                .HasForeignKey(d => d.BarinakId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Hayvanlar__Barin__3C69FB99");
        });

        modelBuilder.Entity<Personeller>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Personel__3214EC07F58EC367");

            entity.ToTable("Personeller");

            entity.HasIndex(e => e.KullaniciAdi, "UQ__Personel__5BAE6A754F321281").IsUnique();

            entity.Property(e => e.AdSoyad).HasMaxLength(100);
            entity.Property(e => e.Eposta).HasMaxLength(100);
            entity.Property(e => e.Gorev).HasMaxLength(50);
            entity.Property(e => e.KullaniciAdi).HasMaxLength(50);
            entity.Property(e => e.SifreHash).HasMaxLength(256);
            entity.Property(e => e.Telefon).HasMaxLength(20);
        });

        modelBuilder.Entity<SaglikKayitlari>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SaglikKa__3214EC07E87A57BA");

            entity.ToTable("SaglikKayitlari");

            entity.Property(e => e.KayitTarihi)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.VeterinerAd).HasMaxLength(100);

            entity.HasOne(d => d.Hayvan).WithMany(p => p.SaglikKayitlaris)
                .HasForeignKey(d => d.HayvanId)
                .HasConstraintName("FK__SaglikKay__Hayva__4BAC3F29");
        });

        modelBuilder.Entity<Sahiplenenler>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Sahiplen__3214EC07630BDBE9");

            entity.ToTable("Sahiplenenler");

            entity.HasIndex(e => e.KimlikNo, "UQ__Sahiplen__F4D9189982A866A3").IsUnique();

            entity.Property(e => e.AdSoyad).HasMaxLength(100);
            entity.Property(e => e.Adres).HasMaxLength(250);
            entity.Property(e => e.Eposta).HasMaxLength(100);
            entity.Property(e => e.KimlikNo).HasMaxLength(11);
            entity.Property(e => e.Telefon).HasMaxLength(20);
        });

        modelBuilder.Entity<Sahiplenmeler>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Sahiplen__3214EC07C4CB8327");

            entity.ToTable("Sahiplenmeler");

            entity.HasIndex(e => e.HayvanId, "UQ__Sahiplen__273611B9FC4018D3").IsUnique();

            entity.Property(e => e.SahiplenmeTarihi)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");

            entity.HasOne(d => d.Hayvan).WithOne(p => p.Sahiplenmeler)
                .HasForeignKey<Sahiplenmeler>(d => d.HayvanId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Sahiplenm__Hayva__440B1D61");

            entity.HasOne(d => d.Sahiplenen).WithMany(p => p.Sahiplenmelers)
                .HasForeignKey(d => d.SahiplenenId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Sahiplenm__Sahip__44FF419A");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
