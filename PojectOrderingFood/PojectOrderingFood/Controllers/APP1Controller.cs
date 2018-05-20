using PojectOrderingFood.Models;
using PojectOrderingFood.BaseLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace PojectOrderingFood.Controllers
{
    public class APP1Controller : Controller
    {
        IAplicationLogic  aplicationLogic;

        public APP1Controller()
        {
            aplicationLogic = new BaseLogic();
        }

        public ActionResult Index()
        {
            return View(aplicationLogic.GetAplicationUser().Select(p => new DetailsDeleteAplicationUserViewModel(p)).ToList());
        }

        // GET: ConferenceUser/Details/5
        public ActionResult Details(Guid id)
        {
            return View(new DetailsDeleteAplicationUserViewModel(aplicationLogic.GetAplicationUser(id)));
        }

        // GET: ConferenceUser/Create
        public ActionResult Create()
        {
            return View(new AddEditAplicationUser(aplicationLogic));
        }

        // POST: ConferenceUser/Create
        [HttpPost]
        public ActionResult Create(AddEditAplicationUser aplicationUser)
        {
            try
            {
                aplicationLogic.AddAplicationUser(new AddEditAplicationUser().conferenceUserFromViewModel(aplicationLogic, aplicationUser));
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: ConferenceUser/Create
        public ActionResult CreateTown()
        {
            return View();
        }


        // GET: ConferenceUser/Edit/5
        public ActionResult Edit(Guid id)
        {
            return View(new AddEditAplicationUser(aplicationLogic, aplicationLogic.GetAplicationUser(id)));
        }

        // POST: ConferenceUser/Edit/5
        [HttpPost]
        public ActionResult Edit(Guid Id, AddEditAplicationUser collection)
        {
            try
            {
                aplicationLogic.Edit(Id, new AddEditAplicationUser().conferenceUserFromViewModel(aplicationLogic, collection));

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: ConferenceUser/Delete/5
        public ActionResult Delete(Guid id)
        {
            return View(aplicationLogic.GetAplicationUser(id));
        }

        // POST: ConferenceUser/Delete/5
        [HttpPost]
        public ActionResult Delete(Guid id, FormCollection collection)
        {
            try
            {
                aplicationLogic.Delete(id);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: ConferenceUser/Restore/5
        public ActionResult Restore(bool info = false)
        {
            ViewBag.SendEmail = info;
            return View();
        }

        //// POST: ConferenceUser/Restore/5
        //[HttpPost]
        //public ActionResult Restore(string Email)
        //{
        //    try
        //    {
        //        var email = Email;
        //        var user = aplicationLogic.GetAplicationUser().Find(x => x.Email == email);
        //        var hash = Md5($"{user.Id}{user.Password}{user.CreateDate}");
        //        var url = $"http://{Request.Url.Authority}/Etap1CRUD/ChangePassword?id={user.Id}&hash={hash}";
        //        //var sm = new SendEmailLogic(email, url);
        //        //sm.SendEmail();
        //        return RedirectToAction("Restore", new { info = true });
        //    }
        //    catch
        //    {
        //        return View("Restore");
        //    }
        //}
        //public ActionResult ChangePassword(Guid Id, string hash)
        //{
        //    return View();
        //}

        //// POST: ConferenceUser/Restore/5
        //[HttpPost]
        //public ActionResult ChangePassword(Guid Id, string hash, ChangePasswordViewModel changePasswordViewModel)
        //{
        //    try
        //    {
        //        var user = aplicationLogic.GetConferenceUser(Id);
        //        var checkHash = Md5($"{user.Id}{user.Password}{user.CreateDate}");
        //        if (hash.Equals(checkHash))
        //        {
        //            aplicationLogic.EditPassword(Id, changePasswordViewModel.Password);
        //        }
        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View("ChangePassword");
        //    }
        //}

        //public string Md5(string input)
        //{
        //    using (MD5 md5Hash = MD5.Create())
        //    {
        //        byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
        //        StringBuilder sBuilder = new StringBuilder();

        //        for (int i = 0; i < data.Length; i++)
        //        {
        //            sBuilder.Append(data[i].ToString("x2"));
        //        }
        //        return sBuilder.ToString();
        //    }

        //}

        //[HttpPost]
        //public ActionResult CheckExistingEmail(string Email)
        //{
        //    try
        //    {
        //        return Json(!IsEmailExists(Email));
        //    }
        //    catch
        //    {
        //        return Json(false);
        //    }
        //}

        public bool IsEmailExists(string email)
        {
            if (aplicationLogic.GetAplicationUser().Where(x => x.Email == email).Count() != 0)
            {
                return true;
            }
            else return false;
        }
    }
}