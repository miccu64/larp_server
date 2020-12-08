﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Server.Models;

namespace larp_server.Migrations
{
    [DbContext(typeof(GamesContext))]
    partial class GamesContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("larp_server.Models.Coord", b =>
                {
                    b.Property<string>("PlayerName")
                        .HasColumnType("varchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("RoomName")
                        .HasColumnType("varchar(30)")
                        .HasMaxLength(30);

                    b.Property<bool>("IsConnected")
                        .HasColumnType("bit");

                    b.Property<double>("Latitude")
                        .HasColumnType("double");

                    b.Property<double>("Longitude")
                        .HasColumnType("double");

                    b.Property<string>("PlayerNickname")
                        .HasColumnType("varchar(30)");

                    b.Property<int>("TeamId")
                        .HasColumnType("int");

                    b.HasKey("PlayerName", "RoomName");

                    b.HasIndex("PlayerNickname");

                    b.HasIndex("RoomName");

                    b.ToTable("Coords");
                });

            modelBuilder.Entity("larp_server.Models.Player", b =>
                {
                    b.Property<string>("Nickname")
                        .HasColumnType("varchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("ConnectionID")
                        .HasColumnType("varchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("Email")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("varchar(80)")
                        .HasMaxLength(80);

                    b.Property<string>("Password")
                        .HasColumnType("varchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("Token")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("varchar(150)")
                        .HasMaxLength(150);

                    b.HasKey("Nickname");

                    b.ToTable("Players");
                });

            modelBuilder.Entity("larp_server.Models.Room", b =>
                {
                    b.Property<string>("Name")
                        .HasColumnType("varchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("AdminNickname")
                        .HasColumnType("varchar(30)");

                    b.Property<string>("Password")
                        .HasColumnType("varchar(30)")
                        .HasMaxLength(30);

                    b.HasKey("Name");

                    b.HasIndex("AdminNickname");

                    b.ToTable("Rooms");
                });

            modelBuilder.Entity("larp_server.Models.Coord", b =>
                {
                    b.HasOne("larp_server.Models.Player", "Player")
                        .WithMany("CoordsList")
                        .HasForeignKey("PlayerNickname");

                    b.HasOne("larp_server.Models.Room", "Room")
                        .WithMany("CoordsList")
                        .HasForeignKey("RoomName")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("larp_server.Models.Room", b =>
                {
                    b.HasOne("larp_server.Models.Player", "Admin")
                        .WithMany()
                        .HasForeignKey("AdminNickname");
                });
#pragma warning restore 612, 618
        }
    }
}
