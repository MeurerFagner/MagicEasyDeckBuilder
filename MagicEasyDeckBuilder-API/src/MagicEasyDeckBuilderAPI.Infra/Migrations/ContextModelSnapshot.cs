﻿// <auto-generated />
using System;
using MagicEasyDeckBuilderAPI.Infra;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace MagicEasyDeckBuilderAPI.Infra.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("MagicEasyDeckBuilderAPI.Dominio.Entidades.Carta", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<bool>("CardDuplo")
                        .HasColumnType("boolean");

                    b.Property<string>("Cores")
                        .HasColumnType("text");

                    b.Property<string>("CustoMana")
                        .HasColumnType("text");

                    b.Property<Guid?>("IdOutroLado")
                        .HasColumnType("uuid");

                    b.Property<string>("IdScryfall")
                        .HasColumnType("text");

                    b.Property<string>("IdentidadeDeCor")
                        .HasColumnType("text");

                    b.Property<string>("Keywords")
                        .HasColumnType("text");

                    b.Property<int>("Lealdade")
                        .HasColumnType("integer");

                    b.Property<string>("LegalidadePorFormato")
                        .HasColumnType("text");

                    b.Property<string>("Nome")
                        .HasColumnType("text");

                    b.Property<string>("NomeOriginal")
                        .HasColumnType("text");

                    b.Property<string>("Poder")
                        .HasColumnType("text");

                    b.Property<string>("Raridade")
                        .HasColumnType("text");

                    b.Property<string>("Resistencia")
                        .HasColumnType("text");

                    b.Property<string>("Texto")
                        .HasColumnType("text");

                    b.Property<string>("TextoOriginal")
                        .HasColumnType("text");

                    b.Property<string>("Tipo")
                        .HasColumnType("text");

                    b.Property<string>("UrlApi")
                        .HasColumnType("text");

                    b.Property<string>("UrlCropImage")
                        .HasColumnType("text");

                    b.Property<string>("UrlImage")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("IdOutroLado")
                        .IsUnique();

                    b.ToTable("Carta");
                });

            modelBuilder.Entity("MagicEasyDeckBuilderAPI.Dominio.Entidades.CartaDeck", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<bool>("Comandante")
                        .HasColumnType("boolean");

                    b.Property<string>("Erros")
                        .HasColumnType("text");

                    b.Property<Guid>("IdCarta")
                        .HasColumnType("uuid");

                    b.Property<Guid>("IdDeck")
                        .HasColumnType("uuid");

                    b.Property<int>("Quantidade")
                        .HasColumnType("integer");

                    b.Property<string>("TipoDeck")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("IdCarta");

                    b.HasIndex("IdDeck");

                    b.ToTable("CartaDeck");
                });

            modelBuilder.Entity("MagicEasyDeckBuilderAPI.Dominio.Entidades.Deck", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Erros")
                        .HasColumnType("text");

                    b.Property<Guid>("IdUsuario")
                        .HasColumnType("uuid");

                    b.Property<string>("Nome")
                        .HasColumnType("text");

                    b.Property<string>("TipoFormato")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("IdUsuario");

                    b.ToTable("Decks");
                });

            modelBuilder.Entity("MagicEasyDeckBuilderAPI.Dominio.Entidades.Usuario", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("DataCadastro")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("Nome")
                        .HasColumnType("text");

                    b.Property<string>("Senha")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("MagicEasyDeckBuilderAPI.Dominio.Entidades.Carta", b =>
                {
                    b.HasOne("MagicEasyDeckBuilderAPI.Dominio.Entidades.Carta", "OutroLado")
                        .WithOne()
                        .HasForeignKey("MagicEasyDeckBuilderAPI.Dominio.Entidades.Carta", "IdOutroLado");

                    b.Navigation("OutroLado");
                });

            modelBuilder.Entity("MagicEasyDeckBuilderAPI.Dominio.Entidades.CartaDeck", b =>
                {
                    b.HasOne("MagicEasyDeckBuilderAPI.Dominio.Entidades.Carta", "Carta")
                        .WithMany("DeckCartas")
                        .HasForeignKey("IdCarta")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MagicEasyDeckBuilderAPI.Dominio.Entidades.Deck", "Deck")
                        .WithMany("Cartas")
                        .HasForeignKey("IdDeck")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Carta");

                    b.Navigation("Deck");
                });

            modelBuilder.Entity("MagicEasyDeckBuilderAPI.Dominio.Entidades.Deck", b =>
                {
                    b.HasOne("MagicEasyDeckBuilderAPI.Dominio.Entidades.Usuario", "Usuario")
                        .WithMany("Decks")
                        .HasForeignKey("IdUsuario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("MagicEasyDeckBuilderAPI.Dominio.Entidades.Carta", b =>
                {
                    b.Navigation("DeckCartas");
                });

            modelBuilder.Entity("MagicEasyDeckBuilderAPI.Dominio.Entidades.Deck", b =>
                {
                    b.Navigation("Cartas");
                });

            modelBuilder.Entity("MagicEasyDeckBuilderAPI.Dominio.Entidades.Usuario", b =>
                {
                    b.Navigation("Decks");
                });
#pragma warning restore 612, 618
        }
    }
}
