using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using vaccineTracer.Models;

namespace vaccineTracer.Controllers
{
    public class RegistrationApiController : ApiController
    {
        public IHttpActionResult Insert(RegClass data)
        {
            VaccinationSystemEntities1 db = new VaccinationSystemEntities1();
            db.UserRegisters.Add(new UserRegister() {
                first_name = data.first_name,
                last_name = data.last_name,
                cnic = data.cnic,
                age = data.age,
                city = data.city,
                reg_date = data.reg_date
            });

            db.SaveChanges();
            return Ok();
        }
    }
}
