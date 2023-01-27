using Hospital.Services;
using Microsoft.AspNetCore.Mvc;

namespace Hospital.Web.Areas.Admin.Controllers
{
    public class HospitalsController : Controller
    {
        private IHospitalInfo _hospitalInfo;
        public IActionResult Index()
        {
            return View();
        }
    }
}
