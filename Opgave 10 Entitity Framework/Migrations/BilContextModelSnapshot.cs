﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Opgave_10_Entitity_Framework.Data;

#nullable disable

namespace Opgave_10_Entitity_Framework.Migrations
{
    [DbContext(typeof(BilContext))]
    partial class BilContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Opgave_10_Entitity_Framework.Models.Bil", b =>
                {
                    b.Property<int>("BILID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BILID"));

                    b.Property<int>("EjerID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NummerPlade")
                        .HasColumnType("int");

                    b.Property<int>("Weight")
                        .HasColumnType("int");

                    b.Property<DateTime>("Årstal")
                        .HasColumnType("datetime2");

                    b.HasKey("BILID");

                    b.HasIndex("EjerID");

                    b.ToTable("Biler");

                    b.HasData(
                        new
                        {
                            BILID = -1,
                            EjerID = -1,
                            Name = "Ford",
                            NummerPlade = 0,
                            Weight = 1400,
                            Årstal = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("Opgave_10_Entitity_Framework.Models.Ejer", b =>
                {
                    b.Property<int>("EjerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EjerID"));

                    b.Property<string>("Navn")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EjerID");

                    b.ToTable("Ejer");

                    b.HasData(
                        new
                        {
                            EjerID = -1,
                            Navn = "Hans"
                        });
                });

            modelBuilder.Entity("Opgave_10_Entitity_Framework.Models.Forretning", b =>
                {
                    b.Property<int>("ForretningID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ForretningID"));

                    b.HasKey("ForretningID");

                    b.ToTable("Forretning");
                });

            modelBuilder.Entity("Opgave_10_Entitity_Framework.Models.Bil", b =>
                {
                    b.HasOne("Opgave_10_Entitity_Framework.Models.Ejer", "Ejer")
                        .WithMany("BilList")
                        .HasForeignKey("EjerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ejer");
                });

            modelBuilder.Entity("Opgave_10_Entitity_Framework.Models.Ejer", b =>
                {
                    b.Navigation("BilList");
                });
#pragma warning restore 612, 618
        }
    }
}
