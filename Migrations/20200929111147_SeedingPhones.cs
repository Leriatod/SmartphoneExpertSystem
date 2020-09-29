using Microsoft.EntityFrameworkCore.Migrations;

namespace PhoneExp.Migrations
{
    public partial class SeedingPhones : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("SET IDENTITY_INSERT Phones ON");

            // PHONE 1
            migrationBuilder.Sql("INSERT INTO Phones (Id, Name, DescriptionUrl, ImageUrl) VALUES (1, 'Samsung Galaxy M31s 6/128GB Blue', 'https://rozetka.com.ua/samsung_sm_m317fzbnsek/p244007101/', 'https://i8.rozetka.ua/goods/19702495/samsung_sm_m317fzbnsek_images_19702495273.jpg')");
            migrationBuilder.Sql("INSERT INTO PhoneFeatures (PhoneId, FeatureId) VALUES (1, 1)");
            migrationBuilder.Sql("INSERT INTO PhoneFeatures (PhoneId, FeatureId) VALUES (1, 4)");
            migrationBuilder.Sql("INSERT INTO PhoneFeatures (PhoneId, FeatureId) VALUES (1, 8)");
            migrationBuilder.Sql("INSERT INTO PhoneFeatures (PhoneId, FeatureId) VALUES (1, 11)");
            migrationBuilder.Sql("INSERT INTO PhoneFeatures (PhoneId, FeatureId) VALUES (1, 16)");
            migrationBuilder.Sql("INSERT INTO PhoneFeatures (PhoneId, FeatureId) VALUES (1, 18)");
            migrationBuilder.Sql("INSERT INTO PhoneFeatures (PhoneId, FeatureId) VALUES (1, 21)");
            migrationBuilder.Sql("INSERT INTO PhoneFeatures (PhoneId, FeatureId) VALUES (1, 24)");
            migrationBuilder.Sql("INSERT INTO PhoneFeatures (PhoneId, FeatureId) VALUES (1, 27)");

            // PHONE 2
            migrationBuilder.Sql("INSERT INTO Phones (Id, Name, DescriptionUrl, ImageUrl) VALUES (2, 'Xiaomi Redmi 9C 2/32GB Midnight Gray', 'https://rozetka.com.ua/xiaomi_660922/p244758475/', 'https://i8.rozetka.ua/goods/19720858/xiaomi_660922_images_19720858189.jpg')");
            migrationBuilder.Sql("INSERT INTO PhoneFeatures (PhoneId, FeatureId) VALUES (2, 1)");
            migrationBuilder.Sql("INSERT INTO PhoneFeatures (PhoneId, FeatureId) VALUES (2, 4)");
            migrationBuilder.Sql("INSERT INTO PhoneFeatures (PhoneId, FeatureId) VALUES (2, 8)");
            migrationBuilder.Sql("INSERT INTO PhoneFeatures (PhoneId, FeatureId) VALUES (2, 15)");
            migrationBuilder.Sql("INSERT INTO PhoneFeatures (PhoneId, FeatureId) VALUES (2, 18)");
            migrationBuilder.Sql("INSERT INTO PhoneFeatures (PhoneId, FeatureId) VALUES (2, 20)");
            migrationBuilder.Sql("INSERT INTO PhoneFeatures (PhoneId, FeatureId) VALUES (2, 22)");
            migrationBuilder.Sql("INSERT INTO PhoneFeatures (PhoneId, FeatureId) VALUES (2, 26)");

