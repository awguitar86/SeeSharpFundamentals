using System;
using System.Collections.Generic;

namespace GradeBook
{
  public class Book
  {
    public Book(string name)
    {
      grades = new List<double>();
      Name = name;
    }
    public void AddGrade(double grade)
    {
      if (grade <= 100 && grade >= 0)
      {
        grades.Add(grade);
      }
    }

    public Statistics GetStats()
    {
      var result = new Statistics();
      result.Average = 0.0;
      result.High = double.MinValue;
      result.Low = double.MaxValue;
      grades.ForEach(x =>
      {
        result.Average += x;
        result.High = Math.Max(x, result.High);
        result.Low = Math.Min(x, result.Low);
      });
      result.Average /= grades.Count;

      return result;
    }

    private List<double> grades;
    public string Name;
  }
}