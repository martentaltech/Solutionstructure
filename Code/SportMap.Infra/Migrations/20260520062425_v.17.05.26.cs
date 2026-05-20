using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SportMap.Infra.Migrations
{
    /// <inheritdoc />
    public partial class v170526 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CountryCurrencies_Countries_CountryId",
                table: "CountryCurrencies");

            migrationBuilder.DropForeignKey(
                name: "FK_CountryCurrencies_Currencies_CurrencyId",
                table: "CountryCurrencies");

            migrationBuilder.DropForeignKey(
                name: "FK_Moneys_Currencies_CurrencyId",
                table: "Moneys");

            migrationBuilder.AlterColumn<Guid>(
                name: "CurrencyId",
                table: "Moneys",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<decimal>(
                name: "Amount",
                table: "Moneys",
                type: "decimal(18, 2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<Guid>(
                name: "CurrencyId",
                table: "CountryCurrencies",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<Guid>(
                name: "CountryId",
                table: "CountryCurrencies",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "TEXT");

            migrationBuilder.AddForeignKey(
                name: "FK_CountryCurrencies_Countries_CountryId",
                table: "CountryCurrencies",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CountryCurrencies_Currencies_CurrencyId",
                table: "CountryCurrencies",
                column: "CurrencyId",
                principalTable: "Currencies",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Moneys_Currencies_CurrencyId",
                table: "Moneys",
                column: "CurrencyId",
                principalTable: "Currencies",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CountryCurrencies_Countries_CountryId",
                table: "CountryCurrencies");

            migrationBuilder.DropForeignKey(
                name: "FK_CountryCurrencies_Currencies_CurrencyId",
                table: "CountryCurrencies");

            migrationBuilder.DropForeignKey(
                name: "FK_Moneys_Currencies_CurrencyId",
                table: "Moneys");

            migrationBuilder.AlterColumn<Guid>(
                name: "CurrencyId",
                table: "Moneys",
                type: "TEXT",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Amount",
                table: "Moneys",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18, 2)");

            migrationBuilder.AlterColumn<Guid>(
                name: "CurrencyId",
                table: "CountryCurrencies",
                type: "TEXT",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "CountryId",
                table: "CountryCurrencies",
                type: "TEXT",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_CountryCurrencies_Countries_CountryId",
                table: "CountryCurrencies",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CountryCurrencies_Currencies_CurrencyId",
                table: "CountryCurrencies",
                column: "CurrencyId",
                principalTable: "Currencies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Moneys_Currencies_CurrencyId",
                table: "Moneys",
                column: "CurrencyId",
                principalTable: "Currencies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
