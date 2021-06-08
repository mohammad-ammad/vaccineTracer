using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using vaccineTracer.Models;

namespace vaccineTracer.Controllers
{
    public class RegisterUserController : Controller
    {
        // GET: RegisterUser
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(RegClass data)
        {
            if (ModelState.IsValid)
            {
                HttpClient hc = new HttpClient();
                hc.BaseAddress = new Uri("http://localhost:51634/Api/RegistrationApi");
                var consume = hc.PostAsJsonAsync<RegClass>("RegistrationApi", data);
                consume.Wait();
                var test = consume.Result;
                if (test.IsSuccessStatusCode)
                {
                    ViewBag.message = "Registration Successfull";
                }
            }
            return View();
        }
    }
}