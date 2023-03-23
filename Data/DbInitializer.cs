using Asp___Angular_2.Model;

namespace Asp___Angular_2.Data
{
    public static class DbInitializer
    {
        public static void Initialize(EmpleadoContext context)
        {

            if (context.Empleados.Any()
                && context.Num_telefonos.Any())
            {
                return;   // DB has been seeded
            }

            var empleados = new Empleado[]
            {
                new Empleado
                    { 
                       Nombre = "Diego",
                       Apellido = "Garcia",
                       Edad = 23,
                       Telefono = "8498064050",
                       Ruta = "Samaná",
                       Camion = "F-47",
                       Direccion ="John F. Kennedy"
                    },

                new Empleado
                    { 
                       Nombre = "Mariela",
                       Apellido = "Garcia",
                       Edad = 25,
                       Telefono = "8099052050",
                       Ruta = "La Romana",
                       Camion = "F-15",
                       Direccion ="27 de Febrero"
                    },

                    new Empleado
                    { 
                       Nombre = "John",
                       Apellido = "Doe",
                       Edad = 30,
                       Telefono = "0123465798",
                       Ruta = "Ruta 66",
                       Camion = "F-22",
                       Direccion ="15 de Febrero"
                    },

                    new Empleado
                    { 
                       Nombre = "Jannette",
                       Apellido = "Poe",
                       Edad = 35,
                       Telefono = "9876543210",
                       Ruta = "La Espirilla",
                       Camion = "F-4",
                       Direccion ="Gustavo Mejia Ricart"
                    },
            };

            var telefonos = new Num_telefono[]{
                new Num_telefono{
                    TelefonoId = 1,
                    Telefono_celular = "8498064050",
                    Descripcion = "Flota 1",
                    Activo = true
                },

                new Num_telefono{
                    TelefonoId = 2,
                    Telefono_celular = "1234567890",
                    Descripcion = "Flota 2",
                    Activo = true
                },
                                new Num_telefono{
                    TelefonoId = 3,
                    Telefono_celular = "0123456789",
                    Descripcion = "Flota 3",
                    Activo = true
                },

                new Num_telefono{
                    TelefonoId = 4,
                    Telefono_celular = "9876543210",
                    Descripcion = "Flota 4",
                    Activo = true
                },
            };

            context.Num_telefonos.AddRange(telefonos);
            context.Empleados.AddRange(empleados);
            context.SaveChanges();
        }
    }
}