﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SocialClassLibrary.DataAccess;

#nullable disable

namespace SocialClassLibrary.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230518151443_initial")]
    partial class initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SocialClassLibrary.Models.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Body")
                        .IsRequired()
                        .HasMaxLength(5000)
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("Post_Id")
                        .HasColumnType("int");

                    b.Property<int>("User_Id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Post_Id");

                    b.HasIndex("User_Id");

                    b.ToTable("comments");
                });

            modelBuilder.Entity("SocialClassLibrary.Models.Post", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(5000)
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("User_Id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("User_Id");

                    b.ToTable("posts");
                });

            modelBuilder.Entity("SocialClassLibrary.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.HasKey("Id");

                    b.ToTable("users");
                });

            modelBuilder.Entity("SocialClassLibrary.Models.Comment", b =>
                {
                    b.HasOne("SocialClassLibrary.Models.Post", "Post")
                        .WithMany("Comments")
                        .HasForeignKey("Post_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SocialClassLibrary.Models.User", "User")
                        .WithMany("Comments")
                        .HasForeignKey("User_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Post");

                    b.Navigation("User");
                });

            modelBuilder.Entity("SocialClassLibrary.Models.Post", b =>
                {
                    b.HasOne("SocialClassLibrary.Models.User", "User")
                        .WithMany("Posts")
                        .HasForeignKey("User_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("SocialClassLibrary.Models.Post", b =>
                {
                    b.Navigation("Comments");
                });

            modelBuilder.Entity("SocialClassLibrary.Models.User", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("Posts");
                });
#pragma warning restore 612, 618
        }
    }
}
