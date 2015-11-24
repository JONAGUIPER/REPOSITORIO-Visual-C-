using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ManejoVistas.Models
{
    public class Fruta
    {
        public int IdFruta { get; set; }
        [Required(ErrorMessage ="Debe colocar un nombre de fruta")]
        public string NombreFruta { get; set; }
        [Range(0.5,10,ErrorMessage ="valores entre 0.5 y 10")]
        [DataType(DataType.Currency,ErrorMessage ="El formato no es valido, pruebe cambiar el . por ,")]
        public float PrecioKiloFruta { get; set; }
        public string FrutaFile { get; set; }

    }

    public class FrutasContext
    {
        public static List<Fruta> Frutas = new List<Fruta>();
        static FrutasContext()
        {
            //hacemos moking para simular una tabla de datos
            Frutas.Add(new Fruta()
            {
                IdFruta = 1,
                NombreFruta = "Manzana",
                PrecioKiloFruta = 1.24F,
                FrutaFile = @"\Imagenes\Manzana.jpg"
            });
            Frutas.Add(new Fruta()
            {
                IdFruta = 2,
                NombreFruta = "Naranja",
                PrecioKiloFruta = 1.0F,
                FrutaFile = @"\Imagenes\Naranja.jpg"
            });
            Frutas.Add(new Fruta()
            {
                IdFruta = 3,
                NombreFruta = "Mandarina",
                PrecioKiloFruta = 1.2F,
                FrutaFile = @"\Imagenes\Mandarina.jpg"
            });
            Frutas.Add(new Fruta()
            {
                IdFruta = 4,
                NombreFruta = "Platano",
                PrecioKiloFruta = 1.2F,
                FrutaFile = @"\Imagenes\platano.jpg"
            });
            Frutas.Add(new Fruta()
            {
                IdFruta = 5,
                NombreFruta = "Mango",
                PrecioKiloFruta = 1.2F,
                FrutaFile = @"\Imagenes\mango.jpg"
            });
            Frutas.Add(new Fruta()
            {
                IdFruta = 6,
                NombreFruta = "Melocoton",
                PrecioKiloFruta = 1.2F,
                FrutaFile = @"\Imagenes\melocoton.jpg"
            });
            Frutas.Add(new Fruta()
            {
                IdFruta = 7,
                NombreFruta = "Ciruela",
                PrecioKiloFruta = 1.2F,
                FrutaFile = @"\Imagenes\ciruela.jpg"
            });
            Frutas.Add(new Fruta()
            {
                IdFruta = 8,
                NombreFruta = "Uva",
                PrecioKiloFruta = 1.2F,
                FrutaFile = @"\Imagenes\uva.jpg"
            });
        }
    }
}