﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication6.Models;

namespace WebApplication6.Migrations
{
    [DbContext(typeof(WebApplication6Context))]
    partial class WebApplication6ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.0-rtm-30799")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebApplication6.Models.Curso", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Capacidad");

                    b.Property<string>("Descripcion")
                        .IsRequired();

                    b.Property<DateTime>("FinDeCurso");

                    b.Property<DateTime>("InicioDeCurso");

                    b.Property<string>("Nombre")
                        .IsRequired();

                    b.Property<string>("Responsable")
                        .IsRequired();

                    b.HasKey("ID");

                    b.ToTable("Curso");
                });

            modelBuilder.Entity("WebApplication6.Models.Estudiante", b =>
                {
                    b.Property<string>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Apellido")
                        .IsRequired();

                    b.Property<int>("CursoID");

                    b.Property<int>("Edad");

                    b.Property<string>("Grado")
                        .IsRequired()
                        .HasConversion(new ValueConverter<string, string>(v => default(string), v => default(string), new ConverterMappingHints(size: 1)));

                    b.Property<string>("Matricula")
                        .IsRequired();

                    b.Property<string>("Nombre")
                        .IsRequired();

                    b.HasKey("ID");

                    b.HasIndex("CursoID");

                    b.ToTable("Estudiante");
                });

            modelBuilder.Entity("WebApplication6.Models.Estudiante", b =>
                {
                    b.HasOne("WebApplication6.Models.Curso", "Curso")
                        .WithMany("Estudiantes")
                        .HasForeignKey("CursoID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
