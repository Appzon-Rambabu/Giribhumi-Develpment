using System;
using System.Web.Http;

namespace ROFR.Controllers
{
    public class ClaimprocessController : ApiController
    {
        [HttpPost]
        [Route("api/Claimprocess/gramasabhaRegistration")]
        public IHttpActionResult gramasabhaRegistration()//GramasabhaRegistrationDO gramasabhaRegistrationDO)
        {
            try
            {
                if (model == null)
                {
                    return Ok(new
                    {
                        jsonResults = new
                        {
                            status = false,
                            message = "Invalid request data."
                        }
                    });
                }

                // Call your registration business logic here.

                return Ok(new
                {
                    jsonResults = new
                    {
                        status = true,
                        message = "Registration successful.",
                        data = model
                    }
                });
            }
            catch (Exception ex)
            {
                return Ok(new
                {
                    jsonResults = new
                    {
                        status = false,
                        message = ex.Message
                    }
                });
            }
        }
    }

    //public class GramasabhaRegistrationDO
    //{
    //    public string GramSabhaName { get; set; }
    //    public string VillageName { get; set; }
    //    public string MandalName { get; set; }
    //    public string DistrictName { get; set; }
    //    public string RegistrationDate { get; set; }
    //}
}