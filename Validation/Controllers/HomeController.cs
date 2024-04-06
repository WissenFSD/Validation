using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Validation.DataModel;
using Validation.Models;

namespace Validation.Controllers
{
	public class HomeController : Controller
	{
		ValidationsContext _context;
		public HomeController(ValidationsContext context)
		{
			_context = context;
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

				_context.Users.Add(new DataModel.User()
				{
					Age = model.Age,
					Email = model.Email,
					IdentityNumber = model.IdentityNo,
					Name = model.Name,
					Surname = model.LastName

				});
				_context.SaveChanges();
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
