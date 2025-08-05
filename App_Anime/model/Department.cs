namespace App_Anime.model
{
    public class Department
    {
        public int Id { get; set; }= 0;
        public string Name { get; set; } = string.Empty;
        public bool Active { get; set; } = true;
        // Navigation property for related teachers
        public ICollection<Teacher> Teachers { get; set; } = new List<Teacher>();
    }
}
