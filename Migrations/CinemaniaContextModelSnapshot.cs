﻿// <auto-generated />
using System;
using CineMania.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CineMania.Migrations
{
    [DbContext(typeof(CinemaniaContext))]
    partial class CinemaniaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.7");

            modelBuilder.Entity("CineMania.Models.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(2000)
                        .HasColumnType("TEXT");

                    b.Property<string>("Genre")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ImageName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "A film about Natasha Romanoff in her quests between the films Civil War and Infinity War.",
                            Genre = "Action",
                            ImageName = "black_widow.jpg",
                            ReleaseDate = new DateTime(2021, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Black Widow"
                        },
                        new
                        {
                            Id = 2,
                            Description = "A family man is drafted to fight in a future war where the fate of humanity relies on his ability to confront the past.",
                            Genre = "Sci-Fi",
                            ImageName = "the_tomorrow_war.jpg",
                            ReleaseDate = new DateTime(2021, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "The Tomorrow War"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Beca, a freshman at Barden University, is cajoled into joining The Bellas, her school's all-girls singing group. Injecting some much needed energy into their repertoire, The Bellas take on their male rivals in a campus competition",
                            Genre = "Comedy",
                            ImageName = "black_widow.jpg",
                            ReleaseDate = new DateTime(2013, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Pitch Perfect"
                        },
                        new
                        {
                            Id = 4,
                            Description = "A family falls victim to a group of mutated cannibals in a desert far away from civilization.",
                            Genre = "Horror",
                            ImageName = "hills_have_eyes.jpg",
                            ReleaseDate = new DateTime(2006, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "The Hills Have Eyes"
                        },
                        new
                        {
                            Id = 5,
                            Description = "78-year-old Carl Fredricksen travels to Paradise Falls in his house equipped with balloons, inadvertently taking a young stowaway",
                            Genre = "Animation",
                            ImageName = "up.jpg",
                            ReleaseDate = new DateTime(2009, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Up"
                        },
                        new
                        {
                            Id = 6,
                            Description = "The lives of two mob hitmen, a boxer, a gangster and his wife, and a pair of diner bandits intertwine in four tales of violence and redemption.",
                            Genre = "Crime",
                            ImageName = "pulp_fiction.jpg",
                            ReleaseDate = new DateTime(1994, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Pulp Fiction"
                        },
                        new
                        {
                            Id = 7,
                            Description = "A small-time boxer gets a supremely rare chance to fight a heavyweight champion in a bout in which he strives to go the distance for his self-respect.",
                            Genre = "Drama",
                            ImageName = "rocky.jpg",
                            ReleaseDate = new DateTime(1976, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Rocky"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}