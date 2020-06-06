﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyHelper.Api.DAL.Context;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace MyHelper.Api.Migrations
{
    [DbContext(typeof(MyHelperContext))]
    [Migration("20200601135942_AddVisibleTypeToNote")]
    partial class AddVisibleTypeToNote
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("MyHelper.Api.DAL.Entities.AppUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Avatar")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .HasColumnType("text");

                    b.Property<int>("UserRole")
                        .HasColumnType("integer");

                    b.Property<string>("Username")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("AppUsers");
                });

            modelBuilder.Entity("MyHelper.Api.DAL.Entities.Feed", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("AppUserData")
                        .HasColumnType("text");

                    b.Property<int>("AppUserId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("FeedData")
                        .HasColumnType("text");

                    b.Property<int>("FeedRank")
                        .HasColumnType("integer");

                    b.Property<int>("FeedType")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Feeds");
                });

            modelBuilder.Entity("MyHelper.Api.DAL.Entities.Friend", b =>
                {
                    b.Property<int>("RequestedById")
                        .HasColumnType("integer");

                    b.Property<int>("RequestedToId")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("BecameFriendsTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("FriendRequestFlag")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("RequestTime")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("RequestedById", "RequestedToId");

                    b.HasIndex("RequestedToId");

                    b.ToTable("Friends");
                });

            modelBuilder.Entity("MyHelper.Api.DAL.Entities.MhTask", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("AppUserId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<DateTime?>("FinishDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("IsRecurring")
                        .HasColumnType("boolean");

                    b.Property<int>("MhTaskState")
                        .HasColumnType("integer");

                    b.Property<int>("MhTaskStatus")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<long?>("ParentId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("VisibleType")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("AppUserId");

                    b.HasIndex("ParentId");

                    b.ToTable("MhTasks");
                });

            modelBuilder.Entity("MyHelper.Api.DAL.Entities.MhTaskTag", b =>
                {
                    b.Property<long>("MhTaskId")
                        .HasColumnType("bigint");

                    b.Property<long>("TagId")
                        .HasColumnType("bigint");

                    b.HasKey("MhTaskId", "TagId");

                    b.HasIndex("TagId");

                    b.ToTable("MhTaskTags");
                });

            modelBuilder.Entity("MyHelper.Api.DAL.Entities.Note", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("AppUserId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("VisibleType")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("AppUserId");

                    b.ToTable("Notes");
                });

            modelBuilder.Entity("MyHelper.Api.DAL.Entities.NoteTag", b =>
                {
                    b.Property<long>("NoteId")
                        .HasColumnType("bigint");

                    b.Property<long>("TagId")
                        .HasColumnType("bigint");

                    b.HasKey("NoteId", "TagId");

                    b.HasIndex("TagId");

                    b.ToTable("NoteTags");
                });

            modelBuilder.Entity("MyHelper.Api.DAL.Entities.ScheduleMhTask", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int?>("MaxCount")
                        .HasColumnType("integer");

                    b.Property<long>("MhTaskId")
                        .HasColumnType("bigint");

                    b.Property<int>("ScheduleMhTaskType")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("MhTaskId")
                        .IsUnique();

                    b.ToTable("ScheduleMhTasks");
                });

            modelBuilder.Entity("MyHelper.Api.DAL.Entities.Tag", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("MyHelper.Api.DAL.Entities.UpdateMhTask", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<long>("MhTaskId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.HasIndex("MhTaskId");

                    b.ToTable("UpdateMhTasks");
                });

            modelBuilder.Entity("MyHelper.Api.DAL.Entities.Friend", b =>
                {
                    b.HasOne("MyHelper.Api.DAL.Entities.AppUser", "RequestedBy")
                        .WithMany("SentFriendRequests")
                        .HasForeignKey("RequestedById")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("MyHelper.Api.DAL.Entities.AppUser", "RequestedTo")
                        .WithMany("ReceievedFriendRequests")
                        .HasForeignKey("RequestedToId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("MyHelper.Api.DAL.Entities.MhTask", b =>
                {
                    b.HasOne("MyHelper.Api.DAL.Entities.AppUser", "AppUser")
                        .WithMany("MhTasks")
                        .HasForeignKey("AppUserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("MyHelper.Api.DAL.Entities.MhTask", "Parent")
                        .WithMany("Children")
                        .HasForeignKey("ParentId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("MyHelper.Api.DAL.Entities.MhTaskTag", b =>
                {
                    b.HasOne("MyHelper.Api.DAL.Entities.MhTask", "MhTask")
                        .WithMany("MhTaskTags")
                        .HasForeignKey("MhTaskId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MyHelper.Api.DAL.Entities.Tag", "Tag")
                        .WithMany("MhTaskTags")
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MyHelper.Api.DAL.Entities.Note", b =>
                {
                    b.HasOne("MyHelper.Api.DAL.Entities.AppUser", "AppUser")
                        .WithMany("Notes")
                        .HasForeignKey("AppUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MyHelper.Api.DAL.Entities.NoteTag", b =>
                {
                    b.HasOne("MyHelper.Api.DAL.Entities.Note", "Note")
                        .WithMany("NoteTags")
                        .HasForeignKey("NoteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MyHelper.Api.DAL.Entities.Tag", "Tag")
                        .WithMany("NoteTags")
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MyHelper.Api.DAL.Entities.ScheduleMhTask", b =>
                {
                    b.HasOne("MyHelper.Api.DAL.Entities.MhTask", "MhTask")
                        .WithOne("ScheduleMhTask")
                        .HasForeignKey("MyHelper.Api.DAL.Entities.ScheduleMhTask", "MhTaskId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MyHelper.Api.DAL.Entities.UpdateMhTask", b =>
                {
                    b.HasOne("MyHelper.Api.DAL.Entities.MhTask", "MhTask")
                        .WithMany("Updates")
                        .HasForeignKey("MhTaskId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
