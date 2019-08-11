﻿// <auto-generated />
using System;
using EasyJamCore.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EasyJamCore.DAL.Migrations
{
    [DbContext(typeof(EasyJamCoreDbContext))]
    [Migration("20190811140756_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EasyJamCore.DAL.Entities.BattleEntity", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BattleName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int?>("BattlePreliminaryID");

                    b.Property<int?>("JamEntityID");

                    b.Property<string>("Location")
                        .IsRequired();

                    b.Property<DateTime>("ScheduledTime");

                    b.Property<DateTime>("StartTime");

                    b.Property<int>("Type");

                    b.HasKey("ID");

                    b.HasIndex("BattlePreliminaryID");

                    b.HasIndex("JamEntityID");

                    b.ToTable("BattleEntity");
                });

            modelBuilder.Entity("EasyJamCore.DAL.Entities.BattleParticipantEntity", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BattleBlaze")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int?>("BattleEntityID");

                    b.Property<int?>("BattlePreliminaryEntityID");

                    b.Property<int?>("BattleRoundEntityID");

                    b.Property<int?>("Rank");

                    b.Property<DateTime>("SubscritpionDate");

                    b.HasKey("ID");

                    b.HasIndex("BattleEntityID");

                    b.HasIndex("BattlePreliminaryEntityID");

                    b.HasIndex("BattleRoundEntityID");

                    b.ToTable("BattleParticipantEntity");
                });

            modelBuilder.Entity("EasyJamCore.DAL.Entities.BattlePreliminaryEntity", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("ScheduledTime");

                    b.Property<DateTime>("StartTime");

                    b.HasKey("ID");

                    b.ToTable("BattlePreliminaryEntity");
                });

            modelBuilder.Entity("EasyJamCore.DAL.Entities.BattleRoundEntity", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BattleEntityID");

                    b.Property<int?>("BattlePreliminaryEntityID");

                    b.Property<int?>("LoserID");

                    b.Property<int>("Order");

                    b.Property<DateTime>("ScheduledTime");

                    b.Property<DateTime>("StartTime");

                    b.Property<int?>("WinnerID");

                    b.HasKey("ID");

                    b.HasIndex("BattleEntityID");

                    b.HasIndex("BattlePreliminaryEntityID");

                    b.HasIndex("LoserID");

                    b.HasIndex("WinnerID");

                    b.ToTable("BattleRoundEntity");
                });

            modelBuilder.Entity("EasyJamCore.DAL.Entities.CityEntity", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CityName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int?>("CrewEntityID");

                    b.Property<int?>("DancerEntityID");

                    b.Property<int?>("DjEntityID");

                    b.Property<int?>("HostEntityID");

                    b.Property<int?>("JudgeEntityID");

                    b.Property<int?>("SpeakerEntityID");

                    b.HasKey("ID");

                    b.HasIndex("CrewEntityID");

                    b.HasIndex("DancerEntityID");

                    b.HasIndex("DjEntityID");

                    b.HasIndex("HostEntityID");

                    b.HasIndex("JudgeEntityID");

                    b.HasIndex("SpeakerEntityID");

                    b.ToTable("CityEntity");
                });

            modelBuilder.Entity("EasyJamCore.DAL.Entities.CountryEntity", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CountryName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int?>("CrewEntityID");

                    b.Property<int?>("DancerEntityID");

                    b.Property<int?>("DjEntityID");

                    b.Property<int?>("HostEntityID");

                    b.Property<int?>("JudgeEntityID");

                    b.Property<int?>("SpeakerEntityID");

                    b.HasKey("ID");

                    b.HasIndex("CrewEntityID");

                    b.HasIndex("DancerEntityID");

                    b.HasIndex("DjEntityID");

                    b.HasIndex("HostEntityID");

                    b.HasIndex("JudgeEntityID");

                    b.HasIndex("SpeakerEntityID");

                    b.ToTable("CountryEntity");
                });

            modelBuilder.Entity("EasyJamCore.DAL.Entities.CrewEntity", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BattleParticipantEntityID");

                    b.Property<string>("CrewName");

                    b.Property<int?>("DancerEntityID");

                    b.Property<int?>("DjEntityID");

                    b.Property<int?>("HostEntityID");

                    b.Property<int?>("JudgeEntityID");

                    b.Property<int?>("SpeakerEntityID");

                    b.HasKey("ID");

                    b.HasIndex("BattleParticipantEntityID");

                    b.HasIndex("DancerEntityID");

                    b.HasIndex("DjEntityID");

                    b.HasIndex("HostEntityID");

                    b.HasIndex("JudgeEntityID");

                    b.HasIndex("SpeakerEntityID");

                    b.ToTable("CrewEntity");
                });

            modelBuilder.Entity("EasyJamCore.DAL.Entities.DancerEntity", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Age");

                    b.Property<int?>("BattleParticipantEntityID");

                    b.Property<string>("Blaze")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("FirstName")
                        .HasMaxLength(50);

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasMaxLength(1);

                    b.Property<string>("LastName")
                        .HasMaxLength(50);

                    b.Property<DateTime>("SignInDate");

                    b.HasKey("ID");

                    b.HasIndex("BattleParticipantEntityID");

                    b.ToTable("DancerEntitiy");
                });

            modelBuilder.Entity("EasyJamCore.DAL.Entities.DjEntity", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Age");

                    b.Property<int?>("BattleEntityID");

                    b.Property<string>("Blaze")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("FirstName")
                        .HasMaxLength(50);

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasMaxLength(1);

                    b.Property<string>("LastName")
                        .HasMaxLength(50);

                    b.Property<DateTime>("SignInDate");

                    b.HasKey("ID");

                    b.HasIndex("BattleEntityID");

                    b.ToTable("DjEntity");
                });

            modelBuilder.Entity("EasyJamCore.DAL.Entities.HostEntity", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Age");

                    b.Property<string>("Blaze")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("FirstName")
                        .HasMaxLength(50);

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasMaxLength(1);

                    b.Property<int?>("JamEntityID");

                    b.Property<string>("LastName")
                        .HasMaxLength(50);

                    b.Property<DateTime>("SignInDate");

                    b.HasKey("ID");

                    b.HasIndex("JamEntityID");

                    b.ToTable("HostEntity");
                });

            modelBuilder.Entity("EasyJamCore.DAL.Entities.JamEntity", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CityID");

                    b.Property<int?>("CountryID");

                    b.Property<string>("JamName");

                    b.Property<string>("Location")
                        .IsRequired();

                    b.Property<DateTime>("ScheduledTime");

                    b.Property<DateTime>("StartTime");

                    b.HasKey("ID");

                    b.HasIndex("CityID");

                    b.HasIndex("CountryID");

                    b.ToTable("JamEntity");
                });

            modelBuilder.Entity("EasyJamCore.DAL.Entities.JudgeEntity", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Age");

                    b.Property<int?>("BattleEntityID");

                    b.Property<string>("Blaze")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("FirstName")
                        .HasMaxLength(50);

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasMaxLength(1);

                    b.Property<string>("LastName")
                        .HasMaxLength(50);

                    b.Property<DateTime>("SignInDate");

                    b.HasKey("ID");

                    b.HasIndex("BattleEntityID");

                    b.ToTable("JudgeEntity");
                });

            modelBuilder.Entity("EasyJamCore.DAL.Entities.SpeakerEntity", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Age");

                    b.Property<int?>("BattleEntityID");

                    b.Property<string>("Blaze")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("FirstName")
                        .HasMaxLength(50);

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasMaxLength(1);

                    b.Property<string>("LastName")
                        .HasMaxLength(50);

                    b.Property<DateTime>("SignInDate");

                    b.HasKey("ID");

                    b.HasIndex("BattleEntityID");

                    b.ToTable("SpeakerEntity");
                });

            modelBuilder.Entity("EasyJamCore.DAL.Entities.BattleEntity", b =>
                {
                    b.HasOne("EasyJamCore.DAL.Entities.BattlePreliminaryEntity", "BattlePreliminary")
                        .WithMany()
                        .HasForeignKey("BattlePreliminaryID");

                    b.HasOne("EasyJamCore.DAL.Entities.JamEntity")
                        .WithMany("Battle")
                        .HasForeignKey("JamEntityID");
                });

            modelBuilder.Entity("EasyJamCore.DAL.Entities.BattleParticipantEntity", b =>
                {
                    b.HasOne("EasyJamCore.DAL.Entities.BattleEntity")
                        .WithMany("BattleEntry")
                        .HasForeignKey("BattleEntityID");

                    b.HasOne("EasyJamCore.DAL.Entities.BattlePreliminaryEntity")
                        .WithMany("Participants")
                        .HasForeignKey("BattlePreliminaryEntityID");

                    b.HasOne("EasyJamCore.DAL.Entities.BattleRoundEntity")
                        .WithMany("Participants")
                        .HasForeignKey("BattleRoundEntityID");
                });

            modelBuilder.Entity("EasyJamCore.DAL.Entities.BattleRoundEntity", b =>
                {
                    b.HasOne("EasyJamCore.DAL.Entities.BattleEntity")
                        .WithMany("BattleRound")
                        .HasForeignKey("BattleEntityID");

                    b.HasOne("EasyJamCore.DAL.Entities.BattlePreliminaryEntity")
                        .WithMany("BattleRound")
                        .HasForeignKey("BattlePreliminaryEntityID");

                    b.HasOne("EasyJamCore.DAL.Entities.BattleParticipantEntity", "Loser")
                        .WithMany()
                        .HasForeignKey("LoserID");

                    b.HasOne("EasyJamCore.DAL.Entities.BattleParticipantEntity", "Winner")
                        .WithMany()
                        .HasForeignKey("WinnerID");
                });

            modelBuilder.Entity("EasyJamCore.DAL.Entities.CityEntity", b =>
                {
                    b.HasOne("EasyJamCore.DAL.Entities.CrewEntity")
                        .WithMany("CityEntity")
                        .HasForeignKey("CrewEntityID");

                    b.HasOne("EasyJamCore.DAL.Entities.DancerEntity")
                        .WithMany("CityEntity")
                        .HasForeignKey("DancerEntityID");

                    b.HasOne("EasyJamCore.DAL.Entities.DjEntity")
                        .WithMany("CityEntity")
                        .HasForeignKey("DjEntityID");

                    b.HasOne("EasyJamCore.DAL.Entities.HostEntity")
                        .WithMany("CityEntity")
                        .HasForeignKey("HostEntityID");

                    b.HasOne("EasyJamCore.DAL.Entities.JudgeEntity")
                        .WithMany("CityEntity")
                        .HasForeignKey("JudgeEntityID");

                    b.HasOne("EasyJamCore.DAL.Entities.SpeakerEntity")
                        .WithMany("CityEntity")
                        .HasForeignKey("SpeakerEntityID");
                });

            modelBuilder.Entity("EasyJamCore.DAL.Entities.CountryEntity", b =>
                {
                    b.HasOne("EasyJamCore.DAL.Entities.CrewEntity")
                        .WithMany("CountryEntity")
                        .HasForeignKey("CrewEntityID");

                    b.HasOne("EasyJamCore.DAL.Entities.DancerEntity")
                        .WithMany("CountryEntity")
                        .HasForeignKey("DancerEntityID");

                    b.HasOne("EasyJamCore.DAL.Entities.DjEntity")
                        .WithMany("CountryEntity")
                        .HasForeignKey("DjEntityID");

                    b.HasOne("EasyJamCore.DAL.Entities.HostEntity")
                        .WithMany("CountryEntity")
                        .HasForeignKey("HostEntityID");

                    b.HasOne("EasyJamCore.DAL.Entities.JudgeEntity")
                        .WithMany("CountryEntity")
                        .HasForeignKey("JudgeEntityID");

                    b.HasOne("EasyJamCore.DAL.Entities.SpeakerEntity")
                        .WithMany("CountryEntity")
                        .HasForeignKey("SpeakerEntityID");
                });

            modelBuilder.Entity("EasyJamCore.DAL.Entities.CrewEntity", b =>
                {
                    b.HasOne("EasyJamCore.DAL.Entities.BattleParticipantEntity")
                        .WithMany("Crew")
                        .HasForeignKey("BattleParticipantEntityID");

                    b.HasOne("EasyJamCore.DAL.Entities.DancerEntity")
                        .WithMany("Crews")
                        .HasForeignKey("DancerEntityID");

                    b.HasOne("EasyJamCore.DAL.Entities.DjEntity")
                        .WithMany("Crews")
                        .HasForeignKey("DjEntityID");

                    b.HasOne("EasyJamCore.DAL.Entities.HostEntity")
                        .WithMany("Crews")
                        .HasForeignKey("HostEntityID");

                    b.HasOne("EasyJamCore.DAL.Entities.JudgeEntity")
                        .WithMany("Crews")
                        .HasForeignKey("JudgeEntityID");

                    b.HasOne("EasyJamCore.DAL.Entities.SpeakerEntity")
                        .WithMany("Crews")
                        .HasForeignKey("SpeakerEntityID");
                });

            modelBuilder.Entity("EasyJamCore.DAL.Entities.DancerEntity", b =>
                {
                    b.HasOne("EasyJamCore.DAL.Entities.BattleParticipantEntity")
                        .WithMany("Dancer")
                        .HasForeignKey("BattleParticipantEntityID");
                });

            modelBuilder.Entity("EasyJamCore.DAL.Entities.DjEntity", b =>
                {
                    b.HasOne("EasyJamCore.DAL.Entities.BattleEntity")
                        .WithMany("Dj")
                        .HasForeignKey("BattleEntityID");
                });

            modelBuilder.Entity("EasyJamCore.DAL.Entities.HostEntity", b =>
                {
                    b.HasOne("EasyJamCore.DAL.Entities.JamEntity")
                        .WithMany("Host")
                        .HasForeignKey("JamEntityID");
                });

            modelBuilder.Entity("EasyJamCore.DAL.Entities.JamEntity", b =>
                {
                    b.HasOne("EasyJamCore.DAL.Entities.CityEntity", "City")
                        .WithMany()
                        .HasForeignKey("CityID");

                    b.HasOne("EasyJamCore.DAL.Entities.CountryEntity", "Country")
                        .WithMany()
                        .HasForeignKey("CountryID");
                });

            modelBuilder.Entity("EasyJamCore.DAL.Entities.JudgeEntity", b =>
                {
                    b.HasOne("EasyJamCore.DAL.Entities.BattleEntity")
                        .WithMany("Judge")
                        .HasForeignKey("BattleEntityID");
                });

            modelBuilder.Entity("EasyJamCore.DAL.Entities.SpeakerEntity", b =>
                {
                    b.HasOne("EasyJamCore.DAL.Entities.BattleEntity")
                        .WithMany("Speaker")
                        .HasForeignKey("BattleEntityID");
                });
#pragma warning restore 612, 618
        }
    }
}
