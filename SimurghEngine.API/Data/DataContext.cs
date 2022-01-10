/**
 * @author [U.Mohebi]
 * @email [uones.mohebi@gmail.com]
 * @create date 2022-01-10 14:14:34
 * @modify date 2022-01-10 14:14:34
 * @desc [کانتکست اصلی دیتابیس هسته]
 */
using Microsoft.EntityFrameworkCore;
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