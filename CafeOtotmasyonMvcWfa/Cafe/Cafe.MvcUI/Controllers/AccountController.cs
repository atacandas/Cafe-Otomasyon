using Cafe.Bll.Abstracts;
using Cafe.Bll.Concretes.Managers;
using Cafe.Dal.Concretes.EntityFramework;
using Cafe.Entity.Concretes;
using Cafe.MvcUI.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cafe.MvcUI.Controllers
{
    public class AccountController : Controller
    {
        IEmployeeService _employeeManager = EmployeeManager.CreateSingleton(new EfEmployeeDal());
        [HttpGet]
        public ActionResult AdminLogin()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AdminLogin(Employee employee)
        {
            if (Session["myLogin"]!=null)
            {
                TempData["message"] = "Önce çıkış yapmalısınız";
                return RedirectToAction("ListProductsForOrder", "AdminOrder");
            }
            Employee loginEmployee = _employeeManager.GetEmployee(employee.UserName, employee.Password);  
            if (loginEmployee != null)
            {
                Session["myLogin"] = loginEmployee;
                Session["myLoginName"] = $"{loginEmployee.UserName}";
                return RedirectToAction("ListProductsForOrder", "AdminOrder");
            }
            TempData["message"] = "Kullanici adi şifre yanlış";
            return View();
        }
        [HttpGet]
        public ActionResult AdminLogout()
        {
            if (Session["myLogin"] != null)
            {
                Session.Remove("myLogin");
                Session.Remove("myLoginName");
            }
            return View("AdminLogin");
        }
        [HttpGet]
        public ActionResult ForgetPassword()
        {
            TempData["message"] = "Its your problem";
            return RedirectToAction("AdminLogin");
        }
    }
}