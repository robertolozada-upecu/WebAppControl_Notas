using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Net;
using System.Web.Http;
using WebAppControl_Notas.Clases.Request;
using WebAppControl_Notas.Models;
using WebAppControl_Notas.Repositorios;

namespace WebAppControl_Notas.Controllers
{
    public class EstudianteController : ApiController
    {
        private readonly EstudianteRepositorio _repositorio = new EstudianteRepositorio();
        
        [System.Web.Http.HttpGet]
        [ProducesResponseType(typeof(List<object>),(int)HttpStatusCode.OK)]
        public IHttpActionResult ObtenerEstudiantes()
        {
            return Ok(_repositorio.ObtenerEstudiantes());
        }

        [System.Web.Http.HttpPost]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public IHttpActionResult CrearEstudiante(NuevoEstudianteRequest request)
        {
            if(request == null)
            {
                return BadRequest("¡No puede haber campos vacios!");
            }
            else if (string.IsNullOrEmpty(request.EST_CEDULA))
            {
                return BadRequest("¡La cédula de identidad es un campo obligatorio, por favor verifique!");
            }
            else if (request.EST_CEDULA.Length != 10)
            {
                return BadRequest("¡La cédula de identidad debe tener 10 dígitos!");
            }  
            else
            {
                var nuevoEstudiante = new ESTUDIANTE
                {
                    EST_CEDULA = request.EST_CEDULA,
                    EST_NOMBRE = request.EST_NOMBRE,
                    EST_APELLIDO_PATERNO = request.EST_APELLIDO_PATERNO,
                    EST_APELLIDO_MATERNO = request.EST_APELLIDO_MATERNO,
                    EST_FECHA_NACIMIENTO = request.EST_FECHA_NACIMIENTO,
                    EST_DIRECCION = request.EST_DIRECCION,
                    EST_TELEFONO_FIJO = request.EST_TELEFONO_FIJO,
                    EST_TELEFONO_CELULAR = request.EST_TELEFONO_CELULAR,
                    EST_CORREO_PERSONAL = request.EST_CORREO_PERSONAL,
                    EST_CORREO_INSTITUCIONAL = request.EST_CORREO_INSTITUCIONAL,
                    EST_USUARIO = request.EST_USUARIO
                };
                _repositorio.CrearEstudiante(nuevoEstudiante);
                return Ok("¡Estudiante Ingresado exitosamente!");
            }
        }

        [System.Web.Http.HttpPut]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public IHttpActionResult ActualizarCorreoPersonalEstudiante(int id, string correoPersonal)
        {
            var estudianteActual = _repositorio.ObtenerEstudiante(id);
            if (estudianteActual == null)
            {
                return BadRequest("¡No existe el estudiante, por favor verifique!");
            }
            else if(estudianteActual.EST_CORREO_PERSONAL == correoPersonal)
            {
                return BadRequest("¡El correo actual es igual al correo a cambiar, por favor verifique!");
            }
            else
            {
                _repositorio.ActualizarCorreoPersonalEstudiante(id, correoPersonal);
                return Ok("¡Estudiante Actualizado!");
            }
        }
    }
}
