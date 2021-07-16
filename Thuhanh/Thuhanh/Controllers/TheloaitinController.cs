using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Thuhanh.Models;

namespace Thuhanh.Controllers
{
    public class TheloaitinController : Controller
    {
        DataClasses1DataContext data = new DataClasses1DataContext();
        // GET: Theloaitin
        public ActionResult Index()
        {

            var all_theloai = from tt in data.Theloaitins select tt;
           
            return View(all_theloai);

        }
        public ActionResult Details( int id)
        {
            var Details_tin = data.Theloaitins.Where(m => m.Maloai == id).First();
            return View(Details_tin);

        }
        public ActionResult Create  ()
        {
            return View();
        }

       [HttpPost]
       public ActionResult Create (FormCollection collection ,Theloaitin ltin)
        {
            var cb_loaitin = collection["Tentheloai"];
            if(string.IsNullOrEmpty(cb_loaitin))
            {
                ViewData["Loi"] = "Thể loại tin không được để trống";

            }
            else
            {
                ltin.Tentheloai = cb_loaitin;
                data.Theloaitins.InsertOnSubmit(ltin);
                data.SubmitChanges();
                return RedirectToAction("Index");
            }
            return this.Create();
        }
        public ActionResult Edit (int id)
        {
            var ED_tin = data.Theloaitins.First(m => m.Maloai == id);
            return View(ED_tin);
        }

        [HttpPost]
        public ActionResult Edit (int id ,FormCollection collection)
        {
            var Ltin = data.Theloaitins.First(m => m.Maloai == id);
            var E_loaitin = collection["Tentheloai"];
            Ltin.Maloai = id;
            if( String.IsNullOrEmpty(E_loaitin))
            {
                ViewData["Loi"] = " The loai tin khong được để trông";

            }
            else
            {
                Ltin.Tentheloai = E_loaitin;
                UpdateModel(Ltin);
                data.SubmitChanges();
                return RedirectToAction("index");

            }
            return this.Edit(id);
        }

        public ActionResult Delete (int id)
        {
            var EB_tin = data.Theloaitins.First(m => m.Maloai == id);
            return View(EB_tin);
        }

        [HttpPost]
        public ActionResult Delete (int id, FormCollection collection)
        {
            var D_tin = data.Theloaitins.Where(m => m.Maloai == id).First();
            data.Theloaitins.DeleteOnSubmit(D_tin);
            data.SubmitChanges();
            return RedirectToAction("index");
        }
    }
}