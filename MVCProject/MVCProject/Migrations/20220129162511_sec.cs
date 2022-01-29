using Microsoft.EntityFrameworkCore.Migrations;

namespace MVCProject.Migrations
{
    public partial class sec : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_instrcutors_Inst_Id",
                table: "Students");

            migrationBuilder.AlterColumn<int>(
                name: "Inst_Id",
                table: "Students",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_instrcutors_Inst_Id",
                table: "Students",
                column: "Inst_Id",
                principalTable: "instrcutors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_instrcutors_Inst_Id",
                table: "Students");

            migrationBuilder.AlterColumn<int>(
                name: "Inst_Id",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_instrcutors_Inst_Id",
                table: "Students",
                column: "Inst_Id",
                principalTable: "instrcutors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
