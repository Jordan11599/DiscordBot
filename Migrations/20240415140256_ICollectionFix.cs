using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DiscordBot.Migrations
{
    /// <inheritdoc />
    public partial class ICollectionFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Avatar",
                columns: table => new
                {
                    AvatarId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Icon = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Avatar", x => x.AvatarId);
                });

            migrationBuilder.CreateTable(
                name: "Element",
                columns: table => new
                {
                    ElementId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Color = table.Column<string>(type: "TEXT", nullable: false),
                    Icon = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Element", x => x.ElementId);
                });

            migrationBuilder.CreateTable(
                name: "Memory_Data",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Level = table.Column<int>(type: "INTEGER", nullable: false),
                    Chaos_Id = table.Column<int>(type: "INTEGER", nullable: false),
                    Chaos_Level = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Memory_Data", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Path",
                columns: table => new
                {
                    PathId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Id = table.Column<string>(type: "TEXT", nullable: true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Icon = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Path", x => x.PathId);
                });

            migrationBuilder.CreateTable(
                name: "Space_Info",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Memory_DataId = table.Column<int>(type: "INTEGER", nullable: true),
                    Universe_Level = table.Column<int>(type: "INTEGER", nullable: false),
                    Light_Cone_Count = table.Column<int>(type: "INTEGER", nullable: false),
                    Avatar_Count = table.Column<int>(type: "INTEGER", nullable: false),
                    Achievement_Count = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Space_Info", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Space_Info_Memory_Data_Memory_DataId",
                        column: x => x.Memory_DataId,
                        principalTable: "Memory_Data",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Light_Cone",
                columns: table => new
                {
                    Light_ConeId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Id = table.Column<string>(type: "TEXT", nullable: true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Rarity = table.Column<int>(type: "INTEGER", nullable: false),
                    Rank = table.Column<int>(type: "INTEGER", nullable: false),
                    Level = table.Column<int>(type: "INTEGER", nullable: false),
                    Promotion = table.Column<int>(type: "INTEGER", nullable: false),
                    Icon = table.Column<string>(type: "TEXT", nullable: false),
                    Preview = table.Column<string>(type: "TEXT", nullable: false),
                    Portrait = table.Column<string>(type: "TEXT", nullable: false),
                    PathId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Light_Cone", x => x.Light_ConeId);
                    table.ForeignKey(
                        name: "FK_Light_Cone_Path_PathId",
                        column: x => x.PathId,
                        principalTable: "Path",
                        principalColumn: "PathId");
                });

            migrationBuilder.CreateTable(
                name: "Player",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UID = table.Column<string>(type: "TEXT", nullable: false),
                    Nickname = table.Column<string>(type: "TEXT", nullable: false),
                    Level = table.Column<int>(type: "INTEGER", nullable: false),
                    World_Level = table.Column<int>(type: "INTEGER", nullable: false),
                    Friend_Count = table.Column<int>(type: "INTEGER", nullable: false),
                    AvatarId = table.Column<int>(type: "INTEGER", nullable: true),
                    Signature = table.Column<string>(type: "TEXT", nullable: false),
                    Is_Display = table.Column<bool>(type: "INTEGER", nullable: false),
                    Space_InfoId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Player", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Player_Avatar_AvatarId",
                        column: x => x.AvatarId,
                        principalTable: "Avatar",
                        principalColumn: "AvatarId");
                    table.ForeignKey(
                        name: "FK_Player_Space_Info_Space_InfoId",
                        column: x => x.Space_InfoId,
                        principalTable: "Space_Info",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Discord_Id = table.Column<string>(type: "TEXT", nullable: false),
                    UID = table.Column<string>(type: "TEXT", nullable: false),
                    PlayerId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                    table.ForeignKey(
                        name: "FK_User_Player_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Player",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Characters",
                columns: table => new
                {
                    CharactersId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Rarity = table.Column<int>(type: "INTEGER", nullable: false),
                    Rank = table.Column<int>(type: "INTEGER", nullable: false),
                    Level = table.Column<int>(type: "INTEGER", nullable: false),
                    Promotion = table.Column<int>(type: "INTEGER", nullable: false),
                    Icon = table.Column<string>(type: "TEXT", nullable: false),
                    Preview = table.Column<string>(type: "TEXT", nullable: false),
                    Rank_Icons = table.Column<string>(type: "TEXT", nullable: false),
                    PathId = table.Column<int>(type: "INTEGER", nullable: true),
                    ElementId = table.Column<int>(type: "INTEGER", nullable: true),
                    Light_ConeId = table.Column<int>(type: "INTEGER", nullable: true),
                    UserId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Characters", x => x.CharactersId);
                    table.ForeignKey(
                        name: "FK_Characters_Element_ElementId",
                        column: x => x.ElementId,
                        principalTable: "Element",
                        principalColumn: "ElementId");
                    table.ForeignKey(
                        name: "FK_Characters_Light_Cone_Light_ConeId",
                        column: x => x.Light_ConeId,
                        principalTable: "Light_Cone",
                        principalColumn: "Light_ConeId");
                    table.ForeignKey(
                        name: "FK_Characters_Path_PathId",
                        column: x => x.PathId,
                        principalTable: "Path",
                        principalColumn: "PathId");
                    table.ForeignKey(
                        name: "FK_Characters_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Additions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Field = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Icon = table.Column<string>(type: "TEXT", nullable: false),
                    Value = table.Column<float>(type: "REAL", nullable: false),
                    Display = table.Column<string>(type: "TEXT", nullable: false),
                    Percent = table.Column<bool>(type: "INTEGER", nullable: false),
                    CharactersId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Additions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Additions_Characters_CharactersId",
                        column: x => x.CharactersId,
                        principalTable: "Characters",
                        principalColumn: "CharactersId");
                });

            migrationBuilder.CreateTable(
                name: "Attributes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Field = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Icon = table.Column<string>(type: "TEXT", nullable: false),
                    Value = table.Column<float>(type: "REAL", nullable: false),
                    Display = table.Column<string>(type: "TEXT", nullable: false),
                    Percent = table.Column<bool>(type: "INTEGER", nullable: false),
                    CharactersId = table.Column<int>(type: "INTEGER", nullable: true),
                    Light_ConeId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attributes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Attributes_Characters_CharactersId",
                        column: x => x.CharactersId,
                        principalTable: "Characters",
                        principalColumn: "CharactersId");
                    table.ForeignKey(
                        name: "FK_Attributes_Light_Cone_Light_ConeId",
                        column: x => x.Light_ConeId,
                        principalTable: "Light_Cone",
                        principalColumn: "Light_ConeId");
                });

            migrationBuilder.CreateTable(
                name: "Relic_Sets",
                columns: table => new
                {
                    Relic_SetsId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Id = table.Column<string>(type: "TEXT", nullable: true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Icon = table.Column<string>(type: "TEXT", nullable: false),
                    Num = table.Column<int>(type: "INTEGER", nullable: false),
                    Desc = table.Column<string>(type: "TEXT", nullable: false),
                    CharactersId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Relic_Sets", x => x.Relic_SetsId);
                    table.ForeignKey(
                        name: "FK_Relic_Sets_Characters_CharactersId",
                        column: x => x.CharactersId,
                        principalTable: "Characters",
                        principalColumn: "CharactersId");
                });

            migrationBuilder.CreateTable(
                name: "Skill_Trees",
                columns: table => new
                {
                    Skill_TreesId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Id = table.Column<string>(type: "TEXT", nullable: true),
                    Level = table.Column<int>(type: "INTEGER", nullable: false),
                    Anchor = table.Column<string>(type: "TEXT", nullable: false),
                    Max_Level = table.Column<int>(type: "INTEGER", nullable: false),
                    Icon = table.Column<string>(type: "TEXT", nullable: false),
                    Parent = table.Column<string>(type: "TEXT", nullable: true),
                    CharactersId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skill_Trees", x => x.Skill_TreesId);
                    table.ForeignKey(
                        name: "FK_Skill_Trees_Characters_CharactersId",
                        column: x => x.CharactersId,
                        principalTable: "Characters",
                        principalColumn: "CharactersId");
                });

            migrationBuilder.CreateTable(
                name: "Skills",
                columns: table => new
                {
                    SkillsId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Id = table.Column<string>(type: "TEXT", nullable: true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Level = table.Column<int>(type: "INTEGER", nullable: false),
                    Max_Level = table.Column<int>(type: "INTEGER", nullable: false),
                    ElementId = table.Column<int>(type: "INTEGER", nullable: true),
                    Type = table.Column<string>(type: "TEXT", nullable: false),
                    Type_Text = table.Column<string>(type: "TEXT", nullable: false),
                    Effect = table.Column<string>(type: "TEXT", nullable: false),
                    Effect_Text = table.Column<string>(type: "TEXT", nullable: false),
                    Simple_Desc = table.Column<string>(type: "TEXT", nullable: false),
                    Desc = table.Column<string>(type: "TEXT", nullable: false),
                    Icon = table.Column<string>(type: "TEXT", nullable: false),
                    CharactersId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skills", x => x.SkillsId);
                    table.ForeignKey(
                        name: "FK_Skills_Characters_CharactersId",
                        column: x => x.CharactersId,
                        principalTable: "Characters",
                        principalColumn: "CharactersId");
                    table.ForeignKey(
                        name: "FK_Skills_Element_ElementId",
                        column: x => x.ElementId,
                        principalTable: "Element",
                        principalColumn: "ElementId");
                });

            migrationBuilder.CreateTable(
                name: "Properties",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Type = table.Column<string>(type: "TEXT", nullable: false),
                    Field = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Icon = table.Column<string>(type: "TEXT", nullable: false),
                    Value = table.Column<float>(type: "REAL", nullable: false),
                    Display = table.Column<string>(type: "TEXT", nullable: false),
                    Percent = table.Column<bool>(type: "INTEGER", nullable: false),
                    CharactersId = table.Column<int>(type: "INTEGER", nullable: true),
                    Light_ConeId = table.Column<int>(type: "INTEGER", nullable: true),
                    Relic_SetsId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Properties", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Properties_Characters_CharactersId",
                        column: x => x.CharactersId,
                        principalTable: "Characters",
                        principalColumn: "CharactersId");
                    table.ForeignKey(
                        name: "FK_Properties_Light_Cone_Light_ConeId",
                        column: x => x.Light_ConeId,
                        principalTable: "Light_Cone",
                        principalColumn: "Light_ConeId");
                    table.ForeignKey(
                        name: "FK_Properties_Relic_Sets_Relic_SetsId",
                        column: x => x.Relic_SetsId,
                        principalTable: "Relic_Sets",
                        principalColumn: "Relic_SetsId");
                });

            migrationBuilder.CreateTable(
                name: "Main_Affix",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Type = table.Column<string>(type: "TEXT", nullable: false),
                    Field = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Icon = table.Column<string>(type: "TEXT", nullable: false),
                    Value = table.Column<float>(type: "REAL", nullable: false),
                    Display = table.Column<string>(type: "TEXT", nullable: false),
                    Percent = table.Column<bool>(type: "INTEGER", nullable: false),
                    Discriminator = table.Column<string>(type: "TEXT", maxLength: 13, nullable: false),
                    Count = table.Column<int>(type: "INTEGER", nullable: true),
                    Step = table.Column<int>(type: "INTEGER", nullable: true),
                    RelicsId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Main_Affix", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Relics",
                columns: table => new
                {
                    RelicsId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Id = table.Column<string>(type: "TEXT", nullable: true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Set_Id = table.Column<string>(type: "TEXT", nullable: false),
                    Set_Name = table.Column<string>(type: "TEXT", nullable: false),
                    Rarity = table.Column<int>(type: "INTEGER", nullable: false),
                    Level = table.Column<int>(type: "INTEGER", nullable: false),
                    Icon = table.Column<string>(type: "TEXT", nullable: false),
                    Main_AffixId = table.Column<int>(type: "INTEGER", nullable: true),
                    CharactersId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Relics", x => x.RelicsId);
                    table.ForeignKey(
                        name: "FK_Relics_Characters_CharactersId",
                        column: x => x.CharactersId,
                        principalTable: "Characters",
                        principalColumn: "CharactersId");
                    table.ForeignKey(
                        name: "FK_Relics_Main_Affix_Main_AffixId",
                        column: x => x.Main_AffixId,
                        principalTable: "Main_Affix",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Additions_CharactersId",
                table: "Additions",
                column: "CharactersId");

            migrationBuilder.CreateIndex(
                name: "IX_Attributes_CharactersId",
                table: "Attributes",
                column: "CharactersId");

            migrationBuilder.CreateIndex(
                name: "IX_Attributes_Light_ConeId",
                table: "Attributes",
                column: "Light_ConeId");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_ElementId",
                table: "Characters",
                column: "ElementId");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_Light_ConeId",
                table: "Characters",
                column: "Light_ConeId");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_PathId",
                table: "Characters",
                column: "PathId");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_UserId",
                table: "Characters",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Light_Cone_PathId",
                table: "Light_Cone",
                column: "PathId");

            migrationBuilder.CreateIndex(
                name: "IX_Main_Affix_RelicsId",
                table: "Main_Affix",
                column: "RelicsId");

            migrationBuilder.CreateIndex(
                name: "IX_Player_AvatarId",
                table: "Player",
                column: "AvatarId");

            migrationBuilder.CreateIndex(
                name: "IX_Player_Space_InfoId",
                table: "Player",
                column: "Space_InfoId");

            migrationBuilder.CreateIndex(
                name: "IX_Properties_CharactersId",
                table: "Properties",
                column: "CharactersId");

            migrationBuilder.CreateIndex(
                name: "IX_Properties_Light_ConeId",
                table: "Properties",
                column: "Light_ConeId");

            migrationBuilder.CreateIndex(
                name: "IX_Properties_Relic_SetsId",
                table: "Properties",
                column: "Relic_SetsId");

            migrationBuilder.CreateIndex(
                name: "IX_Relic_Sets_CharactersId",
                table: "Relic_Sets",
                column: "CharactersId");

            migrationBuilder.CreateIndex(
                name: "IX_Relics_CharactersId",
                table: "Relics",
                column: "CharactersId");

            migrationBuilder.CreateIndex(
                name: "IX_Relics_Main_AffixId",
                table: "Relics",
                column: "Main_AffixId");

            migrationBuilder.CreateIndex(
                name: "IX_Skill_Trees_CharactersId",
                table: "Skill_Trees",
                column: "CharactersId");

            migrationBuilder.CreateIndex(
                name: "IX_Skills_CharactersId",
                table: "Skills",
                column: "CharactersId");

            migrationBuilder.CreateIndex(
                name: "IX_Skills_ElementId",
                table: "Skills",
                column: "ElementId");

            migrationBuilder.CreateIndex(
                name: "IX_Space_Info_Memory_DataId",
                table: "Space_Info",
                column: "Memory_DataId");

            migrationBuilder.CreateIndex(
                name: "IX_User_PlayerId",
                table: "User",
                column: "PlayerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Main_Affix_Relics_RelicsId",
                table: "Main_Affix",
                column: "RelicsId",
                principalTable: "Relics",
                principalColumn: "RelicsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Relics_Characters_CharactersId",
                table: "Relics");

            migrationBuilder.DropForeignKey(
                name: "FK_Main_Affix_Relics_RelicsId",
                table: "Main_Affix");

            migrationBuilder.DropTable(
                name: "Additions");

            migrationBuilder.DropTable(
                name: "Attributes");

            migrationBuilder.DropTable(
                name: "Properties");

            migrationBuilder.DropTable(
                name: "Skill_Trees");

            migrationBuilder.DropTable(
                name: "Skills");

            migrationBuilder.DropTable(
                name: "Relic_Sets");

            migrationBuilder.DropTable(
                name: "Characters");

            migrationBuilder.DropTable(
                name: "Element");

            migrationBuilder.DropTable(
                name: "Light_Cone");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Path");

            migrationBuilder.DropTable(
                name: "Player");

            migrationBuilder.DropTable(
                name: "Avatar");

            migrationBuilder.DropTable(
                name: "Space_Info");

            migrationBuilder.DropTable(
                name: "Memory_Data");

            migrationBuilder.DropTable(
                name: "Relics");

            migrationBuilder.DropTable(
                name: "Main_Affix");
        }
    }
}
