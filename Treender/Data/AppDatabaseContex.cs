using Microsoft.EntityFrameworkCore;


namespace Treender.Data
{

    /// <summary>
    /// Class holding database context of the application
    /// </summary>
    public class AppDatabaseContex : DbContext
    {

        /// <summary>
        /// Default constructor that configures database context
        /// </summary>
        /// <param name="options">Options passed to db context</param>
        public AppDatabaseContex(DbContextOptions<AppDatabaseContex> options)
        {
            
        }
    }
}
