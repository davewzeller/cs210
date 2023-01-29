using System;

public class Resume
{
    public string _name;

    
    public List<Job> _jobs = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        
        foreach (Job job in _jobs)
        {
            DateTime dt1 = new DateTime();
            Console.WriteLine(dt1);
            job.Display();
        }
    }
}