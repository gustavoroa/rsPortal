using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RoaSystems.Server.Services;
using RoaSystems.Web.Portal.Models;
using RoaSystems.Web.Portal.Controllers;

namespace RoaSystems.Web.Portal.Controllers
{
    public class AplicacionesController : Controller
    {
        private readonly IAplicacionService _aplicacionService;
        private readonly IControllerHelper _controllerHelper;
        //private IEnumerable<Aplicacion>


        #region Constructor Methods..
        public AplicacionesController()
        {

        }
        public AplicacionesController(IAplicacionService topicService, IControllerHelper controllerHelper)
        {
            _controllerHelper = controllerHelper;
            _aplicacionService = topicService;
            ViewBag.Message = "Hello World";
        }
        #endregion

        // GET: Aplicaciones
        public ActionResult Index()
        {

            AplicacionesViewModel hmv = new AplicacionesViewModel();

            var apvm = new AplicacionesViewModel
            {
                Aplicaciones = _aplicacionService.GetAll()
            };


            //if (_controllerHelper != null)
            //{
            //    //_controllerHelper.PassedParameters = _controllerHelper.GetPassedParameters(HttpContext.Request.QueryString);
            //    hmv.CanonicalUrl = "http://www.stevesblindsandwallpaper.com";
            //    hmv.ThirdPartyJavaScriptBlocks = _controllerHelper.GetScriptBlocks();
            //}
            return View(apvm);
        }

        // GET: Aplicaciones/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Aplicaciones/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Aplicaciones/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Aplicaciones/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Aplicaciones/Edit/5
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

        // GET: Aplicaciones/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Aplicaciones/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
