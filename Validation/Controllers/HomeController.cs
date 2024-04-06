using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Validation.Models;

namespace Validation.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;

		public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
		}

		public IActionResult Index()
		{
			AddUser model = new AddUser();
			return View(model);
		}
		[HttpPost]
		public IActionResult Index(AddUser model)
		{

			// Modele uygulanan tüm valiasyonlardan her þey okeyse, IsValid True olacaktýr.

			//ModelState üzerinden, validasyon ile ilgili bilgilere ulaþabilirsiniz.
			if (ModelState.IsValid)
			{
				// Devam eden iþleri burada yazmalýsýnýz.
			}
			return View();
		}

		public IActionResult Privacy()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
