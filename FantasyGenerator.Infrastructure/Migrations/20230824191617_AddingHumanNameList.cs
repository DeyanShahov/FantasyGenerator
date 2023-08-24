using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FantasyGenerator.Infrastructure.Data.Migrations
{
    public partial class AddingHumanNameList : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "NpcsName",
                columns: new[] { "Id", "CategoryName", "IsFirstName", "IsMale", "IsPublic", "Name", "SuitableRace" },
                values: new object[,]
                {
                    { 1, "Standart", true, true, true, "Aaryn", "Human" },
                    { 2, "Standart", true, true, true, "Aaro", "Human" },
                    { 3, "Standart", true, true, true, "Aarus", "Human" },
                    { 4, "Standart", true, true, true, "Abramus", "Human" },
                    { 5, "Standart", true, true, true, "Abrahm", "Human" },
                    { 6, "Standart", true, true, true, "Abyl", "Human" },
                    { 7, "Standart", true, true, true, "Abelus", "Human" },
                    { 8, "Standart", true, true, true, "Adannius", "Human" },
                    { 9, "Standart", true, true, true, "Adanno", "Human" },
                    { 10, "Standart", true, true, true, "Aedam", "Human" },
                    { 11, "Standart", true, true, true, "Adym", "Human" },
                    { 12, "Standart", true, true, true, "Adamus", "Human" },
                    { 13, "Standart", true, true, true, "Aedrian", "Human" },
                    { 14, "Standart", true, true, true, "Aedrio", "Human" },
                    { 15, "Standart", true, true, true, "Aedyn", "Human" },
                    { 16, "Standart", true, true, true, "Aidyn", "Human" },
                    { 17, "Standart", true, true, true, "Aelijah", "Human" },
                    { 18, "Standart", true, true, true, "Elyjah", "Human" },
                    { 19, "Standart", true, true, true, "Aendro", "Human" },
                    { 20, "Standart", true, true, true, "Androe", "Human" },
                    { 21, "Standart", true, true, true, "Aenry", "Human" },
                    { 22, "Standart", true, true, true, "Hynroe", "Human" },
                    { 23, "Standart", true, true, true, "Hynrus", "Human" },
                    { 24, "Standart", true, true, true, "Aethan", "Human" },
                    { 25, "Standart", true, true, true, "Aethyn", "Human" },
                    { 26, "Standart", true, true, true, "Aevan", "Human" },
                    { 27, "Standart", true, true, true, "Evyn", "Human" },
                    { 28, "Standart", true, true, true, "Evanus", "Human" },
                    { 29, "Standart", true, true, true, "Alecks", "Human" },
                    { 30, "Standart", true, true, true, "Alyx", "Human" },
                    { 31, "Standart", true, true, true, "Alexandyr", "Human" },
                    { 32, "Standart", true, true, true, "Xandyr", "Human" },
                    { 33, "Standart", true, true, true, "Alyn", "Human" },
                    { 34, "Standart", true, true, true, "Alaen", "Human" },
                    { 35, "Standart", true, true, true, "Andrus", "Human" },
                    { 36, "Standart", true, true, true, "Aendrus", "Human" },
                    { 37, "Standart", true, true, true, "Anglo", "Human" },
                    { 38, "Standart", true, true, true, "Aenglo", "Human" },
                    { 39, "Standart", true, true, true, "Anglus", "Human" },
                    { 40, "Standart", true, true, true, "Antony", "Human" },
                    { 41, "Standart", true, true, true, "Antonyr", "Human" },
                    { 42, "Standart", true, true, true, "Astyn", "Human" }
                });

            migrationBuilder.InsertData(
                table: "NpcsName",
                columns: new[] { "Id", "CategoryName", "IsFirstName", "IsMale", "IsPublic", "Name", "SuitableRace" },
                values: new object[,]
                {
                    { 43, "Standart", true, true, true, "Astinus", "Human" },
                    { 44, "Standart", true, true, true, "Axelus", "Human" },
                    { 45, "Standart", true, true, true, "Axyl", "Human" },
                    { 46, "Standart", true, true, true, "Benjamyn", "Human" },
                    { 47, "Standart", true, true, true, "Benjamyr", "Human" },
                    { 48, "Standart", true, true, true, "Braidyn", "Human" },
                    { 49, "Standart", true, true, true, "Brydus", "Human" },
                    { 50, "Standart", true, true, true, "Braddeus", "Human" },
                    { 51, "Standart", true, true, true, "Brandyn", "Human" },
                    { 52, "Standart", true, true, true, "Braendyn", "Human" },
                    { 53, "Standart", true, true, true, "Bryus", "Human" },
                    { 54, "Standart", true, true, true, "Bryne", "Human" },
                    { 55, "Standart", true, true, true, "Bryn", "Human" },
                    { 56, "Standart", true, true, true, "Branus", "Human" },
                    { 57, "Standart", true, true, true, "Caeleb", "Human" },
                    { 58, "Standart", true, true, true, "Caelyb", "Human" },
                    { 59, "Standart", true, true, true, "Caerlos", "Human" },
                    { 60, "Standart", true, true, true, "Carlus", "Human" },
                    { 61, "Standart", true, true, true, "Cameryn", "Human" },
                    { 62, "Standart", true, true, true, "Camerus", "Human" },
                    { 63, "Standart", true, true, true, "Cartus", "Human" },
                    { 64, "Standart", true, true, true, "Caertero", "Human" },
                    { 65, "Standart", true, true, true, "Charlus", "Human" },
                    { 66, "Standart", true, true, true, "Chaerles", "Human" },
                    { 67, "Standart", true, true, true, "Chyrles", "Human" },
                    { 68, "Standart", true, true, true, "Christophyr", "Human" },
                    { 69, "Standart", true, true, true, "Christo", "Human" },
                    { 70, "Standart", true, true, true, "Chrystian", "Human" },
                    { 71, "Standart", true, true, true, "Chrystan", "Human" },
                    { 72, "Standart", true, true, true, "Connorus", "Human" },
                    { 73, "Standart", true, true, true, "Connyr", "Human" },
                    { 74, "Standart", true, true, true, "Daemian", "Human" },
                    { 75, "Standart", true, true, true, "Damyan", "Human" },
                    { 76, "Standart", true, true, true, "Daenyel", "Human" },
                    { 77, "Standart", true, true, true, "Danyel", "Human" },
                    { 78, "Standart", true, true, true, "Davyd", "Human" },
                    { 79, "Standart", true, true, true, "Daevo", "Human" },
                    { 80, "Standart", true, true, true, "Dominac", "Human" },
                    { 81, "Standart", true, true, true, "Dylaen", "Human" },
                    { 82, "Standart", true, true, true, "Dylus", "Human" },
                    { 83, "Standart", true, true, true, "Elius", "Human" },
                    { 84, "Standart", true, true, true, "Aeli", "Human" }
                });

            migrationBuilder.InsertData(
                table: "NpcsName",
                columns: new[] { "Id", "CategoryName", "IsFirstName", "IsMale", "IsPublic", "Name", "SuitableRace" },
                values: new object[,]
                {
                    { 85, "Standart", true, true, true, "Elyas", "Human" },
                    { 86, "Standart", true, true, true, "Helius", "Human" },
                    { 87, "Standart", true, true, true, "Helian", "Human" },
                    { 88, "Standart", true, true, true, "Emilyan", "Human" },
                    { 89, "Standart", true, true, true, "Emilanus", "Human" },
                    { 90, "Standart", true, true, true, "Emmanus", "Human" },
                    { 91, "Standart", true, true, true, "Emynwell", "Human" },
                    { 92, "Standart", true, true, true, "Ericus", "Human" },
                    { 93, "Standart", true, true, true, "Eryc", "Human" },
                    { 94, "Standart", true, true, true, "Eryck", "Human" },
                    { 95, "Standart", true, true, true, "Ezekius", "Human" },
                    { 96, "Standart", true, true, true, "Zeckus", "Human" },
                    { 97, "Standart", true, true, true, "Ezekio", "Human" },
                    { 98, "Standart", true, true, true, "Ezrus", "Human" },
                    { 99, "Standart", true, true, true, "Yzra", "Human" },
                    { 100, "Standart", true, true, true, "Gabrael", "Human" },
                    { 101, "Standart", true, true, true, "Gaebriel", "Human" },
                    { 102, "Standart", true, true, true, "Gael", "Human" },
                    { 103, "Standart", true, true, true, "Gayl", "Human" },
                    { 104, "Standart", true, true, true, "Gayel", "Human" },
                    { 105, "Standart", true, true, true, "Gaeus", "Human" },
                    { 106, "Standart", true, true, true, "Gavyn", "Human" },
                    { 107, "Standart", true, true, true, "Gaevyn", "Human" },
                    { 108, "Standart", true, true, true, "Goshwa", "Human" },
                    { 109, "Standart", true, true, true, "Joshoe", "Human" },
                    { 110, "Standart", true, true, true, "Graysus", "Human" },
                    { 111, "Standart", true, true, true, "Graysen", "Human" },
                    { 112, "Standart", true, true, true, "Gwann", "Human" },
                    { 113, "Standart", true, true, true, "Ewan", "Human" },
                    { 114, "Standart", true, true, true, "Gwyllam", "Human" },
                    { 115, "Standart", true, true, true, "Gwyllem", "Human" },
                    { 116, "Standart", true, true, true, "Haddeus", "Human" },
                    { 117, "Standart", true, true, true, "Hudsyn", "Human" },
                    { 118, "Standart", true, true, true, "Haesoe", "Human" },
                    { 119, "Standart", true, true, true, "Haesys", "Human" },
                    { 120, "Standart", true, true, true, "Haesus", "Human" },
                    { 121, "Standart", true, true, true, "Handus", "Human" },
                    { 122, "Standart", true, true, true, "Handyr", "Human" },
                    { 123, "Standart", true, true, true, "Hantus", "Human" },
                    { 124, "Standart", true, true, true, "Huntyr", "Human" },
                    { 125, "Standart", true, true, true, "Haroldus", "Human" },
                    { 126, "Standart", true, true, true, "Haryld", "Human" }
                });

            migrationBuilder.InsertData(
                table: "NpcsName",
                columns: new[] { "Id", "CategoryName", "IsFirstName", "IsMale", "IsPublic", "Name", "SuitableRace" },
                values: new object[,]
                {
                    { 127, "Standart", true, true, true, "Horgus", "Human" },
                    { 128, "Standart", true, true, true, "Horus", "Human" },
                    { 129, "Standart", true, true, true, "Horys", "Human" },
                    { 130, "Standart", true, true, true, "Horyce", "Human" },
                    { 131, "Standart", true, true, true, "Hosea", "Human" },
                    { 132, "Standart", true, true, true, "Hosius", "Human" },
                    { 133, "Standart", true, true, true, "Iaen", "Human" },
                    { 134, "Standart", true, true, true, "Yan", "Human" },
                    { 135, "Standart", true, true, true, "Ianus", "Human" },
                    { 136, "Standart", true, true, true, "Ivaen", "Human" },
                    { 137, "Standart", true, true, true, "Yvan", "Human" },
                    { 138, "Standart", true, true, true, "Jaecoby", "Human" },
                    { 139, "Standart", true, true, true, "Jaecob", "Human" },
                    { 140, "Standart", true, true, true, "Jaeden", "Human" },
                    { 141, "Standart", true, true, true, "Jaedyn", "Human" },
                    { 142, "Standart", true, true, true, "Jaeremiah", "Human" },
                    { 143, "Standart", true, true, true, "Jeremus", "Human" },
                    { 144, "Standart", true, true, true, "Jasyn", "Human" },
                    { 145, "Standart", true, true, true, "Jaesen", "Human" },
                    { 146, "Standart", true, true, true, "Jaxon", "Human" },
                    { 147, "Standart", true, true, true, "Jaxyn", "Human" },
                    { 148, "Standart", true, true, true, "Jaxus", "Human" },
                    { 149, "Standart", true, true, true, "Johnus", "Human" },
                    { 150, "Standart", true, true, true, "Jonus", "Human" },
                    { 151, "Standart", true, true, true, "Jonaeth", "Human" },
                    { 152, "Standart", true, true, true, "Jonathyn", "Human" },
                    { 153, "Standart", true, true, true, "Jordus", "Human" },
                    { 154, "Standart", true, true, true, "Jordyn", "Human" },
                    { 155, "Standart", true, true, true, "Josaeth", "Human" },
                    { 156, "Standart", true, true, true, "Josephus", "Human" },
                    { 157, "Standart", true, true, true, "Josaeus", "Human" },
                    { 158, "Standart", true, true, true, "Josayah", "Human" },
                    { 159, "Standart", true, true, true, "Jovanus", "Human" },
                    { 160, "Standart", true, true, true, "Giovan", "Human" },
                    { 161, "Standart", true, true, true, "Julyan", "Human" },
                    { 162, "Standart", true, true, true, "Julyo", "Human" },
                    { 163, "Standart", true, true, true, "Jyck", "Human" },
                    { 164, "Standart", true, true, true, "Jaeck", "Human" },
                    { 165, "Standart", true, true, true, "Jacus", "Human" },
                    { 166, "Standart", true, true, true, "Kaevin", "Human" },
                    { 167, "Standart", true, true, true, "Kevyn", "Human" },
                    { 168, "Standart", true, true, true, "Vinkus", "Human" }
                });

            migrationBuilder.InsertData(
                table: "NpcsName",
                columns: new[] { "Id", "CategoryName", "IsFirstName", "IsMale", "IsPublic", "Name", "SuitableRace" },
                values: new object[,]
                {
                    { 169, "Standart", true, true, true, "Laevi", "Human" },
                    { 170, "Standart", true, true, true, "Levy", "Human" },
                    { 171, "Standart", true, true, true, "Levius", "Human" },
                    { 172, "Standart", true, true, true, "Landyn", "Human" },
                    { 173, "Standart", true, true, true, "Laendus", "Human" },
                    { 174, "Standart", true, true, true, "Leo", "Human" },
                    { 175, "Standart", true, true, true, "Leonus", "Human" },
                    { 176, "Standart", true, true, true, "Leonaerdo", "Human" },
                    { 177, "Standart", true, true, true, "Leonyrdo", "Human" },
                    { 178, "Standart", true, true, true, "Lynardus", "Human" },
                    { 179, "Standart", true, true, true, "Lincon", "Human" },
                    { 180, "Standart", true, true, true, "Lyncon", "Human" },
                    { 181, "Standart", true, true, true, "Linconus", "Human" },
                    { 182, "Standart", true, true, true, "Logaen", "Human" },
                    { 183, "Standart", true, true, true, "Logus", "Human" },
                    { 184, "Standart", true, true, true, "Louis", "Human" },
                    { 185, "Standart", true, true, true, "Lucius", "Human" },
                    { 186, "Standart", true, true, true, "Lucae", "Human" },
                    { 187, "Standart", true, true, true, "Lucaen", "Human" },
                    { 188, "Standart", true, true, true, "Lucaes", "Human" },
                    { 189, "Standart", true, true, true, "Lucoe", "Human" },
                    { 190, "Standart", true, true, true, "Lucus", "Human" },
                    { 191, "Standart", true, true, true, "Lyam", "Human" },
                    { 192, "Standart", true, true, true, "Maeson", "Human" },
                    { 193, "Standart", true, true, true, "Masyn", "Human" },
                    { 194, "Standart", true, true, true, "Maetho", "Human" },
                    { 195, "Standart", true, true, true, "Mathoe", "Human" },
                    { 196, "Standart", true, true, true, "Matteus", "Human" },
                    { 197, "Standart", true, true, true, "Matto", "Human" },
                    { 198, "Standart", true, true, true, "Maxus", "Human" },
                    { 199, "Standart", true, true, true, "Maximus", "Human" },
                    { 200, "Standart", true, true, true, "Maximo", "Human" },
                    { 201, "Standart", true, true, true, "Maxymer", "Human" },
                    { 202, "Standart", true, true, true, "Mychael", "Human" },
                    { 203, "Standart", true, true, true, "Mygwell", "Human" },
                    { 204, "Standart", true, true, true, "Miglus", "Human" },
                    { 205, "Standart", true, true, true, "Mythro", "Human" },
                    { 206, "Standart", true, true, true, "Mithrus", "Human" },
                    { 207, "Standart", true, true, true, "Naemo", "Human" },
                    { 208, "Standart", true, true, true, "Naethyn", "Human" },
                    { 209, "Standart", true, true, true, "Nathanus", "Human" },
                    { 210, "Standart", true, true, true, "Naethynel", "Human" }
                });

            migrationBuilder.InsertData(
                table: "NpcsName",
                columns: new[] { "Id", "CategoryName", "IsFirstName", "IsMale", "IsPublic", "Name", "SuitableRace" },
                values: new object[,]
                {
                    { 211, "Standart", true, true, true, "Nicholaes", "Human" },
                    { 212, "Standart", true, true, true, "Nycholas", "Human" },
                    { 213, "Standart", true, true, true, "Nicholys", "Human" },
                    { 214, "Standart", true, true, true, "Nicolus", "Human" },
                    { 215, "Standart", true, true, true, "Nolyn", "Human" },
                    { 216, "Standart", true, true, true, "Nolanus", "Human" },
                    { 217, "Standart", true, true, true, "Olivyr", "Human" },
                    { 218, "Standart", true, true, true, "Alivyr", "Human" },
                    { 219, "Standart", true, true, true, "Olivus", "Human" },
                    { 220, "Standart", true, true, true, "Oscarus", "Human" },
                    { 221, "Standart", true, true, true, "Oscoe", "Human" },
                    { 222, "Standart", true, true, true, "Raen", "Human" },
                    { 223, "Standart", true, true, true, "Ryn", "Human" },
                    { 224, "Standart", true, true, true, "Robertus", "Human" },
                    { 225, "Standart", true, true, true, "Robett", "Human" },
                    { 226, "Standart", true, true, true, "Bertus", "Human" },
                    { 227, "Standart", true, true, true, "Romyn", "Human" },
                    { 228, "Standart", true, true, true, "Romanus", "Human" },
                    { 229, "Standart", true, true, true, "Ryderus", "Human" },
                    { 230, "Standart", true, true, true, "Ridyr", "Human" },
                    { 231, "Standart", true, true, true, "Samwell", "Human" },
                    { 232, "Standart", true, true, true, "Saemuel", "Human" },
                    { 233, "Standart", true, true, true, "Santegus", "Human" },
                    { 234, "Standart", true, true, true, "Santaegus", "Human" },
                    { 235, "Standart", true, true, true, "Sybasten", "Human" },
                    { 236, "Standart", true, true, true, "Bastyen", "Human" },
                    { 237, "Standart", true, true, true, "Tago", "Human" },
                    { 238, "Standart", true, true, true, "Aemo", "Human" },
                    { 239, "Standart", true, true, true, "Tagus", "Human" },
                    { 240, "Standart", true, true, true, "Theodorus", "Human" },
                    { 241, "Standart", true, true, true, "Theodus", "Human" },
                    { 242, "Standart", true, true, true, "Thaeodore", "Human" },
                    { 243, "Standart", true, true, true, "Thomys", "Human" },
                    { 244, "Standart", true, true, true, "Thomas", "Human" },
                    { 245, "Standart", true, true, true, "Tommus", "Human" },
                    { 246, "Standart", true, true, true, "Tylus", "Human" },
                    { 247, "Standart", true, true, true, "Tilyr", "Human" },
                    { 248, "Standart", true, true, true, "Uwyn", "Human" },
                    { 249, "Standart", true, true, true, "Oewyn", "Human" },
                    { 250, "Standart", true, true, true, "Victor", "Human" },
                    { 251, "Standart", true, true, true, "Victyr", "Human" },
                    { 252, "Standart", true, true, true, "Victorus", "Human" }
                });

            migrationBuilder.InsertData(
                table: "NpcsName",
                columns: new[] { "Id", "CategoryName", "IsFirstName", "IsMale", "IsPublic", "Name", "SuitableRace" },
                values: new object[,]
                {
                    { 253, "Standart", true, true, true, "Vincynt", "Human" },
                    { 254, "Standart", true, true, true, "Vyncent", "Human" },
                    { 255, "Standart", true, true, true, "Vincentus", "Human" },
                    { 256, "Standart", true, true, true, "Wyttus", "Human" },
                    { 257, "Standart", true, true, true, "Wyaett", "Human" },
                    { 258, "Standart", true, true, true, "Xavius", "Human" },
                    { 259, "Standart", true, true, true, "Havius", "Human" },
                    { 260, "Standart", true, true, true, "Xavyer", "Human" },
                    { 261, "Standart", true, true, true, "Yago", "Human" },
                    { 262, "Standart", true, true, true, "Tyago", "Human" },
                    { 263, "Standart", true, true, true, "Tyego", "Human" },
                    { 264, "Standart", true, true, true, "Ysaac", "Human" },
                    { 265, "Standart", true, true, true, "Aisaac", "Human" },
                    { 266, "Standart", true, true, true, "Ysaiah", "Human" },
                    { 267, "Standart", true, true, true, "Aisiah", "Human" },
                    { 268, "Standart", true, true, true, "Siahus", "Human" },
                    { 269, "Standart", true, true, true, "Zacharus", "Human" },
                    { 270, "Standart", true, true, true, "Zachar", "Human" },
                    { 271, "Standart", true, true, true, "Zachaery", "Human" },
                    { 272, "Standart", true, false, true, "Abigayl", "Human" },
                    { 273, "Standart", true, false, true, "Aebria", "Human" },
                    { 274, "Standart", true, false, true, "Aeobreia", "Human" },
                    { 275, "Standart", true, false, true, "Breia", "Human" },
                    { 276, "Standart", true, false, true, "Aedria", "Human" },
                    { 277, "Standart", true, false, true, "Aodreia", "Human" },
                    { 278, "Standart", true, false, true, "Dreia", "Human" },
                    { 279, "Standart", true, false, true, "Aeliya", "Human" },
                    { 280, "Standart", true, false, true, "Aliya", "Human" },
                    { 281, "Standart", true, false, true, "Aella", "Human" },
                    { 282, "Standart", true, false, true, "Aemilya", "Human" },
                    { 283, "Standart", true, false, true, "Aemma", "Human" },
                    { 284, "Standart", true, false, true, "Aemy", "Human" },
                    { 285, "Standart", true, false, true, "Amy", "Human" },
                    { 286, "Standart", true, false, true, "Ami", "Human" },
                    { 287, "Standart", true, false, true, "Aeria", "Human" },
                    { 288, "Standart", true, false, true, "Arya", "Human" },
                    { 289, "Standart", true, false, true, "Aeva", "Human" },
                    { 290, "Standart", true, false, true, "Aevelyn", "Human" },
                    { 291, "Standart", true, false, true, "Evylann", "Human" },
                    { 292, "Standart", true, false, true, "Alaexa", "Human" },
                    { 293, "Standart", true, false, true, "Alyxa", "Human" },
                    { 294, "Standart", true, false, true, "Alina", "Human" }
                });

            migrationBuilder.InsertData(
                table: "NpcsName",
                columns: new[] { "Id", "CategoryName", "IsFirstName", "IsMale", "IsPublic", "Name", "SuitableRace" },
                values: new object[,]
                {
                    { 295, "Standart", true, false, true, "Aelina", "Human" },
                    { 296, "Standart", true, false, true, "Aelinea", "Human" },
                    { 297, "Standart", true, false, true, "Allisann", "Human" },
                    { 298, "Standart", true, false, true, "Allysann", "Human" },
                    { 299, "Standart", true, false, true, "Alyce", "Human" },
                    { 300, "Standart", true, false, true, "Alys", "Human" },
                    { 301, "Standart", true, false, true, "Alysea", "Human" },
                    { 302, "Standart", true, false, true, "Alyssia", "Human" },
                    { 303, "Standart", true, false, true, "Aelyssa", "Human" },
                    { 304, "Standart", true, false, true, "Amelya", "Human" },
                    { 305, "Standart", true, false, true, "Maelya", "Human" },
                    { 306, "Standart", true, false, true, "Andreya", "Human" },
                    { 307, "Standart", true, false, true, "Aendrea", "Human" },
                    { 308, "Standart", true, false, true, "Arianna", "Human" },
                    { 309, "Standart", true, false, true, "Aryanna", "Human" },
                    { 310, "Standart", true, false, true, "Arielle", "Human" },
                    { 311, "Standart", true, false, true, "Aryell", "Human" },
                    { 312, "Standart", true, false, true, "Ariella", "Human" },
                    { 313, "Standart", true, false, true, "Ashlena", "Human" },
                    { 314, "Standart", true, false, true, "Aurora", "Human" },
                    { 315, "Standart", true, false, true, "Avaery", "Human" },
                    { 316, "Standart", true, false, true, "Avyrie", "Human" },
                    { 317, "Standart", true, false, true, "Bella", "Human" },
                    { 318, "Standart", true, false, true, "Baella", "Human" },
                    { 319, "Standart", true, false, true, "Brooklinea", "Human" },
                    { 320, "Standart", true, false, true, "Bryanna", "Human" },
                    { 321, "Standart", true, false, true, "Brynna", "Human" },
                    { 322, "Standart", true, false, true, "Brinna", "Human" },
                    { 323, "Standart", true, false, true, "Caemila", "Human" },
                    { 324, "Standart", true, false, true, "Chloe", "Human" },
                    { 325, "Standart", true, false, true, "Chloeia", "Human" },
                    { 326, "Standart", true, false, true, "Claira", "Human" },
                    { 327, "Standart", true, false, true, "Clayre", "Human" },
                    { 328, "Standart", true, false, true, "Clayra", "Human" },
                    { 329, "Standart", true, false, true, "Delyla", "Human" },
                    { 330, "Standart", true, false, true, "Dalyla", "Human" },
                    { 331, "Standart", true, false, true, "Elisybeth", "Human" },
                    { 332, "Standart", true, false, true, "Aelisabeth", "Human" },
                    { 333, "Standart", true, false, true, "Ellia", "Human" },
                    { 334, "Standart", true, false, true, "Ellya", "Human" },
                    { 335, "Standart", true, false, true, "Elyana", "Human" },
                    { 336, "Standart", true, false, true, "Eliana", "Human" }
                });

            migrationBuilder.InsertData(
                table: "NpcsName",
                columns: new[] { "Id", "CategoryName", "IsFirstName", "IsMale", "IsPublic", "Name", "SuitableRace" },
                values: new object[,]
                {
                    { 337, "Standart", true, false, true, "Eva", "Human" },
                    { 338, "Standart", true, false, true, "Falyne", "Human" },
                    { 339, "Standart", true, false, true, "Genaesis", "Human" },
                    { 340, "Standart", true, false, true, "Genaesys", "Human" },
                    { 341, "Standart", true, false, true, "Gianna", "Human" },
                    { 342, "Standart", true, false, true, "Jianna", "Human" },
                    { 343, "Standart", true, false, true, "Janna", "Human" },
                    { 344, "Standart", true, false, true, "Graece", "Human" },
                    { 345, "Standart", true, false, true, "Grassa", "Human" },
                    { 346, "Standart", true, false, true, "Haenna", "Human" },
                    { 347, "Standart", true, false, true, "Hanna", "Human" },
                    { 348, "Standart", true, false, true, "Halya", "Human" },
                    { 349, "Standart", true, false, true, "Harperia", "Human" },
                    { 350, "Standart", true, false, true, "Peria", "Human" },
                    { 351, "Standart", true, false, true, "Hazyl", "Human" },
                    { 352, "Standart", true, false, true, "Hazel", "Human" },
                    { 353, "Standart", true, false, true, "Jasmyne", "Human" },
                    { 354, "Standart", true, false, true, "Jasmine", "Human" },
                    { 355, "Standart", true, false, true, "Jocelyne", "Human" },
                    { 356, "Standart", true, false, true, "Joceline", "Human" },
                    { 357, "Standart", true, false, true, "Celine", "Human" },
                    { 358, "Standart", true, false, true, "Kaelia", "Human" },
                    { 359, "Standart", true, false, true, "Kaelya", "Human" },
                    { 360, "Standart", true, false, true, "Kathryne", "Human" },
                    { 361, "Standart", true, false, true, "Kathrine", "Human" },
                    { 362, "Standart", true, false, true, "Kayla", "Human" },
                    { 363, "Standart", true, false, true, "Kaila", "Human" },
                    { 364, "Standart", true, false, true, "Kymber", "Human" },
                    { 365, "Standart", true, false, true, "Kimbera", "Human" },
                    { 366, "Standart", true, false, true, "Layla", "Human" },
                    { 367, "Standart", true, false, true, "Laylanna", "Human" },
                    { 368, "Standart", true, false, true, "Leia", "Human" },
                    { 369, "Standart", true, false, true, "Leya", "Human" },
                    { 370, "Standart", true, false, true, "Leah", "Human" },
                    { 371, "Standart", true, false, true, "Lilia", "Human" },
                    { 372, "Standart", true, false, true, "Lylia", "Human" },
                    { 373, "Standart", true, false, true, "Luna", "Human" },
                    { 374, "Standart", true, false, true, "Maedisa", "Human" },
                    { 375, "Standart", true, false, true, "Maelania", "Human" },
                    { 376, "Standart", true, false, true, "Melania", "Human" },
                    { 377, "Standart", true, false, true, "Maya", "Human" },
                    { 378, "Standart", true, false, true, "Mya", "Human" }
                });

            migrationBuilder.InsertData(
                table: "NpcsName",
                columns: new[] { "Id", "CategoryName", "IsFirstName", "IsMale", "IsPublic", "Name", "SuitableRace" },
                values: new object[,]
                {
                    { 379, "Standart", true, false, true, "Myla", "Human" },
                    { 380, "Standart", true, false, true, "Milae", "Human" },
                    { 381, "Standart", true, false, true, "Naomi", "Human" },
                    { 382, "Standart", true, false, true, "Naome", "Human" },
                    { 383, "Standart", true, false, true, "Natalya", "Human" },
                    { 384, "Standart", true, false, true, "Talya", "Human" },
                    { 385, "Standart", true, false, true, "Nathylie", "Human" },
                    { 386, "Standart", true, false, true, "Nataliae", "Human" },
                    { 387, "Standart", true, false, true, "Thalia", "Human" },
                    { 388, "Standart", true, false, true, "Nicola", "Human" },
                    { 389, "Standart", true, false, true, "Nikola", "Human" },
                    { 390, "Standart", true, false, true, "Nycola", "Human" },
                    { 391, "Standart", true, false, true, "Olivya", "Human" },
                    { 392, "Standart", true, false, true, "Alivya", "Human" },
                    { 393, "Standart", true, false, true, "Penelope", "Human" },
                    { 394, "Standart", true, false, true, "Paenelope", "Human" },
                    { 395, "Standart", true, false, true, "Pynelope", "Human" },
                    { 396, "Standart", true, false, true, "Rianna", "Human" },
                    { 397, "Standart", true, false, true, "Ryanna", "Human" },
                    { 398, "Standart", true, false, true, "Ruby", "Human" },
                    { 399, "Standart", true, false, true, "Ryla", "Human" },
                    { 400, "Standart", true, false, true, "Samaentha", "Human" },
                    { 401, "Standart", true, false, true, "Samytha", "Human" },
                    { 402, "Standart", true, false, true, "Sara", "Human" },
                    { 403, "Standart", true, false, true, "Sarah", "Human" },
                    { 404, "Standart", true, false, true, "Savannia", "Human" },
                    { 405, "Standart", true, false, true, "Scarletta", "Human" },
                    { 406, "Standart", true, false, true, "Sharlotta", "Human" },
                    { 407, "Standart", true, false, true, "Caerlotta", "Human" },
                    { 408, "Standart", true, false, true, "Sophya", "Human" },
                    { 409, "Standart", true, false, true, "Stella", "Human" },
                    { 410, "Standart", true, false, true, "Stylla", "Human" },
                    { 411, "Standart", true, false, true, "Valentyna", "Human" },
                    { 412, "Standart", true, false, true, "Valerya", "Human" },
                    { 413, "Standart", true, false, true, "Valeria", "Human" },
                    { 414, "Standart", true, false, true, "Valia", "Human" },
                    { 415, "Standart", true, false, true, "Valea", "Human" },
                    { 416, "Standart", true, false, true, "Victorya", "Human" },
                    { 417, "Standart", true, false, true, "Vilettia", "Human" },
                    { 418, "Standart", true, false, true, "Ximena", "Human" },
                    { 419, "Standart", true, false, true, "Imaena", "Human" },
                    { 420, "Standart", true, false, true, "Ysabel", "Human" }
                });

            migrationBuilder.InsertData(
                table: "NpcsName",
                columns: new[] { "Id", "CategoryName", "IsFirstName", "IsMale", "IsPublic", "Name", "SuitableRace" },
                values: new object[,]
                {
                    { 421, "Standart", true, false, true, "Zoe", "Human" },
                    { 422, "Standart", true, false, true, "Zoeia", "Human" },
                    { 423, "Standart", true, false, true, "Zoea", "Human" },
                    { 424, "Standart", true, false, true, "Zoesia", "Human" },
                    { 425, "Standart", false, true, true, "Alder", "Human" },
                    { 426, "Standart", false, true, true, "Ash", "Human" },
                    { 427, "Standart", false, true, true, "Ashdown", "Human" },
                    { 428, "Standart", false, true, true, "Atwood", "Human" },
                    { 429, "Standart", false, true, true, "Barnes", "Human" },
                    { 430, "Standart", false, true, true, "Becker", "Human" },
                    { 431, "Standart", false, true, true, "Berry", "Human" },
                    { 432, "Standart", false, true, true, "Briar", "Human" },
                    { 433, "Standart", false, true, true, "Briggs", "Human" },
                    { 434, "Standart", false, true, true, "Brock", "Human" },
                    { 435, "Standart", false, true, true, "Brook", "Human" },
                    { 436, "Standart", false, true, true, "Bundy", "Human" },
                    { 437, "Standart", false, true, true, "Burnside", "Human" },
                    { 438, "Standart", false, true, true, "Burroughs", "Human" },
                    { 439, "Standart", false, true, true, "Bush", "Human" },
                    { 440, "Standart", false, true, true, "Butcher", "Human" },
                    { 441, "Standart", false, true, true, "Butler", "Human" },
                    { 442, "Standart", false, true, true, "Clay", "Human" },
                    { 443, "Standart", false, true, true, "Court", "Human" },
                    { 444, "Standart", false, true, true, "Cox", "Human" },
                    { 445, "Standart", false, true, true, "Croft", "Human" },
                    { 446, "Standart", false, true, true, "Cross", "Human" },
                    { 447, "Standart", false, true, true, "Crump", "Human" },
                    { 448, "Standart", false, true, true, "Dale", "Human" },
                    { 449, "Standart", false, true, true, "Deane", "Human" },
                    { 450, "Standart", false, true, true, "Delaney", "Human" },
                    { 451, "Standart", false, true, true, "Dike", "Human" },
                    { 452, "Standart", false, true, true, "Dodd", "Human" },
                    { 453, "Standart", false, true, true, "Ford", "Human" },
                    { 454, "Standart", false, true, true, "Forrest", "Human" },
                    { 455, "Standart", false, true, true, "Fox", "Human" },
                    { 456, "Standart", false, true, true, "Freeman", "Human" },
                    { 457, "Standart", false, true, true, "Garside", "Human" },
                    { 458, "Standart", false, true, true, "Gorsuch", "Human" },
                    { 459, "Standart", false, true, true, "Graves", "Human" },
                    { 460, "Standart", false, true, true, "Green", "Human" },
                    { 461, "Standart", false, true, true, "Greeves", "Human" },
                    { 462, "Standart", false, true, true, "Gross", "Human" }
                });

            migrationBuilder.InsertData(
                table: "NpcsName",
                columns: new[] { "Id", "CategoryName", "IsFirstName", "IsMale", "IsPublic", "Name", "SuitableRace" },
                values: new object[,]
                {
                    { 463, "Standart", false, true, true, "Grove", "Human" },
                    { 464, "Standart", false, true, true, "Grover", "Human" },
                    { 465, "Standart", false, true, true, "Hall", "Human" },
                    { 466, "Standart", false, true, true, "Hawthorne", "Human" },
                    { 467, "Standart", false, true, true, "Hazel", "Human" },
                    { 468, "Standart", false, true, true, "Head", "Human" },
                    { 469, "Standart", false, true, true, "Heather", "Human" },
                    { 470, "Standart", false, true, true, "Hill", "Human" },
                    { 471, "Standart", false, true, true, "Holley", "Human" },
                    { 472, "Standart", false, true, true, "Holmes", "Human" },
                    { 473, "Standart", false, true, true, "Holt", "Human" },
                    { 474, "Standart", false, true, true, "Homer", "Human" },
                    { 475, "Standart", false, true, true, "Hooke", "Human" },
                    { 476, "Standart", false, true, true, "Hope", "Human" },
                    { 477, "Standart", false, true, true, "House", "Human" },
                    { 478, "Standart", false, true, true, "Howe", "Human" },
                    { 479, "Standart", false, true, true, "Hume", "Human" },
                    { 480, "Standart", false, true, true, "Hyde", "Human" },
                    { 481, "Standart", false, true, true, "Johnston", "Human" },
                    { 482, "Standart", false, true, true, "Kaye", "Human" },
                    { 483, "Standart", false, true, true, "Keats", "Human" },
                    { 484, "Standart", false, true, true, "Kerry", "Human" },
                    { 485, "Standart", false, true, true, "Kirk", "Human" },
                    { 486, "Standart", false, true, true, "Lamb", "Human" },
                    { 487, "Standart", false, true, true, "Layne", "Human" },
                    { 488, "Standart", false, true, true, "Lea", "Human" },
                    { 489, "Standart", false, true, true, "Lowell", "Human" },
                    { 490, "Standart", false, true, true, "March", "Human" },
                    { 491, "Standart", false, true, true, "Marsh", "Human" },
                    { 492, "Standart", false, true, true, "Marshal", "Human" },
                    { 493, "Standart", false, true, true, "Martin", "Human" },
                    { 494, "Standart", false, true, true, "May", "Human" },
                    { 495, "Standart", false, true, true, "Millerchip", "Human" },
                    { 496, "Standart", false, true, true, "Mills", "Human" },
                    { 497, "Standart", false, true, true, "Moore", "Human" },
                    { 498, "Standart", false, true, true, "Newby", "Human" },
                    { 499, "Standart", false, true, true, "Paine", "Human" },
                    { 500, "Standart", false, true, true, "Paxton", "Human" },
                    { 501, "Standart", false, true, true, "Perrin", "Human" },
                    { 502, "Standart", false, true, true, "Pike", "Human" },
                    { 503, "Standart", false, true, true, "Pitt", "Human" },
                    { 504, "Standart", false, true, true, "Preacher", "Human" }
                });

            migrationBuilder.InsertData(
                table: "NpcsName",
                columns: new[] { "Id", "CategoryName", "IsFirstName", "IsMale", "IsPublic", "Name", "SuitableRace" },
                values: new object[,]
                {
                    { 505, "Standart", false, true, true, "Provost", "Human" },
                    { 506, "Standart", false, true, true, "Purple", "Human" },
                    { 507, "Standart", false, true, true, "Ridge", "Human" },
                    { 508, "Standart", false, true, true, "Rock", "Human" },
                    { 509, "Standart", false, true, true, "Rose", "Human" },
                    { 510, "Standart", false, true, true, "Rowen", "Human" },
                    { 511, "Standart", false, true, true, "Sangster", "Human" },
                    { 512, "Standart", false, true, true, "Sellers", "Human" },
                    { 513, "Standart", false, true, true, "Shaw", "Human" },
                    { 514, "Standart", false, true, true, "Short", "Human" },
                    { 515, "Standart", false, true, true, "Thorne", "Human" },
                    { 516, "Standart", false, true, true, "Underwood", "Human" },
                    { 517, "Standart", false, true, true, "Walsh", "Human" },
                    { 518, "Standart", false, true, true, "Wells", "Human" },
                    { 519, "Standart", false, true, true, "West", "Human" },
                    { 520, "Standart", false, true, true, "Whitney", "Human" },
                    { 521, "Standart", false, true, true, "Wilde", "Human" },
                    { 522, "Standart", false, true, true, "Wood", "Human" },
                    { 523, "Standart", false, true, true, "Wragge", "Human" },
                    { 524, "Standart", false, true, true, "Wynne", "Human" },
                    { 525, "English Medieval", true, true, true, "Adam", "Human" },
                    { 526, "English Medieval", true, true, true, "Henry", "Human" },
                    { 527, "English Medieval", true, true, true, "John", "Human" },
                    { 528, "English Medieval", true, true, true, "Richard", "Human" },
                    { 529, "English Medieval", true, true, true, "Simon", "Human" },
                    { 530, "English Medieval", true, true, true, "William", "Human" },
                    { 531, "English Medieval", true, true, true, "Geoffrey", "Human" },
                    { 532, "English Medieval", true, true, true, "Hugh", "Human" },
                    { 533, "English Medieval", true, true, true, "Peter", "Human" },
                    { 534, "English Medieval", true, true, true, "Robert", "Human" },
                    { 535, "English Medieval", true, true, true, "Thomas", "Human" },
                    { 536, "English Medieval", true, true, true, "Gilbert", "Human" },
                    { 537, "English Medieval", true, false, true, "Agnes", "Human" },
                    { 538, "English Medieval", true, false, true, "Beatrice", "Human" },
                    { 539, "English Medieval", true, false, true, "Isabella", "Human" },
                    { 540, "English Medieval", true, false, true, "Margery", "Human" },
                    { 541, "English Medieval", true, false, true, "Alice", "Human" },
                    { 542, "English Medieval", true, false, true, "Cecily", "Human" },
                    { 543, "English Medieval", true, false, true, "Galena", "Human" },
                    { 544, "English Medieval", true, false, true, "Glenda", "Human" },
                    { 545, "English Medieval", true, false, true, "Kennis", "Human" },
                    { 546, "English Medieval", true, false, true, "Mavis", "Human" }
                });

            migrationBuilder.InsertData(
                table: "NpcsName",
                columns: new[] { "Id", "CategoryName", "IsFirstName", "IsMale", "IsPublic", "Name", "SuitableRace" },
                values: new object[,]
                {
                    { 547, "English Medieval", true, false, true, "Morgana", "Human" },
                    { 548, "English Medieval", true, false, true, "Joan", "Human" },
                    { 549, "English Medieval", true, false, true, "Matilda", "Human" },
                    { 550, "English Medieval", true, false, true, "Avice", "Human" },
                    { 551, "English Medieval", true, false, true, "Emma", "Human" },
                    { 552, "English Medieval", true, false, true, "Juliana", "Human" },
                    { 553, "English Medieval", true, false, true, "Rohesia", "Human" },
                    { 554, "English Medieval", false, true, true, "Alewife", "Human" },
                    { 555, "English Medieval", false, true, true, "Ambler", "Human" },
                    { 556, "English Medieval", false, true, true, "Ashburner", "Human" },
                    { 557, "English Medieval", false, true, true, "Ayler", "Human" },
                    { 558, "English Medieval", false, true, true, "Backer", "Human" },
                    { 559, "English Medieval", false, true, true, "Banister", "Human" },
                    { 560, "English Medieval", false, true, true, "Barker", "Human" },
                    { 561, "English Medieval", false, true, true, "Barter", "Human" },
                    { 562, "English Medieval", false, true, true, "Boot", "Human" },
                    { 563, "English Medieval", false, true, true, "Botwright", "Human" },
                    { 564, "English Medieval", false, true, true, "Bourchier", "Human" },
                    { 565, "English Medieval", false, true, true, "Bowmaker", "Human" },
                    { 566, "English Medieval", false, true, true, "Butler", "Human" },
                    { 567, "English Medieval", false, true, true, "Canter", "Human" },
                    { 568, "English Medieval", false, true, true, "Capper", "Human" },
                    { 569, "English Medieval", false, true, true, "Carpenter", "Human" },
                    { 570, "English Medieval", false, true, true, "Carver", "Human" },
                    { 571, "English Medieval", false, true, true, "Chaplin", "Human" },
                    { 572, "English Medieval", false, true, true, "Chaucer", "Human" },
                    { 573, "English Medieval", false, true, true, "Cheator", "Human" },
                    { 574, "English Medieval", false, true, true, "Shuttle", "Human" },
                    { 575, "English Medieval", false, true, true, "Silk", "Human" },
                    { 576, "English Medieval", false, true, true, "Simister", "Human" },
                    { 577, "English Medieval", false, true, true, "Sizer", "Human" },
                    { 578, "English Medieval", false, true, true, "Snider", "Human" },
                    { 579, "English Medieval", false, true, true, "Spence", "Human" },
                    { 580, "English Medieval", false, true, true, "Spice", "Human" },
                    { 581, "English Medieval", false, true, true, "Vicar", "Human" },
                    { 582, "English Medieval", false, true, true, "Vickery", "Human" },
                    { 583, "English Medieval", false, true, true, "Mangall", "Human" },
                    { 584, "English Medieval", false, true, true, "Marchant", "Human" },
                    { 585, "English Medieval", false, true, true, "Mason", "Human" },
                    { 586, "English Medieval", false, true, true, "Mather", "Human" },
                    { 587, "English Medieval", false, true, true, "Merchant", "Human" },
                    { 588, "English Medieval", false, true, true, "Meystre", "Human" }
                });

            migrationBuilder.InsertData(
                table: "NpcsName",
                columns: new[] { "Id", "CategoryName", "IsFirstName", "IsMale", "IsPublic", "Name", "SuitableRace" },
                values: new object[,]
                {
                    { 589, "English Medieval", false, true, true, "Aguilar", "Human" },
                    { 590, "English Medieval", false, true, true, "Archer", "Human" },
                    { 591, "English Medieval", false, true, true, "Ashman", "Human" },
                    { 592, "English Medieval", false, true, true, "Bacchus", "Human" },
                    { 593, "English Medieval", false, true, true, "Bacon", "Human" },
                    { 594, "English Medieval", false, true, true, "Ballester", "Human" },
                    { 595, "English Medieval", false, true, true, "Bannerman", "Human" },
                    { 596, "English Medieval", false, true, true, "Baron", "Human" },
                    { 597, "English Medieval", false, true, true, "Baxter", "Human" },
                    { 598, "English Medieval", false, true, true, "Boote", "Human" },
                    { 599, "English Medieval", false, true, true, "Boucher", "Human" },
                    { 600, "English Medieval", false, true, true, "Bowerman", "Human" },
                    { 601, "English Medieval", false, true, true, "Bowman", "Human" },
                    { 602, "English Medieval", false, true, true, "Butner", "Human" },
                    { 603, "English Medieval", false, true, true, "Caperon", "Human" },
                    { 604, "English Medieval", false, true, true, "Card", "Human" },
                    { 605, "English Medieval", false, true, true, "Carter", "Human" },
                    { 606, "English Medieval", false, true, true, "Catchpole", "Human" },
                    { 607, "English Medieval", false, true, true, "Chapman", "Human" },
                    { 608, "English Medieval", false, true, true, "Chauncellor", "Human" },
                    { 609, "English Medieval", false, true, true, "Cheese", "Human" },
                    { 610, "English Medieval", false, true, true, "Sievewright", "Human" },
                    { 611, "English Medieval", false, true, true, "Silver", "Human" },
                    { 612, "English Medieval", false, true, true, "Singer", "Human" },
                    { 613, "English Medieval", false, true, true, "Skinner", "Human" },
                    { 614, "English Medieval", false, true, true, "Sniders", "Human" },
                    { 615, "English Medieval", false, true, true, "Spicer", "Human" },
                    { 616, "English Medieval", false, true, true, "Vicars", "Human" },
                    { 617, "English Medieval", false, true, true, "Vinter", "Human" },
                    { 618, "English Medieval", false, true, true, "Mills", "Human" },
                    { 619, "English Medieval", false, true, true, "Mower", "Human" },
                    { 620, "English Medieval", false, true, true, "Paige", "Human" },
                    { 621, "English Medieval", false, true, true, "Pallister", "Human" },
                    { 622, "English Medieval", false, true, true, "Panter", "Human" },
                    { 623, "English Medieval", false, true, true, "Alderman", "Human" },
                    { 624, "English Medieval", false, true, true, "Aurifaber", "Human" },
                    { 625, "English Medieval", false, true, true, "Bachelor", "Human" },
                    { 626, "English Medieval", false, true, true, "Bailey", "Human" },
                    { 627, "English Medieval", false, true, true, "Balmer", "Human" },
                    { 628, "English Medieval", false, true, true, "Barber", "Human" },
                    { 629, "English Medieval", false, true, true, "Barrell", "Human" },
                    { 630, "English Medieval", false, true, true, "Bayliss", "Human" }
                });

            migrationBuilder.InsertData(
                table: "NpcsName",
                columns: new[] { "Id", "CategoryName", "IsFirstName", "IsMale", "IsPublic", "Name", "SuitableRace" },
                values: new object[,]
                {
                    { 631, "English Medieval", false, true, true, "Boothman", "Human" },
                    { 632, "English Medieval", false, true, true, "Boulter", "Human" },
                    { 633, "English Medieval", false, true, true, "Bowler", "Human" },
                    { 634, "English Medieval", false, true, true, "Bowring", "Human" },
                    { 635, "English Medieval", false, true, true, "Butters", "Human" },
                    { 636, "English Medieval", false, true, true, "Capon", "Human" },
                    { 637, "English Medieval", false, true, true, "Carder", "Human" },
                    { 638, "English Medieval", false, true, true, "Cater", "Human" },
                    { 639, "English Medieval", false, true, true, "Chase", "Human" },
                    { 640, "English Medieval", false, true, true, "Chaundler", "Human" },
                    { 641, "English Medieval", false, true, true, "Cheeseman", "Human" },
                    { 642, "English Medieval", false, true, true, "Silversmith", "Human" },
                    { 643, "English Medieval", false, true, true, "Slater", "Human" },
                    { 644, "English Medieval", false, true, true, "Soper", "Human" },
                    { 645, "English Medieval", false, true, true, "Spender", "Human" },
                    { 646, "English Medieval", false, true, true, "Spier", "Human" },
                    { 647, "English Medieval", false, true, true, "Vickers", "Human" },
                    { 648, "English Medieval", false, true, true, "Voller", "Human" },
                    { 649, "English Medieval", false, true, true, "Pardner", "Human" },
                    { 650, "English Medieval", false, true, true, "Pinder", "Human" },
                    { 651, "English Medieval", false, true, true, "Porcher", "Human" },
                    { 652, "English Medieval", false, true, true, "Potter", "Human" },
                    { 653, "English Medieval", false, true, true, "Priest", "Human" },
                    { 654, "English Medieval", false, true, true, "Procter", "Human" },
                    { 655, "English Medieval", false, true, true, "Dayman", "Human" },
                    { 656, "English Medieval", false, true, true, "Deathridge", "Human" },
                    { 657, "English Medieval", false, true, true, "Diver", "Human" },
                    { 658, "English Medieval", false, true, true, "Drawer", "Human" },
                    { 659, "English Medieval", false, true, true, "Driver", "Human" },
                    { 660, "English Medieval", false, true, true, "Earle", "Human" },
                    { 661, "English Medieval", false, true, true, "Falconar", "Human" },
                    { 662, "English Medieval", false, true, true, "Falkner", "Human" },
                    { 663, "English Medieval", false, true, true, "Farrar", "Human" },
                    { 664, "English Medieval", false, true, true, "Fletcher", "Human" },
                    { 665, "English Medieval", false, true, true, "Flower", "Human" },
                    { 666, "English Medieval", false, true, true, "Forest", "Human" },
                    { 667, "English Medieval", false, true, true, "Forster", "Human" },
                    { 668, "English Medieval", false, true, true, "Gilder", "Human" },
                    { 669, "English Medieval", false, true, true, "Gravenor", "Human" },
                    { 670, "English Medieval", false, true, true, "Groom", "Human" },
                    { 671, "English Medieval", false, true, true, "Grunsell", "Human" },
                    { 672, "English Medieval", false, true, true, "Hansard", "Human" }
                });

            migrationBuilder.InsertData(
                table: "NpcsName",
                columns: new[] { "Id", "CategoryName", "IsFirstName", "IsMale", "IsPublic", "Name", "SuitableRace" },
                values: new object[,]
                {
                    { 673, "English Medieval", false, true, true, "Hotter", "Human" },
                    { 674, "English Medieval", false, true, true, "Hunter", "Human" },
                    { 675, "English Medieval", false, true, true, "Inman", "Human" },
                    { 676, "English Medieval", false, true, true, "Spindler", "Human" },
                    { 677, "English Medieval", false, true, true, "Squier", "Human" },
                    { 678, "English Medieval", false, true, true, "Stainer", "Human" },
                    { 679, "English Medieval", false, true, true, "Steel", "Human" },
                    { 680, "English Medieval", false, true, true, "Sumner", "Human" },
                    { 681, "English Medieval", false, true, true, "Swingler", "Human" },
                    { 682, "English Medieval", false, true, true, "Tanner", "Human" },
                    { 683, "English Medieval", false, true, true, "Waghorn", "Human" },
                    { 684, "English Medieval", false, true, true, "Redman", "Human" },
                    { 685, "English Medieval", false, true, true, "Restler", "Human" },
                    { 686, "English Medieval", false, true, true, "Ridler", "Human" },
                    { 687, "English Medieval", false, true, true, "Taylor", "Human" },
                    { 688, "English Medieval", false, true, true, "Tinkler", "Human" },
                    { 689, "English Medieval", false, true, true, "Todhunter", "Human" },
                    { 690, "English Medieval", false, true, true, "Daymond", "Human" },
                    { 691, "English Medieval", false, true, true, "Demmer", "Human" },
                    { 692, "English Medieval", false, true, true, "Draper", "Human" },
                    { 693, "English Medieval", false, true, true, "Dray", "Human" },
                    { 694, "English Medieval", false, true, true, "Ewer", "Human" },
                    { 695, "English Medieval", false, true, true, "Farman", "Human" },
                    { 696, "English Medieval", false, true, true, "Farrier", "Human" },
                    { 697, "English Medieval", false, true, true, "Flinter", "Human" },
                    { 698, "English Medieval", false, true, true, "Footman", "Human" },
                    { 699, "English Medieval", false, true, true, "Forester", "Human" },
                    { 700, "English Medieval", false, true, true, "Fournier", "Human" },
                    { 701, "English Medieval", false, true, true, "Gilroy", "Human" },
                    { 702, "English Medieval", false, true, true, "Greensmith", "Human" },
                    { 703, "English Medieval", false, true, true, "Groser", "Human" },
                    { 704, "English Medieval", false, true, true, "Guild", "Human" },
                    { 705, "English Medieval", false, true, true, "Harper", "Human" },
                    { 706, "English Medieval", false, true, true, "Hucker", "Human" },
                    { 707, "English Medieval", false, true, true, "Spooner", "Human" },
                    { 708, "English Medieval", false, true, true, "Squiers", "Human" },
                    { 709, "English Medieval", false, true, true, "Steadman", "Human" },
                    { 710, "English Medieval", false, true, true, "Steele", "Human" },
                    { 711, "English Medieval", false, true, true, "Surgeon", "Human" },
                    { 712, "English Medieval", false, true, true, "Taper", "Human" },
                    { 713, "English Medieval", false, true, true, "Waghorne", "Human" },
                    { 714, "English Medieval", false, true, true, "Wain", "Human" }
                });

            migrationBuilder.InsertData(
                table: "NpcsName",
                columns: new[] { "Id", "CategoryName", "IsFirstName", "IsMale", "IsPublic", "Name", "SuitableRace" },
                values: new object[,]
                {
                    { 715, "English Medieval", false, true, true, "Toner", "Human" },
                    { 716, "English Medieval", false, true, true, "Tripper", "Human" },
                    { 717, "English Medieval", false, true, true, "Trumper", "Human" },
                    { 718, "English Medieval", false, true, true, "Tuckerman", "Human" },
                    { 719, "English Medieval", false, true, true, "Warman", "Human" },
                    { 720, "English Medieval", false, true, true, "Warrener", "Human" },
                    { 721, "English Medieval", false, true, true, "Deacon", "Human" },
                    { 722, "English Medieval", false, true, true, "Dempster", "Human" },
                    { 723, "English Medieval", false, true, true, "Drapper", "Human" },
                    { 724, "English Medieval", false, true, true, "Dring", "Human" },
                    { 725, "English Medieval", false, true, true, "Earl", "Human" },
                    { 726, "English Medieval", false, true, true, "Faber", "Human" },
                    { 727, "English Medieval", false, true, true, "Falder", "Human" },
                    { 728, "English Medieval", false, true, true, "Farmer", "Human" },
                    { 729, "English Medieval", false, true, true, "Faulkner", "Human" },
                    { 730, "English Medieval", false, true, true, "Floater", "Human" },
                    { 731, "English Medieval", false, true, true, "Foreman", "Human" },
                    { 732, "English Medieval", false, true, true, "Forestier", "Human" },
                    { 733, "English Medieval", false, true, true, "Fowler", "Human" },
                    { 734, "English Medieval", false, true, true, "Ginger", "Human" },
                    { 735, "English Medieval", false, true, true, "Grieve", "Human" },
                    { 736, "English Medieval", false, true, true, "Grosvenor", "Human" },
                    { 737, "English Medieval", false, true, true, "Hacker", "Human" },
                    { 738, "English Medieval", false, true, true, "Hawker", "Human" },
                    { 739, "English Medieval", false, true, true, "Hunt", "Human" },
                    { 740, "English Medieval", false, true, true, "Hussey", "Human" },
                    { 741, "English Medieval", false, true, true, "Jagger", "Human" },
                    { 742, "English Medieval", false, true, true, "Spurrier", "Human" },
                    { 743, "English Medieval", false, true, true, "Squires", "Human" },
                    { 744, "English Medieval", false, true, true, "Stearman", "Human" },
                    { 745, "English Medieval", false, true, true, "Steward", "Human" },
                    { 746, "English Medieval", false, true, true, "Sutler", "Human" },
                    { 747, "English Medieval", false, true, true, "Taberer", "Human" },
                    { 748, "English Medieval", false, true, true, "Tapper", "Human" },
                    { 749, "English Medieval", false, true, true, "Wagstaff", "Human" },
                    { 750, "English Medieval", false, true, true, "Waine", "Human" },
                    { 751, "English Medieval", false, true, true, "Maidman", "Human" },
                    { 752, "English Medieval", false, true, true, "Mangold", "Human" },
                    { 753, "English Medieval", false, true, true, "Marner", "Human" },
                    { 754, "English Medieval", false, true, true, "Massinger", "Human" },
                    { 755, "English Medieval", false, true, true, "Mayer", "Human" },
                    { 756, "English Medieval", false, true, true, "Miller", "Human" }
                });

            migrationBuilder.InsertData(
                table: "NpcsName",
                columns: new[] { "Id", "CategoryName", "IsFirstName", "IsMale", "IsPublic", "Name", "SuitableRace" },
                values: new object[,]
                {
                    { 757, "English Medieval", false, true, true, "Milner", "Human" },
                    { 758, "English Medieval", false, true, true, "Monger", "Human" },
                    { 759, "English Medieval", false, true, true, "Page", "Human" },
                    { 760, "English Medieval", false, true, true, "Painter", "Human" },
                    { 761, "English Medieval", false, true, true, "Palmer", "Human" },
                    { 762, "English Medieval", false, true, true, "Panther", "Human" },
                    { 763, "English Medieval", false, true, true, "Pilcher", "Human" },
                    { 764, "English Medieval", false, true, true, "Plumer", "Human" },
                    { 765, "English Medieval", false, true, true, "Pottinger", "Human" },
                    { 766, "English Medieval", false, true, true, "Prince", "Human" },
                    { 767, "English Medieval", false, true, true, "Ratter", "Human" },
                    { 768, "English Medieval", false, true, true, "Reeve", "Human" },
                    { 769, "English Medieval", false, true, true, "Retter", "Human" },
                    { 770, "English Medieval", false, true, true, "Tasker", "Human" },
                    { 771, "English Medieval", false, true, true, "Tisser", "Human" },
                    { 772, "English Medieval", false, true, true, "Toller", "Human" },
                    { 773, "English Medieval", false, true, true, "Tripe", "Human" },
                    { 774, "English Medieval", false, true, true, "Trist", "Human" },
                    { 775, "English Medieval", false, true, true, "Tubman", "Human" },
                    { 776, "English Medieval", false, true, true, "Warde", "Human" },
                    { 777, "English Medieval", false, true, true, "Warner", "Human" },
                    { 778, "English Medieval", false, true, true, "Malter", "Human" },
                    { 779, "English Medieval", false, true, true, "Marbler", "Human" },
                    { 780, "English Medieval", false, true, true, "Marshall", "Human" },
                    { 781, "English Medieval", false, true, true, "Masters", "Human" },
                    { 782, "English Medieval", false, true, true, "Mercer", "Human" },
                    { 783, "English Medieval", false, true, true, "Mew", "Human" },
                    { 784, "English Medieval", false, true, true, "Millman", "Human" },
                    { 785, "English Medieval", false, true, true, "Minter", "Human" },
                    { 786, "English Medieval", false, true, true, "Paget", "Human" },
                    { 787, "English Medieval", false, true, true, "Pakeman", "Human" },
                    { 788, "English Medieval", false, true, true, "Paniers", "Human" },
                    { 789, "English Medieval", false, true, true, "Pape", "Human" },
                    { 790, "English Medieval", false, true, true, "Pillinger", "Human" },
                    { 791, "English Medieval", false, true, true, "Plummer", "Human" },
                    { 792, "English Medieval", false, true, true, "Pothecary", "Human" },
                    { 793, "English Medieval", false, true, true, "Poulter", "Human" },
                    { 794, "English Medieval", false, true, true, "Prior", "Human" },
                    { 795, "English Medieval", false, true, true, "Reader", "Human" },
                    { 796, "English Medieval", false, true, true, "Renner", "Human" },
                    { 797, "English Medieval", false, true, true, "Rider", "Human" },
                    { 798, "English Medieval", false, true, true, "Taverner", "Human" }
                });

            migrationBuilder.InsertData(
                table: "NpcsName",
                columns: new[] { "Id", "CategoryName", "IsFirstName", "IsMale", "IsPublic", "Name", "SuitableRace" },
                values: new object[,]
                {
                    { 799, "English Medieval", false, true, true, "Tinker", "Human" },
                    { 800, "English Medieval", false, true, true, "Tisserand", "Human" },
                    { 801, "English Medieval", false, true, true, "Tolman", "Human" },
                    { 802, "English Medieval", false, true, true, "Trippe", "Human" },
                    { 803, "English Medieval", false, true, true, "Trouncer", "Human" },
                    { 804, "English Medieval", false, true, true, "Tucker", "Human" },
                    { 805, "English Medieval", false, true, true, "Warden", "Human" },
                    { 806, "English Medieval", false, true, true, "Warrender", "Human" },
                    { 807, "English Medieval", false, true, true, "Adrain", "Human" },
                    { 808, "English Medieval", false, true, true, "Aldren", "Human" },
                    { 809, "English Medieval", false, true, true, "Arram", "Human" },
                    { 810, "English Medieval", false, true, true, "Attwood", "Human" },
                    { 811, "English Medieval", false, true, true, "Bail", "Human" },
                    { 812, "English Medieval", false, true, true, "Banker", "Human" },
                    { 813, "English Medieval", false, true, true, "Barrow", "Human" },
                    { 814, "English Medieval", false, true, true, "Biddick", "Human" },
                    { 815, "English Medieval", false, true, true, "Boosey", "Human" },
                    { 816, "English Medieval", false, true, true, "Bradnam", "Human" },
                    { 817, "English Medieval", false, true, true, "Brook", "Human" },
                    { 818, "English Medieval", false, true, true, "Byrom", "Human" },
                    { 819, "English Medieval", false, true, true, "Bytheway", "Human" },
                    { 820, "English Medieval", false, true, true, "Acum", "Human" },
                    { 821, "English Medieval", false, true, true, "Agate", "Human" },
                    { 822, "English Medieval", false, true, true, "Allaun", "Human" },
                    { 823, "English Medieval", false, true, true, "Applin", "Human" },
                    { 824, "English Medieval", false, true, true, "Ashmead", "Human" },
                    { 825, "English Medieval", false, true, true, "Atthill", "Human" },
                    { 826, "English Medieval", false, true, true, "Attwell", "Human" },
                    { 827, "English Medieval", false, true, true, "Bankes", "Human" },
                    { 828, "English Medieval", false, true, true, "Barry", "Human" },
                    { 829, "English Medieval", false, true, true, "Bolam", "Human" },
                    { 830, "English Medieval", false, true, true, "Bratcher", "Human" },
                    { 831, "English Medieval", false, true, true, "Brooker", "Human" },
                    { 832, "English Medieval", false, true, true, "Bywater", "Human" },
                    { 833, "English Medieval", false, true, true, "Adeane", "Human" },
                    { 834, "English Medieval", false, true, true, "Agutter", "Human" },
                    { 835, "English Medieval", false, true, true, "Applegarth", "Human" },
                    { 836, "English Medieval", false, true, true, "Armitage", "Human" },
                    { 837, "English Medieval", false, true, true, "Attley", "Human" },
                    { 838, "English Medieval", false, true, true, "Attwick", "Human" },
                    { 839, "English Medieval", false, true, true, "Atyeo", "Human" },
                    { 840, "English Medieval", false, true, true, "Banfield", "Human" }
                });

            migrationBuilder.InsertData(
                table: "NpcsName",
                columns: new[] { "Id", "CategoryName", "IsFirstName", "IsMale", "IsPublic", "Name", "SuitableRace" },
                values: new object[,]
                {
                    { 841, "English Medieval", false, true, true, "Banks", "Human" },
                    { 842, "English Medieval", false, true, true, "Bencroft", "Human" },
                    { 843, "English Medieval", false, true, true, "Binks", "Human" },
                    { 844, "English Medieval", false, true, true, "Bollom", "Human" },
                    { 845, "English Medieval", false, true, true, "Bowley", "Human" },
                    { 846, "English Medieval", false, true, true, "Bridge", "Human" },
                    { 847, "English Medieval", false, true, true, "Bullpen", "Human" },
                    { 848, "English Medieval", false, true, true, "Bythesea", "Human" },
                    { 849, "English Medieval", false, true, true, "Bywood", "Human" },
                    { 850, "English Medieval", false, true, true, "Capel", "Human" },
                    { 851, "English Medieval", false, true, true, "Chapel", "Human" },
                    { 852, "English Medieval", false, true, true, "Cottam", "Human" },
                    { 853, "English Medieval", false, true, true, "Dashwood", "Human" },
                    { 854, "English Medieval", false, true, true, "DeLaMere", "Human" },
                    { 855, "English Medieval", false, true, true, "Delbridge", "Human" },
                    { 856, "English Medieval", false, true, true, "Dubois", "Human" },
                    { 857, "English Medieval", false, true, true, "Fenner", "Human" },
                    { 858, "English Medieval", false, true, true, "Flasher", "Human" },
                    { 859, "English Medieval", false, true, true, "Ford", "Human" },
                    { 860, "English Medieval", false, true, true, "Hall", "Human" },
                    { 861, "English Medieval", false, true, true, "Hayes", "Human" },
                    { 862, "English Medieval", false, true, true, "Hillam", "Human" },
                    { 863, "English Medieval", false, true, true, "Hotham", "Human" },
                    { 864, "English Medieval", false, true, true, "Kirk", "Human" },
                    { 865, "English Medieval", false, true, true, "Lascelles", "Human" },
                    { 866, "English Medieval", false, true, true, "Castle", "Human" },
                    { 867, "English Medieval", false, true, true, "Court", "Human" },
                    { 868, "English Medieval", false, true, true, "Damerell", "Human" },
                    { 869, "English Medieval", false, true, true, "Deller", "Human" },
                    { 870, "English Medieval", false, true, true, "East", "Human" },
                    { 871, "English Medieval", false, true, true, "Fielder", "Human" },
                    { 872, "English Medieval", false, true, true, "Flashman", "Human" },
                    { 873, "English Medieval", false, true, true, "Forder", "Human" },
                    { 874, "English Medieval", false, true, true, "Greaves", "Human" },
                    { 875, "English Medieval", false, true, true, "Haslam", "Human" },
                    { 876, "English Medieval", false, true, true, "Headlam", "Human" },
                    { 877, "English Medieval", false, true, true, "Hinton", "Human" },
                    { 878, "English Medieval", false, true, true, "Jardine", "Human" },
                    { 879, "English Medieval", false, true, true, "Lea", "Human" },
                    { 880, "English Medieval", false, true, true, "Chalk", "Human" },
                    { 881, "English Medieval", false, true, true, "Dale", "Human" },
                    { 882, "English Medieval", false, true, true, "Dash", "Human" }
                });

            migrationBuilder.InsertData(
                table: "NpcsName",
                columns: new[] { "Id", "CategoryName", "IsFirstName", "IsMale", "IsPublic", "Name", "SuitableRace" },
                values: new object[,]
                {
                    { 883, "English Medieval", false, true, true, "Stather", "Human" },
                    { 884, "English Medieval", false, true, true, "Vine", "Human" },
                    { 885, "English Medieval", false, true, true, "Delafield", "Human" },
                    { 886, "English Medieval", false, true, true, "Streeter", "Human" },
                    { 887, "English Medieval", false, true, true, "Welles", "Human" },
                    { 888, "English Medieval", false, true, true, "Denman", "Human" },
                    { 889, "English Medieval", false, true, true, "Towers", "Human" },
                    { 890, "English Medieval", false, true, true, "Whitney", "Human" },
                    { 891, "English Medieval", false, true, true, "Fell", "Human" },
                    { 892, "English Medieval", false, true, true, "Underhill", "Human" },
                    { 893, "English Medieval", false, true, true, "Willen", "Human" },
                    { 894, "English Medieval", false, true, true, "Fielding", "Human" },
                    { 895, "English Medieval", false, true, true, "Vale", "Human" },
                    { 896, "English Medieval", false, true, true, "Woods", "Human" },
                    { 897, "English Medieval", false, true, true, "Flatman", "Human" },
                    { 898, "English Medieval", false, true, true, "Welham", "Human" },
                    { 899, "English Medieval", false, true, true, "Gardham", "Human" },
                    { 900, "English Medieval", false, true, true, "West", "Human" },
                    { 901, "English Medieval", false, true, true, "Grover", "Human" },
                    { 902, "English Medieval", false, true, true, "Wicker", "Human" },
                    { 903, "English Medieval", false, true, true, "Hatcher", "Human" },
                    { 904, "English Medieval", false, true, true, "Wood", "Human" },
                    { 905, "English Medieval", false, true, true, "Hilder", "Human" },
                    { 906, "English Medieval", false, true, true, "Stickler", "Human" },
                    { 907, "English Medieval", false, true, true, "Holman", "Human" },
                    { 908, "English Medieval", false, true, true, "Toner", "Human" },
                    { 909, "English Medieval", false, true, true, "Kelham", "Human" },
                    { 910, "English Medieval", false, true, true, "Townsend", "Human" },
                    { 911, "English Medieval", false, true, true, "Lakeman", "Human" },
                    { 912, "English Medieval", false, true, true, "Underwood", "Human" },
                    { 913, "English Medieval", false, true, true, "Legh", "Human" },
                    { 914, "English Medieval", false, true, true, "Waller", "Human" },
                    { 915, "English Medieval", false, true, true, "Statham", "Human" },
                    { 916, "English Medieval", false, true, true, "Wellman", "Human" },
                    { 917, "English Medieval", false, true, true, "Stokes", "Human" },
                    { 918, "English Medieval", false, true, true, "Wicken", "Human" },
                    { 919, "English Medieval", false, true, true, "Topper", "Human" },
                    { 920, "English Medieval", false, true, true, "Willows", "Human" },
                    { 921, "English Medieval", false, true, true, "Troake", "Human" },
                    { 922, "English Medieval", false, true, true, "Wylam", "Human" },
                    { 923, "Nordic", true, true, true, "Ake", "Human" },
                    { 924, "Nordic", true, true, true, "Anwend", "Human" }
                });

            migrationBuilder.InsertData(
                table: "NpcsName",
                columns: new[] { "Id", "CategoryName", "IsFirstName", "IsMale", "IsPublic", "Name", "SuitableRace" },
                values: new object[,]
                {
                    { 925, "Nordic", true, true, true, "Asbjorn", "Human" },
                    { 926, "Nordic", true, true, true, "Aslak", "Human" },
                    { 927, "Nordic", true, true, true, "Asgot", "Human" },
                    { 928, "Nordic", true, true, true, "Asser", "Human" },
                    { 929, "Nordic", true, true, true, "Asvald", "Human" },
                    { 930, "Nordic", true, true, true, "Asved", "Human" },
                    { 931, "Nordic", true, true, true, "Bjarni", "Human" },
                    { 932, "Nordic", true, true, true, "Bjorn", "Human" },
                    { 933, "Nordic", true, true, true, "Brand", "Human" },
                    { 934, "Nordic", true, true, true, "Brandr", "Human" },
                    { 935, "Nordic", true, true, true, "Cnut", "Human" },
                    { 936, "Nordic", true, true, true, "Einar", "Human" },
                    { 937, "Nordic", true, true, true, "Ejulf", "Human" },
                    { 938, "Nordic", true, true, true, "Erik", "Human" },
                    { 939, "Nordic", true, true, true, "Eirik", "Human" },
                    { 940, "Nordic", true, true, true, "Finnbogi", "Human" },
                    { 941, "Nordic", true, true, true, "Floki", "Human" },
                    { 942, "Nordic", true, true, true, "Fridrek", "Human" },
                    { 943, "Nordic", true, true, true, "Frodi", "Human" },
                    { 944, "Nordic", true, true, true, "Gamli", "Human" },
                    { 945, "Nordic", true, true, true, "Gardi", "Human" },
                    { 946, "Nordic", true, true, true, "Geirstein", "Human" },
                    { 947, "Nordic", true, true, true, "Grim", "Human" },
                    { 948, "Nordic", true, true, true, "Gudmund", "Human" },
                    { 949, "Nordic", true, true, true, "Gunnvor", "Human" },
                    { 950, "Nordic", true, true, true, "Hafgrim", "Human" },
                    { 951, "Nordic", true, true, true, "Hakon", "Human" },
                    { 952, "Nordic", true, true, true, "Halfdan", "Human" },
                    { 953, "Nordic", true, true, true, "Hallad", "Human" },
                    { 954, "Nordic", true, true, true, "Harald", "Human" },
                    { 955, "Nordic", true, true, true, "Helgi", "Human" },
                    { 956, "Nordic", true, true, true, "Herjolf", "Human" },
                    { 957, "Nordic", true, true, true, "Hove", "Human" },
                    { 958, "Nordic", true, true, true, "Hrafn", "Human" },
                    { 959, "Nordic", true, true, true, "Hrolf", "Human" },
                    { 960, "Nordic", true, true, true, "Hrollaug", "Human" },
                    { 961, "Nordic", true, true, true, "Illugi", "Human" },
                    { 962, "Nordic", true, true, true, "Ingjald", "Human" },
                    { 963, "Nordic", true, true, true, "Ingolf", "Human" },
                    { 964, "Nordic", true, true, true, "Isleif", "Human" },
                    { 965, "Nordic", true, true, true, "Ivar", "Human" },
                    { 966, "Nordic", true, true, true, "Ketil", "Human" }
                });

            migrationBuilder.InsertData(
                table: "NpcsName",
                columns: new[] { "Id", "CategoryName", "IsFirstName", "IsMale", "IsPublic", "Name", "SuitableRace" },
                values: new object[,]
                {
                    { 967, "Nordic", true, true, true, "Knud", "Human" },
                    { 968, "Nordic", true, true, true, "Leif", "Human" },
                    { 969, "Nordic", true, true, true, "Manne", "Human" },
                    { 970, "Nordic", true, true, true, "Njal", "Human" },
                    { 971, "Nordic", true, true, true, "Odd", "Human" },
                    { 972, "Nordic", true, true, true, "Olaf", "Human" },
                    { 973, "Nordic", true, true, true, "Olav", "Human" },
                    { 974, "Nordic", true, true, true, "Orm", "Human" },
                    { 975, "Nordic", true, true, true, "Pallig", "Human" },
                    { 976, "Nordic", true, true, true, "Ragnar", "Human" },
                    { 977, "Nordic", true, true, true, "Rognvald", "Human" },
                    { 978, "Nordic", true, true, true, "Rolf", "Human" },
                    { 979, "Nordic", true, true, true, "Runolf", "Human" },
                    { 980, "Nordic", true, true, true, "Sakse", "Human" },
                    { 981, "Nordic", true, true, true, "Solvi", "Human" },
                    { 982, "Nordic", true, true, true, "Styr", "Human" },
                    { 983, "Nordic", true, true, true, "Svein", "Human" },
                    { 984, "Nordic", true, true, true, "Svend", "Human" },
                    { 985, "Nordic", true, true, true, "Thorbrand", "Human" },
                    { 986, "Nordic", true, true, true, "Thord", "Human" },
                    { 987, "Nordic", true, true, true, "Toste", "Human" },
                    { 988, "Nordic", true, true, true, "Tyrkir", "Human" },
                    { 989, "Nordic", true, true, true, "Ulf", "Human" },
                    { 990, "Nordic", true, true, true, "Vifil", "Human" },
                    { 991, "Nordic", true, false, true, "Arnora", "Human" },
                    { 992, "Nordic", true, false, true, "Ase", "Human" },
                    { 993, "Nordic", true, false, true, "Astrid", "Human" },
                    { 994, "Nordic", true, false, true, "Aud", "Human" },
                    { 995, "Nordic", true, false, true, "Estrid", "Human" },
                    { 996, "Nordic", true, false, true, "Fastvi", "Human" },
                    { 997, "Nordic", true, false, true, "Freydis", "Human" },
                    { 998, "Nordic", true, false, true, "Grimhild", "Human" },
                    { 999, "Nordic", true, false, true, "Groa", "Human" },
                    { 1000, "Nordic", true, false, true, "Gudrid", "Human" },
                    { 1001, "Nordic", true, false, true, "Gudrun", "Human" },
                    { 1002, "Nordic", true, false, true, "Gunhild", "Human" },
                    { 1003, "Nordic", true, false, true, "Halldis", "Human" },
                    { 1004, "Nordic", true, false, true, "Hallfrid", "Human" },
                    { 1005, "Nordic", true, false, true, "Hallveig", "Human" },
                    { 1006, "Nordic", true, false, true, "Hekja", "Human" },
                    { 1007, "Nordic", true, false, true, "Jorunn", "Human" },
                    { 1008, "Nordic", true, false, true, "Kolfinna", "Human" }
                });

            migrationBuilder.InsertData(
                table: "NpcsName",
                columns: new[] { "Id", "CategoryName", "IsFirstName", "IsMale", "IsPublic", "Name", "SuitableRace" },
                values: new object[,]
                {
                    { 1009, "Nordic", true, false, true, "Kolgrima", "Human" },
                    { 1010, "Nordic", true, false, true, "Odindisa", "Human" },
                    { 1011, "Nordic", true, false, true, "Ragnhild", "Human" },
                    { 1012, "Nordic", true, false, true, "Sigrid", "Human" },
                    { 1013, "Nordic", true, false, true, "Thora", "Human" },
                    { 1014, "Nordic", true, false, true, "Thurid", "Human" },
                    { 1015, "Nordic", true, false, true, "Thyre", "Human" },
                    { 1016, "Nordic", true, false, true, "Tola", "Human" },
                    { 1017, "Nordic", true, false, true, "Tove", "Human" },
                    { 1018, "Nordic", true, false, true, "Viborg", "Human" },
                    { 1019, "Fantasy", true, true, true, "Sirius", "Human" },
                    { 1020, "Fantasy", true, true, true, "Darius", "Human" },
                    { 1021, "Fantasy", true, true, true, "Adair", "Human" },
                    { 1022, "Fantasy", true, true, true, "Destin", "Human" },
                    { 1023, "Fantasy", true, true, true, "Tavish", "Human" },
                    { 1024, "Fantasy", true, true, true, "Lucien", "Human" },
                    { 1025, "Fantasy", true, true, true, "Drake", "Human" },
                    { 1026, "Fantasy", true, true, true, "Adriel", "Human" },
                    { 1027, "Fantasy", true, true, true, "Katriel", "Human" },
                    { 1028, "Fantasy", true, true, true, "Drystan", "Human" },
                    { 1029, "Fantasy", true, true, true, "Tearlach", "Human" },
                    { 1030, "Fantasy", true, true, true, "Marius", "Human" },
                    { 1031, "Fantasy", true, true, true, "Eirian", "Human" },
                    { 1032, "Fantasy", true, true, true, "Mathieu", "Human" },
                    { 1033, "Fantasy", true, true, true, "Altair", "Human" },
                    { 1034, "Fantasy", true, true, true, "Liron", "Human" },
                    { 1035, "Fantasy", true, true, true, "Torian", "Human" },
                    { 1036, "Fantasy", true, true, true, "Torin", "Human" },
                    { 1037, "Fantasy", true, true, true, "Fineas", "Human" },
                    { 1038, "Fantasy", true, true, true, "Neirin", "Human" },
                    { 1039, "Fantasy", true, true, true, "Nerys", "Human" },
                    { 1040, "Fantasy", true, true, true, "Finian", "Human" },
                    { 1041, "Fantasy", true, true, true, "Nyfain", "Human" },
                    { 1042, "Fantasy", true, true, true, "Fyodor", "Human" },
                    { 1043, "Fantasy", true, true, true, "Gareth", "Human" },
                    { 1044, "Fantasy", true, true, true, "Arianwen", "Human" },
                    { 1045, "Fantasy", true, true, true, "Urien", "Human" },
                    { 1046, "Fantasy", true, true, true, "Oisin", "Human" },
                    { 1047, "Fantasy", true, true, true, "Gavriel", "Human" },
                    { 1048, "Fantasy", true, true, true, "Pryderi", "Human" },
                    { 1049, "Fantasy", true, true, true, "Griffin", "Human" },
                    { 1050, "Fantasy", true, true, true, "Aurelian", "Human" }
                });

            migrationBuilder.InsertData(
                table: "NpcsName",
                columns: new[] { "Id", "CategoryName", "IsFirstName", "IsMale", "IsPublic", "Name", "SuitableRace" },
                values: new object[,]
                {
                    { 1051, "Fantasy", true, true, true, "Orion", "Human" },
                    { 1052, "Fantasy", true, true, true, "Aurelius", "Human" },
                    { 1053, "Fantasy", true, true, true, "Xanthus", "Human" },
                    { 1054, "Fantasy", true, true, true, "Orpheus", "Human" },
                    { 1055, "Fantasy", true, true, true, "Bastian", "Human" },
                    { 1056, "Fantasy", true, true, true, "Hesperos", "Human" },
                    { 1057, "Fantasy", true, true, true, "Serian", "Human" },
                    { 1058, "Fantasy", true, true, true, "Perseus", "Human" },
                    { 1059, "Fantasy", true, true, true, "Iagan", "Human" },
                    { 1060, "Fantasy", true, true, true, "Severin", "Human" },
                    { 1061, "Fantasy", true, true, true, "Ianthe", "Human" },
                    { 1062, "Fantasy", true, true, true, "Zorion", "Human" },
                    { 1063, "Fantasy", true, true, true, "Phelan", "Human" },
                    { 1064, "Fantasy", true, true, true, "Carys", "Human" },
                    { 1065, "Fantasy", true, true, true, "Vasilis", "Human" },
                    { 1066, "Fantasy", true, true, true, "Ignatius", "Human" },
                    { 1067, "Fantasy", true, true, true, "Caspian", "Human" },
                    { 1068, "Fantasy", true, true, true, "Cassiel", "Human" },
                    { 1069, "Fantasy", true, true, true, "Briallan", "Human" },
                    { 1070, "Fantasy", true, true, true, "Remus", "Human" },
                    { 1071, "Fantasy", true, true, true, "Briseis", "Human" },
                    { 1072, "Fantasy", true, true, true, "Cassius", "Human" },
                    { 1073, "Fantasy", true, true, true, "Dagen", "Human" },
                    { 1074, "Fantasy", true, true, true, "Rhydderch", "Human" },
                    { 1075, "Fantasy", true, true, true, "Devlin", "Human" },
                    { 1076, "Fantasy", true, true, true, "Korbin", "Human" },
                    { 1077, "Fantasy", true, true, true, "Kyler", "Human" },
                    { 1078, "Fantasy", true, true, true, "Corbin", "Human" },
                    { 1079, "Fantasy", true, true, true, "Eliron", "Human" },
                    { 1080, "Fantasy", true, true, true, "Cyprian", "Human" },
                    { 1081, "Fantasy", true, true, true, "Sebastian", "Human" },
                    { 1082, "Fantasy", true, true, true, "Seraphim", "Human" },
                    { 1083, "Fantasy", true, true, true, "Zarek", "Human" },
                    { 1084, "Fantasy", true, true, true, "Yestin", "Human" },
                    { 1085, "Fantasy", true, true, true, "Arton", "Human" },
                    { 1086, "Fantasy", true, true, true, "Logon", "Human" },
                    { 1087, "Fantasy", true, true, true, "Astar", "Human" },
                    { 1088, "Fantasy", true, true, true, "Melo", "Human" },
                    { 1089, "Fantasy", true, true, true, "Atheo", "Human" },
                    { 1090, "Fantasy", true, true, true, "Mindon", "Human" },
                    { 1091, "Fantasy", true, true, true, "Baron", "Human" },
                    { 1092, "Fantasy", true, true, true, "Miro", "Human" }
                });

            migrationBuilder.InsertData(
                table: "NpcsName",
                columns: new[] { "Id", "CategoryName", "IsFirstName", "IsMale", "IsPublic", "Name", "SuitableRace" },
                values: new object[,]
                {
                    { 1093, "Fantasy", true, true, true, "Beren", "Human" },
                    { 1094, "Fantasy", true, true, true, "Orion", "Human" },
                    { 1095, "Fantasy", true, true, true, "Callon", "Human" },
                    { 1096, "Fantasy", true, true, true, "Poldo", "Human" },
                    { 1097, "Fantasy", true, true, true, "Cevon", "Human" },
                    { 1098, "Fantasy", true, true, true, "Rion", "Human" },
                    { 1099, "Fantasy", true, true, true, "Dorion", "Human" },
                    { 1100, "Fantasy", true, true, true, "Romon", "Human" },
                    { 1101, "Fantasy", true, true, true, "Fion", "Human" },
                    { 1102, "Fantasy", true, true, true, "Russo", "Human" },
                    { 1103, "Fantasy", true, true, true, "Gil", "Human" },
                    { 1104, "Fantasy", true, true, true, "Teren", "Human" },
                    { 1105, "Fantasy", true, true, true, "Iston", "Human" },
                    { 1106, "Fantasy", true, true, true, "Varand", "Human" },
                    { 1107, "Fantasy", true, true, true, "Leo", "Human" },
                    { 1108, "Fantasy", true, true, true, "Veo", "Human" },
                    { 1109, "Fantasy", true, true, true, "Elfarran", "Human" },
                    { 1110, "Fantasy", true, true, true, "Losen", "Human" },
                    { 1111, "Fantasy", true, true, true, "Akbe", "Human" },
                    { 1112, "Fantasy", true, true, true, "Alder", "Human" },
                    { 1113, "Fantasy", true, true, true, "Akaren", "Human" },
                    { 1114, "Fantasy", true, true, true, "Elt", "Human" },
                    { 1115, "Fantasy", true, true, true, "Heather", "Human" },
                    { 1116, "Fantasy", true, true, true, "Maharion", "Human" },
                    { 1117, "Fantasy", true, true, true, "Rowan", "Human" },
                    { 1118, "Fantasy", true, true, true, "Embar", "Human" },
                    { 1119, "Fantasy", true, true, true, "Apple", "Human" },
                    { 1120, "Fantasy", true, true, true, "Emer", "Human" },
                    { 1121, "Fantasy", true, true, true, "Heleth", "Human" },
                    { 1122, "Fantasy", true, true, true, "Manan", "Human" },
                    { 1123, "Fantasy", true, true, true, "Seppel", "Human" },
                    { 1124, "Fantasy", true, true, true, "Irian", "Human" },
                    { 1125, "Fantasy", true, true, true, "Arha", "Human" },
                    { 1126, "Fantasy", true, true, true, "Ard", "Human" },
                    { 1127, "Fantasy", true, true, true, "Ennas", "Human" },
                    { 1128, "Fantasy", true, true, true, "Highdrake", "Human" },
                    { 1129, "Fantasy", true, true, true, "Mebbeth", "Human" },
                    { 1130, "Fantasy", true, true, true, "Serrathen", "Human" },
                    { 1131, "Fantasy", true, true, true, "Arren", "Human" },
                    { 1132, "Fantasy", true, true, true, "Erisen", "Human" },
                    { 1133, "Fantasy", true, true, true, "Hound", "Human" },
                    { 1134, "Fantasy", true, true, true, "Mead", "Human" }
                });

            migrationBuilder.InsertData(
                table: "NpcsName",
                columns: new[] { "Id", "CategoryName", "IsFirstName", "IsMale", "IsPublic", "Name", "SuitableRace" },
                values: new object[,]
                {
                    { 1135, "Fantasy", true, true, true, "Serret", "Human" },
                    { 1136, "Fantasy", true, true, true, "Moss", "Human" },
                    { 1137, "Fantasy", true, true, true, "Aspen", "Human" },
                    { 1138, "Fantasy", true, true, true, "Ayeth", "Human" },
                    { 1139, "Fantasy", true, true, true, "Erreth", "Human" },
                    { 1140, "Fantasy", true, true, true, "Ioeth", "Human" },
                    { 1141, "Fantasy", true, true, true, "Ayo", "Human" },
                    { 1142, "Fantasy", true, true, true, "Irian", "Human" },
                    { 1143, "Fantasy", true, true, true, "Mevre", "Human" },
                    { 1144, "Fantasy", true, true, true, "Otak", "Human" },
                    { 1145, "Fantasy", true, true, true, "Azver", "Human" },
                    { 1146, "Fantasy", true, true, true, "Morred", "Human" },
                    { 1147, "Fantasy", true, true, true, "Flint", "Human" },
                    { 1148, "Fantasy", true, true, true, "Sopli", "Human" },
                    { 1149, "Fantasy", true, true, true, "Early", "Human" },
                    { 1150, "Fantasy", true, true, true, "Jasper", "Human" },
                    { 1151, "Fantasy", true, true, true, "Brand", "Human" },
                    { 1152, "Fantasy", true, true, true, "Tuly", "Human" },
                    { 1153, "Fantasy", true, true, true, "Kest", "Human" },
                    { 1154, "Fantasy", true, true, true, "Tenar", "Human" },
                    { 1155, "Fantasy", true, true, true, "Teriel", "Human" },
                    { 1156, "Fantasy", true, true, true, "Lark", "Human" },
                    { 1157, "Fantasy", true, true, true, "Thar", "Human" },
                    { 1158, "Fantasy", true, true, true, "Gully", "Human" },
                    { 1159, "Fantasy", true, true, true, "Adair", "Human" },
                    { 1160, "Fantasy", true, true, true, "Aonghus", "Human" },
                    { 1161, "Fantasy", true, true, true, "Ahern", "Human" },
                    { 1162, "Fantasy", true, true, true, "Amargain", "Human" },
                    { 1163, "Fantasy", true, true, true, "Brogan", "Human" },
                    { 1164, "Fantasy", true, true, true, "Barram", "Human" },
                    { 1165, "Fantasy", true, true, true, "Bearach", "Human" },
                    { 1166, "Fantasy", true, true, true, "Bran", "Human" },
                    { 1167, "Fantasy", true, true, true, "Cahan", "Human" },
                    { 1168, "Fantasy", true, true, true, "Calbhach", "Human" },
                    { 1169, "Fantasy", true, true, true, "Chullain", "Human" },
                    { 1170, "Fantasy", true, true, true, "Aodh", "Human" },
                    { 1171, "Fantasy", true, true, true, "Connacht", "Human" },
                    { 1172, "Fantasy", true, true, true, "Cael", "Human" },
                    { 1173, "Fantasy", true, true, true, "Cormac", "Human" },
                    { 1174, "Fantasy", true, true, true, "Cruaidh", "Human" },
                    { 1175, "Fantasy", true, true, true, "Daigh", "Human" },
                    { 1176, "Fantasy", true, true, true, "Dearg", "Human" }
                });

            migrationBuilder.InsertData(
                table: "NpcsName",
                columns: new[] { "Id", "CategoryName", "IsFirstName", "IsMale", "IsPublic", "Name", "SuitableRace" },
                values: new object[,]
                {
                    { 1177, "Fantasy", true, true, true, "Doon", "Human" },
                    { 1178, "Fantasy", true, true, true, "Domnall", "Human" },
                    { 1179, "Fantasy", true, true, true, "Eachan", "Human" },
                    { 1180, "Fantasy", true, true, true, "Eithriall", "Human" },
                    { 1181, "Fantasy", true, true, true, "Eamha", "Human" },
                    { 1182, "Fantasy", true, true, true, "Eremon", "Human" },
                    { 1183, "Fantasy", true, true, true, "Culann", "Human" },
                    { 1184, "Fantasy", true, true, true, "Fionn", "Human" },
                    { 1185, "Fantasy", true, true, true, "Curaidh", "Human" },
                    { 1186, "Fantasy", true, true, true, "Fechine", "Human" },
                    { 1187, "Fantasy", true, true, true, "Gaer", "Human" },
                    { 1188, "Fantasy", true, true, true, "Giall", "Human" },
                    { 1189, "Fantasy", true, true, true, "Bain", "Human" },
                    { 1190, "Fantasy", true, true, true, "Gillean", "Human" },
                    { 1191, "Fantasy", true, true, true, "Donal", "Human" },
                    { 1192, "Fantasy", true, true, true, "Imar", "Human" },
                    { 1193, "Fantasy", true, true, true, "Iuchar", "Human" },
                    { 1194, "Fantasy", true, true, true, "Dubaltach", "Human" },
                    { 1195, "Fantasy", true, true, true, "Kern", "Human" },
                    { 1196, "Fantasy", true, true, true, "Keallach", "Human" },
                    { 1197, "Fantasy", true, true, true, "Keelan", "Human" },
                    { 1198, "Fantasy", true, true, true, "Kennet", "Human" },
                    { 1199, "Fantasy", true, true, true, "Kenyon", "Human" },
                    { 1200, "Fantasy", true, true, true, "Lorcan", "Human" },
                    { 1201, "Fantasy", true, true, true, "Murchad", "Human" },
                    { 1202, "Fantasy", true, true, true, "Lochlainn", "Human" },
                    { 1203, "Fantasy", true, true, true, "Lunn", "Human" },
                    { 1204, "Fantasy", true, true, true, "Malachy", "Human" },
                    { 1205, "Fantasy", true, true, true, "Manus", "Human" },
                    { 1206, "Fantasy", true, true, true, "Marcan", "Human" },
                    { 1207, "Fantasy", true, true, true, "Mellan", "Human" },
                    { 1208, "Fantasy", true, true, true, "Morann", "Human" },
                    { 1209, "Fantasy", true, true, true, "Tormey", "Human" },
                    { 1210, "Fantasy", true, true, true, "Nechtan", "Human" },
                    { 1211, "Fantasy", true, true, true, "Eion", "Human" },
                    { 1212, "Fantasy", true, true, true, "Patraic", "Human" },
                    { 1213, "Fantasy", true, true, true, "Phelan", "Human" },
                    { 1214, "Fantasy", true, true, true, "Ronan", "Human" },
                    { 1215, "Fantasy", true, true, true, "Conaldar", "Human" },
                    { 1216, "Fantasy", true, true, true, "Nemghan", "Human" },
                    { 1217, "Fantasy", true, true, true, "Ruarc", "Human" },
                    { 1218, "Fantasy", true, true, true, "Ragallach", "Human" }
                });

            migrationBuilder.InsertData(
                table: "NpcsName",
                columns: new[] { "Id", "CategoryName", "IsFirstName", "IsMale", "IsPublic", "Name", "SuitableRace" },
                values: new object[,]
                {
                    { 1219, "Fantasy", true, true, true, "Regan", "Human" },
                    { 1220, "Fantasy", true, true, true, "Scanlon", "Human" },
                    { 1221, "Fantasy", true, true, true, "Sualtam", "Human" },
                    { 1222, "Fantasy", true, true, true, "Sithchean", "Human" },
                    { 1223, "Fantasy", true, true, true, "Sloan", "Human" },
                    { 1224, "Fantasy", true, true, true, "Tarlach", "Human" },
                    { 1225, "Fantasy", true, true, true, "Riddoc", "Human" },
                    { 1226, "Fantasy", true, true, true, "Tiarnahn", "Human" },
                    { 1227, "Fantasy", true, true, true, "Rafer", "Human" },
                    { 1228, "Fantasy", true, true, true, "Cul", "Human" },
                    { 1229, "Fantasy", true, true, true, "Conchobar", "Human" },
                    { 1230, "Fantasy", true, true, true, "Conleth", "Human" },
                    { 1231, "Fantasy", true, true, true, "Tuathal", "Human" },
                    { 1232, "Fantasy", true, true, true, "Andrion", "Human" },
                    { 1233, "Fantasy", true, true, true, "Anguis", "Human" },
                    { 1234, "Fantasy", true, true, true, "Arpello", "Human" },
                    { 1235, "Fantasy", true, true, true, "Arctos", "Human" },
                    { 1236, "Fantasy", true, true, true, "Atabulus", "Human" },
                    { 1237, "Fantasy", true, true, true, "Araris", "Human" },
                    { 1238, "Fantasy", true, true, true, "Attalus", "Human" },
                    { 1239, "Fantasy", true, true, true, "Attelius", "Human" },
                    { 1240, "Fantasy", true, true, true, "Aufidus", "Human" },
                    { 1241, "Fantasy", true, true, true, "Calleo", "Human" },
                    { 1242, "Fantasy", true, true, true, "Baraccus", "Human" },
                    { 1243, "Fantasy", true, true, true, "Barras", "Human" },
                    { 1244, "Fantasy", true, true, true, "Cladian", "Human" },
                    { 1245, "Fantasy", true, true, true, "Damon", "Human" },
                    { 1246, "Fantasy", true, true, true, "Glacus", "Human" },
                    { 1247, "Fantasy", true, true, true, "Dardanus", "Human" },
                    { 1248, "Fantasy", true, true, true, "Decualion", "Human" },
                    { 1249, "Fantasy", true, true, true, "Drago", "Human" },
                    { 1250, "Fantasy", true, true, true, "Achaeus", "Human" },
                    { 1251, "Fantasy", true, true, true, "Edric", "Human" },
                    { 1252, "Fantasy", true, true, true, "Dexitheus", "Human" },
                    { 1253, "Fantasy", true, true, true, "Dion", "Human" },
                    { 1254, "Fantasy", true, true, true, "Eligius", "Human" },
                    { 1255, "Fantasy", true, true, true, "Hilarion", "Human" },
                    { 1256, "Fantasy", true, true, true, "Gratian", "Human" },
                    { 1257, "Fantasy", true, true, true, "Iphis", "Human" },
                    { 1258, "Fantasy", true, true, true, "Horatius", "Human" },
                    { 1259, "Fantasy", true, true, true, "Ilus", "Human" },
                    { 1260, "Fantasy", true, true, true, "Inachus", "Human" }
                });

            migrationBuilder.InsertData(
                table: "NpcsName",
                columns: new[] { "Id", "CategoryName", "IsFirstName", "IsMale", "IsPublic", "Name", "SuitableRace" },
                values: new object[,]
                {
                    { 1261, "Fantasy", true, true, true, "Ilius", "Human" },
                    { 1262, "Fantasy", true, true, true, "Kester", "Human" },
                    { 1263, "Fantasy", true, true, true, "Kostas", "Human" },
                    { 1264, "Fantasy", true, true, true, "Krelis", "Human" },
                    { 1265, "Fantasy", true, true, true, "Lares", "Human" },
                    { 1266, "Fantasy", true, true, true, "Laudalino", "Human" },
                    { 1267, "Fantasy", true, true, true, "Leonidos", "Human" },
                    { 1268, "Fantasy", true, true, true, "Lorimer", "Human" },
                    { 1269, "Fantasy", true, true, true, "Epeus", "Human" },
                    { 1270, "Fantasy", true, true, true, "Mezentius", "Human" },
                    { 1271, "Fantasy", true, true, true, "Modestus", "Human" },
                    { 1272, "Fantasy", true, true, true, "Nereus", "Human" },
                    { 1273, "Fantasy", true, true, true, "Emilius", "Human" },
                    { 1274, "Fantasy", true, true, true, "Mercer", "Human" },
                    { 1275, "Fantasy", true, true, true, "Valerius", "Human" },
                    { 1276, "Fantasy", true, true, true, "Nolio", "Human" },
                    { 1277, "Fantasy", true, true, true, "Octavian", "Human" },
                    { 1278, "Fantasy", true, true, true, "Orastes", "Human" },
                    { 1279, "Fantasy", true, true, true, "Liber", "Human" },
                    { 1280, "Fantasy", true, true, true, "Parnassus", "Human" },
                    { 1281, "Fantasy", true, true, true, "Sura", "Human" },
                    { 1282, "Fantasy", true, true, true, "Metabus", "Human" },
                    { 1283, "Fantasy", true, true, true, "Periphetes", "Human" },
                    { 1284, "Fantasy", true, true, true, "Rigello", "Human" },
                    { 1285, "Fantasy", true, true, true, "Thorus", "Human" },
                    { 1286, "Fantasy", true, true, true, "Tiberias", "Human" },
                    { 1287, "Fantasy", true, true, true, "Tiberio", "Human" },
                    { 1288, "Fantasy", true, true, true, "Trocero", "Human" },
                    { 1289, "Fantasy", true, true, true, "Guilaime", "Human" },
                    { 1290, "Fantasy", true, true, true, "Valannus", "Human" },
                    { 1291, "Fantasy", true, true, true, "Marinos", "Human" },
                    { 1292, "Fantasy", true, true, true, "Victorin", "Human" },
                    { 1293, "Fantasy", true, true, true, "Tulio", "Human" },
                    { 1294, "Fantasy", true, true, true, "Zetus", "Human" },
                    { 1295, "Fantasy", true, true, true, "Zorian", "Human" },
                    { 1296, "Fantasy", true, true, true, "Pallantides", "Human" },
                    { 1297, "Fantasy", true, true, true, "Vilerus", "Human" },
                    { 1298, "Fantasy", true, true, true, "Volmana", "Human" },
                    { 1299, "Fantasy", true, true, true, "Aegon", "Human" },
                    { 1300, "Fantasy", true, true, true, "Borros", "Human" },
                    { 1301, "Fantasy", true, true, true, "Drennan", "Human" },
                    { 1302, "Fantasy", true, true, true, "Glendon", "Human" }
                });

            migrationBuilder.InsertData(
                table: "NpcsName",
                columns: new[] { "Id", "CategoryName", "IsFirstName", "IsMale", "IsPublic", "Name", "SuitableRace" },
                values: new object[,]
                {
                    { 1303, "Fantasy", true, true, true, "Jafer", "Human" },
                    { 1304, "Fantasy", true, true, true, "Mawney", "Human" },
                    { 1305, "Fantasy", true, true, true, "Robar", "Human" },
                    { 1306, "Fantasy", true, true, true, "Tobbot", "Human" },
                    { 1307, "Fantasy", true, true, true, "Waldom", "Human" },
                    { 1308, "Fantasy", true, true, true, "Aeron", "Human" },
                    { 1309, "Fantasy", true, true, true, "Bonifer", "Human" },
                    { 1310, "Fantasy", true, true, true, "Durran", "Human" },
                    { 1311, "Fantasy", true, true, true, "Gawen", "Human" },
                    { 1312, "Fantasy", true, true, true, "Jaxar", "Human" },
                    { 1313, "Fantasy", true, true, true, "Malcolm", "Human" },
                    { 1314, "Fantasy", true, true, true, "Robert", "Human" },
                    { 1315, "Fantasy", true, true, true, "Torrhen", "Human" },
                    { 1316, "Fantasy", true, true, true, "Waldon", "Human" },
                    { 1317, "Fantasy", true, true, true, "Alren", "Human" },
                    { 1318, "Fantasy", true, true, true, "Benedar", "Human" },
                    { 1319, "Fantasy", true, true, true, "Durwon", "Human" },
                    { 1320, "Fantasy", true, true, true, "Gwayne", "Human" },
                    { 1321, "Fantasy", true, true, true, "Jasper", "Human" },
                    { 1322, "Fantasy", true, true, true, "Medger", "Human" },
                    { 1323, "Fantasy", true, true, true, "Robin", "Human" },
                    { 1324, "Fantasy", true, true, true, "Tyrek", "Human" },
                    { 1325, "Fantasy", true, true, true, "Wendell", "Human" },
                    { 1326, "Fantasy", true, true, true, "Ashter", "Human" },
                    { 1327, "Fantasy", true, true, true, "Bryan", "Human" },
                    { 1328, "Fantasy", true, true, true, "Donnel", "Human" },
                    { 1329, "Fantasy", true, true, true, "Gunthor", "Human" },
                    { 1330, "Fantasy", true, true, true, "Jerren", "Human" },
                    { 1331, "Fantasy", true, true, true, "Mychel", "Human" },
                    { 1332, "Fantasy", true, true, true, "Roger", "Human" },
                    { 1333, "Fantasy", true, true, true, "Tywell", "Human" },
                    { 1334, "Fantasy", true, true, true, "Wyman", "Human" },
                    { 1335, "Fantasy", true, true, true, "Arneld", "Human" },
                    { 1336, "Fantasy", true, true, true, "Bryen", "Human" },
                    { 1337, "Fantasy", true, true, true, "Dywen", "Human" },
                    { 1338, "Fantasy", true, true, true, "Guyard", "Human" },
                    { 1339, "Fantasy", true, true, true, "Kevan", "Human" },
                    { 1340, "Fantasy", true, true, true, "Melwyn", "Human" },
                    { 1341, "Fantasy", true, true, true, "Roland", "Human" },
                    { 1342, "Fantasy", true, true, true, "Tyrion", "Human" },
                    { 1343, "Fantasy", true, true, true, "Wilbert", "Human" },
                    { 1344, "Fantasy", true, true, true, "Ardrian", "Human" }
                });

            migrationBuilder.InsertData(
                table: "NpcsName",
                columns: new[] { "Id", "CategoryName", "IsFirstName", "IsMale", "IsPublic", "Name", "SuitableRace" },
                values: new object[,]
                {
                    { 1345, "Fantasy", true, true, true, "Brenyn", "Human" },
                    { 1346, "Fantasy", true, true, true, "Dunstan", "Human" },
                    { 1347, "Fantasy", true, true, true, "Grance", "Human" },
                    { 1348, "Fantasy", true, true, true, "Karlon", "Human" },
                    { 1349, "Fantasy", true, true, true, "Martyn", "Human" },
                    { 1350, "Fantasy", true, true, true, "Rolder", "Human" },
                    { 1351, "Fantasy", true, true, true, "Triston", "Human" },
                    { 1352, "Fantasy", true, true, true, "Willam", "Human" },
                    { 1353, "Fantasy", true, true, true, "Asfred", "Human" },
                    { 1354, "Fantasy", true, true, true, "Barton", "Human" },
                    { 1355, "Fantasy", true, true, true, "Damion", "Human" },
                    { 1356, "Fantasy", true, true, true, "Griffin", "Human" },
                    { 1357, "Fantasy", true, true, true, "Kemmett", "Human" },
                    { 1358, "Fantasy", true, true, true, "Maynard", "Human" },
                    { 1359, "Fantasy", true, true, true, "Rolland", "Human" },
                    { 1360, "Fantasy", true, true, true, "Tregar", "Human" },
                    { 1361, "Fantasy", true, true, true, "Wimark", "Human" },
                    { 1362, "Fantasy", true, true, true, "Alliser", "Human" },
                    { 1363, "Fantasy", true, true, true, "Cregard", "Human" },
                    { 1364, "Fantasy", true, true, true, "Davon", "Human" },
                    { 1365, "Fantasy", true, true, true, "Gilwyn", "Human" },
                    { 1366, "Fantasy", true, true, true, "Lucion", "Human" },
                    { 1367, "Fantasy", true, true, true, "Nestor", "Human" },
                    { 1368, "Fantasy", true, true, true, "Rolph", "Human" },
                    { 1369, "Fantasy", true, true, true, "Trevyr", "Human" },
                    { 1370, "Fantasy", true, true, true, "Warron", "Human" },
                    { 1371, "Fantasy", true, true, true, "Armond", "Human" },
                    { 1372, "Fantasy", true, true, true, "Coren", "Human" },
                    { 1373, "Fantasy", true, true, true, "Errold", "Human" },
                    { 1374, "Fantasy", true, true, true, "Gregor", "Human" },
                    { 1375, "Fantasy", true, true, true, "Lorren", "Human" },
                    { 1376, "Fantasy", true, true, true, "Norwin", "Human" },
                    { 1377, "Fantasy", true, true, true, "Rolphar", "Human" },
                    { 1378, "Fantasy", true, true, true, "Trovar", "Human" },
                    { 1379, "Fantasy", true, true, true, "Walderen", "Human" },
                    { 1380, "Fantasy", true, true, true, "Alkwin", "Human" },
                    { 1381, "Fantasy", true, true, true, "Cayden", "Human" },
                    { 1382, "Fantasy", true, true, true, "Edwell", "Human" },
                    { 1383, "Fantasy", true, true, true, "Gareth", "Human" },
                    { 1384, "Fantasy", true, true, true, "Lorent", "Human" },
                    { 1385, "Fantasy", true, true, true, "Norbert", "Human" },
                    { 1386, "Fantasy", true, true, true, "Romny", "Human" }
                });

            migrationBuilder.InsertData(
                table: "NpcsName",
                columns: new[] { "Id", "CategoryName", "IsFirstName", "IsMale", "IsPublic", "Name", "SuitableRace" },
                values: new object[,]
                {
                    { 1387, "Fantasy", true, true, true, "Tywin", "Human" },
                    { 1388, "Fantasy", true, true, true, "Wolmer", "Human" },
                    { 1389, "Fantasy", true, true, true, "Andron", "Human" },
                    { 1390, "Fantasy", true, true, true, "Cregard", "Human" },
                    { 1391, "Fantasy", true, true, true, "Emmond", "Human" },
                    { 1392, "Fantasy", true, true, true, "Gerold", "Human" },
                    { 1393, "Fantasy", true, true, true, "Lothar", "Human" },
                    { 1394, "Fantasy", true, true, true, "Orson", "Human" },
                    { 1395, "Fantasy", true, true, true, "Ronard", "Human" },
                    { 1396, "Fantasy", true, true, true, "Tygett", "Human" },
                    { 1397, "Fantasy", true, true, true, "Walder", "Human" },
                    { 1398, "Fantasy", true, true, true, "Amory", "Human" },
                    { 1399, "Fantasy", true, true, true, "Cedric", "Human" },
                    { 1400, "Fantasy", true, true, true, "Evlys", "Human" },
                    { 1401, "Fantasy", true, true, true, "Gerion", "Human" },
                    { 1402, "Fantasy", true, true, true, "Lorean", "Human" },
                    { 1403, "Fantasy", true, true, true, "Otter", "Human" },
                    { 1404, "Fantasy", true, true, true, "Ronnel", "Human" },
                    { 1405, "Fantasy", true, true, true, "Torrek", "Human" },
                    { 1406, "Fantasy", true, true, true, "Willum", "Human" },
                    { 1407, "Fantasy", true, true, true, "Adrian", "Human" },
                    { 1408, "Fantasy", true, true, true, "Casper", "Human" },
                    { 1409, "Fantasy", true, true, true, "Elyas", "Human" },
                    { 1410, "Fantasy", true, true, true, "Gylbert", "Human" },
                    { 1411, "Fantasy", true, true, true, "Lymond", "Human" },
                    { 1412, "Fantasy", true, true, true, "Ossyn", "Human" },
                    { 1413, "Fantasy", true, true, true, "Ronnet", "Human" },
                    { 1414, "Fantasy", true, true, true, "Tyland", "Human" },
                    { 1415, "Fantasy", true, true, true, "Xander", "Human" },
                    { 1416, "Fantasy", true, true, true, "Addam", "Human" },
                    { 1417, "Fantasy", true, true, true, "Cleos", "Human" },
                    { 1418, "Fantasy", true, true, true, "Elmar", "Human" },
                    { 1419, "Fantasy", true, true, true, "Garryl", "Human" },
                    { 1420, "Fantasy", true, true, true, "Luwion", "Human" },
                    { 1421, "Fantasy", true, true, true, "Ottyn", "Human" },
                    { 1422, "Fantasy", true, true, true, "Rooney", "Human" },
                    { 1423, "Fantasy", true, true, true, "Tymond", "Human" },
                    { 1424, "Fantasy", true, true, true, "Yorbert", "Human" },
                    { 1425, "Fantasy", true, true, true, "Allun", "Human" },
                    { 1426, "Fantasy", true, true, true, "Cleoden", "Human" },
                    { 1427, "Fantasy", true, true, true, "Emmon", "Human" },
                    { 1428, "Fantasy", true, true, true, "Harrion", "Human" }
                });

            migrationBuilder.InsertData(
                table: "NpcsName",
                columns: new[] { "Id", "CategoryName", "IsFirstName", "IsMale", "IsPublic", "Name", "SuitableRace" },
                values: new object[,]
                {
                    { 1429, "Fantasy", true, true, true, "Lewis", "Human" },
                    { 1430, "Fantasy", true, true, true, "Orton", "Human" },
                    { 1431, "Fantasy", true, true, true, "Roril", "Human" },
                    { 1432, "Fantasy", true, true, true, "Tywald", "Human" },
                    { 1433, "Fantasy", true, true, true, "Yohn", "Human" },
                    { 1434, "Fantasy", true, true, true, "Allus", "Human" },
                    { 1435, "Fantasy", true, true, true, "Creighton", "Human" },
                    { 1436, "Fantasy", true, true, true, "Ellery", "Human" },
                    { 1437, "Fantasy", true, true, true, "Harkon", "Human" },
                    { 1438, "Fantasy", true, true, true, "Larence", "Human" },
                    { 1439, "Fantasy", true, true, true, "Ossifer", "Human" },
                    { 1440, "Fantasy", true, true, true, "Ruger", "Human" },
                    { 1441, "Fantasy", true, true, true, "Tybold", "Human" },
                    { 1442, "Fantasy", true, true, true, "Arrec", "Human" },
                    { 1443, "Fantasy", true, true, true, "Colliss", "Human" },
                    { 1444, "Fantasy", true, true, true, "Ebbert", "Human" },
                    { 1445, "Fantasy", true, true, true, "Harker", "Human" },
                    { 1446, "Fantasy", true, true, true, "Lomys", "Human" },
                    { 1447, "Fantasy", true, true, true, "Olymer", "Human" },
                    { 1448, "Fantasy", true, true, true, "Runcel", "Human" },
                    { 1449, "Fantasy", true, true, true, "Tybon", "Human" },
                    { 1450, "Fantasy", true, true, true, "Allard", "Human" },
                    { 1451, "Fantasy", true, true, true, "Cerion", "Human" },
                    { 1452, "Fantasy", true, true, true, "Eduard", "Human" },
                    { 1453, "Fantasy", true, true, true, "Herros", "Human" },
                    { 1454, "Fantasy", true, true, true, "Lyman", "Human" },
                    { 1455, "Fantasy", true, true, true, "Othell", "Human" },
                    { 1456, "Fantasy", true, true, true, "Rycherd", "Human" },
                    { 1457, "Fantasy", true, true, true, "Terrence", "Human" },
                    { 1458, "Fantasy", true, true, true, "Aston", "Human" },
                    { 1459, "Fantasy", true, true, true, "Caspor", "Human" },
                    { 1460, "Fantasy", true, true, true, "Ellys", "Human" },
                    { 1461, "Fantasy", true, true, true, "Hewel", "Human" },
                    { 1462, "Fantasy", true, true, true, "Lendon", "Human" },
                    { 1463, "Fantasy", true, true, true, "Ormond", "Human" },
                    { 1464, "Fantasy", true, true, true, "Ryger", "Human" },
                    { 1465, "Fantasy", true, true, true, "Theomar", "Human" },
                    { 1466, "Fantasy", true, true, true, "Arstan", "Human" },
                    { 1467, "Fantasy", true, true, true, "Clarent", "Human" },
                    { 1468, "Fantasy", true, true, true, "Eyan", "Human" },
                    { 1469, "Fantasy", true, true, true, "Heward", "Human" },
                    { 1470, "Fantasy", true, true, true, "Laswell", "Human" }
                });

            migrationBuilder.InsertData(
                table: "NpcsName",
                columns: new[] { "Id", "CategoryName", "IsFirstName", "IsMale", "IsPublic", "Name", "SuitableRace" },
                values: new object[,]
                {
                    { 1471, "Fantasy", true, true, true, "Olyvar", "Human" },
                    { 1472, "Fantasy", true, true, true, "Rymol", "Human" },
                    { 1473, "Fantasy", true, true, true, "Thoren", "Human" },
                    { 1474, "Fantasy", true, true, true, "Albar", "Human" },
                    { 1475, "Fantasy", true, true, true, "Cadwyn", "Human" },
                    { 1476, "Fantasy", true, true, true, "Erich", "Human" },
                    { 1477, "Fantasy", true, true, true, "Hubard", "Human" },
                    { 1478, "Fantasy", true, true, true, "Lomas", "Human" },
                    { 1479, "Fantasy", true, true, true, "Osney", "Human" },
                    { 1480, "Fantasy", true, true, true, "Sybell", "Human" },
                    { 1481, "Fantasy", true, true, true, "Theon", "Human" },
                    { 1482, "Fantasy", true, true, true, "Arwen", "Human" },
                    { 1483, "Fantasy", true, true, true, "Dirron", "Human" },
                    { 1484, "Fantasy", true, true, true, "Eldon", "Human" },
                    { 1485, "Fantasy", true, true, true, "Howlan", "Human" },
                    { 1486, "Fantasy", true, true, true, "Lester", "Human" },
                    { 1487, "Fantasy", true, true, true, "Oswell", "Human" },
                    { 1488, "Fantasy", true, true, true, "Samnus", "Human" },
                    { 1489, "Fantasy", true, true, true, "Theos", "Human" },
                    { 1490, "Fantasy", true, true, true, "Arron", "Human" },
                    { 1491, "Fantasy", true, true, true, "Dickon", "Human" },
                    { 1492, "Fantasy", true, true, true, "Endrew", "Human" },
                    { 1493, "Fantasy", true, true, true, "Hendry", "Human" },
                    { 1494, "Fantasy", true, true, true, "Lancel", "Human" },
                    { 1495, "Fantasy", true, true, true, "Percen", "Human" },
                    { 1496, "Fantasy", true, true, true, "Symond", "Human" },
                    { 1497, "Fantasy", true, true, true, "Umfred", "Human" },
                    { 1498, "Fantasy", true, true, true, "Amarey", "Human" },
                    { 1499, "Fantasy", true, true, true, "Dillan", "Human" },
                    { 1500, "Fantasy", true, true, true, "Eustace", "Human" },
                    { 1501, "Fantasy", true, true, true, "Humfrey", "Human" },
                    { 1502, "Fantasy", true, true, true, "Lewys", "Human" },
                    { 1503, "Fantasy", true, true, true, "Petyr", "Human" },
                    { 1504, "Fantasy", true, true, true, "Stafford", "Human" },
                    { 1505, "Fantasy", true, true, true, "Uthor", "Human" },
                    { 1506, "Fantasy", true, true, true, "Aubrey", "Human" },
                    { 1507, "Fantasy", true, true, true, "Dorren", "Human" },
                    { 1508, "Fantasy", true, true, true, "Eddison", "Human" },
                    { 1509, "Fantasy", true, true, true, "Hyle", "Human" },
                    { 1510, "Fantasy", true, true, true, "Lambert", "Human" },
                    { 1511, "Fantasy", true, true, true, "Podrick", "Human" },
                    { 1512, "Fantasy", true, true, true, "Sandor", "Human" }
                });

            migrationBuilder.InsertData(
                table: "NpcsName",
                columns: new[] { "Id", "CategoryName", "IsFirstName", "IsMale", "IsPublic", "Name", "SuitableRace" },
                values: new object[,]
                {
                    { 1513, "Fantasy", true, true, true, "Urron", "Human" },
                    { 1514, "Fantasy", true, true, true, "Addison", "Human" },
                    { 1515, "Fantasy", true, true, true, "Denlen", "Human" },
                    { 1516, "Fantasy", true, true, true, "Edmund", "Human" },
                    { 1517, "Fantasy", true, true, true, "Hosman", "Human" },
                    { 1518, "Fantasy", true, true, true, "Loreth", "Human" },
                    { 1519, "Fantasy", true, true, true, "Preston", "Human" },
                    { 1520, "Fantasy", true, true, true, "Samwell", "Human" },
                    { 1521, "Fantasy", true, true, true, "Vardis", "Human" },
                    { 1522, "Fantasy", true, true, true, "Branton", "Human" },
                    { 1523, "Fantasy", true, true, true, "Dorron", "Human" },
                    { 1524, "Fantasy", true, true, true, "Esson", "Human" },
                    { 1525, "Fantasy", true, true, true, "Hoster", "Human" },
                    { 1526, "Fantasy", true, true, true, "Merrett", "Human" },
                    { 1527, "Fantasy", true, true, true, "Quenten", "Human" },
                    { 1528, "Fantasy", true, true, true, "Sewane", "Human" },
                    { 1529, "Fantasy", true, true, true, "Vickon", "Human" },
                    { 1530, "Fantasy", true, true, true, "Bayard", "Human" },
                    { 1531, "Fantasy", true, true, true, "Denys", "Human" },
                    { 1532, "Fantasy", true, true, true, "Ethan", "Human" },
                    { 1533, "Fantasy", true, true, true, "Holman", "Human" },
                    { 1534, "Fantasy", true, true, true, "Matthar", "Human" },
                    { 1535, "Fantasy", true, true, true, "Rafford", "Human" },
                    { 1536, "Fantasy", true, true, true, "Steffon", "Human" },
                    { 1537, "Fantasy", true, true, true, "Veron", "Human" },
                    { 1538, "Fantasy", true, true, true, "Benfred", "Human" },
                    { 1539, "Fantasy", true, true, true, "Dennett", "Human" },
                    { 1540, "Fantasy", true, true, true, "Eyron", "Human" },
                    { 1541, "Fantasy", true, true, true, "Hollis", "Human" },
                    { 1542, "Fantasy", true, true, true, "Matthos", "Human" },
                    { 1543, "Fantasy", true, true, true, "Ramsay", "Human" },
                    { 1544, "Fantasy", true, true, true, "Selmond", "Human" },
                    { 1545, "Fantasy", true, true, true, "Vayon", "Human" },
                    { 1546, "Fantasy", true, true, true, "Brandon", "Human" },
                    { 1547, "Fantasy", true, true, true, "Danwell", "Human" },
                    { 1548, "Fantasy", true, true, true, "Ellard", "Human" },
                    { 1549, "Fantasy", true, true, true, "Harry", "Human" },
                    { 1550, "Fantasy", true, true, true, "Marston", "Human" },
                    { 1551, "Fantasy", true, true, true, "Ramson", "Human" },
                    { 1552, "Fantasy", true, true, true, "Saffron", "Human" },
                    { 1553, "Fantasy", true, true, true, "Vyman", "Human" },
                    { 1554, "Fantasy", true, true, true, "Branston", "Human" }
                });

            migrationBuilder.InsertData(
                table: "NpcsName",
                columns: new[] { "Id", "CategoryName", "IsFirstName", "IsMale", "IsPublic", "Name", "SuitableRace" },
                values: new object[,]
                {
                    { 1555, "Fantasy", true, true, true, "Davos", "Human" },
                    { 1556, "Fantasy", true, true, true, "Eggon", "Human" },
                    { 1557, "Fantasy", true, true, true, "Harwyn", "Human" },
                    { 1558, "Fantasy", true, true, true, "Mallow", "Human" },
                    { 1559, "Fantasy", true, true, true, "Randyll", "Human" },
                    { 1560, "Fantasy", true, true, true, "Trentan", "Human" },
                    { 1561, "Fantasy", true, true, true, "Willem", "Human" },
                    { 1562, "Fantasy", true, true, true, "Baramy", "Human" },
                    { 1563, "Fantasy", true, true, true, "Denys", "Human" },
                    { 1564, "Fantasy", true, true, true, "Forley", "Human" },
                    { 1565, "Fantasy", true, true, true, "Harrold", "Human" },
                    { 1566, "Fantasy", true, true, true, "Merlon", "Human" },
                    { 1567, "Fantasy", true, true, true, "Raymar", "Human" },
                    { 1568, "Fantasy", true, true, true, "Tommen", "Human" },
                    { 1569, "Fantasy", true, true, true, "Wyllis", "Human" },
                    { 1570, "Fantasy", true, true, true, "Boyce", "Human" },
                    { 1571, "Fantasy", true, true, true, "Dennis", "Human" },
                    { 1572, "Fantasy", true, true, true, "Frenlyn", "Human" },
                    { 1573, "Fantasy", true, true, true, "Harren", "Human" },
                    { 1574, "Fantasy", true, true, true, "Manfryd", "Human" },
                    { 1575, "Fantasy", true, true, true, "Raymund", "Human" },
                    { 1576, "Fantasy", true, true, true, "Torwon", "Human" },
                    { 1577, "Fantasy", true, true, true, "Waltyr", "Human" },
                    { 1578, "Fantasy", true, true, true, "Bertin", "Human" },
                    { 1579, "Fantasy", true, true, true, "Damon", "Human" },
                    { 1580, "Fantasy", true, true, true, "Fergon", "Human" },
                    { 1581, "Fantasy", true, true, true, "Ilyn", "Human" },
                    { 1582, "Fantasy", true, true, true, "Myrion", "Human" },
                    { 1583, "Fantasy", true, true, true, "Raynald", "Human" },
                    { 1584, "Fantasy", true, true, true, "Todric", "Human" },
                    { 1585, "Fantasy", true, true, true, "Weslar", "Human" },
                    { 1586, "Fantasy", true, true, true, "Balian", "Human" },
                    { 1587, "Fantasy", true, true, true, "Derris", "Human" },
                    { 1588, "Fantasy", true, true, true, "Frederick", "Human" },
                    { 1589, "Fantasy", true, true, true, "Joshua", "Human" },
                    { 1590, "Fantasy", true, true, true, "Maudon", "Human" },
                    { 1591, "Fantasy", true, true, true, "Regenard", "Human" },
                    { 1592, "Fantasy", true, true, true, "Torwyn", "Human" },
                    { 1593, "Fantasy", true, true, true, "Walton", "Human" },
                    { 1594, "Fantasy", true, true, true, "Bollo", "Human" },
                    { 1595, "Fantasy", true, true, true, "Denner", "Human" },
                    { 1596, "Fantasy", true, true, true, "Flement", "Human" }
                });

            migrationBuilder.InsertData(
                table: "NpcsName",
                columns: new[] { "Id", "CategoryName", "IsFirstName", "IsMale", "IsPublic", "Name", "SuitableRace" },
                values: new object[,]
                {
                    { 1597, "Fantasy", true, true, true, "Jon", "Human" },
                    { 1598, "Fantasy", true, true, true, "Margot", "Human" },
                    { 1599, "Fantasy", true, true, true, "Reynard", "Human" },
                    { 1600, "Fantasy", true, true, true, "Tytos", "Human" },
                    { 1601, "Fantasy", true, true, true, "Wendel", "Human" },
                    { 1602, "Fantasy", true, false, true, "Seraphina", "Human" },
                    { 1603, "Fantasy", true, false, true, "Leila", "Human" },
                    { 1604, "Fantasy", true, false, true, "Daire", "Human" },
                    { 1605, "Fantasy", true, false, true, "Abrielle", "Human" },
                    { 1606, "Fantasy", true, false, true, "Pyralis", "Human" },
                    { 1607, "Fantasy", true, false, true, "Lilith", "Human" },
                    { 1608, "Fantasy", true, false, true, "Sorcha", "Human" },
                    { 1609, "Fantasy", true, false, true, "Liora", "Human" },
                    { 1610, "Fantasy", true, false, true, "Adara", "Human" },
                    { 1611, "Fantasy", true, false, true, "Ginerva", "Human" },
                    { 1612, "Fantasy", true, false, true, "Aiyana", "Human" },
                    { 1613, "Fantasy", true, false, true, "Kyrielle", "Human" },
                    { 1614, "Fantasy", true, false, true, "Lyra", "Human" },
                    { 1615, "Fantasy", true, false, true, "Terra", "Human" },
                    { 1616, "Fantasy", true, false, true, "Maia", "Human" },
                    { 1617, "Fantasy", true, false, true, "Eira", "Human" },
                    { 1618, "Fantasy", true, false, true, "Alissa", "Human" },
                    { 1619, "Fantasy", true, false, true, "Leira", "Human" },
                    { 1620, "Fantasy", true, false, true, "Thalia", "Human" },
                    { 1621, "Fantasy", true, false, true, "Alixandra", "Human" },
                    { 1622, "Fantasy", true, false, true, "Liriene", "Human" },
                    { 1623, "Fantasy", true, false, true, "Eirian", "Human" },
                    { 1624, "Fantasy", true, false, true, "Thaniel", "Human" },
                    { 1625, "Fantasy", true, false, true, "Elysia", "Human" },
                    { 1626, "Fantasy", true, false, true, "Theia", "Human" },
                    { 1627, "Fantasy", true, false, true, "Mireille", "Human" },
                    { 1628, "Fantasy", true, false, true, "Eoin", "Human" },
                    { 1629, "Fantasy", true, false, true, "Amara", "Human" },
                    { 1630, "Fantasy", true, false, true, "Maylea", "Human" },
                    { 1631, "Fantasy", true, false, true, "Mireya", "Human" },
                    { 1632, "Fantasy", true, false, true, "Evadne", "Human" },
                    { 1633, "Fantasy", true, false, true, "Anatola", "Human" },
                    { 1634, "Fantasy", true, false, true, "Meira", "Human" },
                    { 1635, "Fantasy", true, false, true, "Natania", "Human" },
                    { 1636, "Fantasy", true, false, true, "Anya", "Human" },
                    { 1637, "Fantasy", true, false, true, "Tressa", "Human" },
                    { 1638, "Fantasy", true, false, true, "Arcadia", "Human" }
                });

            migrationBuilder.InsertData(
                table: "NpcsName",
                columns: new[] { "Id", "CategoryName", "IsFirstName", "IsMale", "IsPublic", "Name", "SuitableRace" },
                values: new object[,]
                {
                    { 1639, "Fantasy", true, false, true, "Tristana", "Human" },
                    { 1640, "Fantasy", true, false, true, "Nuriel", "Human" },
                    { 1641, "Fantasy", true, false, true, "Ariadne", "Human" },
                    { 1642, "Fantasy", true, false, true, "Oleisa", "Human" },
                    { 1643, "Fantasy", true, false, true, "Uriela", "Human" },
                    { 1644, "Fantasy", true, false, true, "Nyssa", "Human" },
                    { 1645, "Fantasy", true, false, true, "Orinthea", "Human" },
                    { 1646, "Fantasy", true, false, true, "Aurelia", "Human" },
                    { 1647, "Fantasy", true, false, true, "Vanora", "Human" },
                    { 1648, "Fantasy", true, false, true, "Oralie", "Human" },
                    { 1649, "Fantasy", true, false, true, "Pyralia", "Human" },
                    { 1650, "Fantasy", true, false, true, "Vespera", "Human" },
                    { 1651, "Fantasy", true, false, true, "Guinevere", "Human" },
                    { 1652, "Fantasy", true, false, true, "Quinevere", "Human" },
                    { 1653, "Fantasy", true, false, true, "Hadriel", "Human" },
                    { 1654, "Fantasy", true, false, true, "Avalon", "Human" },
                    { 1655, "Fantasy", true, false, true, "Yadira", "Human" },
                    { 1656, "Fantasy", true, false, true, "Ozara", "Human" },
                    { 1657, "Fantasy", true, false, true, "Hannelore", "Human" },
                    { 1658, "Fantasy", true, false, true, "Saira", "Human" },
                    { 1659, "Fantasy", true, false, true, "Yseult", "Human" },
                    { 1660, "Fantasy", true, false, true, "Hermione", "Human" },
                    { 1661, "Fantasy", true, false, true, "Breena", "Human" },
                    { 1662, "Fantasy", true, false, true, "Sarielle", "Human" },
                    { 1663, "Fantasy", true, false, true, "Zaira", "Human" },
                    { 1664, "Fantasy", true, false, true, "Persephone", "Human" },
                    { 1665, "Fantasy", true, false, true, "Brielle", "Human" },
                    { 1666, "Fantasy", true, false, true, "Cambria", "Human" },
                    { 1667, "Fantasy", true, false, true, "Zora", "Human" },
                    { 1668, "Fantasy", true, false, true, "Cara", "Human" },
                    { 1669, "Fantasy", true, false, true, "Ulyssia", "Human" },
                    { 1670, "Fantasy", true, false, true, "Ignacia", "Human" },
                    { 1671, "Fantasy", true, false, true, "Acalia", "Human" },
                    { 1672, "Fantasy", true, false, true, "Qadira", "Human" },
                    { 1673, "Fantasy", true, false, true, "Alaire", "Human" },
                    { 1674, "Fantasy", true, false, true, "Quintessa", "Human" },
                    { 1675, "Fantasy", true, false, true, "Cassia", "Human" },
                    { 1676, "Fantasy", true, false, true, "Auristela", "Human" },
                    { 1677, "Fantasy", true, false, true, "Raisa", "Human" },
                    { 1678, "Fantasy", true, false, true, "Isolde", "Human" },
                    { 1679, "Fantasy", true, false, true, "Jessalyn", "Human" },
                    { 1680, "Fantasy", true, false, true, "Cassiopeia", "Human" }
                });

            migrationBuilder.InsertData(
                table: "NpcsName",
                columns: new[] { "Id", "CategoryName", "IsFirstName", "IsMale", "IsPublic", "Name", "SuitableRace" },
                values: new object[,]
                {
                    { 1681, "Fantasy", true, false, true, "Rhyan", "Human" },
                    { 1682, "Fantasy", true, false, true, "Kara", "Human" },
                    { 1683, "Fantasy", true, false, true, "Kerensa", "Human" },
                    { 1684, "Fantasy", true, false, true, "Chaniel", "Human" },
                    { 1685, "Fantasy", true, false, true, "Riona", "Human" },
                    { 1686, "Fantasy", true, false, true, "Cora", "Human" },
                    { 1687, "Fantasy", true, false, true, "Sarai", "Human" },
                    { 1688, "Fantasy", true, false, true, "Kyra", "Human" },
                    { 1689, "Fantasy", true, false, true, "Leala", "Human" },
                    { 1690, "Fantasy", true, false, true, "Zaniel", "Human" },
                    { 1691, "Fantasy", true, false, true, "Yeriel", "Human" },
                    { 1692, "Fantasy", true, false, true, "Yakira", "Human" },
                    { 1693, "Fantasy", true, false, true, "Xara", "Human" },
                    { 1694, "Fantasy", true, false, true, "Xylia", "Human" },
                    { 1695, "Fantasy", true, false, true, "Alma", "Human" },
                    { 1696, "Fantasy", true, false, true, "Malina", "Human" },
                    { 1697, "Fantasy", true, false, true, "Anna", "Human" },
                    { 1698, "Fantasy", true, false, true, "Mariel", "Human" },
                    { 1699, "Fantasy", true, false, true, "Ariel", "Human" },
                    { 1700, "Fantasy", true, false, true, "Melisse", "Human" },
                    { 1701, "Fantasy", true, false, true, "Calen", "Human" },
                    { 1702, "Fantasy", true, false, true, "Meren", "Human" },
                    { 1703, "Fantasy", true, false, true, "Candis", "Human" },
                    { 1704, "Fantasy", true, false, true, "Merilin", "Human" },
                    { 1705, "Fantasy", true, false, true, "Cellin", "Human" },
                    { 1706, "Fantasy", true, false, true, "Miriel", "Human" },
                    { 1707, "Fantasy", true, false, true, "Elen", "Human" },
                    { 1708, "Fantasy", true, false, true, "Nessa", "Human" },
                    { 1709, "Fantasy", true, false, true, "Estel", "Human" },
                    { 1710, "Fantasy", true, false, true, "Pia", "Human" },
                    { 1711, "Fantasy", true, false, true, "Haleth", "Human" },
                    { 1712, "Fantasy", true, false, true, "Rina", "Human" },
                    { 1713, "Fantasy", true, false, true, "Helin", "Human" },
                    { 1714, "Fantasy", true, false, true, "Tara", "Human" },
                    { 1715, "Fantasy", true, false, true, "Lia", "Human" },
                    { 1716, "Fantasy", true, false, true, "Vanesse", "Human" },
                    { 1717, "Fantasy", true, false, true, "Linda", "Human" },
                    { 1718, "Fantasy", true, false, true, "Wista", "Human" },
                    { 1719, "Fantasy", true, false, true, "Rose", "Human" },
                    { 1720, "Fantasy", true, false, true, "Lily", "Human" },
                    { 1721, "Fantasy", true, false, true, "Medra", "Human" },
                    { 1722, "Fantasy", true, false, true, "Essiri", "Human" }
                });

            migrationBuilder.InsertData(
                table: "NpcsName",
                columns: new[] { "Id", "CategoryName", "IsFirstName", "IsMale", "IsPublic", "Name", "SuitableRace" },
                values: new object[,]
                {
                    { 1723, "Fantasy", true, false, true, "Rose", "Human" },
                    { 1724, "Fantasy", true, false, true, "Ivy", "Human" },
                    { 1725, "Fantasy", true, false, true, "Ember", "Human" },
                    { 1726, "Fantasy", true, false, true, "Nesty", "Human" },
                    { 1727, "Fantasy", true, false, true, "Deyala", "Human" },
                    { 1728, "Fantasy", true, false, true, "Hara", "Human" },
                    { 1729, "Fantasy", true, false, true, "Veil", "Human" },
                    { 1730, "Fantasy", true, false, true, "Aideen", "Human" },
                    { 1731, "Fantasy", true, false, true, "Ailis", "Human" },
                    { 1732, "Fantasy", true, false, true, "Comala", "Human" },
                    { 1733, "Fantasy", true, false, true, "Becuma", "Human" },
                    { 1734, "Fantasy", true, false, true, "Artis", "Human" },
                    { 1735, "Fantasy", true, false, true, "Binne", "Human" },
                    { 1736, "Fantasy", true, false, true, "Boann", "Human" },
                    { 1737, "Fantasy", true, false, true, "Casideh", "Human" },
                    { 1738, "Fantasy", true, false, true, "Alma", "Human" },
                    { 1739, "Fantasy", true, false, true, "Ernine", "Human" },
                    { 1740, "Fantasy", true, false, true, "Dairine", "Human" },
                    { 1741, "Fantasy", true, false, true, "Dealla", "Human" },
                    { 1742, "Fantasy", true, false, true, "Cliona", "Human" },
                    { 1743, "Fantasy", true, false, true, "Earlene", "Human" },
                    { 1744, "Fantasy", true, false, true, "Elva", "Human" },
                    { 1745, "Fantasy", true, false, true, "Eavan", "Human" },
                    { 1746, "Fantasy", true, false, true, "Eilis", "Human" },
                    { 1747, "Fantasy", true, false, true, "Fallon", "Human" },
                    { 1748, "Fantasy", true, false, true, "Flidais", "Human" },
                    { 1749, "Fantasy", true, false, true, "Fenella", "Human" },
                    { 1750, "Fantasy", true, false, true, "Fialla", "Human" },
                    { 1751, "Fantasy", true, false, true, "Gormlaith", "Human" },
                    { 1752, "Fantasy", true, false, true, "Grania", "Human" },
                    { 1753, "Fantasy", true, false, true, "Kacey", "Human" },
                    { 1754, "Fantasy", true, false, true, "Keavy", "Human" },
                    { 1755, "Fantasy", true, false, true, "Kevyn", "Human" },
                    { 1756, "Fantasy", true, false, true, "Liadan", "Human" },
                    { 1757, "Fantasy", true, false, true, "Neala", "Human" },
                    { 1758, "Fantasy", true, false, true, "Luiseach", "Human" },
                    { 1759, "Fantasy", true, false, true, "Mab", "Human" },
                    { 1760, "Fantasy", true, false, true, "Maeve", "Human" },
                    { 1761, "Fantasy", true, false, true, "Moninne", "Human" },
                    { 1762, "Fantasy", true, false, true, "Naomh", "Human" },
                    { 1763, "Fantasy", true, false, true, "Niamh", "Human" },
                    { 1764, "Fantasy", true, false, true, "Nessa", "Human" }
                });

            migrationBuilder.InsertData(
                table: "NpcsName",
                columns: new[] { "Id", "CategoryName", "IsFirstName", "IsMale", "IsPublic", "Name", "SuitableRace" },
                values: new object[,]
                {
                    { 1765, "Fantasy", true, false, true, "Rionach", "Human" },
                    { 1766, "Fantasy", true, false, true, "Ryann", "Human" },
                    { 1767, "Fantasy", true, false, true, "Rylee", "Human" },
                    { 1768, "Fantasy", true, false, true, "Saorla", "Human" },
                    { 1769, "Fantasy", true, false, true, "Saraid", "Human" },
                    { 1770, "Fantasy", true, false, true, "Shanley", "Human" },
                    { 1771, "Fantasy", true, false, true, "Sile", "Human" },
                    { 1772, "Fantasy", true, false, true, "Taillte", "Human" },
                    { 1773, "Fantasy", true, false, true, "Tarra", "Human" },
                    { 1774, "Fantasy", true, false, true, "Trevina", "Human" },
                    { 1775, "Fantasy", true, false, true, "Tuiren", "Human" },
                    { 1776, "Fantasy", true, false, true, "Creidne", "Human" },
                    { 1777, "Fantasy", true, false, true, "Shonda", "Human" },
                    { 1778, "Fantasy", true, false, true, "Nola", "Human" },
                    { 1779, "Fantasy", true, false, true, "Siobhan", "Human" },
                    { 1780, "Fantasy", true, false, true, "Muireann", "Human" },
                    { 1781, "Fantasy", true, false, true, "Murine", "Human" },
                    { 1782, "Fantasy", true, false, true, "Briana", "Human" },
                    { 1783, "Fantasy", true, false, true, "Brid", "Human" },
                    { 1784, "Fantasy", true, false, true, "Sorcha", "Human" },
                    { 1785, "Fantasy", true, false, true, "Bithynia", "Human" },
                    { 1786, "Fantasy", true, false, true, "Balbina", "Human" },
                    { 1787, "Fantasy", true, false, true, "Epione", "Human" },
                    { 1788, "Fantasy", true, false, true, "Horacia", "Human" },
                    { 1789, "Fantasy", true, false, true, "Catena", "Human" },
                    { 1790, "Fantasy", true, false, true, "Albiona", "Human" },
                    { 1791, "Fantasy", true, false, true, "Cardea", "Human" },
                    { 1792, "Fantasy", true, false, true, "Aracelia", "Human" },
                    { 1793, "Fantasy", true, false, true, "Damiana", "Human" },
                    { 1794, "Fantasy", true, false, true, "Emera", "Human" },
                    { 1795, "Fantasy", true, false, true, "Donelle", "Human" },
                    { 1796, "Fantasy", true, false, true, "Devota", "Human" },
                    { 1797, "Fantasy", true, false, true, "Euandra", "Human" },
                    { 1798, "Fantasy", true, false, true, "Felice", "Human" },
                    { 1799, "Fantasy", true, false, true, "Fluonia", "Human" },
                    { 1800, "Fantasy", true, false, true, "Calliope", "Human" },
                    { 1801, "Fantasy", true, false, true, "Gryne", "Human" },
                    { 1802, "Fantasy", true, false, true, "Galatea", "Human" },
                    { 1803, "Fantasy", true, false, true, "Glauce", "Human" },
                    { 1804, "Fantasy", true, false, true, "Kalare", "Human" },
                    { 1805, "Fantasy", true, false, true, "Larunda", "Human" },
                    { 1806, "Fantasy", true, false, true, "Lelia", "Human" }
                });

            migrationBuilder.InsertData(
                table: "NpcsName",
                columns: new[] { "Id", "CategoryName", "IsFirstName", "IsMale", "IsPublic", "Name", "SuitableRace" },
                values: new object[,]
                {
                    { 1807, "Fantasy", true, false, true, "Leis", "Human" },
                    { 1808, "Fantasy", true, false, true, "Levana", "Human" },
                    { 1809, "Fantasy", true, false, true, "Kornele", "Human" },
                    { 1810, "Fantasy", true, false, true, "Lamia", "Human" },
                    { 1811, "Fantasy", true, false, true, "Lorelle", "Human" },
                    { 1812, "Fantasy", true, false, true, "Malvina", "Human" },
                    { 1813, "Fantasy", true, false, true, "Marina", "Human" },
                    { 1814, "Fantasy", true, false, true, "Matuta", "Human" },
                    { 1815, "Fantasy", true, false, true, "Messina", "Human" },
                    { 1816, "Fantasy", true, false, true, "Nelia", "Human" },
                    { 1817, "Fantasy", true, false, true, "Noleta", "Human" },
                    { 1818, "Fantasy", true, false, true, "Nydia", "Human" },
                    { 1819, "Fantasy", true, false, true, "Phaedra", "Human" },
                    { 1820, "Fantasy", true, false, true, "Pallantia", "Human" },
                    { 1821, "Fantasy", true, false, true, "Panya", "Human" },
                    { 1822, "Fantasy", true, false, true, "Pasithea", "Human" },
                    { 1823, "Fantasy", true, false, true, "Nautia", "Human" },
                    { 1824, "Fantasy", true, false, true, "Rosabel", "Human" },
                    { 1825, "Fantasy", true, false, true, "Rhea", "Human" },
                    { 1826, "Fantasy", true, false, true, "Pellonia", "Human" },
                    { 1827, "Fantasy", true, false, true, "Renita", "Human" },
                    { 1828, "Fantasy", true, false, true, "Salacia", "Human" },
                    { 1829, "Fantasy", true, false, true, "Salvia", "Human" },
                    { 1830, "Fantasy", true, false, true, "Secuba", "Human" },
                    { 1831, "Fantasy", true, false, true, "Suada", "Human" },
                    { 1832, "Fantasy", true, false, true, "Virilis", "Human" },
                    { 1833, "Fantasy", true, false, true, "Timandra", "Human" },
                    { 1834, "Fantasy", true, false, true, "Tethys", "Human" },
                    { 1835, "Fantasy", true, false, true, "Vigilia", "Human" },
                    { 1836, "Fantasy", true, false, true, "Zelata", "Human" },
                    { 1837, "Fantasy", true, false, true, "Valeria", "Human" },
                    { 1838, "Fantasy", true, false, true, "Verna", "Human" },
                    { 1839, "Fantasy", true, false, true, "Tryphene", "Human" },
                    { 1840, "Fantasy", true, false, true, "Arwaya", "Human" },
                    { 1841, "Fantasy", true, false, true, "Cynthea", "Human" },
                    { 1842, "Fantasy", true, false, true, "Jocelyn", "Human" },
                    { 1843, "Fantasy", true, false, true, "Marna", "Human" },
                    { 1844, "Fantasy", true, false, true, "Perra", "Human" },
                    { 1845, "Fantasy", true, false, true, "Anya", "Human" },
                    { 1846, "Fantasy", true, false, true, "Donyse", "Human" },
                    { 1847, "Fantasy", true, false, true, "Kristyne", "Human" },
                    { 1848, "Fantasy", true, false, true, "Morya", "Human" }
                });

            migrationBuilder.InsertData(
                table: "NpcsName",
                columns: new[] { "Id", "CategoryName", "IsFirstName", "IsMale", "IsPublic", "Name", "SuitableRace" },
                values: new object[,]
                {
                    { 1849, "Fantasy", true, false, true, "Rosamund", "Human" },
                    { 1850, "Fantasy", true, false, true, "Alysanne", "Human" },
                    { 1851, "Fantasy", true, false, true, "Dolyse", "Human" },
                    { 1852, "Fantasy", true, false, true, "Lorra", "Human" },
                    { 1853, "Fantasy", true, false, true, "Marya", "Human" },
                    { 1854, "Fantasy", true, false, true, "Rowenna", "Human" },
                    { 1855, "Fantasy", true, false, true, "Alla", "Human" },
                    { 1856, "Fantasy", true, false, true, "Dasina", "Human" },
                    { 1857, "Fantasy", true, false, true, "Lanna", "Human" },
                    { 1858, "Fantasy", true, false, true, "Minisa", "Human" },
                    { 1859, "Fantasy", true, false, true, "Randa", "Human" },
                    { 1860, "Fantasy", true, false, true, "Arla", "Human" },
                    { 1861, "Fantasy", true, false, true, "Dyanna", "Human" },
                    { 1862, "Fantasy", true, false, true, "Lynora", "Human" },
                    { 1863, "Fantasy", true, false, true, "Mariya", "Human" },
                    { 1864, "Fantasy", true, false, true, "Sabitha", "Human" },
                    { 1865, "Fantasy", true, false, true, "Annara", "Human" },
                    { 1866, "Fantasy", true, false, true, "Eleyna", "Human" },
                    { 1867, "Fantasy", true, false, true, "Leonella", "Human" },
                    { 1868, "Fantasy", true, false, true, "Mirria", "Human" },
                    { 1869, "Fantasy", true, false, true, "Shyra", "Human" },
                    { 1870, "Fantasy", true, false, true, "Aemma", "Human" },
                    { 1871, "Fantasy", true, false, true, "Faye", "Human" },
                    { 1872, "Fantasy", true, false, true, "Layna", "Human" },
                    { 1873, "Fantasy", true, false, true, "Monica", "Human" },
                    { 1874, "Fantasy", true, false, true, "Tanelle", "Human" },
                    { 1875, "Fantasy", true, false, true, "Aerona", "Human" },
                    { 1876, "Fantasy", true, false, true, "Jocey", "Human" },
                    { 1877, "Fantasy", true, false, true, "Lythene", "Human" },
                    { 1878, "Fantasy", true, false, true, "Megga", "Human" },
                    { 1879, "Fantasy", true, false, true, "Teora", "Human" },
                    { 1880, "Fantasy", true, false, true, "Annette", "Human" },
                    { 1881, "Fantasy", true, false, true, "Jorelle", "Human" },
                    { 1882, "Fantasy", true, false, true, "Lyra", "Human" },
                    { 1883, "Fantasy", true, false, true, "Megette", "Human" },
                    { 1884, "Fantasy", true, false, true, "Tessa", "Human" },
                    { 1885, "Fantasy", true, false, true, "Brella", "Human" },
                    { 1886, "Fantasy", true, false, true, "Joanna", "Human" },
                    { 1887, "Fantasy", true, false, true, "Malora", "Human" },
                    { 1888, "Fantasy", true, false, true, "Melina", "Human" },
                    { 1889, "Fantasy", true, false, true, "Catelyn", "Human" },
                    { 1890, "Fantasy", true, false, true, "Josmyn", "Human" }
                });

            migrationBuilder.InsertData(
                table: "NpcsName",
                columns: new[] { "Id", "CategoryName", "IsFirstName", "IsMale", "IsPublic", "Name", "SuitableRace" },
                values: new object[,]
                {
                    { 1891, "Fantasy", true, false, true, "Meera", "Human" },
                    { 1892, "Fantasy", true, false, true, "Maerie", "Human" },
                    { 1893, "Fantasy", true, false, true, "Ceryse", "Human" },
                    { 1894, "Fantasy", true, false, true, "Jenelyn", "Human" },
                    { 1895, "Fantasy", true, false, true, "Marla", "Human" },
                    { 1896, "Fantasy", true, false, true, "Melesa", "Human" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 252);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 262);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 264);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 265);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 266);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 267);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 268);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 269);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 270);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 271);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 272);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 273);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 274);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 275);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 276);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 277);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 278);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 279);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 280);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 281);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 282);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 283);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 284);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 285);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 286);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 287);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 288);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 289);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 290);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 291);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 292);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 293);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 294);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 295);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 296);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 297);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 298);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 299);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 300);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 303);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 304);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 305);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 306);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 307);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 308);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 309);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 310);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 311);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 312);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 313);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 314);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 315);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 316);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 317);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 318);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 319);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 320);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 321);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 322);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 323);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 324);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 325);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 326);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 327);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 328);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 329);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 330);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 331);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 332);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 333);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 334);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 335);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 336);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 337);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 338);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 339);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 340);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 341);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 342);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 343);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 344);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 345);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 346);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 347);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 348);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 349);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 350);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 351);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 352);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 353);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 354);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 355);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 356);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 357);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 358);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 359);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 360);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 361);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 362);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 363);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 364);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 365);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 366);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 367);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 368);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 369);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 370);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 371);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 372);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 373);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 374);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 375);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 376);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 377);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 378);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 379);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 380);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 381);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 382);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 383);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 384);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 385);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 386);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 387);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 388);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 389);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 390);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 391);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 392);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 393);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 394);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 395);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 396);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 397);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 398);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 399);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 400);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 401);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 402);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 403);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 404);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 405);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 406);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 407);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 408);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 409);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 410);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 411);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 412);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 413);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 414);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 415);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 416);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 417);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 418);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 419);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 420);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 421);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 422);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 423);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 424);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 425);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 426);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 427);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 428);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 429);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 430);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 431);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 432);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 433);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 434);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 435);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 436);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 437);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 438);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 439);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 440);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 441);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 442);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 443);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 444);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 445);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 446);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 447);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 448);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 449);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 450);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 451);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 452);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 453);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 454);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 455);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 456);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 457);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 458);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 459);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 460);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 461);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 462);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 463);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 464);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 465);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 466);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 467);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 468);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 469);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 470);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 471);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 472);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 473);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 474);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 475);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 476);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 477);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 478);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 479);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 480);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 481);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 482);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 483);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 484);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 485);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 486);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 487);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 488);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 489);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 490);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 491);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 492);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 493);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 494);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 495);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 496);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 497);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 498);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 499);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 500);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 501);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 502);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 503);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 504);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 505);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 506);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 507);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 508);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 509);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 510);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 511);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 512);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 513);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 514);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 515);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 516);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 517);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 518);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 519);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 520);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 521);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 522);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 523);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 524);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 525);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 526);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 527);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 528);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 529);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 530);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 531);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 532);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 533);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 534);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 535);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 536);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 537);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 538);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 539);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 540);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 541);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 542);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 543);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 544);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 545);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 546);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 547);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 548);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 549);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 550);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 551);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 552);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 553);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 554);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 555);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 556);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 557);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 558);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 559);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 560);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 561);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 562);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 563);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 564);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 565);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 566);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 567);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 568);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 569);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 570);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 571);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 572);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 573);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 574);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 575);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 576);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 577);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 578);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 579);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 580);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 581);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 582);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 583);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 584);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 585);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 586);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 587);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 588);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 589);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 590);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 591);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 592);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 593);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 594);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 595);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 596);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 597);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 598);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 599);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 600);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 601);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 602);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 603);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 604);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 605);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 606);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 607);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 608);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 609);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 610);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 611);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 612);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 613);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 614);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 615);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 616);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 617);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 618);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 619);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 620);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 621);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 622);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 623);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 624);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 625);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 626);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 627);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 628);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 629);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 630);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 631);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 632);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 633);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 634);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 635);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 636);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 637);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 638);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 639);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 640);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 641);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 642);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 643);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 644);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 645);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 646);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 647);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 648);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 649);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 650);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 651);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 652);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 653);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 654);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 655);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 656);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 657);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 658);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 659);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 660);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 661);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 662);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 663);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 664);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 665);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 666);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 667);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 668);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 669);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 670);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 671);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 672);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 673);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 674);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 675);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 676);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 677);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 678);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 679);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 680);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 681);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 682);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 683);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 684);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 685);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 686);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 687);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 688);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 689);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 690);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 691);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 692);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 693);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 694);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 695);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 696);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 697);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 698);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 699);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 700);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 701);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 702);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 703);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 704);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 705);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 706);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 707);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 708);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 709);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 710);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 711);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 712);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 713);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 714);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 715);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 716);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 717);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 718);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 719);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 720);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 721);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 722);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 723);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 724);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 725);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 726);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 727);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 728);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 729);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 730);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 731);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 732);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 733);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 734);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 735);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 736);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 737);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 738);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 739);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 740);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 741);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 742);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 743);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 744);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 745);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 746);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 747);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 748);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 749);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 750);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 751);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 752);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 753);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 754);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 755);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 756);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 757);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 758);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 759);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 760);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 761);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 762);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 763);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 764);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 765);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 766);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 767);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 768);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 769);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 770);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 771);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 772);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 773);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 774);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 775);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 776);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 777);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 778);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 779);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 780);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 781);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 782);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 783);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 784);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 785);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 786);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 787);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 788);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 789);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 790);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 791);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 792);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 793);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 794);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 795);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 796);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 797);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 798);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 799);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 800);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 801);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 802);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 803);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 804);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 805);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 806);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 807);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 808);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 809);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 810);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 811);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 812);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 813);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 814);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 815);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 816);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 817);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 818);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 819);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 820);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 821);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 822);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 823);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 824);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 825);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 826);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 827);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 828);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 829);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 830);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 831);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 832);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 833);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 834);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 835);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 836);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 837);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 838);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 839);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 840);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 841);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 842);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 843);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 844);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 845);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 846);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 847);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 848);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 849);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 850);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 851);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 852);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 853);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 854);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 855);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 856);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 857);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 858);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 859);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 860);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 861);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 862);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 863);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 864);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 865);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 866);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 867);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 868);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 869);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 870);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 871);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 872);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 873);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 874);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 875);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 876);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 877);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 878);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 879);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 880);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 881);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 882);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 883);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 884);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 885);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 886);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 887);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 888);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 889);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 890);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 891);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 892);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 893);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 894);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 895);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 896);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 897);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 898);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 899);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 900);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 901);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 902);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 903);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 904);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 905);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 906);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 907);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 908);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 909);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 910);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 911);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 912);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 913);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 914);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 915);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 916);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 917);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 918);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 919);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 920);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 921);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 922);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 923);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 924);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 925);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 926);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 927);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 928);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 929);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 930);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 931);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 932);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 933);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 934);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 935);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 936);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 937);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 938);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 939);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 940);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 941);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 942);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 943);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 944);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 945);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 946);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 947);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 948);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 949);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 950);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 951);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 952);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 953);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 954);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 955);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 956);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 957);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 958);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 959);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 960);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 961);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 962);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 963);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 964);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 965);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 966);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 967);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 968);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 969);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 970);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 971);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 972);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 973);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 974);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 975);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 976);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 977);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 978);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 979);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 980);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 981);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 982);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 983);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 984);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 985);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 986);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 987);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 988);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 989);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 990);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 991);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 992);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 993);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 994);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 995);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 996);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 997);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 998);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 999);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1000);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1001);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1002);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1003);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1004);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1005);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1006);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1007);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1008);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1009);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1010);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1011);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1012);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1013);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1014);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1015);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1016);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1017);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1018);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1019);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1020);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1021);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1022);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1023);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1024);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1025);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1026);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1027);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1028);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1029);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1030);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1031);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1032);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1033);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1034);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1035);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1036);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1037);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1038);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1039);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1040);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1041);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1042);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1043);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1044);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1045);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1046);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1047);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1048);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1049);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1050);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1051);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1052);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1053);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1054);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1055);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1056);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1057);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1058);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1059);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1060);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1061);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1062);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1063);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1064);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1065);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1066);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1067);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1068);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1069);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1070);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1071);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1072);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1073);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1074);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1075);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1076);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1077);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1078);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1079);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1080);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1081);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1082);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1083);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1084);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1085);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1086);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1087);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1088);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1089);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1090);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1091);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1092);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1093);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1094);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1095);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1096);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1097);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1098);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1099);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1100);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1101);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1102);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1103);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1104);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1105);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1106);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1107);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1108);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1109);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1110);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1111);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1112);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1113);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1114);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1115);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1116);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1117);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1118);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1119);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1120);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1121);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1122);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1123);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1124);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1125);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1126);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1127);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1128);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1129);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1130);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1131);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1132);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1133);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1134);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1135);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1136);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1137);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1138);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1139);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1140);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1141);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1142);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1143);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1144);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1145);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1146);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1147);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1148);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1149);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1150);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1151);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1152);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1153);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1154);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1155);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1156);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1157);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1158);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1159);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1160);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1161);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1162);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1163);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1164);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1165);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1166);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1167);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1168);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1169);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1170);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1171);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1172);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1173);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1174);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1175);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1176);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1177);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1178);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1179);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1180);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1181);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1182);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1183);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1184);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1185);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1186);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1187);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1188);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1189);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1190);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1191);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1192);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1193);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1194);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1195);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1196);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1197);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1198);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1199);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1200);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1201);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1202);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1203);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1204);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1205);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1206);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1207);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1208);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1209);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1210);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1211);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1212);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1213);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1214);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1215);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1216);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1217);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1218);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1219);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1220);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1221);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1222);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1223);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1224);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1225);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1226);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1227);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1228);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1229);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1230);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1231);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1232);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1233);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1234);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1235);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1236);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1237);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1238);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1239);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1240);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1241);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1242);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1243);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1244);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1245);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1246);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1247);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1248);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1249);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1250);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1251);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1252);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1253);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1254);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1255);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1256);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1257);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1258);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1259);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1260);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1261);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1262);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1263);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1264);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1265);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1266);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1267);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1268);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1269);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1270);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1271);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1272);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1273);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1274);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1275);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1276);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1277);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1278);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1279);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1280);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1281);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1282);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1283);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1284);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1285);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1286);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1287);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1288);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1289);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1290);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1291);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1292);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1293);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1294);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1295);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1296);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1297);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1298);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1299);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1300);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1301);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1302);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1303);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1304);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1305);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1306);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1307);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1308);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1309);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1310);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1311);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1312);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1313);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1314);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1315);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1316);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1317);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1318);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1319);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1320);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1321);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1322);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1323);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1324);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1325);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1326);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1327);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1328);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1329);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1330);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1331);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1332);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1333);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1334);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1335);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1336);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1337);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1338);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1339);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1340);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1341);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1342);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1343);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1344);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1345);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1346);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1347);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1348);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1349);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1350);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1351);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1352);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1353);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1354);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1355);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1356);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1357);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1358);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1359);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1360);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1361);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1362);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1363);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1364);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1365);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1366);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1367);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1368);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1369);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1370);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1371);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1372);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1373);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1374);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1375);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1376);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1377);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1378);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1379);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1380);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1381);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1382);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1383);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1384);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1385);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1386);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1387);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1388);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1389);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1390);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1391);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1392);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1393);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1394);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1395);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1396);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1397);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1398);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1399);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1400);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1401);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1402);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1403);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1404);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1405);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1406);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1407);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1408);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1409);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1410);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1411);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1412);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1413);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1414);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1415);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1416);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1417);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1418);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1419);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1420);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1421);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1422);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1423);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1424);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1425);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1426);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1427);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1428);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1429);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1430);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1431);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1432);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1433);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1434);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1435);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1436);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1437);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1438);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1439);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1440);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1441);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1442);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1443);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1444);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1445);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1446);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1447);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1448);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1449);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1450);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1451);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1452);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1453);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1454);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1455);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1456);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1457);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1458);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1459);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1460);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1461);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1462);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1463);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1464);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1465);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1466);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1467);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1468);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1469);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1470);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1471);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1472);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1473);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1474);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1475);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1476);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1477);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1478);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1479);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1480);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1481);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1482);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1483);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1484);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1485);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1486);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1487);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1488);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1489);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1490);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1491);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1492);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1493);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1494);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1495);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1496);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1497);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1498);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1499);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1500);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1501);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1502);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1503);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1504);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1505);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1506);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1507);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1508);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1509);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1510);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1511);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1512);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1513);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1514);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1515);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1516);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1517);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1518);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1519);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1520);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1521);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1522);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1523);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1524);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1525);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1526);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1527);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1528);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1529);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1530);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1531);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1532);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1533);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1534);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1535);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1536);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1537);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1538);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1539);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1540);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1541);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1542);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1543);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1544);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1545);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1546);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1547);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1548);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1549);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1550);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1551);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1552);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1553);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1554);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1555);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1556);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1557);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1558);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1559);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1560);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1561);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1562);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1563);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1564);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1565);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1566);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1567);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1568);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1569);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1570);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1571);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1572);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1573);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1574);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1575);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1576);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1577);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1578);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1579);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1580);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1581);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1582);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1583);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1584);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1585);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1586);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1587);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1588);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1589);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1590);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1591);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1592);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1593);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1594);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1595);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1596);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1597);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1598);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1599);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1600);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1601);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1602);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1603);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1604);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1605);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1606);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1607);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1608);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1609);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1610);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1611);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1612);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1613);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1614);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1615);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1616);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1617);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1618);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1619);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1620);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1621);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1622);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1623);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1624);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1625);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1626);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1627);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1628);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1629);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1630);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1631);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1632);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1633);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1634);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1635);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1636);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1637);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1638);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1639);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1640);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1641);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1642);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1643);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1644);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1645);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1646);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1647);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1648);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1649);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1650);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1651);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1652);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1653);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1654);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1655);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1656);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1657);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1658);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1659);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1660);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1661);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1662);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1663);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1664);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1665);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1666);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1667);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1668);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1669);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1670);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1671);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1672);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1673);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1674);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1675);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1676);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1677);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1678);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1679);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1680);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1681);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1682);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1683);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1684);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1685);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1686);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1687);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1688);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1689);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1690);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1691);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1692);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1693);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1694);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1695);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1696);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1697);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1698);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1699);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1700);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1701);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1702);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1703);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1704);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1705);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1706);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1707);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1708);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1709);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1710);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1711);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1712);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1713);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1714);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1715);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1716);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1717);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1718);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1719);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1720);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1721);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1722);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1723);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1724);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1725);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1726);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1727);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1728);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1729);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1730);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1731);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1732);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1733);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1734);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1735);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1736);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1737);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1738);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1739);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1740);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1741);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1742);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1743);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1744);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1745);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1746);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1747);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1748);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1749);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1750);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1751);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1752);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1753);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1754);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1755);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1756);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1757);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1758);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1759);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1760);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1761);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1762);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1763);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1764);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1765);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1766);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1767);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1768);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1769);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1770);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1771);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1772);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1773);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1774);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1775);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1776);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1777);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1778);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1779);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1780);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1781);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1782);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1783);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1784);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1785);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1786);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1787);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1788);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1789);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1790);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1791);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1792);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1793);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1794);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1795);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1796);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1797);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1798);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1799);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1800);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1801);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1802);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1803);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1804);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1805);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1806);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1807);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1808);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1809);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1810);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1811);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1812);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1813);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1814);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1815);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1816);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1817);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1818);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1819);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1820);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1821);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1822);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1823);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1824);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1825);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1826);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1827);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1828);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1829);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1830);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1831);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1832);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1833);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1834);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1835);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1836);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1837);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1838);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1839);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1840);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1841);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1842);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1843);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1844);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1845);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1846);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1847);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1848);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1849);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1850);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1851);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1852);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1853);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1854);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1855);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1856);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1857);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1858);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1859);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1860);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1861);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1862);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1863);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1864);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1865);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1866);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1867);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1868);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1869);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1870);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1871);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1872);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1873);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1874);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1875);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1876);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1877);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1878);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1879);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1880);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1881);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1882);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1883);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1884);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1885);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1886);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1887);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1888);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1889);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1890);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1891);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1892);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1893);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1894);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1895);

            migrationBuilder.DeleteData(
                table: "NpcsName",
                keyColumn: "Id",
                keyValue: 1896);
        }
    }
}
