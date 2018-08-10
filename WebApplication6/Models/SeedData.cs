using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication6.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new WebApplication6Context(
                serviceProvider.GetRequiredService<DbContextOptions<WebApplication6Context>>()))
            {
                if (context.Curso.Any())
                {
                    return;
                }

                context.Curso.AddRange(
                    new Curso
                    {
                        Capacidad = 25,
                        Descripcion = "test",
                        Nombre = "test",
                        Responsable = "test",
                        FinDeCurso = DateTime.Now,
                        InicioDeCurso = DateTime.Parse("05/05/2018")
                    },
                    new Curso
                    {
                        Capacidad = 25,
                        Descripcion = "test",
                        Nombre = "test",
                        Responsable = "test",
                        FinDeCurso = DateTime.Now,
                        InicioDeCurso = DateTime.Parse("05/05/2018")
                    },
                    new Curso
                    {
                        Capacidad = 25,
                        Descripcion = "test",
                        Nombre = "test",
                        Responsable = "test",
                        FinDeCurso = DateTime.Now,
                        InicioDeCurso = DateTime.Parse("05/05/2018")
                    }
                    );
            }
        }
    }
}
