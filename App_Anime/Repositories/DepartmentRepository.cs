using App_Anime.Data;
using App_Anime.model;

namespace App_Anime.Repositories
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly AppDbContext _context;
        public DepartmentRepository(AppDbContext context)
        {
            _context = context;

        }
        public IEnumerable<Department> GetAll()
        {
            return _context.Departments.ToList();
        }

        public Department? GetById(int Id)
        {
            return _context.Departments.Find(Id);
        }

        public void Add(Department department)
        {
            _context.Departments.Add(department);
        }
        public void Update(Department department)
        {
            _context.Departments.Update(department);
        }
        public void Delete(int id)
        {
            var existingDepartment = _context.Departments.Find(id);
            if (existingDepartment != null)
                _context.Departments.Remove(existingDepartment);

        }

        public void Save() => _context.SaveChanges();
    }
}
