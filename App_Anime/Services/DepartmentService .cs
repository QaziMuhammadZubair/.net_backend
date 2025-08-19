using App_Anime.model;
using App_Anime.Repositories;

namespace App_Anime.Services
{
    public class DepartmentService : IDepartmentService
    {
        private readonly IDepartmentRepository _repository;

        public DepartmentService(IDepartmentRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<Department> GetAll() => _repository.GetAll();

        public Department? GetById(int id) => _repository.GetById(id);

        public void Create(Department Department)
        {
            _repository.Add(Department);
            _repository.Save();
        }

        public void Update(Department Department)
        {
            _repository.Update(Department);
            _repository.Save();
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
            _repository.Save();
        }
    }
}
