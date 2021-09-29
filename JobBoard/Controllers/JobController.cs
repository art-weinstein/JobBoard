using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using JobBoard.Models;
using System;

namespace JobBoard.Controllers
{
  public class JobsController : Controller
  {
    [HttpGet("/jobs/new")]
    public ActionResult New()
    {
      return View();
    }
  }
}