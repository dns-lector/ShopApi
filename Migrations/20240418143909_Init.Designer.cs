﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ShopApi.Data;

#nullable disable

namespace ShopApi.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20240418143909_Init")]
    partial class Init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ShopApi.Data.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Slug")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("Slug")
                        .IsUnique();

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = new Guid("25044c03-549f-4a52-86c3-975196966aa1"),
                            Description = "Декоративні та сувенірні товари зі скла",
                            ImageUrl = "glass.jpg",
                            IsActive = true,
                            Name = "Вироби зі скла",
                            Slug = "glass"
                        },
                        new
                        {
                            Id = new Guid("d6b69746-b24c-4f42-927b-78c1d539af38"),
                            Description = "Сувенірні товари для встановлення на стіл",
                            ImageUrl = "office.jpg",
                            IsActive = true,
                            Name = "Товари для офісу",
                            Slug = "office"
                        },
                        new
                        {
                            Id = new Guid("62bab42b-3652-42f6-b3c1-221ce296d66d"),
                            Description = "Декоративні та сувенірні товари з каменю",
                            ImageUrl = "stone.jpg",
                            IsActive = true,
                            Name = "Вироби з каменю",
                            Slug = "stone"
                        },
                        new
                        {
                            Id = new Guid("fd7cc5c1-3543-4bd6-b36c-64cf7e8f9030"),
                            Description = "Практичні та декоративні товари з деревини",
                            ImageUrl = "wood.jpg",
                            IsActive = true,
                            Name = "Вироби з деревини",
                            Slug = "wood"
                        });
                });

            modelBuilder.Entity("ShopApi.Data.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PriceCent")
                        .HasColumnType("int");

                    b.Property<string>("Slug")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("Slug")
                        .IsUnique();

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = new Guid("bef5a5dc-8bbb-485b-adcf-dcf9b7f62e72"),
                            CategoryId = new Guid("25044c03-549f-4a52-86c3-975196966aa1"),
                            Description = "Декоративна скляна сфера з ялинкою",
                            ImageUrl = "glass1.png",
                            IsActive = true,
                            Name = "Сфера з ялинкою",
                            PriceCent = 32050,
                            Slug = "glass1"
                        },
                        new
                        {
                            Id = new Guid("c6759bfd-8463-4601-aaea-3f4902402dbd"),
                            CategoryId = new Guid("25044c03-549f-4a52-86c3-975196966aa1"),
                            Description = "Фігурка бика з кольорового скла",
                            ImageUrl = "glass2.jpg",
                            IsActive = true,
                            Name = "Бик",
                            PriceCent = 41000,
                            Slug = "glass2"
                        },
                        new
                        {
                            Id = new Guid("e362e363-205d-439e-9778-2b504c34e9a3"),
                            CategoryId = new Guid("25044c03-549f-4a52-86c3-975196966aa1"),
                            Description = "Декоративна скляна сфера з гелікоптером",
                            ImageUrl = "glass3.jpg",
                            IsActive = true,
                            Name = "Гелікоптер",
                            PriceCent = 33050,
                            Slug = "glass3"
                        },
                        new
                        {
                            Id = new Guid("eead4f41-cd3f-44ca-83d7-68b79d80e880"),
                            CategoryId = new Guid("25044c03-549f-4a52-86c3-975196966aa1"),
                            Description = "Фігурка лисиці з кольорового скла",
                            ImageUrl = "glass4.jpeg",
                            IsActive = true,
                            Name = "Лис",
                            PriceCent = 25000,
                            Slug = "glass4"
                        },
                        new
                        {
                            Id = new Guid("7cadc8af-3b7d-449f-a003-c99658fb693b"),
                            CategoryId = new Guid("25044c03-549f-4a52-86c3-975196966aa1"),
                            Description = "Скляна настільна форма для цукерок",
                            ImageUrl = "glass5.jpg",
                            IsActive = true,
                            Name = "Цукерниця",
                            PriceCent = 37000,
                            Slug = "glass5"
                        },
                        new
                        {
                            Id = new Guid("0df61203-45d5-47e6-acad-0eef86f3757a"),
                            CategoryId = new Guid("25044c03-549f-4a52-86c3-975196966aa1"),
                            Description = "Фігурка павича з кольорового скла",
                            ImageUrl = "glass6.jpg",
                            IsActive = true,
                            Name = "Пава",
                            PriceCent = 19000,
                            Slug = "glass6"
                        },
                        new
                        {
                            Id = new Guid("d31b9563-1292-483a-89ca-ae0caa50a244"),
                            CategoryId = new Guid("25044c03-549f-4a52-86c3-975196966aa1"),
                            Description = "Фігурка кота з прозорого скла",
                            ImageUrl = "glass7.jpg",
                            IsActive = true,
                            Name = "Кіт",
                            PriceCent = 41050,
                            Slug = "glass7"
                        },
                        new
                        {
                            Id = new Guid("87972425-8713-4f0c-85e5-536ba16eee4f"),
                            CategoryId = new Guid("25044c03-549f-4a52-86c3-975196966aa1"),
                            Description = "Декоративна скляна сфера з терезами",
                            ImageUrl = "glass8.jpg",
                            IsActive = true,
                            Name = "Ваги",
                            PriceCent = 34000,
                            Slug = "glass8"
                        },
                        new
                        {
                            Id = new Guid("fe434459-bb36-4a09-9494-395504531286"),
                            CategoryId = new Guid("d6b69746-b24c-4f42-927b-78c1d539af38"),
                            Description = "Декоративний настільний маятник у формі вершника",
                            ImageUrl = "office1.jpeg",
                            IsActive = true,
                            Name = "Вершник",
                            PriceCent = 39050,
                            Slug = "office1"
                        },
                        new
                        {
                            Id = new Guid("3d149a4c-cf4c-403a-b524-e107f684bbae"),
                            CategoryId = new Guid("d6b69746-b24c-4f42-927b-78c1d539af38"),
                            Description = "Декоративний настільний маятник Ньютона",
                            ImageUrl = "office2.jpg",
                            IsActive = true,
                            Name = "Маятник Ньютона",
                            PriceCent = 42000,
                            Slug = "office2"
                        },
                        new
                        {
                            Id = new Guid("b466382a-a59b-471a-a847-4a53b582da09"),
                            CategoryId = new Guid("d6b69746-b24c-4f42-927b-78c1d539af38"),
                            Description = "Декоративна настільна фігурка",
                            ImageUrl = "office3.jpg",
                            IsActive = true,
                            Name = "Сонцеворот",
                            PriceCent = 33000,
                            Slug = "office3"
                        },
                        new
                        {
                            Id = new Guid("b1659daa-ed1a-4937-b795-12d03f755520"),
                            CategoryId = new Guid("d6b69746-b24c-4f42-927b-78c1d539af38"),
                            Description = "Декоративний настільний маятник у формі Жордана",
                            ImageUrl = "office4.jpg",
                            IsActive = true,
                            Name = "Маятник Жордана",
                            PriceCent = 37500,
                            Slug = "office4"
                        },
                        new
                        {
                            Id = new Guid("87b48b86-6347-4a12-8f7d-31d89fc2f793"),
                            CategoryId = new Guid("d6b69746-b24c-4f42-927b-78c1d539af38"),
                            Description = "Прес для паперів у формі штурвалу",
                            ImageUrl = "office5.jpeg",
                            IsActive = true,
                            Name = "Штурвал",
                            PriceCent = 34550,
                            Slug = "office5"
                        },
                        new
                        {
                            Id = new Guid("ab475e6d-3c31-40bc-bede-01c9950fb597"),
                            CategoryId = new Guid("d6b69746-b24c-4f42-927b-78c1d539af38"),
                            Description = "Декоративний настільний маятник у формі планетарної системи",
                            ImageUrl = "office6.jpg",
                            IsActive = true,
                            Name = "Система",
                            PriceCent = 32500,
                            Slug = "office6"
                        },
                        new
                        {
                            Id = new Guid("5fd8b900-ebff-4a0b-a782-a25827555046"),
                            CategoryId = new Guid("d6b69746-b24c-4f42-927b-78c1d539af38"),
                            Description = "Декоративний настільний маятник у формі орбітальних кульок",
                            ImageUrl = "office7.jpg",
                            IsActive = true,
                            Name = "Маятник",
                            PriceCent = 35000,
                            Slug = "office7"
                        },
                        new
                        {
                            Id = new Guid("d714a1c5-3586-4c3b-9b77-d450813c6816"),
                            CategoryId = new Guid("62bab42b-3652-42f6-b3c1-221ce296d66d"),
                            Description = "Посуд-цукорниця з природнього каменю",
                            ImageUrl = "stone1.jpg",
                            IsActive = true,
                            Name = "Цукорниця",
                            PriceCent = 35000,
                            Slug = "stone1"
                        },
                        new
                        {
                            Id = new Guid("fbafcf92-f5ed-4576-815a-293dfc15af61"),
                            CategoryId = new Guid("62bab42b-3652-42f6-b3c1-221ce296d66d"),
                            Description = "Декоративна фігурка у формі груши з природнього каменю",
                            ImageUrl = "stone2.jpg",
                            IsActive = true,
                            Name = "Груша",
                            PriceCent = 40000,
                            Slug = "stone2"
                        },
                        new
                        {
                            Id = new Guid("8831cc8b-2ef1-402d-a2d3-00ab4fa11cc8"),
                            CategoryId = new Guid("62bab42b-3652-42f6-b3c1-221ce296d66d"),
                            Description = "Фігурка-амулет у формі сови",
                            ImageUrl = "stone3.jpg",
                            IsActive = true,
                            Name = "Сова",
                            PriceCent = 30000,
                            Slug = "stone3"
                        },
                        new
                        {
                            Id = new Guid("b574fa3b-3053-4a7f-974f-1ec777a8d4fd"),
                            CategoryId = new Guid("fd7cc5c1-3543-4bd6-b36c-64cf7e8f9030"),
                            Description = "Кошик з дерева середнього розміру",
                            ImageUrl = "wood1.jpg",
                            IsActive = true,
                            Name = "Кошик",
                            PriceCent = 48000,
                            Slug = "wood1"
                        },
                        new
                        {
                            Id = new Guid("c7226697-c40c-41ed-8a6e-0acab3637691"),
                            CategoryId = new Guid("fd7cc5c1-3543-4bd6-b36c-64cf7e8f9030"),
                            Description = "Сувенір - булава з дерева",
                            ImageUrl = "wood2.jpg",
                            IsActive = true,
                            Name = "Булава",
                            PriceCent = 85000,
                            Slug = "wood2"
                        },
                        new
                        {
                            Id = new Guid("6f6a5542-41dd-4aff-ab50-9ee37b59c8aa"),
                            CategoryId = new Guid("fd7cc5c1-3543-4bd6-b36c-64cf7e8f9030"),
                            Description = "Набір кухолів з дерева",
                            ImageUrl = "wood3.jpg",
                            IsActive = true,
                            Name = "Кухолі",
                            PriceCent = 21000,
                            Slug = "wood3"
                        },
                        new
                        {
                            Id = new Guid("cb54c85d-a9cd-4068-8bba-234af7f8107d"),
                            CategoryId = new Guid("fd7cc5c1-3543-4bd6-b36c-64cf7e8f9030"),
                            Description = "Настільна підставка для олівців з черепахою",
                            ImageUrl = "wood4.jpg",
                            IsActive = true,
                            Name = "Черепаха",
                            PriceCent = 42050,
                            Slug = "wood4"
                        },
                        new
                        {
                            Id = new Guid("35755354-fda6-4cba-b39d-d657067c6b39"),
                            CategoryId = new Guid("fd7cc5c1-3543-4bd6-b36c-64cf7e8f9030"),
                            Description = "Декоративний твір з дерева",
                            ImageUrl = "wood5.jpeg",
                            IsActive = true,
                            Name = "Леви",
                            PriceCent = 54000,
                            Slug = "wood5"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
