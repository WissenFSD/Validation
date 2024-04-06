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

			// Modele uygulanan t�m valiasyonlardan her �ey okeyse, IsValid True olacakt�r.

			//ModelState �zerinden, validasyon ile ilgili bilgilere ula�abilirsiniz.
			if (ModelState.IsValid)
			{
				// Devam eden i�leri burada yazmal�s�n�z.

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
