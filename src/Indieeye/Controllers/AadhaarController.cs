using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using Indieeye.Models;

namespace Indieeye.Controllers
{
    public class AadhaarController : ApiController
    {
        private AadhaarContext db = new AadhaarContext();

        // GET: api/Aadhaar
        public IQueryable<ValidateAadhaar> GetValidateAadhaars()
        {
            return db.ValidateAadhaars;
        }

        // GET: api/Aadhaar/5
        [ResponseType(typeof(bool))]
        public async Task<IHttpActionResult> GetValidateAadhaar(int id)
        {
            ValidateAadhaar validateAadhaar = await db.ValidateAadhaars.FindAsync(id);
            if (validateAadhaar == null)
            {
                return Ok(false); ;
            }
            return Ok(true);
        }
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
        
    }
}