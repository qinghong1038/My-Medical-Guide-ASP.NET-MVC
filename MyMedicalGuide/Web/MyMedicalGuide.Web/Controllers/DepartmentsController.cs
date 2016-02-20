﻿namespace MyMedicalGuide.Web.Controllers
{
    using System.Collections.Generic;
    using System.Web.Mvc;
    using MyMedicalGuide.Services.Contracts;
    using MyMedicalGuide.Web.Models.Departments;

    public class DepartmentsController : BaseController
    {
        private readonly IDepartmentsService departmentsService;

        public DepartmentsController(IDepartmentsService service)
        {
            this.departmentsService = service;
        }

        [HttpGet]
        [OutputCache(Duration = 60)]
        public ActionResult All()
        {
            var departments = departmentsService.GetAll();
            var viewModelDepartments = this.Mapper.Map<IEnumerable<DepartmentViewModel>>(departments);
            return View(viewModelDepartments);
        }

        [HttpGet]
        public ActionResult Details(int id)
        {
            var department = departmentsService.GetById(id);
            var viewModelDepartmentDetails = this.Mapper.Map<DepartmentViewModel>(department);
            return View(viewModelDepartmentDetails);
        }
    }
}