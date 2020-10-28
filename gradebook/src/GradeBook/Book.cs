using System;
using System.Collections.Generic;

namespace GradeBook
{
  class Book
  {
    public Book(string name)
    {
      grades = new List<double>();
      this.name = name;
    }
    public void AddGrade(double grade)
    {
      grades.Add(grade);
    }

    public void ShowStats()
    {
      var gradeAverage = 0.0;
      var highGrade = double.MinValue;
      var lowGrade = double.MaxValue;
      grades.ForEach(x =>
      {
        gradeAverage += x;
        highGrade = Math.Max(x, highGrade);
        lowGrade = Math.Min(x, lowGrade);
      });
      gradeAverage = gradeAverage / grades.Count;
      Console.WriteLine($"The average grade is {gradeAverage:N1}.");
      Console.WriteLine($"The highest grade is {highGrade:N1}.");
      Console.WriteLine($"The lowest grade is {lowGrade:N1}.");
    }

    private List<double> grades;
    private string name;
  }
}