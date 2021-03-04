﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Ymltekstil.IdeaSoft.Server.Database;

namespace Ymltekstil.IdeaSoft.Server.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210303114636_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity("Ymltekstil.IdeaSoft.Server.Database.Entities.Settings", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Key");

                    b.Property<string>("Value");

                    b.HasKey("Id");

                    b.ToTable("Settings");

                    b.HasData(
                        new
                        {
                            Id = new Guid("44783db6-948d-422d-84fc-2af908e4cc0a"),
                            Key = "RefreshToken",
                            Value = "MmIwMjU1NTg0ODAyZTA1OThhYmU2ZWVhYmY1YzUxZTI3YmI5MDAwM2YyMDdmZjM3ZGQyN2Y5Y2NhOGYzYTJkOA"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}