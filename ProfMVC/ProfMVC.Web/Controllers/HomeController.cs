using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProfMVC.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "I like cake!!!!";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}

//Scaffold	Description
//Create	    Creates a view with a form for generating new instances of the model. Generates a label and input field for each property of the model type.
//Delete	    Creates a view with a form for deleting existing instances of the model. Displays a label and the current value for each property of the model.
//Details	    Creates a view that displays a label and the value for each property of the model type.
//Edit	    Creates a view with a form for editing existing instances of the model. Generates a label and input field for each property of the model type.
//Empty	    Creates an empty view. Only the model type is specified using the @model syntax.
//Empty       (without model)	Creates an empty view, as with the Empty scaffold. In this case, however, there's no model so you're not required to select a model type when you select this scaffold. This is the only scaffold type which does not require you to select a model type.
//List	    Creates a view with a table of model instances. Generates a column for each property of the model type. Make sure to pass an IEnumerable<YourModelType> to this view from your action method. The view also contains links to actions for performing the create/edit/delete operations.