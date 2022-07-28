using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppControl_Notas.Clases.Request
{
    public class NuevoDocenteRequest
    {
        public string DOC_CEDULA { get; set; }
        public string DOC_NOMBRES { get; set; }
        public string DOC_APELLIDO_PATERNO { get; set; }
        public string DOC_APELLIDO_MATERNO { get; set; }
        public System.DateTime DOC_FECHA_NACIMIENTO { get; set; }
        public string DOC_DIRECCION { get; set; }
        public string DOC_TELEFONO_FIJO { get; set; }
        public string DOC_TELEFONO_CELULAR { get; set; }
        public string DOC_CORREO_PERSONAL { get; set; }
        public string DOC_CORREO_INSTITUCIONAL { get; set; }
        public bool DOC_ESTADO { get; set; }
        public System.DateTime DOC_FECHA_INGRESO { get; set; }
        public Nullable<System.DateTime> DOC_FECHA_SALIDA { get; set; }
        public string DOC_TIPO { get; set; }
        public string DOC_USUARIO { get; set; }
    }
}