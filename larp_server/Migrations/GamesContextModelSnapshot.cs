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
                    b.Property<string>("Id")
                        .HasColumnType("varchar(767)");

                    b.Property<double>("Latitude")
                        .HasColumnType("double");

                    b.Property<double>("Longitude")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.ToTable("Coords");
                });

            modelBuilder.Entity("larp_server.Models.Player", b =>
                {
                    b.Property<string>("Name")
                        .HasColumnType("varchar(767)");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .HasColumnType("text");

                    b.HasKey("Name");

                    b.ToTable("Player");
                });

            modelBuilder.Entity("larp_server.Models.PlayerRoom", b =>
                {
                    b.Property<string>("PlayerName")
                        .HasColumnType("varchar(767)");

                    b.Property<string>("RoomName")
                        .HasColumnType("varchar(767)");

                    b.HasKey("PlayerName", "RoomName");

                    b.HasIndex("RoomName");

                    b.ToTable("PlayerRoom");
                });

            modelBuilder.Entity("larp_server.Models.Room", b =>
                {
                    b.Property<string>("Name")
                        .HasColumnType("varchar(767)");

                    b.HasKey("Name");

                    b.ToTable("Room");
                });

            modelBuilder.Entity("larp_server.Models.PlayerRoom", b =>
                {
                    b.HasOne("larp_server.Models.Player", "Player")
                        .WithMany("PlayerRoomList")
                        .HasForeignKey("PlayerName")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("larp_server.Models.Room", "Room")
                        .WithMany("PlayerRoomList")
                        .HasForeignKey("RoomName")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
