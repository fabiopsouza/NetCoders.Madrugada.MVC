using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NetCoders.Madrugada.MVC.Services.Interface;
using NetCoders.Madrugada.MVC.UI.WEB.ViewModel;
using FastMapper;
using NetCoders.Madrugada.MVC.Domain.Entities;

namespace NetCoders.Madrugada.MVC.UI.WEB.Controllers
{
    public class FicanteController : Controller
    {
        private readonly IFicanteService _ficanteService;

        private readonly IFicanteService _telefoneService;

        public FicanteController(IFicanteService ficanteService, IFicanteService telefoneService)
        {
            _ficanteService = ficanteService;
            _telefoneService = telefoneService;
        }

        // GET: Ficante
        public ActionResult Index()
        {
            var ficantes = _ficanteService.GetAll().ToList();

            var model = TypeAdapter.Adapt<List<TB_FICANTE>, List<FicanteViewModel>>(ficantes);

            return View(model);
        }

        // GET: Ficante/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Ficante/Create
        public ActionResult Create()
        {
            var model = new FicanteViewModel();

            return View(model);
        }

        // POST: Ficante/Create
        [HttpPost]
        public ActionResult Create(FicanteViewModel model)
        {
            try
            {
                var ficante = TypeAdapter.Adapt<FicanteViewModel, TB_FICANTE>(model); //Adapt<"O que esta mandando", "O que quer">

                _ficanteService.Create(ficante);

                return RedirectToAction("Index");
            }
            catch
            {
                return View(model);
            }
        }

        // GET: Ficante/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Ficante/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Ficante/Delete/5
        public ActionResult Delete(int id)
        {
            var ficante = _ficanteService.Get(x => x.idFicante == id).First();

            _ficanteService.Remove(ficante);

            return RedirectToAction("Index");
        }
    }
}
