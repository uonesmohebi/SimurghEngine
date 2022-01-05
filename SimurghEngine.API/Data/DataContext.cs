using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SimurghEngine.API.Entities;
using SimurghEngine.API.Entities.CMS;


namespace SimurghEngine.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        #region Authentication Entities
        public virtual DbSet<AppUser> AppUsers { get; set; }
        public virtual DbSet<RoleAccess> RoleAccesses { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        #endregion

        #region CMS Entities
        public virtual DbSet<Article> Articles { get; set; }
        public virtual DbSet<ArticleGroup> ArticleGroups { get; set; }
        public virtual DbSet<Image> Images { get; set; }
        public virtual DbSet<ImageGroup> ImageGroups { get; set; }
        public virtual DbSet<KeyWord> KeyWords { get; set; }
        #endregion

        #region Main Entities
        public virtual DbSet<Setting> Settings { get; set; }
        #endregion
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Article>(entity =>
                entity
                .HasOne<AppUser>(e => e.CreatorUser)
                .WithMany(e => e.ArticleCreators)
                .HasForeignKey(e => e.CreatorUserId)
                .IsRequired(true)
                );

            modelBuilder.Entity<Article>(entity =>
            entity
            .HasOne<AppUser>(e => e.EditorUser)
            .WithMany(e => e.ArticleEditors)
            .HasForeignKey(e => e.EditorUserId)
            .IsRequired(false)
            );

            modelBuilder.Entity<ArticleGroup>(entity =>
            entity
            .HasOne(e => e.CreatorUser)
            .WithMany(e => e.ArticleGroupCreators)
            .HasForeignKey(e => e.CreatorUserId)
            .IsRequired(true)
            );

            modelBuilder.Entity<ArticleGroup>(entity =>
            entity
            .HasOne<AppUser>(e => e.EditorUser)
            .WithMany(e => e.ArticleGroupEditors)
            .HasForeignKey(e => e.EditorUserId)
            .IsRequired(true));

            modelBuilder.Entity<Image>(entity =>
            entity
            .HasOne(e => e.CreatorUser)
            .WithMany(e => e.ImageCreators)
            .HasForeignKey(e => e.CreatorUserId)
            .IsRequired(true)
            );

            modelBuilder.Entity<Image>(entity =>
            entity
            .HasOne<AppUser>(e => e.EditorUser)
            .WithMany(e => e.ImageEditors)
            .HasForeignKey(e => e.EditorUserId)
            .IsRequired(true));

            modelBuilder.Entity<ImageGroup>(entity =>
            entity
            .HasOne(e => e.CreatorUser)
            .WithMany(e => e.ImageGroupCreators)
            .HasForeignKey(e => e.CreatorUserId)
            .IsRequired(true)
            );

            modelBuilder.Entity<ImageGroup>(entity =>
            entity
            .HasOne<AppUser>(e => e.EditorUser)
            .WithMany(e => e.ImageGroupEditors)
            .HasForeignKey(e => e.EditorUserId)
            .IsRequired(true));

            modelBuilder.Entity<KeyWord>(entity =>
            entity
            .HasOne(e => e.CreatorUser)
            .WithMany(e => e.KeyWordCreators)
            .HasForeignKey(e => e.CreatorUserId)
            .IsRequired(true)
            );

            modelBuilder.Entity<KeyWord>(entity =>
            entity
            .HasOne<AppUser>(e => e.EditorUser)
            .WithMany(e => e.KeyWordEditors)
            .HasForeignKey(e => e.EditorUserId)
            .IsRequired(true));

        }
    }
}