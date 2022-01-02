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
#endregion
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // configures one-to-many relationship
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
        }
    }
}