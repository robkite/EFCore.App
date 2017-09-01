using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using EFCore;
using EFCore.Domain;

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

                    b.Property<string>("BuildingName");

                    b.Property<string>("BuildingNumber");

                    b.Property<string>("City");

                    b.Property<string>("Country");

                    b.Property<string>("County");

                    b.Property<string>("Postcode");

                    b.Property<string>("Street");

                    b.HasKey("Id");

                    b.ToTable("Addresss");
                });

            modelBuilder.Entity("EFCore.Domain.Quotation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("PropertyType");

                    b.Property<int>("SalesPersonId");

                    b.HasKey("Id");

                    b.ToTable("Quotations");
                });

            modelBuilder.Entity("EFCore.Domain.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AddressId");

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("Mobile");

                    b.Property<bool>("PrimaryUser");

                    b.Property<int>("QuotationId");

                    b.Property<int>("Relation");

                    b.Property<double>("SeatToFootrestDimension");

                    b.Property<double>("SeatToHeadDimension");

                    b.Property<double>("SpineToKneesDimension");

                    b.Property<string>("Telephone");

                    b.Property<double>("Weight");

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
