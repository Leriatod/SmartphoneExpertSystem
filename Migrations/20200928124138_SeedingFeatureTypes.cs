using Microsoft.EntityFrameworkCore.Migrations;

namespace PhoneExp.Migrations
{
    public partial class SeedingFeatureTypes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("SET IDENTITY_INSERT FeatureTypes ON");
            migrationBuilder.Sql("INSERT INTO FeatureTypes(Id, Name) VALUES (1, 'Price')");
            migrationBuilder.Sql("INSERT INTO FeatureTypes(Id, Name) VALUES (2, 'Operating System')");
            migrationBuilder.Sql("INSERT INTO FeatureTypes(Id, Name) VALUES (3, 'Screen Size')");
            migrationBuilder.Sql("INSERT INTO FeatureTypes(Id, Name) VALUES (4, 'Display Quality')");
            migrationBuilder.Sql("INSERT INTO FeatureTypes(Id, Name) VALUES (5, 'Design')");
            migrationBuilder.Sql("INSERT INTO FeatureTypes(Id, Name) VALUES (6, 'Camera')");
            migrationBuilder.Sql("INSERT INTO FeatureTypes(Id, Name) VALUES (7, 'Processor')");
            migrationBuilder.Sql("INSERT INTO FeatureTypes(Id, Name) VALUES (8, 'Ram')");
            migrationBuilder.Sql("INSERT INTO FeatureTypes(Id, Name) VALUES (9, 'Internal Storage')");
            migrationBuilder.Sql("INSERT INTO FeatureTypes(Id, Name) VALUES (10, 'Battery Life')");
            migrationBuilder.Sql("SET IDENTITY_INSERT FeatureTypes OFF");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM FeatureTypes");
        }
    }
}
