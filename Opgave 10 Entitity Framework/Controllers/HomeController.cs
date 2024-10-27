using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Opgave_10_Entitity_Framework.Data;
using Opgave_10_Entitity_Framework.Models;

namespace Opgave_10_Entitity_Framework.Controllers
{
    public class HomeController : Controller
    {
		private BilContext bilcontext = new BilContext();

		public IActionResult Index()
        {
           
            bilcontext.Database.EnsureCreated();

   //         Bil bil2 =new Bil();
   //         Ejer ejer1= bilcontext.Ejer.Where(b => b.EjerID == -1).First();
   //         bil2.Name = "";
   //         bil2.Weight = 100;
   //         bil2.Ejer = ejer1;
           
   //         bilcontext.Biler.Add(bil2);
		



			Ejer ejer = bilcontext.Ejer.Where(b => b.EjerID == -1).Include(e => e.BilList).First();

            Console.WriteLine(ejer.Navn + " "+ ejer.EjerID);
            foreach (Bil bil in ejer.BilList)
            {
                Console.WriteLine(bil.Name + " " + bil.EjerID);

            }
			List<Ejer> listEjer = bilcontext.Ejer.ToList();
			bilcontext.SaveChanges();

			return View(listEjer);
        }

        [HttpPost]
       public IActionResult Index(IFormCollection formData)
       {
			bilcontext.Database.EnsureCreated();

            string ejerNavn = formData["EjerNavn"];
			List<Ejer> listEjer = bilcontext.Ejer.ToList();

			Ejer ejer =  bilcontext.Ejer.Where(e => e.Navn == ejerNavn).First();
            
            List<Bil> listBiler = bilcontext.Biler.Where(b=> b.EjerID == ejer.EjerID).ToList();
           
            ViewBag.Biler = listBiler;

			bilcontext.SaveChanges();

			return View(listEjer);
       }

        public IActionResult EditBil(IFormCollection formData)
        {

            Console.WriteLine("HEJ");
            int bilId = int.Parse(formData["BilID"]);
            string newBilName = formData["NewBilName"];
			Bil bil = bilcontext.Biler.Where(b => b.BILID == bilId).FirstOrDefault();

            if(bil != null)
            {
                bil.Name = newBilName;
                bilcontext.SaveChanges();
			
			}
			

			return  RedirectToAction("Index");
        }
    }
}
