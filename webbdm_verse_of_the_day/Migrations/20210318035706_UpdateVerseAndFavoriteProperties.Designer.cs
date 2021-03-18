﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using webbdm_verse_of_the_day.Models;

namespace webbdm_verse_of_the_day.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210318035706_UpdateVerseAndFavoriteProperties")]
    partial class UpdateVerseAndFavoriteProperties
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.4");

            modelBuilder.Entity("webbdm_verse_of_the_day.Models.Favorite", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("VerseId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Favorites");
                });

            modelBuilder.Entity("webbdm_verse_of_the_day.Models.Verse", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("BibleReferenceLink")
                        .HasColumnType("TEXT");

                    b.Property<string>("Book")
                        .HasColumnType("TEXT");

                    b.Property<int>("Chapter")
                        .HasColumnType("INTEGER");

                    b.Property<string>("FacebookShareUrl")
                        .HasColumnType("TEXT");

                    b.Property<bool>("HasBeenFavorited")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ImageLink")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsValid")
                        .HasColumnType("INTEGER");

                    b.Property<string>("PinterestShareUrl")
                        .HasColumnType("TEXT");

                    b.Property<string>("ReferenceLink")
                        .HasColumnType("TEXT");

                    b.Property<string>("ReferenceText")
                        .HasColumnType("TEXT");

                    b.Property<string>("TwitterShareUrl")
                        .HasColumnType("TEXT");

                    b.Property<string>("Url")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("VerseDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("VerseNumbers")
                        .HasColumnType("TEXT");

                    b.Property<string>("VerseText")
                        .HasColumnType("TEXT");

                    b.Property<string>("VideoLink")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Verses");
                });
#pragma warning restore 612, 618
        }
    }
}
