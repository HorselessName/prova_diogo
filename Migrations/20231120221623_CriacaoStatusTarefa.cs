using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    public partial class CriacaoStatusTarefa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Tarefas",
                type: "TEXT",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "CategoriaId",
                keyValue: 1,
                column: "CriadoEm",
                value: new DateTime(2023, 11, 21, 19, 16, 23, 207, DateTimeKind.Local).AddTicks(3755));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "CategoriaId",
                keyValue: 2,
                column: "CriadoEm",
                value: new DateTime(2023, 11, 22, 19, 16, 23, 207, DateTimeKind.Local).AddTicks(3759));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "CategoriaId",
                keyValue: 3,
                column: "CriadoEm",
                value: new DateTime(2023, 11, 23, 19, 16, 23, 207, DateTimeKind.Local).AddTicks(3760));

            migrationBuilder.UpdateData(
                table: "Tarefas",
                keyColumn: "TarefaId",
                keyValue: 1,
                columns: new[] { "CriadoEm", "Status" },
                values: new object[] { new DateTime(2023, 11, 27, 19, 16, 23, 207, DateTimeKind.Local).AddTicks(3828), "0" });

            migrationBuilder.UpdateData(
                table: "Tarefas",
                keyColumn: "TarefaId",
                keyValue: 2,
                columns: new[] { "CriadoEm", "Status" },
                values: new object[] { new DateTime(2023, 11, 23, 19, 16, 23, 207, DateTimeKind.Local).AddTicks(3830), "0" });

            migrationBuilder.UpdateData(
                table: "Tarefas",
                keyColumn: "TarefaId",
                keyValue: 3,
                columns: new[] { "CriadoEm", "Status" },
                values: new object[] { new DateTime(2023, 12, 4, 19, 16, 23, 207, DateTimeKind.Local).AddTicks(3831), "0" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "Tarefas");

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "CategoriaId",
                keyValue: 1,
                column: "CriadoEm",
                value: new DateTime(2023, 11, 21, 18, 45, 46, 646, DateTimeKind.Local).AddTicks(713));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "CategoriaId",
                keyValue: 2,
                column: "CriadoEm",
                value: new DateTime(2023, 11, 22, 18, 45, 46, 646, DateTimeKind.Local).AddTicks(717));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "CategoriaId",
                keyValue: 3,
                column: "CriadoEm",
                value: new DateTime(2023, 11, 23, 18, 45, 46, 646, DateTimeKind.Local).AddTicks(718));

            migrationBuilder.UpdateData(
                table: "Tarefas",
                keyColumn: "TarefaId",
                keyValue: 1,
                column: "CriadoEm",
                value: new DateTime(2023, 11, 27, 18, 45, 46, 646, DateTimeKind.Local).AddTicks(786));

            migrationBuilder.UpdateData(
                table: "Tarefas",
                keyColumn: "TarefaId",
                keyValue: 2,
                column: "CriadoEm",
                value: new DateTime(2023, 11, 23, 18, 45, 46, 646, DateTimeKind.Local).AddTicks(789));

            migrationBuilder.UpdateData(
                table: "Tarefas",
                keyColumn: "TarefaId",
                keyValue: 3,
                column: "CriadoEm",
                value: new DateTime(2023, 12, 4, 18, 45, 46, 646, DateTimeKind.Local).AddTicks(790));
        }
    }
}
