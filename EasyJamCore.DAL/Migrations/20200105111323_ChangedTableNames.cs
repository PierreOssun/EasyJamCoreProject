using Microsoft.EntityFrameworkCore.Migrations;

namespace EasyJamCore.DAL.Migrations
{
    public partial class ChangedTableNames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BattleEntity_BattlePreliminaryEntity_BattlePreliminaryID",
                table: "BattleEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_BattleEntity_JamEntity_JamEntityID",
                table: "BattleEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_BattleParticipantEntity_BattleEntity_BattleEntityID",
                table: "BattleParticipantEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_BattleParticipantEntity_BattlePreliminaryEntity_BattlePreliminaryEntityID",
                table: "BattleParticipantEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_BattleParticipantEntity_BattleRoundEntity_BattleRoundEntityID",
                table: "BattleParticipantEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_BattleParticipantEntity_BattleRoundEntity_BattleRoundEntityID1",
                table: "BattleParticipantEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_BattleRoundEntity_BattleEntity_BattleEntityID",
                table: "BattleRoundEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_BattleRoundEntity_BattlePreliminaryEntity_BattlePreliminaryEntityID",
                table: "BattleRoundEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_CityEntity_CrewEntity_CrewEntityID",
                table: "CityEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_CityEntity_DancerEntitiy_DancerEntityID",
                table: "CityEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_CityEntity_DjEntity_DjEntityID",
                table: "CityEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_CityEntity_HostEntity_HostEntityID",
                table: "CityEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_CityEntity_JudgeEntity_JudgeEntityID",
                table: "CityEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_CityEntity_SpeakerEntity_SpeakerEntityID",
                table: "CityEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_CountryEntity_CrewEntity_CrewEntityID",
                table: "CountryEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_CountryEntity_DancerEntitiy_DancerEntityID",
                table: "CountryEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_CountryEntity_DjEntity_DjEntityID",
                table: "CountryEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_CountryEntity_HostEntity_HostEntityID",
                table: "CountryEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_CountryEntity_JudgeEntity_JudgeEntityID",
                table: "CountryEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_CountryEntity_SpeakerEntity_SpeakerEntityID",
                table: "CountryEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_CrewEntity_BattleParticipantEntity_BattleParticipantEntityID",
                table: "CrewEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_CrewEntity_DancerEntitiy_DancerEntityID",
                table: "CrewEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_CrewEntity_DjEntity_DjEntityID",
                table: "CrewEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_CrewEntity_HostEntity_HostEntityID",
                table: "CrewEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_CrewEntity_JudgeEntity_JudgeEntityID",
                table: "CrewEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_CrewEntity_SpeakerEntity_SpeakerEntityID",
                table: "CrewEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_DancerEntitiy_BattleParticipantEntity_BattleParticipantEntityID",
                table: "DancerEntitiy");

            migrationBuilder.DropForeignKey(
                name: "FK_DjEntity_BattleEntity_BattleEntityID",
                table: "DjEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_HostEntity_JamEntity_JamEntityID",
                table: "HostEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_JamEntity_CityEntity_CityID",
                table: "JamEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_JamEntity_CountryEntity_CountryID",
                table: "JamEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_JudgeEntity_BattleEntity_BattleEntityID",
                table: "JudgeEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_SpeakerEntity_BattleEntity_BattleEntityID",
                table: "SpeakerEntity");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SpeakerEntity",
                table: "SpeakerEntity");

            migrationBuilder.DropPrimaryKey(
                name: "PK_JudgeEntity",
                table: "JudgeEntity");

            migrationBuilder.DropPrimaryKey(
                name: "PK_JamEntity",
                table: "JamEntity");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HostEntity",
                table: "HostEntity");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DjEntity",
                table: "DjEntity");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DancerEntitiy",
                table: "DancerEntitiy");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CrewEntity",
                table: "CrewEntity");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CountryEntity",
                table: "CountryEntity");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CityEntity",
                table: "CityEntity");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BattleRoundEntity",
                table: "BattleRoundEntity");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BattlePreliminaryEntity",
                table: "BattlePreliminaryEntity");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BattleParticipantEntity",
                table: "BattleParticipantEntity");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BattleEntity",
                table: "BattleEntity");

            migrationBuilder.RenameTable(
                name: "SpeakerEntity",
                newName: "Speaker");

            migrationBuilder.RenameTable(
                name: "JudgeEntity",
                newName: "Judge");

            migrationBuilder.RenameTable(
                name: "JamEntity",
                newName: "Jam");

            migrationBuilder.RenameTable(
                name: "HostEntity",
                newName: "Host");

            migrationBuilder.RenameTable(
                name: "DjEntity",
                newName: "Dj");

            migrationBuilder.RenameTable(
                name: "DancerEntitiy",
                newName: "Dancer");

            migrationBuilder.RenameTable(
                name: "CrewEntity",
                newName: "Crew");

            migrationBuilder.RenameTable(
                name: "CountryEntity",
                newName: "Country");

            migrationBuilder.RenameTable(
                name: "CityEntity",
                newName: "City");

            migrationBuilder.RenameTable(
                name: "BattleRoundEntity",
                newName: "BattleRound");

            migrationBuilder.RenameTable(
                name: "BattlePreliminaryEntity",
                newName: "BattlePreliminary");

            migrationBuilder.RenameTable(
                name: "BattleParticipantEntity",
                newName: "BattleParticipant");

            migrationBuilder.RenameTable(
                name: "BattleEntity",
                newName: "Battle");

            migrationBuilder.RenameIndex(
                name: "IX_SpeakerEntity_BattleEntityID",
                table: "Speaker",
                newName: "IX_Speaker_BattleEntityID");

            migrationBuilder.RenameIndex(
                name: "IX_JudgeEntity_BattleEntityID",
                table: "Judge",
                newName: "IX_Judge_BattleEntityID");

            migrationBuilder.RenameIndex(
                name: "IX_JamEntity_CountryID",
                table: "Jam",
                newName: "IX_Jam_CountryID");

            migrationBuilder.RenameIndex(
                name: "IX_JamEntity_CityID",
                table: "Jam",
                newName: "IX_Jam_CityID");

            migrationBuilder.RenameIndex(
                name: "IX_HostEntity_JamEntityID",
                table: "Host",
                newName: "IX_Host_JamEntityID");

            migrationBuilder.RenameIndex(
                name: "IX_DjEntity_BattleEntityID",
                table: "Dj",
                newName: "IX_Dj_BattleEntityID");

            migrationBuilder.RenameIndex(
                name: "IX_DancerEntitiy_BattleParticipantEntityID",
                table: "Dancer",
                newName: "IX_Dancer_BattleParticipantEntityID");

            migrationBuilder.RenameIndex(
                name: "IX_CrewEntity_SpeakerEntityID",
                table: "Crew",
                newName: "IX_Crew_SpeakerEntityID");

            migrationBuilder.RenameIndex(
                name: "IX_CrewEntity_JudgeEntityID",
                table: "Crew",
                newName: "IX_Crew_JudgeEntityID");

            migrationBuilder.RenameIndex(
                name: "IX_CrewEntity_HostEntityID",
                table: "Crew",
                newName: "IX_Crew_HostEntityID");

            migrationBuilder.RenameIndex(
                name: "IX_CrewEntity_DjEntityID",
                table: "Crew",
                newName: "IX_Crew_DjEntityID");

            migrationBuilder.RenameIndex(
                name: "IX_CrewEntity_DancerEntityID",
                table: "Crew",
                newName: "IX_Crew_DancerEntityID");

            migrationBuilder.RenameIndex(
                name: "IX_CrewEntity_BattleParticipantEntityID",
                table: "Crew",
                newName: "IX_Crew_BattleParticipantEntityID");

            migrationBuilder.RenameIndex(
                name: "IX_CountryEntity_SpeakerEntityID",
                table: "Country",
                newName: "IX_Country_SpeakerEntityID");

            migrationBuilder.RenameIndex(
                name: "IX_CountryEntity_JudgeEntityID",
                table: "Country",
                newName: "IX_Country_JudgeEntityID");

            migrationBuilder.RenameIndex(
                name: "IX_CountryEntity_HostEntityID",
                table: "Country",
                newName: "IX_Country_HostEntityID");

            migrationBuilder.RenameIndex(
                name: "IX_CountryEntity_DjEntityID",
                table: "Country",
                newName: "IX_Country_DjEntityID");

            migrationBuilder.RenameIndex(
                name: "IX_CountryEntity_DancerEntityID",
                table: "Country",
                newName: "IX_Country_DancerEntityID");

            migrationBuilder.RenameIndex(
                name: "IX_CountryEntity_CrewEntityID",
                table: "Country",
                newName: "IX_Country_CrewEntityID");

            migrationBuilder.RenameIndex(
                name: "IX_CityEntity_SpeakerEntityID",
                table: "City",
                newName: "IX_City_SpeakerEntityID");

            migrationBuilder.RenameIndex(
                name: "IX_CityEntity_JudgeEntityID",
                table: "City",
                newName: "IX_City_JudgeEntityID");

            migrationBuilder.RenameIndex(
                name: "IX_CityEntity_HostEntityID",
                table: "City",
                newName: "IX_City_HostEntityID");

            migrationBuilder.RenameIndex(
                name: "IX_CityEntity_DjEntityID",
                table: "City",
                newName: "IX_City_DjEntityID");

            migrationBuilder.RenameIndex(
                name: "IX_CityEntity_DancerEntityID",
                table: "City",
                newName: "IX_City_DancerEntityID");

            migrationBuilder.RenameIndex(
                name: "IX_CityEntity_CrewEntityID",
                table: "City",
                newName: "IX_City_CrewEntityID");

            migrationBuilder.RenameIndex(
                name: "IX_BattleRoundEntity_BattlePreliminaryEntityID",
                table: "BattleRound",
                newName: "IX_BattleRound_BattlePreliminaryEntityID");

            migrationBuilder.RenameIndex(
                name: "IX_BattleRoundEntity_BattleEntityID",
                table: "BattleRound",
                newName: "IX_BattleRound_BattleEntityID");

            migrationBuilder.RenameIndex(
                name: "IX_BattleParticipantEntity_BattleRoundEntityID1",
                table: "BattleParticipant",
                newName: "IX_BattleParticipant_BattleRoundEntityID1");

            migrationBuilder.RenameIndex(
                name: "IX_BattleParticipantEntity_BattleRoundEntityID",
                table: "BattleParticipant",
                newName: "IX_BattleParticipant_BattleRoundEntityID");

            migrationBuilder.RenameIndex(
                name: "IX_BattleParticipantEntity_BattlePreliminaryEntityID",
                table: "BattleParticipant",
                newName: "IX_BattleParticipant_BattlePreliminaryEntityID");

            migrationBuilder.RenameIndex(
                name: "IX_BattleParticipantEntity_BattleEntityID",
                table: "BattleParticipant",
                newName: "IX_BattleParticipant_BattleEntityID");

            migrationBuilder.RenameIndex(
                name: "IX_BattleEntity_JamEntityID",
                table: "Battle",
                newName: "IX_Battle_JamEntityID");

            migrationBuilder.RenameIndex(
                name: "IX_BattleEntity_BattlePreliminaryID",
                table: "Battle",
                newName: "IX_Battle_BattlePreliminaryID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Speaker",
                table: "Speaker",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Judge",
                table: "Judge",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Jam",
                table: "Jam",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Host",
                table: "Host",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Dj",
                table: "Dj",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Dancer",
                table: "Dancer",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Crew",
                table: "Crew",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Country",
                table: "Country",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_City",
                table: "City",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BattleRound",
                table: "BattleRound",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BattlePreliminary",
                table: "BattlePreliminary",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BattleParticipant",
                table: "BattleParticipant",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Battle",
                table: "Battle",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Battle_BattlePreliminary_BattlePreliminaryID",
                table: "Battle",
                column: "BattlePreliminaryID",
                principalTable: "BattlePreliminary",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Battle_Jam_JamEntityID",
                table: "Battle",
                column: "JamEntityID",
                principalTable: "Jam",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BattleParticipant_Battle_BattleEntityID",
                table: "BattleParticipant",
                column: "BattleEntityID",
                principalTable: "Battle",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BattleParticipant_BattlePreliminary_BattlePreliminaryEntityID",
                table: "BattleParticipant",
                column: "BattlePreliminaryEntityID",
                principalTable: "BattlePreliminary",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BattleParticipant_BattleRound_BattleRoundEntityID",
                table: "BattleParticipant",
                column: "BattleRoundEntityID",
                principalTable: "BattleRound",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BattleParticipant_BattleRound_BattleRoundEntityID1",
                table: "BattleParticipant",
                column: "BattleRoundEntityID1",
                principalTable: "BattleRound",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BattleRound_Battle_BattleEntityID",
                table: "BattleRound",
                column: "BattleEntityID",
                principalTable: "Battle",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BattleRound_BattlePreliminary_BattlePreliminaryEntityID",
                table: "BattleRound",
                column: "BattlePreliminaryEntityID",
                principalTable: "BattlePreliminary",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_City_Crew_CrewEntityID",
                table: "City",
                column: "CrewEntityID",
                principalTable: "Crew",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_City_Dancer_DancerEntityID",
                table: "City",
                column: "DancerEntityID",
                principalTable: "Dancer",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_City_Dj_DjEntityID",
                table: "City",
                column: "DjEntityID",
                principalTable: "Dj",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_City_Host_HostEntityID",
                table: "City",
                column: "HostEntityID",
                principalTable: "Host",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_City_Judge_JudgeEntityID",
                table: "City",
                column: "JudgeEntityID",
                principalTable: "Judge",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_City_Speaker_SpeakerEntityID",
                table: "City",
                column: "SpeakerEntityID",
                principalTable: "Speaker",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Country_Crew_CrewEntityID",
                table: "Country",
                column: "CrewEntityID",
                principalTable: "Crew",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Country_Dancer_DancerEntityID",
                table: "Country",
                column: "DancerEntityID",
                principalTable: "Dancer",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Country_Dj_DjEntityID",
                table: "Country",
                column: "DjEntityID",
                principalTable: "Dj",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Country_Host_HostEntityID",
                table: "Country",
                column: "HostEntityID",
                principalTable: "Host",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Country_Judge_JudgeEntityID",
                table: "Country",
                column: "JudgeEntityID",
                principalTable: "Judge",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Country_Speaker_SpeakerEntityID",
                table: "Country",
                column: "SpeakerEntityID",
                principalTable: "Speaker",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Crew_BattleParticipant_BattleParticipantEntityID",
                table: "Crew",
                column: "BattleParticipantEntityID",
                principalTable: "BattleParticipant",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Crew_Dancer_DancerEntityID",
                table: "Crew",
                column: "DancerEntityID",
                principalTable: "Dancer",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Crew_Dj_DjEntityID",
                table: "Crew",
                column: "DjEntityID",
                principalTable: "Dj",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Crew_Host_HostEntityID",
                table: "Crew",
                column: "HostEntityID",
                principalTable: "Host",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Crew_Judge_JudgeEntityID",
                table: "Crew",
                column: "JudgeEntityID",
                principalTable: "Judge",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Crew_Speaker_SpeakerEntityID",
                table: "Crew",
                column: "SpeakerEntityID",
                principalTable: "Speaker",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Dancer_BattleParticipant_BattleParticipantEntityID",
                table: "Dancer",
                column: "BattleParticipantEntityID",
                principalTable: "BattleParticipant",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Dj_Battle_BattleEntityID",
                table: "Dj",
                column: "BattleEntityID",
                principalTable: "Battle",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Host_Jam_JamEntityID",
                table: "Host",
                column: "JamEntityID",
                principalTable: "Jam",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Jam_City_CityID",
                table: "Jam",
                column: "CityID",
                principalTable: "City",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Jam_Country_CountryID",
                table: "Jam",
                column: "CountryID",
                principalTable: "Country",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Judge_Battle_BattleEntityID",
                table: "Judge",
                column: "BattleEntityID",
                principalTable: "Battle",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Speaker_Battle_BattleEntityID",
                table: "Speaker",
                column: "BattleEntityID",
                principalTable: "Battle",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Battle_BattlePreliminary_BattlePreliminaryID",
                table: "Battle");

            migrationBuilder.DropForeignKey(
                name: "FK_Battle_Jam_JamEntityID",
                table: "Battle");

            migrationBuilder.DropForeignKey(
                name: "FK_BattleParticipant_Battle_BattleEntityID",
                table: "BattleParticipant");

            migrationBuilder.DropForeignKey(
                name: "FK_BattleParticipant_BattlePreliminary_BattlePreliminaryEntityID",
                table: "BattleParticipant");

            migrationBuilder.DropForeignKey(
                name: "FK_BattleParticipant_BattleRound_BattleRoundEntityID",
                table: "BattleParticipant");

            migrationBuilder.DropForeignKey(
                name: "FK_BattleParticipant_BattleRound_BattleRoundEntityID1",
                table: "BattleParticipant");

            migrationBuilder.DropForeignKey(
                name: "FK_BattleRound_Battle_BattleEntityID",
                table: "BattleRound");

            migrationBuilder.DropForeignKey(
                name: "FK_BattleRound_BattlePreliminary_BattlePreliminaryEntityID",
                table: "BattleRound");

            migrationBuilder.DropForeignKey(
                name: "FK_City_Crew_CrewEntityID",
                table: "City");

            migrationBuilder.DropForeignKey(
                name: "FK_City_Dancer_DancerEntityID",
                table: "City");

            migrationBuilder.DropForeignKey(
                name: "FK_City_Dj_DjEntityID",
                table: "City");

            migrationBuilder.DropForeignKey(
                name: "FK_City_Host_HostEntityID",
                table: "City");

            migrationBuilder.DropForeignKey(
                name: "FK_City_Judge_JudgeEntityID",
                table: "City");

            migrationBuilder.DropForeignKey(
                name: "FK_City_Speaker_SpeakerEntityID",
                table: "City");

            migrationBuilder.DropForeignKey(
                name: "FK_Country_Crew_CrewEntityID",
                table: "Country");

            migrationBuilder.DropForeignKey(
                name: "FK_Country_Dancer_DancerEntityID",
                table: "Country");

            migrationBuilder.DropForeignKey(
                name: "FK_Country_Dj_DjEntityID",
                table: "Country");

            migrationBuilder.DropForeignKey(
                name: "FK_Country_Host_HostEntityID",
                table: "Country");

            migrationBuilder.DropForeignKey(
                name: "FK_Country_Judge_JudgeEntityID",
                table: "Country");

            migrationBuilder.DropForeignKey(
                name: "FK_Country_Speaker_SpeakerEntityID",
                table: "Country");

            migrationBuilder.DropForeignKey(
                name: "FK_Crew_BattleParticipant_BattleParticipantEntityID",
                table: "Crew");

            migrationBuilder.DropForeignKey(
                name: "FK_Crew_Dancer_DancerEntityID",
                table: "Crew");

            migrationBuilder.DropForeignKey(
                name: "FK_Crew_Dj_DjEntityID",
                table: "Crew");

            migrationBuilder.DropForeignKey(
                name: "FK_Crew_Host_HostEntityID",
                table: "Crew");

            migrationBuilder.DropForeignKey(
                name: "FK_Crew_Judge_JudgeEntityID",
                table: "Crew");

            migrationBuilder.DropForeignKey(
                name: "FK_Crew_Speaker_SpeakerEntityID",
                table: "Crew");

            migrationBuilder.DropForeignKey(
                name: "FK_Dancer_BattleParticipant_BattleParticipantEntityID",
                table: "Dancer");

            migrationBuilder.DropForeignKey(
                name: "FK_Dj_Battle_BattleEntityID",
                table: "Dj");

            migrationBuilder.DropForeignKey(
                name: "FK_Host_Jam_JamEntityID",
                table: "Host");

            migrationBuilder.DropForeignKey(
                name: "FK_Jam_City_CityID",
                table: "Jam");

            migrationBuilder.DropForeignKey(
                name: "FK_Jam_Country_CountryID",
                table: "Jam");

            migrationBuilder.DropForeignKey(
                name: "FK_Judge_Battle_BattleEntityID",
                table: "Judge");

            migrationBuilder.DropForeignKey(
                name: "FK_Speaker_Battle_BattleEntityID",
                table: "Speaker");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Speaker",
                table: "Speaker");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Judge",
                table: "Judge");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Jam",
                table: "Jam");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Host",
                table: "Host");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Dj",
                table: "Dj");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Dancer",
                table: "Dancer");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Crew",
                table: "Crew");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Country",
                table: "Country");

            migrationBuilder.DropPrimaryKey(
                name: "PK_City",
                table: "City");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BattleRound",
                table: "BattleRound");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BattlePreliminary",
                table: "BattlePreliminary");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BattleParticipant",
                table: "BattleParticipant");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Battle",
                table: "Battle");

            migrationBuilder.RenameTable(
                name: "Speaker",
                newName: "SpeakerEntity");

            migrationBuilder.RenameTable(
                name: "Judge",
                newName: "JudgeEntity");

            migrationBuilder.RenameTable(
                name: "Jam",
                newName: "JamEntity");

            migrationBuilder.RenameTable(
                name: "Host",
                newName: "HostEntity");

            migrationBuilder.RenameTable(
                name: "Dj",
                newName: "DjEntity");

            migrationBuilder.RenameTable(
                name: "Dancer",
                newName: "DancerEntitiy");

            migrationBuilder.RenameTable(
                name: "Crew",
                newName: "CrewEntity");

            migrationBuilder.RenameTable(
                name: "Country",
                newName: "CountryEntity");

            migrationBuilder.RenameTable(
                name: "City",
                newName: "CityEntity");

            migrationBuilder.RenameTable(
                name: "BattleRound",
                newName: "BattleRoundEntity");

            migrationBuilder.RenameTable(
                name: "BattlePreliminary",
                newName: "BattlePreliminaryEntity");

            migrationBuilder.RenameTable(
                name: "BattleParticipant",
                newName: "BattleParticipantEntity");

            migrationBuilder.RenameTable(
                name: "Battle",
                newName: "BattleEntity");

            migrationBuilder.RenameIndex(
                name: "IX_Speaker_BattleEntityID",
                table: "SpeakerEntity",
                newName: "IX_SpeakerEntity_BattleEntityID");

            migrationBuilder.RenameIndex(
                name: "IX_Judge_BattleEntityID",
                table: "JudgeEntity",
                newName: "IX_JudgeEntity_BattleEntityID");

            migrationBuilder.RenameIndex(
                name: "IX_Jam_CountryID",
                table: "JamEntity",
                newName: "IX_JamEntity_CountryID");

            migrationBuilder.RenameIndex(
                name: "IX_Jam_CityID",
                table: "JamEntity",
                newName: "IX_JamEntity_CityID");

            migrationBuilder.RenameIndex(
                name: "IX_Host_JamEntityID",
                table: "HostEntity",
                newName: "IX_HostEntity_JamEntityID");

            migrationBuilder.RenameIndex(
                name: "IX_Dj_BattleEntityID",
                table: "DjEntity",
                newName: "IX_DjEntity_BattleEntityID");

            migrationBuilder.RenameIndex(
                name: "IX_Dancer_BattleParticipantEntityID",
                table: "DancerEntitiy",
                newName: "IX_DancerEntitiy_BattleParticipantEntityID");

            migrationBuilder.RenameIndex(
                name: "IX_Crew_SpeakerEntityID",
                table: "CrewEntity",
                newName: "IX_CrewEntity_SpeakerEntityID");

            migrationBuilder.RenameIndex(
                name: "IX_Crew_JudgeEntityID",
                table: "CrewEntity",
                newName: "IX_CrewEntity_JudgeEntityID");

            migrationBuilder.RenameIndex(
                name: "IX_Crew_HostEntityID",
                table: "CrewEntity",
                newName: "IX_CrewEntity_HostEntityID");

            migrationBuilder.RenameIndex(
                name: "IX_Crew_DjEntityID",
                table: "CrewEntity",
                newName: "IX_CrewEntity_DjEntityID");

            migrationBuilder.RenameIndex(
                name: "IX_Crew_DancerEntityID",
                table: "CrewEntity",
                newName: "IX_CrewEntity_DancerEntityID");

            migrationBuilder.RenameIndex(
                name: "IX_Crew_BattleParticipantEntityID",
                table: "CrewEntity",
                newName: "IX_CrewEntity_BattleParticipantEntityID");

            migrationBuilder.RenameIndex(
                name: "IX_Country_SpeakerEntityID",
                table: "CountryEntity",
                newName: "IX_CountryEntity_SpeakerEntityID");

            migrationBuilder.RenameIndex(
                name: "IX_Country_JudgeEntityID",
                table: "CountryEntity",
                newName: "IX_CountryEntity_JudgeEntityID");

            migrationBuilder.RenameIndex(
                name: "IX_Country_HostEntityID",
                table: "CountryEntity",
                newName: "IX_CountryEntity_HostEntityID");

            migrationBuilder.RenameIndex(
                name: "IX_Country_DjEntityID",
                table: "CountryEntity",
                newName: "IX_CountryEntity_DjEntityID");

            migrationBuilder.RenameIndex(
                name: "IX_Country_DancerEntityID",
                table: "CountryEntity",
                newName: "IX_CountryEntity_DancerEntityID");

            migrationBuilder.RenameIndex(
                name: "IX_Country_CrewEntityID",
                table: "CountryEntity",
                newName: "IX_CountryEntity_CrewEntityID");

            migrationBuilder.RenameIndex(
                name: "IX_City_SpeakerEntityID",
                table: "CityEntity",
                newName: "IX_CityEntity_SpeakerEntityID");

            migrationBuilder.RenameIndex(
                name: "IX_City_JudgeEntityID",
                table: "CityEntity",
                newName: "IX_CityEntity_JudgeEntityID");

            migrationBuilder.RenameIndex(
                name: "IX_City_HostEntityID",
                table: "CityEntity",
                newName: "IX_CityEntity_HostEntityID");

            migrationBuilder.RenameIndex(
                name: "IX_City_DjEntityID",
                table: "CityEntity",
                newName: "IX_CityEntity_DjEntityID");

            migrationBuilder.RenameIndex(
                name: "IX_City_DancerEntityID",
                table: "CityEntity",
                newName: "IX_CityEntity_DancerEntityID");

            migrationBuilder.RenameIndex(
                name: "IX_City_CrewEntityID",
                table: "CityEntity",
                newName: "IX_CityEntity_CrewEntityID");

            migrationBuilder.RenameIndex(
                name: "IX_BattleRound_BattlePreliminaryEntityID",
                table: "BattleRoundEntity",
                newName: "IX_BattleRoundEntity_BattlePreliminaryEntityID");

            migrationBuilder.RenameIndex(
                name: "IX_BattleRound_BattleEntityID",
                table: "BattleRoundEntity",
                newName: "IX_BattleRoundEntity_BattleEntityID");

            migrationBuilder.RenameIndex(
                name: "IX_BattleParticipant_BattleRoundEntityID1",
                table: "BattleParticipantEntity",
                newName: "IX_BattleParticipantEntity_BattleRoundEntityID1");

            migrationBuilder.RenameIndex(
                name: "IX_BattleParticipant_BattleRoundEntityID",
                table: "BattleParticipantEntity",
                newName: "IX_BattleParticipantEntity_BattleRoundEntityID");

            migrationBuilder.RenameIndex(
                name: "IX_BattleParticipant_BattlePreliminaryEntityID",
                table: "BattleParticipantEntity",
                newName: "IX_BattleParticipantEntity_BattlePreliminaryEntityID");

            migrationBuilder.RenameIndex(
                name: "IX_BattleParticipant_BattleEntityID",
                table: "BattleParticipantEntity",
                newName: "IX_BattleParticipantEntity_BattleEntityID");

            migrationBuilder.RenameIndex(
                name: "IX_Battle_JamEntityID",
                table: "BattleEntity",
                newName: "IX_BattleEntity_JamEntityID");

            migrationBuilder.RenameIndex(
                name: "IX_Battle_BattlePreliminaryID",
                table: "BattleEntity",
                newName: "IX_BattleEntity_BattlePreliminaryID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SpeakerEntity",
                table: "SpeakerEntity",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_JudgeEntity",
                table: "JudgeEntity",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_JamEntity",
                table: "JamEntity",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HostEntity",
                table: "HostEntity",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DjEntity",
                table: "DjEntity",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DancerEntitiy",
                table: "DancerEntitiy",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CrewEntity",
                table: "CrewEntity",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CountryEntity",
                table: "CountryEntity",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CityEntity",
                table: "CityEntity",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BattleRoundEntity",
                table: "BattleRoundEntity",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BattlePreliminaryEntity",
                table: "BattlePreliminaryEntity",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BattleParticipantEntity",
                table: "BattleParticipantEntity",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BattleEntity",
                table: "BattleEntity",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_BattleEntity_BattlePreliminaryEntity_BattlePreliminaryID",
                table: "BattleEntity",
                column: "BattlePreliminaryID",
                principalTable: "BattlePreliminaryEntity",
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
                name: "FK_BattleParticipantEntity_BattleEntity_BattleEntityID",
                table: "BattleParticipantEntity",
                column: "BattleEntityID",
                principalTable: "BattleEntity",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BattleParticipantEntity_BattlePreliminaryEntity_BattlePreliminaryEntityID",
                table: "BattleParticipantEntity",
                column: "BattlePreliminaryEntityID",
                principalTable: "BattlePreliminaryEntity",
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
                name: "FK_BattleParticipantEntity_BattleRoundEntity_BattleRoundEntityID1",
                table: "BattleParticipantEntity",
                column: "BattleRoundEntityID1",
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
                name: "FK_BattleRoundEntity_BattlePreliminaryEntity_BattlePreliminaryEntityID",
                table: "BattleRoundEntity",
                column: "BattlePreliminaryEntityID",
                principalTable: "BattlePreliminaryEntity",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CityEntity_CrewEntity_CrewEntityID",
                table: "CityEntity",
                column: "CrewEntityID",
                principalTable: "CrewEntity",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CityEntity_DancerEntitiy_DancerEntityID",
                table: "CityEntity",
                column: "DancerEntityID",
                principalTable: "DancerEntitiy",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CityEntity_DjEntity_DjEntityID",
                table: "CityEntity",
                column: "DjEntityID",
                principalTable: "DjEntity",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CityEntity_HostEntity_HostEntityID",
                table: "CityEntity",
                column: "HostEntityID",
                principalTable: "HostEntity",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CityEntity_JudgeEntity_JudgeEntityID",
                table: "CityEntity",
                column: "JudgeEntityID",
                principalTable: "JudgeEntity",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CityEntity_SpeakerEntity_SpeakerEntityID",
                table: "CityEntity",
                column: "SpeakerEntityID",
                principalTable: "SpeakerEntity",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CountryEntity_CrewEntity_CrewEntityID",
                table: "CountryEntity",
                column: "CrewEntityID",
                principalTable: "CrewEntity",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CountryEntity_DancerEntitiy_DancerEntityID",
                table: "CountryEntity",
                column: "DancerEntityID",
                principalTable: "DancerEntitiy",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CountryEntity_DjEntity_DjEntityID",
                table: "CountryEntity",
                column: "DjEntityID",
                principalTable: "DjEntity",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CountryEntity_HostEntity_HostEntityID",
                table: "CountryEntity",
                column: "HostEntityID",
                principalTable: "HostEntity",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CountryEntity_JudgeEntity_JudgeEntityID",
                table: "CountryEntity",
                column: "JudgeEntityID",
                principalTable: "JudgeEntity",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CountryEntity_SpeakerEntity_SpeakerEntityID",
                table: "CountryEntity",
                column: "SpeakerEntityID",
                principalTable: "SpeakerEntity",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CrewEntity_BattleParticipantEntity_BattleParticipantEntityID",
                table: "CrewEntity",
                column: "BattleParticipantEntityID",
                principalTable: "BattleParticipantEntity",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CrewEntity_DancerEntitiy_DancerEntityID",
                table: "CrewEntity",
                column: "DancerEntityID",
                principalTable: "DancerEntitiy",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CrewEntity_DjEntity_DjEntityID",
                table: "CrewEntity",
                column: "DjEntityID",
                principalTable: "DjEntity",
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
                name: "FK_CrewEntity_JudgeEntity_JudgeEntityID",
                table: "CrewEntity",
                column: "JudgeEntityID",
                principalTable: "JudgeEntity",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CrewEntity_SpeakerEntity_SpeakerEntityID",
                table: "CrewEntity",
                column: "SpeakerEntityID",
                principalTable: "SpeakerEntity",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DancerEntitiy_BattleParticipantEntity_BattleParticipantEntityID",
                table: "DancerEntitiy",
                column: "BattleParticipantEntityID",
                principalTable: "BattleParticipantEntity",
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
                name: "FK_HostEntity_JamEntity_JamEntityID",
                table: "HostEntity",
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
        }
    }
}
