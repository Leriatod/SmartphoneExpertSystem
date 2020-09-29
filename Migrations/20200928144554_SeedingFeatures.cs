using Microsoft.EntityFrameworkCore.Migrations;

namespace PhoneExp.Migrations
{
    public partial class SeedingFeatures : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("SET IDENTITY_INSERT Features ON");

            // PRICE features
            migrationBuilder.Sql("INSERT INTO Features (Id, Name, FeatureTypeId) VALUES (1, 'Below 500$', 1)");
            migrationBuilder.Sql("INSERT INTO Features (Id, Name, FeatureTypeId) VALUES (2, 'From 500$ to 1000$', 1)");
            migrationBuilder.Sql("INSERT INTO Features (Id, Name, FeatureTypeId) VALUES (3, 'Higher than 1000$', 1)");

            // OPERATING SYSTEM features
            migrationBuilder.Sql("INSERT INTO Features (Id, Name, FeatureTypeId) VALUES (4, 'Android', 2)");
            migrationBuilder.Sql("INSERT INTO Features (Id, Name, FeatureTypeId) VALUES (5, 'IOS', 2)");

            // SCREEN SIZE features
            migrationBuilder.Sql("INSERT INTO Features (Id, Name, FeatureTypeId) VALUES (6, 'Small Screen (5 Inches or Smaller)', 3)");
            migrationBuilder.Sql("INSERT INTO Features (Id, Name, FeatureTypeId) VALUES (7, 'Medium Screen (5 to 5.5 Inches)', 3)");
            migrationBuilder.Sql("INSERT INTO Features (Id, Name, FeatureTypeId) VALUES (8, 'Large Screen (5.5 Inches or Larger)', 3)");

            // DISPLAY QUALITY features
            migrationBuilder.Sql("INSERT INTO Features (Id, Name, FeatureTypeId) VALUES (9, '720p (HD, High Definition)', 4)");
            migrationBuilder.Sql("INSERT INTO Features (Id, Name, FeatureTypeId) VALUES (10, '1080p (Full HD, High Definition)-Recommended', 4)");
            migrationBuilder.Sql("INSERT INTO Features (Id, Name, FeatureTypeId) VALUES (11, '2K (Quad HD, Super High)', 4)");

            // DESIGN features
            migrationBuilder.Sql("INSERT INTO Features (Id, Name, FeatureTypeId) VALUES (12, 'Water-resistant', 5)");

            // CAMERA features
            migrationBuilder.Sql("INSERT INTO Features (Id, Name, FeatureTypeId) VALUES (14, 'Ultrawide lenses for making stunning landscapes', 6)");
            migrationBuilder.Sql("INSERT INTO Features (Id, Name, FeatureTypeId) VALUES (15, 'Telephotos for making portraits', 6)");
            migrationBuilder.Sql("INSERT INTO Features (Id, Name, FeatureTypeId) VALUES (16, 'Both', 6)");

            // PROCESSOR features
            migrationBuilder.Sql("INSERT INTO Features (Id, Name, FeatureTypeId) VALUES (17, 'Quad-Core(For daily needs)-Recommended', 7)");
            migrationBuilder.Sql("INSERT INTO Features (Id, Name, FeatureTypeId) VALUES (18, 'Octa-Core(For playing games, recording video and etc.)', 7)");

            // RAM features
            migrationBuilder.Sql("INSERT INTO Features (Id, Name, FeatureTypeId) VALUES (19, 'Low(1GB of system memory)', 8)");
            migrationBuilder.Sql("INSERT INTO Features (Id, Name, FeatureTypeId) VALUES (20, 'Medium(2-4GB of system memory)-Recommended', 8)");
            migrationBuilder.Sql("INSERT INTO Features (Id, Name, FeatureTypeId) VALUES (21, 'High(8GB of system memory)-For Gaming', 8)");

            // INTERNAL storage features
            migrationBuilder.Sql("INSERT INTO Features (Id, Name, FeatureTypeId) VALUES (22, 'Low(32GB)', 9)");
            migrationBuilder.Sql("INSERT INTO Features (Id, Name, FeatureTypeId) VALUES (23, 'Medium(64GB)-Recommended', 9)");
            migrationBuilder.Sql("INSERT INTO Features (Id, Name, FeatureTypeId) VALUES (24, 'High(128GB)-Recording videos and downloading games', 9)");

            // BATTERY LIFE features
            migrationBuilder.Sql("INSERT INTO Features (Id, Name, FeatureTypeId) VALUES (25, 'Less than 10 hours on a charge', 10)");
            migrationBuilder.Sql("INSERT INTO Features (Id, Name, FeatureTypeId) VALUES (26, '10-15 hours on a charge (Recomended)', 10)");
            migrationBuilder.Sql("INSERT INTO Features (Id, Name, FeatureTypeId) VALUES (27, '15+ hours on a charge', 10)");


            migrationBuilder.Sql("SET IDENTITY_INSERT Features OFF");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Features");
        }
    }
}
