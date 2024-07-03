using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CDatos.Migrations
{
    /// <inheritdoc />
    public partial class nombrescorregidos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CantidadCopia",
                table: "Copia");

            migrationBuilder.DropColumn(
                name: "BiografiaAutor",
                table: "Autor");

            migrationBuilder.RenameColumn(
                name: "FechaVenta",
                table: "Venta",
                newName: "Fecha");

            migrationBuilder.RenameColumn(
                name: "TelefonoPersona",
                table: "Persona",
                newName: "Telefono");

            migrationBuilder.RenameColumn(
                name: "NombrePersona",
                table: "Persona",
                newName: "Nombre");

            migrationBuilder.RenameColumn(
                name: "NacionalidadPersona",
                table: "Persona",
                newName: "Nacionalidad");

            migrationBuilder.RenameColumn(
                name: "DNIPersona",
                table: "Persona",
                newName: "DNI");

            migrationBuilder.RenameColumn(
                name: "ApellidoPersona",
                table: "Persona",
                newName: "Apellido");

            migrationBuilder.RenameColumn(
                name: "TituloLibro",
                table: "Libro",
                newName: "Titulo");

            migrationBuilder.RenameColumn(
                name: "PrecioVentaLibro",
                table: "Libro",
                newName: "PrecioVenta");

            migrationBuilder.RenameColumn(
                name: "DescripcionLibro",
                table: "Libro",
                newName: "Descripcion");

            migrationBuilder.RenameColumn(
                name: "AnioPublicacionLibro",
                table: "Libro",
                newName: "AnioPublicacion");

            migrationBuilder.RenameColumn(
                name: "DescripcionGenero",
                table: "Genero",
                newName: "Descripcion");

            migrationBuilder.RenameColumn(
                name: "DescripcionFormaPago",
                table: "FormaPago",
                newName: "Descripcion");

            migrationBuilder.RenameColumn(
                name: "DireccionEditorial",
                table: "Editorial",
                newName: "Direccion");

            migrationBuilder.RenameColumn(
                name: "ContactoEditorial",
                table: "Editorial",
                newName: "Contacto");

            migrationBuilder.RenameColumn(
                name: "PrecioCopia",
                table: "Copia",
                newName: "PrecioPrestamo");

            migrationBuilder.RenameColumn(
                name: "NacionalidadAutor",
                table: "Autor",
                newName: "Biografia");

            migrationBuilder.RenameColumn(
                name: "FechaNacimientoAutor",
                table: "Autor",
                newName: "FechaNacimiento");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Fecha",
                table: "Venta",
                newName: "FechaVenta");

            migrationBuilder.RenameColumn(
                name: "Telefono",
                table: "Persona",
                newName: "TelefonoPersona");

            migrationBuilder.RenameColumn(
                name: "Nombre",
                table: "Persona",
                newName: "NombrePersona");

            migrationBuilder.RenameColumn(
                name: "Nacionalidad",
                table: "Persona",
                newName: "NacionalidadPersona");

            migrationBuilder.RenameColumn(
                name: "DNI",
                table: "Persona",
                newName: "DNIPersona");

            migrationBuilder.RenameColumn(
                name: "Apellido",
                table: "Persona",
                newName: "ApellidoPersona");

            migrationBuilder.RenameColumn(
                name: "Titulo",
                table: "Libro",
                newName: "TituloLibro");

            migrationBuilder.RenameColumn(
                name: "PrecioVenta",
                table: "Libro",
                newName: "PrecioVentaLibro");

            migrationBuilder.RenameColumn(
                name: "Descripcion",
                table: "Libro",
                newName: "DescripcionLibro");

            migrationBuilder.RenameColumn(
                name: "AnioPublicacion",
                table: "Libro",
                newName: "AnioPublicacionLibro");

            migrationBuilder.RenameColumn(
                name: "Descripcion",
                table: "Genero",
                newName: "DescripcionGenero");

            migrationBuilder.RenameColumn(
                name: "Descripcion",
                table: "FormaPago",
                newName: "DescripcionFormaPago");

            migrationBuilder.RenameColumn(
                name: "Direccion",
                table: "Editorial",
                newName: "DireccionEditorial");

            migrationBuilder.RenameColumn(
                name: "Contacto",
                table: "Editorial",
                newName: "ContactoEditorial");

            migrationBuilder.RenameColumn(
                name: "PrecioPrestamo",
                table: "Copia",
                newName: "PrecioCopia");

            migrationBuilder.RenameColumn(
                name: "FechaNacimiento",
                table: "Autor",
                newName: "FechaNacimientoAutor");

            migrationBuilder.RenameColumn(
                name: "Biografia",
                table: "Autor",
                newName: "NacionalidadAutor");

            migrationBuilder.AddColumn<int>(
                name: "CantidadCopia",
                table: "Copia",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "BiografiaAutor",
                table: "Autor",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
