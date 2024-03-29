﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CalcAppAPI.Migrations
{
    /// <inheritdoc />
    public partial class trailerwithcrane : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TrailerCraneConfigurations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CraneId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TrailerCraneConfigurations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CraneId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TrailerCraneConfigurations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CraneId", "TrailerId" },
                values: new object[] { 2, 1 });

            migrationBuilder.UpdateData(
                table: "TrailerCraneConfigurations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CraneId", "SelectedFrameTypeId", "TrailerId" },
                values: new object[] { 2, 2, 1 });

            migrationBuilder.UpdateData(
                table: "TrailerCraneConfigurations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CraneId", "SelectedFrameTypeId", "TrailerId" },
                values: new object[] { 3, 1, 1 });

            migrationBuilder.UpdateData(
                table: "TrailerCraneConfigurations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CraneId", "SelectedFrameTypeId", "TrailerId" },
                values: new object[] { 3, 2, 1 });

            migrationBuilder.UpdateData(
                table: "TrailerCraneConfigurations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CraneId", "SelectedFrameTypeId" },
                values: new object[] { 1, 1 });

            migrationBuilder.InsertData(
                table: "TrailerCraneConfigurations",
                columns: new[] { "Id", "CraneId", "SelectedFrameTypeId", "TrailerId" },
                values: new object[,]
                {
                    { 8, 1, 2, 2 },
                    { 9, 2, 1, 2 },
                    { 10, 2, 2, 2 },
                    { 11, 3, 1, 2 },
                    { 12, 3, 2, 2 },
                    { 13, 4, 1, 2 },
                    { 14, 4, 3, 2 },
                    { 15, 4, 4, 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TrailerCraneConfigurations",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "TrailerCraneConfigurations",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "TrailerCraneConfigurations",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "TrailerCraneConfigurations",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "TrailerCraneConfigurations",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "TrailerCraneConfigurations",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "TrailerCraneConfigurations",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "TrailerCraneConfigurations",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.UpdateData(
                table: "TrailerCraneConfigurations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CraneId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "TrailerCraneConfigurations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CraneId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "TrailerCraneConfigurations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CraneId", "TrailerId" },
                values: new object[] { 4, 2 });

            migrationBuilder.UpdateData(
                table: "TrailerCraneConfigurations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CraneId", "SelectedFrameTypeId", "TrailerId" },
                values: new object[] { 4, 3, 2 });

            migrationBuilder.UpdateData(
                table: "TrailerCraneConfigurations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CraneId", "SelectedFrameTypeId", "TrailerId" },
                values: new object[] { 4, 4, 2 });

            migrationBuilder.UpdateData(
                table: "TrailerCraneConfigurations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CraneId", "SelectedFrameTypeId", "TrailerId" },
                values: new object[] { 5, 3, 2 });

            migrationBuilder.UpdateData(
                table: "TrailerCraneConfigurations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CraneId", "SelectedFrameTypeId" },
                values: new object[] { 5, 4 });
        }
    }
}
