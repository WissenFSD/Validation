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

			// Modele uygulanan t�m valiasyonlardan her �ey okeyse, IsValid True olacakt�r.

			//ModelState �zerinden, validasyon ile ilgili bilgilere ula�abilirsiniz.
			if (ModelState.IsValid)
			{
				// Devam eden i�leri burada yazmal�s�n�z.
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
