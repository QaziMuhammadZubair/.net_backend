using App_Anime.Data;
using App_Anime.model;
using Microsoft.AspNetCore.Server.IIS;
using System;

namespace App_Anime.Repositories
{
    public class TeacherRepository : ITeacherRepository
    {
        private readonly AppDbContext _context;

        public TeacherRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Teacher> GetAll() => _context.Teachers.ToList();

        public async Task<Teacher> GetById(int id)
        {
            var findData = await _context.Teachers.FindAsync(id);
            return findData ?? throw new Exception();
        }

        public void Add(Teacher teacher)
        {
            _context.Teachers.Add(teacher);
        }

        public async Task Update(Teacher teacher) // Updated return type to match the interface
        {
            var existingTeacher = await _context.Teachers.FindAsync(teacher.Id);
            if (existingTeacher == null)
            {
                throw new Exception("Teacher not found");
            }

            _context.Entry(existingTeacher).CurrentValues.SetValues(teacher);
            await _context.SaveChangesAsync(); // Ensure changes are saved
        }

        public void Delete(int id)
        {
            var teacher = _context.Teachers.Find(id);
            if (teacher != null)
            {
                _context.Teachers.Remove(teacher);
            }
        }

        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }
    }
}
