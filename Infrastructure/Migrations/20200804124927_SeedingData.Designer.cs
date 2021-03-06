﻿// <auto-generated />
using System;
using Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Infrastructure.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20200804124927_SeedingData")]
    partial class SeedingData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Core.Entities.Ad", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("company")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("text")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("url")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Ad");
                });

            modelBuilder.Entity("Core.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("adId")
                        .HasColumnType("int");

                    b.Property<string>("avatar")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("first_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("last_name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("adId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            avatar = "https://s3.amazonaws.com/uifaces/faces/twitter/calebogden/128.jpg",
                            email = "george.bluth@reqres.in",
                            first_name = "George",
                            last_name = "Bluth"
                        },
                        new
                        {
                            Id = 2,
                            avatar = "https://s3.amazonaws.com/uifaces/faces/twitter/josephstein/128.jpg",
                            email = "janet.weaver@reqres.in",
                            first_name = "Janet",
                            last_name = "Weaver"
                        },
                        new
                        {
                            Id = 3,
                            avatar = "https://s3.amazonaws.com/uifaces/faces/twitter/olegpogodaev/128.jpg",
                            email = "emma.wong@reqres.in",
                            first_name = "Emma",
                            last_name = "Wong"
                        },
                        new
                        {
                            Id = 4,
                            avatar = "https://s3.amazonaws.com/uifaces/faces/twitter/marcoramires/128.jpg",
                            email = "eve.holt@reqres.in",
                            first_name = "Eve",
                            last_name = "Holt"
                        },
                        new
                        {
                            Id = 5,
                            avatar = "https://s3.amazonaws.com/uifaces/faces/twitter/stephenmoon/128.jpg",
                            email = "charles.morris@reqres.in",
                            first_name = "Charles",
                            last_name = "Morris"
                        },
                        new
                        {
                            Id = 6,
                            avatar = "https://s3.amazonaws.com/uifaces/faces/twitter/bigmancho/128.jpg",
                            email = "tracey.ramos@reqres.in",
                            first_name = "Tracey",
                            last_name = "Ramos"
                        });
                });

            modelBuilder.Entity("Core.Entities.User", b =>
                {
                    b.HasOne("Core.Entities.Ad", "ad")
                        .WithMany()
                        .HasForeignKey("adId");
                });
#pragma warning restore 612, 618
        }
    }
}
