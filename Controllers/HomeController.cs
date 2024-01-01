using Microsoft.AspNetCore.Mvc;
using RockPaperScissors.Models;
using System.Diagnostics;

namespace RockPaperScissors.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Home()
		{
			UserModel user = new UserModel();
			return View(user);
		}
		[HttpPost]
		public ActionResult Result(UserModel user)
		{
			user.GetUserSelection();
			ComputerModel computer = new ComputerModel();
			CalculationModel calculation = new CalculationModel(user.Selection, computer.Selection);
			return View(calculation);
		}
	}
}
