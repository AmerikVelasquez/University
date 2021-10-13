using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using UniversityRegistar.Models;
using System.Collections.Generic;
using System.Linq;

namespace UniversityRegistar.Controllers
{
  public class DepartmentsController : Controller
  {
    private readonly UniversityRegistarContext _db;

    public DepartmentsController(UniversityRegistarContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      return View(_db.Departments.ToList());
    }

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Department department, int CourseId)
    {
      _db.Departments.Add(department);
      _db.SaveChanges();
      if(CourseId != 0)
      {
        _db.Course_Department.Add(new Course_Department(){CourseId = CourseId, DepartmentId = department.DepartmentId});
      }
      _db.SaveChanges();
      return RedirectToAction("Index");      
    }

    public ActionResult Details(int id)
    {
      List<Student> studentList = _db.Students.Where(student => student.DepartmentId == id).ToList(); //code works but project stucture is limiting.
      ViewBag.Courses = studentList;
      var thisDepartment = _db.Departments 
        .Include(department => department.JoinEntities2)
        .ThenInclude(join => join.Course)
        .FirstOrDefault(department => department.DepartmentId == id);
      return View(thisDepartment);
    }

    public ActionResult Edit(int id)
    {
      var thisDepartment = _db.Departments.FirstOrDefault(department => department.DepartmentId == id);
      return View(thisDepartment);
    }

    [HttpPost]
    public ActionResult Edit(Department department)
    {
      _db.Entry(department).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Delete(int id)
    {
      var thisDepartment = _db.Departments
        .Include(department => department.JoinEntities2)
        .ThenInclude(join => join.Course)
        .FirstOrDefault(department => department.DepartmentId == id);
      return View(thisDepartment);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      var thisDepartment = _db.Departments.FirstOrDefault(department => department.DepartmentId == id);
      _db.Departments.Remove(thisDepartment);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}