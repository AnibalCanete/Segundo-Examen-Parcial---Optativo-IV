using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SegundoExamenParcialOptativoIV.Models;
using System.Net.Mail;

namespace SegundoExamenParcialOptativoIV.Controllers
{
    public class PersonaController : Controller
    {
        [HttpPost("ConsultarPersona/(id)")]

        public ActionResult<PersonaModel> ConsultarPersona(int id)
        {
            var resultado = this.personaservice.consultarpersona(id);
            return Ok(resultado);
        }

        [HttpPost("InsertarPersona")]

        public ActionResult<string>insertarPersona(PersonaModel modelo)
        {
            var resultado = this.Personaservice.insertarPersona(new infraestructure.models.PersonaModel
            {
                Id = modelo.Id,
                Nombre = modelo.Nombre,
                Apellido = modelo.Apellido,
                TipoDocumento = modelo.TipoDocumento,
                Documento = modelo.Documento,
                Direccion = modelo.Direccion,
                Telefono = modelo.Telefono,
                Mail = modelo.Mail,
                Estado = modelo.Estado,
            });
            return Ok(resultado);
        }

        [HttpPost("ModificarPersona/(id)")]

        public ActionResult<string> ModificarPersona(PersonaModel modelo, int id)
        {
            var resultado = this.Personaservice.ModificarPersona(new infraestructura.Models.PersonaModel
            {
                Nombre = modelo.Nombre,
                Apellido = modelo.Apellido,
                TipoDocumento = modelo.TipoDocumento,
                Documento = modelo.Documento,
                Direccion = modelo.Direccion,
                Telefono = modelo.Telefono,
                Mail = modelo.Mail,
                Estado = modelo.Estado,
            }, id);
            return Ok(resultado);
        }

        [HttpPost("EliminarrPersona/{id}")]

        public ActionResult<string> EliminarPersona(int id)
        {
            var resultado = this.Personaservice.EliminarPersona(id);
            return Ok(resultado);
        }
        // GET: PersonaController
        public ActionResult Index()
        {
            return View();
        }

        // GET: PersonaController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PersonaController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PersonaController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PersonaController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PersonaController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PersonaController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PersonaController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
