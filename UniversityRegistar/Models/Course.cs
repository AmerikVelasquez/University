using System.Collections.Generic;

namespace UniversityRegistar.Models
{
  public class Course 
  {
    public Course()
    {
      this.JoinEntities = new HashSet<Registry>();
      this.JoinEntities2 = new HashSet<Course_Department>();
    }

    public int CourseId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public virtual ICollection<Registry> JoinEntities { get; set; }
    public virtual ICollection<Course_Department> JoinEntities2 { get; set; }
  }
}