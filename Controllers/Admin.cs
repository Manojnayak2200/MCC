using MCC.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MCC.Controllers
{
    public class Admin : Controller
    {

        public IActionResult login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult loginsuccess(string username, string password)
        {
            try
            {
                //UserEntityClame claims = new UserEntityClame();
                //claims = _ilogin.logiuser(username, password);
                //if (claims != null)
                //{
                //    Logiuser.UID = claims.UID;
                //    Logiuser.USERNAME = claims.USERNAME;
                //    Logiuser.ROLEID = claims.ROLEID;
                //    Logiuser.ROLENAME = claims.ROLENAME;
                //    if (claims.approvedAuthority == 1)
                //    {
                //        string url = Url.Action("index", "users", new { Area = "User" });
                //        return Json(url);
                //    }
                UserEntityClame.FULLNAME = "MANOJ";
                UserEntityClame.ROLEID = 1;
                UserEntityClame.ROLENAME = "Admin";

                if (UserEntityClame.ROLEID  == 1)
                {
                    string url = Url.Action("Loagisuccess", "Admin");
                    return Json(url);
                }
                else
                 {

                        return Json(3);
                 }

                
               
            }
            catch (Exception ex)
            {
                return Json(0);
            }

        }

        public IActionResult Loagisuccess()
        {
            return View();
        }

    }


}
