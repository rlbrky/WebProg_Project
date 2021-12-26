﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebProg_Project.Data;

namespace WebProg_Project.Migrations
{
    [DbContext(typeof(WebProg_ProjectContext))]
    [Migration("20211226042740_ChampionCreate")]
    partial class ChampionCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebProg_Project.Models.Champion", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("Blurb")
                        .IsRequired()
                        .HasMaxLength(2147483647)
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Key")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("Id");

                    b.ToTable("Champion");
                });

            modelBuilder.Entity("WebProg_Project.Models.Summoner", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("AccountId")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<int>("ProfileIconId")
                        .HasColumnType("int");

                    b.Property<string>("PuuId")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<DateTime>("RevisionDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("SummonerLevel")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Summoner");
                });

            modelBuilder.Entity("WebProg_Project.Models.SummonerChampionMastery", b =>
                {
                    b.Property<string>("ChampionId")
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<int>("ChampionLevel")
                        .HasColumnType("int");

                    b.Property<int>("ChampionPoint")
                        .HasColumnType("int");

                    b.Property<bool>("ChestGranted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("LastPlayTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("SummonerId")
                        .IsRequired()
                        .HasColumnType("nvarchar(150)");

                    b.Property<int>("TokensEarned")
                        .HasColumnType("int");

                    b.HasKey("ChampionId");

                    b.HasIndex("SummonerId");

                    b.ToTable("SummonerChampionMastery");
                });

            modelBuilder.Entity("WebProg_Project.Models.SummonerChampionMastery", b =>
                {
                    b.HasOne("WebProg_Project.Models.Summoner", "Summoner")
                        .WithMany()
                        .HasForeignKey("SummonerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Summoner");
                });
#pragma warning restore 612, 618
        }
    }
}