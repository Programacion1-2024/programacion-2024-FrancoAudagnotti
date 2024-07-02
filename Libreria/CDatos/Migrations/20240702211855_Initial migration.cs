using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CDatos.Migrations
{
    /// <inheritdoc />
    public partial class Initialmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Copia",
                columns: table => new
                {
                    IdCopia = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CantidadCopia = table.Column<int>(type: "int", nullable: false),
                    PrecioCopia = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ID_COPIA", x => x.IdCopia);
                });

            migrationBuilder.CreateTable(
                name: "Editorial",
                columns: table => new
                {
                    IdEditorial = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DireccionEditorial = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactoEditorial = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ID_EDITORIAL", x => x.IdEditorial);
                });

            migrationBuilder.CreateTable(
                name: "FormaPago",
                columns: table => new
                {
                    IdFormaPago = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DescripcionFormaPago = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ID_FORMAPAGO", x => x.IdFormaPago);
                });

            migrationBuilder.CreateTable(
                name: "Genero",
                columns: table => new
                {
                    IdGenero = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DescripcionGenero = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ID_GENERO", x => x.IdGenero);
                });

            migrationBuilder.CreateTable(
                name: "Persona",
                columns: table => new
                {
                    IdPersona = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DNIPersona = table.Column<long>(type: "bigint", nullable: false),
                    NombrePersona = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ApellidoPersona = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NacionalidadPersona = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TelefonoPersona = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ID_PERSONA", x => x.IdPersona);
                });

            migrationBuilder.CreateTable(
                name: "Prestamo",
                columns: table => new
                {
                    IdPrestamo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaInicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaFin = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FechaDevolucion = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ID_PRESTAMO", x => x.IdPrestamo);
                });

            migrationBuilder.CreateTable(
                name: "Venta",
                columns: table => new
                {
                    IdVenta = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaVenta = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ID_VENTA", x => x.IdVenta);
                });

            migrationBuilder.CreateTable(
                name: "Libro",
                columns: table => new
                {
                    IdLibro = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ISBN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TituloLibro = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DescripcionLibro = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AnioPublicacionLibro = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PrecioVentaLibro = table.Column<float>(type: "real", nullable: false),
                    IdEditorial1 = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ID_LIBRO", x => x.IdLibro);
                    table.ForeignKey(
                        name: "FK_Libro_Editorial_IdEditorial1",
                        column: x => x.IdEditorial1,
                        principalTable: "Editorial",
                        principalColumn: "IdEditorial",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Autor",
                columns: table => new
                {
                    IdAutor = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaNacimientoAutor = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BiografiaAutor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NacionalidadAutor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PersonaClienteIdPersona = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ID_AUTOR", x => x.IdAutor);
                    table.ForeignKey(
                        name: "FK_Autor_Persona_PersonaClienteIdPersona",
                        column: x => x.PersonaClienteIdPersona,
                        principalTable: "Persona",
                        principalColumn: "IdPersona",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    IdCliente = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EsSocio = table.Column<bool>(type: "bit", nullable: false),
                    PagaIVA = table.Column<bool>(type: "bit", nullable: false),
                    PersonaClienteIdPersona = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ID_CLIENTE", x => x.IdCliente);
                    table.ForeignKey(
                        name: "FK_Cliente_Persona_PersonaClienteIdPersona",
                        column: x => x.PersonaClienteIdPersona,
                        principalTable: "Persona",
                        principalColumn: "IdPersona",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Empleado",
                columns: table => new
                {
                    IdEmpleado = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Antiguedad = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Cargo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sueldo = table.Column<double>(type: "float", nullable: false),
                    PersonaEmpleadoIdPersona = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ID_EMPLEADO", x => x.IdEmpleado);
                    table.ForeignKey(
                        name: "FK_Empleado_Persona_PersonaEmpleadoIdPersona",
                        column: x => x.PersonaEmpleadoIdPersona,
                        principalTable: "Persona",
                        principalColumn: "IdPersona",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GeneroLibro",
                columns: table => new
                {
                    IdGeneroLibro = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdLibro1 = table.Column<int>(type: "int", nullable: false),
                    IdGenero1 = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ID_GENEROLIBRO", x => x.IdGeneroLibro);
                    table.ForeignKey(
                        name: "FK_GeneroLibro_Genero_IdGenero1",
                        column: x => x.IdGenero1,
                        principalTable: "Genero",
                        principalColumn: "IdGenero",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GeneroLibro_Libro_IdLibro1",
                        column: x => x.IdLibro1,
                        principalTable: "Libro",
                        principalColumn: "IdLibro",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AutorLibro",
                columns: table => new
                {
                    IdAutorLibro = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AutorAutorLibroIdAutor = table.Column<int>(type: "int", nullable: false),
                    LibroAutorLibroIdLibro = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ID_AUTORLIBRO", x => x.IdAutorLibro);
                    table.ForeignKey(
                        name: "FK_AutorLibro_Autor_AutorAutorLibroIdAutor",
                        column: x => x.AutorAutorLibroIdAutor,
                        principalTable: "Autor",
                        principalColumn: "IdAutor",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AutorLibro_Libro_LibroAutorLibroIdLibro",
                        column: x => x.LibroAutorLibroIdLibro,
                        principalTable: "Libro",
                        principalColumn: "IdLibro",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Autor_PersonaClienteIdPersona",
                table: "Autor",
                column: "PersonaClienteIdPersona");

            migrationBuilder.CreateIndex(
                name: "IX_AutorLibro_AutorAutorLibroIdAutor",
                table: "AutorLibro",
                column: "AutorAutorLibroIdAutor");

            migrationBuilder.CreateIndex(
                name: "IX_AutorLibro_LibroAutorLibroIdLibro",
                table: "AutorLibro",
                column: "LibroAutorLibroIdLibro");

            migrationBuilder.CreateIndex(
                name: "IX_Cliente_PersonaClienteIdPersona",
                table: "Cliente",
                column: "PersonaClienteIdPersona");

            migrationBuilder.CreateIndex(
                name: "IX_Empleado_PersonaEmpleadoIdPersona",
                table: "Empleado",
                column: "PersonaEmpleadoIdPersona");

            migrationBuilder.CreateIndex(
                name: "IX_GeneroLibro_IdGenero1",
                table: "GeneroLibro",
                column: "IdGenero1");

            migrationBuilder.CreateIndex(
                name: "IX_GeneroLibro_IdLibro1",
                table: "GeneroLibro",
                column: "IdLibro1");

            migrationBuilder.CreateIndex(
                name: "IX_Libro_IdEditorial1",
                table: "Libro",
                column: "IdEditorial1");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AutorLibro");

            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropTable(
                name: "Copia");

            migrationBuilder.DropTable(
                name: "Empleado");

            migrationBuilder.DropTable(
                name: "FormaPago");

            migrationBuilder.DropTable(
                name: "GeneroLibro");

            migrationBuilder.DropTable(
                name: "Prestamo");

            migrationBuilder.DropTable(
                name: "Venta");

            migrationBuilder.DropTable(
                name: "Autor");

            migrationBuilder.DropTable(
                name: "Genero");

            migrationBuilder.DropTable(
                name: "Libro");

            migrationBuilder.DropTable(
                name: "Persona");

            migrationBuilder.DropTable(
                name: "Editorial");
        }
    }
}
