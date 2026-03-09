using System;

public class Job
{
    public string _jobTitle = "";
    public string _company = "";
    public int _startYear = 0;
    public int _endYear = 0;
    public string _endDateText = "";
    public string _description = "";
    public void Display()
    {
        if (_endYear == 0)
        {
            _endDateText = "present";
        }
        else
        {
            _endDateText = _endYear.ToString();
        }
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endDateText}");
        if (_description != "")
        {
            Console.WriteLine($"{_description}");
        }
    }
}