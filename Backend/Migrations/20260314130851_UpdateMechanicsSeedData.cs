using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MotorSafe.Backend.Migrations
{
    /// <inheritdoc />
    public partial class UpdateMechanicsSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "ShopName" },
                values: new object[] { "12 Nguyễn Văn Linh, Hải Châu, Đà Nẵng", 16.059999999999999, 108.20999999999999, "Nguyễn Văn An", "0901000001", "An Motor Repair" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "ShopName" },
                values: new object[] { "45 Lê Duẩn, Hải Châu, Đà Nẵng", 16.068000000000001, 108.22, "Trần Văn Bình", "0901000002", "Bình Quick Fix" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "ShopName" },
                values: new object[] { "78 Trần Phú, Hải Châu, Đà Nẵng", 16.055, 108.205, "Lê Thị Cẩm", "0901000003", "Cẩm Motor Service" });

            migrationBuilder.InsertData(
                table: "Mechanics",
                columns: new[] { "Id", "Address", "IsAvailable", "Latitude", "Longitude", "Name", "Phone", "Rating", "ShopName", "SpecialSkills" },
                values: new object[,]
                {
                    { 4, "23 Hùng Vương, Hải Châu, Đà Nẵng", true, 16.062000000000001, 108.215, "Phạm Hữu Đức", "0901000004", 4.2000000000000002, "Đức Sửa Xe", "Tires, Chain" },
                    { 5, "56 Phan Châu Trinh, Hải Châu, Đà Nẵng", true, 16.07, 108.212, "Võ Minh Em", "0901000005", 4.5999999999999996, "Em Motor", "Engine" },
                    { 6, "89 Bạch Đằng, Hải Châu, Đà Nẵng", true, 16.058, 108.208, "Hoàng Văn Phú", "0901000006", 4.7000000000000002, "Phú Auto Fix", "Battery, Engine" },
                    { 7, "34 Ông Ích Khiêm, Hải Châu, Đà Nẵng", true, 16.065000000000001, 108.203, "Đỗ Quang Giang", "0901000007", 4.2999999999999998, "Giang Bike Care", "Chain, Tires" },
                    { 8, "67 Núi Thành, Hải Châu, Đà Nẵng", true, 16.053000000000001, 108.218, "Ngô Thanh Hải", "0901000008", 4.4000000000000004, "Hải Motor Pro", "All" },
                    { 9, "12 Hoàng Diệu, Hải Châu, Đà Nẵng", true, 16.071999999999999, 108.206, "Bùi Văn Inh", "0901000009", 4.0999999999999996, "Inh Quick Repair", "Tires" },
                    { 10, "90 Điện Biên Phủ, Thanh Khê, Đà Nẵng", true, 16.065999999999999, 108.19799999999999, "Lý Minh Khang", "0901000010", 4.7999999999999998, "Khang Motor Shop", "Engine, Battery" },
                    { 11, "45 Hải Phòng, Thanh Khê, Đà Nẵng", true, 16.064, 108.2, "Trương Văn Long", "0901000011", 4.0, "Long Sửa Xe 24h", "Chain" },
                    { 12, "78 Đống Đa, Thanh Khê, Đà Nẵng", true, 16.059000000000001, 108.196, "Đinh Quốc Minh", "0901000012", 4.5, "Minh Auto Care", "All" },
                    { 13, "23 Trần Cao Vân, Thanh Khê, Đà Nẵng", true, 16.071000000000002, 108.202, "Phan Hồng Nam", "0901000013", 4.5999999999999996, "Nam Bike Repair", "Engine, Tires" },
                    { 14, "56 Lê Thanh Nghị, Hải Châu, Đà Nẵng", true, 16.053999999999998, 108.214, "Mai Xuân Oanh", "0901000014", 4.2999999999999998, "Oanh Motor Fix", "Battery" },
                    { 15, "89 Nguyễn Tri Phương, Thanh Khê, Đà Nẵng", true, 16.067, 108.20399999999999, "Cao Văn Phong", "0901000015", 4.7000000000000002, "Phong Express Repair", "Tires, Chain" },
                    { 16, "12 Lê Đình Lý, Hải Châu, Đà Nẵng", true, 16.061, 108.21599999999999, "Hồ Quang Quý", "0901000016", 4.2000000000000002, "Quý Bike Pro", "Engine" },
                    { 17, "34 Nguyễn Hữu Thọ, Hải Châu, Đà Nẵng", true, 16.048999999999999, 108.211, "Đặng Văn Rạng", "0901000017", 4.9000000000000004, "Rạng Motor Service", "All" },
                    { 18, "67 Xô Viết Nghệ Tĩnh, Hải Châu, Đà Nẵng", true, 16.056999999999999, 108.209, "Vũ Đình Sơn", "0901000018", 4.4000000000000004, "Sơn Speed Fix", "Battery, Tires" },
                    { 19, "90 Trưng Nữ Vương, Hải Châu, Đà Nẵng", true, 16.062999999999999, 108.20699999999999, "Lê Văn Tâm", "0901000019", 4.5999999999999996, "Tâm Motor 365", "Chain, Engine" },
                    { 20, "23 Yên Bái, Hải Châu, Đà Nẵng", true, 16.068999999999999, 108.21299999999999, "Nguyễn Hữu Uy", "0901000020", 4.0999999999999996, "Uy Sửa Xe Nhanh", "Tires" },
                    { 21, "56 Thái Phiên, Hải Châu, Đà Nẵng", true, 16.052, 108.21899999999999, "Trần Minh Vượng", "0901000021", 4.7999999999999998, "Vượng Auto", "All" },
                    { 22, "78 Pasteur, Hải Châu, Đà Nẵng", true, 16.074000000000002, 108.205, "Phạm Đức Xuyên", "0901000022", 4.2999999999999998, "Xuyên Motor Shop", "Engine, Battery" },
                    { 23, "12 Lý Tự Trọng, Hải Châu, Đà Nẵng", true, 16.056000000000001, 108.20099999999999, "Võ Trung Yên", "0901000023", 4.5, "Yên Bike Fix", "Tires, Chain" },
                    { 24, "34 Nguyễn Chí Thanh, Hải Châu, Đà Nẵng", true, 16.065000000000001, 108.217, "Hoàng Trọng Anh", "0901000024", 4.7000000000000002, "Anh Phát Motor", "Engine" },
                    { 25, "67 Đỗ Quang, Ngũ Hành Sơn, Đà Nẵng", true, 16.050000000000001, 108.235, "Đỗ Ngọc Bảo", "0901000025", 4.2000000000000002, "Bảo Repair Center", "All" },
                    { 26, "89 Lê Văn Hiến, Ngũ Hành Sơn, Đà Nẵng", true, 16.047999999999998, 108.23, "Ngô Hải Châu", "0901000026", 4.5999999999999996, "Châu Motor Express", "Battery" },
                    { 27, "12 Nguyễn Văn Thoại, Sơn Trà, Đà Nẵng", true, 16.076000000000001, 108.22799999999999, "Bùi Đình Duy", "0901000027", 4.4000000000000004, "Duy Bike Care 24h", "Tires" },
                    { 28, "45 Phạm Văn Đồng, Sơn Trà, Đà Nẵng", true, 16.073, 108.232, "Lý Văn Đạt", "0901000028", 4.7999999999999998, "Đạt Motor Pro", "Engine, Chain" },
                    { 29, "78 An Nhơn, Sơn Trà, Đà Nẵng", true, 16.077999999999999, 108.22499999999999, "Trương Quốc Gia", "0901000029", 4.0, "Gia Motor Service", "All" },
                    { 30, "23 Ngô Quyền, Sơn Trà, Đà Nẵng", true, 16.074999999999999, 108.221, "Đinh Hữu Hào", "0901000030", 4.5, "Hào Quick Fix", "Battery, Tires" },
                    { 31, "56 Trần Đại Nghĩa, Ngũ Hành Sơn, Đà Nẵng", true, 16.047000000000001, 108.226, "Phan Minh Khánh", "0901000031", 4.2999999999999998, "Khánh Sửa Xe", "Chain" },
                    { 32, "89 Mỹ An, Ngũ Hành Sơn, Đà Nẵng", true, 16.050999999999998, 108.238, "Mai Trọng Lâm", "0901000032", 4.7000000000000002, "Lâm Motor Fix", "Engine" },
                    { 33, "12 Võ Nguyên Giáp, Sơn Trà, Đà Nẵng", true, 16.068999999999999, 108.23999999999999, "Cao Quang Mạnh", "0901000033", 4.0999999999999996, "Mạnh Bike Pro", "Tires, Engine" },
                    { 34, "34 Trần Hưng Đạo, Sơn Trà, Đà Nẵng", true, 16.077000000000002, 108.215, "Hồ Đức Nghĩa", "0901000034", 4.9000000000000004, "Nghĩa Motor 24h", "All" },
                    { 35, "67 Nguyễn Công Trứ, Sơn Trà, Đà Nẵng", true, 16.079999999999998, 108.218, "Đặng Minh Phúc", "0901000035", 4.4000000000000004, "Phúc Auto Repair", "Battery, Chain" },
                    { 36, "90 Nguyễn Lương Bằng, Liên Chiểu, Đà Nẵng", true, 16.082000000000001, 108.155, "Vũ Hồng Quân", "0901000036", 4.5999999999999996, "Quân Motor Express", "Engine" },
                    { 37, "23 Tôn Đức Thắng, Liên Chiểu, Đà Nẵng", true, 16.085000000000001, 108.16, "Lê Quốc Sang", "0901000037", 4.2000000000000002, "Sang Bike Center", "Tires" },
                    { 38, "56 Hoàng Văn Thái, Liên Chiểu, Đà Nẵng", true, 16.077999999999999, 108.16500000000001, "Nguyễn Tấn Tài", "0901000038", 4.7999999999999998, "Tài Motor Shop", "All" },
                    { 39, "78 Nguyễn Sinh Sắc, Liên Chiểu, Đà Nẵng", true, 16.071999999999999, 108.17, "Trần Hữu Vĩnh", "0901000039", 4.2999999999999998, "Vĩnh Sửa Xe Pro", "Chain, Battery" },
                    { 40, "12 Nguyễn Tất Thành, Liên Chiểu, Đà Nẵng", true, 16.09, 108.15000000000001, "Phạm Quang Huy", "0901000040", 4.5, "Huy Motor Fix", "Engine, Tires" },
                    { 41, "34 Cách Mạng T8, Cẩm Lệ, Đà Nẵng", true, 16.039999999999999, 108.20999999999999, "Võ Thanh Liêm", "0901000041", 4.7000000000000002, "Liêm Bike Service", "All" },
                    { 42, "67 Âu Cơ, Cẩm Lệ, Đà Nẵng", true, 16.038, 108.205, "Hoàng Minh Đạo", "0901000042", 4.0, "Đạo Quick Repair", "Battery" },
                    { 43, "89 Trường Chinh, Cẩm Lệ, Đà Nẵng", true, 16.035, 108.2, "Đỗ Văn Kiên", "0901000043", 4.5999999999999996, "Kiên Motor 365", "Tires, Chain" },
                    { 44, "23 Tùng Thiện Vương, Cẩm Lệ, Đà Nẵng", true, 16.042000000000002, 108.215, "Ngô Đình Lộc", "0901000044", 4.4000000000000004, "Lộc Motor Care", "Engine" },
                    { 45, "56 Võ Văn Kiệt, Cẩm Lệ, Đà Nẵng", true, 16.036999999999999, 108.22, "Bùi Trọng Nhân", "0901000045", 4.7999999999999998, "Nhân Express Motor", "All" },
                    { 46, "78 Nguyễn Phước Lan, Cẩm Lệ, Đà Nẵng", true, 16.044, 108.22499999999999, "Lý Đình Phát", "0901000046", 4.0999999999999996, "Phát Bike Fix", "Battery, Engine" },
                    { 47, "12 Lê Trọng Tấn, Cẩm Lệ, Đà Nẵng", true, 16.045999999999999, 108.19499999999999, "Trương Văn Tín", "0901000047", 4.5, "Tín Sửa Xe 24h", "Tires" },
                    { 48, "34 Trần Đức Thảo, Hải Châu, Đà Nẵng", true, 16.058, 108.22199999999999, "Đinh Xuân Việt", "0901000048", 4.9000000000000004, "Việt Motor Pro", "All" },
                    { 49, "67 Nguyễn Du, Hải Châu, Đà Nẵng", true, 16.062000000000001, 108.199, "Phan Đức Anh", "0901000049", 4.2999999999999998, "Anh Tú Motor", "Chain" },
                    { 50, "90 Duy Tân, Hải Châu, Đà Nẵng", true, 16.053999999999998, 108.20399999999999, "Mai Hoàng Bách", "0901000050", 4.7000000000000002, "Bách Motor Center", "Engine, Tires, Battery" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "ShopName" },
                values: new object[] { "123 Le Loi, Q1, HCMC", 10.776899999999999, 106.7009, "Nguyen Van A", "0901234567", "A Motor Repair" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "ShopName" },
                values: new object[] { "456 Nguyen Hue, Q1, HCMC", 10.7745, 106.7032, "Tran Van B", "0987654321", "B Quick Fix" });

            migrationBuilder.UpdateData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address", "Latitude", "Longitude", "Name", "Phone", "ShopName" },
                values: new object[] { "789 Tran Hung Dao, Q5, HCMC", 10.7554, 106.66679999999999, "Le Thi C", "0912223334", "C Motor Service" });
        }
    }
}
