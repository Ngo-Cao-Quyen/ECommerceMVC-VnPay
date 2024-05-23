﻿// <auto-generated />
using System;
using ECommerceMVC.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ECommerceMVC.Migrations
{
    [DbContext(typeof(QShopContext))]
    [Migration("20240523075231_v1")]
    partial class v1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ECommerceMVC.Data.ChiTietHd", b =>
                {
                    b.Property<int>("MaCt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("MaCT");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaCt"));

                    b.Property<double>("DonGia")
                        .HasColumnType("float");

                    b.Property<double>("GiamGia")
                        .HasColumnType("float");

                    b.Property<int>("MaHd")
                        .HasColumnType("int")
                        .HasColumnName("MaHD");

                    b.Property<int>("MaHh")
                        .HasColumnType("int")
                        .HasColumnName("MaHH");

                    b.Property<int>("SoLuong")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(1);

                    b.HasKey("MaCt")
                        .HasName("PK_OrderDetails");

                    b.HasIndex("MaHd");

                    b.HasIndex("MaHh");

                    b.ToTable("ChiTietHD", (string)null);
                });

            modelBuilder.Entity("ECommerceMVC.Data.HangHoa", b =>
                {
                    b.Property<int>("MaHh")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("MaHH");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaHh"));

                    b.Property<double?>("DonGia")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("float")
                        .HasDefaultValue(0.0);

                    b.Property<double>("GiamGia")
                        .HasColumnType("float");

                    b.Property<string>("Hinh")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("MaLoai")
                        .HasColumnType("int");

                    b.Property<string>("MaNcc")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("MaNCC");

                    b.Property<string>("MoTa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MoTaDonVi")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("NgaySx")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasColumnName("NgaySX")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<int>("SoLanXem")
                        .HasColumnType("int");

                    b.Property<string>("TenAlias")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("TenHh")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("TenHH");

                    b.HasKey("MaHh")
                        .HasName("PK_Products");

                    b.HasIndex("MaLoai");

                    b.HasIndex("MaNcc");

                    b.ToTable("HangHoa", (string)null);
                });

            modelBuilder.Entity("ECommerceMVC.Data.HoaDon", b =>
                {
                    b.Property<int>("MaHd")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("MaHD");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaHd"));

                    b.Property<string>("CachThanhToan")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasDefaultValue("Cash");

                    b.Property<string>("CachVanChuyen")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasDefaultValue("Airline");

                    b.Property<string>("DiaChi")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("DienThoai")
                        .HasMaxLength(24)
                        .HasColumnType("nvarchar(24)");

                    b.Property<string>("GhiChu")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("HoTen")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("MaKh")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("MaKH");

                    b.Property<string>("MaNv")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("MaNV");

                    b.Property<int>("MaTrangThai")
                        .HasColumnType("int");

                    b.Property<DateTime?>("NgayCan")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<DateTime>("NgayDat")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<DateTime?>("NgayGiao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(((1)/(1))/(1900))");

                    b.Property<double>("PhiVanChuyen")
                        .HasColumnType("float");

                    b.HasKey("MaHd")
                        .HasName("PK_Orders");

                    b.HasIndex("MaKh");

                    b.HasIndex("MaTrangThai");

                    b.ToTable("HoaDon", (string)null);
                });

            modelBuilder.Entity("ECommerceMVC.Data.KhachHang", b =>
                {
                    b.Property<string>("MaKh")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("MaKH");

                    b.Property<string>("DiaChi")
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("DienThoai")
                        .HasMaxLength(24)
                        .HasColumnType("nvarchar(24)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("GioiTinh")
                        .HasColumnType("bit");

                    b.Property<bool>("HieuLuc")
                        .HasColumnType("bit");

                    b.Property<string>("Hinh")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasDefaultValue("Photo.gif");

                    b.Property<string>("HoTen")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("MatKhau")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("NgaySinh")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<string>("RandomKey")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<int>("VaiTro")
                        .HasColumnType("int");

                    b.HasKey("MaKh")
                        .HasName("PK_Customers");

                    b.ToTable("KhachHang", (string)null);
                });

            modelBuilder.Entity("ECommerceMVC.Data.Loai", b =>
                {
                    b.Property<int>("MaLoai")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaLoai"));

                    b.Property<string>("Hinh")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("MoTa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenLoai")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("TenLoaiAlias")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("MaLoai")
                        .HasName("PK_Categories");

                    b.ToTable("Loai", (string)null);
                });

            modelBuilder.Entity("ECommerceMVC.Data.NhaCungCap", b =>
                {
                    b.Property<string>("MaNcc")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("MaNCC");

                    b.Property<string>("DiaChi")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("DienThoai")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Logo")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("MoTa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NguoiLienLac")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("TenCongTy")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("MaNcc")
                        .HasName("PK_Suppliers");

                    b.ToTable("NhaCungCap", (string)null);
                });

            modelBuilder.Entity("ECommerceMVC.Data.TrangThai", b =>
                {
                    b.Property<int>("MaTrangThai")
                        .HasColumnType("int");

                    b.Property<string>("MoTa")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("TenTrangThai")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("MaTrangThai");

                    b.ToTable("TrangThai", (string)null);
                });

            modelBuilder.Entity("ECommerceMVC.Data.TrangWeb", b =>
                {
                    b.Property<int>("MaTrang")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaTrang"));

                    b.Property<string>("TenTrang")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)")
                        .HasColumnName("URL");

                    b.HasKey("MaTrang");

                    b.ToTable("TrangWeb", (string)null);
                });

            modelBuilder.Entity("ECommerceMVC.Data.VChiTietHoaDon", b =>
                {
                    b.Property<double>("DonGia")
                        .HasColumnType("float");

                    b.Property<double>("GiamGia")
                        .HasColumnType("float");

                    b.Property<int>("MaCt")
                        .HasColumnType("int")
                        .HasColumnName("MaCT");

                    b.Property<int>("MaHd")
                        .HasColumnType("int")
                        .HasColumnName("MaHD");

                    b.Property<int>("MaHh")
                        .HasColumnType("int")
                        .HasColumnName("MaHH");

                    b.Property<int>("SoLuong")
                        .HasColumnType("int");

                    b.Property<string>("TenHh")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("TenHH");

                    b.ToTable((string)null);

                    b.ToView("vChiTietHoaDon", (string)null);
                });

            modelBuilder.Entity("ECommerceMVC.Data.ChiTietHd", b =>
                {
                    b.HasOne("ECommerceMVC.Data.HoaDon", "MaHdNavigation")
                        .WithMany("ChiTietHds")
                        .HasForeignKey("MaHd")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_OrderDetails_Orders");

                    b.HasOne("ECommerceMVC.Data.HangHoa", "MaHhNavigation")
                        .WithMany("ChiTietHds")
                        .HasForeignKey("MaHh")
                        .IsRequired()
                        .HasConstraintName("FK_OrderDetails_Products");

                    b.Navigation("MaHdNavigation");

                    b.Navigation("MaHhNavigation");
                });

            modelBuilder.Entity("ECommerceMVC.Data.HangHoa", b =>
                {
                    b.HasOne("ECommerceMVC.Data.Loai", "MaLoaiNavigation")
                        .WithMany("HangHoas")
                        .HasForeignKey("MaLoai")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_Products_Categories");

                    b.HasOne("ECommerceMVC.Data.NhaCungCap", "MaNccNavigation")
                        .WithMany("HangHoas")
                        .HasForeignKey("MaNcc")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_Products_Suppliers");

                    b.Navigation("MaLoaiNavigation");

                    b.Navigation("MaNccNavigation");
                });

            modelBuilder.Entity("ECommerceMVC.Data.HoaDon", b =>
                {
                    b.HasOne("ECommerceMVC.Data.KhachHang", "MaKhNavigation")
                        .WithMany("HoaDons")
                        .HasForeignKey("MaKh")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_Orders_Customers");

                    b.HasOne("ECommerceMVC.Data.TrangThai", "MaTrangThaiNavigation")
                        .WithMany("HoaDons")
                        .HasForeignKey("MaTrangThai")
                        .IsRequired()
                        .HasConstraintName("FK_HoaDon_TrangThai");

                    b.Navigation("MaKhNavigation");

                    b.Navigation("MaTrangThaiNavigation");
                });

            modelBuilder.Entity("ECommerceMVC.Data.HangHoa", b =>
                {
                    b.Navigation("ChiTietHds");
                });

            modelBuilder.Entity("ECommerceMVC.Data.HoaDon", b =>
                {
                    b.Navigation("ChiTietHds");
                });

            modelBuilder.Entity("ECommerceMVC.Data.KhachHang", b =>
                {
                    b.Navigation("HoaDons");
                });

            modelBuilder.Entity("ECommerceMVC.Data.Loai", b =>
                {
                    b.Navigation("HangHoas");
                });

            modelBuilder.Entity("ECommerceMVC.Data.NhaCungCap", b =>
                {
                    b.Navigation("HangHoas");
                });

            modelBuilder.Entity("ECommerceMVC.Data.TrangThai", b =>
                {
                    b.Navigation("HoaDons");
                });
#pragma warning restore 612, 618
        }
    }
}
