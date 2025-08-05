using App_Anime.model;

namespace App_Anime.Repositories
{
    public interface ITeacherRepository
    {
        IEnumerable<Teacher> GetAll();
        Teacher? GetById(int id);
        void Add(Teacher teacher);
        void Update(Teacher teacher);
        void Delete(int id);
        void Save();
    }
}
