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

        public async Task<Teacher> GetById(int id)
        {
            var findData = await _repository.GetById(id);
            return findData;
        }

        public void Create(Teacher teacher)
        {
            _repository.Add(teacher);
            _repository.Save();
        }

        public async Task Update(Teacher teacher)

        {
            await _repository.Update(teacher);
           await _repository.Save();
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
            _repository.Save();
        }
    }
}
