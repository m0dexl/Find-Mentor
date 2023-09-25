﻿// <auto-generated />
using System;
using Infrastructure.Data.Postgres.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Infrastructure.Migrations
{
    [DbContext(typeof(PostgresContext))]
    [Migration("20230925105437_init")]
    partial class init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

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
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("Form");
                });

            modelBuilder.Entity("Infrastructure.Data.Postgres.Entities.FormQuestion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("FormId")
                        .HasColumnType("integer");

                    b.Property<int>("QuestionsId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("FormId");

                    b.HasIndex("QuestionsId");

                    b.ToTable("FormQuestion");
                });

            modelBuilder.Entity("Infrastructure.Data.Postgres.Entities.Mentor", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("integer");

                    b.Property<int>("Availability")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("Mentor_Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("Mentors");
                });

            modelBuilder.Entity("Infrastructure.Data.Postgres.Entities.MentorCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("integer");

                    b.Property<int>("MentorId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("MentorId");

                    b.ToTable("MentorCategory");
                });

            modelBuilder.Entity("Infrastructure.Data.Postgres.Entities.MentorForm", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("FormId")
                        .HasColumnType("integer");

                    b.Property<int>("MentorId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("FormId");

                    b.HasIndex("MentorId");

                    b.ToTable("MentorForm");
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

            modelBuilder.Entity("Infrastructure.Data.Postgres.Entities.FormQuestion", b =>
                {
                    b.HasOne("Infrastructure.Data.Postgres.Entities.Form", "Form")
                        .WithMany("QuestionsForForms")
                        .HasForeignKey("FormId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Infrastructure.Data.Postgres.Entities.Questions", "Questions")
                        .WithMany("FormsForQuestions")
                        .HasForeignKey("QuestionsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Form");

                    b.Navigation("Questions");
                });

            modelBuilder.Entity("Infrastructure.Data.Postgres.Entities.Mentor", b =>
                {
                    b.HasOne("Infrastructure.Data.Postgres.Entities.User", "User")
                        .WithOne("Mentor")
                        .HasForeignKey("Infrastructure.Data.Postgres.Entities.Mentor", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Infrastructure.Data.Postgres.Entities.MentorCategory", b =>
                {
                    b.HasOne("Infrastructure.Data.Postgres.Entities.Categories", "Categories")
                        .WithMany("MentorsForCategory")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Infrastructure.Data.Postgres.Entities.Mentor", "Mentor")
                        .WithMany("CategoriesForMentor")
                        .HasForeignKey("MentorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categories");

                    b.Navigation("Mentor");
                });

            modelBuilder.Entity("Infrastructure.Data.Postgres.Entities.MentorForm", b =>
                {
                    b.HasOne("Infrastructure.Data.Postgres.Entities.Form", "Form")
                        .WithMany("MentorsForForm")
                        .HasForeignKey("FormId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Infrastructure.Data.Postgres.Entities.Mentor", "Mentor")
                        .WithMany("FormsForMentor")
                        .HasForeignKey("MentorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Form");

                    b.Navigation("Mentor");
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
                    b.Navigation("MentorsForCategory");
                });

            modelBuilder.Entity("Infrastructure.Data.Postgres.Entities.Form", b =>
                {
                    b.Navigation("MentorsForForm");

                    b.Navigation("QuestionsForForms");
                });

            modelBuilder.Entity("Infrastructure.Data.Postgres.Entities.Mentor", b =>
                {
                    b.Navigation("CategoriesForMentor");

                    b.Navigation("FormsForMentor");
                });

            modelBuilder.Entity("Infrastructure.Data.Postgres.Entities.Questions", b =>
                {
                    b.Navigation("FormsForQuestions");
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
