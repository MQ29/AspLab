﻿// <auto-generated />
using System;
using BookData;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BookData.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.13");

            modelBuilder.Entity("BookData.Entities.BookEntity", b =>
                {
                    b.Property<int>("BookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("BookType")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ISBN")
                        .HasColumnType("TEXT");

                    b.Property<int?>("PublicationDate")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("PublisherId")
                        .IsRequired()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("BookId");

                    b.HasIndex("PublisherId");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            BookId = 1,
                            Author = "Ayn Rand",
                            BookType = 2,
                            ISBN = "123141412",
                            PublicationDate = 2000,
                            PublisherId = 1,
                            Title = "Atlas Zbuntowany"
                        },
                        new
                        {
                            BookId = 2,
                            Author = "Stanisław Lem",
                            BookType = 1,
                            ISBN = "5443332154",
                            PublicationDate = 2003,
                            PublisherId = 2,
                            Title = "Solaris"
                        });
                });

            modelBuilder.Entity("BookData.Entities.PublisherEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Publishers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Znak",
                            Phone = "123456789"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Greg",
                            Phone = "987654321"
                        });
                });

            modelBuilder.Entity("BookData.Entities.BookEntity", b =>
                {
                    b.HasOne("BookData.Entities.PublisherEntity", "Publisher")
                        .WithMany("Books")
                        .HasForeignKey("PublisherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Publisher");
                });

            modelBuilder.Entity("BookData.Entities.PublisherEntity", b =>
                {
                    b.OwnsOne("BookData.Models.Address", "Address", b1 =>
                        {
                            b1.Property<int>("PublisherEntityId")
                                .HasColumnType("INTEGER");

                            b1.Property<string>("City")
                                .IsRequired()
                                .HasColumnType("TEXT");

                            b1.Property<string>("PostalCode")
                                .IsRequired()
                                .HasColumnType("TEXT");

                            b1.Property<string>("Street")
                                .IsRequired()
                                .HasColumnType("TEXT");

                            b1.HasKey("PublisherEntityId");

                            b1.ToTable("Publishers");

                            b1.WithOwner()
                                .HasForeignKey("PublisherEntityId");

                            b1.HasData(
                                new
                                {
                                    PublisherEntityId = 1,
                                    City = "Kraków",
                                    PostalCode = "31-234",
                                    Street = "ul.Sienkiewicza"
                                },
                                new
                                {
                                    PublisherEntityId = 2,
                                    City = "Poznań",
                                    PostalCode = "31-555",
                                    Street = "ul.Mickiewicza"
                                });
                        });

                    b.Navigation("Address");
                });

            modelBuilder.Entity("BookData.Entities.PublisherEntity", b =>
                {
                    b.Navigation("Books");
                });
#pragma warning restore 612, 618
        }
    }
}
