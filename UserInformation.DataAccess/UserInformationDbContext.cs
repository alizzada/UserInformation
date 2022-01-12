using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserInformation.Entities;

namespace UserInformation.DataAccess
{
    public class UserInformationDbContext:DbContext
    {
        public UserInformationDbContext(DbContextOptions<UserInformationDbContext> options):base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(UserInformationDbContext).Assembly);
        }

        
    }
}
