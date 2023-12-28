﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using POS_WebAPI.DataContext;

#nullable disable

namespace POS_WebAPI.Migrations
{
    [DbContext(typeof(PosContext))]
    [Migration("20231228063949_M_3")]
    partial class M_3
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("POS_WebAPI.Models.EntityModel.Category", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(36)
                        .HasColumnType("varchar");

                    b.Property<DateTime>("Create_At")
                        .HasColumnType("datetime");

                    b.Property<string>("Description")
                        .HasMaxLength(255)
                        .HasColumnType("varchar");

                    b.Property<string>("Image")
                        .HasMaxLength(550)
                        .HasColumnType("varchar");

                    b.Property<bool>("Is_Deleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Category");
                });

            modelBuilder.Entity("POS_WebAPI.Models.EntityModel.Company", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(36)
                        .HasColumnType("varchar");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar");

                    b.Property<string>("Contact")
                        .IsRequired()
                        .HasMaxLength(12)
                        .HasColumnType("varchar");

                    b.Property<DateTime>("Create_At")
                        .HasColumnType("datetime");

                    b.Property<string>("Email")
                        .HasMaxLength(100)
                        .HasColumnType("varchar");

                    b.Property<string>("Image")
                        .HasMaxLength(500)
                        .HasColumnType("varchar");

                    b.Property<bool?>("Is_Deleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar");

                    b.Property<string>("NameKh")
                        .HasMaxLength(100)
                        .IsUnicode(true)
                        .HasColumnType("varchar");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("System_Id")
                        .IsRequired()
                        .HasMaxLength(36)
                        .HasColumnType("varchar");

                    b.Property<string>("Website")
                        .HasMaxLength(255)
                        .HasColumnType("varchar");

                    b.HasKey("Id");

                    b.HasIndex("System_Id");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("POS_WebAPI.Models.EntityModel.Order", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(36)
                        .HasColumnType("varchar");

                    b.Property<string>("Company_Id")
                        .HasMaxLength(36)
                        .HasColumnType("varchar");

                    b.Property<bool?>("Is_Delete")
                        .IsRequired()
                        .HasColumnType("bit");

                    b.Property<DateTime>("Order_Date")
                        .HasColumnType("datetime");

                    b.Property<int>("Order_Status")
                        .HasColumnType("int");

                    b.Property<string>("Reference_Id")
                        .HasMaxLength(36)
                        .HasColumnType("varchar");

                    b.Property<string>("Source_Id")
                        .HasMaxLength(36)
                        .HasColumnType("varchar");

                    b.Property<decimal>("Sub_Total")
                        .HasColumnType("decimal(8,2)");

                    b.Property<decimal?>("Tax")
                        .HasColumnType("decimal(8,2)");

                    b.Property<decimal>("Total")
                        .HasColumnType("decimal(8,2)");

                    b.Property<decimal>("Total_Discount")
                        .HasColumnType("decimal(8,2)");

                    b.HasKey("Id");

                    b.HasIndex("Reference_Id");

                    b.HasIndex("Source_Id");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("POS_WebAPI.Models.EntityModel.OrderDetail", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(36)
                        .HasColumnType("varchar");

                    b.Property<DateTime>("Create_At")
                        .HasColumnType("datetime");

                    b.Property<decimal?>("Discount")
                        .HasColumnType("decimal(8,2)");

                    b.Property<string>("Order_Id")
                        .IsRequired()
                        .HasMaxLength(36)
                        .HasColumnType("varchar");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(8,2)");

                    b.Property<string>("Product_Id")
                        .IsRequired()
                        .HasMaxLength(36)
                        .HasColumnType("varchar");

                    b.Property<string>("Product_Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar");

                    b.Property<int>("Qty")
                        .HasColumnType("int");

                    b.Property<string>("Size")
                        .HasMaxLength(100)
                        .HasColumnType("varchar");

                    b.Property<decimal>("SubTotal")
                        .HasColumnType("decimal(8,2)");

                    b.Property<decimal>("Total")
                        .HasColumnType("decimal(8,2)");

                    b.HasKey("Id");

                    b.HasIndex("Order_Id");

                    b.HasIndex("Product_Id");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("POS_WebAPI.Models.EntityModel.Product", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(36)
                        .HasColumnType("varchar");

                    b.Property<string>("Category_Id")
                        .IsRequired()
                        .HasMaxLength(36)
                        .HasColumnType("varchar");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(36)
                        .HasColumnType("varchar");

                    b.Property<string>("Company_Id")
                        .IsRequired()
                        .HasMaxLength(36)
                        .HasColumnType("varchar");

                    b.Property<string>("Company_Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar");

                    b.Property<decimal>("Cost")
                        .HasColumnType("decimal(8,2)");

                    b.Property<DateTime>("Create_At")
                        .HasColumnType("datetime");

                    b.Property<string>("Create_By")
                        .IsRequired()
                        .HasMaxLength(36)
                        .HasColumnType("varchar");

                    b.Property<string>("Description")
                        .HasMaxLength(255)
                        .HasColumnType("varchar");

                    b.Property<string>("Image")
                        .HasMaxLength(550)
                        .HasColumnType("varchar");

                    b.Property<bool>("Is_Deleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("Last_Update")
                        .HasColumnType("datetime");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar");

                    b.Property<string>("NameKh")
                        .HasMaxLength(255)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(8,2)");

                    b.Property<int>("Qty")
                        .HasColumnType("int");

                    b.Property<string>("Size")
                        .HasMaxLength(255)
                        .HasColumnType("varchar");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Category_Id");

                    b.HasIndex("Code")
                        .IsUnique();

                    b.HasIndex("Create_By");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("POS_WebAPI.Models.EntityModel.Receipt", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(36)
                        .HasColumnType("varchar");

                    b.Property<decimal?>("Discount")
                        .IsRequired()
                        .HasColumnType("decimal(8,2)");

                    b.Property<string>("Order_Id")
                        .HasMaxLength(36)
                        .HasColumnType("varchar");

                    b.Property<string>("Reference")
                        .HasMaxLength(36)
                        .HasColumnType("varchar");

                    b.Property<decimal>("Total")
                        .HasColumnType("decimal(8,2)");

                    b.Property<DateTime>("Transaction_Date")
                        .HasColumnType("datetime");

                    b.HasKey("Id");

                    b.HasIndex("Order_Id");

                    b.HasIndex("Reference");

                    b.ToTable("Receipts");
                });

            modelBuilder.Entity("POS_WebAPI.Models.EntityModel.Role", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(36)
                        .HasColumnType("varchar");

                    b.Property<DateTime>("Create_At")
                        .HasColumnType("datetime");

                    b.Property<string>("Description")
                        .HasMaxLength(255)
                        .HasColumnType("varchar");

                    b.Property<bool?>("Is_Deleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("POS_WebAPI.Models.EntityModel.Source", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(36)
                        .HasColumnType("varchar");

                    b.Property<DateTime>("Create_At")
                        .HasColumnType("datetime");

                    b.Property<string>("Desctiption")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar");

                    b.Property<bool>("Is_Deleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Sources");
                });

            modelBuilder.Entity("POS_WebAPI.Models.EntityModel.SubCategory", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(36)
                        .HasColumnType("varchar");

                    b.Property<DateTime>("Create_At")
                        .HasColumnType("datetime");

                    b.Property<string>("Description")
                        .HasMaxLength(255)
                        .HasColumnType("varchar");

                    b.Property<string>("Image")
                        .HasMaxLength(550)
                        .HasColumnType("varchar");

                    b.Property<bool>("Is_Deleted")
                        .HasColumnType("bit");

                    b.Property<string>("Main_Category_Id")
                        .IsRequired()
                        .HasMaxLength(36)
                        .HasColumnType("varchar");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Main_Category_Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("SubCategories");
                });

            modelBuilder.Entity("POS_WebAPI.Models.EntityModel.SystemType", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(36)
                        .HasColumnType("varchar");

                    b.Property<DateTime>("Create_At")
                        .HasColumnType("datetime");

                    b.Property<bool?>("Is_Deleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("SystemTypes");
                });

            modelBuilder.Entity("POS_WebAPI.Models.EntityModel.User", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(36)
                        .HasColumnType("varchar");

                    b.Property<string>("Address")
                        .HasMaxLength(550)
                        .HasColumnType("nvarchar");

                    b.Property<string>("Company_Id")
                        .IsRequired()
                        .HasMaxLength(36)
                        .HasColumnType("varchar");

                    b.Property<string>("Contact")
                        .IsRequired()
                        .HasMaxLength(12)
                        .HasColumnType("varchar");

                    b.Property<DateTime>("Create_At")
                        .HasColumnType("datetime");

                    b.Property<string>("Email")
                        .HasMaxLength(100)
                        .HasColumnType("varchar");

                    b.Property<int?>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .HasMaxLength(550)
                        .HasColumnType("varchar");

                    b.Property<bool?>("Is_Deleted")
                        .IsRequired()
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar");

                    b.Property<string>("Role_Id")
                        .IsRequired()
                        .HasMaxLength(36)
                        .HasColumnType("varchar");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Token")
                        .HasMaxLength(550)
                        .HasColumnType("nvarchar");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar");

                    b.HasKey("Id");

                    b.HasIndex("Company_Id");

                    b.HasIndex("Role_Id");

                    b.HasIndex("UserName")
                        .IsUnique();

                    b.ToTable("Users");
                });

            modelBuilder.Entity("POS_WebAPI.Models.EntityModel.UserLog", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(36)
                        .HasColumnType("varchar");

                    b.Property<int>("Action")
                        .HasColumnType("int");

                    b.Property<DateTime>("Create_At")
                        .HasColumnType("datetime");

                    b.Property<string>("User_Id")
                        .IsRequired()
                        .HasMaxLength(36)
                        .HasColumnType("varchar");

                    b.Property<string>("User_Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar");

                    b.Property<string>("User_Type")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar");

                    b.HasKey("Id");

                    b.HasIndex("User_Id");

                    b.ToTable("User_Logs", (string)null);
                });

            modelBuilder.Entity("POS_WebAPI.Models.EntityModel.Company", b =>
                {
                    b.HasOne("POS_WebAPI.Models.EntityModel.SystemType", "SystemType")
                        .WithMany("Companies")
                        .HasForeignKey("System_Id")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("SystemType");
                });

            modelBuilder.Entity("POS_WebAPI.Models.EntityModel.Order", b =>
                {
                    b.HasOne("POS_WebAPI.Models.EntityModel.User", "User")
                        .WithMany("Orders")
                        .HasForeignKey("Reference_Id")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.HasOne("POS_WebAPI.Models.EntityModel.Source", "Source")
                        .WithMany("Orders")
                        .HasForeignKey("Source_Id")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.Navigation("Source");

                    b.Navigation("User");
                });

            modelBuilder.Entity("POS_WebAPI.Models.EntityModel.OrderDetail", b =>
                {
                    b.HasOne("POS_WebAPI.Models.EntityModel.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("Order_Id")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("POS_WebAPI.Models.EntityModel.Product", "Product")
                        .WithMany("OrderDetails")
                        .HasForeignKey("Product_Id")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("POS_WebAPI.Models.EntityModel.Product", b =>
                {
                    b.HasOne("POS_WebAPI.Models.EntityModel.SubCategory", "SubCategory")
                        .WithMany("Products")
                        .HasForeignKey("Category_Id")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("POS_WebAPI.Models.EntityModel.User", "User")
                        .WithMany("Products")
                        .HasForeignKey("Create_By")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("SubCategory");

                    b.Navigation("User");
                });

            modelBuilder.Entity("POS_WebAPI.Models.EntityModel.Receipt", b =>
                {
                    b.HasOne("POS_WebAPI.Models.EntityModel.Order", "Order")
                        .WithMany("Receipts")
                        .HasForeignKey("Order_Id")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.HasOne("POS_WebAPI.Models.EntityModel.User", "User")
                        .WithMany("Receipts")
                        .HasForeignKey("Reference")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.Navigation("Order");

                    b.Navigation("User");
                });

            modelBuilder.Entity("POS_WebAPI.Models.EntityModel.SubCategory", b =>
                {
                    b.HasOne("POS_WebAPI.Models.EntityModel.Category", "Category")
                        .WithMany("SubCategories")
                        .HasForeignKey("Main_Category_Id")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("POS_WebAPI.Models.EntityModel.User", b =>
                {
                    b.HasOne("POS_WebAPI.Models.EntityModel.Company", "Company")
                        .WithMany("Users")
                        .HasForeignKey("Company_Id")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("POS_WebAPI.Models.EntityModel.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("Role_Id")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Company");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("POS_WebAPI.Models.EntityModel.UserLog", b =>
                {
                    b.HasOne("POS_WebAPI.Models.EntityModel.User", "User")
                        .WithMany("UserLog")
                        .HasForeignKey("User_Id")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("POS_WebAPI.Models.EntityModel.Category", b =>
                {
                    b.Navigation("SubCategories");
                });

            modelBuilder.Entity("POS_WebAPI.Models.EntityModel.Company", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("POS_WebAPI.Models.EntityModel.Order", b =>
                {
                    b.Navigation("OrderDetails");

                    b.Navigation("Receipts");
                });

            modelBuilder.Entity("POS_WebAPI.Models.EntityModel.Product", b =>
                {
                    b.Navigation("OrderDetails");
                });

            modelBuilder.Entity("POS_WebAPI.Models.EntityModel.Role", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("POS_WebAPI.Models.EntityModel.Source", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("POS_WebAPI.Models.EntityModel.SubCategory", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("POS_WebAPI.Models.EntityModel.SystemType", b =>
                {
                    b.Navigation("Companies");
                });

            modelBuilder.Entity("POS_WebAPI.Models.EntityModel.User", b =>
                {
                    b.Navigation("Orders");

                    b.Navigation("Products");

                    b.Navigation("Receipts");

                    b.Navigation("UserLog");
                });
#pragma warning restore 612, 618
        }
    }
}
