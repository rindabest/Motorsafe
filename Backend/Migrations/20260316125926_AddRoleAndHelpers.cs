using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MotorSafe.Backend.Migrations
{
    /// <inheritdoc />
    public partial class AddRoleAndHelpers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Role",
                table: "Mechanics",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "Role", "ShopName", "SpecialSkills" },
                values: new object[] { "144 Bạch Đằng, Hải Châu, Đà Nẵng", 16.039693, 108.207701, "Trần Văn Hùng", "0902266383", 4.5999999999999996, "Mechanic", "Dũng Motor Service", "Tires, Chain" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "Role", "ShopName", "SpecialSkills" },
                values: new object[] { "76 Lê Duẩn, Hải Châu, Đà Nẵng", 16.07141, 108.187268, "Dương Văn Cường", "0907010156", 4.5999999999999996, "Mechanic", "Phú Motor Service", "Battery, Engine" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "Role", "ShopName" },
                values: new object[] { "189 Nguyễn Tri Phương, Liên Chiểu, Đà Nẵng", 16.071504000000001, 108.195036, "Đặng Công Phong", "0901805365", 4.7000000000000002, "Mechanic", "Phong Motor Service" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Role", "ShopName", "SpecialSkills" },
                values: new object[] { "137 Hoàng Diệu, Sơn Trà, Đà Nẵng", 16.035803000000001, 108.19898000000001, "Vũ Đình Minh", "0901081922", "Mechanic", "Tâm Motor Service", "Chain, Tires" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Role", "ShopName", "SpecialSkills" },
                values: new object[] { "195 Lê Duẩn, Ngũ Hành Sơn, Đà Nẵng", 16.0425, 108.21868499999999, "Lý Quốc Nam", "0906354693", "Mechanic", "Giang Motor Service", "Battery" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "Role", "ShopName" },
                values: new object[] { "27 Hùng Vương, Hải Châu, Đà Nẵng", 16.044758999999999, 108.236181, "Ngô Ngọc Nam", "0907535371", 4.4000000000000004, "Mechanic", "Phú Motor Service" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "Role", "ShopName", "SpecialSkills" },
                values: new object[] { "89 Hùng Vương, Sơn Trà, Đà Nẵng", 16.059097000000001, 108.198215, "Đặng Thu Phương Phú", "0904558472", 4.2000000000000002, "Mechanic", "Hùng Motor Service", "Engine" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "Role", "ShopName", "SpecialSkills" },
                values: new object[] { "69 Phạm Văn Đồng, Thanh Khê, Đà Nẵng", 16.072583999999999, 108.182838, "Hồ Thành An", "0906325015", 4.9000000000000004, "Mechanic", "Phát Motor Service", "Chain, Tires" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "Role", "ShopName", "SpecialSkills" },
                values: new object[] { "153 Hùng Vương, Thanh Khê, Đà Nẵng", 16.050722, 108.19533, "Trần Quang An", "0902252554", 4.7000000000000002, "Mechanic", "Khánh Motor Service", "All" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "Role", "ShopName", "SpecialSkills" },
                values: new object[] { "174 Phạm Văn Đồng, Liên Chiểu, Đà Nẵng", 16.040134999999999, 108.192561, "Đặng Công Khánh", "0902181530", 4.7000000000000002, "Mechanic", "Phát Motor Service", "Battery" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "Role", "ShopName", "SpecialSkills" },
                values: new object[] { "94 Trần Phú, Cẩm Lệ, Đà Nẵng", 16.075185999999999, 108.194344, "Hồ Quang Phú", "0907368463", 4.2999999999999998, "Mechanic", "Giang Motor Service", "All" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "Role", "ShopName", "SpecialSkills" },
                values: new object[] { "40 Hùng Vương, Cẩm Lệ, Đà Nẵng", 16.058599000000001, 108.181062, "Hồ Hữu Khánh", "0906900481", 4.7999999999999998, "Mechanic", "An Motor Service", "Engine" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "Role", "ShopName", "SpecialSkills" },
                values: new object[] { "41 Phạm Văn Đồng, Liên Chiểu, Đà Nẵng", 16.037997000000001, 108.201457, "Bùi Thu Phương Bảo", "0906362140", 4.7000000000000002, "Mechanic", "Giang Motor Service", "Start" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "Role", "ShopName", "SpecialSkills" },
                values: new object[] { "200 Điện Biên Phủ, Hải Châu, Đà Nẵng", 16.079957, 108.208333, "Dương Văn Phú", "0906886917", 4.7000000000000002, "Mechanic", "Em Motor Service", "Chain, Tires" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Role", "ShopName", "SpecialSkills" },
                values: new object[] { "72 Hùng Vương, Cẩm Lệ, Đà Nẵng", 16.039353999999999, 108.229726, "Phạm Công Long", "0905527799", "Mechanic", "An Motor Service", "Battery" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "Role", "ShopName", "SpecialSkills" },
                values: new object[] { "31 Nguyễn Văn Linh, Thanh Khê, Đà Nẵng", 16.057452000000001, 108.223732, "Đỗ Đức Khánh", "0904547342", 4.0999999999999996, "Mechanic", "Giang Motor Service", "Battery, Engine" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "Role", "ShopName", "SpecialSkills" },
                values: new object[] { "31 Trần Phú, Ngũ Hành Sơn, Đà Nẵng", 16.068100000000001, 108.20604899999999, "Võ Bích Phú", "0903913619", 4.5, "Mechanic", "Hùng Motor Service", "Engine" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "Role", "ShopName", "SpecialSkills" },
                values: new object[] { "137 Phạm Văn Đồng, Hải Châu, Đà Nẵng", 16.059002, 108.197163, "Bùi Thanh Nam", "0909675901", 4.2000000000000002, "Mechanic", "Long Motor Service", "Battery, Engine" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "Role", "ShopName", "SpecialSkills" },
                values: new object[] { "144 Nguyễn Văn Linh, Ngũ Hành Sơn, Đà Nẵng", 16.057421999999999, 108.238657, "Bùi Đình Cường", "0902676611", 4.7000000000000002, "Mechanic", "Khánh Motor Service", "All" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "Role", "ShopName" },
                values: new object[] { "166 Nguyễn Văn Linh, Cẩm Lệ, Đà Nẵng", 16.074705999999999, 108.228442, "Dương Văn Bảo", "0907875977", 4.7999999999999998, "Mechanic", "Phong Motor Service" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "Role", "ShopName", "SpecialSkills" },
                values: new object[] { "184 Điện Biên Phủ, Sơn Trà, Đà Nẵng", 16.072825999999999, 108.227031, "Đặng Đình Em", "0901620795", 4.2999999999999998, "Mechanic", "Long Motor Service", "Engine" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "Role", "ShopName", "SpecialSkills" },
                values: new object[] { "83 Điện Biên Phủ, Hải Châu, Đà Nẵng", 16.065102, 108.22833300000001, "Huỳnh Công Phong", "0902435633", 4.7000000000000002, "Mechanic", "Khánh Motor Service", "Tires, Chain" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "Role", "ShopName" },
                values: new object[] { "125 Võ Nguyên Giáp, Ngũ Hành Sơn, Đà Nẵng", 16.057881999999999, 108.187048, "Đỗ Quốc Tâm", "0906567681", 4.0999999999999996, "Mechanic", "Phú Motor Service" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "Role", "ShopName", "SpecialSkills" },
                values: new object[] { "134 Xô Viết Nghệ Tĩnh, Thanh Khê, Đà Nẵng", 16.041969000000002, 108.192632, "Bùi Hữu Cường", "0901659822", 4.0999999999999996, "Mechanic", "Khánh Motor Service", "Tires, Chain" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "Role", "ShopName" },
                values: new object[] { "61 Xô Viết Nghệ Tĩnh, Liên Chiểu, Đà Nẵng", 16.042446000000002, 108.182249, "Lý Thu Phương Tâm", "0906728527", 4.7999999999999998, "Mechanic", "An Motor Service" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "Role", "ShopName", "SpecialSkills" },
                values: new object[] { "23 Phạm Văn Đồng, Sơn Trà, Đà Nẵng", 16.056607, 108.23739, "Phạm Thị Long", "0902656516", 4.4000000000000004, "Mechanic", "An Motor Service", "Tires" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "Role", "ShopName", "SpecialSkills" },
                values: new object[] { "48 Hùng Vương, Cẩm Lệ, Đà Nẵng", 16.077292, 108.218667, "Phạm Hữu Phong", "0902375877", 4.5999999999999996, "Mechanic", "Tâm Motor Service", "Battery, Engine" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "Role", "ShopName", "SpecialSkills" },
                values: new object[] { "78 Nguyễn Văn Linh, Thanh Khê, Đà Nẵng", 16.067958999999998, 108.213646, "Phạm Bích Nam", "0901179426", 4.2999999999999998, "Mechanic", "Phát Motor Service", "Chain, Tires" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "Role", "ShopName", "SpecialSkills" },
                values: new object[] { "60 Nguyễn Văn Linh, Thanh Khê, Đà Nẵng", 16.043433, 108.21571400000001, "Lê Ngọc Hùng", "0903027034", 4.0999999999999996, "Mechanic", "An Motor Service", "Tires, Chain" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "Role", "ShopName", "SpecialSkills" },
                values: new object[] { "110 Điện Biên Phủ, Hải Châu, Đà Nẵng", 16.065874999999998, 108.21199300000001, "Bùi Quang Minh", "0902086631", 4.4000000000000004, "Mechanic", "Minh Motor Service", "Tires" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "Role", "ShopName", "SpecialSkills" },
                values: new object[] { "124 Hùng Vương, Ngũ Hành Sơn, Đà Nẵng", 16.067799999999998, 108.22889499999999, "Đặng Bích Phong", "0904480863", 4.2000000000000002, "Mechanic", "An Motor Service", "Chain, Tires" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "Role", "ShopName", "SpecialSkills" },
                values: new object[] { "110 Võ Nguyên Giáp, Hải Châu, Đà Nẵng", 16.059985999999999, 108.233859, "Lê Văn Long", "0901780257", 4.5, "Mechanic", "An Motor Service", "Tires, Chain" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "Role", "ShopName", "SpecialSkills" },
                values: new object[] { "177 Phạm Văn Đồng, Sơn Trà, Đà Nẵng", 16.051333, 108.23492299999999, "Lý Thu Phương Phú", "0908052777", 4.5, "Mechanic", "Nam Motor Service", "Tires, Chain" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "Role", "ShopName", "SpecialSkills" },
                values: new object[] { "167 Trần Phú, Thanh Khê, Đà Nẵng", 16.068887, 108.199265, "Dương Đức Nam", "0903054708", 4.0, "Mechanic", "Phong Motor Service", "Tires, Chain" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "Role", "ShopName", "SpecialSkills" },
                values: new object[] { "5 Nguyễn Văn Linh, Liên Chiểu, Đà Nẵng", 16.040619, 108.224721, "Hồ Hữu Tâm", "0903023226", 4.0, "Mechanic", "Tâm Motor Service", "Start" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "Role", "ShopName" },
                values: new object[] { "14 Phạm Văn Đồng, Liên Chiểu, Đà Nẵng", 16.044208999999999, 108.19070000000001, "Huỳnh Quốc Khánh", "0903331732", 4.9000000000000004, "Mechanic", "An Motor Service" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "Role", "ShopName", "SpecialSkills" },
                values: new object[] { "14 Phạm Văn Đồng, Ngũ Hành Sơn, Đà Nẵng", 16.039021000000002, 108.22176, "Võ Văn Giang", "0908418042", 4.5999999999999996, "Mechanic", "Hùng Motor Service", "Chain, Tires" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "Role", "ShopName", "SpecialSkills" },
                values: new object[] { "1 Võ Nguyên Giáp, Ngũ Hành Sơn, Đà Nẵng", 16.067371000000001, 108.225207, "Bùi Đức Tâm", "0907155005", 4.0999999999999996, "Mechanic", "Tâm Motor Service", "Battery" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "Role", "ShopName", "SpecialSkills" },
                values: new object[] { "35 Phạm Văn Đồng, Hải Châu, Đà Nẵng", 16.077842, 108.207883, "Bùi Ngọc Phú", "0909112165", 4.7999999999999998, "Mechanic", "Minh Motor Service", "All" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "Role", "ShopName", "SpecialSkills" },
                values: new object[] { "77 Nguyễn Tri Phương, Sơn Trà, Đà Nẵng", 16.063880000000001, 108.18901200000001, "Phạm Công Phú", "0901294561", 4.7000000000000002, "Mechanic", "Dũng Motor Service", "Start" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Role", "ShopName" },
                values: new object[] { "54 Hùng Vương, Thanh Khê, Đà Nẵng", 16.056736000000001, 108.227389, "Trần Ngọc Phát", "0906373719", "Mechanic", "Nam Motor Service" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "Role", "ShopName", "SpecialSkills" },
                values: new object[] { "155 Hùng Vương, Thanh Khê, Đà Nẵng", 16.067795, 108.213497, "Đặng Công Khánh", "0906015648", 4.9000000000000004, "Mechanic", "An Motor Service", "Tires" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "Role", "ShopName" },
                values: new object[] { "195 Nguyễn Tri Phương, Sơn Trà, Đà Nẵng", 16.064568999999999, 108.183446, "Đặng Quốc Nam", "0901499039", 4.0, "Mechanic", "Bảo Motor Service" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "Role", "ShopName", "SpecialSkills" },
                values: new object[] { "4 Lê Duẩn, Cẩm Lệ, Đà Nẵng", 16.079637000000002, 108.236773, "Phạm Minh Tùng", "0907359152", 4.5999999999999996, "Mechanic", "Phú Motor Service", "All" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "Role", "ShopName", "SpecialSkills" },
                values: new object[] { "97 Lê Duẩn, Liên Chiểu, Đà Nẵng", 16.051197999999999, 108.202752, "Trần Thanh Long", "0906340362", 5.0, "Mechanic", "Phát Motor Service", "Tires, Chain" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "Role", "ShopName", "SpecialSkills" },
                values: new object[] { "77 Hùng Vương, Liên Chiểu, Đà Nẵng", 16.077242999999999, 108.239994, "Hồ Công Long", "0902193307", 4.0, "Mechanic", "Khánh Motor Service", "All" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "Role", "ShopName", "SpecialSkills" },
                values: new object[] { "40 Hùng Vương, Thanh Khê, Đà Nẵng", 16.077912999999999, 108.18360699999999, "Nguyễn Minh Bảo", "0901467109", 4.0999999999999996, "Mechanic", "Phú Motor Service", "Tires, Chain" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "Role", "ShopName", "SpecialSkills" },
                values: new object[] { "19 Hoàng Diệu, Cẩm Lệ, Đà Nẵng", 16.04917, 108.22680699999999, "Phạm Minh Minh", "0903328041", 4.5999999999999996, "Mechanic", "Phát Motor Service", "Tires, Chain" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "Role", "ShopName", "SpecialSkills" },
                values: new object[] { "106 Hùng Vương, Thanh Khê, Đà Nẵng", 16.052149, 108.184136, "Bùi Quốc Em", "0902719388", 4.7999999999999998, "Mechanic", "Bảo Motor Service", "Tires, Chain" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "Role", "ShopName", "SpecialSkills" },
                values: new object[] { "108 Phạm Văn Đồng, Hải Châu, Đà Nẵng", 16.038305000000001, 108.197221, "Lý Đức Phát", "0905337574", 4.2999999999999998, "Mechanic", "Cường Motor Service", "Battery" });

            migrationBuilder.InsertData(
                table: "Mechanics",
                columns: new[] { "Id", "Address", "IsAvailable", "Latitude", "Longitude", "Name", "Phone", "Rating", "Role", "ShopName", "SpecialSkills" },
                values: new object[,]
                {
                    { 51, "123 Điện Biên Phủ, Hải Châu, Đà Nẵng", true, 16.059414, 108.20502500000001, "Võ Quốc Phát", "0919163765", 4.9000000000000004, "CommunityHelper", "Người hỗ trợ cộng đồng", "" },
                    { 52, "132 Nguyễn Văn Linh, Cẩm Lệ, Đà Nẵng", true, 16.073778999999998, 108.23536900000001, "Ngô Đình Em", "0918373554", 4.5, "CommunityHelper", "Người hỗ trợ cộng đồng", "" },
                    { 53, "67 Nguyễn Văn Linh, Thanh Khê, Đà Nẵng", true, 16.057155000000002, 108.232353, "Nguyễn Bích Phát", "0915945527", 4.7000000000000002, "CommunityHelper", "Người hỗ trợ cộng đồng", "" },
                    { 54, "176 Trần Phú, Liên Chiểu, Đà Nẵng", true, 16.057230000000001, 108.23022, "Vũ Quốc Hùng", "0912281734", 4.2999999999999998, "CommunityHelper", "Người hỗ trợ cộng đồng", "" },
                    { 55, "158 Điện Biên Phủ, Sơn Trà, Đà Nẵng", true, 16.057365999999998, 108.19178100000001, "Đặng Thu Phương Nam", "0914267295", 4.7000000000000002, "CommunityHelper", "Người hỗ trợ cộng đồng", "" },
                    { 56, "125 Phạm Văn Đồng, Sơn Trà, Đà Nẵng", true, 16.053754999999999, 108.21426700000001, "Phan Bích An", "0911971754", 4.4000000000000004, "CommunityHelper", "Người hỗ trợ cộng đồng", "" },
                    { 57, "95 Bạch Đằng, Hải Châu, Đà Nẵng", true, 16.064686999999999, 108.190511, "Phạm Ngọc Phong", "0914582901", 4.5, "CommunityHelper", "Người hỗ trợ cộng đồng", "" },
                    { 58, "100 Võ Nguyên Giáp, Hải Châu, Đà Nẵng", true, 16.054480000000002, 108.235135, "Dương Văn Khánh", "0914733916", 4.5, "CommunityHelper", "Người hỗ trợ cộng đồng", "" },
                    { 59, "194 Hoàng Diệu, Ngũ Hành Sơn, Đà Nẵng", true, 16.050746, 108.19506800000001, "Lê Hữu Khánh", "0919007596", 4.0, "CommunityHelper", "Người hỗ trợ cộng đồng", "" },
                    { 60, "72 Hoàng Diệu, Thanh Khê, Đà Nẵng", true, 16.078218, 108.18853300000001, "Bùi Quốc Phong", "0912296885", 4.5999999999999996, "CommunityHelper", "Người hỗ trợ cộng đồng", "" },
                    { 61, "42 Hoàng Diệu, Sơn Trà, Đà Nẵng", true, 16.069638000000001, 108.20648199999999, "Nguyễn Thu Phương Cường", "0915358134", 4.5, "CommunityHelper", "Người hỗ trợ cộng đồng", "" },
                    { 62, "192 Hùng Vương, Hải Châu, Đà Nẵng", true, 16.037642000000002, 108.237258, "Trần Minh Giang", "0918769038", 5.0, "CommunityHelper", "Người hỗ trợ cộng đồng", "" },
                    { 63, "47 Nguyễn Văn Linh, Liên Chiểu, Đà Nẵng", true, 16.054141000000001, 108.220573, "Ngô Minh Phú", "0919894813", 4.2999999999999998, "CommunityHelper", "Người hỗ trợ cộng đồng", "" },
                    { 64, "108 Lê Duẩn, Hải Châu, Đà Nẵng", true, 16.070193, 108.213204, "Đỗ Đình Cường", "0913662533", 4.2999999999999998, "CommunityHelper", "Người hỗ trợ cộng đồng", "" },
                    { 65, "183 Xô Viết Nghệ Tĩnh, Thanh Khê, Đà Nẵng", true, 16.070070000000001, 108.22863, "Phan Thu Phương Nam", "0915900168", 4.7000000000000002, "CommunityHelper", "Người hỗ trợ cộng đồng", "" },
                    { 66, "30 Võ Nguyên Giáp, Sơn Trà, Đà Nẵng", true, 16.036237, 108.225917, "Lê Ngọc Phát", "0919742510", 4.9000000000000004, "CommunityHelper", "Người hỗ trợ cộng đồng", "" },
                    { 67, "122 Bạch Đằng, Sơn Trà, Đà Nẵng", true, 16.043025, 108.180026, "Phạm Thanh Tâm", "0913349723", 4.5, "CommunityHelper", "Người hỗ trợ cộng đồng", "" },
                    { 68, "73 Võ Nguyên Giáp, Thanh Khê, Đà Nẵng", true, 16.050298000000002, 108.203655, "Lê Quốc Cường", "0912058147", 4.7999999999999998, "CommunityHelper", "Người hỗ trợ cộng đồng", "" },
                    { 69, "34 Nguyễn Văn Linh, Liên Chiểu, Đà Nẵng", true, 16.075147000000001, 108.181404, "Bùi Thị Phong", "0911350904", 5.0, "CommunityHelper", "Người hỗ trợ cộng đồng", "" },
                    { 70, "99 Hoàng Diệu, Hải Châu, Đà Nẵng", true, 16.064651999999999, 108.218411, "Phạm Công Tâm", "0912002558", 4.9000000000000004, "CommunityHelper", "Người hỗ trợ cộng đồng", "" },
                    { 71, "169 Hoàng Diệu, Hải Châu, Đà Nẵng", true, 16.051475, 108.233063, "Lê Văn Minh", "0912432341", 4.4000000000000004, "CommunityHelper", "Người hỗ trợ cộng đồng", "" },
                    { 72, "191 Võ Nguyên Giáp, Hải Châu, Đà Nẵng", true, 16.061025999999998, 108.19619, "Lý Văn Tâm", "0919272279", 4.2999999999999998, "CommunityHelper", "Người hỗ trợ cộng đồng", "" },
                    { 73, "90 Trần Phú, Hải Châu, Đà Nẵng", true, 16.058257999999999, 108.183408, "Phan Thị Dũng", "0918967108", 4.0999999999999996, "CommunityHelper", "Người hỗ trợ cộng đồng", "" },
                    { 74, "136 Hoàng Diệu, Thanh Khê, Đà Nẵng", true, 16.062428000000001, 108.20669599999999, "Trần Đình Phong", "0912512763", 4.5, "CommunityHelper", "Người hỗ trợ cộng đồng", "" },
                    { 75, "80 Lê Duẩn, Hải Châu, Đà Nẵng", true, 16.073847000000001, 108.222731, "Nguyễn Quang Em", "0919203900", 4.5999999999999996, "CommunityHelper", "Người hỗ trợ cộng đồng", "" },
                    { 76, "72 Hoàng Diệu, Cẩm Lệ, Đà Nẵng", true, 16.051165000000001, 108.18458, "Bùi Thanh Minh", "0917462271", 4.9000000000000004, "CommunityHelper", "Người hỗ trợ cộng đồng", "" },
                    { 77, "156 Trần Phú, Thanh Khê, Đà Nẵng", true, 16.055077000000001, 108.234461, "Ngô Ngọc Tùng", "0918116649", 4.2999999999999998, "CommunityHelper", "Người hỗ trợ cộng đồng", "" },
                    { 78, "28 Hùng Vương, Ngũ Hành Sơn, Đà Nẵng", true, 16.071334, 108.206491, "Lý Thanh Phát", "0914221696", 4.7999999999999998, "CommunityHelper", "Người hỗ trợ cộng đồng", "" },
                    { 79, "156 Võ Nguyên Giáp, Hải Châu, Đà Nẵng", true, 16.042770999999998, 108.180347, "Vũ Quốc Nam", "0916588046", 4.2000000000000002, "CommunityHelper", "Người hỗ trợ cộng đồng", "" },
                    { 80, "129 Hùng Vương, Cẩm Lệ, Đà Nẵng", true, 16.044336000000001, 108.198497, "Trần Hữu Dũng", "0913599782", 4.4000000000000004, "CommunityHelper", "Người hỗ trợ cộng đồng", "" },
                    { 81, "12 Điện Biên Phủ, Cẩm Lệ, Đà Nẵng", true, 16.059438, 108.22289499999999, "Hoàng Văn Phong", "0917054828", 4.5999999999999996, "CommunityHelper", "Người hỗ trợ cộng đồng", "" },
                    { 82, "87 Hùng Vương, Sơn Trà, Đà Nẵng", true, 16.055972000000001, 108.190065, "Huỳnh Bích Dũng", "0912854055", 4.4000000000000004, "CommunityHelper", "Người hỗ trợ cộng đồng", "" },
                    { 83, "11 Trần Phú, Cẩm Lệ, Đà Nẵng", true, 16.074818, 108.19972, "Nguyễn Thành Tâm", "0911756616", 4.2000000000000002, "CommunityHelper", "Người hỗ trợ cộng đồng", "" },
                    { 84, "119 Hoàng Diệu, Liên Chiểu, Đà Nẵng", true, 16.073687, 108.23871, "Đặng Thành Long", "0919950124", 4.7000000000000002, "CommunityHelper", "Người hỗ trợ cộng đồng", "" },
                    { 85, "180 Phạm Văn Đồng, Thanh Khê, Đà Nẵng", true, 16.036111999999999, 108.229878, "Hồ Hữu Tâm", "0911758945", 4.2999999999999998, "CommunityHelper", "Người hỗ trợ cộng đồng", "" },
                    { 86, "21 Điện Biên Phủ, Ngũ Hành Sơn, Đà Nẵng", true, 16.047615, 108.237532, "Hồ Đình Giang", "0911528625", 4.2999999999999998, "CommunityHelper", "Người hỗ trợ cộng đồng", "" },
                    { 87, "91 Bạch Đằng, Liên Chiểu, Đà Nẵng", true, 16.048976, 108.216607, "Đặng Thu Phương Khánh", "0916479534", 4.7000000000000002, "CommunityHelper", "Người hỗ trợ cộng đồng", "" },
                    { 88, "49 Lê Duẩn, Sơn Trà, Đà Nẵng", true, 16.077362000000001, 108.222936, "Vũ Thu Phương An", "0919649882", 4.2999999999999998, "CommunityHelper", "Người hỗ trợ cộng đồng", "" },
                    { 89, "102 Trần Phú, Ngũ Hành Sơn, Đà Nẵng", true, 16.067140999999999, 108.199051, "Ngô Ngọc Cường", "0917718885", 4.0, "CommunityHelper", "Người hỗ trợ cộng đồng", "" },
                    { 90, "160 Trần Phú, Ngũ Hành Sơn, Đà Nẵng", true, 16.058098000000001, 108.227228, "Lý Thành Minh", "0914935229", 4.0999999999999996, "CommunityHelper", "Người hỗ trợ cộng đồng", "" },
                    { 91, "25 Lê Duẩn, Thanh Khê, Đà Nẵng", true, 16.045145999999999, 108.23985399999999, "Hoàng Thanh Phát", "0915909051", 4.2000000000000002, "CommunityHelper", "Người hỗ trợ cộng đồng", "" },
                    { 92, "179 Nguyễn Tri Phương, Hải Châu, Đà Nẵng", true, 16.052862000000001, 108.19986299999999, "Dương Công Phát", "0915906856", 4.7999999999999998, "CommunityHelper", "Người hỗ trợ cộng đồng", "" },
                    { 93, "149 Hoàng Diệu, Ngũ Hành Sơn, Đà Nẵng", true, 16.063476999999999, 108.188294, "Trần Minh Cường", "0916495523", 4.7999999999999998, "CommunityHelper", "Người hỗ trợ cộng đồng", "" },
                    { 94, "75 Lê Duẩn, Liên Chiểu, Đà Nẵng", true, 16.037096999999999, 108.22495600000001, "Dương Quang Khánh", "0914185230", 4.7000000000000002, "CommunityHelper", "Người hỗ trợ cộng đồng", "" },
                    { 95, "126 Bạch Đằng, Cẩm Lệ, Đà Nẵng", true, 16.069326, 108.222104, "Bùi Quang Tâm", "0911831883", 4.5999999999999996, "CommunityHelper", "Người hỗ trợ cộng đồng", "" },
                    { 96, "117 Điện Biên Phủ, Ngũ Hành Sơn, Đà Nẵng", true, 16.069091, 108.18358499999999, "Lê Ngọc Giang", "0916625078", 4.0999999999999996, "CommunityHelper", "Người hỗ trợ cộng đồng", "" },
                    { 97, "191 Trần Phú, Thanh Khê, Đà Nẵng", true, 16.073036999999999, 108.184416, "Huỳnh Bích Dũng", "0914365880", 4.5999999999999996, "CommunityHelper", "Người hỗ trợ cộng đồng", "" },
                    { 98, "20 Võ Nguyên Giáp, Hải Châu, Đà Nẵng", true, 16.069973000000001, 108.227374, "Lê Công Bảo", "0918781035", 4.0999999999999996, "CommunityHelper", "Người hỗ trợ cộng đồng", "" },
                    { 99, "56 Xô Viết Nghệ Tĩnh, Cẩm Lệ, Đà Nẵng", true, 16.035305999999999, 108.219342, "Dương Ngọc Phát", "0915371787", 4.7000000000000002, "CommunityHelper", "Người hỗ trợ cộng đồng", "" },
                    { 100, "41 Trần Phú, Hải Châu, Đà Nẵng", true, 16.058761000000001, 108.201759, "Lê Thị Tùng", "0912265461", 4.7999999999999998, "CommunityHelper", "Người hỗ trợ cộng đồng", "" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DropColumn(
                name: "Role",
                table: "Mechanics");

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "ShopName", "SpecialSkills" },
                values: new object[] { "12 Nguyễn Văn Linh, Hải Châu, Đà Nẵng", 16.059999999999999, 108.20999999999999, "Nguyễn Văn An", "0901000001", 4.7999999999999998, "An Motor Repair", "Engine, Tires" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "ShopName", "SpecialSkills" },
                values: new object[] { "45 Lê Duẩn, Hải Châu, Đà Nẵng", 16.068000000000001, 108.22, "Trần Văn Bình", "0901000002", 4.5, "Bình Quick Fix", "Battery, Start" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "ShopName" },
                values: new object[] { "78 Trần Phú, Hải Châu, Đà Nẵng", 16.055, 108.205, "Lê Thị Cẩm", "0901000003", 4.9000000000000004, "Cẩm Motor Service" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "ShopName", "SpecialSkills" },
                values: new object[] { "23 Hùng Vương, Hải Châu, Đà Nẵng", 16.062000000000001, 108.215, "Phạm Hữu Đức", "0901000004", "Đức Sửa Xe", "Tires, Chain" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "ShopName", "SpecialSkills" },
                values: new object[] { "56 Phan Châu Trinh, Hải Châu, Đà Nẵng", 16.07, 108.212, "Võ Minh Em", "0901000005", "Em Motor", "Engine" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "ShopName" },
                values: new object[] { "89 Bạch Đằng, Hải Châu, Đà Nẵng", 16.058, 108.208, "Hoàng Văn Phú", "0901000006", 4.7000000000000002, "Phú Auto Fix" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "ShopName", "SpecialSkills" },
                values: new object[] { "34 Ông Ích Khiêm, Hải Châu, Đà Nẵng", 16.065000000000001, 108.203, "Đỗ Quang Giang", "0901000007", 4.2999999999999998, "Giang Bike Care", "Chain, Tires" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "ShopName", "SpecialSkills" },
                values: new object[] { "67 Núi Thành, Hải Châu, Đà Nẵng", 16.053000000000001, 108.218, "Ngô Thanh Hải", "0901000008", 4.4000000000000004, "Hải Motor Pro", "All" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "ShopName", "SpecialSkills" },
                values: new object[] { "12 Hoàng Diệu, Hải Châu, Đà Nẵng", 16.071999999999999, 108.206, "Bùi Văn Inh", "0901000009", 4.0999999999999996, "Inh Quick Repair", "Tires" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "ShopName", "SpecialSkills" },
                values: new object[] { "90 Điện Biên Phủ, Thanh Khê, Đà Nẵng", 16.065999999999999, 108.19799999999999, "Lý Minh Khang", "0901000010", 4.7999999999999998, "Khang Motor Shop", "Engine, Battery" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "ShopName", "SpecialSkills" },
                values: new object[] { "45 Hải Phòng, Thanh Khê, Đà Nẵng", 16.064, 108.2, "Trương Văn Long", "0901000011", 4.0, "Long Sửa Xe 24h", "Chain" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "ShopName", "SpecialSkills" },
                values: new object[] { "78 Đống Đa, Thanh Khê, Đà Nẵng", 16.059000000000001, 108.196, "Đinh Quốc Minh", "0901000012", 4.5, "Minh Auto Care", "All" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "ShopName", "SpecialSkills" },
                values: new object[] { "23 Trần Cao Vân, Thanh Khê, Đà Nẵng", 16.071000000000002, 108.202, "Phan Hồng Nam", "0901000013", 4.5999999999999996, "Nam Bike Repair", "Engine, Tires" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "ShopName", "SpecialSkills" },
                values: new object[] { "56 Lê Thanh Nghị, Hải Châu, Đà Nẵng", 16.053999999999998, 108.214, "Mai Xuân Oanh", "0901000014", 4.2999999999999998, "Oanh Motor Fix", "Battery" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "ShopName", "SpecialSkills" },
                values: new object[] { "89 Nguyễn Tri Phương, Thanh Khê, Đà Nẵng", 16.067, 108.20399999999999, "Cao Văn Phong", "0901000015", "Phong Express Repair", "Tires, Chain" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "ShopName", "SpecialSkills" },
                values: new object[] { "12 Lê Đình Lý, Hải Châu, Đà Nẵng", 16.061, 108.21599999999999, "Hồ Quang Quý", "0901000016", 4.2000000000000002, "Quý Bike Pro", "Engine" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "ShopName", "SpecialSkills" },
                values: new object[] { "34 Nguyễn Hữu Thọ, Hải Châu, Đà Nẵng", 16.048999999999999, 108.211, "Đặng Văn Rạng", "0901000017", 4.9000000000000004, "Rạng Motor Service", "All" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "ShopName", "SpecialSkills" },
                values: new object[] { "67 Xô Viết Nghệ Tĩnh, Hải Châu, Đà Nẵng", 16.056999999999999, 108.209, "Vũ Đình Sơn", "0901000018", 4.4000000000000004, "Sơn Speed Fix", "Battery, Tires" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "ShopName", "SpecialSkills" },
                values: new object[] { "90 Trưng Nữ Vương, Hải Châu, Đà Nẵng", 16.062999999999999, 108.20699999999999, "Lê Văn Tâm", "0901000019", 4.5999999999999996, "Tâm Motor 365", "Chain, Engine" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "ShopName" },
                values: new object[] { "23 Yên Bái, Hải Châu, Đà Nẵng", 16.068999999999999, 108.21299999999999, "Nguyễn Hữu Uy", "0901000020", 4.0999999999999996, "Uy Sửa Xe Nhanh" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "ShopName", "SpecialSkills" },
                values: new object[] { "56 Thái Phiên, Hải Châu, Đà Nẵng", 16.052, 108.21899999999999, "Trần Minh Vượng", "0901000021", 4.7999999999999998, "Vượng Auto", "All" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "ShopName", "SpecialSkills" },
                values: new object[] { "78 Pasteur, Hải Châu, Đà Nẵng", 16.074000000000002, 108.205, "Phạm Đức Xuyên", "0901000022", 4.2999999999999998, "Xuyên Motor Shop", "Engine, Battery" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "ShopName" },
                values: new object[] { "12 Lý Tự Trọng, Hải Châu, Đà Nẵng", 16.056000000000001, 108.20099999999999, "Võ Trung Yên", "0901000023", 4.5, "Yên Bike Fix" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "ShopName", "SpecialSkills" },
                values: new object[] { "34 Nguyễn Chí Thanh, Hải Châu, Đà Nẵng", 16.065000000000001, 108.217, "Hoàng Trọng Anh", "0901000024", 4.7000000000000002, "Anh Phát Motor", "Engine" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "ShopName" },
                values: new object[] { "67 Đỗ Quang, Ngũ Hành Sơn, Đà Nẵng", 16.050000000000001, 108.235, "Đỗ Ngọc Bảo", "0901000025", 4.2000000000000002, "Bảo Repair Center" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "ShopName", "SpecialSkills" },
                values: new object[] { "89 Lê Văn Hiến, Ngũ Hành Sơn, Đà Nẵng", 16.047999999999998, 108.23, "Ngô Hải Châu", "0901000026", 4.5999999999999996, "Châu Motor Express", "Battery" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "ShopName", "SpecialSkills" },
                values: new object[] { "12 Nguyễn Văn Thoại, Sơn Trà, Đà Nẵng", 16.076000000000001, 108.22799999999999, "Bùi Đình Duy", "0901000027", 4.4000000000000004, "Duy Bike Care 24h", "Tires" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "ShopName", "SpecialSkills" },
                values: new object[] { "45 Phạm Văn Đồng, Sơn Trà, Đà Nẵng", 16.073, 108.232, "Lý Văn Đạt", "0901000028", 4.7999999999999998, "Đạt Motor Pro", "Engine, Chain" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "ShopName", "SpecialSkills" },
                values: new object[] { "78 An Nhơn, Sơn Trà, Đà Nẵng", 16.077999999999999, 108.22499999999999, "Trương Quốc Gia", "0901000029", 4.0, "Gia Motor Service", "All" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "ShopName", "SpecialSkills" },
                values: new object[] { "23 Ngô Quyền, Sơn Trà, Đà Nẵng", 16.074999999999999, 108.221, "Đinh Hữu Hào", "0901000030", 4.5, "Hào Quick Fix", "Battery, Tires" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "ShopName", "SpecialSkills" },
                values: new object[] { "56 Trần Đại Nghĩa, Ngũ Hành Sơn, Đà Nẵng", 16.047000000000001, 108.226, "Phan Minh Khánh", "0901000031", 4.2999999999999998, "Khánh Sửa Xe", "Chain" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "ShopName", "SpecialSkills" },
                values: new object[] { "89 Mỹ An, Ngũ Hành Sơn, Đà Nẵng", 16.050999999999998, 108.238, "Mai Trọng Lâm", "0901000032", 4.7000000000000002, "Lâm Motor Fix", "Engine" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "ShopName", "SpecialSkills" },
                values: new object[] { "12 Võ Nguyên Giáp, Sơn Trà, Đà Nẵng", 16.068999999999999, 108.23999999999999, "Cao Quang Mạnh", "0901000033", 4.0999999999999996, "Mạnh Bike Pro", "Tires, Engine" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "ShopName", "SpecialSkills" },
                values: new object[] { "34 Trần Hưng Đạo, Sơn Trà, Đà Nẵng", 16.077000000000002, 108.215, "Hồ Đức Nghĩa", "0901000034", 4.9000000000000004, "Nghĩa Motor 24h", "All" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "ShopName", "SpecialSkills" },
                values: new object[] { "67 Nguyễn Công Trứ, Sơn Trà, Đà Nẵng", 16.079999999999998, 108.218, "Đặng Minh Phúc", "0901000035", 4.4000000000000004, "Phúc Auto Repair", "Battery, Chain" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "ShopName" },
                values: new object[] { "90 Nguyễn Lương Bằng, Liên Chiểu, Đà Nẵng", 16.082000000000001, 108.155, "Vũ Hồng Quân", "0901000036", 4.5999999999999996, "Quân Motor Express" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "ShopName", "SpecialSkills" },
                values: new object[] { "23 Tôn Đức Thắng, Liên Chiểu, Đà Nẵng", 16.085000000000001, 108.16, "Lê Quốc Sang", "0901000037", 4.2000000000000002, "Sang Bike Center", "Tires" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "ShopName", "SpecialSkills" },
                values: new object[] { "56 Hoàng Văn Thái, Liên Chiểu, Đà Nẵng", 16.077999999999999, 108.16500000000001, "Nguyễn Tấn Tài", "0901000038", 4.7999999999999998, "Tài Motor Shop", "All" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "ShopName", "SpecialSkills" },
                values: new object[] { "78 Nguyễn Sinh Sắc, Liên Chiểu, Đà Nẵng", 16.071999999999999, 108.17, "Trần Hữu Vĩnh", "0901000039", 4.2999999999999998, "Vĩnh Sửa Xe Pro", "Chain, Battery" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "ShopName", "SpecialSkills" },
                values: new object[] { "12 Nguyễn Tất Thành, Liên Chiểu, Đà Nẵng", 16.09, 108.15000000000001, "Phạm Quang Huy", "0901000040", 4.5, "Huy Motor Fix", "Engine, Tires" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "ShopName" },
                values: new object[] { "34 Cách Mạng T8, Cẩm Lệ, Đà Nẵng", 16.039999999999999, 108.20999999999999, "Võ Thanh Liêm", "0901000041", "Liêm Bike Service" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "ShopName", "SpecialSkills" },
                values: new object[] { "67 Âu Cơ, Cẩm Lệ, Đà Nẵng", 16.038, 108.205, "Hoàng Minh Đạo", "0901000042", 4.0, "Đạo Quick Repair", "Battery" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "ShopName" },
                values: new object[] { "89 Trường Chinh, Cẩm Lệ, Đà Nẵng", 16.035, 108.2, "Đỗ Văn Kiên", "0901000043", 4.5999999999999996, "Kiên Motor 365" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "ShopName", "SpecialSkills" },
                values: new object[] { "23 Tùng Thiện Vương, Cẩm Lệ, Đà Nẵng", 16.042000000000002, 108.215, "Ngô Đình Lộc", "0901000044", 4.4000000000000004, "Lộc Motor Care", "Engine" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "ShopName", "SpecialSkills" },
                values: new object[] { "56 Võ Văn Kiệt, Cẩm Lệ, Đà Nẵng", 16.036999999999999, 108.22, "Bùi Trọng Nhân", "0901000045", 4.7999999999999998, "Nhân Express Motor", "All" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "ShopName", "SpecialSkills" },
                values: new object[] { "78 Nguyễn Phước Lan, Cẩm Lệ, Đà Nẵng", 16.044, 108.22499999999999, "Lý Đình Phát", "0901000046", 4.0999999999999996, "Phát Bike Fix", "Battery, Engine" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "ShopName", "SpecialSkills" },
                values: new object[] { "12 Lê Trọng Tấn, Cẩm Lệ, Đà Nẵng", 16.045999999999999, 108.19499999999999, "Trương Văn Tín", "0901000047", 4.5, "Tín Sửa Xe 24h", "Tires" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "ShopName", "SpecialSkills" },
                values: new object[] { "34 Trần Đức Thảo, Hải Châu, Đà Nẵng", 16.058, 108.22199999999999, "Đinh Xuân Việt", "0901000048", 4.9000000000000004, "Việt Motor Pro", "All" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "ShopName", "SpecialSkills" },
                values: new object[] { "67 Nguyễn Du, Hải Châu, Đà Nẵng", 16.062000000000001, 108.199, "Phan Đức Anh", "0901000049", 4.2999999999999998, "Anh Tú Motor", "Chain" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "ShopName", "SpecialSkills" },
                values: new object[] { "90 Duy Tân, Hải Châu, Đà Nẵng", 16.053999999999998, 108.20399999999999, "Mai Hoàng Bách", "0901000050", 4.7000000000000002, "Bách Motor Center", "Engine, Tires, Battery" });
        }
    }
}
