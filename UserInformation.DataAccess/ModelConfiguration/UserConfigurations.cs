using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserInformation.Entities;

namespace UserInformation.DataAccess.ModelConfiguration
{
    public class UserConfigurations : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("TBL_Users");
            builder.HasKey(x => x.Id);
            builder.Property(p => p.Id).HasColumnName("Id");
            builder.Property(p => p.Name).HasColumnName("Name").HasColumnType("nvarchar(50)");
            builder.Property(p => p.Surname).HasColumnName("Surname").HasColumnType("nvarchar(50)");
            builder.Property(p => p.EmailAddress).HasColumnName("EmailAddress").HasColumnType("nvarchar(50)");
            builder.Property(p => p.Status).HasColumnName("Status").HasColumnType("bit");

        }
    }
}
