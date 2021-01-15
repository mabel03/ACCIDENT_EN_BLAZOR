using System;
using System.Collections.Generic;
using System.Text;

namespace AccidenteTransito.Model
{
     public class Accidente
     {
         public int CodigoAccidentes { get; set; }
         public DateTime Fecha_Hora { get; set; }
         public string Lugar { get; set; }

         public double Latitud { get; set; }
         public double Longitud { get; set; }

     }
}
