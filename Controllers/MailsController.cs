using AmazonSES.Demo.Models;
using AmazonSES.Demo.Services;
using Microsoft.AspNetCore.Mvc;

namespace AmazonSES.Demo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MailsController : ControllerBase
    {
        private readonly IMailService _mailService;
        public MailsController(IMailService mailService)
        {
            _mailService = mailService;
        }

        [HttpPost]
        public async Task<IActionResult> SendMail(MailRequest mailRequest)
        {
            await _mailService.SendEmailAsync(mailRequest);

            return Ok();
        }
    }
}
