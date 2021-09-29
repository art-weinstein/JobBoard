using System.Collections.Generic;

namespace JobBoard.Models
{
  public class Job
  {
    public string Title { get; set; }
    public string Description { get; set; }
    public string ContactInfo { get; set; }
    private static List<Job> _instances = new List<Job> {};

    public Job (string title, string description, string contactInfo)
    {
      Title = title;
      Description = description;
      ContactInfo = contactInfo;
      _instances.Add(this);
    }
  }
}