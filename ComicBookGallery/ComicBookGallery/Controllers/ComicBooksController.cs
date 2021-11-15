using Microsoft.AspNetCore.Mvc;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {
        // RedirectResult and ContentResult both share the ActionResult base class 
        public ActionResult Detail()
        {
            // Redirect result 
            // Date time static property
            // Day of week enumeraton value Monday
            if (DateTime.Today.DayOfWeek == DayOfWeek.Tuesday) 
            {
                // Equivalent to below code
                return Redirect("/");

                // Redirect to home page
                //return new RedirectResult("/");
            }

            // Equivalent to below code
            return Content("Hello from the comic book controller.");

            /*
            // Action result 
            // Content result constructor call 
            return new ContentResult()
            {
                Content = "Hello from the comic book controller."
            };
            */ 
            
        }

    }
}
