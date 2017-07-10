using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MVC_Meds.Migrations
{
    public partial class Second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "textReminder",
                table: "Meds",
                newName: "text");

            migrationBuilder.RenameColumn(
                name: "rxPerAmount",
                table: "Meds",
                newName: "rxAmount");

            migrationBuilder.RenameColumn(
                name: "pharmacyPhone",
                table: "Meds",
                newName: "rxPhone");

            migrationBuilder.RenameColumn(
                name: "numDoses",
                table: "Meds",
                newName: "doses");

            migrationBuilder.RenameColumn(
                name: "emailReminder",
                table: "Meds",
                newName: "email");

            migrationBuilder.RenameColumn(
                name: "dateToRefill",
                table: "Meds",
                newName: "refillDate");

            migrationBuilder.RenameColumn(
                name: "dateFilled",
                table: "Meds",
                newName: "fillDate");

            migrationBuilder.RenameColumn(
                name: "accountID",
                table: "Meds",
                newName: "acctID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "text",
                table: "Meds",
                newName: "textReminder");

            migrationBuilder.RenameColumn(
                name: "rxPhone",
                table: "Meds",
                newName: "pharmacyPhone");

            migrationBuilder.RenameColumn(
                name: "rxAmount",
                table: "Meds",
                newName: "rxPerAmount");

            migrationBuilder.RenameColumn(
                name: "refillDate",
                table: "Meds",
                newName: "dateToRefill");

            migrationBuilder.RenameColumn(
                name: "fillDate",
                table: "Meds",
                newName: "dateFilled");

            migrationBuilder.RenameColumn(
                name: "email",
                table: "Meds",
                newName: "emailReminder");

            migrationBuilder.RenameColumn(
                name: "doses",
                table: "Meds",
                newName: "numDoses");

            migrationBuilder.RenameColumn(
                name: "acctID",
                table: "Meds",
                newName: "accountID");
        }
    }
}
