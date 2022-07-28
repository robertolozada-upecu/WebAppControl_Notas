using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppControl_Notas.Clases.Request
{
    public class NuevoEstudianteRequest
    {
        public string EST_CEDULA { get; set; }
        public string EST_NOMBRE { get; set; }
        public string EST_APELLIDO_PATERNO { get; set; }
        public string EST_APELLIDO_MATERNO { get; set; }
        public System.DateTime EST_FECHA_NACIMIENTO { get; set; }
        public string EST_DIRECCION { get; set; }
        public string EST_TELEFONO_FIJO { get; set; }
        public string EST_TELEFONO_CELULAR { get; set; }
        public string EST_CORREO_PERSONAL { get; set; }
        public string EST_CORREO_INSTITUCIONAL { get; set; }
        public string EST_USUARIO { get; set; }
    }
}