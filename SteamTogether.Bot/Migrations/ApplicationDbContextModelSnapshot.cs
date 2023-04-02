﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SteamTogether.Bot.Context;

#nullable disable

namespace SteamTogether.Bot.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.4");

            modelBuilder.Entity("SteamPlayerTelegramChat", b =>
                {
                    b.Property<string>("PlayerId")
                        .HasColumnType("TEXT");

                    b.Property<long>("ChatId")
                        .HasColumnType("INTEGER");

                    b.HasKey("PlayerId", "ChatId");

                    b.HasIndex("ChatId");

                    b.ToTable("SteamPlayerTelegramChat");

                    b.HasData(
                        new
                        {
                            PlayerId = "76561198068819558",
                            ChatId = 1L
                        },
                        new
                        {
                            PlayerId = "zebradil",
                            ChatId = 1L
                        });
                });

            modelBuilder.Entity("SteamTogether.Bot.Models.SteamPlayer", b =>
                {
                    b.Property<string>("PlayerId")
                        .HasColumnType("TEXT");

                    b.Property<string>("ApiKey")
                        .HasColumnType("TEXT");

                    b.HasKey("PlayerId");

                    b.ToTable("SteamPlayers");

                    b.HasData(
                        new
                        {
                            PlayerId = "76561198068819558"
                        },
                        new
                        {
                            PlayerId = "zebradil"
                        });
                });

            modelBuilder.Entity("SteamTogether.Bot.Models.TelegramChat", b =>
                {
                    b.Property<long>("ChatId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.HasKey("ChatId");

                    b.ToTable("TelegramChat");

                    b.HasData(
                        new
                        {
                            ChatId = 1L
                        });
                });

            modelBuilder.Entity("SteamPlayerTelegramChat", b =>
                {
                    b.HasOne("SteamTogether.Bot.Models.TelegramChat", null)
                        .WithMany()
                        .HasForeignKey("ChatId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SteamTogether.Bot.Models.SteamPlayer", null)
                        .WithMany()
                        .HasForeignKey("PlayerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
