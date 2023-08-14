using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.Base.Example.Repository.Migrations
{
    /// <inheritdoc />
    public partial class InitProject : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CITIES",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "UNIQUEIDENTIFIER", nullable: false),
                    POSTALCODE = table.Column<string>(type: "TEXT", nullable: false),
                    COUNTRY = table.Column<decimal>(type: "NUMERIC(4,0)", nullable: false),
                    NAME = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CITIES", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IDX_CITY",
                table: "CITIES",
                column: "ID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IDX_CITY_NAME",
                table: "CITIES",
                column: "NAME");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CITIES");
        }
    }
}
