using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using EFCore;

namespace EFCore.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2");

            modelBuilder.Entity("EFCore.Domain.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Postcode");

                    b.HasKey("Id");

                    b.ToTable("Addresss");
                });

            modelBuilder.Entity("EFCore.Domain.Quotation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.HasKey("Id");

                    b.ToTable("Quotations");
                });

            modelBuilder.Entity("EFCore.Domain.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AddressId");

                    b.Property<int>("QuotationId");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.HasIndex("QuotationId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("EFCore.Domain.User", b =>
                {
                    b.HasOne("EFCore.Domain.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("EFCore.Domain.Quotation", "Quotation")
                        .WithMany("Users")
                        .HasForeignKey("QuotationId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
