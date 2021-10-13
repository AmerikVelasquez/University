namespace UniversityRegistar.Models
{
  public class Registry
  {
    public int RegistryId {get; set;}
    public int CourseId {get; set;}
    public int StudentId {get; set;}
    
    public virtual Course Course {get; set;}
    public virtual Student Student {get; set;}
  }
}