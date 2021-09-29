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
    [HttpGet("/jobs")]
    public ActionResult Index()
    {
      List<Job> allJobs = Job.GetAll();

      return View(allJobs);
    }

    [HttpPost("/jobs")]
    public ActionResult Create(string title, string description, string contactInfo)
    {
      Job myJob = new Job(title, description, contactInfo);
      return RedirectToAction("Index");
    }

    [HttpGet("/jobs/{id}")]
    public ActionResult Show(int id)
    {
      Job foundJob = Job.Find(id);
      return View(foundJob);
    }

    [HttpPost("/jobs/delete/{id}")]
    public ActionResult Destroy(int id)
    {
      Job.Find(id).ClearJob();
      return View();
    }

    [HttpGet("/jobs/deleted/")]
    public ActionResult GetDeleted()
    {
      List<Job> allJobs = Job.GetAll();
      return View(allJobs);
    }
  }
}