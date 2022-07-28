using System;
using System.Collections.Generic;
using System.Linq;
using WebAppControl_Notas.Models;

namespace WebAppControl_Notas.Repositorios
{
    public class EstudianteRepositorio
    {
        private readonly CONTROL_NOTASEntities dbControl_Notas = new CONTROL_NOTASEntities();

        public ESTUDIANTE ObtenerEstudiante(int id)
        {
            return dbControl_Notas.ESTUDIANTE.FirstOrDefault(estudiante => estudiante.ID_ESTUDIANTE == id);
        }

        public IEnumerable<ESTUDIANTE> ObtenerEstudiantes()
        {
            return dbControl_Notas.ESTUDIANTE.ToList();
        }

        public void CrearEstudiante(ESTUDIANTE estudiante)
        {
            dbControl_Notas.ESTUDIANTE.Add(estudiante);
            dbControl_Notas.SaveChanges();
        }

        public void ActualizarCorreoPersonalEstudiante(int id, string nuevoCorreoPersonal)
        {
            var estudianteActual = ObtenerEstudiante(id);
            estudianteActual.EST_CORREO_PERSONAL = nuevoCorreoPersonal;
            dbControl_Notas.SaveChanges();
        }
    }
}