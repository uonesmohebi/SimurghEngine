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

        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            foreach (var relationship in modelbuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }

            base.OnModelCreating(modelbuilder);
        }
    }
}