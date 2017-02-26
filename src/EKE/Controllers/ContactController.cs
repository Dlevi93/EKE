using Microsoft.AspNetCore.Mvc;
using EKE.Data.Entities;
using EKE.Service.Services;


namespace EKE.Controllers
{
    public class ContactController : Controller
    {
        private readonly IContactService contactService;

        public ContactController(
            IContactService contactService)
        {
            this.contactService = contactService;
        }
        // GET: /<controller>/
        public IActionResult Message(ContactMessage model)
        {
            if (!ModelState.IsValid)
                return View(model);
            var res = contactService.Add(model);
            if (!res.IsOk())
                return StatusCode(500, res.Message);
            TempData.Add("Message", "Messaj trimis");
            TempData.Add("ServerMessageType", "success");
            return RedirectToAction("Contact", "Home");
        }
    }
}
