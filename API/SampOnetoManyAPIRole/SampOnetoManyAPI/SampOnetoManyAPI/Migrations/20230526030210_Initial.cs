using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SampOnetoManyAPI.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProId);
                });

            migrationBuilder.CreateTable(
                name: "Seats",
                columns: table => new
                {
                    SeatId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ScreenId = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seats", x => x.SeatId);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Roles = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmailId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "MoviesDetails",
                columns: table => new
                {
                    MovieId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MovieTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MovieGenre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cost = table.Column<float>(type: "real", nullable: false),
                    ReleasedDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DroppedDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    screening_scheduleScreenId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MoviesDetails", x => x.MovieId);
                });

            migrationBuilder.CreateTable(
                name: "ScreeningSchedules",
                columns: table => new
                {
                    ScreenId = table.Column<int>(type: "int", nullable: false),
                    ScreenTimings = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MovieId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScreeningSchedules", x => x.ScreenId);
                    table.ForeignKey(
                        name: "FK_ScreeningSchedules_MoviesDetails_MovieId",
                        column: x => x.MovieId,
                        principalTable: "MoviesDetails",
                        principalColumn: "MovieId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ticketBookings",
                columns: table => new
                {
                    BookingId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    MovieId = table.Column<int>(type: "int", nullable: false),
                    ScreenId = table.Column<int>(type: "int", nullable: false),
                    Count = table.Column<int>(type: "int", nullable: false),
                    SeatId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Cash = table.Column<float>(type: "real", nullable: false),
                    MovieDetailsMovieId = table.Column<int>(type: "int", nullable: true),
                    UsersUserId = table.Column<int>(type: "int", nullable: true),
                    screening_scheduleScreenId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ticketBookings", x => x.BookingId);
                    table.ForeignKey(
                        name: "FK_ticketBookings_MoviesDetails_MovieDetailsMovieId",
                        column: x => x.MovieDetailsMovieId,
                        principalTable: "MoviesDetails",
                        principalColumn: "MovieId");
                    table.ForeignKey(
                        name: "FK_ticketBookings_ScreeningSchedules_screening_scheduleScreenId",
                        column: x => x.screening_scheduleScreenId,
                        principalTable: "ScreeningSchedules",
                        principalColumn: "ScreenId");
                    table.ForeignKey(
                        name: "FK_ticketBookings_Seats_SeatId",
                        column: x => x.SeatId,
                        principalTable: "Seats",
                        principalColumn: "SeatId");
                    table.ForeignKey(
                        name: "FK_ticketBookings_Users_UsersUserId",
                        column: x => x.UsersUserId,
                        principalTable: "Users",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_MoviesDetails_screening_scheduleScreenId",
                table: "MoviesDetails",
                column: "screening_scheduleScreenId");

            migrationBuilder.CreateIndex(
                name: "IX_ScreeningSchedules_MovieId",
                table: "ScreeningSchedules",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_ticketBookings_MovieDetailsMovieId",
                table: "ticketBookings",
                column: "MovieDetailsMovieId");

            migrationBuilder.CreateIndex(
                name: "IX_ticketBookings_screening_scheduleScreenId",
                table: "ticketBookings",
                column: "screening_scheduleScreenId");

            migrationBuilder.CreateIndex(
                name: "IX_ticketBookings_SeatId",
                table: "ticketBookings",
                column: "SeatId");

            migrationBuilder.CreateIndex(
                name: "IX_ticketBookings_UsersUserId",
                table: "ticketBookings",
                column: "UsersUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_MoviesDetails_ScreeningSchedules_screening_scheduleScreenId",
                table: "MoviesDetails",
                column: "screening_scheduleScreenId",
                principalTable: "ScreeningSchedules",
                principalColumn: "ScreenId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MoviesDetails_ScreeningSchedules_screening_scheduleScreenId",
                table: "MoviesDetails");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "ticketBookings");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Seats");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "ScreeningSchedules");

            migrationBuilder.DropTable(
                name: "MoviesDetails");
        }
    }
}
