using Microsoft.AspNetCore.Mvc;

namespace _7_ViewComponents.Components
{
	public class UserList : ViewComponent
	{

		public IViewComponentResult Invoke()
		{
			List<string> userList = new List<string>();
			userList.Add("İsmail");
			userList.Add("Berat");
			userList.Add("Havva");
			userList.Add("Merve");

			return View(userList);
		}
	}
}
