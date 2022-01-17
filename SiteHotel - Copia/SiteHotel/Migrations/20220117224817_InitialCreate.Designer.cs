﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SiteHotel.Repository;

namespace SiteHotel.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20220117224817_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SiteHotel.Models.Hotel.Entities.Apartamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("QuantidadeDormitorios")
                        .HasColumnType("int");

                    b.Property<decimal>("ValorDiaria")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Apartamento");
                });

            modelBuilder.Entity("SiteHotel.Models.Hotel.Entities.Imagens", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ApartamentoId")
                        .HasColumnType("int");

                    b.Property<byte[]>("Imagem")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("NomeImagens")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ApartamentoId");

                    b.ToTable("Imagens");
                });

            modelBuilder.Entity("SiteHotel.Models.Hotel.Entities.Reserva", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ApartamentoId")
                        .HasColumnType("int");

                    b.Property<int>("ApartmentoId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataFinal")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataInicial")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataSolicitacao")
                        .HasColumnType("datetime2");

                    b.Property<int>("DiasDuracao")
                        .HasColumnType("int");

                    b.Property<int>("PessoaId")
                        .HasColumnType("int");

                    b.Property<decimal>("Valor")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("ApartamentoId");

                    b.HasIndex("PessoaId");

                    b.ToTable("Reserva");
                });

            modelBuilder.Entity("SiteHotel.Models.Usuario.Entities.Endereco", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Bairro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cep")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cidade")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Complemento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PessoaId")
                        .HasColumnType("int");

                    b.Property<string>("Rua")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Uf")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("PessoaId")
                        .IsUnique();

                    b.ToTable("Endereco");
                });

            modelBuilder.Entity("SiteHotel.Models.Usuario.Entities.Login", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PessoaId")
                        .HasColumnType("int");

                    b.Property<string>("Senha")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("PessoaId")
                        .IsUnique();

                    b.ToTable("Login");
                });

            modelBuilder.Entity("SiteHotel.Models.Usuario.Entities.Pessoa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cpf")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EstadoCivil")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("Foto")
                        .HasColumnType("varbinary(max)");

                    b.Property<DateTime>("Nascimento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sexo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Pessoa");
                });

            modelBuilder.Entity("SiteHotel.Models.Hotel.Entities.Imagens", b =>
                {
                    b.HasOne("SiteHotel.Models.Hotel.Entities.Apartamento", "Apartamento")
                        .WithMany("Imagens")
                        .HasForeignKey("ApartamentoId")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();

                    b.Navigation("Apartamento");
                });

            modelBuilder.Entity("SiteHotel.Models.Hotel.Entities.Reserva", b =>
                {
                    b.HasOne("SiteHotel.Models.Hotel.Entities.Apartamento", "Apartamento")
                        .WithMany("Reserva")
                        .HasForeignKey("ApartamentoId")
                        .OnDelete(DeleteBehavior.ClientCascade);

                    b.HasOne("SiteHotel.Models.Usuario.Entities.Pessoa", "Pessoa")
                        .WithMany("Reserva")
                        .HasForeignKey("PessoaId")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();

                    b.Navigation("Apartamento");

                    b.Navigation("Pessoa");
                });

            modelBuilder.Entity("SiteHotel.Models.Usuario.Entities.Endereco", b =>
                {
                    b.HasOne("SiteHotel.Models.Usuario.Entities.Pessoa", "Pessoa")
                        .WithOne("Enderecos")
                        .HasForeignKey("SiteHotel.Models.Usuario.Entities.Endereco", "PessoaId")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();

                    b.Navigation("Pessoa");
                });

            modelBuilder.Entity("SiteHotel.Models.Usuario.Entities.Login", b =>
                {
                    b.HasOne("SiteHotel.Models.Usuario.Entities.Pessoa", "Pessoa")
                        .WithOne("Login")
                        .HasForeignKey("SiteHotel.Models.Usuario.Entities.Login", "PessoaId")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();

                    b.Navigation("Pessoa");
                });

            modelBuilder.Entity("SiteHotel.Models.Hotel.Entities.Apartamento", b =>
                {
                    b.Navigation("Imagens");

                    b.Navigation("Reserva");
                });

            modelBuilder.Entity("SiteHotel.Models.Usuario.Entities.Pessoa", b =>
                {
                    b.Navigation("Enderecos");

                    b.Navigation("Login");

                    b.Navigation("Reserva");
                });
#pragma warning restore 612, 618
        }
    }
}