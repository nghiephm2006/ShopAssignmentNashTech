using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShopAssignment.Data.Migrations
{
    public partial class AddRefreshToken : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "RefreshToken",
                table: "AppUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "RefreshTokenExpiryTime",
                table: "AppUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "f7b564a1-24b2-40bd-8599-23088d6329d5");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e2c1a592-1615-4a2d-a3d7-eaa51be82f3d", "AQAAAAEAACcQAAAAEHWnLR6jI1Kga42avWMka4kf8I6NzEW4+el6oZKYno9APJQPhujIJexjm75TyChlRw==" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 7, 8, 8, 3, 48, 445, DateTimeKind.Utc).AddTicks(6334));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 7, 8, 8, 3, 48, 445, DateTimeKind.Utc).AddTicks(6335));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 7, 8, 8, 3, 48, 445, DateTimeKind.Utc).AddTicks(6336));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2022, 7, 8, 8, 3, 48, 445, DateTimeKind.Utc).AddTicks(6337));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2022, 7, 8, 8, 3, 48, 445, DateTimeKind.Utc).AddTicks(6338));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2022, 7, 8, 8, 3, 48, 445, DateTimeKind.Utc).AddTicks(6339));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2022, 7, 8, 8, 3, 48, 445, DateTimeKind.Utc).AddTicks(6340));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2022, 7, 8, 8, 3, 48, 445, DateTimeKind.Utc).AddTicks(6341));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 7, 8, 15, 3, 48, 445, DateTimeKind.Local).AddTicks(6240));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 7, 8, 15, 3, 48, 445, DateTimeKind.Local).AddTicks(6265));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 7, 8, 15, 3, 48, 445, DateTimeKind.Local).AddTicks(6267));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2022, 7, 8, 15, 3, 48, 445, DateTimeKind.Local).AddTicks(6269));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2022, 7, 8, 15, 3, 48, 445, DateTimeKind.Local).AddTicks(6271));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2022, 7, 8, 15, 3, 48, 445, DateTimeKind.Local).AddTicks(6272));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2022, 7, 8, 15, 3, 48, 445, DateTimeKind.Local).AddTicks(6273));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2022, 7, 8, 15, 3, 48, 445, DateTimeKind.Local).AddTicks(6275));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RefreshToken",
                table: "AppUsers");

            migrationBuilder.DropColumn(
                name: "RefreshTokenExpiryTime",
                table: "AppUsers");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "a855c3d0-9253-44e5-a01e-a6fd59707807");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f6d4f381-570a-4ca1-9f28-57b5f7d04b05", "AQAAAAEAACcQAAAAENixrR2xxzN5oUDE3/FqEo81VnYr2WnF/oUD3gQbhUKBQrw0/fBW81op5tP5R0FaFg==" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 6, 28, 8, 1, 41, 611, DateTimeKind.Utc).AddTicks(9914));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 6, 28, 8, 1, 41, 611, DateTimeKind.Utc).AddTicks(9916));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 6, 28, 8, 1, 41, 611, DateTimeKind.Utc).AddTicks(9918));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2022, 6, 28, 8, 1, 41, 611, DateTimeKind.Utc).AddTicks(9919));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2022, 6, 28, 8, 1, 41, 611, DateTimeKind.Utc).AddTicks(9920));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2022, 6, 28, 8, 1, 41, 611, DateTimeKind.Utc).AddTicks(9921));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2022, 6, 28, 8, 1, 41, 611, DateTimeKind.Utc).AddTicks(9921));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2022, 6, 28, 8, 1, 41, 611, DateTimeKind.Utc).AddTicks(9922));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 6, 28, 15, 1, 41, 611, DateTimeKind.Local).AddTicks(9833));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 6, 28, 15, 1, 41, 611, DateTimeKind.Local).AddTicks(9846));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 6, 28, 15, 1, 41, 611, DateTimeKind.Local).AddTicks(9848));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2022, 6, 28, 15, 1, 41, 611, DateTimeKind.Local).AddTicks(9849));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2022, 6, 28, 15, 1, 41, 611, DateTimeKind.Local).AddTicks(9851));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2022, 6, 28, 15, 1, 41, 611, DateTimeKind.Local).AddTicks(9852));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2022, 6, 28, 15, 1, 41, 611, DateTimeKind.Local).AddTicks(9853));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2022, 6, 28, 15, 1, 41, 611, DateTimeKind.Local).AddTicks(9854));
        }
    }
}
