﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Models;

namespace SWE___PROJEKAT.Migrations
{
    [DbContext(typeof(ProjekatContext))]
    [Migration("20220530232027_V16")]
    partial class V16
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Models.Administrator", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("E-mail");

                    b.Property<string>("telefon")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Br. telefona");

                    b.HasKey("ID");

                    b.ToTable("Administrator");
                });

            modelBuilder.Entity("Models.Domacinstvo", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("AdministratorID")
                        .HasColumnType("int");

                    b.Property<string>("Adresa")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("DostavljacID")
                        .HasColumnType("int");

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Tip")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("E-mail");

                    b.Property<DateTime>("otvorenaVrata")
                        .HasColumnType("datetime2")
                        .HasColumnName("Dan otvorenih vrata");

                    b.Property<string>("telefon")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Br. telefona");

                    b.HasKey("ID");

                    b.HasIndex("AdministratorID");

                    b.HasIndex("DostavljacID");

                    b.ToTable("Domaćinstvo");
                });

            modelBuilder.Entity("Models.Dostavljac", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("AdministratorID")
                        .HasColumnType("int");

                    b.Property<int>("Cena")
                        .HasColumnType("int");

                    b.Property<string>("Ime")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Prezime")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Tip")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("E-mail");

                    b.Property<string>("telefon")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Br. telefona");

                    b.HasKey("ID");

                    b.HasIndex("AdministratorID");

                    b.ToTable("Dostavljač");
                });

            modelBuilder.Entity("Models.Korisnik", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("AdministratorID")
                        .HasColumnType("int");

                    b.Property<string>("Ime")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Prezime")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Tip")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("E-mail");

                    b.HasKey("ID");

                    b.HasIndex("AdministratorID");

                    b.ToTable("Korisnik");
                });

            modelBuilder.Entity("Models.Kupovina", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("DostavljacID")
                        .HasColumnType("int");

                    b.Property<int?>("KorisnikID")
                        .HasColumnType("int");

                    b.Property<int>("ProizvodFK")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("DostavljacID");

                    b.HasIndex("KorisnikID");

                    b.HasIndex("ProizvodFK")
                        .IsUnique();

                    b.ToTable("Kupovine");
                });

            modelBuilder.Entity("Models.Poruka", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("DomacinstvoID")
                        .HasColumnType("int");

                    b.Property<int?>("DostavljacID")
                        .HasColumnType("int");

                    b.Property<int?>("KorisnikID")
                        .HasColumnType("int");

                    b.Property<string>("Tip")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<string>("sadrzaj")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.HasKey("ID");

                    b.HasIndex("DomacinstvoID");

                    b.HasIndex("DostavljacID");

                    b.HasIndex("KorisnikID");

                    b.ToTable("Poruka");
                });

            modelBuilder.Entity("Models.Posao", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("Cena")
                        .HasColumnType("int");

                    b.Property<DateTime>("Datum")
                        .HasColumnType("datetime2")
                        .HasColumnName("Datum početka posla");

                    b.Property<int?>("DomacinstvoID")
                        .HasColumnType("int");

                    b.Property<string>("Opis")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<int>("brojRadnihMesta")
                        .HasColumnType("int")
                        .HasColumnName("Broj radnih mesta");

                    b.HasKey("ID");

                    b.HasIndex("DomacinstvoID");

                    b.ToTable("Poslovi");
                });

            modelBuilder.Entity("Models.Proizvod", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("Cena")
                        .HasColumnType("int");

                    b.Property<int?>("DomacinstvoID")
                        .HasColumnType("int");

                    b.Property<string>("Kategorija")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Kolicina")
                        .HasColumnType("int")
                        .HasColumnName("Količina");

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Opis")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.HasKey("ID");

                    b.HasIndex("DomacinstvoID");

                    b.ToTable("Proizvodi");
                });

            modelBuilder.Entity("Models.Recenzija", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Komentar")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Ocena")
                        .HasColumnType("int");

                    b.Property<int?>("ProizvodID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("ProizvodID");

                    b.ToTable("Recenzije");
                });

            modelBuilder.Entity("Models.Spoj", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("KorisnikID")
                        .HasColumnType("int");

                    b.Property<int?>("PosaoID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("KorisnikID");

                    b.HasIndex("PosaoID");

                    b.ToTable("Spojevi");
                });

            modelBuilder.Entity("Models.Domacinstvo", b =>
                {
                    b.HasOne("Models.Administrator", "Administrator")
                        .WithMany("Domacinstva")
                        .HasForeignKey("AdministratorID");

                    b.HasOne("Models.Dostavljac", "Dostavljac")
                        .WithMany("Domacinstva")
                        .HasForeignKey("DostavljacID");

                    b.Navigation("Administrator");

                    b.Navigation("Dostavljac");
                });

            modelBuilder.Entity("Models.Dostavljac", b =>
                {
                    b.HasOne("Models.Administrator", "Administrator")
                        .WithMany("Dostavljaci")
                        .HasForeignKey("AdministratorID");

                    b.Navigation("Administrator");
                });

            modelBuilder.Entity("Models.Korisnik", b =>
                {
                    b.HasOne("Models.Administrator", "Administrator")
                        .WithMany("Korisnici")
                        .HasForeignKey("AdministratorID");

                    b.Navigation("Administrator");
                });

            modelBuilder.Entity("Models.Kupovina", b =>
                {
                    b.HasOne("Models.Dostavljac", "Dostavljac")
                        .WithMany("Kupovine")
                        .HasForeignKey("DostavljacID");

                    b.HasOne("Models.Korisnik", "Korisnik")
                        .WithMany("Korpa")
                        .HasForeignKey("KorisnikID");

                    b.HasOne("Models.Proizvod", "Proizvod")
                        .WithOne("Kupovina")
                        .HasForeignKey("Models.Kupovina", "ProizvodFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Dostavljac");

                    b.Navigation("Korisnik");

                    b.Navigation("Proizvod");
                });

            modelBuilder.Entity("Models.Poruka", b =>
                {
                    b.HasOne("Models.Domacinstvo", "Domacinstvo")
                        .WithMany("inbox")
                        .HasForeignKey("DomacinstvoID");

                    b.HasOne("Models.Dostavljac", "Dostavljac")
                        .WithMany("inbox")
                        .HasForeignKey("DostavljacID");

                    b.HasOne("Models.Korisnik", "Korisnik")
                        .WithMany("inbox")
                        .HasForeignKey("KorisnikID");

                    b.Navigation("Domacinstvo");

                    b.Navigation("Dostavljac");

                    b.Navigation("Korisnik");
                });

            modelBuilder.Entity("Models.Posao", b =>
                {
                    b.HasOne("Models.Domacinstvo", "Domacinstvo")
                        .WithMany("Poslovi")
                        .HasForeignKey("DomacinstvoID");

                    b.Navigation("Domacinstvo");
                });

            modelBuilder.Entity("Models.Proizvod", b =>
                {
                    b.HasOne("Models.Domacinstvo", "Domacinstvo")
                        .WithMany("Proizvodi")
                        .HasForeignKey("DomacinstvoID");

                    b.Navigation("Domacinstvo");
                });

            modelBuilder.Entity("Models.Recenzija", b =>
                {
                    b.HasOne("Models.Proizvod", "Proizvod")
                        .WithMany("Recenzije")
                        .HasForeignKey("ProizvodID");

                    b.Navigation("Proizvod");
                });

            modelBuilder.Entity("Models.Spoj", b =>
                {
                    b.HasOne("Models.Korisnik", "Korisnik")
                        .WithMany("KorisnikPosao")
                        .HasForeignKey("KorisnikID");

                    b.HasOne("Models.Posao", "Posao")
                        .WithMany("PosaoKorisnik")
                        .HasForeignKey("PosaoID");

                    b.Navigation("Korisnik");

                    b.Navigation("Posao");
                });

            modelBuilder.Entity("Models.Administrator", b =>
                {
                    b.Navigation("Domacinstva");

                    b.Navigation("Dostavljaci");

                    b.Navigation("Korisnici");
                });

            modelBuilder.Entity("Models.Domacinstvo", b =>
                {
                    b.Navigation("inbox");

                    b.Navigation("Poslovi");

                    b.Navigation("Proizvodi");
                });

            modelBuilder.Entity("Models.Dostavljac", b =>
                {
                    b.Navigation("Domacinstva");

                    b.Navigation("inbox");

                    b.Navigation("Kupovine");
                });

            modelBuilder.Entity("Models.Korisnik", b =>
                {
                    b.Navigation("inbox");

                    b.Navigation("KorisnikPosao");

                    b.Navigation("Korpa");
                });

            modelBuilder.Entity("Models.Posao", b =>
                {
                    b.Navigation("PosaoKorisnik");
                });

            modelBuilder.Entity("Models.Proizvod", b =>
                {
                    b.Navigation("Kupovina");

                    b.Navigation("Recenzije");
                });
#pragma warning restore 612, 618
        }
    }
}
