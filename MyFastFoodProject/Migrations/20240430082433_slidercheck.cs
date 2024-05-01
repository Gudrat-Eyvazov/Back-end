using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyFastFoodProject.Migrations
{
    /// <inheritdoc />
    public partial class slidercheck : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsCheck",
                table: "Sliders",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsCheck",
                table: "Sliders");
        }
    }
}
