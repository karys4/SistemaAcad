using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SistemaAcad.Models;
using SistemaAcad.Data;

namespace SistemaAcad.Data
{

    //Clase agregada DbInitilizer
    public class DbInitializer
    {
        public static void Initialize (SistemaAcadContext context)
        {
            context.Database.EnsureCreated();

            if (context.Categoria.Any())
            {
                return;
            }
            var categorias = new Categoria[]
            {
                new Categoria{Nombre="Programación",Descripcion="Curso de Programación ASP", Carrera="TI",Estado=true},
                new Categoria{Nombre="Diseño Gráfico",Descripcion="Curso de diseño gráfico", Carrera="Diseño",Estado=true},
                new Categoria{Nombre="Matemáticas",Descripcion="Introducción a Algebra Lineal", Carrera="Matemáticas",Estado=true},
            };
            foreach (Categoria c in categorias)
            {
                context.Categoria.Add(c);

            }
            context.SaveChanges();
        }
        
    }
}
