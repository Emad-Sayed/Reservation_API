using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace _DB.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    Discriminator = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Branches",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Created_Date = table.Column<DateTime>(nullable: false),
                    Last_Update = table.Column<DateTime>(nullable: true),
                    Is_Deleted = table.Column<bool>(nullable: false),
                    Branch_Name_Ar = table.Column<string>(nullable: true),
                    Branch_Name_En = table.Column<string>(nullable: true),
                    Branch_Address = table.Column<string>(nullable: true),
                    Branch_Phone = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Branches", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Configuration",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Created_Date = table.Column<DateTime>(nullable: false),
                    Last_Update = table.Column<DateTime>(nullable: true),
                    Is_Deleted = table.Column<bool>(nullable: false),
                    Start_Reserving_Time = table.Column<TimeSpan>(nullable: false),
                    End_Reserving_Time = table.Column<TimeSpan>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Configuration", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Departements",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Created_Date = table.Column<DateTime>(nullable: false),
                    Last_Update = table.Column<DateTime>(nullable: true),
                    Is_Deleted = table.Column<bool>(nullable: false),
                    Departement_Name_Ar = table.Column<string>(nullable: true),
                    Departement_Name_En = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departements", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ticket_States",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Created_Date = table.Column<DateTime>(nullable: false),
                    Last_Update = table.Column<DateTime>(nullable: true),
                    Is_Deleted = table.Column<bool>(nullable: false),
                    State_Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ticket_States", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Branch_Departements",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Created_Date = table.Column<DateTime>(nullable: false),
                    Last_Update = table.Column<DateTime>(nullable: true),
                    Is_Deleted = table.Column<bool>(nullable: false),
                    Branch_Id = table.Column<int>(nullable: false),
                    Departement_Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Branch_Departements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Branch_Departements_Branches_Branch_Id",
                        column: x => x.Branch_Id,
                        principalTable: "Branches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Branch_Departements_Departements_Departement_Id",
                        column: x => x.Departement_Id,
                        principalTable: "Departements",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    Confirmation_Code = table.Column<string>(nullable: true),
                    Block = table.Column<bool>(nullable: false),
                    BRANCH_DEPARTEMENT_ID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_Branch_Departements_BRANCH_DEPARTEMENT_ID",
                        column: x => x.BRANCH_DEPARTEMENT_ID,
                        principalTable: "Branch_Departements",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tickets",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Created_Date = table.Column<DateTime>(nullable: false),
                    Last_Update = table.Column<DateTime>(nullable: true),
                    Is_Deleted = table.Column<bool>(nullable: false),
                    Ticket_Number = table.Column<int>(nullable: false),
                    Client_Id = table.Column<string>(nullable: true),
                    State_Id = table.Column<int>(nullable: false),
                    Branch_Departement_Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tickets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tickets_Branch_Departements_Branch_Departement_Id",
                        column: x => x.Branch_Departement_Id,
                        principalTable: "Branch_Departements",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tickets_AspNetUsers_Client_Id",
                        column: x => x.Client_Id,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tickets_Ticket_States_State_Id",
                        column: x => x.State_Id,
                        principalTable: "Ticket_States",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ticket_Reserves",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Created_Date = table.Column<DateTime>(nullable: false),
                    Last_Update = table.Column<DateTime>(nullable: true),
                    Is_Deleted = table.Column<bool>(nullable: false),
                    Ticket_Id = table.Column<int>(nullable: false),
                    Employee_Id = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ticket_Reserves", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ticket_Reserves_AspNetUsers_Employee_Id",
                        column: x => x.Employee_Id,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Ticket_Reserves_Tickets_Ticket_Id",
                        column: x => x.Ticket_Id,
                        principalTable: "Tickets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Discriminator", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "a18be9c0-aa65-4af8-bd17-00bd9344e575", "e7a8eeed-8944-4584-8d53-18d62432edc8", "AppUserRole", "admin", "admin" },
                    { "a18be9c0-aa65-4af8-bd17-00bd9344e577", "c58b6232-db38-4b96-a0d6-b8cff6aa14af", "AppUserRole", "employee", "employee" },
                    { "a18be9c0-aa65-4af8-bd17-00bd9344e578", "4c67b762-c8f5-4be6-bbe9-4426ee097579", "AppUserRole", "client", "client" }
                });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "Id", "Branch_Address", "Branch_Name_Ar", "Branch_Name_En", "Branch_Phone", "Created_Date", "Is_Deleted", "Last_Update" },
                values: new object[,]
                {
                    { 1, "108 St Number 4", "القاهرة", "Cairo", "101051453123", new DateTime(2020, 5, 30, 19, 28, 43, 699, DateTimeKind.Local).AddTicks(7965), false, null },
                    { 2, "445 St Number 8", "الجيزة", "Giza", "112323123", new DateTime(2020, 5, 30, 19, 28, 43, 700, DateTimeKind.Local).AddTicks(322), false, null }
                });

            migrationBuilder.InsertData(
                table: "Configuration",
                columns: new[] { "Id", "Created_Date", "End_Reserving_Time", "Is_Deleted", "Last_Update", "Start_Reserving_Time" },
                values: new object[] { 1, new DateTime(2020, 5, 30, 19, 28, 43, 698, DateTimeKind.Local).AddTicks(1024), new TimeSpan(0, 18, 30, 0, 0), false, null, new TimeSpan(0, 7, 30, 0, 0) });

            migrationBuilder.InsertData(
                table: "Departements",
                columns: new[] { "Id", "Created_Date", "Departement_Name_Ar", "Departement_Name_En", "Is_Deleted", "Last_Update" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 5, 30, 19, 28, 43, 700, DateTimeKind.Local).AddTicks(1402), "محاسبة", "ACCOUNTING", false, null },
                    { 2, new DateTime(2020, 5, 30, 19, 28, 43, 700, DateTimeKind.Local).AddTicks(2508), "شكوى", "COMPLAIGN", false, null },
                    { 3, new DateTime(2020, 5, 30, 19, 28, 43, 700, DateTimeKind.Local).AddTicks(2521), "استفسار", "REQUIREMENT", false, null }
                });

            migrationBuilder.InsertData(
                table: "Ticket_States",
                columns: new[] { "Id", "Created_Date", "Is_Deleted", "Last_Update", "State_Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 5, 30, 19, 28, 43, 741, DateTimeKind.Local).AddTicks(3285), false, null, "PENDING" },
                    { 2, new DateTime(2020, 5, 30, 19, 28, 43, 741, DateTimeKind.Local).AddTicks(4122), false, null, "SERVING" },
                    { 3, new DateTime(2020, 5, 30, 19, 28, 43, 741, DateTimeKind.Local).AddTicks(4132), false, null, "DONE" }
                });

            migrationBuilder.InsertData(
                table: "Branch_Departements",
                columns: new[] { "Id", "Branch_Id", "Created_Date", "Departement_Id", "Is_Deleted", "Last_Update" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2020, 5, 30, 19, 28, 43, 700, DateTimeKind.Local).AddTicks(3481), 1, false, null },
                    { 4, 2, new DateTime(2020, 5, 30, 19, 28, 43, 700, DateTimeKind.Local).AddTicks(4872), 1, false, null },
                    { 2, 1, new DateTime(2020, 5, 30, 19, 28, 43, 700, DateTimeKind.Local).AddTicks(4858), 2, false, null },
                    { 5, 2, new DateTime(2020, 5, 30, 19, 28, 43, 700, DateTimeKind.Local).AddTicks(4873), 2, false, null },
                    { 3, 1, new DateTime(2020, 5, 30, 19, 28, 43, 700, DateTimeKind.Local).AddTicks(4870), 3, false, null },
                    { 6, 2, new DateTime(2020, 5, 30, 19, 28, 43, 700, DateTimeKind.Local).AddTicks(4875), 3, false, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "BRANCH_DEPARTEMENT_ID", "Block", "ConcurrencyStamp", "Confirmation_Code", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "a18be9c0-aa65-4af8-bd17-00bd9344e575", 0, 1, false, "2299979c-17bd-4653-986a-a021f503ec9d", null, "admin@admin.com", true, false, null, "admin@admin.com", "admin", "AQAAAAEAACcQAAAAECLoMjHpGmerExiKmi6GvPLQkUrfqG+VOH2i2M/yBu9ovHWgrsNSNc3PoNTKx7EwrQ==", null, false, "", false, "admin" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "BRANCH_DEPARTEMENT_ID", "Block", "ConcurrencyStamp", "Confirmation_Code", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "a18be9c0-aa65-4af8-bd17-00bd9344e578", 0, 4, false, "04b51209-f5bb-43f3-b685-7d25a610d2bc", null, "client@client.com", true, false, null, "client@client.com", "client", "AQAAAAEAACcQAAAAEA7fYI7Zlddi2MvnzalbJCMxDC/q5GA9cSOrwRRCoWt6I209ZQw92QH67pgj0Weirg==", null, false, "", false, "client" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "BRANCH_DEPARTEMENT_ID", "Block", "ConcurrencyStamp", "Confirmation_Code", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "a18be9c0-aa65-4af8-bd17-00bd9344e577", 0, 2, false, "ba110731-6d03-43cf-835e-0a756bfc5f0f", null, "employee@employee.com", true, false, null, "employee@employee.com", "employee", "AQAAAAEAACcQAAAAEBNB5DVmizr2U5YY66xRP+p38lQPrddzFrj/1SfO56YdiAuo6X0NRIG8VF4VqLbI5Q==", null, false, "", false, "employee" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "a18be9c0-aa65-4af8-bd17-00bd9344e575", "a18be9c0-aa65-4af8-bd17-00bd9344e575" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "a18be9c0-aa65-4af8-bd17-00bd9344e577", "a18be9c0-aa65-4af8-bd17-00bd9344e577" });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_BRANCH_DEPARTEMENT_ID",
                table: "AspNetUsers",
                column: "BRANCH_DEPARTEMENT_ID");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Branch_Departements_Branch_Id",
                table: "Branch_Departements",
                column: "Branch_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Branch_Departements_Departement_Id",
                table: "Branch_Departements",
                column: "Departement_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_Reserves_Employee_Id",
                table: "Ticket_Reserves",
                column: "Employee_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_Reserves_Ticket_Id",
                table: "Ticket_Reserves",
                column: "Ticket_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_Branch_Departement_Id",
                table: "Tickets",
                column: "Branch_Departement_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_Client_Id",
                table: "Tickets",
                column: "Client_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_State_Id",
                table: "Tickets",
                column: "State_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Configuration");

            migrationBuilder.DropTable(
                name: "Ticket_Reserves");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Tickets");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Ticket_States");

            migrationBuilder.DropTable(
                name: "Branch_Departements");

            migrationBuilder.DropTable(
                name: "Branches");

            migrationBuilder.DropTable(
                name: "Departements");
        }
    }
}
