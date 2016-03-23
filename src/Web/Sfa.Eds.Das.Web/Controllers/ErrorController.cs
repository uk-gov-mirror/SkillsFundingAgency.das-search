﻿namespace Sfa.Eds.Das.Web.Controllers
{
    using System.Web.Mvc;

    public sealed class ErrorController : Controller
    {
        // GET: Error
        public ViewResult NotFound()
        {
            Response.StatusCode = 404;

            return View("_Error404");
        }

        public ViewResult Error()
        {
            Response.StatusCode = 500;

            return View("_Error500");
        }
    }
}