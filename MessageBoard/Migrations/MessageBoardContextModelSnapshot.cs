﻿// <auto-generated />
using System;
using MessageBoard.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MessageBoard.Migrations
{
    [DbContext(typeof(MessageBoardContext))]
    partial class MessageBoardContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("MessageBoard.Models.Message", b =>
                {
                    b.Property<int>("MessageId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Group");

                    b.Property<string>("MessageAuthor");

                    b.Property<DateTime>("MessageDate");

                    b.Property<string>("MessagePost");

                    b.HasKey("MessageId");

                    b.ToTable("Messages");
                });
#pragma warning restore 612, 618
        }
    }
}
