using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SegundoExamenParcialOptativoIV.Controllers
{
    public class OperacionesController : Controller
    {
        string cadenaConeion = "";

        public OperacionesController(IConfiguration configuration)
        {
            cadenaConeion = configuration.GetConnectionString("PostgresDB");
        }


        // GET: OperacionesController
        public ActionResult Index()
        {
            return View();
        }

        // GET: OperacionesController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: OperacionesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: OperacionesController/Create
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

        // GET: OperacionesController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: OperacionesController/Edit/5
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

        // GET: OperacionesController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: OperacionesController/Delete/5
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
