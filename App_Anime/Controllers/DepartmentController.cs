using App_Anime.model;
using App_Anime.Services;
using App_Anime.ViewModel;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NuGet.DependencyResolver;

namespace App_Anime.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly IDepartmentService _service;
        private readonly IMapper _mapper;

        public DepartmentController(IDepartmentService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var departments = _service.GetAll();
            var departmentVM = _mapper.Map<IEnumerable<DepartmentVM>>(departments);
            return Ok(departmentVM);
        }

        [HttpPost]
        public IActionResult Create(DepartmentVM dvm)
        {
            //var department = _mapper.Map<Department>(dvm);
            var department = new Department();
            department.Id = 0;
            department.Name = dvm.Name;
            department.Active = dvm.Active;
            _service.Create(department);
            var createdVm = _mapper.Map<Department>(department);
            return CreatedAtAction(nameof(GetById), new { id = createdVm.Id }, createdVm);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var department = _service.GetById(id);
            if (department == null) return NotFound();

            var vm = _mapper.Map<Department>(department);
            return Ok(vm);
        }

    }
}
