﻿// <auto-generated />
using System;
using Infrastructure.Data.Postgres.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Infrastructure.Data.Postgres.Migrations
{
    [DbContext(typeof(PostgresContext))]
    [Migration("20230924210127_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("CategoriesMentor", b =>
                {
                    b.Property<int>("CategoriesId")
                        .HasColumnType("integer");

                    b.Property<int>("MentorId")
                        .HasColumnType("integer");

                    b.HasKey("CategoriesId", "MentorId");

                    b.HasIndex("MentorId");

                    b.ToTable("CategoriesMentor");
                });

            modelBuilder.Entity("Infrastructure.Data.Postgres.Entities.Categories", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Category_Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Category_Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Category_Photo")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Infrastructure.Data.Postgres.Entities.Form", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("integer");

                    b.Property<int?>("CategoriesId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("Form_Owner_Mentor_Id")
                        .HasColumnType("integer");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<int>("QuestionsId")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("CategoriesId");

                    b.HasIndex("QuestionsId");

                    b.ToTable("Form");
                });

            modelBuilder.Entity("Infrastructure.Data.Postgres.Entities.Mentor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("Mentor_Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("User_Id")
                        .HasColumnType("integer");

                    b.Property<bool>("isAvailable")
                        .HasColumnType("boolean");

                    b.HasKey("Id");

                    b.HasIndex("User_Id")
                        .IsUnique();

                    b.ToTable("Mentors");
                });

            modelBuilder.Entity("Infrastructure.Data.Postgres.Entities.MentorCategory", b =>
                {
                    b.Property<int>("Mentor_Id")
                        .HasColumnType("integer");

                    b.Property<int>("Category_Id")
                        .HasColumnType("integer");

                    b.HasKey("Mentor_Id", "Category_Id");

                    b.HasIndex("Category_Id");

                    b.ToTable("MentorCategory");
                });

            modelBuilder.Entity("Infrastructure.Data.Postgres.Entities.Questions", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("Form_Id")
                        .HasColumnType("integer");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("Question_Text")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("Form_Id");

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("Infrastructure.Data.Postgres.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<int>("Mentor_Id")
                        .HasColumnType("integer");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("bytea");

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("bytea");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("UserType")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("UserName")
                        .IsUnique();

                    b.ToTable("User");
                });

            modelBuilder.Entity("Infrastructure.Data.Postgres.Entities.UserToken", b =>
                {
                    b.Property<string>("Token")
                        .HasColumnType("text");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("ValidUntil")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Token");

                    b.HasIndex("UserId");

                    b.ToTable("UserTokens");
                });

            modelBuilder.Entity("CategoriesMentor", b =>
                {
                    b.HasOne("Infrastructure.Data.Postgres.Entities.Categories", null)
                        .WithMany()
                        .HasForeignKey("CategoriesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Infrastructure.Data.Postgres.Entities.Mentor", null)
                        .WithMany()
                        .HasForeignKey("MentorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Infrastructure.Data.Postgres.Entities.Form", b =>
                {
                    b.HasOne("Infrastructure.Data.Postgres.Entities.Categories", null)
                        .WithMany("Forms")
                        .HasForeignKey("CategoriesId");

                    b.HasOne("Infrastructure.Data.Postgres.Entities.Mentor", "Mentor")
                        .WithMany("Forms")
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Infrastructure.Data.Postgres.Entities.Questions", "Questions")
                        .WithMany()
                        .HasForeignKey("QuestionsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Mentor");

                    b.Navigation("Questions");
                });

            modelBuilder.Entity("Infrastructure.Data.Postgres.Entities.Mentor", b =>
                {
                    b.HasOne("Infrastructure.Data.Postgres.Entities.User", "User")
                        .WithOne("Mentor")
                        .HasForeignKey("Infrastructure.Data.Postgres.Entities.Mentor", "User_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Infrastructure.Data.Postgres.Entities.MentorCategory", b =>
                {
                    b.HasOne("Infrastructure.Data.Postgres.Entities.Categories", "Categories")
                        .WithMany("MentorCategory")
                        .HasForeignKey("Category_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Infrastructure.Data.Postgres.Entities.Mentor", "Mentor")
                        .WithMany("MentorCategories")
                        .HasForeignKey("Mentor_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categories");

                    b.Navigation("Mentor");
                });

            modelBuilder.Entity("Infrastructure.Data.Postgres.Entities.Questions", b =>
                {
                    b.HasOne("Infrastructure.Data.Postgres.Entities.Form", "Form")
                        .WithMany("QuestionsLıst")
                        .HasForeignKey("Form_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Form");
                });

            modelBuilder.Entity("Infrastructure.Data.Postgres.Entities.UserToken", b =>
                {
                    b.HasOne("Infrastructure.Data.Postgres.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Infrastructure.Data.Postgres.Entities.Categories", b =>
                {
                    b.Navigation("Forms");

                    b.Navigation("MentorCategory");
                });

            modelBuilder.Entity("Infrastructure.Data.Postgres.Entities.Form", b =>
                {
                    b.Navigation("QuestionsLıst");
                });

            modelBuilder.Entity("Infrastructure.Data.Postgres.Entities.Mentor", b =>
                {
                    b.Navigation("Forms");

                    b.Navigation("MentorCategories");
                });

            modelBuilder.Entity("Infrastructure.Data.Postgres.Entities.User", b =>
                {
                    b.Navigation("Mentor")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}