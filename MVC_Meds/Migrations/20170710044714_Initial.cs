using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MVC_Meds.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Meds",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    accountID = table.Column<int>(nullable: false),
                    dateFilled = table.Column<DateTime>(nullable: false),
                    dateToRefill = table.Column<DateTime>(nullable: false),
                    dosesLeft = table.Column<int>(nullable: false),
                    emailReminder = table.Column<bool>(nullable: false),
                    numDoses = table.Column<int>(nullable: false),
                    pharmacyPhone = table.Column<string>(nullable: true),
                    rxName = table.Column<string>(nullable: true),
                    rxNumber = table.Column<int>(nullable: false),
                    rxPerAmount = table.Column<int>(nullable: false),
                    textReminder = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Meds", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Meds");
        }
    }
}
