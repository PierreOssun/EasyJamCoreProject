using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EasyJamCore.DAL.Migrations
{
    public partial class ChangedAgeToBirthday : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BattleRoundEntity_BattleParticipantEntity_LoserID",
                table: "BattleRoundEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_BattleRoundEntity_BattleParticipantEntity_WinnerID",
                table: "BattleRoundEntity");

            migrationBuilder.DropIndex(
                name: "IX_BattleRoundEntity_LoserID",
                table: "BattleRoundEntity");

            migrationBuilder.DropIndex(
                name: "IX_BattleRoundEntity_WinnerID",
                table: "BattleRoundEntity");

            migrationBuilder.DropColumn(
                name: "Age",
                table: "SpeakerEntity");

            migrationBuilder.DropColumn(
                name: "Age",
                table: "JudgeEntity");

            migrationBuilder.DropColumn(
                name: "Age",
                table: "HostEntity");

            migrationBuilder.DropColumn(
                name: "Age",
                table: "DjEntity");

            migrationBuilder.DropColumn(
                name: "Age",
                table: "DancerEntitiy");

            migrationBuilder.DropColumn(
                name: "LoserID",
                table: "BattleRoundEntity");

            migrationBuilder.DropColumn(
                name: "WinnerID",
                table: "BattleRoundEntity");

            migrationBuilder.AddColumn<DateTime>(
                name: "Birthdate",
                table: "SpeakerEntity",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Birthdate",
                table: "JudgeEntity",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Birthdate",
                table: "HostEntity",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Birthdate",
                table: "DjEntity",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Birthdate",
                table: "DancerEntitiy",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BattleRoundEntityID1",
                table: "BattleParticipantEntity",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_BattleParticipantEntity_BattleRoundEntityID1",
                table: "BattleParticipantEntity",
                column: "BattleRoundEntityID1");

            migrationBuilder.AddForeignKey(
                name: "FK_BattleParticipantEntity_BattleRoundEntity_BattleRoundEntityID1",
                table: "BattleParticipantEntity",
                column: "BattleRoundEntityID1",
                principalTable: "BattleRoundEntity",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BattleParticipantEntity_BattleRoundEntity_BattleRoundEntityID1",
                table: "BattleParticipantEntity");

            migrationBuilder.DropIndex(
                name: "IX_BattleParticipantEntity_BattleRoundEntityID1",
                table: "BattleParticipantEntity");

            migrationBuilder.DropColumn(
                name: "Birthdate",
                table: "SpeakerEntity");

            migrationBuilder.DropColumn(
                name: "Birthdate",
                table: "JudgeEntity");

            migrationBuilder.DropColumn(
                name: "Birthdate",
                table: "HostEntity");

            migrationBuilder.DropColumn(
                name: "Birthdate",
                table: "DjEntity");

            migrationBuilder.DropColumn(
                name: "Birthdate",
                table: "DancerEntitiy");

            migrationBuilder.DropColumn(
                name: "BattleRoundEntityID1",
                table: "BattleParticipantEntity");

            migrationBuilder.AddColumn<string>(
                name: "Age",
                table: "SpeakerEntity",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Age",
                table: "JudgeEntity",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Age",
                table: "HostEntity",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Age",
                table: "DjEntity",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Age",
                table: "DancerEntitiy",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LoserID",
                table: "BattleRoundEntity",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "WinnerID",
                table: "BattleRoundEntity",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_BattleRoundEntity_LoserID",
                table: "BattleRoundEntity",
                column: "LoserID");

            migrationBuilder.CreateIndex(
                name: "IX_BattleRoundEntity_WinnerID",
                table: "BattleRoundEntity",
                column: "WinnerID");

            migrationBuilder.AddForeignKey(
                name: "FK_BattleRoundEntity_BattleParticipantEntity_LoserID",
                table: "BattleRoundEntity",
                column: "LoserID",
                principalTable: "BattleParticipantEntity",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BattleRoundEntity_BattleParticipantEntity_WinnerID",
                table: "BattleRoundEntity",
                column: "WinnerID",
                principalTable: "BattleParticipantEntity",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
