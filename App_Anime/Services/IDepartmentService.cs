using App_Anime.model;

namespace App_Anime.Services
{
    public interface IDepartmentService
    {
        IEnumerable<Department> GetAll();
        Department? GetById(int id);
        void Create(Department teacher);
        void Update(Department teacher);
        void Delete(int id);
    }
}
