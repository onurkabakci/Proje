﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using Proje.Models.EFGetStarted.AspNetCore.NewDb.Models;
using System;

namespace Proje.Migrations
{
    [DbContext(typeof(YolcuContext))]
    partial class YolcuContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Proje.Models.EFGetStarted.AspNetCore.NewDb.Models.Arac", b =>
                {
                    b.Property<int>("AracId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AracAdi");

                    b.HasKey("AracId");

                    b.ToTable("Araclar");
                });

            modelBuilder.Entity("Proje.Models.EFGetStarted.AspNetCore.NewDb.Models.Yolcu", b =>
                {
                    b.Property<int>("YolcuId")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("YolcuId1");

                    b.Property<string>("Yolculuk");

                    b.HasKey("YolcuId");

                    b.HasIndex("YolcuId1");

                    b.ToTable("Yolcular");
                });

            modelBuilder.Entity("Proje.Models.EFGetStarted.AspNetCore.NewDb.Models.Yolcu", b =>
                {
                    b.HasOne("Proje.Models.EFGetStarted.AspNetCore.NewDb.Models.Yolcu")
                        .WithMany("Yolcular")
                        .HasForeignKey("YolcuId1");
                });
#pragma warning restore 612, 618
        }
    }
}
