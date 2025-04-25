using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Aplicacion.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Adopciones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "varchar(300)", unicode: false, maxLength: 300, nullable: false),
                    Nombre = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Tamano = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    Sexo = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    Raza = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Color = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Descripcion = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    Baja = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Adopcion__3214EC073618B9E0", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ContactoAdopciones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdAdopcion = table.Column<int>(type: "int", nullable: false),
                    EmailRemitente = table.Column<string>(type: "varchar(300)", unicode: false, maxLength: 300, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactoAdopciones", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ContactoPerdidas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdPerdida = table.Column<int>(type: "int", nullable: false),
                    EmailRemitente = table.Column<string>(type: "varchar(300)", unicode: false, maxLength: 300, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactoPerdidas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cuidadores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Apellido = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HorarioIn = table.Column<TimeSpan>(type: "time", nullable: false),
                    HorarioOut = table.Column<TimeSpan>(type: "time", nullable: false),
                    Foto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Latitud = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Longitud = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ubicacion = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cuidadores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Descuentos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Descuentos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EstadoTurno",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Estado = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstadoTurno", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HorarioTurno",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Turno = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HorarioTurno", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Paseadores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    Apellido = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "varchar(300)", unicode: false, maxLength: 300, nullable: false),
                    Foto = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Ubicacion = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false),
                    HorarioIN = table.Column<TimeSpan>(type: "time(0)", precision: 0, nullable: false),
                    HorarioOut = table.Column<TimeSpan>(type: "time(0)", precision: 0, nullable: false),
                    Latitud = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Longitud = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paseadores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Perdidas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "varchar(300)", unicode: false, maxLength: 300, nullable: false),
                    Nombre = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Peso = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    Sexo = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    Raza = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Color = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Descripcion = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    Foto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaPerdida = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    Baja = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Perdidas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rol",
                columns: table => new
                {
                    IdRol = table.Column<int>(type: "int", nullable: false),
                    Descripcion = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Rol__2A49584C2F1A143A", x => x.IdRol);
                });

            migrationBuilder.CreateTable(
                name: "TipoModalidad",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoModalidad", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoPublicacion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoPublicacion", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tratamientos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tratamientos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vacunas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Vacuna = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vacunas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Turnos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Motivo = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    Fecha = table.Column<DateTime>(type: "date", nullable: false),
                    Dueno = table.Column<int>(type: "int", nullable: false),
                    Horario = table.Column<int>(type: "int", nullable: false),
                    HorarioFinal = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Comentario = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Turnos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Turnos_EstadoTurno",
                        column: x => x.Estado,
                        principalTable: "EstadoTurno",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Turnos_HorarioTurno",
                        column: x => x.Horario,
                        principalTable: "HorarioTurno",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Nombre = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    Apellido = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    Telefono = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    Direccion = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    IdRol = table.Column<int>(type: "int", nullable: true),
                    Pass = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: false),
                    EsNuevo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Usuarios__3214EC076CD730FD", x => x.Id);
                    table.ForeignKey(
                        name: "FK__Usuarios__IdRol__48CFD27E",
                        column: x => x.IdRol,
                        principalTable: "Rol",
                        principalColumn: "IdRol");
                });

            migrationBuilder.CreateTable(
                name: "ModalidadCuidador",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdCuidador = table.Column<int>(type: "int", nullable: true),
                    IdModalidad = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModalidadCuidador", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ModalidadCuidador_Cuidadores",
                        column: x => x.IdCuidador,
                        principalTable: "Cuidadores",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ModalidadCuidador_TipoModalidad",
                        column: x => x.IdModalidad,
                        principalTable: "TipoModalidad",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Perros",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    Peso = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Celo = table.Column<DateTime>(type: "date", nullable: true),
                    Sexo = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    Foto = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Color = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Estado = table.Column<bool>(type: "bit", nullable: false),
                    Raza = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    Observaciones = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: false),
                    FechaDeNacimiento = table.Column<DateTime>(type: "date", nullable: false),
                    IdDueno = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Perros", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PerrosUsuarios",
                        column: x => x.IdDueno,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PerroTurno",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    IdPerro = table.Column<int>(type: "int", nullable: true),
                    IdTurno = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PerroTurno", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PerroTurno_Perros",
                        column: x => x.IdPerro,
                        principalTable: "Perros",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PerroTurno_Turnos",
                        column: x => x.IdTurno,
                        principalTable: "Turnos",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Publicacion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Estado = table.Column<bool>(type: "bit", nullable: false),
                    Tipo = table.Column<int>(type: "int", nullable: false),
                    IdPerro = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Publicacion", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Publicacion_Perros",
                        column: x => x.IdPerro,
                        principalTable: "Perros",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Publicacion_TipoPublicacion",
                        column: x => x.Tipo,
                        principalTable: "TipoPublicacion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PublicacionTinderdog",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdPerro = table.Column<int>(type: "int", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PublicacionTinderdog", x => x.Id);
                    table.UniqueConstraint("AK_PublicacionTinderdog_IdPerro", x => x.IdPerro);
                    table.ForeignKey(
                        name: "FK_PublicacionTinderdog_Perros_IdPerro",
                        column: x => x.IdPerro,
                        principalTable: "Perros",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TratamientoPerro",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdTratamiento = table.Column<int>(type: "int", nullable: false),
                    IdPerro = table.Column<int>(type: "int", nullable: false),
                    Observaciones = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    Fecha = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TratamientoPerro", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TratamientoPerro_Perros",
                        column: x => x.IdPerro,
                        principalTable: "Perros",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TratamientoPerro_Tratamientos",
                        column: x => x.IdTratamiento,
                        principalTable: "Tratamientos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VacunaPerro",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdVacuna = table.Column<int>(type: "int", nullable: false),
                    IdPerro = table.Column<int>(type: "int", nullable: false),
                    Dosis = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    NroLote = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    FechaAplicacion = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VacunaPerro", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VacunaPerro_Perros",
                        column: x => x.IdPerro,
                        principalTable: "Perros",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VacunaPerro_Vacunas",
                        column: x => x.IdVacuna,
                        principalTable: "Vacunas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UsuarioAdopcionPublicacion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    IdUsuario = table.Column<int>(type: "int", nullable: false),
                    IdPublicacion = table.Column<int>(type: "int", nullable: false),
                    Descripcion = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsuarioAdopcionPublicacion", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UsuarioAdopcionPublicacion_Publicacion",
                        column: x => x.IdPublicacion,
                        principalTable: "Publicacion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UsuarioColectaPublicacion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    IdUsuario = table.Column<int>(type: "int", nullable: false),
                    IdPublicacion = table.Column<int>(type: "int", nullable: false),
                    Titulo = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Motivo = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsuarioColectaPublicacion", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UsuarioColectaPublicacion_Publicacion",
                        column: x => x.IdPublicacion,
                        principalTable: "Publicacion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UsuarioPerdidaPublicacion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    IdUsuario = table.Column<int>(type: "int", nullable: false),
                    IdPublicacion = table.Column<int>(type: "int", nullable: false),
                    Descripcion = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Fecha = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsuarioPerdidaPublicacion", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UsuarioPerdidaPublicacion_Publicacion",
                        column: x => x.IdPublicacion,
                        principalTable: "Publicacion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Fotos_PublicacionTinderdog",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdPublicacion = table.Column<int>(type: "int", nullable: false),
                    Foto = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fotos_PublicacionTinderdog", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Fotos_PublicacionTinderdog_PublicacionTinderdog_IdPublicacion",
                        column: x => x.IdPublicacion,
                        principalTable: "PublicacionTinderdog",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PerrosMeGusta",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idPerroEmisor = table.Column<int>(type: "int", nullable: false),
                    idPerroReceptor = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PerrosMeGusta", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PerrosMeGusta_PublicacionTinderdog_idPerroEmisor",
                        column: x => x.idPerroEmisor,
                        principalTable: "PublicacionTinderdog",
                        principalColumn: "IdPerro",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PerrosMeGusta_PublicacionTinderdog_idPerroReceptor",
                        column: x => x.idPerroReceptor,
                        principalTable: "PublicacionTinderdog",
                        principalColumn: "IdPerro");
                });

            migrationBuilder.CreateTable(
                name: "PerrosNoMeGusta",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idPerroEmisor = table.Column<int>(type: "int", nullable: false),
                    idPerroReceptor = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PerrosNoMeGusta", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PerrosNoMeGusta_PublicacionTinderdog_idPerroEmisor",
                        column: x => x.idPerroEmisor,
                        principalTable: "PublicacionTinderdog",
                        principalColumn: "IdPerro",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PerrosNoMeGusta_PublicacionTinderdog_idPerroReceptor",
                        column: x => x.idPerroReceptor,
                        principalTable: "PublicacionTinderdog",
                        principalColumn: "IdPerro");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Descuento",
                table: "Descuentos",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Fotos_PublicacionTinderdog_IdPublicacion",
                table: "Fotos_PublicacionTinderdog",
                column: "IdPublicacion");

            migrationBuilder.CreateIndex(
                name: "IX_ModalidadCuidador_IdCuidador",
                table: "ModalidadCuidador",
                column: "IdCuidador");

            migrationBuilder.CreateIndex(
                name: "IX_ModalidadCuidador_IdModalidad",
                table: "ModalidadCuidador",
                column: "IdModalidad");

            migrationBuilder.CreateIndex(
                name: "IX_Perros_IdDueno",
                table: "Perros",
                column: "IdDueno");

            migrationBuilder.CreateIndex(
                name: "IX_PerrosMeGusta_idPerroEmisor",
                table: "PerrosMeGusta",
                column: "idPerroEmisor");

            migrationBuilder.CreateIndex(
                name: "IX_PerrosMeGusta_idPerroReceptor",
                table: "PerrosMeGusta",
                column: "idPerroReceptor");

            migrationBuilder.CreateIndex(
                name: "IX_PerrosNoMeGusta_idPerroEmisor",
                table: "PerrosNoMeGusta",
                column: "idPerroEmisor");

            migrationBuilder.CreateIndex(
                name: "IX_PerrosNoMeGusta_idPerroReceptor",
                table: "PerrosNoMeGusta",
                column: "idPerroReceptor");

            migrationBuilder.CreateIndex(
                name: "IX_PerroTurno",
                table: "PerroTurno",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_PerroTurno_IdPerro",
                table: "PerroTurno",
                column: "IdPerro");

            migrationBuilder.CreateIndex(
                name: "IX_PerroTurno_IdTurno",
                table: "PerroTurno",
                column: "IdTurno");

            migrationBuilder.CreateIndex(
                name: "IX_Publicacion_IdPerro",
                table: "Publicacion",
                column: "IdPerro");

            migrationBuilder.CreateIndex(
                name: "IX_Publicacion_Tipo",
                table: "Publicacion",
                column: "Tipo");

            migrationBuilder.CreateIndex(
                name: "IX_IdPerro",
                table: "PublicacionTinderdog",
                column: "IdPerro",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TratamientoPerro_IdPerro",
                table: "TratamientoPerro",
                column: "IdPerro");

            migrationBuilder.CreateIndex(
                name: "IX_TratamientoPerro_IdTratamiento",
                table: "TratamientoPerro",
                column: "IdTratamiento");

            migrationBuilder.CreateIndex(
                name: "IX_Turnos_Estado",
                table: "Turnos",
                column: "Estado");

            migrationBuilder.CreateIndex(
                name: "IX_Turnos_Horario",
                table: "Turnos",
                column: "Horario");

            migrationBuilder.CreateIndex(
                name: "IX_UsuarioAdopcionPublicacion_IdPublicacion",
                table: "UsuarioAdopcionPublicacion",
                column: "IdPublicacion");

            migrationBuilder.CreateIndex(
                name: "IX_UsuarioColectaPublicacion_IdPublicacion",
                table: "UsuarioColectaPublicacion",
                column: "IdPublicacion");

            migrationBuilder.CreateIndex(
                name: "IX_UsuarioPerdidaPublicacion_IdPublicacion",
                table: "UsuarioPerdidaPublicacion",
                column: "IdPublicacion");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_IdRol",
                table: "Usuarios",
                column: "IdRol");

            migrationBuilder.CreateIndex(
                name: "IX_VacunaPerro_IdPerro",
                table: "VacunaPerro",
                column: "IdPerro");

            migrationBuilder.CreateIndex(
                name: "IX_VacunaPerro_IdVacuna",
                table: "VacunaPerro",
                column: "IdVacuna");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Adopciones");

            migrationBuilder.DropTable(
                name: "ContactoAdopciones");

            migrationBuilder.DropTable(
                name: "ContactoPerdidas");

            migrationBuilder.DropTable(
                name: "Descuentos");

            migrationBuilder.DropTable(
                name: "Fotos_PublicacionTinderdog");

            migrationBuilder.DropTable(
                name: "ModalidadCuidador");

            migrationBuilder.DropTable(
                name: "Paseadores");

            migrationBuilder.DropTable(
                name: "Perdidas");

            migrationBuilder.DropTable(
                name: "PerrosMeGusta");

            migrationBuilder.DropTable(
                name: "PerrosNoMeGusta");

            migrationBuilder.DropTable(
                name: "PerroTurno");

            migrationBuilder.DropTable(
                name: "TratamientoPerro");

            migrationBuilder.DropTable(
                name: "UsuarioAdopcionPublicacion");

            migrationBuilder.DropTable(
                name: "UsuarioColectaPublicacion");

            migrationBuilder.DropTable(
                name: "UsuarioPerdidaPublicacion");

            migrationBuilder.DropTable(
                name: "VacunaPerro");

            migrationBuilder.DropTable(
                name: "Cuidadores");

            migrationBuilder.DropTable(
                name: "TipoModalidad");

            migrationBuilder.DropTable(
                name: "PublicacionTinderdog");

            migrationBuilder.DropTable(
                name: "Turnos");

            migrationBuilder.DropTable(
                name: "Tratamientos");

            migrationBuilder.DropTable(
                name: "Publicacion");

            migrationBuilder.DropTable(
                name: "Vacunas");

            migrationBuilder.DropTable(
                name: "EstadoTurno");

            migrationBuilder.DropTable(
                name: "HorarioTurno");

            migrationBuilder.DropTable(
                name: "Perros");

            migrationBuilder.DropTable(
                name: "TipoPublicacion");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Rol");
        }
    }
}
