using System;

public class Job
{

  public string _jobTitle = "";
  public int _startYear;
  public string _companyName = "";

  public void Display()
  {
    Console.WriteLine($"{_jobTitle} - started in: {_startYear} at {_companyName}");
  }
}