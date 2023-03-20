using _9_ViewModel.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace _9_ViewModel.Controllers
{
    public class OgrenciController : Controller
    {
        public IActionResult Index()
        {
            OgrenciRepository ogrenciRepository = new OgrenciRepository(); 

            return View(ogrenciRepository.GetList());
        }
    }
}