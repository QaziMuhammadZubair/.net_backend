using App_Anime.Data;
using App_Anime.model;
using System;

namespace App_Anime.Repositories
{
    public class TeacherRepository: ITeacherRepository
    {
        private readonly AppDbContext _context;

        public TeacherRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Teacher> GetAll() => _context.Teachers.ToList();

        public Teacher? GetById(int id) => _context.Teachers.Find(id);

        public void Add(Teacher teacher)
        {
            _context.Teachers.Add(teacher);
        }

        public void Update(Teacher teacher)
        {
            _context.Teachers.Update(teacher);
        }

        public void Delete(int id)
        {
            var teacher = _context.Teachers.Find(id);
            if (teacher != null)
            {
                _context.Teachers.Remove(teacher);
            }
        }

        public void Save() => _context.SaveChanges();
    }
}
