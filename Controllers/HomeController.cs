using Microsoft.AspNetCore.Mvc;

using TPLOCAL1.Models;

//Subject is find at the root of the project and the logo in the wwwroot/ressources folders of the solution
//--------------------------------------------------------------------------------------
//Careful, the MVC model is a so-called convention model instead of configuration,
//The controller must imperatively be name with "Controller" at the end !!!
namespace TPLOCAL1.Controllers
{
    public class HomeController : Controller
    {
     
    
      //methode "naturally" call by router
        public IActionResult Index(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
                //retourn to the Index view (see routing in Program.cs)
                return View();
            else
            {
                //Call different pages, according to the id pass as parameter
                switch (id)
                {
                    case "AvisList":
                        //TODO : code reading of the xml files provide
                        return View(id,new OpinionList().GetAvis("XlmFile/DataAvis.xml"));
                    case "Form":
                        //TODO : call the Form view with data model empty
                        return View(id);

                    default:
                        //retourn to the Index view (see routing in Program.cs)
                        return View();
                }
            }
        }


        //methode to send datas from form to validation page
        [HttpPost]
        public IActionResult FormValidation(Dataform data)
        {

                if (ModelState.IsValid)
                {
                return View(data);
                }
                return View("FormValidation", data);
        }

    }
}