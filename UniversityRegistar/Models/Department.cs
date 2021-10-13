using System.Collections.Generic;

namespace UniversityRegistar.Models
{
  public class Department
  {
    public Department()
    {
      this.JoinEntities2 = new HashSet<Course_Department>();
    }
     public int DepartmentId { get; set; }
      public string Name { get; set; }
      public string Description { get; set; }
      public virtual ICollection<Course_Department> JoinEntities2 {get; set;}
  }
}