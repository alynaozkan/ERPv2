﻿// <auto-generated />
using System;
using ERP.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ERP.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20241219140341_UpdateHeadRelationships")]
    partial class UpdateHeadRelationships
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ERP.Models.Kontrol.Genel.BSMGRNNMGEN001", b =>
                {
                    b.Property<string>("COMCODE")
                        .HasMaxLength(4)
                        .HasColumnType("nvarchar(4)");

                    b.Property<string>("ADRESS1")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<string>("ADRESS2")
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<string>("CITYCODE")
                        .HasColumnType("nvarchar(3)");

                    b.Property<string>("COMTEXT")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<string>("COUNTRYCODE")
                        .IsRequired()
                        .HasColumnType("nvarchar(4)");

                    b.HasKey("COMCODE");

                    b.HasIndex("CITYCODE");

                    b.HasIndex("COUNTRYCODE");

                    b.ToTable("BSMGRNNMGEN001");
                });

            modelBuilder.Entity("ERP.Models.Kontrol.Genel.BSMGRNNMGEN002", b =>
                {
                    b.Property<string>("LANCODE")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("COMCODE")
                        .IsRequired()
                        .HasMaxLength(4)
                        .HasColumnType("nvarchar(4)");

                    b.Property<string>("LANTEXT")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LANCODE");

                    b.HasIndex("COMCODE");

                    b.ToTable("BSMGRNNMGEN002");
                });

            modelBuilder.Entity("ERP.Models.Kontrol.Genel.BSMGRNNMGEN003", b =>
                {
                    b.Property<string>("COUNTRYCODE")
                        .HasMaxLength(4)
                        .HasColumnType("nvarchar(4)");

                    b.Property<string>("COUNTRYNAME")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.HasKey("COUNTRYCODE");

                    b.ToTable("BSMGRNNMGEN003");
                });

            modelBuilder.Entity("ERP.Models.Kontrol.Genel.BSMGRNNMGEN004", b =>
                {
                    b.Property<string>("CITYCODE")
                        .HasMaxLength(3)
                        .HasColumnType("nvarchar(3)");

                    b.Property<string>("CITYTEXT")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("COUNTRYCODE")
                        .HasMaxLength(4)
                        .HasColumnType("nvarchar(4)");

                    b.HasKey("CITYCODE");

                    b.HasIndex("COUNTRYCODE");

                    b.ToTable("BSMGRNNMGEN004");
                });

            modelBuilder.Entity("ERP.Models.Kontrol.Genel.BSMGRNNMGEN005", b =>
                {
                    b.Property<string>("UNITCODE")
                        .HasMaxLength(3)
                        .HasColumnType("nvarchar(3)");

                    b.Property<string>("COMCODE")
                        .IsRequired()
                        .HasMaxLength(4)
                        .HasColumnType("nvarchar(4)");

                    b.Property<int>("ISMAINUNIT")
                        .HasColumnType("int");

                    b.Property<string>("MAINUNITCODE")
                        .IsRequired()
                        .HasMaxLength(3)
                        .HasColumnType("nvarchar(3)");

                    b.Property<string>("UNITTEXT")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.HasKey("UNITCODE");

                    b.HasIndex("COMCODE");

                    b.ToTable("BSMGRNNMGEN005");
                });

            modelBuilder.Entity("ERP.Models.Kontrol.Maliyet.BSMGRNNMCCM001", b =>
                {
                    b.Property<string>("DOCTYPE")
                        .HasMaxLength(4)
                        .HasColumnType("nvarchar(4)");

                    b.Property<string>("COMCODE")
                        .IsRequired()
                        .HasMaxLength(4)
                        .HasColumnType("nvarchar(4)");

                    b.Property<string>("DOCTYPETEXT")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<int>("ISPASSIVE")
                        .HasColumnType("int");

                    b.HasKey("DOCTYPE");

                    b.HasIndex("COMCODE");

                    b.ToTable("BSMGRNNMCCM001");
                });

            modelBuilder.Entity("ERP.Models.Kontrol.MalzemeBilgi.BSMGRNNMMAT001", b =>
                {
                    b.Property<string>("DOCTYPE")
                        .HasMaxLength(4)
                        .HasColumnType("nvarchar(4)");

                    b.Property<string>("COMCODE")
                        .IsRequired()
                        .HasMaxLength(4)
                        .HasColumnType("nvarchar(4)");

                    b.Property<string>("DOCTYPETEXT")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<int>("ISPASSIVE")
                        .HasColumnType("int");

                    b.HasKey("DOCTYPE");

                    b.HasIndex("COMCODE");

                    b.ToTable("BSMGRNNMMAT001");
                });

            modelBuilder.Entity("ERP.Models.Kontrol.RotaBilgi.BSMGRNNMOPR001", b =>
                {
                    b.Property<string>("DOCTYPE")
                        .HasMaxLength(4)
                        .HasColumnType("nvarchar(4)");

                    b.Property<string>("COMCODE")
                        .IsRequired()
                        .HasMaxLength(4)
                        .HasColumnType("nvarchar(4)");

                    b.Property<string>("DOCTYPETEXT")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<int>("ISPASSIVE")
                        .HasColumnType("int");

                    b.HasKey("DOCTYPE");

                    b.HasIndex("COMCODE");

                    b.ToTable("BSMGRNNMOPR001");
                });

            modelBuilder.Entity("ERP.Models.Kontrol.RotaBilgi.BSMGRNNMROT001", b =>
                {
                    b.Property<string>("DOCTYPE")
                        .HasMaxLength(4)
                        .HasColumnType("nvarchar(4)");

                    b.Property<string>("COMCODE")
                        .IsRequired()
                        .HasMaxLength(4)
                        .HasColumnType("nvarchar(4)");

                    b.Property<string>("DOCTYPETEXT")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<int>("ISPASSIVE")
                        .HasColumnType("int");

                    b.HasKey("DOCTYPE");

                    b.HasIndex("COMCODE");

                    b.ToTable("BSMGRNNMROT001");
                });

            modelBuilder.Entity("ERP.Models.Kontrol.RotaBilgi.BSMGRNNMWCM001", b =>
                {
                    b.Property<string>("DOCTYPE")
                        .HasMaxLength(4)
                        .HasColumnType("nvarchar(4)");

                    b.Property<string>("COMCODE")
                        .IsRequired()
                        .HasMaxLength(4)
                        .HasColumnType("nvarchar(4)");

                    b.Property<string>("DOCTYPETEXT")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<int>("ISPASSIVE")
                        .HasColumnType("int");

                    b.HasKey("DOCTYPE");

                    b.HasIndex("COMCODE");

                    b.ToTable("BSMGRNNMWCM001");
                });

            modelBuilder.Entity("ERP.Models.Kontrol.UrunAgac.BSMGRNNMBOM001", b =>
                {
                    b.Property<string>("DOCTYPE")
                        .HasMaxLength(4)
                        .HasColumnType("nvarchar(4)");

                    b.Property<string>("COMCODE")
                        .IsRequired()
                        .HasMaxLength(4)
                        .HasColumnType("nvarchar(4)");

                    b.Property<string>("DOCTYPETEXT")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<int>("ISPASSIVE")
                        .HasColumnType("int");

                    b.HasKey("DOCTYPE");

                    b.HasIndex("COMCODE");

                    b.ToTable("BSMGRNNMBOM001");
                });

            modelBuilder.Entity("ERP.Models.Veri.IsMerkez.BSMGRNNMWCMHEAD", b =>
                {
                    b.Property<string>("WCMDOCNUM")
                        .HasMaxLength(4)
                        .HasColumnType("nvarchar(4)");

                    b.Property<string>("CCMDOCNUM")
                        .IsRequired()
                        .HasColumnType("nvarchar(4)");

                    b.Property<string>("CCMDOCTYPE")
                        .IsRequired()
                        .HasColumnType("nvarchar(4)");

                    b.Property<string>("COMCODE")
                        .IsRequired()
                        .HasMaxLength(4)
                        .HasColumnType("nvarchar(4)");

                    b.Property<int>("ISDELETED")
                        .HasColumnType("int");

                    b.Property<int>("ISPASSIVE")
                        .HasColumnType("int");

                    b.Property<string>("LANCODE")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("MAINWCMDOCNUM")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MAINWCMDOCTYPE")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OPRDOCTYPE")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("WCMDOCFROM")
                        .HasColumnType("datetime2");

                    b.Property<string>("WCMDOCTYPE")
                        .IsRequired()
                        .HasMaxLength(4)
                        .HasColumnType("nvarchar(4)");

                    b.Property<DateTime>("WCMDOCUNTIL")
                        .HasColumnType("datetime2");

                    b.Property<string>("WCMLTWXT")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WCMSTEXT")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("WORKTIME")
                        .HasColumnType("float");

                    b.HasKey("WCMDOCNUM");

                    b.HasIndex("CCMDOCNUM");

                    b.HasIndex("CCMDOCTYPE");

                    b.HasIndex("COMCODE");

                    b.HasIndex("LANCODE");

                    b.HasIndex("WCMDOCTYPE");

                    b.ToTable("BSMGRNNMWCMHEAD");
                });

            modelBuilder.Entity("ERP.Models.Veri.Maliyet.BSMGRNNMCCMHEAD", b =>
                {
                    b.Property<string>("CCMDOCNUM")
                        .HasMaxLength(4)
                        .HasColumnType("nvarchar(4)");

                    b.Property<DateTime>("CCMDOCFROM")
                        .HasColumnType("datetime2");

                    b.Property<string>("CCMDOCTYPE")
                        .IsRequired()
                        .HasMaxLength(4)
                        .HasColumnType("nvarchar(4)");

                    b.Property<DateTime>("CCMDOCUNTIL")
                        .HasColumnType("datetime2");

                    b.Property<string>("CCMLTEXT")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CCMSTEXT")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("COMCODE")
                        .IsRequired()
                        .HasMaxLength(4)
                        .HasColumnType("nvarchar(4)");

                    b.Property<int>("ISDELETED")
                        .HasColumnType("int");

                    b.Property<int>("ISPASSIVE")
                        .HasColumnType("int");

                    b.Property<string>("LANCODE")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("MAINCCMDOCNUM")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MAINCCMDOCTYPE")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CCMDOCNUM");

                    b.HasIndex("CCMDOCTYPE");

                    b.HasIndex("COMCODE");

                    b.HasIndex("LANCODE");

                    b.ToTable("BSMGRNNMCCMHEAD");
                });

            modelBuilder.Entity("ERP.Models.Veri.Malzeme.BSMGRNNMMATHEAD", b =>
                {
                    b.Property<string>("MATDOCNUM")
                        .HasMaxLength(4)
                        .HasColumnType("nvarchar(4)");

                    b.Property<string>("BOMDOCNUM")
                        .IsRequired()
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("BOMDOCTYPE")
                        .IsRequired()
                        .HasColumnType("nvarchar(25)");

                    b.Property<double>("BRUTWEIGHT")
                        .HasColumnType("float");

                    b.Property<string>("BWUNIT")
                        .IsRequired()
                        .HasColumnType("nvarchar(3)");

                    b.Property<string>("COMCODE")
                        .IsRequired()
                        .HasMaxLength(4)
                        .HasColumnType("nvarchar(4)");

                    b.Property<int>("ISBOM")
                        .HasColumnType("int");

                    b.Property<int>("ISDELETED")
                        .HasColumnType("int");

                    b.Property<int>("ISPASSIVE")
                        .HasColumnType("int");

                    b.Property<int>("ISROUTE")
                        .HasColumnType("int");

                    b.Property<string>("LANCODE")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("MATDOCFROM")
                        .HasColumnType("datetime2");

                    b.Property<string>("MATDOCTYPE")
                        .IsRequired()
                        .HasMaxLength(4)
                        .HasColumnType("nvarchar(4)");

                    b.Property<DateTime>("MATDOCUNTIL")
                        .HasColumnType("datetime2");

                    b.Property<string>("MATLTEXT")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MATSTEXT")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("NETWEIGHT")
                        .HasColumnType("float");

                    b.Property<string>("NWUNIT")
                        .IsRequired()
                        .HasColumnType("nvarchar(3)");

                    b.Property<string>("ROTDOCNUM")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ROTDOCTYPE")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("STUNIT")
                        .HasColumnType("nvarchar(3)");

                    b.Property<int>("SUPPLYTYPE")
                        .HasColumnType("int");

                    b.HasKey("MATDOCNUM");

                    b.HasIndex("BOMDOCNUM");

                    b.HasIndex("BOMDOCTYPE");

                    b.HasIndex("BWUNIT");

                    b.HasIndex("COMCODE");

                    b.HasIndex("LANCODE");

                    b.HasIndex("MATDOCTYPE");

                    b.HasIndex("NWUNIT");

                    b.HasIndex("STUNIT");

                    b.ToTable("BSMGRNNMMATHEAD");
                });

            modelBuilder.Entity("ERP.Models.Veri.Rota.BSMGRNNMROTHEAD", b =>
                {
                    b.Property<string>("ROTDOCNUM")
                        .HasMaxLength(4)
                        .HasColumnType("nvarchar(4)");

                    b.Property<string>("BOMDOCNUM")
                        .IsRequired()
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("BOMDOCTYPE")
                        .IsRequired()
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("COMCODE")
                        .IsRequired()
                        .HasMaxLength(4)
                        .HasColumnType("nvarchar(4)");

                    b.Property<string>("COMPONENT")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CONTENTNUM")
                        .HasColumnType("int");

                    b.Property<string>("DRAWNUM")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ISDELETED")
                        .HasColumnType("int");

                    b.Property<int>("ISPASSIVE")
                        .HasColumnType("int");

                    b.Property<double>("LABOURTIME")
                        .HasColumnType("float");

                    b.Property<double>("MACHINETIME")
                        .HasColumnType("float");

                    b.Property<string>("MATDOCNUM")
                        .IsRequired()
                        .HasColumnType("nvarchar(4)");

                    b.Property<string>("MATDOCTYPE")
                        .IsRequired()
                        .HasColumnType("nvarchar(4)");

                    b.Property<int>("OPRNUM")
                        .HasColumnType("int");

                    b.Property<double>("QUANTITY")
                        .HasColumnType("float");

                    b.Property<DateTime>("ROTDOCFROM")
                        .HasColumnType("datetime2");

                    b.Property<string>("ROTDOCTYPE")
                        .IsRequired()
                        .HasMaxLength(4)
                        .HasColumnType("nvarchar(4)");

                    b.Property<DateTime>("ROTDOCUNTIL")
                        .HasColumnType("datetime2");

                    b.Property<double>("SETUPTIME")
                        .HasColumnType("float");

                    b.Property<string>("WCMDOCNUM")
                        .IsRequired()
                        .HasColumnType("nvarchar(4)");

                    b.Property<string>("WCMDOCTYPE")
                        .IsRequired()
                        .HasColumnType("nvarchar(4)");

                    b.HasKey("ROTDOCNUM");

                    b.HasIndex("BOMDOCNUM");

                    b.HasIndex("BOMDOCTYPE");

                    b.HasIndex("COMCODE");

                    b.HasIndex("MATDOCNUM");

                    b.HasIndex("MATDOCTYPE");

                    b.HasIndex("ROTDOCTYPE");

                    b.HasIndex("WCMDOCNUM");

                    b.HasIndex("WCMDOCTYPE");

                    b.ToTable("BSMGRNNMROTHEAD");
                });

            modelBuilder.Entity("ERP.Models.Veri.UrunAgac.BSMGRNNMBOMHEAD", b =>
                {
                    b.Property<string>("BOMDOCNUM")
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<DateTime>("BOMDOCFROM")
                        .HasColumnType("datetime2");

                    b.Property<string>("BOMDOCTYPE")
                        .IsRequired()
                        .HasMaxLength(4)
                        .HasColumnType("nvarchar(4)");

                    b.Property<DateTime>("BOMDOCUNTIL")
                        .HasColumnType("datetime2");

                    b.Property<string>("COMCODE")
                        .IsRequired()
                        .HasMaxLength(4)
                        .HasColumnType("nvarchar(4)");

                    b.Property<string>("COMPONENT")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CONTENTNUM")
                        .HasColumnType("int");

                    b.Property<string>("DRAWNUM")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ISDELETED")
                        .HasColumnType("int");

                    b.Property<int>("ISPASSIVE")
                        .HasColumnType("int");

                    b.Property<string>("MATDOCNUM")
                        .IsRequired()
                        .HasColumnType("nvarchar(4)");

                    b.Property<string>("MATDOCTYPE")
                        .IsRequired()
                        .HasColumnType("nvarchar(4)");

                    b.Property<double>("QUANTITY")
                        .HasColumnType("float");

                    b.HasKey("BOMDOCNUM");

                    b.HasIndex("BOMDOCTYPE");

                    b.HasIndex("COMCODE");

                    b.HasIndex("MATDOCNUM");

                    b.HasIndex("MATDOCTYPE");

                    b.ToTable("BSMGRNNMBOMHEAD");
                });

            modelBuilder.Entity("ERP.Models.Kontrol.Genel.BSMGRNNMGEN001", b =>
                {
                    b.HasOne("ERP.Models.Kontrol.Genel.BSMGRNNMGEN004", "CITY")
                        .WithMany()
                        .HasForeignKey("CITYCODE")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("ERP.Models.Kontrol.Genel.BSMGRNNMGEN003", "COUNTRY")
                        .WithMany()
                        .HasForeignKey("COUNTRYCODE")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("CITY");

                    b.Navigation("COUNTRY");
                });

            modelBuilder.Entity("ERP.Models.Kontrol.Genel.BSMGRNNMGEN002", b =>
                {
                    b.HasOne("ERP.Models.Kontrol.Genel.BSMGRNNMGEN001", "FCOMCODE")
                        .WithMany()
                        .HasForeignKey("COMCODE")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FCOMCODE");
                });

            modelBuilder.Entity("ERP.Models.Kontrol.Genel.BSMGRNNMGEN004", b =>
                {
                    b.HasOne("ERP.Models.Kontrol.Genel.BSMGRNNMGEN003", "COUNTRY")
                        .WithMany()
                        .HasForeignKey("COUNTRYCODE")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("COUNTRY");
                });

            modelBuilder.Entity("ERP.Models.Kontrol.Genel.BSMGRNNMGEN005", b =>
                {
                    b.HasOne("ERP.Models.Kontrol.Genel.BSMGRNNMGEN001", "FCOMCODE")
                        .WithMany()
                        .HasForeignKey("COMCODE")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FCOMCODE");
                });

            modelBuilder.Entity("ERP.Models.Kontrol.Maliyet.BSMGRNNMCCM001", b =>
                {
                    b.HasOne("ERP.Models.Kontrol.Genel.BSMGRNNMGEN001", "FCOMCODE")
                        .WithMany()
                        .HasForeignKey("COMCODE")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FCOMCODE");
                });

            modelBuilder.Entity("ERP.Models.Kontrol.MalzemeBilgi.BSMGRNNMMAT001", b =>
                {
                    b.HasOne("ERP.Models.Kontrol.Genel.BSMGRNNMGEN001", "FCOMCODE")
                        .WithMany()
                        .HasForeignKey("COMCODE")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FCOMCODE");
                });

            modelBuilder.Entity("ERP.Models.Kontrol.RotaBilgi.BSMGRNNMOPR001", b =>
                {
                    b.HasOne("ERP.Models.Kontrol.Genel.BSMGRNNMGEN001", "FCOMCODE")
                        .WithMany()
                        .HasForeignKey("COMCODE")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FCOMCODE");
                });

            modelBuilder.Entity("ERP.Models.Kontrol.RotaBilgi.BSMGRNNMROT001", b =>
                {
                    b.HasOne("ERP.Models.Kontrol.Genel.BSMGRNNMGEN001", "FCOMCODE")
                        .WithMany()
                        .HasForeignKey("COMCODE")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FCOMCODE");
                });

            modelBuilder.Entity("ERP.Models.Kontrol.RotaBilgi.BSMGRNNMWCM001", b =>
                {
                    b.HasOne("ERP.Models.Kontrol.Genel.BSMGRNNMGEN001", "FCOMCODE")
                        .WithMany()
                        .HasForeignKey("COMCODE")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FCOMCODE");
                });

            modelBuilder.Entity("ERP.Models.Kontrol.UrunAgac.BSMGRNNMBOM001", b =>
                {
                    b.HasOne("ERP.Models.Kontrol.Genel.BSMGRNNMGEN001", "FCOMCODE")
                        .WithMany()
                        .HasForeignKey("COMCODE")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FCOMCODE");
                });

            modelBuilder.Entity("ERP.Models.Veri.IsMerkez.BSMGRNNMWCMHEAD", b =>
                {
                    b.HasOne("ERP.Models.Veri.Maliyet.BSMGRNNMCCMHEAD", "FCCMDOCNUM")
                        .WithMany()
                        .HasForeignKey("CCMDOCNUM")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("ERP.Models.Veri.Maliyet.BSMGRNNMCCMHEAD", "FCCMDOCTYPE")
                        .WithMany()
                        .HasForeignKey("CCMDOCTYPE")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("ERP.Models.Kontrol.Genel.BSMGRNNMGEN001", "FCOMCODE")
                        .WithMany()
                        .HasForeignKey("COMCODE")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("ERP.Models.Kontrol.Genel.BSMGRNNMGEN002", "FLANCODE")
                        .WithMany()
                        .HasForeignKey("LANCODE")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("ERP.Models.Kontrol.RotaBilgi.BSMGRNNMWCM001", "DOCTYPE")
                        .WithMany()
                        .HasForeignKey("WCMDOCTYPE")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("DOCTYPE");

                    b.Navigation("FCCMDOCNUM");

                    b.Navigation("FCCMDOCTYPE");

                    b.Navigation("FCOMCODE");

                    b.Navigation("FLANCODE");
                });

            modelBuilder.Entity("ERP.Models.Veri.Maliyet.BSMGRNNMCCMHEAD", b =>
                {
                    b.HasOne("ERP.Models.Kontrol.Maliyet.BSMGRNNMCCM001", "DOCTYPE")
                        .WithMany()
                        .HasForeignKey("CCMDOCTYPE")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("ERP.Models.Kontrol.Genel.BSMGRNNMGEN001", "FCOMCODE")
                        .WithMany()
                        .HasForeignKey("COMCODE")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("ERP.Models.Kontrol.Genel.BSMGRNNMGEN002", "FLANCODE")
                        .WithMany()
                        .HasForeignKey("LANCODE")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("DOCTYPE");

                    b.Navigation("FCOMCODE");

                    b.Navigation("FLANCODE");
                });

            modelBuilder.Entity("ERP.Models.Veri.Malzeme.BSMGRNNMMATHEAD", b =>
                {
                    b.HasOne("ERP.Models.Veri.UrunAgac.BSMGRNNMBOMHEAD", "FBOMDOCNUM")
                        .WithMany()
                        .HasForeignKey("BOMDOCNUM")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("ERP.Models.Veri.UrunAgac.BSMGRNNMBOMHEAD", "FBOMDOCTYPE")
                        .WithMany()
                        .HasForeignKey("BOMDOCTYPE")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("ERP.Models.Kontrol.Genel.BSMGRNNMGEN005", "FBWUNIT")
                        .WithMany()
                        .HasForeignKey("BWUNIT")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("ERP.Models.Kontrol.Genel.BSMGRNNMGEN001", "FCOMCODE")
                        .WithMany()
                        .HasForeignKey("COMCODE")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("ERP.Models.Kontrol.Genel.BSMGRNNMGEN002", "FLANCODE")
                        .WithMany()
                        .HasForeignKey("LANCODE")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("ERP.Models.Kontrol.MalzemeBilgi.BSMGRNNMMAT001", "DOCTYPE")
                        .WithMany()
                        .HasForeignKey("MATDOCTYPE")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("ERP.Models.Kontrol.Genel.BSMGRNNMGEN005", "FNWUNIT")
                        .WithMany()
                        .HasForeignKey("NWUNIT")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("ERP.Models.Kontrol.Genel.BSMGRNNMGEN005", "FSTUNIT")
                        .WithMany()
                        .HasForeignKey("STUNIT")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("DOCTYPE");

                    b.Navigation("FBOMDOCNUM");

                    b.Navigation("FBOMDOCTYPE");

                    b.Navigation("FBWUNIT");

                    b.Navigation("FCOMCODE");

                    b.Navigation("FLANCODE");

                    b.Navigation("FNWUNIT");

                    b.Navigation("FSTUNIT");
                });

            modelBuilder.Entity("ERP.Models.Veri.Rota.BSMGRNNMROTHEAD", b =>
                {
                    b.HasOne("ERP.Models.Veri.UrunAgac.BSMGRNNMBOMHEAD", "FBOMDOCNUM")
                        .WithMany()
                        .HasForeignKey("BOMDOCNUM")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("ERP.Models.Veri.UrunAgac.BSMGRNNMBOMHEAD", "FBOMDOCTYPE")
                        .WithMany()
                        .HasForeignKey("BOMDOCTYPE")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("ERP.Models.Kontrol.Genel.BSMGRNNMGEN001", "FCOMCODE")
                        .WithMany()
                        .HasForeignKey("COMCODE")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("ERP.Models.Veri.Malzeme.BSMGRNNMMATHEAD", "FMATDOCNUM")
                        .WithMany()
                        .HasForeignKey("MATDOCNUM")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("ERP.Models.Veri.Malzeme.BSMGRNNMMATHEAD", "FMATDOCTYPE")
                        .WithMany()
                        .HasForeignKey("MATDOCTYPE")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("ERP.Models.Kontrol.MalzemeBilgi.BSMGRNNMMAT001", "DOCTYPE")
                        .WithMany()
                        .HasForeignKey("ROTDOCTYPE")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("ERP.Models.Veri.IsMerkez.BSMGRNNMWCMHEAD", "FWCMDOCNUM")
                        .WithMany()
                        .HasForeignKey("WCMDOCNUM")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("ERP.Models.Veri.IsMerkez.BSMGRNNMWCMHEAD", "FWCMDOCTYPE")
                        .WithMany()
                        .HasForeignKey("WCMDOCTYPE")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("DOCTYPE");

                    b.Navigation("FBOMDOCNUM");

                    b.Navigation("FBOMDOCTYPE");

                    b.Navigation("FCOMCODE");

                    b.Navigation("FMATDOCNUM");

                    b.Navigation("FMATDOCTYPE");

                    b.Navigation("FWCMDOCNUM");

                    b.Navigation("FWCMDOCTYPE");
                });

            modelBuilder.Entity("ERP.Models.Veri.UrunAgac.BSMGRNNMBOMHEAD", b =>
                {
                    b.HasOne("ERP.Models.Kontrol.UrunAgac.BSMGRNNMBOM001", "DOCTYPE")
                        .WithMany()
                        .HasForeignKey("BOMDOCTYPE")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("ERP.Models.Kontrol.Genel.BSMGRNNMGEN001", "FCOMCODE")
                        .WithMany()
                        .HasForeignKey("COMCODE")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("ERP.Models.Veri.Malzeme.BSMGRNNMMATHEAD", "FMATDOCNUM")
                        .WithMany()
                        .HasForeignKey("MATDOCNUM")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("ERP.Models.Veri.Malzeme.BSMGRNNMMATHEAD", "FMATDOCTYPE")
                        .WithMany()
                        .HasForeignKey("MATDOCTYPE")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("DOCTYPE");

                    b.Navigation("FCOMCODE");

                    b.Navigation("FMATDOCNUM");

                    b.Navigation("FMATDOCTYPE");
                });
#pragma warning restore 612, 618
        }
    }
}