﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ScriptureNotes.Migrations
{
    [DbContext(typeof(ScriptureNotesContext))]
    [Migration("20210604005151_ChapterName")]
    partial class ChapterName
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.6");

            modelBuilder.Entity("ScriptureNotes.Models.Scripture", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Book")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("TEXT");

                    b.Property<int>("Chapter")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateAdded")
                        .HasColumnType("TEXT");

                    b.Property<string>("Note")
                        .IsRequired()
                        .HasMaxLength(800)
                        .HasColumnType("TEXT");

                    b.Property<int>("Verse")
                        .HasColumnType("INTEGER");

                    b.HasKey("ID");

                    b.ToTable("Scripture");
                });
#pragma warning restore 612, 618
        }
    }
}