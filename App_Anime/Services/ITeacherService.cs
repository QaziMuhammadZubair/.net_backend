using App_Anime.model;

namespace App_Anime.Services
{
    public interface ITeacherService
    {
        IEnumerable<Teacher> GetAll();
        Teacher? GetById(int id);
        void Create(Teacher teacher);
        void Update(Teacher teacher);
        void Delete(int id);
    }
}
