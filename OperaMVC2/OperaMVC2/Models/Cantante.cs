using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OperaMVC2.Models
{
    public class Cantante
    {
  
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Voz { get; set; }
       
    }
}