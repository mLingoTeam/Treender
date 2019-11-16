using Microsoft.EntityFrameworkCore;
using Treender.Data.DbModels;


namespace Treender.Data
{

    /// <summary>
    /// Class holding database context of the application
    /// </summary>
    public class AppDatabaseContext : DbContext
    {
        #region DatabesTables

        public DbSet<Tree> Trees { get; set; }

        public DbSet<TreeType> TreeTypes { get; set; }

        public DbSet<TreeSpecie> TreeSpecies { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<Preference> Preferences { get; set; }

        public DbSet<Like> Likes { get; set; }

        #endregion

        /// <summary>
        /// Default constructor that configures database context
        /// </summary>
        /// <param name="options">Options passed to db context</param>
        public AppDatabaseContext(DbContextOptions<AppDatabaseContext> options) : base(options)
        {

        }
    }
}
