﻿// <auto-generated />
using System;
using DataAccesLayer.Concrete.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccesLayer.Migrations
{
    [DbContext(typeof(EstateDbContext))]
    [Migration("20231026115156_mig-1")]
    partial class mig1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EntityLayer.Concrete.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CreatedDate = new DateTime(2023, 10, 26, 14, 51, 56, 356, DateTimeKind.Local).AddTicks(1646),
                            Name = "Satılık",
                            Status = 1
                        },
                        new
                        {
                            CategoryId = 2,
                            CreatedDate = new DateTime(2023, 10, 26, 14, 51, 56, 356, DateTimeKind.Local).AddTicks(1655),
                            Name = "Kiralık",
                            Status = 1
                        });
                });

            modelBuilder.Entity("EntityLayer.Concrete.City", b =>
                {
                    b.Property<int>("CityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CityId"));

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CityId");

                    b.ToTable("Cities");

                    b.HasData(
                        new
                        {
                            CityId = 1,
                            Name = "Adana"
                        },
                        new
                        {
                            CityId = 2,
                            Name = "Adıyaman"
                        });
                });

            modelBuilder.Entity("EntityLayer.Concrete.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomerId"));

                    b.Property<int?>("Budget")
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("EstateTypeId")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("CustomerId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("CityId");

                    b.HasIndex("EstateTypeId");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            CustomerId = 1,
                            Budget = 5000000,
                            CategoryId = 1,
                            CityId = 1,
                            CreatedDate = new DateTime(2023, 10, 26, 14, 51, 56, 356, DateTimeKind.Local).AddTicks(1914),
                            EstateTypeId = 2,
                            LastName = "Baler",
                            Mail = "semihbaler@gmail.com",
                            Name = "Semih",
                            Status = 1
                        },
                        new
                        {
                            CustomerId = 2,
                            Budget = 12000,
                            CategoryId = 2,
                            CityId = 1,
                            CreatedDate = new DateTime(2023, 10, 26, 14, 51, 56, 356, DateTimeKind.Local).AddTicks(1918),
                            EstateTypeId = 1,
                            LastName = "Baler",
                            Name = "Merve",
                            Status = 1
                        });
                });

            modelBuilder.Entity("EntityLayer.Concrete.District", b =>
                {
                    b.Property<int>("DistrictId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DistrictId"));

                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DistrictId");

                    b.HasIndex("CityId");

                    b.ToTable("Districts");

                    b.HasData(
                        new
                        {
                            DistrictId = 1,
                            CityId = 1,
                            Name = "Seyhan"
                        },
                        new
                        {
                            DistrictId = 2,
                            CityId = 1,
                            Name = "Ceyhan"
                        });
                });

            modelBuilder.Entity("EntityLayer.Concrete.Estate", b =>
                {
                    b.Property<int>("EstateId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EstateId"));

                    b.Property<string>("Adress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("EstateTypeId")
                        .HasColumnType("int");

                    b.Property<int?>("Price")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("EstateId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("CityId");

                    b.HasIndex("EstateTypeId");

                    b.ToTable("Estates");

                    b.HasData(
                        new
                        {
                            EstateId = 1,
                            Adress = "Bağlıca",
                            CategoryId = 1,
                            CityId = 1,
                            CreatedDate = new DateTime(2023, 10, 26, 14, 51, 56, 356, DateTimeKind.Local).AddTicks(1981),
                            EstateTypeId = 2,
                            Price = 7500000,
                            Status = 1
                        },
                        new
                        {
                            EstateId = 2,
                            Adress = "Alacaatlı",
                            CategoryId = 1,
                            CityId = 1,
                            CreatedDate = new DateTime(2023, 10, 26, 14, 51, 56, 356, DateTimeKind.Local).AddTicks(1983),
                            EstateTypeId = 3,
                            Price = 12000000,
                            Status = 1
                        });
                });

            modelBuilder.Entity("EntityLayer.Concrete.EstateType", b =>
                {
                    b.Property<int>("EstateTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EstateTypeId"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("EstateTypeId");

                    b.ToTable("EstateType");

                    b.HasData(
                        new
                        {
                            EstateTypeId = 1,
                            CreatedDate = new DateTime(2023, 10, 26, 14, 51, 56, 356, DateTimeKind.Local).AddTicks(2027),
                            Name = "Müstakil",
                            Status = 1
                        },
                        new
                        {
                            EstateTypeId = 2,
                            CreatedDate = new DateTime(2023, 10, 26, 14, 51, 56, 356, DateTimeKind.Local).AddTicks(2028),
                            Name = "Daire",
                            Status = 1
                        },
                        new
                        {
                            EstateTypeId = 3,
                            CreatedDate = new DateTime(2023, 10, 26, 14, 51, 56, 356, DateTimeKind.Local).AddTicks(2029),
                            Name = "Arsa",
                            Status = 1
                        });
                });

            modelBuilder.Entity("EntityLayer.Concrete.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("UserId");

                    b.ToTable("User");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            CreatedDate = new DateTime(2023, 10, 26, 14, 51, 56, 356, DateTimeKind.Local).AddTicks(2073),
                            Name = "Ahmet",
                            Role = "User",
                            Status = 1
                        },
                        new
                        {
                            UserId = 2,
                            CreatedDate = new DateTime(2023, 10, 26, 14, 51, 56, 356, DateTimeKind.Local).AddTicks(2074),
                            Name = "Mehmet",
                            Role = "Customer",
                            Status = 1
                        },
                        new
                        {
                            UserId = 3,
                            CreatedDate = new DateTime(2023, 10, 26, 14, 51, 56, 356, DateTimeKind.Local).AddTicks(2075),
                            Name = "Yade",
                            Role = "Admin",
                            Status = 1
                        });
                });

            modelBuilder.Entity("EntityLayer.Concrete.Customer", b =>
                {
                    b.HasOne("EntityLayer.Concrete.Category", "Category")
                        .WithMany("Customers")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityLayer.Concrete.City", "City")
                        .WithMany("Customers")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityLayer.Concrete.EstateType", "EstateType")
                        .WithMany("Customers")
                        .HasForeignKey("EstateTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("City");

                    b.Navigation("EstateType");
                });

            modelBuilder.Entity("EntityLayer.Concrete.District", b =>
                {
                    b.HasOne("EntityLayer.Concrete.City", "City")
                        .WithMany("Districts")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Estate", b =>
                {
                    b.HasOne("EntityLayer.Concrete.Category", "Category")
                        .WithMany("Estates")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityLayer.Concrete.City", "City")
                        .WithMany("Estates")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityLayer.Concrete.EstateType", "EstateType")
                        .WithMany("Estates")
                        .HasForeignKey("EstateTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("City");

                    b.Navigation("EstateType");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Category", b =>
                {
                    b.Navigation("Customers");

                    b.Navigation("Estates");
                });

            modelBuilder.Entity("EntityLayer.Concrete.City", b =>
                {
                    b.Navigation("Customers");

                    b.Navigation("Districts");

                    b.Navigation("Estates");
                });

            modelBuilder.Entity("EntityLayer.Concrete.EstateType", b =>
                {
                    b.Navigation("Customers");

                    b.Navigation("Estates");
                });
#pragma warning restore 612, 618
        }
    }
}