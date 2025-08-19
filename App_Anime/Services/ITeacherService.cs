using App_Anime.model;

namespace App_Anime.Services
{
    public interface ITeacherService
    {
        IEnumerable<Teacher> GetAll();
        Task<Teacher> GetById(int id);
        void Create(Teacher teacher);
        Task Update(Teacher teacher);
        void Delete(int id);
    }
}
