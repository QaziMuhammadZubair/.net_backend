using App_Anime.model;
using App_Anime.Services;
using App_Anime.ViewModel;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace App_Anime.Controllers
{
    // Controllers/TeacherController.cs
    [ApiController]
    [Route("api/[controller]")]
    public class TeacherController : ControllerBase
    {
        private readonly ITeacherService _service;
        private readonly IDepartmentService _departmentService;
        private readonly IMapper _mapper;

        public TeacherController(ITeacherService service, IMapper mapper, IDepartmentService departmentService)
        {
            _service = service;
            _mapper = mapper;
            _departmentService = departmentService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var teachers = _service.GetAll();
            var teacherVMs = _mapper.Map<IEnumerable<TeacherVm>>(teachers);
            return Ok(teacherVMs);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var teacher = _service.GetById(id);
            if (teacher == null) return NotFound();

            var vm = _mapper.Map<TeacherVm>(teacher);
            return Ok(vm);
        }

        [HttpPost]
        public IActionResult Create([FromBody] TeacherVm vm)
        {
            if (_departmentService.GetAll().All(d => d.Id != vm.DepartmentID))
            {
                return BadRequest("Invalid Department ID");
            }
            var teacher = _mapper.Map<Teacher>(vm);
            _service.Create(teacher);
            var createdVm = _mapper.Map<TeacherVm>(teacher);
            return CreatedAtAction(nameof(GetById), new { id = createdVm.Id }, createdVm);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] TeacherVm vm)
        {
            if (id != vm.Id) return BadRequest();

            var existing = await _service.GetById(id);
            if (existing == null) return NotFound();


            //existing.Name = vm.Name;
            var updatedTeacher = _mapper.Map<Teacher>(vm);
            await _service.Update(updatedTeacher);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var teacher = _service.GetById(id);
            if (teacher == null) return NotFound();

            _service.Delete(id);
            return NoContent();
        }
    }

}
