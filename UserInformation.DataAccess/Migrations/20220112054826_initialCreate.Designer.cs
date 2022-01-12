﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UserInformation.DataAccess;

#nullable disable

namespace UserInformation.DataAccess.Migrations
{
    [DbContext(typeof(UserInformationDbContext))]
    [Migration("20220112054826_initialCreate")]
    partial class initialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("UserInformation.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("EmailAddress");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Name");

                    b.Property<bool>("Status")
                        .HasColumnType("bit")
                        .HasColumnName("Status");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Surname");

                    b.HasKey("Id");

                    b.ToTable("TBL_Users", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
