using App_Anime.model;

namespace App_Anime.Repositories
{
    public interface IDepartmentRepository
    {
        IEnumerable<Department> GetAll();
        Department? GetById(int Id);
        void Add(Department department);
        void Update(Department department);
        void Delete(int Id);
        void Save();
    }
}
