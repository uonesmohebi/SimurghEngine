﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SimurghEngine.API.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppUsers",
                columns: table => new
                {
                    AppUserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Alias = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AccountIsActive = table.Column<bool>(type: "bit", nullable: false),
                    EmailAccount = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmailActivationCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailIsActive = table.Column<bool>(type: "bit", nullable: false),
                    MobileNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MobileActivationCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MobileIsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastLoginDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastLoginIp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PasswordHash = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    PasswordSalt = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    AppUserImageId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUsers", x => x.AppUserId);
                });

            migrationBuilder.CreateTable(
                name: "RoleAccesses",
                columns: table => new
                {
                    roleAccessId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    titleEn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    titleFa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    desc = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleAccesses", x => x.roleAccessId);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    RoleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TitleEn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TitleFa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Desc = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.RoleId);
                });

            migrationBuilder.CreateTable(
                name: "Settings",
                columns: table => new
                {
                    SettingId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TitleEn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TitleFa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Desc = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Settings", x => x.SettingId);
                });

            migrationBuilder.CreateTable(
                name: "ArticleGroups",
                columns: table => new
                {
                    ArticleGroupId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParentGroupId = table.Column<int>(type: "int", nullable: false),
                    TitleEn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TitleFa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Desc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatorUserId = table.Column<int>(type: "int", nullable: false),
                    EditorUserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArticleGroups", x => x.ArticleGroupId);
                    table.ForeignKey(
                        name: "FK_ArticleGroups_AppUsers_CreatorUserId",
                        column: x => x.CreatorUserId,
                        principalTable: "AppUsers",
                        principalColumn: "AppUserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArticleGroups_AppUsers_EditorUserId",
                        column: x => x.EditorUserId,
                        principalTable: "AppUsers",
                        principalColumn: "AppUserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Articles",
                columns: table => new
                {
                    ArticleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TitleEn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TitleFa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MetaDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Summary = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatorUserId = table.Column<int>(type: "int", nullable: false),
                    EditorUserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Articles", x => x.ArticleId);
                    table.ForeignKey(
                        name: "FK_Articles_AppUsers_CreatorUserId",
                        column: x => x.CreatorUserId,
                        principalTable: "AppUsers",
                        principalColumn: "AppUserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Articles_AppUsers_EditorUserId",
                        column: x => x.EditorUserId,
                        principalTable: "AppUsers",
                        principalColumn: "AppUserId");
                });

            migrationBuilder.CreateTable(
                name: "ImageGroups",
                columns: table => new
                {
                    ImageGroupId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParentGroupId = table.Column<int>(type: "int", nullable: true),
                    TitleEn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TitleFa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Desc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatorUserId = table.Column<int>(type: "int", nullable: false),
                    EditorUserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImageGroups", x => x.ImageGroupId);
                    table.ForeignKey(
                        name: "FK_ImageGroups_AppUsers_CreatorUserId",
                        column: x => x.CreatorUserId,
                        principalTable: "AppUsers",
                        principalColumn: "AppUserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ImageGroups_AppUsers_EditorUserId",
                        column: x => x.EditorUserId,
                        principalTable: "AppUsers",
                        principalColumn: "AppUserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    ImageId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TitleEn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TitleFa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AlternateText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Desc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatorUserId = table.Column<int>(type: "int", nullable: false),
                    EditorUserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.ImageId);
                    table.ForeignKey(
                        name: "FK_Images_AppUsers_CreatorUserId",
                        column: x => x.CreatorUserId,
                        principalTable: "AppUsers",
                        principalColumn: "AppUserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Images_AppUsers_EditorUserId",
                        column: x => x.EditorUserId,
                        principalTable: "AppUsers",
                        principalColumn: "AppUserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KeyWords",
                columns: table => new
                {
                    KeyWordId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TitleEn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TitleFa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Desc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatorUserId = table.Column<int>(type: "int", nullable: false),
                    EditorUserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KeyWords", x => x.KeyWordId);
                    table.ForeignKey(
                        name: "FK_KeyWords_AppUsers_CreatorUserId",
                        column: x => x.CreatorUserId,
                        principalTable: "AppUsers",
                        principalColumn: "AppUserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KeyWords_AppUsers_EditorUserId",
                        column: x => x.EditorUserId,
                        principalTable: "AppUsers",
                        principalColumn: "AppUserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AppUserRole",
                columns: table => new
                {
                    AppUsersAppUserId = table.Column<int>(type: "int", nullable: false),
                    RolesRoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserRole", x => new { x.AppUsersAppUserId, x.RolesRoleId });
                    table.ForeignKey(
                        name: "FK_AppUserRole_AppUsers_AppUsersAppUserId",
                        column: x => x.AppUsersAppUserId,
                        principalTable: "AppUsers",
                        principalColumn: "AppUserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AppUserRole_Roles_RolesRoleId",
                        column: x => x.RolesRoleId,
                        principalTable: "Roles",
                        principalColumn: "RoleId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RoleRoleAccess",
                columns: table => new
                {
                    RoleAccessesroleAccessId = table.Column<int>(type: "int", nullable: false),
                    RolesRoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleRoleAccess", x => new { x.RoleAccessesroleAccessId, x.RolesRoleId });
                    table.ForeignKey(
                        name: "FK_RoleRoleAccess_RoleAccesses_RoleAccessesroleAccessId",
                        column: x => x.RoleAccessesroleAccessId,
                        principalTable: "RoleAccesses",
                        principalColumn: "roleAccessId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RoleRoleAccess_Roles_RolesRoleId",
                        column: x => x.RolesRoleId,
                        principalTable: "Roles",
                        principalColumn: "RoleId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ArticleArticleGroup",
                columns: table => new
                {
                    ArticleGroupsArticleGroupId = table.Column<int>(type: "int", nullable: false),
                    ArticlesArticleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArticleArticleGroup", x => new { x.ArticleGroupsArticleGroupId, x.ArticlesArticleId });
                    table.ForeignKey(
                        name: "FK_ArticleArticleGroup_ArticleGroups_ArticleGroupsArticleGroupId",
                        column: x => x.ArticleGroupsArticleGroupId,
                        principalTable: "ArticleGroups",
                        principalColumn: "ArticleGroupId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArticleArticleGroup_Articles_ArticlesArticleId",
                        column: x => x.ArticlesArticleId,
                        principalTable: "Articles",
                        principalColumn: "ArticleId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ImageImageGroup",
                columns: table => new
                {
                    ImageGroupsImageGroupId = table.Column<int>(type: "int", nullable: false),
                    ImagesImageId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImageImageGroup", x => new { x.ImageGroupsImageGroupId, x.ImagesImageId });
                    table.ForeignKey(
                        name: "FK_ImageImageGroup_ImageGroups_ImageGroupsImageGroupId",
                        column: x => x.ImageGroupsImageGroupId,
                        principalTable: "ImageGroups",
                        principalColumn: "ImageGroupId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ImageImageGroup_Images_ImagesImageId",
                        column: x => x.ImagesImageId,
                        principalTable: "Images",
                        principalColumn: "ImageId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ArticleKeyWord",
                columns: table => new
                {
                    ArticlesArticleId = table.Column<int>(type: "int", nullable: false),
                    KeyWordsKeyWordId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArticleKeyWord", x => new { x.ArticlesArticleId, x.KeyWordsKeyWordId });
                    table.ForeignKey(
                        name: "FK_ArticleKeyWord_Articles_ArticlesArticleId",
                        column: x => x.ArticlesArticleId,
                        principalTable: "Articles",
                        principalColumn: "ArticleId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArticleKeyWord_KeyWords_KeyWordsKeyWordId",
                        column: x => x.KeyWordsKeyWordId,
                        principalTable: "KeyWords",
                        principalColumn: "KeyWordId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AppUserRole_RolesRoleId",
                table: "AppUserRole",
                column: "RolesRoleId");

            migrationBuilder.CreateIndex(
                name: "IX_ArticleArticleGroup_ArticlesArticleId",
                table: "ArticleArticleGroup",
                column: "ArticlesArticleId");

            migrationBuilder.CreateIndex(
                name: "IX_ArticleGroups_CreatorUserId",
                table: "ArticleGroups",
                column: "CreatorUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ArticleGroups_EditorUserId",
                table: "ArticleGroups",
                column: "EditorUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ArticleKeyWord_KeyWordsKeyWordId",
                table: "ArticleKeyWord",
                column: "KeyWordsKeyWordId");

            migrationBuilder.CreateIndex(
                name: "IX_Articles_CreatorUserId",
                table: "Articles",
                column: "CreatorUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Articles_EditorUserId",
                table: "Articles",
                column: "EditorUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ImageGroups_CreatorUserId",
                table: "ImageGroups",
                column: "CreatorUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ImageGroups_EditorUserId",
                table: "ImageGroups",
                column: "EditorUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ImageImageGroup_ImagesImageId",
                table: "ImageImageGroup",
                column: "ImagesImageId");

            migrationBuilder.CreateIndex(
                name: "IX_Images_CreatorUserId",
                table: "Images",
                column: "CreatorUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Images_EditorUserId",
                table: "Images",
                column: "EditorUserId");

            migrationBuilder.CreateIndex(
                name: "IX_KeyWords_CreatorUserId",
                table: "KeyWords",
                column: "CreatorUserId");

            migrationBuilder.CreateIndex(
                name: "IX_KeyWords_EditorUserId",
                table: "KeyWords",
                column: "EditorUserId");

            migrationBuilder.CreateIndex(
                name: "IX_RoleRoleAccess_RolesRoleId",
                table: "RoleRoleAccess",
                column: "RolesRoleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppUserRole");

            migrationBuilder.DropTable(
                name: "ArticleArticleGroup");

            migrationBuilder.DropTable(
                name: "ArticleKeyWord");

            migrationBuilder.DropTable(
                name: "ImageImageGroup");

            migrationBuilder.DropTable(
                name: "RoleRoleAccess");

            migrationBuilder.DropTable(
                name: "Settings");

            migrationBuilder.DropTable(
                name: "ArticleGroups");

            migrationBuilder.DropTable(
                name: "Articles");

            migrationBuilder.DropTable(
                name: "KeyWords");

            migrationBuilder.DropTable(
                name: "ImageGroups");

            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DropTable(
                name: "RoleAccesses");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "AppUsers");
        }
    }
}