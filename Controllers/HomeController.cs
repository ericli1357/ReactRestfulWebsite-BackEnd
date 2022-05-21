using EmailService;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReactRestfulWebsite.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HomeController : ControllerBase
    {
        private readonly IEmailSender _emailSender;

        public HomeController(IEmailSender emailSender)
        {
            _emailSender = emailSender;
        }

        [HttpPost("sendEmail")]
        public ActionResult SendEmail(Message m)
        {
            _emailSender.SendEmail(m);
            return NoContent();
        }
    }
}