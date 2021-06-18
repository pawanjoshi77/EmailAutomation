using EmailAutomation.Helpers;
using System;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace EmailAutomation.Controllers
{
    public class EmailController : BaseController
    {
        // GET: Emails
        [Authorize]
        public async Task<ActionResult> Index()
        {
            var messages = await GraphHelper.GetEmailsAsync();           

            //return Json(messages, JsonRequestBehavior.AllowGet);
            return View(messages);
        }
    }
}