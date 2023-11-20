using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    public partial class StatusBoolENaoString : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "Status",
                table: "Tarefas",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "CategoriaId",
                keyValue: 1,
                column: "CriadoEm",
                value: new DateTime(2023, 11, 21, 19, 45, 50, 552, DateTimeKind.Local).AddTicks(318));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "CategoriaId",
                keyValue: 2,
                column: "CriadoEm",
                value: new DateTime(2023, 11, 22, 19, 45, 50, 552, DateTimeKind.Local).AddTicks(323));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "CategoriaId",
                keyValue: 3,
                column: "CriadoEm",
                value: new DateTime(2023, 11, 23, 19, 45, 50, 552, DateTimeKind.Local).AddTicks(324));

            migrationBuilder.UpdateData(
                table: "Tarefas",
                keyColumn: "TarefaId",
                keyValue: 1,
                columns: new[] { "CriadoEm", "Status" },
                values: new object[] { new DateTime(2023, 11, 27, 19, 45, 50, 552, DateTimeKind.Local).AddTicks(389), false });

            migrationBuilder.UpdateData(
                table: "Tarefas",
                keyColumn: "TarefaId",
                keyValue: 2,
                columns: new[] { "CriadoEm", "Status" },
                values: new object[] { new DateTime(2023, 11, 23, 19, 45, 50, 552, DateTimeKind.Local).AddTicks(391), false });

            migrationBuilder.UpdateData(
                table: "Tarefas",
                keyColumn: "TarefaId",
                keyValue: 3,
                columns: new[] { "CriadoEm", "Status" },
                values: new object[] { new DateTime(2023, 12, 4, 19, 45, 50, 552, DateTimeKind.Local).AddTicks(393), false });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "Tarefas",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "INTEGER",
                oldNullable: true);

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
    }
}
