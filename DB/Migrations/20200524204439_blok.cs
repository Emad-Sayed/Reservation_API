using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace _DB.Migrations
{
    public partial class blok : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Block",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                column: "ConcurrencyStamp",
                value: "6f7fca15-4841-4171-922b-f79defcea979");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e577",
                column: "ConcurrencyStamp",
                value: "12cb932b-2e28-42a8-8348-f57b45b2d751");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e578",
                column: "ConcurrencyStamp",
                value: "851ada55-d6ec-4d4b-8bb1-f19b53463774");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "448778e8-b529-487a-b7bf-a4b307e65a70", "AQAAAAEAACcQAAAAEGKAVlWvijPPwCGuGgZYSi7SmrzkaQDqmOz1PyUi3Z/M3MfdEVfopynINIbyN+aVMg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e577",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "08aef4a4-13ab-42f6-ba40-f78c54139c30", "AQAAAAEAACcQAAAAEMEN28pqGJ33T0iXbDBWNkSKauhkf5Ea8ryPuRnuMPvvZlRAC4ZpQ+a1rCiS5NbCdQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e578",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7e291e82-463c-4344-8af5-3f38fd2d1612", "AQAAAAEAACcQAAAAEG5X677dp2h4m0hWptFRTvrqGl4XNo9yhcEH35jqAI10jwnijC+bM4Zq8PYCwjvq+g==" });

            migrationBuilder.UpdateData(
                table: "Branch_Departements",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2020, 5, 24, 22, 44, 39, 184, DateTimeKind.Local).AddTicks(6268));

            migrationBuilder.UpdateData(
                table: "Branch_Departements",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_Date",
                value: new DateTime(2020, 5, 24, 22, 44, 39, 184, DateTimeKind.Local).AddTicks(7622));

            migrationBuilder.UpdateData(
                table: "Branch_Departements",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_Date",
                value: new DateTime(2020, 5, 24, 22, 44, 39, 184, DateTimeKind.Local).AddTicks(7635));

            migrationBuilder.UpdateData(
                table: "Branch_Departements",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created_Date",
                value: new DateTime(2020, 5, 24, 22, 44, 39, 184, DateTimeKind.Local).AddTicks(7637));

            migrationBuilder.UpdateData(
                table: "Branch_Departements",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created_Date",
                value: new DateTime(2020, 5, 24, 22, 44, 39, 184, DateTimeKind.Local).AddTicks(7639));

            migrationBuilder.UpdateData(
                table: "Branch_Departements",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created_Date",
                value: new DateTime(2020, 5, 24, 22, 44, 39, 184, DateTimeKind.Local).AddTicks(7640));

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2020, 5, 24, 22, 44, 39, 184, DateTimeKind.Local).AddTicks(1123));

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_Date",
                value: new DateTime(2020, 5, 24, 22, 44, 39, 184, DateTimeKind.Local).AddTicks(3142));

            migrationBuilder.UpdateData(
                table: "Configuration",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2020, 5, 24, 22, 44, 39, 181, DateTimeKind.Local).AddTicks(8743));

            migrationBuilder.UpdateData(
                table: "Departements",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2020, 5, 24, 22, 44, 39, 184, DateTimeKind.Local).AddTicks(4402));

            migrationBuilder.UpdateData(
                table: "Departements",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_Date",
                value: new DateTime(2020, 5, 24, 22, 44, 39, 184, DateTimeKind.Local).AddTicks(5031));

            migrationBuilder.UpdateData(
                table: "Departements",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_Date",
                value: new DateTime(2020, 5, 24, 22, 44, 39, 184, DateTimeKind.Local).AddTicks(5040));

            migrationBuilder.UpdateData(
                table: "Ticket_States",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2020, 5, 24, 22, 44, 39, 226, DateTimeKind.Local).AddTicks(5148));

            migrationBuilder.UpdateData(
                table: "Ticket_States",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_Date",
                value: new DateTime(2020, 5, 24, 22, 44, 39, 226, DateTimeKind.Local).AddTicks(6303));

            migrationBuilder.UpdateData(
                table: "Ticket_States",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_Date",
                value: new DateTime(2020, 5, 24, 22, 44, 39, 226, DateTimeKind.Local).AddTicks(6315));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Block",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                column: "ConcurrencyStamp",
                value: "f691ffc2-53d9-420a-8296-0b99e067dc95");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e577",
                column: "ConcurrencyStamp",
                value: "3da6d9ac-8e41-4733-904c-3fd9a22c2630");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e578",
                column: "ConcurrencyStamp",
                value: "719c0d6c-8bed-4226-9df2-f41d591b3ef7");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "12cfacd2-a7a4-45c5-879c-97dcc233aedd", "AQAAAAEAACcQAAAAEJVdCyhldWJ9ahO+BMRvJL/zklPv4MAITHxr9RRxo0gwOYmCYBLZdcJ7yvE6vss1sA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e577",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "77106c43-7dbb-47be-ac94-3afc61db31b8", "AQAAAAEAACcQAAAAEPutN6TghA8XlGTDYKalcFb0Zpk7Kvfw0sDzVzlzbkoHBQi2b1JB5Jbyj395W7bYNg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e578",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "eca835ab-3c46-4ea7-b7c7-e828074ace01", "AQAAAAEAACcQAAAAEACBqO+/3r4XMYNftYNVwkKhTxpqPfvpxhFVgRolHPAQNIBHOax4bd0dlGoqi4Qw2A==" });

            migrationBuilder.UpdateData(
                table: "Branch_Departements",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2020, 5, 24, 21, 46, 3, 981, DateTimeKind.Local).AddTicks(3568));

            migrationBuilder.UpdateData(
                table: "Branch_Departements",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_Date",
                value: new DateTime(2020, 5, 24, 21, 46, 3, 981, DateTimeKind.Local).AddTicks(5009));

            migrationBuilder.UpdateData(
                table: "Branch_Departements",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_Date",
                value: new DateTime(2020, 5, 24, 21, 46, 3, 981, DateTimeKind.Local).AddTicks(5023));

            migrationBuilder.UpdateData(
                table: "Branch_Departements",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created_Date",
                value: new DateTime(2020, 5, 24, 21, 46, 3, 981, DateTimeKind.Local).AddTicks(5025));

            migrationBuilder.UpdateData(
                table: "Branch_Departements",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created_Date",
                value: new DateTime(2020, 5, 24, 21, 46, 3, 981, DateTimeKind.Local).AddTicks(5027));

            migrationBuilder.UpdateData(
                table: "Branch_Departements",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created_Date",
                value: new DateTime(2020, 5, 24, 21, 46, 3, 981, DateTimeKind.Local).AddTicks(5028));

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2020, 5, 24, 21, 46, 3, 980, DateTimeKind.Local).AddTicks(7349));

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_Date",
                value: new DateTime(2020, 5, 24, 21, 46, 3, 980, DateTimeKind.Local).AddTicks(9195));

            migrationBuilder.UpdateData(
                table: "Configuration",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2020, 5, 24, 21, 46, 3, 979, DateTimeKind.Local).AddTicks(1671));

            migrationBuilder.UpdateData(
                table: "Departements",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2020, 5, 24, 21, 46, 3, 981, DateTimeKind.Local).AddTicks(338));

            migrationBuilder.UpdateData(
                table: "Departements",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_Date",
                value: new DateTime(2020, 5, 24, 21, 46, 3, 981, DateTimeKind.Local).AddTicks(2067));

            migrationBuilder.UpdateData(
                table: "Departements",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_Date",
                value: new DateTime(2020, 5, 24, 21, 46, 3, 981, DateTimeKind.Local).AddTicks(2083));

            migrationBuilder.UpdateData(
                table: "Ticket_States",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2020, 5, 24, 21, 46, 4, 23, DateTimeKind.Local).AddTicks(6358));

            migrationBuilder.UpdateData(
                table: "Ticket_States",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_Date",
                value: new DateTime(2020, 5, 24, 21, 46, 4, 23, DateTimeKind.Local).AddTicks(7243));

            migrationBuilder.UpdateData(
                table: "Ticket_States",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_Date",
                value: new DateTime(2020, 5, 24, 21, 46, 4, 23, DateTimeKind.Local).AddTicks(7257));
        }
    }
}
