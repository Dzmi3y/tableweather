﻿// <auto-generated />
using GetWeatherApi.DbConnection;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace GetWeatherApi.Migrations
{
    [DbContext(typeof(WeatherContext))]
    [Migration("20190913070522_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("GetWeatherApi.Entities.WeatherEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CityName");

                    b.Property<decimal>("Temperature");

                    b.HasKey("Id");

                    b.ToTable("WeatherEntities");
                });
#pragma warning restore 612, 618
        }
    }
}
