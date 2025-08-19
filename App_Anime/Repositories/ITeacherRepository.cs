using App_Anime.model;

namespace App_Anime.Repositories
{
    public interface ITeacherRepository
    {
        IEnumerable<Teacher> GetAll();
        Task<Teacher> GetById(int id);
        void Add(Teacher teacher);
        Task Update(Teacher teacher);
        void Delete(int id);
        Task Save();
    }
}
