using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuanLyBanHang.Migrations
{
    /// <inheritdoc />
    public partial class InitDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "SanPham",
                newName: "ID");

            migrationBuilder.AlterColumn<int>(
                name: "SoLuongBan",
                table: "HoaDon_ChiTiet",
                type: "int",
                nullable: false,
                oldClrType: typeof(short),
                oldType: "smallint");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ID",
                table: "SanPham",
                newName: "Id");

            migrationBuilder.AlterColumn<short>(
                name: "SoLuongBan",
                table: "HoaDon_ChiTiet",
                type: "smallint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}
