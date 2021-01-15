using System;
using System.Collections.Generic;
using System.Text;

namespace AccidenteTransito.Model
{
    public class Involucrado
    {
        public int IdPersona { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public string Cedula { get; set; }
        public int CasoInvolucrado { get; set; }
    }
}
