﻿// <auto-generated />
using System;
using ChatApp.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ChatApp.Data.Migrations
{
    [DbContext(typeof(ChatAppDbContext))]
    [Migration("20240101172441_FourthMigrationTest")]
    partial class FourthMigrationTest
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("ChatApp.Data.Entities.Models.GroupMessages", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("GroupID")
                        .HasColumnType("integer");

                    b.Property<string>("MessageText")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("SenderUserID")
                        .HasColumnType("integer");

                    b.Property<DateTime>("SentDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("GroupID");

                    b.HasIndex("SenderUserID");

                    b.ToTable("GroupMessages");
                });

            modelBuilder.Entity("ChatApp.Data.Entities.Models.Groups", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("GroupName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Groups");
                });

            modelBuilder.Entity("ChatApp.Data.Entities.Models.GroupUsers", b =>
                {
                    b.Property<int>("GroupId")
                        .HasColumnType("integer");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("GroupId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("GroupUsers");
                });

            modelBuilder.Entity("ChatApp.Data.Entities.Models.PrivateMessages", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("MessageDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("MessageText")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("ReceiverUserID")
                        .HasColumnType("integer");

                    b.Property<int>("SenderUserID")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("ReceiverUserID");

                    b.HasIndex("SenderUserID");

                    b.ToTable("PrivateMesseges");
                });

            modelBuilder.Entity("ChatApp.Data.Entities.Models.Users", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsLogged")
                        .HasColumnType("boolean");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("UserName")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("Users");
                });

            modelBuilder.Entity("ChatApp.Data.Entities.Models.GroupMessages", b =>
                {
                    b.HasOne("ChatApp.Data.Entities.Models.Groups", "Group")
                        .WithMany("GroupMessages")
                        .HasForeignKey("GroupID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ChatApp.Data.Entities.Models.Users", "SenderUser")
                        .WithMany("GroupMessages")
                        .HasForeignKey("SenderUserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Group");

                    b.Navigation("SenderUser");
                });

            modelBuilder.Entity("ChatApp.Data.Entities.Models.GroupUsers", b =>
                {
                    b.HasOne("ChatApp.Data.Entities.Models.Groups", "Group")
                        .WithMany("GroupUsers")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ChatApp.Data.Entities.Models.Users", "User")
                        .WithMany("GroupUsers")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Group");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ChatApp.Data.Entities.Models.PrivateMessages", b =>
                {
                    b.HasOne("ChatApp.Data.Entities.Models.Users", "ReceiverUser")
                        .WithMany("PrivateMessagesReceived")
                        .HasForeignKey("ReceiverUserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ChatApp.Data.Entities.Models.Users", "SenderUser")
                        .WithMany("PrivateMessagesSent")
                        .HasForeignKey("SenderUserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ReceiverUser");

                    b.Navigation("SenderUser");
                });

            modelBuilder.Entity("ChatApp.Data.Entities.Models.Groups", b =>
                {
                    b.Navigation("GroupMessages");

                    b.Navigation("GroupUsers");
                });

            modelBuilder.Entity("ChatApp.Data.Entities.Models.Users", b =>
                {
                    b.Navigation("GroupMessages");

                    b.Navigation("GroupUsers");

                    b.Navigation("PrivateMessagesReceived");

                    b.Navigation("PrivateMessagesSent");
                });
#pragma warning restore 612, 618
        }
    }
}
