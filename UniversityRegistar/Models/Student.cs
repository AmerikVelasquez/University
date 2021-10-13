using System.Collections.Generic;
using System;

namespace UniversityRegistar.Models
{
  public class Student
  {
    public Student()
    {
      this.JoinEntities = new HashSet<Registry>();
    }
    public int StudentId{get;set;}
    public string Name {get; set;}
    public int YearEnrolled { get; set;}
    public int DepartmentId{get; set;}
    public virtual ICollection<Registry> JoinEntities {  get; }
  }
}