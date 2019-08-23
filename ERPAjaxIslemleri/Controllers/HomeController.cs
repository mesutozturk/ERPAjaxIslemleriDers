using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ERPAjaxIslemleri.Models;

namespace ERPAjaxIslemleri.Controllers
{
    public class HomeController : Controller
    {
        private readonly AjaxContext _context;

        public HomeController()
        {
            _context = new AjaxContext();
        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public JsonResult CheckTckn(string tckn)
        {
            var result = _context.Kisiler.Any(x => x.Tckn == tckn);
            return Json(new
            {
                success = result
            }, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult AddKisi(Kisi model)
        {
            if (!ModelState.IsValid)
            {

                return Json(new { success = false });
            }

            var item = new Kisi()
            {
                Tckn = model.Tckn,
                Ad = model.Ad,
                Soyad = model.Soyad
            };
            _context.Kisiler.Add(item);

            try
            {
                _context.SaveChanges();
                return Json(new
                {
                    success = true,
                    message = "Kayıt başarıyla eklendi",
                    primary = item.Id
                });
            }
            catch (Exception ex)
            {
                return Json(new
                {
                    success = false,
                    message = $"Bir hata oluştu: {ex.Message}",
                    primary = item.Id
                });
            }
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}