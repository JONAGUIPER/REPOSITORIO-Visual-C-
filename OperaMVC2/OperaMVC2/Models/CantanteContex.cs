using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OperaMVC2.Models
{
    public class CantanteContex
    {
        static public List<Cantante> Cantantes;
        static CantanteContex()
        {
            if (Cantantes == null)
            {
                Cantantes = new List<Cantante>();
                Cantantes.Add(
                    new Cantante()
                    {
                        Id = 1,
                        Nombre = "Luciano Pavarotti",
                        Voz = "Tenor"
                    });
                Cantantes.Add(
                    new Cantante()
                    {
                        Id = 2,
                        Nombre = "Placido Domingo",
                        Voz = "Tenor"
                    });
                Cantantes.Add(
                    new Cantante()
                    {
                        Id = 3,
                        Nombre = "Placido",
                        Voz = "Soprano"
                    });
                Cantantes.Add(
                    new Cantante()
                    {
                        Id = 2,
                        Nombre = "Domingo",
                        Voz = "Altos"
                    });
            }

        }
    }
}