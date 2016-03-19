using Indieeye.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Indieeye.Controllers
{
    public class SurvellanceController : ApiController
    {
        CriminalDetails[] criminalObj = new CriminalDetails[] {
            new CriminalDetails { Id = 1, Name = "Tomato Soup", Category = "Groceries" },
            new CriminalDetails { Id = 2, Name = "Yo-yo", Category = "Toys" },
            new CriminalDetails { Id = 3, Name = "Hammer", Category = "Hardware" }
        };

        // /api/Survellance
        public IEnumerable<CriminalDetails> GetCriminalDetails()
        {
            return criminalObj;
        }

        // /api/Survellance/id
        public IHttpActionResult GetCriminal(int id)
        {
            var criminal = criminalObj.FirstOrDefault((c) => c.Id == id);
            if (criminal == null)
            {
                return NotFound();
            }
            return Ok(criminal);
        }

        public IHttpActionResult GetIntruderdetail(int id)
        {
            return null;
        }

        // POST api/Survellance
        public HttpResponseMessage PostIntruderData(Intruder value)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    return null;
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.InternalServerError, "Invalid Model");
                }
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }
}
