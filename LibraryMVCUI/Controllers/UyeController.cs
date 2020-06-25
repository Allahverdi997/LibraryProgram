using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using BusinessLogicalLayer;

namespace LibraryMVCUI.Controllers
{
    public class UyeController : Controller
    {
        //
        // GET: /Uye/

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string UserName,string Password)
        {
            bool sonuc = Membership.ValidateUser(UserName, Password);
            if (sonuc)
            {
                FormsAuthentication.RedirectFromLoginPage(UserName,false);
                return View();
            }
            else
            {
                string mesaj = "Kullanici Adi Ve Ya Parola Yanlistir...";
                ViewBag.Mesaj = mesaj;
                return View();
            }
           
        }

        public ActionResult RegistrOl()
        {
            return View();
        }

        [HttpPost]
        public ActionResult RegistrOl(string username, string email, string password,string passwordQuestions,string passwordAnswer)
        {
            MembershipCreateStatus status;
            MembershipUser mu = Membership.CreateUser(username, password, email, passwordQuestions, passwordAnswer, true, out status);
            string mesaj = "";

            switch (status)
            {
                case MembershipCreateStatus.DuplicateEmail: mesaj = "Email Tekrari.";
                    break;
                case MembershipCreateStatus.DuplicateProviderUserKey:
                    break;
                case MembershipCreateStatus.DuplicateUserName: mesaj =mesaj+"Kullanici Adi Tekrari.";
                    break;
                case MembershipCreateStatus.InvalidAnswer: mesaj=mesaj+ "Gecersiz Soru.";
                    break;
                case MembershipCreateStatus.InvalidEmail: mesaj =mesaj+"Gecersiz Email.";
                    break;
                case MembershipCreateStatus.InvalidPassword: mesaj =mesaj+"Gecersiz Parola: Parola en az 7 karakterden olusmali ve icinde 1 tane @,* ve bu gibi karakterler olmalidir.";
                    break;
                case MembershipCreateStatus.InvalidProviderUserKey:
                    break;
                case MembershipCreateStatus.InvalidQuestion: mesaj = mesaj+"Gecersiz Soru";
                    break;
                case MembershipCreateStatus.InvalidUserName: mesaj =mesaj+"Gecersiz Kullanici Adi.";
                    break;
                case MembershipCreateStatus.ProviderError:
                    break;
                case MembershipCreateStatus.Success:
                    break;
                case MembershipCreateStatus.UserRejected:
                    break;
                default:
                    break;
            }

            if (status==MembershipCreateStatus.Success)
            {
                
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.Mesaj = mesaj;
                return View();
            }
            
        }

        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index");
        }

        public ActionResult Okuyucu()
        {
            ViewBag.Okuyucu = Membership.GetAllUsers();
            return View();
        }

        public ActionResult RolElaveEt()
        {
            return View(Roles.GetAllRoles());
        }

        [HttpPost]
        public ActionResult RolElaveEt(string rol)
        {
            string rolname = (rol.Trim()).ToUpper();
            Roles.CreateRole(rolname);
            return View(Roles.GetAllRoles());
        }

        public ActionResult OxuyucuyaRolElaveEt()
        {
            ViewBag.Rol = Roles.GetAllRoles();
            ViewBag.Okuyucu = Membership.GetAllUsers();
            return View();
        }

        [HttpPost]
        public ActionResult OxuyucuyaRolElaveEt(string username,string rol)
        {
            Roles.AddUserToRole(username, rol);

            ViewBag.Rol = Roles.GetAllRoles();
            ViewBag.Okuyucu = Membership.GetAllUsers();
            return View();
        }
    }
}
