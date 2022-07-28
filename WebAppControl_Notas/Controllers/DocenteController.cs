using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Net;
using System.Web.Http;
using WebAppControl_Notas.Clases.Request;
using WebAppControl_Notas.Models;
using WebAppControl_Notas.Repositorios;

namespace WebAppControl_Notas.Controllers
{
    public class DocenteController : ApiController
    {
        private readonly DocenteRepositorio _repositorio = new DocenteRepositorio();
        
        [System.Web.Http.HttpGet]
        [ProducesResponseType(typeof(List<object>),(int)HttpStatusCode.OK)]
        public IHttpActionResult ObtenerDocentes()
        {
            return Ok(_repositorio.ObtenerDocentes());
        }

        [System.Web.Http.HttpPost]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public IHttpActionResult CrearDocente(NuevoDocenteRequest request)
        {
            if (request == null)
            {
                return BadRequest("¡No puede haber campos vacios!");
            }
            else if (string.IsNullOrEmpty(request.DOC_CEDULA))
            {
                return BadRequest("¡La cédula de identidad es un campo obligatorio, por favor verifique!");
            }
            else if (request.DOC_CEDULA.Length != 10)
            {
                return BadRequest("¡La cédula de identidad debe tener 10 dígitos!");
            }
            else
            {
                var nuevoDocente = new DOCENTE
                {
                    DOC_CEDULA = request.DOC_CEDULA,
                    DOC_NOMBRES = request.DOC_NOMBRES,
                    DOC_APELLIDO_PATERNO = request.DOC_APELLIDO_PATERNO,
                    DOC_APELLIDO_MATERNO = request.DOC_APELLIDO_MATERNO,
                    DOC_FECHA_NACIMIENTO = request.DOC_FECHA_NACIMIENTO,
                    DOC_DIRECCION = request.DOC_DIRECCION,
                    DOC_TELEFONO_FIJO = request.DOC_TELEFONO_FIJO,
                    DOC_TELEFONO_CELULAR = request.DOC_TELEFONO_CELULAR,
                    DOC_CORREO_PERSONAL = request.DOC_CORREO_PERSONAL,
                    DOC_CORREO_INSTITUCIONAL = request.DOC_CORREO_INSTITUCIONAL,
                    DOC_ESTADO = request.DOC_ESTADO,
                    DOC_FECHA_INGRESO = request.DOC_FECHA_INGRESO,
                    DOC_FECHA_SALIDA = request.DOC_FECHA_SALIDA,
                    DOC_TIPO = request.DOC_TIPO,
                    DOC_USUARIO = request.DOC_USUARIO
                };
                _repositorio.CrearDocente(nuevoDocente);
                return Ok("¡Docente Ingresado exitosamente!");
            }
        }

        [System.Web.Http.HttpPut]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public IHttpActionResult ActualizarDireccionDocente(int id, string direccion)
        {
            var docenteActual = _repositorio.ObtenerDocente(id);
            if (docenteActual == null)
            {
                return BadRequest("!No existe el docente, por favor verifique!");
            }
            else if (docenteActual.DOC_DIRECCION == direccion)
            {
                return BadRequest("¡La dirección actual es igual a la dirección a cambiar, por favor verifique!");
            }
            else
            {
                _repositorio.ActualizarDireccionDocente(id, direccion);
                return Ok("¡Docente Actualizado!");
            }
        }
    }
}
