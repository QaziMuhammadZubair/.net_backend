using App_Anime.model;
using App_Anime.Repositories;

namespace App_Anime.Services
{
    public class TeacherService : ITeacherService
    {
        private readonly ITeacherRepository _repository;

        public TeacherService(ITeacherRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<Teacher> GetAll() => _repository.GetAll();

        public Teacher? GetById(int id) => _repository.GetById(id);

        public void Create(Teacher teacher)
        {
            _repository.Add(teacher);
            _repository.Save();
        }

        public void Update(Teacher teacher)
        {
            _repository.Update(teacher);
            _repository.Save();
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
            _repository.Save();
        }
    }
}
