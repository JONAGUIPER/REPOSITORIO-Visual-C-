using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCFotos.Models
{
    public class DbContext
    {
        public static List<Foto> Fotos = new List<Foto>();
        public static List<Comentario> Comentarios = new List<Comentario>();

        static DbContext()
        {
            ///////////////LLENO LOS COMENTARIOS
            Comentarios.Add(new Comentario
            {
                IdComentario = 1,
                Autor = "Desconocido 1",
                FechaCreacion = DateTime.Now,
                Texto = "Comentario1 para la ciruela",
                FotoId = 1
            });
            Comentarios.Add(new Comentario
            {
                IdComentario = 2,
                Autor = "Desconocido 2",
                FechaCreacion = DateTime.Now,
                Texto = "Comentario2 para la ciruela",
                FotoId = 1
            });
            Comentarios.Add(new Comentario
            {
                IdComentario = 3,
                Autor = "Desconocido 3",
                FechaCreacion = DateTime.Now,
                Texto = "Comentario1 para la Mandarina",
                FotoId = 2
            });
            Comentarios.Add(new Comentario
            {
                IdComentario = 4,
                Autor = "Desconocido 4",
                FechaCreacion = DateTime.Now,
                Texto = "Comentario2 para la Mandarina",
                FotoId = 2
            });
            Comentarios.Add(new Comentario
            {
                IdComentario = 5,
                Autor = "Desconocido 5",
                FechaCreacion = DateTime.Now,
                Texto = "Comentario1 para el Mango",
                FotoId = 3
            });
            Comentarios.Add(new Comentario
            {
                IdComentario = 6,
                Autor = "Desconocido 6",
                FechaCreacion = DateTime.Now,
                Texto = "Comentario1 para la Manzana",
                FotoId = 4
            });

            ////////////LLENO LAS FOTOS
            Fotos.Add(new Foto
            {
                IDFoto = 1,
                Titulo = "CIRUELA",
                FechaCreacion=DateTime.Now,
                FotoURL=@"/imagenes/Ciruela.jpg",
                Comentarios=(from c in Comentarios where c.FotoId==1 select c).ToList()
            });
            Fotos.Add(new Foto
            {
                IDFoto = 2,
                Titulo = "Mandarina",
                FechaCreacion = DateTime.Now,
                FotoURL = @"/imagenes/Mandarina.jpg",
                Comentarios = (from c in Comentarios where c.FotoId == 2 select c).ToList()
            });
            Fotos.Add(new Foto
            {
                IDFoto = 3,
                Titulo = "Mango",
                FechaCreacion = DateTime.Now,
                FotoURL = @"/imagenes/Mango.jpg",
                Comentarios = (from c in Comentarios where c.FotoId == 3 select c).ToList()
            });
            Fotos.Add(new Foto
            {
                IDFoto = 4,
                Titulo = "Manzana",
                FechaCreacion = DateTime.Now,
                FotoURL = @"/imagenes/Manzana.jpg",
                Comentarios = (from c in Comentarios where c.FotoId == 5 select c).ToList()
            });
            Fotos.Add(new Foto
            {
                IDFoto = 5,
                Titulo = "Melocoton",
                FechaCreacion = DateTime.Now,
                FotoURL = @"/imagenes/Melocoton.jpg",
                Comentarios = (from c in Comentarios where c.FotoId == 5 select c).ToList()
            });
            

        }
    }
}