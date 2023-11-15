using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetoAGA.Migrations
{
    public partial class UserUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Idade",
                table: "Professor",
                newName: "NumeroEndereco");

            migrationBuilder.RenameColumn(
                name: "Idade",
                table: "Coordenador",
                newName: "NumeroEndereco");

            migrationBuilder.RenameColumn(
                name: "Idade",
                table: "Aluno",
                newName: "NumeroEndereco");

            migrationBuilder.RenameColumn(
                name: "Idade",
                table: "Admin",
                newName: "NumeroEndereco");

            migrationBuilder.AddColumn<string>(
                name: "Bairro",
                table: "Professor",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Cidade",
                table: "Professor",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<DateTime>(
                name: "DatadeNascimento",
                table: "Professor",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Bairro",
                table: "Coordenador",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Cidade",
                table: "Coordenador",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<DateTime>(
                name: "DatadeNascimento",
                table: "Coordenador",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Bairro",
                table: "Aluno",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Cidade",
                table: "Aluno",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<DateTime>(
                name: "DatadeNascimento",
                table: "Aluno",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Bairro",
                table: "Admin",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Cidade",
                table: "Admin",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<DateTime>(
                name: "DatadeNascimento",
                table: "Admin",
                type: "datetime(6)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Bairro",
                table: "Professor");

            migrationBuilder.DropColumn(
                name: "Cidade",
                table: "Professor");

            migrationBuilder.DropColumn(
                name: "DatadeNascimento",
                table: "Professor");

            migrationBuilder.DropColumn(
                name: "Bairro",
                table: "Coordenador");

            migrationBuilder.DropColumn(
                name: "Cidade",
                table: "Coordenador");

            migrationBuilder.DropColumn(
                name: "DatadeNascimento",
                table: "Coordenador");

            migrationBuilder.DropColumn(
                name: "Bairro",
                table: "Aluno");

            migrationBuilder.DropColumn(
                name: "Cidade",
                table: "Aluno");

            migrationBuilder.DropColumn(
                name: "DatadeNascimento",
                table: "Aluno");

            migrationBuilder.DropColumn(
                name: "Bairro",
                table: "Admin");

            migrationBuilder.DropColumn(
                name: "Cidade",
                table: "Admin");

            migrationBuilder.DropColumn(
                name: "DatadeNascimento",
                table: "Admin");

            migrationBuilder.RenameColumn(
                name: "NumeroEndereco",
                table: "Professor",
                newName: "Idade");

            migrationBuilder.RenameColumn(
                name: "NumeroEndereco",
                table: "Coordenador",
                newName: "Idade");

            migrationBuilder.RenameColumn(
                name: "NumeroEndereco",
                table: "Aluno",
                newName: "Idade");

            migrationBuilder.RenameColumn(
                name: "NumeroEndereco",
                table: "Admin",
                newName: "Idade");
        }
    }
}
