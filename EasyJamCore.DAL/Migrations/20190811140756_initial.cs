using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EasyJamCore.DAL.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BattlePreliminaryEntity",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ScheduledTime = table.Column<DateTime>(nullable: false),
                    StartTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BattlePreliminaryEntity", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "BattleParticipantEntity",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BattleBlaze = table.Column<string>(maxLength: 50, nullable: false),
                    SubscritpionDate = table.Column<DateTime>(nullable: false),
                    Rank = table.Column<int>(nullable: true),
                    BattleEntityID = table.Column<int>(nullable: true),
                    BattlePreliminaryEntityID = table.Column<int>(nullable: true),
                    BattleRoundEntityID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BattleParticipantEntity", x => x.ID);
                    table.ForeignKey(
                        name: "FK_BattleParticipantEntity_BattlePreliminaryEntity_BattlePreliminaryEntityID",
                        column: x => x.BattlePreliminaryEntityID,
                        principalTable: "BattlePreliminaryEntity",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DancerEntitiy",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Blaze = table.Column<string>(maxLength: 50, nullable: false),
                    Gender = table.Column<string>(maxLength: 1, nullable: false),
                    Email = table.Column<string>(maxLength: 50, nullable: false),
                    FirstName = table.Column<string>(maxLength: 50, nullable: true),
                    LastName = table.Column<string>(maxLength: 50, nullable: true),
                    SignInDate = table.Column<DateTime>(nullable: false),
                    Age = table.Column<string>(nullable: true),
                    BattleParticipantEntityID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DancerEntitiy", x => x.ID);
                    table.ForeignKey(
                        name: "FK_DancerEntitiy_BattleParticipantEntity_BattleParticipantEntityID",
                        column: x => x.BattleParticipantEntityID,
                        principalTable: "BattleParticipantEntity",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BattleRoundEntity",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Order = table.Column<int>(nullable: false),
                    ScheduledTime = table.Column<DateTime>(nullable: false),
                    StartTime = table.Column<DateTime>(nullable: false),
                    WinnerID = table.Column<int>(nullable: true),
                    LoserID = table.Column<int>(nullable: true),
                    BattleEntityID = table.Column<int>(nullable: true),
                    BattlePreliminaryEntityID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BattleRoundEntity", x => x.ID);
                    table.ForeignKey(
                        name: "FK_BattleRoundEntity_BattlePreliminaryEntity_BattlePreliminaryEntityID",
                        column: x => x.BattlePreliminaryEntityID,
                        principalTable: "BattlePreliminaryEntity",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BattleRoundEntity_BattleParticipantEntity_LoserID",
                        column: x => x.LoserID,
                        principalTable: "BattleParticipantEntity",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BattleRoundEntity_BattleParticipantEntity_WinnerID",
                        column: x => x.WinnerID,
                        principalTable: "BattleParticipantEntity",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DjEntity",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Blaze = table.Column<string>(maxLength: 50, nullable: false),
                    Gender = table.Column<string>(maxLength: 1, nullable: false),
                    Email = table.Column<string>(maxLength: 50, nullable: false),
                    FirstName = table.Column<string>(maxLength: 50, nullable: true),
                    LastName = table.Column<string>(maxLength: 50, nullable: true),
                    SignInDate = table.Column<DateTime>(nullable: false),
                    Age = table.Column<string>(nullable: true),
                    BattleEntityID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DjEntity", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "JudgeEntity",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Blaze = table.Column<string>(maxLength: 50, nullable: false),
                    Gender = table.Column<string>(maxLength: 1, nullable: false),
                    Email = table.Column<string>(maxLength: 50, nullable: false),
                    FirstName = table.Column<string>(maxLength: 50, nullable: true),
                    LastName = table.Column<string>(maxLength: 50, nullable: true),
                    SignInDate = table.Column<DateTime>(nullable: false),
                    Age = table.Column<string>(nullable: true),
                    BattleEntityID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JudgeEntity", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "SpeakerEntity",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Blaze = table.Column<string>(maxLength: 50, nullable: false),
                    Gender = table.Column<string>(maxLength: 1, nullable: false),
                    Email = table.Column<string>(maxLength: 50, nullable: false),
                    FirstName = table.Column<string>(maxLength: 50, nullable: true),
                    LastName = table.Column<string>(maxLength: 50, nullable: true),
                    SignInDate = table.Column<DateTime>(nullable: false),
                    Age = table.Column<string>(nullable: true),
                    BattleEntityID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpeakerEntity", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CrewEntity",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CrewName = table.Column<string>(nullable: true),
                    BattleParticipantEntityID = table.Column<int>(nullable: true),
                    DancerEntityID = table.Column<int>(nullable: true),
                    DjEntityID = table.Column<int>(nullable: true),
                    HostEntityID = table.Column<int>(nullable: true),
                    JudgeEntityID = table.Column<int>(nullable: true),
                    SpeakerEntityID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CrewEntity", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CrewEntity_BattleParticipantEntity_BattleParticipantEntityID",
                        column: x => x.BattleParticipantEntityID,
                        principalTable: "BattleParticipantEntity",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CrewEntity_DancerEntitiy_DancerEntityID",
                        column: x => x.DancerEntityID,
                        principalTable: "DancerEntitiy",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CrewEntity_DjEntity_DjEntityID",
                        column: x => x.DjEntityID,
                        principalTable: "DjEntity",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CrewEntity_JudgeEntity_JudgeEntityID",
                        column: x => x.JudgeEntityID,
                        principalTable: "JudgeEntity",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CrewEntity_SpeakerEntity_SpeakerEntityID",
                        column: x => x.SpeakerEntityID,
                        principalTable: "SpeakerEntity",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BattleEntity",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BattleName = table.Column<string>(maxLength: 50, nullable: false),
                    Type = table.Column<int>(nullable: false),
                    ScheduledTime = table.Column<DateTime>(nullable: false),
                    StartTime = table.Column<DateTime>(nullable: false),
                    Location = table.Column<string>(nullable: false),
                    BattlePreliminaryID = table.Column<int>(nullable: true),
                    JamEntityID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BattleEntity", x => x.ID);
                    table.ForeignKey(
                        name: "FK_BattleEntity_BattlePreliminaryEntity_BattlePreliminaryID",
                        column: x => x.BattlePreliminaryID,
                        principalTable: "BattlePreliminaryEntity",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "JamEntity",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    JamName = table.Column<string>(nullable: true),
                    ScheduledTime = table.Column<DateTime>(nullable: false),
                    StartTime = table.Column<DateTime>(nullable: false),
                    Location = table.Column<string>(nullable: false),
                    CityID = table.Column<int>(nullable: true),
                    CountryID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JamEntity", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "HostEntity",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Blaze = table.Column<string>(maxLength: 50, nullable: false),
                    Gender = table.Column<string>(maxLength: 1, nullable: false),
                    Email = table.Column<string>(maxLength: 50, nullable: false),
                    FirstName = table.Column<string>(maxLength: 50, nullable: true),
                    LastName = table.Column<string>(maxLength: 50, nullable: true),
                    SignInDate = table.Column<DateTime>(nullable: false),
                    Age = table.Column<string>(nullable: true),
                    JamEntityID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HostEntity", x => x.ID);
                    table.ForeignKey(
                        name: "FK_HostEntity_JamEntity_JamEntityID",
                        column: x => x.JamEntityID,
                        principalTable: "JamEntity",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CityEntity",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CityName = table.Column<string>(maxLength: 50, nullable: false),
                    CrewEntityID = table.Column<int>(nullable: true),
                    DancerEntityID = table.Column<int>(nullable: true),
                    DjEntityID = table.Column<int>(nullable: true),
                    HostEntityID = table.Column<int>(nullable: true),
                    JudgeEntityID = table.Column<int>(nullable: true),
                    SpeakerEntityID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CityEntity", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CityEntity_CrewEntity_CrewEntityID",
                        column: x => x.CrewEntityID,
                        principalTable: "CrewEntity",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CityEntity_DancerEntitiy_DancerEntityID",
                        column: x => x.DancerEntityID,
                        principalTable: "DancerEntitiy",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CityEntity_DjEntity_DjEntityID",
                        column: x => x.DjEntityID,
                        principalTable: "DjEntity",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CityEntity_HostEntity_HostEntityID",
                        column: x => x.HostEntityID,
                        principalTable: "HostEntity",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CityEntity_JudgeEntity_JudgeEntityID",
                        column: x => x.JudgeEntityID,
                        principalTable: "JudgeEntity",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CityEntity_SpeakerEntity_SpeakerEntityID",
                        column: x => x.SpeakerEntityID,
                        principalTable: "SpeakerEntity",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CountryEntity",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CountryName = table.Column<string>(maxLength: 50, nullable: false),
                    CrewEntityID = table.Column<int>(nullable: true),
                    DancerEntityID = table.Column<int>(nullable: true),
                    DjEntityID = table.Column<int>(nullable: true),
                    HostEntityID = table.Column<int>(nullable: true),
                    JudgeEntityID = table.Column<int>(nullable: true),
                    SpeakerEntityID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CountryEntity", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CountryEntity_CrewEntity_CrewEntityID",
                        column: x => x.CrewEntityID,
                        principalTable: "CrewEntity",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CountryEntity_DancerEntitiy_DancerEntityID",
                        column: x => x.DancerEntityID,
                        principalTable: "DancerEntitiy",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CountryEntity_DjEntity_DjEntityID",
                        column: x => x.DjEntityID,
                        principalTable: "DjEntity",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CountryEntity_HostEntity_HostEntityID",
                        column: x => x.HostEntityID,
                        principalTable: "HostEntity",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CountryEntity_JudgeEntity_JudgeEntityID",
                        column: x => x.JudgeEntityID,
                        principalTable: "JudgeEntity",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CountryEntity_SpeakerEntity_SpeakerEntityID",
                        column: x => x.SpeakerEntityID,
                        principalTable: "SpeakerEntity",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BattleEntity_BattlePreliminaryID",
                table: "BattleEntity",
                column: "BattlePreliminaryID");

            migrationBuilder.CreateIndex(
                name: "IX_BattleEntity_JamEntityID",
                table: "BattleEntity",
                column: "JamEntityID");

            migrationBuilder.CreateIndex(
                name: "IX_BattleParticipantEntity_BattleEntityID",
                table: "BattleParticipantEntity",
                column: "BattleEntityID");

            migrationBuilder.CreateIndex(
                name: "IX_BattleParticipantEntity_BattlePreliminaryEntityID",
                table: "BattleParticipantEntity",
                column: "BattlePreliminaryEntityID");

            migrationBuilder.CreateIndex(
                name: "IX_BattleParticipantEntity_BattleRoundEntityID",
                table: "BattleParticipantEntity",
                column: "BattleRoundEntityID");

            migrationBuilder.CreateIndex(
                name: "IX_BattleRoundEntity_BattleEntityID",
                table: "BattleRoundEntity",
                column: "BattleEntityID");

            migrationBuilder.CreateIndex(
                name: "IX_BattleRoundEntity_BattlePreliminaryEntityID",
                table: "BattleRoundEntity",
                column: "BattlePreliminaryEntityID");

            migrationBuilder.CreateIndex(
                name: "IX_BattleRoundEntity_LoserID",
                table: "BattleRoundEntity",
                column: "LoserID");

            migrationBuilder.CreateIndex(
                name: "IX_BattleRoundEntity_WinnerID",
                table: "BattleRoundEntity",
                column: "WinnerID");

            migrationBuilder.CreateIndex(
                name: "IX_CityEntity_CrewEntityID",
                table: "CityEntity",
                column: "CrewEntityID");

            migrationBuilder.CreateIndex(
                name: "IX_CityEntity_DancerEntityID",
                table: "CityEntity",
                column: "DancerEntityID");

            migrationBuilder.CreateIndex(
                name: "IX_CityEntity_DjEntityID",
                table: "CityEntity",
                column: "DjEntityID");

            migrationBuilder.CreateIndex(
                name: "IX_CityEntity_HostEntityID",
                table: "CityEntity",
                column: "HostEntityID");

            migrationBuilder.CreateIndex(
                name: "IX_CityEntity_JudgeEntityID",
                table: "CityEntity",
                column: "JudgeEntityID");

            migrationBuilder.CreateIndex(
                name: "IX_CityEntity_SpeakerEntityID",
                table: "CityEntity",
                column: "SpeakerEntityID");

            migrationBuilder.CreateIndex(
                name: "IX_CountryEntity_CrewEntityID",
                table: "CountryEntity",
                column: "CrewEntityID");

            migrationBuilder.CreateIndex(
                name: "IX_CountryEntity_DancerEntityID",
                table: "CountryEntity",
                column: "DancerEntityID");

            migrationBuilder.CreateIndex(
                name: "IX_CountryEntity_DjEntityID",
                table: "CountryEntity",
                column: "DjEntityID");

            migrationBuilder.CreateIndex(
                name: "IX_CountryEntity_HostEntityID",
                table: "CountryEntity",
                column: "HostEntityID");

            migrationBuilder.CreateIndex(
                name: "IX_CountryEntity_JudgeEntityID",
                table: "CountryEntity",
                column: "JudgeEntityID");

            migrationBuilder.CreateIndex(
                name: "IX_CountryEntity_SpeakerEntityID",
                table: "CountryEntity",
                column: "SpeakerEntityID");

            migrationBuilder.CreateIndex(
                name: "IX_CrewEntity_BattleParticipantEntityID",
                table: "CrewEntity",
                column: "BattleParticipantEntityID");

            migrationBuilder.CreateIndex(
                name: "IX_CrewEntity_DancerEntityID",
                table: "CrewEntity",
                column: "DancerEntityID");

            migrationBuilder.CreateIndex(
                name: "IX_CrewEntity_DjEntityID",
                table: "CrewEntity",
                column: "DjEntityID");

            migrationBuilder.CreateIndex(
                name: "IX_CrewEntity_HostEntityID",
                table: "CrewEntity",
                column: "HostEntityID");

            migrationBuilder.CreateIndex(
                name: "IX_CrewEntity_JudgeEntityID",
                table: "CrewEntity",
                column: "JudgeEntityID");

            migrationBuilder.CreateIndex(
                name: "IX_CrewEntity_SpeakerEntityID",
                table: "CrewEntity",
                column: "SpeakerEntityID");

            migrationBuilder.CreateIndex(
                name: "IX_DancerEntitiy_BattleParticipantEntityID",
                table: "DancerEntitiy",
                column: "BattleParticipantEntityID");

            migrationBuilder.CreateIndex(
                name: "IX_DjEntity_BattleEntityID",
                table: "DjEntity",
                column: "BattleEntityID");

            migrationBuilder.CreateIndex(
                name: "IX_HostEntity_JamEntityID",
                table: "HostEntity",
                column: "JamEntityID");

            migrationBuilder.CreateIndex(
                name: "IX_JamEntity_CityID",
                table: "JamEntity",
                column: "CityID");

            migrationBuilder.CreateIndex(
                name: "IX_JamEntity_CountryID",
                table: "JamEntity",
                column: "CountryID");

            migrationBuilder.CreateIndex(
                name: "IX_JudgeEntity_BattleEntityID",
                table: "JudgeEntity",
                column: "BattleEntityID");

            migrationBuilder.CreateIndex(
                name: "IX_SpeakerEntity_BattleEntityID",
                table: "SpeakerEntity",
                column: "BattleEntityID");

            migrationBuilder.AddForeignKey(
                name: "FK_BattleParticipantEntity_BattleEntity_BattleEntityID",
                table: "BattleParticipantEntity",
                column: "BattleEntityID",
                principalTable: "BattleEntity",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BattleParticipantEntity_BattleRoundEntity_BattleRoundEntityID",
                table: "BattleParticipantEntity",
                column: "BattleRoundEntityID",
                principalTable: "BattleRoundEntity",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BattleRoundEntity_BattleEntity_BattleEntityID",
                table: "BattleRoundEntity",
                column: "BattleEntityID",
                principalTable: "BattleEntity",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DjEntity_BattleEntity_BattleEntityID",
                table: "DjEntity",
                column: "BattleEntityID",
                principalTable: "BattleEntity",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_JudgeEntity_BattleEntity_BattleEntityID",
                table: "JudgeEntity",
                column: "BattleEntityID",
                principalTable: "BattleEntity",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SpeakerEntity_BattleEntity_BattleEntityID",
                table: "SpeakerEntity",
                column: "BattleEntityID",
                principalTable: "BattleEntity",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CrewEntity_HostEntity_HostEntityID",
                table: "CrewEntity",
                column: "HostEntityID",
                principalTable: "HostEntity",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BattleEntity_JamEntity_JamEntityID",
                table: "BattleEntity",
                column: "JamEntityID",
                principalTable: "JamEntity",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_JamEntity_CityEntity_CityID",
                table: "JamEntity",
                column: "CityID",
                principalTable: "CityEntity",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_JamEntity_CountryEntity_CountryID",
                table: "JamEntity",
                column: "CountryID",
                principalTable: "CountryEntity",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BattleEntity_BattlePreliminaryEntity_BattlePreliminaryID",
                table: "BattleEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_BattleParticipantEntity_BattlePreliminaryEntity_BattlePreliminaryEntityID",
                table: "BattleParticipantEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_BattleRoundEntity_BattlePreliminaryEntity_BattlePreliminaryEntityID",
                table: "BattleRoundEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_BattleEntity_JamEntity_JamEntityID",
                table: "BattleEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_HostEntity_JamEntity_JamEntityID",
                table: "HostEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_BattleParticipantEntity_BattleEntity_BattleEntityID",
                table: "BattleParticipantEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_BattleRoundEntity_BattleEntity_BattleEntityID",
                table: "BattleRoundEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_BattleParticipantEntity_BattleRoundEntity_BattleRoundEntityID",
                table: "BattleParticipantEntity");

            migrationBuilder.DropTable(
                name: "BattlePreliminaryEntity");

            migrationBuilder.DropTable(
                name: "JamEntity");

            migrationBuilder.DropTable(
                name: "CityEntity");

            migrationBuilder.DropTable(
                name: "CountryEntity");

            migrationBuilder.DropTable(
                name: "CrewEntity");

            migrationBuilder.DropTable(
                name: "DancerEntitiy");

            migrationBuilder.DropTable(
                name: "DjEntity");

            migrationBuilder.DropTable(
                name: "HostEntity");

            migrationBuilder.DropTable(
                name: "JudgeEntity");

            migrationBuilder.DropTable(
                name: "SpeakerEntity");

            migrationBuilder.DropTable(
                name: "BattleEntity");

            migrationBuilder.DropTable(
                name: "BattleRoundEntity");

            migrationBuilder.DropTable(
                name: "BattleParticipantEntity");
        }
    }
}
