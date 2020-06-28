﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ShetaPersonal.Data.Model.Context;

namespace ShetaPersonal.Data.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20200609091635_data8")]
    partial class data8
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ShetaPersonal.Data.Model.Entities.About", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AboutMe")
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.Property<DateTime>("BirthDay")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FName")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("FNameEN")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("LName")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("LNameEN")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Profile")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.HasKey("UserId");

                    b.ToTable("Abouts");
                });

            modelBuilder.Entity("ShetaPersonal.Data.Model.Entities.Danesh", b =>
                {
                    b.Property<int>("DId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AboutUserId")
                        .HasColumnType("int");

                    b.Property<string>("DaneshName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Icon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tozihat")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("DId");

                    b.HasIndex("AboutUserId");

                    b.ToTable("Daneshes");
                });

            modelBuilder.Entity("ShetaPersonal.Data.Model.Entities.Gallery", b =>
                {
                    b.Property<int>("GalleryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AboutUserId")
                        .HasColumnType("int");

                    b.Property<string>("Gallerytitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("GalleryId");

                    b.HasIndex("AboutUserId");

                    b.ToTable("Galleries");
                });

            modelBuilder.Entity("ShetaPersonal.Data.Model.Entities.Maharat", b =>
                {
                    b.Property<int>("MId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AboutUserId")
                        .HasColumnType("int");

                    b.Property<int>("Persent")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("MId");

                    b.HasIndex("AboutUserId");

                    b.ToTable("Maharats");
                });

            modelBuilder.Entity("ShetaPersonal.Data.Model.Entities.Rezome", b =>
                {
                    b.Property<int>("RezomeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AboutUserId")
                        .HasColumnType("int");

                    b.Property<string>("RezomeImage")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("RezomeLink")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("RezomeTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("vazeiyat")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.HasKey("RezomeId");

                    b.HasIndex("AboutUserId");

                    b.ToTable("Rezomes");
                });

            modelBuilder.Entity("ShetaPersonal.Data.Model.Entities.Rezomedetail", b =>
                {
                    b.Property<int>("DetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DetailCaption")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("DetailValue")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<int>("RezomeId")
                        .HasColumnType("int");

                    b.HasKey("DetailId");

                    b.HasIndex("RezomeId");

                    b.ToTable("Rezomedetails");
                });

            modelBuilder.Entity("ShetaPersonal.Data.Model.Entities.Sabeghe", b =>
                {
                    b.Property<int>("SId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AboutUserId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EndTime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Icon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StartTime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Stitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("SId");

                    b.HasIndex("AboutUserId");

                    b.ToTable("Sabeghes");
                });

            modelBuilder.Entity("ShetaPersonal.Data.Model.Entities.Social", b =>
                {
                    b.Property<int>("SociaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AboutUserId")
                        .HasColumnType("int");

                    b.Property<string>("SocialIcon")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("SocialLink")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("SocialName")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("SociaId");

                    b.HasIndex("AboutUserId");

                    b.ToTable("Socials");
                });

            modelBuilder.Entity("ShetaPersonal.Data.Model.Entities.Tahsilat", b =>
                {
                    b.Property<int>("TahsilatId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AboutUserId")
                        .HasColumnType("int");

                    b.Property<string>("Daneshgah")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("EndTime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Reshte")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("StartTime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("gerayesh")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.HasKey("TahsilatId");

                    b.HasIndex("AboutUserId");

                    b.ToTable("Tahsilats");
                });

            modelBuilder.Entity("ShetaPersonal.Data.Model.Entities.Takhasos", b =>
                {
                    b.Property<int>("TakhasosId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AboutUserId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("TakhasosId");

                    b.HasIndex("AboutUserId");

                    b.ToTable("Takhasoses");
                });

            modelBuilder.Entity("ShetaPersonal.Data.Model.Entities.TamasHa", b =>
                {
                    b.Property<int>("TamasId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AboutUserId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Massage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(11)")
                        .HasMaxLength(11);

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.HasKey("TamasId");

                    b.HasIndex("AboutUserId");

                    b.ToTable("TamasHas");
                });

            modelBuilder.Entity("ShetaPersonal.Data.Model.Entities.Danesh", b =>
                {
                    b.HasOne("ShetaPersonal.Data.Model.Entities.About", "About")
                        .WithMany("Daneshes")
                        .HasForeignKey("AboutUserId");
                });

            modelBuilder.Entity("ShetaPersonal.Data.Model.Entities.Gallery", b =>
                {
                    b.HasOne("ShetaPersonal.Data.Model.Entities.About", "About")
                        .WithMany("Galleries")
                        .HasForeignKey("AboutUserId");
                });

            modelBuilder.Entity("ShetaPersonal.Data.Model.Entities.Maharat", b =>
                {
                    b.HasOne("ShetaPersonal.Data.Model.Entities.About", "About")
                        .WithMany("Maharats")
                        .HasForeignKey("AboutUserId");
                });

            modelBuilder.Entity("ShetaPersonal.Data.Model.Entities.Rezome", b =>
                {
                    b.HasOne("ShetaPersonal.Data.Model.Entities.About", "About")
                        .WithMany("Rezomes")
                        .HasForeignKey("AboutUserId");
                });

            modelBuilder.Entity("ShetaPersonal.Data.Model.Entities.Rezomedetail", b =>
                {
                    b.HasOne("ShetaPersonal.Data.Model.Entities.Rezome", "Rezome")
                        .WithMany("Rezomedetails")
                        .HasForeignKey("RezomeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ShetaPersonal.Data.Model.Entities.Sabeghe", b =>
                {
                    b.HasOne("ShetaPersonal.Data.Model.Entities.About", "About")
                        .WithMany("Sabeghes")
                        .HasForeignKey("AboutUserId");
                });

            modelBuilder.Entity("ShetaPersonal.Data.Model.Entities.Social", b =>
                {
                    b.HasOne("ShetaPersonal.Data.Model.Entities.About", "About")
                        .WithMany("Socials")
                        .HasForeignKey("AboutUserId");
                });

            modelBuilder.Entity("ShetaPersonal.Data.Model.Entities.Tahsilat", b =>
                {
                    b.HasOne("ShetaPersonal.Data.Model.Entities.About", "About")
                        .WithMany("Tahsilats")
                        .HasForeignKey("AboutUserId");
                });

            modelBuilder.Entity("ShetaPersonal.Data.Model.Entities.Takhasos", b =>
                {
                    b.HasOne("ShetaPersonal.Data.Model.Entities.About", "About")
                        .WithMany("Takhasoses")
                        .HasForeignKey("AboutUserId");
                });

            modelBuilder.Entity("ShetaPersonal.Data.Model.Entities.TamasHa", b =>
                {
                    b.HasOne("ShetaPersonal.Data.Model.Entities.About", "About")
                        .WithMany("TamasHas")
                        .HasForeignKey("AboutUserId");
                });
#pragma warning restore 612, 618
        }
    }
}
