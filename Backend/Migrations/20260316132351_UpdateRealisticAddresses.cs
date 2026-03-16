using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MotorSafe.Backend.Migrations
{
    /// <inheritdoc />
    public partial class UpdateRealisticAddresses : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "ShopName", "SpecialSkills" },
                values: new object[] { "187 Lê Văn Hiến, Ngũ Hành Sơn, Đà Nẵng", 16.032674, 108.251366, "Đỗ Hữu Bình", "0901094968", 4.0999999999999996, "Tùng Motor Service", "Tires" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "SpecialSkills" },
                values: new object[] { "164 Phạm Hùng, Cẩm Lệ, Đà Nẵng", 16.014289000000002, 108.185558, "Ngô Quang Em", "0903753177", 4.2999999999999998, "Chain, Tires" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "ShopName", "SpecialSkills" },
                values: new object[] { "65 Nguyễn Lương Bằng, Liên Chiểu, Đà Nẵng", 16.055076, 108.157409, "Đỗ Văn Bình", "0909133701", 4.5999999999999996, "Bình Motor Service", "Battery" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "ShopName", "SpecialSkills" },
                values: new object[] { "66 Nguyễn Tất Thành, Liên Chiểu, Đà Nẵng", 16.064655999999999, 108.126135, "Ngô Quốc Tùng", "0908427609", "Hùng Motor Service", "Tires, Chain" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "ShopName", "SpecialSkills" },
                values: new object[] { "175 Trần Đại Nghĩa, Ngũ Hành Sơn, Đà Nẵng", 16.019469000000001, 108.269553, "Dương Ngọc An", "0905625011", 4.4000000000000004, "Cường Motor Service", "All" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "ShopName", "SpecialSkills" },
                values: new object[] { "171 Lê Văn Hiến, Ngũ Hành Sơn, Đà Nẵng", 15.995485, 108.26107399999999, "Huỳnh Công Phú", "0909330987", "An Motor Service", "Chain, Tires" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "ShopName", "SpecialSkills" },
                values: new object[] { "55 Yết Kiêu, Sơn Trà, Đà Nẵng", 16.078365000000002, 108.243655, "Dương Công Nam", "0909708556", 4.2999999999999998, "Tâm Motor Service", "Tires, Chain" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "ShopName", "SpecialSkills" },
                values: new object[] { "102 Hồ Xuân Hương, Ngũ Hành Sơn, Đà Nẵng", 15.98132, 108.24027, "Lê Quang An", "0909350325", 4.5, "Nam Motor Service", "Battery" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "ShopName", "SpecialSkills" },
                values: new object[] { "118 Hoàng Văn Thái, Liên Chiểu, Đà Nẵng", 16.097102, 108.150327, "Lý Đức Tùng", "0908064446", 4.2999999999999998, "Long Motor Service", "Start" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "ShopName" },
                values: new object[] { "185 Nguyễn Sinh Sắc, Liên Chiểu, Đà Nẵng", 16.052676999999999, 108.13473399999999, "Phan Minh Dũng", "0902311858", 4.7999999999999998, "Tùng Motor Service" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "ShopName", "SpecialSkills" },
                values: new object[] { "42 Hoàng Diệu, Hải Châu, Đà Nẵng", 16.044757000000001, 108.225266, "Dương Thu Phương Cường", "0902465243", 4.0999999999999996, "Hùng Motor Service", "Engine" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "ShopName", "SpecialSkills" },
                values: new object[] { "129 Hoàng Văn Thái, Liên Chiểu, Đà Nẵng", 16.093934999999998, 108.17583399999999, "Võ Hữu Tâm", "0909815767", 4.7000000000000002, "Tùng Motor Service", "Tires" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "ShopName", "SpecialSkills" },
                values: new object[] { "200 Bạch Đằng, Hải Châu, Đà Nẵng", 16.061052, 108.220197, "Huỳnh Công Dũng", "0903581442", 4.4000000000000004, "Hùng Motor Service", "Battery, Engine" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "ShopName", "SpecialSkills" },
                values: new object[] { "150 Cách Mạng Tháng 8, Cẩm Lệ, Đà Nẵng", 16.003907000000002, 108.200835, "Lê Công Khánh", "0907278915", 4.9000000000000004, "Phong Motor Service", "Tires" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "ShopName", "SpecialSkills" },
                values: new object[] { "143 Nguyễn Văn Linh, Hải Châu, Đà Nẵng", 16.051421000000001, 108.211714, "Hoàng Đức Hùng", "0909549566", 4.7999999999999998, "Tùng Motor Service", "Start" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "ShopName", "SpecialSkills" },
                values: new object[] { "99 Lê Văn Hiến, Ngũ Hành Sơn, Đà Nẵng", 16.035858000000001, 108.258009, "Nguyễn Đình Phát", "0905090320", 4.2000000000000002, "Cường Motor Service", "Start" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "ShopName", "SpecialSkills" },
                values: new object[] { "52 Quang Trung, Hải Châu, Đà Nẵng", 16.044547999999999, 108.210386, "Đặng Thành Phú", "0905306637", 4.4000000000000004, "Phát Motor Service", "Tires" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "ShopName", "SpecialSkills" },
                values: new object[] { "65 Võ Kỳ Sơn, Ngũ Hành Sơn, Đà Nẵng", 16.018186, 108.269972, "Đặng Thanh Hùng", "0908330361", 4.7000000000000002, "Hùng Motor Service", "Tires, Chain" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "ShopName" },
                values: new object[] { "6 Nguyễn Sinh Sắc, Liên Chiểu, Đà Nẵng", 16.089822000000002, 108.12039300000001, "Hồ Văn Phú", "0906135658", 4.2999999999999998, "Giang Motor Service" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "ShopName", "SpecialSkills" },
                values: new object[] { "111 Nguyễn Tất Thành, Liên Chiểu, Đà Nẵng", 16.056066000000001, 108.158935, "Phạm Bích Phú", "0907857410", 4.4000000000000004, "Khánh Motor Service", "Battery" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "ShopName", "SpecialSkills" },
                values: new object[] { "56 Lê Văn Hiến, Ngũ Hành Sơn, Đà Nẵng", 15.994177000000001, 108.269577, "Huỳnh Công Tâm", "0901534688", 5.0, "Khánh Motor Service", "Tires" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "ShopName", "SpecialSkills" },
                values: new object[] { "127 Hoàng Văn Thái, Liên Chiểu, Đà Nẵng", 16.127310999999999, 108.154809, "Lê Minh An", "0905408422", 4.0999999999999996, "An Motor Service", "Battery, Engine" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "ShopName", "SpecialSkills" },
                values: new object[] { "93 Hồ Xuân Hương, Ngũ Hành Sơn, Đà Nẵng", 16.018554000000002, 108.27991, "Dương Bích Phát", "0907880774", 4.7000000000000002, "Phát Motor Service", "Tires" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "ShopName", "SpecialSkills" },
                values: new object[] { "24 Lê Văn Hiến, Ngũ Hành Sơn, Đà Nẵng", 16.004549000000001, 108.26917400000001, "Phạm Đình Cường", "0906428342", 5.0, "Phú Motor Service", "Battery, Engine" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "ShopName", "SpecialSkills" },
                values: new object[] { "41 Nguyễn Lương Bằng, Liên Chiểu, Đà Nẵng", 16.1191, 108.147094, "Phan Thu Phương Khánh", "0908990389", 4.7000000000000002, "Bình Motor Service", "Engine" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "ShopName", "SpecialSkills" },
                values: new object[] { "192 Ông Ích Khiêm, Hải Châu, Đà Nẵng", 16.036840999999999, 108.228837, "Đặng Văn Phú", "0901360526", 4.9000000000000004, "Minh Motor Service", "All" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "ShopName", "SpecialSkills" },
                values: new object[] { "165 Thái Thị Bôi, Thanh Khê, Đà Nẵng", 16.051984000000001, 108.17153999999999, "Vũ Minh Em", "0908448524", 4.4000000000000004, "Tùng Motor Service", "Start" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "ShopName", "SpecialSkills" },
                values: new object[] { "51 Trường Chinh, Cẩm Lệ, Đà Nẵng", 16.027452, 108.19891699999999, "Huỳnh Đình Giang", "0905493293", 4.0999999999999996, "Dũng Motor Service", "Battery" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "ShopName", "SpecialSkills" },
                values: new object[] { "152 Hoàng Văn Thái, Liên Chiểu, Đà Nẵng", 16.060217000000002, 108.15311, "Lý Bích Dũng", "0902505274", 4.5999999999999996, "Khánh Motor Service", "Tires" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "ShopName", "SpecialSkills" },
                values: new object[] { "200 Nguyễn Phước Lan, Cẩm Lệ, Đà Nẵng", 16.009004999999998, 108.21671600000001, "Võ Đình Bình", "0906003373", 4.7000000000000002, "Bình Motor Service", "Start" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "ShopName" },
                values: new object[] { "26 Trần Phú, Hải Châu, Đà Nẵng", 16.041357000000001, 108.22854700000001, "Huỳnh Đức Tâm", "0905787887", 4.5999999999999996, "Giang Motor Service" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "ShopName", "SpecialSkills" },
                values: new object[] { "116 Nguyễn Tất Thành, Liên Chiểu, Đà Nẵng", 16.114281999999999, 108.134911, "Dương Minh Tâm", "0907674430", "Tùng Motor Service", "Engine" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "ShopName", "SpecialSkills" },
                values: new object[] { "72 Hoàng Văn Thái, Liên Chiểu, Đà Nẵng", 16.055789000000001, 108.15496899999999, "Vũ Bích Tùng", "0906891992", 4.0999999999999996, "Bình Motor Service", "Battery" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "ShopName", "SpecialSkills" },
                values: new object[] { "174 Núi Thành, Hải Châu, Đà Nẵng", 16.066337999999998, 108.225855, "Huỳnh Thu Phương An", "0909864313", 4.2000000000000002, "Nam Motor Service", "Start" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "ShopName", "SpecialSkills" },
                values: new object[] { "174 Hồ Xuân Hương, Ngũ Hành Sơn, Đà Nẵng", 16.011171999999998, 108.272293, "Võ Đức Giang", "0906179432", 4.7999999999999998, "Hùng Motor Service", "Chain, Tires" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "ShopName" },
                values: new object[] { "69 Nguyễn Sinh Sắc, Liên Chiểu, Đà Nẵng", 16.108222000000001, 108.15203200000001, "Bùi Ngọc An", "0909626249", "Em Motor Service" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "SpecialSkills" },
                values: new object[] { "23 Lê Văn Hiến, Ngũ Hành Sơn, Đà Nẵng", 15.991007, 108.241895, "Võ Thị Minh", "0903659402", "Battery, Engine" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "ShopName", "SpecialSkills" },
                values: new object[] { "64 Tôn Đức Thắng, Liên Chiểu, Đà Nẵng", 16.105160000000001, 108.149263, "Vũ Quang Phong", "0901585302", 4.5, "Phát Motor Service", "Chain, Tires" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "ShopName", "SpecialSkills" },
                values: new object[] { "47 Nguyễn Lương Bằng, Liên Chiểu, Đà Nẵng", 16.073663, 108.14976900000001, "Đỗ Đức Tâm", "0905053133", 5.0, "Bình Motor Service", "Battery, Engine" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "ShopName", "SpecialSkills" },
                values: new object[] { "50 Võ Kỳ Sơn, Ngũ Hành Sơn, Đà Nẵng", 15.980093, 108.243303, "Phan Đức Phát", "0904852830", 4.4000000000000004, "Long Motor Service", "Battery, Engine" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "ShopName", "SpecialSkills" },
                values: new object[] { "63 Phạm Hùng, Cẩm Lệ, Đà Nẵng", 16.029228, 108.199907, "Ngô Bích Bình", "0908501318", 5.0, "Phong Motor Service", "Engine" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "ShopName", "SpecialSkills" },
                values: new object[] { "105 Lê Văn Hiến, Ngũ Hành Sơn, Đà Nẵng", 16.034458000000001, 108.232151, "Huỳnh Thành Tùng", "0903915232", 4.4000000000000004, "Tùng Motor Service", "Engine" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "ShopName", "SpecialSkills" },
                values: new object[] { "68 Nguyễn Công Trứ, Sơn Trà, Đà Nẵng", 16.066469999999999, 108.2236, "Huỳnh Bích Khánh", "0909982648", 4.0999999999999996, "Tâm Motor Service", "Battery" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "ShopName" },
                values: new object[] { "199 Quang Trung, Hải Châu, Đà Nẵng", 16.03932, 108.204238, "Phan Bích Phong", "0904985127", 4.7000000000000002, "Phong Motor Service" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "ShopName", "SpecialSkills" },
                values: new object[] { "9 Nguyễn Tất Thành, Liên Chiểu, Đà Nẵng", 16.062445, 108.162987, "Phan Quốc Phú", "0901219491", 4.0, "Tùng Motor Service", "Tires" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "SpecialSkills" },
                values: new object[] { "27 Quang Trung, Hải Châu, Đà Nẵng", 16.052001000000001, 108.223574, "Phạm Thanh Bình", "0903561878", 4.2000000000000002, "Tires, Chain" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "ShopName", "SpecialSkills" },
                values: new object[] { "47 Nguyễn Lương Bằng, Liên Chiểu, Đà Nẵng", 16.125973999999999, 108.154234, "Huỳnh Bích Tùng", "0909362342", 4.4000000000000004, "Tùng Motor Service", "Engine" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "ShopName" },
                values: new object[] { "56 Cách Mạng Tháng 8, Cẩm Lệ, Đà Nẵng", 16.002023999999999, 108.21756000000001, "Nguyễn Thanh Minh", "0902696032", 4.4000000000000004, "An Motor Service" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "ShopName", "SpecialSkills" },
                values: new object[] { "199 Phan Châu Trinh, Hải Châu, Đà Nẵng", 16.059090999999999, 108.225767, "Dương Minh An", "0904903212", 4.4000000000000004, "Hùng Motor Service", "All" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "ShopName", "SpecialSkills" },
                values: new object[] { "28 Nguyễn Công Trứ, Sơn Trà, Đà Nẵng", 16.112985999999999, 108.231661, "Đỗ Quốc Long", "0901840532", 5.0, "Giang Motor Service", "Battery, Engine" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating" },
                values: new object[] { "145 Ông Ích Đường, Cẩm Lệ, Đà Nẵng", 16.028908000000001, 108.203687, "Đặng Thị Tâm", "0911106910", 4.7999999999999998 });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating" },
                values: new object[] { "10 Hùng Vương, Hải Châu, Đà Nẵng", 16.069040000000001, 108.21366500000001, "Ngô Công Bình", "0916533587", 4.7999999999999998 });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating" },
                values: new object[] { "143 Phạm Hùng, Cẩm Lệ, Đà Nẵng", 16.03481, 108.193275, "Ngô Đình Giang", "0919948244", 4.2999999999999998 });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating" },
                values: new object[] { "52 Phạm Văn Đồng, Sơn Trà, Đà Nẵng", 16.048188, 108.22012100000001, "Ngô Minh Cường", "0916680580", 4.5 });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating" },
                values: new object[] { "21 Phạm Hùng, Cẩm Lệ, Đà Nẵng", 16.035534999999999, 108.189547, "Nguyễn Đình Nam", "0911678338", 4.0 });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating" },
                values: new object[] { "82 Nguyễn Tất Thành, Liên Chiểu, Đà Nẵng", 16.112162999999999, 108.173768, "Dương Thị Em", "0917194867", 4.5999999999999996 });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating" },
                values: new object[] { "21 Nguyễn Tất Thành, Liên Chiểu, Đà Nẵng", 16.113098999999998, 108.151112, "Nguyễn Quang Phát", "0919478952", 4.2999999999999998 });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating" },
                values: new object[] { "74 Hải Phòng, Thanh Khê, Đà Nẵng", 16.042921, 108.191585, "Lê Minh Giang", "0912174965", 4.7999999999999998 });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating" },
                values: new object[] { "44 Lê Duẩn, Hải Châu, Đà Nẵng", 16.036477000000001, 108.219425, "Võ Công Cường", "0911653972", 4.5 });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone" },
                values: new object[] { "31 Lê Văn Hiến, Ngũ Hành Sơn, Đà Nẵng", 16.045397000000001, 108.25018, "Hoàng Bích Em", "0911684008" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating" },
                values: new object[] { "65 Trường Chinh, Cẩm Lệ, Đà Nẵng", 16.000947, 108.209388, "Đặng Quốc Phú", "0911779864", 4.9000000000000004 });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating" },
                values: new object[] { "107 Điện Biên Phủ, Thanh Khê, Đà Nẵng", 16.047107, 108.173079, "Nguyễn Bích An", "0911791236", 4.5 });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone" },
                values: new object[] { "195 Phạm Văn Đồng, Sơn Trà, Đà Nẵng", 16.046676999999999, 108.243612, "Võ Minh An", "0917803048" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating" },
                values: new object[] { "167 Nguyễn Phước Lan, Cẩm Lệ, Đà Nẵng", 16.013133, 108.180877, "Trần Đức Phong", "0919001885", 4.4000000000000004 });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating" },
                values: new object[] { "24 Nguyễn Văn Thoại, Ngũ Hành Sơn, Đà Nẵng", 15.984411, 108.267475, "Vũ Minh Tâm", "0917556438", 4.4000000000000004 });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating" },
                values: new object[] { "50 Nguyễn Phước Lan, Cẩm Lệ, Đà Nẵng", 16.035575999999999, 108.185141, "Dương Đức Phú", "0911060201", 4.0999999999999996 });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating" },
                values: new object[] { "48 Võ Kỳ Sơn, Ngũ Hành Sơn, Đà Nẵng", 16.015868000000001, 108.231477, "Bùi Hữu Cường", "0918030779", 4.2000000000000002 });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating" },
                values: new object[] { "25 Nguyễn Sinh Sắc, Liên Chiểu, Đà Nẵng", 16.089531999999998, 108.14960600000001, "Huỳnh Thành Hùng", "0918966653", 4.2999999999999998 });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating" },
                values: new object[] { "28 Nguyễn Phước Lan, Cẩm Lệ, Đà Nẵng", 16.036221999999999, 108.193398, "Đỗ Đức Phú", "0918876228", 4.5999999999999996 });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating" },
                values: new object[] { "139 Cách Mạng Tháng 8, Cẩm Lệ, Đà Nẵng", 16.028075000000001, 108.205128, "Võ Thanh Hùng", "0911820633", 4.2000000000000002 });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating" },
                values: new object[] { "151 Ngô Quyền, Sơn Trà, Đà Nẵng", 16.084288000000001, 108.27173999999999, "Trần Ngọc An", "0915129871", 4.7999999999999998 });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating" },
                values: new object[] { "185 Trần Đại Nghĩa, Ngũ Hành Sơn, Đà Nẵng", 16.019307000000001, 108.25484, "Phan Minh Tùng", "0917411949", 4.5 });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating" },
                values: new object[] { "10 Ông Ích Đường, Cẩm Lệ, Đà Nẵng", 16.008610000000001, 108.18859500000001, "Nguyễn Văn Khánh", "0911013715", 4.2999999999999998 });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating" },
                values: new object[] { "186 Trường Chinh, Cẩm Lệ, Đà Nẵng", 16.025514999999999, 108.187558, "Trần Thị An", "0911638933", 4.7000000000000002 });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating" },
                values: new object[] { "73 Quang Trung, Hải Châu, Đà Nẵng", 16.055412, 108.20572900000001, "Huỳnh Quang Dũng", "0913114451", 4.2000000000000002 });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating" },
                values: new object[] { "151 Hoàng Văn Thái, Liên Chiểu, Đà Nẵng", 16.065804, 108.133859, "Đỗ Thị Phú", "0912620975", 4.0 });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating" },
                values: new object[] { "108 Nguyễn Sinh Sắc, Liên Chiểu, Đà Nẵng", 16.086282000000001, 108.120183, "Hồ Quốc Nam", "0918988512", 4.5999999999999996 });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating" },
                values: new object[] { "125 Trần Cao Vân, Thanh Khê, Đà Nẵng", 16.059028000000001, 108.174813, "Đặng Công Minh", "0914188333", 4.5999999999999996 });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating" },
                values: new object[] { "153 Nguyễn Tất Thành, Liên Chiểu, Đà Nẵng", 16.118486000000001, 108.12087099999999, "Nguyễn Thanh Cường", "0911442046", 4.7999999999999998 });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating" },
                values: new object[] { "106 Nguyễn Văn Thoại, Ngũ Hành Sơn, Đà Nẵng", 15.991367, 108.269921, "Ngô Thành Hùng", "0911500713", 4.9000000000000004 });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating" },
                values: new object[] { "151 Nguyễn Tri Phương, Thanh Khê, Đà Nẵng", 16.067221, 108.193054, "Phan Ngọc An", "0919320211", 4.7000000000000002 });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating" },
                values: new object[] { "70 Trường Chinh, Cẩm Lệ, Đà Nẵng", 16.009409000000002, 108.188119, "Dương Thành Nam", "0917573870", 4.7000000000000002 });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone" },
                values: new object[] { "171 Ông Ích Khiêm, Hải Châu, Đà Nẵng", 16.069873999999999, 108.21108700000001, "Hồ Thành Tùng", "0912019735" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating" },
                values: new object[] { "106 Bạch Đằng, Hải Châu, Đà Nẵng", 16.044397, 108.22108299999999, "Đặng Thu Phương Cường", "0918686556", 4.4000000000000004 });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating" },
                values: new object[] { "52 Nguyễn Lương Bằng, Liên Chiểu, Đà Nẵng", 16.060002000000001, 108.16986300000001, "Đỗ Hữu Tâm", "0912079198", 4.5999999999999996 });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating" },
                values: new object[] { "95 Tôn Đức Thắng, Liên Chiểu, Đà Nẵng", 16.093751999999999, 108.128536, "Bùi Quốc Long", "0917778396", 4.7999999999999998 });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating" },
                values: new object[] { "55 Hồ Xuân Hương, Ngũ Hành Sơn, Đà Nẵng", 16.030674000000001, 108.256383, "Phạm Minh Khánh", "0914976682", 4.5999999999999996 });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating" },
                values: new object[] { "183 Nguyễn Sinh Sắc, Liên Chiểu, Đà Nẵng", 16.114165, 108.153295, "Đỗ Thành Tùng", "0916243627", 4.4000000000000004 });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating" },
                values: new object[] { "36 Ngô Quyền, Sơn Trà, Đà Nẵng", 16.108827999999999, 108.28829399999999, "Phạm Thu Phương Phát", "0913337671", 4.7000000000000002 });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating" },
                values: new object[] { "89 Phạm Hùng, Cẩm Lệ, Đà Nẵng", 16.0121, 108.19916600000001, "Huỳnh Bích Khánh", "0918456728", 4.5999999999999996 });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating" },
                values: new object[] { "156 Nguyễn Phước Lan, Cẩm Lệ, Đà Nẵng", 16.005932000000001, 108.193878, "Trần Hữu Cường", "0916320492", 4.5999999999999996 });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating" },
                values: new object[] { "151 Cách Mạng Tháng 8, Cẩm Lệ, Đà Nẵng", 16.015283, 108.199878, "Đặng Quốc Giang", "0919317121", 4.4000000000000004 });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating" },
                values: new object[] { "191 Yết Kiêu, Sơn Trà, Đà Nẵng", 16.081333000000001, 108.255394, "Trần Hữu Giang", "0915528351", 4.5 });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating" },
                values: new object[] { "103 Trần Phú, Hải Châu, Đà Nẵng", 16.070554000000001, 108.20197400000001, "Hồ Thu Phương Long", "0912969769", 4.5999999999999996 });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating" },
                values: new object[] { "154 Phạm Hùng, Cẩm Lệ, Đà Nẵng", 16.009815, 108.19741, "Đỗ Thành Minh", "0917487889", 4.0 });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating" },
                values: new object[] { "20 Trần Đại Nghĩa, Ngũ Hành Sơn, Đà Nẵng", 15.984794000000001, 108.25191, "Bùi Quốc Phát", "0916311257", 4.7000000000000002 });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating" },
                values: new object[] { "161 Tôn Đức Thắng, Liên Chiểu, Đà Nẵng", 16.083137000000001, 108.152562, "Ngô Văn Phong", "0913231720", 4.0999999999999996 });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating" },
                values: new object[] { "154 Phan Châu Trinh, Hải Châu, Đà Nẵng", 16.057072999999999, 108.227728, "Trần Thu Phương An", "0912302431", 4.5999999999999996 });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating" },
                values: new object[] { "97 Nguyễn Sinh Sắc, Liên Chiểu, Đà Nẵng", 16.098796, 108.167351, "Huỳnh Quốc Phát", "0917837151", 4.0 });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating" },
                values: new object[] { "85 Đống Đa, Thanh Khê, Đà Nẵng", 16.063144999999999, 108.192519, "Vũ Ngọc Tùng", "0917087979", 4.5 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "ShopName", "SpecialSkills" },
                values: new object[] { "144 Bạch Đằng, Hải Châu, Đà Nẵng", 16.039693, 108.207701, "Trần Văn Hùng", "0902266383", 4.5999999999999996, "Dũng Motor Service", "Tires, Chain" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "SpecialSkills" },
                values: new object[] { "76 Lê Duẩn, Hải Châu, Đà Nẵng", 16.07141, 108.187268, "Dương Văn Cường", "0907010156", 4.5999999999999996, "Battery, Engine" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "ShopName", "SpecialSkills" },
                values: new object[] { "189 Nguyễn Tri Phương, Liên Chiểu, Đà Nẵng", 16.071504000000001, 108.195036, "Đặng Công Phong", "0901805365", 4.7000000000000002, "Phong Motor Service", "All" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "ShopName", "SpecialSkills" },
                values: new object[] { "137 Hoàng Diệu, Sơn Trà, Đà Nẵng", 16.035803000000001, 108.19898000000001, "Vũ Đình Minh", "0901081922", "Tâm Motor Service", "Chain, Tires" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "ShopName", "SpecialSkills" },
                values: new object[] { "195 Lê Duẩn, Ngũ Hành Sơn, Đà Nẵng", 16.0425, 108.21868499999999, "Lý Quốc Nam", "0906354693", 4.5999999999999996, "Giang Motor Service", "Battery" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "ShopName", "SpecialSkills" },
                values: new object[] { "27 Hùng Vương, Hải Châu, Đà Nẵng", 16.044758999999999, 108.236181, "Ngô Ngọc Nam", "0907535371", "Phú Motor Service", "Battery, Engine" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "ShopName", "SpecialSkills" },
                values: new object[] { "89 Hùng Vương, Sơn Trà, Đà Nẵng", 16.059097000000001, 108.198215, "Đặng Thu Phương Phú", "0904558472", 4.2000000000000002, "Hùng Motor Service", "Engine" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "ShopName", "SpecialSkills" },
                values: new object[] { "69 Phạm Văn Đồng, Thanh Khê, Đà Nẵng", 16.072583999999999, 108.182838, "Hồ Thành An", "0906325015", 4.9000000000000004, "Phát Motor Service", "Chain, Tires" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "ShopName", "SpecialSkills" },
                values: new object[] { "153 Hùng Vương, Thanh Khê, Đà Nẵng", 16.050722, 108.19533, "Trần Quang An", "0902252554", 4.7000000000000002, "Khánh Motor Service", "All" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "ShopName" },
                values: new object[] { "174 Phạm Văn Đồng, Liên Chiểu, Đà Nẵng", 16.040134999999999, 108.192561, "Đặng Công Khánh", "0902181530", 4.7000000000000002, "Phát Motor Service" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "ShopName", "SpecialSkills" },
                values: new object[] { "94 Trần Phú, Cẩm Lệ, Đà Nẵng", 16.075185999999999, 108.194344, "Hồ Quang Phú", "0907368463", 4.2999999999999998, "Giang Motor Service", "All" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "ShopName", "SpecialSkills" },
                values: new object[] { "40 Hùng Vương, Cẩm Lệ, Đà Nẵng", 16.058599000000001, 108.181062, "Hồ Hữu Khánh", "0906900481", 4.7999999999999998, "An Motor Service", "Engine" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "ShopName", "SpecialSkills" },
                values: new object[] { "41 Phạm Văn Đồng, Liên Chiểu, Đà Nẵng", 16.037997000000001, 108.201457, "Bùi Thu Phương Bảo", "0906362140", 4.7000000000000002, "Giang Motor Service", "Start" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "ShopName", "SpecialSkills" },
                values: new object[] { "200 Điện Biên Phủ, Hải Châu, Đà Nẵng", 16.079957, 108.208333, "Dương Văn Phú", "0906886917", 4.7000000000000002, "Em Motor Service", "Chain, Tires" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "ShopName", "SpecialSkills" },
                values: new object[] { "72 Hùng Vương, Cẩm Lệ, Đà Nẵng", 16.039353999999999, 108.229726, "Phạm Công Long", "0905527799", 4.7000000000000002, "An Motor Service", "Battery" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "ShopName", "SpecialSkills" },
                values: new object[] { "31 Nguyễn Văn Linh, Thanh Khê, Đà Nẵng", 16.057452000000001, 108.223732, "Đỗ Đức Khánh", "0904547342", 4.0999999999999996, "Giang Motor Service", "Battery, Engine" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "ShopName", "SpecialSkills" },
                values: new object[] { "31 Trần Phú, Ngũ Hành Sơn, Đà Nẵng", 16.068100000000001, 108.20604899999999, "Võ Bích Phú", "0903913619", 4.5, "Hùng Motor Service", "Engine" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "ShopName", "SpecialSkills" },
                values: new object[] { "137 Phạm Văn Đồng, Hải Châu, Đà Nẵng", 16.059002, 108.197163, "Bùi Thanh Nam", "0909675901", 4.2000000000000002, "Long Motor Service", "Battery, Engine" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "ShopName" },
                values: new object[] { "144 Nguyễn Văn Linh, Ngũ Hành Sơn, Đà Nẵng", 16.057421999999999, 108.238657, "Bùi Đình Cường", "0902676611", 4.7000000000000002, "Khánh Motor Service" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "ShopName", "SpecialSkills" },
                values: new object[] { "166 Nguyễn Văn Linh, Cẩm Lệ, Đà Nẵng", 16.074705999999999, 108.228442, "Dương Văn Bảo", "0907875977", 4.7999999999999998, "Phong Motor Service", "Tires" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "ShopName", "SpecialSkills" },
                values: new object[] { "184 Điện Biên Phủ, Sơn Trà, Đà Nẵng", 16.072825999999999, 108.227031, "Đặng Đình Em", "0901620795", 4.2999999999999998, "Long Motor Service", "Engine" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "ShopName", "SpecialSkills" },
                values: new object[] { "83 Điện Biên Phủ, Hải Châu, Đà Nẵng", 16.065102, 108.22833300000001, "Huỳnh Công Phong", "0902435633", 4.7000000000000002, "Khánh Motor Service", "Tires, Chain" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "ShopName", "SpecialSkills" },
                values: new object[] { "125 Võ Nguyên Giáp, Ngũ Hành Sơn, Đà Nẵng", 16.057881999999999, 108.187048, "Đỗ Quốc Tâm", "0906567681", 4.0999999999999996, "Phú Motor Service", "Tires, Chain" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "ShopName", "SpecialSkills" },
                values: new object[] { "134 Xô Viết Nghệ Tĩnh, Thanh Khê, Đà Nẵng", 16.041969000000002, 108.192632, "Bùi Hữu Cường", "0901659822", 4.0999999999999996, "Khánh Motor Service", "Tires, Chain" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "ShopName", "SpecialSkills" },
                values: new object[] { "61 Xô Viết Nghệ Tĩnh, Liên Chiểu, Đà Nẵng", 16.042446000000002, 108.182249, "Lý Thu Phương Tâm", "0906728527", 4.7999999999999998, "An Motor Service", "All" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "ShopName", "SpecialSkills" },
                values: new object[] { "23 Phạm Văn Đồng, Sơn Trà, Đà Nẵng", 16.056607, 108.23739, "Phạm Thị Long", "0902656516", 4.4000000000000004, "An Motor Service", "Tires" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "ShopName", "SpecialSkills" },
                values: new object[] { "48 Hùng Vương, Cẩm Lệ, Đà Nẵng", 16.077292, 108.218667, "Phạm Hữu Phong", "0902375877", 4.5999999999999996, "Tâm Motor Service", "Battery, Engine" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "ShopName", "SpecialSkills" },
                values: new object[] { "78 Nguyễn Văn Linh, Thanh Khê, Đà Nẵng", 16.067958999999998, 108.213646, "Phạm Bích Nam", "0901179426", 4.2999999999999998, "Phát Motor Service", "Chain, Tires" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "ShopName", "SpecialSkills" },
                values: new object[] { "60 Nguyễn Văn Linh, Thanh Khê, Đà Nẵng", 16.043433, 108.21571400000001, "Lê Ngọc Hùng", "0903027034", 4.0999999999999996, "An Motor Service", "Tires, Chain" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "ShopName", "SpecialSkills" },
                values: new object[] { "110 Điện Biên Phủ, Hải Châu, Đà Nẵng", 16.065874999999998, 108.21199300000001, "Bùi Quang Minh", "0902086631", 4.4000000000000004, "Minh Motor Service", "Tires" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "ShopName" },
                values: new object[] { "124 Hùng Vương, Ngũ Hành Sơn, Đà Nẵng", 16.067799999999998, 108.22889499999999, "Đặng Bích Phong", "0904480863", 4.2000000000000002, "An Motor Service" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "ShopName", "SpecialSkills" },
                values: new object[] { "110 Võ Nguyên Giáp, Hải Châu, Đà Nẵng", 16.059985999999999, 108.233859, "Lê Văn Long", "0901780257", "An Motor Service", "Tires, Chain" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "ShopName", "SpecialSkills" },
                values: new object[] { "177 Phạm Văn Đồng, Sơn Trà, Đà Nẵng", 16.051333, 108.23492299999999, "Lý Thu Phương Phú", "0908052777", 4.5, "Nam Motor Service", "Tires, Chain" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "ShopName", "SpecialSkills" },
                values: new object[] { "167 Trần Phú, Thanh Khê, Đà Nẵng", 16.068887, 108.199265, "Dương Đức Nam", "0903054708", 4.0, "Phong Motor Service", "Tires, Chain" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "ShopName", "SpecialSkills" },
                values: new object[] { "5 Nguyễn Văn Linh, Liên Chiểu, Đà Nẵng", 16.040619, 108.224721, "Hồ Hữu Tâm", "0903023226", 4.0, "Tâm Motor Service", "Start" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "ShopName" },
                values: new object[] { "14 Phạm Văn Đồng, Liên Chiểu, Đà Nẵng", 16.044208999999999, 108.19070000000001, "Huỳnh Quốc Khánh", "0903331732", "An Motor Service" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "SpecialSkills" },
                values: new object[] { "14 Phạm Văn Đồng, Ngũ Hành Sơn, Đà Nẵng", 16.039021000000002, 108.22176, "Võ Văn Giang", "0908418042", "Chain, Tires" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "ShopName", "SpecialSkills" },
                values: new object[] { "1 Võ Nguyên Giáp, Ngũ Hành Sơn, Đà Nẵng", 16.067371000000001, 108.225207, "Bùi Đức Tâm", "0907155005", 4.0999999999999996, "Tâm Motor Service", "Battery" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "ShopName", "SpecialSkills" },
                values: new object[] { "35 Phạm Văn Đồng, Hải Châu, Đà Nẵng", 16.077842, 108.207883, "Bùi Ngọc Phú", "0909112165", 4.7999999999999998, "Minh Motor Service", "All" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "ShopName", "SpecialSkills" },
                values: new object[] { "77 Nguyễn Tri Phương, Sơn Trà, Đà Nẵng", 16.063880000000001, 108.18901200000001, "Phạm Công Phú", "0901294561", 4.7000000000000002, "Dũng Motor Service", "Start" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "ShopName", "SpecialSkills" },
                values: new object[] { "54 Hùng Vương, Thanh Khê, Đà Nẵng", 16.056736000000001, 108.227389, "Trần Ngọc Phát", "0906373719", 4.7000000000000002, "Nam Motor Service", "All" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "ShopName", "SpecialSkills" },
                values: new object[] { "155 Hùng Vương, Thanh Khê, Đà Nẵng", 16.067795, 108.213497, "Đặng Công Khánh", "0906015648", 4.9000000000000004, "An Motor Service", "Tires" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "ShopName", "SpecialSkills" },
                values: new object[] { "195 Nguyễn Tri Phương, Sơn Trà, Đà Nẵng", 16.064568999999999, 108.183446, "Đặng Quốc Nam", "0901499039", 4.0, "Bảo Motor Service", "Tires, Chain" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "ShopName" },
                values: new object[] { "4 Lê Duẩn, Cẩm Lệ, Đà Nẵng", 16.079637000000002, 108.236773, "Phạm Minh Tùng", "0907359152", 4.5999999999999996, "Phú Motor Service" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "ShopName", "SpecialSkills" },
                values: new object[] { "97 Lê Duẩn, Liên Chiểu, Đà Nẵng", 16.051197999999999, 108.202752, "Trần Thanh Long", "0906340362", 5.0, "Phát Motor Service", "Tires, Chain" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "SpecialSkills" },
                values: new object[] { "77 Hùng Vương, Liên Chiểu, Đà Nẵng", 16.077242999999999, 108.239994, "Hồ Công Long", "0902193307", 4.0, "All" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "ShopName", "SpecialSkills" },
                values: new object[] { "40 Hùng Vương, Thanh Khê, Đà Nẵng", 16.077912999999999, 108.18360699999999, "Nguyễn Minh Bảo", "0901467109", 4.0999999999999996, "Phú Motor Service", "Tires, Chain" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "ShopName" },
                values: new object[] { "19 Hoàng Diệu, Cẩm Lệ, Đà Nẵng", 16.04917, 108.22680699999999, "Phạm Minh Minh", "0903328041", 4.5999999999999996, "Phát Motor Service" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "ShopName", "SpecialSkills" },
                values: new object[] { "106 Hùng Vương, Thanh Khê, Đà Nẵng", 16.052149, 108.184136, "Bùi Quốc Em", "0902719388", 4.7999999999999998, "Bảo Motor Service", "Tires, Chain" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating", "ShopName", "SpecialSkills" },
                values: new object[] { "108 Phạm Văn Đồng, Hải Châu, Đà Nẵng", 16.038305000000001, 108.197221, "Lý Đức Phát", "0905337574", 4.2999999999999998, "Cường Motor Service", "Battery" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating" },
                values: new object[] { "123 Điện Biên Phủ, Hải Châu, Đà Nẵng", 16.059414, 108.20502500000001, "Võ Quốc Phát", "0919163765", 4.9000000000000004 });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating" },
                values: new object[] { "132 Nguyễn Văn Linh, Cẩm Lệ, Đà Nẵng", 16.073778999999998, 108.23536900000001, "Ngô Đình Em", "0918373554", 4.5 });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating" },
                values: new object[] { "67 Nguyễn Văn Linh, Thanh Khê, Đà Nẵng", 16.057155000000002, 108.232353, "Nguyễn Bích Phát", "0915945527", 4.7000000000000002 });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating" },
                values: new object[] { "176 Trần Phú, Liên Chiểu, Đà Nẵng", 16.057230000000001, 108.23022, "Vũ Quốc Hùng", "0912281734", 4.2999999999999998 });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating" },
                values: new object[] { "158 Điện Biên Phủ, Sơn Trà, Đà Nẵng", 16.057365999999998, 108.19178100000001, "Đặng Thu Phương Nam", "0914267295", 4.7000000000000002 });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating" },
                values: new object[] { "125 Phạm Văn Đồng, Sơn Trà, Đà Nẵng", 16.053754999999999, 108.21426700000001, "Phan Bích An", "0911971754", 4.4000000000000004 });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating" },
                values: new object[] { "95 Bạch Đằng, Hải Châu, Đà Nẵng", 16.064686999999999, 108.190511, "Phạm Ngọc Phong", "0914582901", 4.5 });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating" },
                values: new object[] { "100 Võ Nguyên Giáp, Hải Châu, Đà Nẵng", 16.054480000000002, 108.235135, "Dương Văn Khánh", "0914733916", 4.5 });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating" },
                values: new object[] { "194 Hoàng Diệu, Ngũ Hành Sơn, Đà Nẵng", 16.050746, 108.19506800000001, "Lê Hữu Khánh", "0919007596", 4.0 });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone" },
                values: new object[] { "72 Hoàng Diệu, Thanh Khê, Đà Nẵng", 16.078218, 108.18853300000001, "Bùi Quốc Phong", "0912296885" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating" },
                values: new object[] { "42 Hoàng Diệu, Sơn Trà, Đà Nẵng", 16.069638000000001, 108.20648199999999, "Nguyễn Thu Phương Cường", "0915358134", 4.5 });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating" },
                values: new object[] { "192 Hùng Vương, Hải Châu, Đà Nẵng", 16.037642000000002, 108.237258, "Trần Minh Giang", "0918769038", 5.0 });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone" },
                values: new object[] { "47 Nguyễn Văn Linh, Liên Chiểu, Đà Nẵng", 16.054141000000001, 108.220573, "Ngô Minh Phú", "0919894813" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating" },
                values: new object[] { "108 Lê Duẩn, Hải Châu, Đà Nẵng", 16.070193, 108.213204, "Đỗ Đình Cường", "0913662533", 4.2999999999999998 });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating" },
                values: new object[] { "183 Xô Viết Nghệ Tĩnh, Thanh Khê, Đà Nẵng", 16.070070000000001, 108.22863, "Phan Thu Phương Nam", "0915900168", 4.7000000000000002 });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating" },
                values: new object[] { "30 Võ Nguyên Giáp, Sơn Trà, Đà Nẵng", 16.036237, 108.225917, "Lê Ngọc Phát", "0919742510", 4.9000000000000004 });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating" },
                values: new object[] { "122 Bạch Đằng, Sơn Trà, Đà Nẵng", 16.043025, 108.180026, "Phạm Thanh Tâm", "0913349723", 4.5 });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating" },
                values: new object[] { "73 Võ Nguyên Giáp, Thanh Khê, Đà Nẵng", 16.050298000000002, 108.203655, "Lê Quốc Cường", "0912058147", 4.7999999999999998 });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating" },
                values: new object[] { "34 Nguyễn Văn Linh, Liên Chiểu, Đà Nẵng", 16.075147000000001, 108.181404, "Bùi Thị Phong", "0911350904", 5.0 });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating" },
                values: new object[] { "99 Hoàng Diệu, Hải Châu, Đà Nẵng", 16.064651999999999, 108.218411, "Phạm Công Tâm", "0912002558", 4.9000000000000004 });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating" },
                values: new object[] { "169 Hoàng Diệu, Hải Châu, Đà Nẵng", 16.051475, 108.233063, "Lê Văn Minh", "0912432341", 4.4000000000000004 });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating" },
                values: new object[] { "191 Võ Nguyên Giáp, Hải Châu, Đà Nẵng", 16.061025999999998, 108.19619, "Lý Văn Tâm", "0919272279", 4.2999999999999998 });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating" },
                values: new object[] { "90 Trần Phú, Hải Châu, Đà Nẵng", 16.058257999999999, 108.183408, "Phan Thị Dũng", "0918967108", 4.0999999999999996 });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating" },
                values: new object[] { "136 Hoàng Diệu, Thanh Khê, Đà Nẵng", 16.062428000000001, 108.20669599999999, "Trần Đình Phong", "0912512763", 4.5 });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating" },
                values: new object[] { "80 Lê Duẩn, Hải Châu, Đà Nẵng", 16.073847000000001, 108.222731, "Nguyễn Quang Em", "0919203900", 4.5999999999999996 });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating" },
                values: new object[] { "72 Hoàng Diệu, Cẩm Lệ, Đà Nẵng", 16.051165000000001, 108.18458, "Bùi Thanh Minh", "0917462271", 4.9000000000000004 });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating" },
                values: new object[] { "156 Trần Phú, Thanh Khê, Đà Nẵng", 16.055077000000001, 108.234461, "Ngô Ngọc Tùng", "0918116649", 4.2999999999999998 });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating" },
                values: new object[] { "28 Hùng Vương, Ngũ Hành Sơn, Đà Nẵng", 16.071334, 108.206491, "Lý Thanh Phát", "0914221696", 4.7999999999999998 });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating" },
                values: new object[] { "156 Võ Nguyên Giáp, Hải Châu, Đà Nẵng", 16.042770999999998, 108.180347, "Vũ Quốc Nam", "0916588046", 4.2000000000000002 });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating" },
                values: new object[] { "129 Hùng Vương, Cẩm Lệ, Đà Nẵng", 16.044336000000001, 108.198497, "Trần Hữu Dũng", "0913599782", 4.4000000000000004 });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating" },
                values: new object[] { "12 Điện Biên Phủ, Cẩm Lệ, Đà Nẵng", 16.059438, 108.22289499999999, "Hoàng Văn Phong", "0917054828", 4.5999999999999996 });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating" },
                values: new object[] { "87 Hùng Vương, Sơn Trà, Đà Nẵng", 16.055972000000001, 108.190065, "Huỳnh Bích Dũng", "0912854055", 4.4000000000000004 });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone" },
                values: new object[] { "11 Trần Phú, Cẩm Lệ, Đà Nẵng", 16.074818, 108.19972, "Nguyễn Thành Tâm", "0911756616" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating" },
                values: new object[] { "119 Hoàng Diệu, Liên Chiểu, Đà Nẵng", 16.073687, 108.23871, "Đặng Thành Long", "0919950124", 4.7000000000000002 });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating" },
                values: new object[] { "180 Phạm Văn Đồng, Thanh Khê, Đà Nẵng", 16.036111999999999, 108.229878, "Hồ Hữu Tâm", "0911758945", 4.2999999999999998 });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating" },
                values: new object[] { "21 Điện Biên Phủ, Ngũ Hành Sơn, Đà Nẵng", 16.047615, 108.237532, "Hồ Đình Giang", "0911528625", 4.2999999999999998 });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating" },
                values: new object[] { "91 Bạch Đằng, Liên Chiểu, Đà Nẵng", 16.048976, 108.216607, "Đặng Thu Phương Khánh", "0916479534", 4.7000000000000002 });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating" },
                values: new object[] { "49 Lê Duẩn, Sơn Trà, Đà Nẵng", 16.077362000000001, 108.222936, "Vũ Thu Phương An", "0919649882", 4.2999999999999998 });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating" },
                values: new object[] { "102 Trần Phú, Ngũ Hành Sơn, Đà Nẵng", 16.067140999999999, 108.199051, "Ngô Ngọc Cường", "0917718885", 4.0 });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating" },
                values: new object[] { "160 Trần Phú, Ngũ Hành Sơn, Đà Nẵng", 16.058098000000001, 108.227228, "Lý Thành Minh", "0914935229", 4.0999999999999996 });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating" },
                values: new object[] { "25 Lê Duẩn, Thanh Khê, Đà Nẵng", 16.045145999999999, 108.23985399999999, "Hoàng Thanh Phát", "0915909051", 4.2000000000000002 });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating" },
                values: new object[] { "179 Nguyễn Tri Phương, Hải Châu, Đà Nẵng", 16.052862000000001, 108.19986299999999, "Dương Công Phát", "0915906856", 4.7999999999999998 });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating" },
                values: new object[] { "149 Hoàng Diệu, Ngũ Hành Sơn, Đà Nẵng", 16.063476999999999, 108.188294, "Trần Minh Cường", "0916495523", 4.7999999999999998 });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating" },
                values: new object[] { "75 Lê Duẩn, Liên Chiểu, Đà Nẵng", 16.037096999999999, 108.22495600000001, "Dương Quang Khánh", "0914185230", 4.7000000000000002 });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating" },
                values: new object[] { "126 Bạch Đằng, Cẩm Lệ, Đà Nẵng", 16.069326, 108.222104, "Bùi Quang Tâm", "0911831883", 4.5999999999999996 });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating" },
                values: new object[] { "117 Điện Biên Phủ, Ngũ Hành Sơn, Đà Nẵng", 16.069091, 108.18358499999999, "Lê Ngọc Giang", "0916625078", 4.0999999999999996 });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating" },
                values: new object[] { "191 Trần Phú, Thanh Khê, Đà Nẵng", 16.073036999999999, 108.184416, "Huỳnh Bích Dũng", "0914365880", 4.5999999999999996 });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating" },
                values: new object[] { "20 Võ Nguyên Giáp, Hải Châu, Đà Nẵng", 16.069973000000001, 108.227374, "Lê Công Bảo", "0918781035", 4.0999999999999996 });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating" },
                values: new object[] { "56 Xô Viết Nghệ Tĩnh, Cẩm Lệ, Đà Nẵng", 16.035305999999999, 108.219342, "Dương Ngọc Phát", "0915371787", 4.7000000000000002 });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "Rating" },
                values: new object[] { "41 Trần Phú, Hải Châu, Đà Nẵng", 16.058761000000001, 108.201759, "Lê Thị Tùng", "0912265461", 4.7999999999999998 });
        }
    }
}
