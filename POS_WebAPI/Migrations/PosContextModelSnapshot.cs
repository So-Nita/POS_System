﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using POS_WebAPI.DataContext;

#nullable disable

namespace POS_WebAPI.Migrations
{
    [DbContext(typeof(PosContext))]
    partial class PosContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.ToTable("Categories");
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

            modelBuilder.Entity("POS_WebAPI.Models.EntityModel.Customer", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(36)
                        .HasColumnType("varchar");

                    b.Property<string>("Address")
                        .HasMaxLength(12)
                        .HasColumnType("varchar");

                    b.Property<string>("Contact")
                        .IsRequired()
                        .HasMaxLength(12)
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

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("POS_WebAPI.Models.EntityModel.Order", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(36)
                        .HasColumnType("varchar");

                    b.Property<DateTime>("Create_At")
                        .HasColumnType("datetime2");

                    b.Property<string>("CustomerName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar");

                    b.Property<string>("Customer_Id")
                        .HasMaxLength(36)
                        .HasColumnType("varchar");

                    b.Property<bool?>("Is_Delete")
                        .HasColumnType("bit");

                    b.Property<int>("OrderStatus")
                        .HasColumnType("int");

                    b.Property<string>("Table_Id")
                        .HasMaxLength(36)
                        .HasColumnType("varchar");

                    b.Property<decimal>("Total")
                        .HasColumnType("decimal(8,2)");

                    b.Property<int>("TotalItem")
                        .HasColumnType("int");

                    b.Property<string>("User_Id")
                        .IsRequired()
                        .HasMaxLength(36)
                        .HasColumnType("varchar");

                    b.HasKey("Id");

                    b.HasIndex("Customer_Id");

                    b.HasIndex("Table_Id");

                    b.HasIndex("User_Id");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("POS_WebAPI.Models.EntityModel.OrderDetail", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(36)
                        .HasColumnType("varchar");

                    b.Property<DateTime>("Create_At")
                        .HasColumnType("datetime");

                    b.Property<decimal>("GrandTotal")
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
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar");

                    b.Property<decimal>("Tax")
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

                    b.Property<decimal>("Cost")
                        .HasColumnType("decimal(8,2)");

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

                    b.Property<string>("NameKh")
                        .HasMaxLength(255)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(8,2)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Category_Id");

                    b.HasIndex("Code")
                        .IsUnique();

                    b.HasIndex("Company_Id");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("POS_WebAPI.Models.EntityModel.Role", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(36)
                        .HasColumnType("varchar");

                    b.Property<DateTime>("Create_At")
                        .HasColumnType("datetime");

                    b.Property<string>("Description")
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

            modelBuilder.Entity("POS_WebAPI.Models.EntityModel.Table", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(36)
                        .HasColumnType("varchar");

                    b.Property<DateTime>("Create_At")
                        .HasColumnType("datetime");

                    b.Property<string>("Description")
                        .HasColumnType("varchar");

                    b.Property<bool?>("Is_Deleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar");

                    b.Property<string>("Size")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Tables");
                });

            modelBuilder.Entity("POS_WebAPI.Models.EntityModel.User", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(36)
                        .HasColumnType("varchar");

                    b.Property<string>("Address")
                        .HasColumnType("varchar");

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
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .HasColumnType("varchar");

                    b.Property<bool?>("Is_Deleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasMaxLength(100)
                        .HasColumnType("varchar");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar");

                    b.Property<string>("Role_Id")
                        .IsRequired()
                        .HasMaxLength(36)
                        .HasColumnType("varchar");

                    b.Property<int>("Status")
                        .HasColumnType("int");

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
                    b.HasOne("POS_WebAPI.Models.EntityModel.Customer", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("Customer_Id")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.HasOne("POS_WebAPI.Models.EntityModel.Table", "Table")
                        .WithMany("Orders")
                        .HasForeignKey("Table_Id")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.HasOne("POS_WebAPI.Models.EntityModel.User", "User")
                        .WithMany("Orders")
                        .HasForeignKey("User_Id")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Table");

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

                    b.HasOne("POS_WebAPI.Models.EntityModel.Company", "Company")
                        .WithMany("Products")
                        .HasForeignKey("Company_Id")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Company");

                    b.Navigation("SubCategory");
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

            modelBuilder.Entity("POS_WebAPI.Models.EntityModel.Category", b =>
                {
                    b.Navigation("SubCategories");
                });

            modelBuilder.Entity("POS_WebAPI.Models.EntityModel.Company", b =>
                {
                    b.Navigation("Products");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("POS_WebAPI.Models.EntityModel.Customer", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("POS_WebAPI.Models.EntityModel.Order", b =>
                {
                    b.Navigation("OrderDetails");
                });

            modelBuilder.Entity("POS_WebAPI.Models.EntityModel.Product", b =>
                {
                    b.Navigation("OrderDetails");
                });

            modelBuilder.Entity("POS_WebAPI.Models.EntityModel.Role", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("POS_WebAPI.Models.EntityModel.SubCategory", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("POS_WebAPI.Models.EntityModel.SystemType", b =>
                {
                    b.Navigation("Companies");
                });

            modelBuilder.Entity("POS_WebAPI.Models.EntityModel.Table", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("POS_WebAPI.Models.EntityModel.User", b =>
                {
                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
