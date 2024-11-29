using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace cairo_library.Migrations
{
    public partial class add2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "librarians",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Firstname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Lastname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phonenumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Hiredate = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_librarians", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "members",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Firstname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Lastname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phonenumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Membershipdate = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_members", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "checkouts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Member_id = table.Column<int>(type: "int", nullable: false),
                    Librarian_id = table.Column<int>(type: "int", nullable: false),
                    librariansId = table.Column<int>(type: "int", nullable: false),
                    Checkout_date = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Due_date = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Penality_amount = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Return_date = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_checkouts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_checkouts_librarians_librariansId",
                        column: x => x.librariansId,
                        principalTable: "librarians",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_checkouts_members_Member_id",
                        column: x => x.Member_id,
                        principalTable: "members",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "penalities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Member_id = table.Column<int>(type: "int", nullable: false),
                    membersId = table.Column<int>(type: "int", nullable: false),
                    Penality_amount = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Payment_status = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_penalities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_penalities_members_membersId",
                        column: x => x.membersId,
                        principalTable: "members",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "books",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Isbn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Genre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bublishdate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    checkoutsid = table.Column<int>(type: "int", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_books", x => x.Id);
                    table.ForeignKey(
                        name: "FK_books_checkouts_checkoutsid",
                        column: x => x.checkoutsid,
                        principalTable: "checkouts",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_books_checkoutsid",
                table: "books",
                column: "checkoutsid");

            migrationBuilder.CreateIndex(
                name: "IX_checkouts_librariansId",
                table: "checkouts",
                column: "librariansId");

            migrationBuilder.CreateIndex(
                name: "IX_checkouts_Member_id",
                table: "checkouts",
                column: "Member_id");

            migrationBuilder.CreateIndex(
                name: "IX_penalities_membersId",
                table: "penalities",
                column: "membersId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "books");

            migrationBuilder.DropTable(
                name: "penalities");

            migrationBuilder.DropTable(
                name: "checkouts");

            migrationBuilder.DropTable(
                name: "librarians");

            migrationBuilder.DropTable(
                name: "members");
        }
    }
}
