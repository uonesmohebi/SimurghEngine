// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SimurghEngine.API.Data;

#nullable disable

namespace SimurghEngine.API.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220110085420_EditSomeFields")]
    partial class EditSomeFields
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("AppUserRole", b =>
                {
                    b.Property<int>("AppUsersAppUserId")
                        .HasColumnType("int");

                    b.Property<int>("RolesRoleId")
                        .HasColumnType("int");

                    b.HasKey("AppUsersAppUserId", "RolesRoleId");

                    b.HasIndex("RolesRoleId");

                    b.ToTable("AppUserRole");
                });

            modelBuilder.Entity("ArticleArticleGroup", b =>
                {
                    b.Property<int>("ArticleGroupsArticleGroupId")
                        .HasColumnType("int");

                    b.Property<int>("ArticlesArticleId")
                        .HasColumnType("int");

                    b.HasKey("ArticleGroupsArticleGroupId", "ArticlesArticleId");

                    b.HasIndex("ArticlesArticleId");

                    b.ToTable("ArticleArticleGroup");
                });

            modelBuilder.Entity("ArticleKeyWord", b =>
                {
                    b.Property<int>("ArticlesArticleId")
                        .HasColumnType("int");

                    b.Property<int>("KeyWordsKeyWordId")
                        .HasColumnType("int");

                    b.HasKey("ArticlesArticleId", "KeyWordsKeyWordId");

                    b.HasIndex("KeyWordsKeyWordId");

                    b.ToTable("ArticleKeyWord");
                });

            modelBuilder.Entity("ImageImageGroup", b =>
                {
                    b.Property<int>("ImageGroupsImageGroupId")
                        .HasColumnType("int");

                    b.Property<int>("ImagesImageId")
                        .HasColumnType("int");

                    b.HasKey("ImageGroupsImageGroupId", "ImagesImageId");

                    b.HasIndex("ImagesImageId");

                    b.ToTable("ImageImageGroup");
                });

            modelBuilder.Entity("RoleRoleAccess", b =>
                {
                    b.Property<int>("RoleAccessesroleAccessId")
                        .HasColumnType("int");

                    b.Property<int>("RolesRoleId")
                        .HasColumnType("int");

                    b.HasKey("RoleAccessesroleAccessId", "RolesRoleId");

                    b.HasIndex("RolesRoleId");

                    b.ToTable("RoleRoleAccess");
                });

            modelBuilder.Entity("SimurghEngine.API.Entities.CMS.AppUser", b =>
                {
                    b.Property<int>("AppUserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AppUserId"), 1L, 1);

                    b.Property<bool>("AccountIsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Alias")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("AppUserImageId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("EmailAccount")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmailActivationCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EmailIsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("LastLoginDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastLoginIp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MobileActivationCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("MobileIsActive")
                        .HasColumnType("bit");

                    b.Property<string>("MobileNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AppUserId");

                    b.ToTable("AppUsers");
                });

            modelBuilder.Entity("SimurghEngine.API.Entities.CMS.Article", b =>
                {
                    b.Property<int>("ArticleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ArticleId"), 1L, 1);

                    b.Property<int>("AppUserId")
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("EditorUserId")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("MetaDesc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Summary")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TitleEn")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TitleFa")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ArticleId");

                    b.HasIndex("AppUserId");

                    b.ToTable("Articles");
                });

            modelBuilder.Entity("SimurghEngine.API.Entities.CMS.ArticleGroup", b =>
                {
                    b.Property<int>("ArticleGroupId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ArticleGroupId"), 1L, 1);

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Desc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EditorUserId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("ParentGroupId")
                        .HasColumnType("int");

                    b.Property<string>("TitleEn")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TitleFa")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ArticleGroupId");

                    b.ToTable("ArticleGroups");
                });

            modelBuilder.Entity("SimurghEngine.API.Entities.CMS.Image", b =>
                {
                    b.Property<int>("ImageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ImageId"), 1L, 1);

                    b.Property<string>("AlternateText")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("AppUserId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Desc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EditorUserId")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("TitleEn")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TitleFa")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ImageId");

                    b.HasIndex("AppUserId");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("SimurghEngine.API.Entities.CMS.ImageGroup", b =>
                {
                    b.Property<int>("ImageGroupId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ImageGroupId"), 1L, 1);

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Desc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EditorUserId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ParentGroupId")
                        .HasColumnType("int");

                    b.Property<string>("TitleEn")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TitleFa")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ImageGroupId");

                    b.ToTable("ImageGroups");
                });

            modelBuilder.Entity("SimurghEngine.API.Entities.CMS.KeyWord", b =>
                {
                    b.Property<int>("KeyWordId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("KeyWordId"), 1L, 1);

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Desc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EditorUserId")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("TitleEn")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TitleFa")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("KeyWordId");

                    b.ToTable("KeyWords");
                });

            modelBuilder.Entity("SimurghEngine.API.Entities.CMS.Role", b =>
                {
                    b.Property<int>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RoleId"), 1L, 1);

                    b.Property<string>("Desc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TitleEn")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TitleFa")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RoleId");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("SimurghEngine.API.Entities.CMS.RoleAccess", b =>
                {
                    b.Property<int>("roleAccessId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("roleAccessId"), 1L, 1);

                    b.Property<string>("desc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("titleEn")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("titleFa")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("roleAccessId");

                    b.ToTable("RoleAccesses");
                });

            modelBuilder.Entity("SimurghEngine.API.Entities.CMS.Setting", b =>
                {
                    b.Property<int>("SettingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SettingId"), 1L, 1);

                    b.Property<string>("Desc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TitleEn")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TitleFa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SettingId");

                    b.ToTable("Settings");
                });

            modelBuilder.Entity("AppUserRole", b =>
                {
                    b.HasOne("SimurghEngine.API.Entities.CMS.AppUser", null)
                        .WithMany()
                        .HasForeignKey("AppUsersAppUserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("SimurghEngine.API.Entities.CMS.Role", null)
                        .WithMany()
                        .HasForeignKey("RolesRoleId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("ArticleArticleGroup", b =>
                {
                    b.HasOne("SimurghEngine.API.Entities.CMS.ArticleGroup", null)
                        .WithMany()
                        .HasForeignKey("ArticleGroupsArticleGroupId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("SimurghEngine.API.Entities.CMS.Article", null)
                        .WithMany()
                        .HasForeignKey("ArticlesArticleId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("ArticleKeyWord", b =>
                {
                    b.HasOne("SimurghEngine.API.Entities.CMS.Article", null)
                        .WithMany()
                        .HasForeignKey("ArticlesArticleId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("SimurghEngine.API.Entities.CMS.KeyWord", null)
                        .WithMany()
                        .HasForeignKey("KeyWordsKeyWordId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("ImageImageGroup", b =>
                {
                    b.HasOne("SimurghEngine.API.Entities.CMS.ImageGroup", null)
                        .WithMany()
                        .HasForeignKey("ImageGroupsImageGroupId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("SimurghEngine.API.Entities.CMS.Image", null)
                        .WithMany()
                        .HasForeignKey("ImagesImageId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("RoleRoleAccess", b =>
                {
                    b.HasOne("SimurghEngine.API.Entities.CMS.RoleAccess", null)
                        .WithMany()
                        .HasForeignKey("RoleAccessesroleAccessId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("SimurghEngine.API.Entities.CMS.Role", null)
                        .WithMany()
                        .HasForeignKey("RolesRoleId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("SimurghEngine.API.Entities.CMS.Article", b =>
                {
                    b.HasOne("SimurghEngine.API.Entities.CMS.AppUser", "AppUser")
                        .WithMany("Articles")
                        .HasForeignKey("AppUserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("AppUser");
                });

            modelBuilder.Entity("SimurghEngine.API.Entities.CMS.Image", b =>
                {
                    b.HasOne("SimurghEngine.API.Entities.CMS.AppUser", "AppUser")
                        .WithMany("Images")
                        .HasForeignKey("AppUserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("AppUser");
                });

            modelBuilder.Entity("SimurghEngine.API.Entities.CMS.AppUser", b =>
                {
                    b.Navigation("Articles");

                    b.Navigation("Images");
                });
#pragma warning restore 612, 618
        }
    }
}