            // PHONE 3
            migrationBuilder.Sql("INSERT INTO Phones (Id, Name, DescriptionUrl, ImageUrl) VALUES (3, 'Huawei P40 lite 6/128GB Emerald Green', 'https://rozetka.com.ua/huawei_p40_lite_6_128_green/p191045695/', 'https://i8.rozetka.ua/goods/17482858/huawei_p40_lite_6_128_green_images_17482858627.jpg')");
            migrationBuilder.Sql("INSERT INTO PhoneFeatures (PhoneId, FeatureId) VALUES (3, 1)");
            migrationBuilder.Sql("INSERT INTO PhoneFeatures (PhoneId, FeatureId) VALUES (3, 4)");
            migrationBuilder.Sql("INSERT INTO PhoneFeatures (PhoneId, FeatureId) VALUES (3, 8)");
            migrationBuilder.Sql("INSERT INTO PhoneFeatures (PhoneId, FeatureId) VALUES (3, 11)");
            migrationBuilder.Sql("INSERT INTO PhoneFeatures (PhoneId, FeatureId) VALUES (3, 15)");
            migrationBuilder.Sql("INSERT INTO PhoneFeatures (PhoneId, FeatureId) VALUES (3, 18)");
            migrationBuilder.Sql("INSERT INTO PhoneFeatures (PhoneId, FeatureId) VALUES (3, 21)");
            migrationBuilder.Sql("INSERT INTO PhoneFeatures (PhoneId, FeatureId) VALUES (3, 24)");
            migrationBuilder.Sql("INSERT INTO PhoneFeatures (PhoneId, FeatureId) VALUES (3, 26)");

            // PHONE 4
            migrationBuilder.Sql("INSERT INTO Phones (Id, Name, DescriptionUrl, ImageUrl) VALUES (4, 'Apple iPhone SE 64GB (2020) White', 'https://rozetka.com.ua/apple_iphone_se_64gb_white/p205228429/', 'https://i8.rozetka.ua/goods/17801797/apple_iphone_se_64gb_white_images_17801797963.png')");
            migrationBuilder.Sql("INSERT INTO PhoneFeatures (PhoneId, FeatureId) VALUES (4, 2)");
            migrationBuilder.Sql("INSERT INTO PhoneFeatures (PhoneId, FeatureId) VALUES (4, 5)");
            migrationBuilder.Sql("INSERT INTO PhoneFeatures (PhoneId, FeatureId) VALUES (4, 6)");
            migrationBuilder.Sql("INSERT INTO PhoneFeatures (PhoneId, FeatureId) VALUES (4, 11)");
            migrationBuilder.Sql("INSERT INTO PhoneFeatures (PhoneId, FeatureId) VALUES (4, 16)");
            migrationBuilder.Sql("INSERT INTO PhoneFeatures (PhoneId, FeatureId) VALUES (4, 17)");
            migrationBuilder.Sql("INSERT INTO PhoneFeatures (PhoneId, FeatureId) VALUES (4, 20)");
            migrationBuilder.Sql("INSERT INTO PhoneFeatures (PhoneId, FeatureId) VALUES (4, 23)");
            migrationBuilder.Sql("INSERT INTO PhoneFeatures (PhoneId, FeatureId) VALUES (4, 26)");

            // PHONE 5
            migrationBuilder.Sql("INSERT INTO Phones (Id, Name, DescriptionUrl, ImageUrl) VALUES (5, 'Apple iPhone 11 64GB Purple', 'https://rozetka.com.ua/apple_mwlx2/p141550235/', 'https://i2.rozetka.ua/goods/14906619/copy_apple_iphone_11_64gb_purple_5dc03ab174536_images_14906619183.jpg')");
            migrationBuilder.Sql("INSERT INTO PhoneFeatures (PhoneId, FeatureId) VALUES (5, 2)");
            migrationBuilder.Sql("INSERT INTO PhoneFeatures (PhoneId, FeatureId) VALUES (5, 5)");
            migrationBuilder.Sql("INSERT INTO PhoneFeatures (PhoneId, FeatureId) VALUES (5, 8)");
            migrationBuilder.Sql("INSERT INTO PhoneFeatures (PhoneId, FeatureId) VALUES (5, 11)");
            migrationBuilder.Sql("INSERT INTO PhoneFeatures (PhoneId, FeatureId) VALUES (5, 15)");
            migrationBuilder.Sql("INSERT INTO PhoneFeatures (PhoneId, FeatureId) VALUES (5, 17)");
            migrationBuilder.Sql("INSERT INTO PhoneFeatures (PhoneId, FeatureId) VALUES (5, 20)");
            migrationBuilder.Sql("INSERT INTO PhoneFeatures (PhoneId, FeatureId) VALUES (5, 23)");
            migrationBuilder.Sql("INSERT INTO PhoneFeatures (PhoneId, FeatureId) VALUES (5, 25)");

            migrationBuilder.Sql("SET IDENTITY_INSERT Phones OFF");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Phones");
        }
    }
}
