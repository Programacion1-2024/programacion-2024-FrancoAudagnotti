using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CDatos.Migrations
{
    /// <inheritdoc />
    public partial class TablasRelaciones : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Autor_Persona_PersonaClienteIdPersona",
                table: "Autor");

            migrationBuilder.DropForeignKey(
                name: "FK_AutorLibro_Autor_AutorAutorLibroIdAutor",
                table: "AutorLibro");

            migrationBuilder.DropForeignKey(
                name: "FK_AutorLibro_Libro_LibroAutorLibroIdLibro",
                table: "AutorLibro");

            migrationBuilder.DropForeignKey(
                name: "FK_Cliente_Persona_PersonaClienteIdPersona",
                table: "Cliente");

            migrationBuilder.DropForeignKey(
                name: "FK_Empleado_Persona_PersonaEmpleadoIdPersona",
                table: "Empleado");

            migrationBuilder.DropForeignKey(
                name: "FK_GeneroLibro_Genero_IdGenero1",
                table: "GeneroLibro");

            migrationBuilder.DropForeignKey(
                name: "FK_GeneroLibro_Libro_IdLibro1",
                table: "GeneroLibro");

            migrationBuilder.DropForeignKey(
                name: "FK_Libro_Editorial_IdEditorial1",
                table: "Libro");

            migrationBuilder.DropIndex(
                name: "IX_Empleado_PersonaEmpleadoIdPersona",
                table: "Empleado");

            migrationBuilder.DropIndex(
                name: "IX_Cliente_PersonaClienteIdPersona",
                table: "Cliente");

            migrationBuilder.DropIndex(
                name: "IX_Autor_PersonaClienteIdPersona",
                table: "Autor");

            migrationBuilder.DropColumn(
                name: "PersonaEmpleadoIdPersona",
                table: "Empleado");

            migrationBuilder.DropColumn(
                name: "PersonaClienteIdPersona",
                table: "Cliente");

            migrationBuilder.RenameColumn(
                name: "IdEditorial1",
                table: "Libro",
                newName: "IdEditorial");

            migrationBuilder.RenameIndex(
                name: "IX_Libro_IdEditorial1",
                table: "Libro",
                newName: "IX_Libro_IdEditorial");

            migrationBuilder.RenameColumn(
                name: "IdLibro1",
                table: "GeneroLibro",
                newName: "IdLibro");

            migrationBuilder.RenameColumn(
                name: "IdGenero1",
                table: "GeneroLibro",
                newName: "IdGenero");

            migrationBuilder.RenameIndex(
                name: "IX_GeneroLibro_IdLibro1",
                table: "GeneroLibro",
                newName: "IX_GeneroLibro_IdLibro");

            migrationBuilder.RenameIndex(
                name: "IX_GeneroLibro_IdGenero1",
                table: "GeneroLibro",
                newName: "IX_GeneroLibro_IdGenero");

            migrationBuilder.RenameColumn(
                name: "LibroAutorLibroIdLibro",
                table: "AutorLibro",
                newName: "IdLibro");

            migrationBuilder.RenameColumn(
                name: "AutorAutorLibroIdAutor",
                table: "AutorLibro",
                newName: "IdAutor");

            migrationBuilder.RenameIndex(
                name: "IX_AutorLibro_LibroAutorLibroIdLibro",
                table: "AutorLibro",
                newName: "IX_AutorLibro_IdLibro");

            migrationBuilder.RenameIndex(
                name: "IX_AutorLibro_AutorAutorLibroIdAutor",
                table: "AutorLibro",
                newName: "IX_AutorLibro_IdAutor");

            migrationBuilder.RenameColumn(
                name: "PersonaClienteIdPersona",
                table: "Autor",
                newName: "CantidadLibrosEscritos");

            migrationBuilder.AddColumn<int>(
                name: "IdCliente",
                table: "Venta",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdFormaPago",
                table: "Venta",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdCliente",
                table: "Prestamo",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdCopia",
                table: "Prestamo",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdFormaPago",
                table: "Prestamo",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdPersona",
                table: "Empleado",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdLibro",
                table: "Copia",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdPersona",
                table: "Cliente",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdPersona",
                table: "Autor",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Venta_IdCliente",
                table: "Venta",
                column: "IdCliente");

            migrationBuilder.CreateIndex(
                name: "IX_Venta_IdFormaPago",
                table: "Venta",
                column: "IdFormaPago");

            migrationBuilder.CreateIndex(
                name: "IX_Prestamo_IdCliente",
                table: "Prestamo",
                column: "IdCliente");

            migrationBuilder.CreateIndex(
                name: "IX_Prestamo_IdCopia",
                table: "Prestamo",
                column: "IdCopia");

            migrationBuilder.CreateIndex(
                name: "IX_Prestamo_IdFormaPago",
                table: "Prestamo",
                column: "IdFormaPago");

            migrationBuilder.CreateIndex(
                name: "IX_Empleado_IdPersona",
                table: "Empleado",
                column: "IdPersona",
                unique: true,
                filter: "[IdPersona] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Copia_IdLibro",
                table: "Copia",
                column: "IdLibro");

            migrationBuilder.CreateIndex(
                name: "IX_Cliente_IdPersona",
                table: "Cliente",
                column: "IdPersona",
                unique: true,
                filter: "[IdPersona] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Autor_IdPersona",
                table: "Autor",
                column: "IdPersona",
                unique: true,
                filter: "[IdPersona] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Autor_Persona_IdPersona",
                table: "Autor",
                column: "IdPersona",
                principalTable: "Persona",
                principalColumn: "IdPersona");

            migrationBuilder.AddForeignKey(
                name: "FK_AutorLibro_Autor_IdAutor",
                table: "AutorLibro",
                column: "IdAutor",
                principalTable: "Autor",
                principalColumn: "IdAutor",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AutorLibro_Libro_IdLibro",
                table: "AutorLibro",
                column: "IdLibro",
                principalTable: "Libro",
                principalColumn: "IdLibro",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cliente_Persona_IdPersona",
                table: "Cliente",
                column: "IdPersona",
                principalTable: "Persona",
                principalColumn: "IdPersona");

            migrationBuilder.AddForeignKey(
                name: "FK_Copia_Libro_IdLibro",
                table: "Copia",
                column: "IdLibro",
                principalTable: "Libro",
                principalColumn: "IdLibro",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Empleado_Persona_IdPersona",
                table: "Empleado",
                column: "IdPersona",
                principalTable: "Persona",
                principalColumn: "IdPersona");

            migrationBuilder.AddForeignKey(
                name: "FK_GeneroLibro_Genero_IdGenero",
                table: "GeneroLibro",
                column: "IdGenero",
                principalTable: "Genero",
                principalColumn: "IdGenero",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GeneroLibro_Libro_IdLibro",
                table: "GeneroLibro",
                column: "IdLibro",
                principalTable: "Libro",
                principalColumn: "IdLibro",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Libro_Editorial_IdEditorial",
                table: "Libro",
                column: "IdEditorial",
                principalTable: "Editorial",
                principalColumn: "IdEditorial",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Prestamo_Cliente_IdCliente",
                table: "Prestamo",
                column: "IdCliente",
                principalTable: "Cliente",
                principalColumn: "IdCliente",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Prestamo_Copia_IdCopia",
                table: "Prestamo",
                column: "IdCopia",
                principalTable: "Copia",
                principalColumn: "IdCopia",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Prestamo_FormaPago_IdFormaPago",
                table: "Prestamo",
                column: "IdFormaPago",
                principalTable: "FormaPago",
                principalColumn: "IdFormaPago",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Venta_Cliente_IdCliente",
                table: "Venta",
                column: "IdCliente",
                principalTable: "Cliente",
                principalColumn: "IdCliente",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Venta_FormaPago_IdFormaPago",
                table: "Venta",
                column: "IdFormaPago",
                principalTable: "FormaPago",
                principalColumn: "IdFormaPago",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Autor_Persona_IdPersona",
                table: "Autor");

            migrationBuilder.DropForeignKey(
                name: "FK_AutorLibro_Autor_IdAutor",
                table: "AutorLibro");

            migrationBuilder.DropForeignKey(
                name: "FK_AutorLibro_Libro_IdLibro",
                table: "AutorLibro");

            migrationBuilder.DropForeignKey(
                name: "FK_Cliente_Persona_IdPersona",
                table: "Cliente");

            migrationBuilder.DropForeignKey(
                name: "FK_Copia_Libro_IdLibro",
                table: "Copia");

            migrationBuilder.DropForeignKey(
                name: "FK_Empleado_Persona_IdPersona",
                table: "Empleado");

            migrationBuilder.DropForeignKey(
                name: "FK_GeneroLibro_Genero_IdGenero",
                table: "GeneroLibro");

            migrationBuilder.DropForeignKey(
                name: "FK_GeneroLibro_Libro_IdLibro",
                table: "GeneroLibro");

            migrationBuilder.DropForeignKey(
                name: "FK_Libro_Editorial_IdEditorial",
                table: "Libro");

            migrationBuilder.DropForeignKey(
                name: "FK_Prestamo_Cliente_IdCliente",
                table: "Prestamo");

            migrationBuilder.DropForeignKey(
                name: "FK_Prestamo_Copia_IdCopia",
                table: "Prestamo");

            migrationBuilder.DropForeignKey(
                name: "FK_Prestamo_FormaPago_IdFormaPago",
                table: "Prestamo");

            migrationBuilder.DropForeignKey(
                name: "FK_Venta_Cliente_IdCliente",
                table: "Venta");

            migrationBuilder.DropForeignKey(
                name: "FK_Venta_FormaPago_IdFormaPago",
                table: "Venta");

            migrationBuilder.DropIndex(
                name: "IX_Venta_IdCliente",
                table: "Venta");

            migrationBuilder.DropIndex(
                name: "IX_Venta_IdFormaPago",
                table: "Venta");

            migrationBuilder.DropIndex(
                name: "IX_Prestamo_IdCliente",
                table: "Prestamo");

            migrationBuilder.DropIndex(
                name: "IX_Prestamo_IdCopia",
                table: "Prestamo");

            migrationBuilder.DropIndex(
                name: "IX_Prestamo_IdFormaPago",
                table: "Prestamo");

            migrationBuilder.DropIndex(
                name: "IX_Empleado_IdPersona",
                table: "Empleado");

            migrationBuilder.DropIndex(
                name: "IX_Copia_IdLibro",
                table: "Copia");

            migrationBuilder.DropIndex(
                name: "IX_Cliente_IdPersona",
                table: "Cliente");

            migrationBuilder.DropIndex(
                name: "IX_Autor_IdPersona",
                table: "Autor");

            migrationBuilder.DropColumn(
                name: "IdCliente",
                table: "Venta");

            migrationBuilder.DropColumn(
                name: "IdFormaPago",
                table: "Venta");

            migrationBuilder.DropColumn(
                name: "IdCliente",
                table: "Prestamo");

            migrationBuilder.DropColumn(
                name: "IdCopia",
                table: "Prestamo");

            migrationBuilder.DropColumn(
                name: "IdFormaPago",
                table: "Prestamo");

            migrationBuilder.DropColumn(
                name: "IdPersona",
                table: "Empleado");

            migrationBuilder.DropColumn(
                name: "IdLibro",
                table: "Copia");

            migrationBuilder.DropColumn(
                name: "IdPersona",
                table: "Cliente");

            migrationBuilder.DropColumn(
                name: "IdPersona",
                table: "Autor");

            migrationBuilder.RenameColumn(
                name: "IdEditorial",
                table: "Libro",
                newName: "IdEditorial1");

            migrationBuilder.RenameIndex(
                name: "IX_Libro_IdEditorial",
                table: "Libro",
                newName: "IX_Libro_IdEditorial1");

            migrationBuilder.RenameColumn(
                name: "IdLibro",
                table: "GeneroLibro",
                newName: "IdLibro1");

            migrationBuilder.RenameColumn(
                name: "IdGenero",
                table: "GeneroLibro",
                newName: "IdGenero1");

            migrationBuilder.RenameIndex(
                name: "IX_GeneroLibro_IdLibro",
                table: "GeneroLibro",
                newName: "IX_GeneroLibro_IdLibro1");

            migrationBuilder.RenameIndex(
                name: "IX_GeneroLibro_IdGenero",
                table: "GeneroLibro",
                newName: "IX_GeneroLibro_IdGenero1");

            migrationBuilder.RenameColumn(
                name: "IdLibro",
                table: "AutorLibro",
                newName: "LibroAutorLibroIdLibro");

            migrationBuilder.RenameColumn(
                name: "IdAutor",
                table: "AutorLibro",
                newName: "AutorAutorLibroIdAutor");

            migrationBuilder.RenameIndex(
                name: "IX_AutorLibro_IdLibro",
                table: "AutorLibro",
                newName: "IX_AutorLibro_LibroAutorLibroIdLibro");

            migrationBuilder.RenameIndex(
                name: "IX_AutorLibro_IdAutor",
                table: "AutorLibro",
                newName: "IX_AutorLibro_AutorAutorLibroIdAutor");

            migrationBuilder.RenameColumn(
                name: "CantidadLibrosEscritos",
                table: "Autor",
                newName: "PersonaClienteIdPersona");

            migrationBuilder.AddColumn<int>(
                name: "PersonaEmpleadoIdPersona",
                table: "Empleado",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PersonaClienteIdPersona",
                table: "Cliente",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Empleado_PersonaEmpleadoIdPersona",
                table: "Empleado",
                column: "PersonaEmpleadoIdPersona");

            migrationBuilder.CreateIndex(
                name: "IX_Cliente_PersonaClienteIdPersona",
                table: "Cliente",
                column: "PersonaClienteIdPersona");

            migrationBuilder.CreateIndex(
                name: "IX_Autor_PersonaClienteIdPersona",
                table: "Autor",
                column: "PersonaClienteIdPersona");

            migrationBuilder.AddForeignKey(
                name: "FK_Autor_Persona_PersonaClienteIdPersona",
                table: "Autor",
                column: "PersonaClienteIdPersona",
                principalTable: "Persona",
                principalColumn: "IdPersona",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AutorLibro_Autor_AutorAutorLibroIdAutor",
                table: "AutorLibro",
                column: "AutorAutorLibroIdAutor",
                principalTable: "Autor",
                principalColumn: "IdAutor",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AutorLibro_Libro_LibroAutorLibroIdLibro",
                table: "AutorLibro",
                column: "LibroAutorLibroIdLibro",
                principalTable: "Libro",
                principalColumn: "IdLibro",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cliente_Persona_PersonaClienteIdPersona",
                table: "Cliente",
                column: "PersonaClienteIdPersona",
                principalTable: "Persona",
                principalColumn: "IdPersona",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Empleado_Persona_PersonaEmpleadoIdPersona",
                table: "Empleado",
                column: "PersonaEmpleadoIdPersona",
                principalTable: "Persona",
                principalColumn: "IdPersona",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GeneroLibro_Genero_IdGenero1",
                table: "GeneroLibro",
                column: "IdGenero1",
                principalTable: "Genero",
                principalColumn: "IdGenero",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GeneroLibro_Libro_IdLibro1",
                table: "GeneroLibro",
                column: "IdLibro1",
                principalTable: "Libro",
                principalColumn: "IdLibro",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Libro_Editorial_IdEditorial1",
                table: "Libro",
                column: "IdEditorial1",
                principalTable: "Editorial",
                principalColumn: "IdEditorial",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
