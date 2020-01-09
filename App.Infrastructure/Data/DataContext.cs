using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using App.Core.Entities;

namespace App.Infrastructure.Data
{
    public partial class DataContext : IdentityDbContext<User>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                /*
                 * To protect potentially sensitive information in your connection string, you should move it out of source code. 
                 * See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                 */
                optionsBuilder.UseMySql("server=localhost;user id=root;password=;database=app_db;");
            }
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}