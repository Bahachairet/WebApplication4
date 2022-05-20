using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication4.Migrations
{
    public partial class Intial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categorie",
                columns: table => new
                {
                    CategId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Categname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Categdescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Categphotos = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorie", x => x.CategId);
                });

            migrationBuilder.CreateTable(
                name: "Client",
                columns: table => new
                {
                    ClientId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Clientfirstname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Clientlastname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Clientemail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Clientpassword = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client", x => x.ClientId);
                });

            migrationBuilder.CreateTable(
                name: "Freelancer",
                columns: table => new
                {
                    FreelancerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Freelancername = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Freelanceremail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Freelancerpassword = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Freelancerdescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Freelanceroccup = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Freelancer", x => x.FreelancerId);
                });

            migrationBuilder.CreateTable(
                name: "Freelancer_Categories",
                columns: table => new
                {
                    CategId = table.Column<int>(type: "int", nullable: false),
                    FreelancerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Freelancer_Categories", x => new { x.FreelancerId, x.CategId });
                    table.ForeignKey(
                        name: "FK_Freelancer_Categories_Categorie_FreelancerId",
                        column: x => x.FreelancerId,
                        principalTable: "Categorie",
                        principalColumn: "CategId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Freelancer_Categories_Freelancer_CategId",
                        column: x => x.CategId,
                        principalTable: "Freelancer",
                        principalColumn: "FreelancerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Gig",
                columns: table => new
                {
                    GigId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Gigcateg = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gigtitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gigusername = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gigabout = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gigprice = table.Column<int>(type: "int", nullable: false),
                    Gigaboutuser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gigphotos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FreelancersFreelancerId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gig", x => x.GigId);
                    table.ForeignKey(
                        name: "FK_Gig_Freelancer_FreelancersFreelancerId",
                        column: x => x.FreelancersFreelancerId,
                        principalTable: "Freelancer",
                        principalColumn: "FreelancerId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Freelancer_Categories_CategId",
                table: "Freelancer_Categories",
                column: "CategId");

            migrationBuilder.CreateIndex(
                name: "IX_Gig_FreelancersFreelancerId",
                table: "Gig",
                column: "FreelancersFreelancerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Client");

            migrationBuilder.DropTable(
                name: "Freelancer_Categories");

            migrationBuilder.DropTable(
                name: "Gig");

            migrationBuilder.DropTable(
                name: "Categorie");

            migrationBuilder.DropTable(
                name: "Freelancer");
        }
    }
}
