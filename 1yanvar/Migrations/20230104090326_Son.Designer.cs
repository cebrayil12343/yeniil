// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using _1yanvar.Models;

#nullable disable

namespace _1yanvar.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230104090326_Son")]
    partial class Son
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("_1yanvar.Models.Catagori", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(28)
                        .HasColumnType("nvarchar(28)");

                    b.HasKey("Id");

                    b.ToTable("Catagori");
                });

            modelBuilder.Entity("_1yanvar.Models.Portfolio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CatagoriId")
                        .HasColumnType("int");

                    b.Property<string>("Client")
                        .IsRequired()
                        .HasMaxLength(22)
                        .HasColumnType("nvarchar(22)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Desc")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("ProjectUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.HasIndex("CatagoriId");

                    b.ToTable("Portfolio");
                });

            modelBuilder.Entity("_1yanvar.Models.PortfolioImage", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PortfolioId")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("PortfolioId");

                    b.ToTable("portfolioImages");
                });

            modelBuilder.Entity("_1yanvar.Models.Portfolio", b =>
                {
                    b.HasOne("_1yanvar.Models.Catagori", "Catagori")
                        .WithMany("PortfolioC")
                        .HasForeignKey("CatagoriId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Catagori");
                });

            modelBuilder.Entity("_1yanvar.Models.PortfolioImage", b =>
                {
                    b.HasOne("_1yanvar.Models.Portfolio", "Portfolio")
                        .WithMany("PortfolioImage")
                        .HasForeignKey("PortfolioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Portfolio");
                });

            modelBuilder.Entity("_1yanvar.Models.Catagori", b =>
                {
                    b.Navigation("PortfolioC");
                });

            modelBuilder.Entity("_1yanvar.Models.Portfolio", b =>
                {
                    b.Navigation("PortfolioImage");
                });
#pragma warning restore 612, 618
        }
    }
}
