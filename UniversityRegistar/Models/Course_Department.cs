namespace UniversityRegistar.Models
{
  public class Course_Department
  {
    public int Course_DepartmentId {get; set;}
    public int CourseId {get; set;}
    public int DepartmentId {get; set;}
    public virtual Course Course {get; set;}
    public virtual Department Department {get; set;}
  }
}