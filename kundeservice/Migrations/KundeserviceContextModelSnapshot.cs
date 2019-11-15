﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using kundeservice.DAL;

namespace kundeservice.Migrations
{
    [DbContext(typeof(KundeserviceContext))]
    partial class KundeserviceContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("kundeservice.DAL.dbsporsmal", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Navn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Spors")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Svar")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("dbsporsmal");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Navn = "Einar",
                            Spors = "Test",
                            Svar = "Svar"
                        },
                        new
                        {
                            ID = 2,
                            Navn = "Einar",
                            Spors = "Test",
                            Svar = "Svar"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
