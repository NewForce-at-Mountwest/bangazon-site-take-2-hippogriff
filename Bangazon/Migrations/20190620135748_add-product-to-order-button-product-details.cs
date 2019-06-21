using Microsoft.EntityFrameworkCore.Migrations;

namespace Bangazon.Migrations
{
    public partial class addproducttoorderbuttonproductdetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5acccf2f-fa75-4255-8290-d1d8d236ecae", "AQAAAAEAACcQAAAAEEf26T95IaxKpniuh/jZdbLfRM0G8hX2t1hcdOAniI2tcaqWZpNEXGlsVI1LvGRzow==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9f72faa0-4eae-4f8b-a38c-5e3838f3519b", "AQAAAAEAACcQAAAAEF/B/NunJFieD+fMc3CG/ZT9cInAy0inLrqlkYssg/QyNfPZlQ9oepY00wbc0xuHrA==" });
        }
    }
}
