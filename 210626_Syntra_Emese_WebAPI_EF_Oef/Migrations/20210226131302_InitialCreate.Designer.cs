﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using _210626_Syntra_Emese_WebAPI_EF_Oef.DB;

namespace _210626_Syntra_Emese_WebAPI_EF_Oef.Migrations
{
    [DbContext(typeof(ProductDbContext))]
    [Migration("20210226131302_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.3");

            modelBuilder.Entity("_210626_Syntra_Emese_WebAPI_EF_Oef.Models.Product", b =>
                {
                    b.Property<int>("productID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("productName")
                        .HasColumnType("TEXT");

                    b.Property<double>("productPrice")
                        .HasColumnType("REAL");

                    b.HasKey("productID");

                    b.ToTable("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
