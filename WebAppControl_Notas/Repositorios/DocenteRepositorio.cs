using System;
using System.Collections.Generic;
using System.Linq;
using WebAppControl_Notas.Models;

namespace WebAppControl_Notas.Repositorios
{
    public class DocenteRepositorio
    {
        private readonly CONTROL_NOTASEntities dbControl_Notas = new CONTROL_NOTASEntities();

        public IEnumerable<DOCENTE> ObtenerDocentes()
        {
            return dbControl_Notas.DOCENTE.ToList();
        }

        public DOCENTE ObtenerDocente(int id)
        {
            return dbControl_Notas.DOCENTE.FirstOrDefault(docente => docente.ID_DOCENTE == id);
        }

        public void CrearDocente(DOCENTE docente)
        {
            dbControl_Notas.DOCENTE.Add(docente);
            dbControl_Notas.SaveChanges();
        }

        public void ActualizarDireccionDocente(int id, string direccion)
        {
            var docenteActual = ObtenerDocente(id);
            docenteActual.DOC_DIRECCION = direccion;
            dbControl_Notas.SaveChanges();
        }
    }
}