using DapperPractices.Models;
using DapperPractices.Repository;
using Microsoft.AspNetCore.Mvc;

namespace CRUDUsingMVC.Controllers
{
    public class EmployeeController : Controller
    {
        public ActionResult GetAllEmpDetails()
        {
            EmployeeRepository EmpRepo = new EmployeeRepository();
            return View(EmpRepo.GetAllEmployees());
        }
        public ActionResult AddEmployee()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddEmployee(Employee Emp)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    EmployeeRepository EmpRepo = new EmployeeRepository();
                    EmpRepo.AddEmployee(Emp);
                    ViewBag.Message = "Records added successfully.";
                }
                return View();
            }
            catch
            {
                return View();
            }
        }
        public ActionResult EditEmpDetails(int id)
        {
            EmployeeRepository EmpRepo = new EmployeeRepository();
            return View(EmpRepo.GetAllEmployees().Find(Emp => Emp.EmployeeId == id));
        }
        [HttpPost]
        public ActionResult EditEmpDetails(int id, Employee obj)
        {
            try
            {
                EmployeeRepository EmpRepo = new EmployeeRepository();
                EmpRepo.UpdateEmployee(obj);
                return RedirectToAction("GetAllEmpDetails");
            }
            catch
            {
                return View();
            }
        }
        public ActionResult DeleteEmp(int id)
        {
            try
            {
                EmployeeRepository EmpRepo = new EmployeeRepository();
                if (EmpRepo.DeleteEmployee(id))
                {
                    ViewBag.AlertMsg = "Employee details deleted successfully";
                }
                return RedirectToAction("GetAllEmpDetails");
            }
            catch
            {
                return RedirectToAction("GetAllEmpDetails");
            }
        }
    }
}