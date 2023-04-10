﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SteamTogether.Core.Context;

#nullable disable

namespace SteamTogether.Core.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230410170820_Games")]
    partial class Games
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.4");

            modelBuilder.Entity("SteamPlayerSteamGame", b =>
                {
                    b.Property<ulong>("PlayerId")
                        .HasColumnType("INTEGER");

                    b.Property<uint>("GameId")
                        .HasColumnType("INTEGER");

                    b.HasKey("PlayerId", "GameId");

                    b.HasIndex("GameId");

                    b.ToTable("SteamPlayerSteamGame");
                });

            modelBuilder.Entity("SteamPlayerTelegramChat", b =>
                {
                    b.Property<ulong>("PlayerId")
                        .HasColumnType("INTEGER");

                    b.Property<long>("ChatId")
                        .HasColumnType("INTEGER");

                    b.HasKey("PlayerId", "ChatId");

                    b.HasIndex("ChatId");

                    b.ToTable("SteamPlayerTelegramChat");
                });

            modelBuilder.Entity("SteamTogether.Core.Models.SteamGame", b =>
                {
                    b.Property<uint>("GameId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("LastSyncDateTime")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Multiplayer")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<uint>("SteamAppId")
                        .HasColumnType("INTEGER");

                    b.HasKey("GameId");

                    b.ToTable("SteamGames");
                });

            modelBuilder.Entity("SteamTogether.Core.Models.SteamPlayer", b =>
                {
                    b.Property<ulong>("PlayerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ApiKey")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("LastSyncDateTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("PlayerId");

                    b.ToTable("SteamPlayers");
                });

            modelBuilder.Entity("SteamTogether.Core.Models.TelegramChat", b =>
                {
                    b.Property<long>("ChatId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.HasKey("ChatId");

                    b.ToTable("TelegramChat");
                });

            modelBuilder.Entity("SteamPlayerSteamGame", b =>
                {
                    b.HasOne("SteamTogether.Core.Models.SteamGame", null)
                        .WithMany()
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SteamTogether.Core.Models.SteamPlayer", null)
                        .WithMany()
                        .HasForeignKey("PlayerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SteamPlayerTelegramChat", b =>
                {
                    b.HasOne("SteamTogether.Core.Models.TelegramChat", null)
                        .WithMany()
                        .HasForeignKey("ChatId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SteamTogether.Core.Models.SteamPlayer", null)
                        .WithMany()
                        .HasForeignKey("PlayerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
