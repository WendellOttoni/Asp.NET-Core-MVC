﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace LivrariaControleEmprestimo.DATA.Models;

public partial class BibliotecaContext : DbContext
{
    public BibliotecaContext()
    {
    }

    public BibliotecaContext(DbContextOptions<BibliotecaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Cliente> Clientes { get; set; }

    public virtual DbSet<Livro> Livros { get; set; }

    public virtual DbSet<LivroClienteEmprestimo> LivroClienteEmprestimos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=LAPTOP-SL0V3D0T\\SQLSERVER;Initial Catalog=Biblioteca;User ID=sa;Password=sa@1234;Encrypt=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<LivroClienteEmprestimo>(entity =>
        {
            entity.HasOne(d => d.IdClienteNavigation).WithMany(p => p.LivroClienteEmprestimos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Livro_Cliente_Emprestimo_Cliente");

            entity.HasOne(d => d.IdLivroNavigation).WithMany(p => p.LivroClienteEmprestimos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Livro_Cliente_Emprestimo_Livro");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}