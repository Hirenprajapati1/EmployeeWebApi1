﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using EmployeeWebApi.Repository;
using EmployeeWebApi.Models;

namespace EmployeeWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("AllowMyOrigin")]

    public class EmployeeMainController : ControllerBase
    {
            EmployeeRepository EmployeeRepositoryObject = new EmployeeRepository();
  
        
        [HttpGet("GetEmployees")]
        public List<EmployeeModel> GetEmployees()
        {
            return (EmployeeRepositoryObject.GetEmployees());
        }



        [HttpPost("AddEmployee")]
        public int Addemployee([FromBody] EmployeeModel emp)
        {
            return EmployeeRepositoryObject.AddEmployeeData(emp);
        }

        //public IActionResult AddEmployees()
        //{
        //    DepartmentRepository departmentRepository = new DepartmentRepository();
        //    var department = departmentRepository.GetDepartments();
        //    ViewBag.Data1 = department;

        //    DesignationRepository designationRepository = new DesignationRepository();
        //    var Designation = designationRepository.GetDesignations();
        //    ViewBag.Data = Designation;

        //    //DesignationRepository designationRepository = new DesignationRepository();
        //    //ViewBag["Designation"] = designationRepository.GetDesignations();
        //    //DesignationRepository designationRepository = new DesignationRepository();
        //    //ViewBag["Designation"] = designationRepository.GetDesignations();

        //    return View();
        //}
        //[HttpPost]
        //public ActionResult AddEmployees(EmployeeModel emp)
        //{
        //    DepartmentRepository departmentRepository = new DepartmentRepository();
        //    var department = departmentRepository.GetDepartments();
        //    ViewBag.Data1 = department;

        //    DesignationRepository designationRepository = new DesignationRepository();
        //    var Designation = designationRepository.GetDesignations();
        //    ViewBag.Data = Designation;


        //    EmployeeRepository EmployeeRepositoryObject = new EmployeeRepository();
        //    //AddEmployee AddEmployeeObject = new AddEmployee();
        //    if (EmployeeRepositoryObject.AddEmployeeData(emp))
        //    {
        //        ViewBag.Msg = "Employee Details are successfully Added";
        //    }
        //    else
        //    {
        //        ViewBag.Msg = "Employee Details are Not successfully Added";
        //    }
        //    return View(emp);


        //}

        //public IActionResult GetEmployees()
        //{
        //    EmployeeRepository EmployeeRepositoryObject = new EmployeeRepository();

        //    ModelState.Clear();
        //    DepartmentRepository departmentRepository = new DepartmentRepository();
        //    var department = departmentRepository.GetDepartments();
        //    ViewBag.Data1 = department;

        //    DesignationRepository designationRepository = new DesignationRepository();
        //    var Designation = designationRepository.GetDesignations();
        //    ViewBag.Data = Designation;

        //    return View(EmployeeRepositoryObject.GetEmployees());
        //}

        



        //public IActionResult UpdateEmployee(int ID)
        //{
        //    EmployeeRepository EmployeeRepositoryObject = new EmployeeRepository();

        //    DepartmentRepository departmentRepository = new DepartmentRepository();
        //    var department = departmentRepository.GetDepartments();
        //    ViewBag.Data1 = department;

        //    DesignationRepository designationRepository = new DesignationRepository();
        //    var Designation = designationRepository.GetDesignations();
        //    ViewBag.Data = Designation;
        //    EmployeeRepository st = new EmployeeRepository();
        //    return View(EmployeeRepositoryObject.GetEmployees().Find(asd => asd.ID == ID));

        //}

        //[HttpPost]
        //public IActionResult UpdateEmployee(int ID, EmployeeModel s1)
        //{
        //    DepartmentRepository departmentRepository = new DepartmentRepository();
        //    var department = departmentRepository.GetDepartments();
        //    ViewBag.Data1 = department;

        //    DesignationRepository designationRepository = new DesignationRepository();
        //    var Designation = designationRepository.GetDesignations();
        //    ViewBag.Data = Designation;

        //    EmployeeRepository EmployeeRepositoryObject = new EmployeeRepository();
        //    if (EmployeeRepositoryObject.UpdateEmployeeData(s1))
        //    {
        //        return RedirectToAction("GetEmployees");
        //    }
        //    else
        //    {
        //        return View();

        //    }
        //}

        //public IActionResult DeleteEmployee(int ID)
        //{
        //    EmployeeRepository EmployeeRepositoryObject = new EmployeeRepository();
        //    DepartmentRepository departmentRepository = new DepartmentRepository();
        //    var department = departmentRepository.GetDepartments();
        //    ViewBag.Data1 = department;

        //    DesignationRepository designationRepository = new DesignationRepository();
        //    var Designation = designationRepository.GetDesignations();
        //    ViewBag.Data = Designation;

        //    return View(EmployeeRepositoryObject.GetEmployees().Find(asd => asd.ID == ID));

        //}



        //[HttpPost]
        //public IActionResult DeleteEmployee(int ID, EmployeeRepository s1)
        //{
        //    EmployeeRepository EmployeeRepositoryObject = new EmployeeRepository();
        //    if (EmployeeRepositoryObject.DeleteEmployeeData(ID))
        //    {
        //        return RedirectToAction("GetEmployees");
        //    }
        //    else
        //    {
        //        return View();

        //    }
        //}


    }
}