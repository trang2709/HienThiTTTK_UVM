﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using QLTuyenDung.Models;

#nullable disable

namespace QLTuyenDung.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20240704035155_AddQuyenHan")]
    partial class AddQuyenHan
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.31")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("QLTuyenDung.Models.NguoiDung", b =>
                {
                    b.Property<int>("MaND")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("iMaND");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaND"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("sEmail");

                    b.Property<string>("GioiTinh")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("sGioiTinh");

                    b.Property<DateTime?>("NgaySinh")
                        .HasColumnType("datetime2")
                        .HasColumnName("dNgaySinh");

                    b.Property<string>("SDT")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)")
                        .HasColumnName("sSDT");

                    b.Property<string>("TenND")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("sTenND");

                    b.HasKey("MaND");

                    b.ToTable("tbl_NguoiDung");
                });

            modelBuilder.Entity("QLTuyenDung.Models.QuyenHan", b =>
                {
                    b.Property<int>("MaQuyen")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("iMaQuyen");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaQuyen"), 1L, 1);

                    b.Property<string>("TenQuyen")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("sTenQuyen");

                    b.HasKey("MaQuyen");

                    b.ToTable("tbl_QuyenHan");
                });

            modelBuilder.Entity("QLTuyenDung.Models.TaiKhoan", b =>
                {
                    b.Property<int>("MaTaiKhoan")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("iMaTaiKhoan");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaTaiKhoan"), 1L, 1);

                    b.Property<int>("MaND")
                        .HasColumnType("int");

                    b.Property<int>("MaQuyen")
                        .HasColumnType("int");

                    b.Property<string>("MatKhau")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("sMatKhau");

                    b.Property<string>("TenTaiKhoan")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("sTaiKhoan");

                    b.Property<int>("iMaND")
                        .HasColumnType("int");

                    b.Property<int>("iMaQuyen")
                        .HasColumnType("int");

                    b.HasKey("MaTaiKhoan");

                    b.HasIndex("iMaND");

                    b.HasIndex("iMaQuyen");

                    b.ToTable("tbl_TaiKhoan");
                });

            modelBuilder.Entity("QLTuyenDung.Models.TaiKhoan", b =>
                {
                    b.HasOne("QLTuyenDung.Models.NguoiDung", "NguoiDung")
                        .WithMany()
                        .HasForeignKey("iMaND")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("QLTuyenDung.Models.QuyenHan", "QuyenHan")
                        .WithMany()
                        .HasForeignKey("iMaQuyen")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("NguoiDung");

                    b.Navigation("QuyenHan");
                });
#pragma warning restore 612, 618
        }
    }
}
