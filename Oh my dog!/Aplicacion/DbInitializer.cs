using Aplicacion.Models;
using Microsoft.EntityFrameworkCore;

public static class DbInitializer
{
    public static void Seed(OhmydogdbContext context)
    {
        CreateRol(context);
        CreateUser(context);
    }

    public static void CreateRol(OhmydogdbContext context)
    {
        if (!context.Rols.Any())
        {
            context.Rols.Add(new Rol { IdRol = 1, Descripcion = "Administrador" });
            context.SaveChanges();
        }
    }

    public static void CreateUser(OhmydogdbContext context)
    {
        if (!context.Usuarios.Any())
        {
            context.Usuarios.Add(new Usuarios { 
                Email = "juanperez@gmail.com", 
                Pass = "123456", 
                Nombre = "Juan", 
                Apellido = "Perez", 
                Telefono = "123456789",
                Direccion = "Calle Falsa 123",
                Estado = 1,
                EsNuevo = 0,
                IdRol = 1,
            });
            context.SaveChanges();
        }
    }
}
