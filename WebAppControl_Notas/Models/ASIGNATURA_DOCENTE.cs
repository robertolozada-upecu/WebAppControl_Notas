//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebAppControl_Notas.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ASIGNATURA_DOCENTE
    {
        public int ID_ASIGNATURA_DOCENTE { get; set; }
        public int ID_ASIGNATURA { get; set; }
        public int ID_DOCENTE { get; set; }
        public string ASIG_DOC_MODALIDAD { get; set; }
    
        public virtual ASIGNATURA ASIGNATURA { get; set; }
        public virtual DOCENTE DOCENTE { get; set; }
    }
}
