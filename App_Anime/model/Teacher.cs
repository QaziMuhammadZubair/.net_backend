namespace App_Anime.model
{
    public class Teacher
    {
        public int Id { get; set; } = 1;
        public string Name { get; set; } = "";
        public string Email { get; set; } = "";
        public string Img { get; set; } = "";
        // Foreign Key to Department
        public int DepartmentId { get; set; } = 0;
        public string CNIC { get; set; } = "";
        public string PhoneNumber { get; set; } = "";
        public string FatherName { get; set; } = "";
        public string Gender { get; set; } = "";
        public string Address { get; set; } = "";
        public string Qualification { get; set; } = "";
        public int Experience { get; set; } = 0;
        public DateTime DateOfBirth { get; set; } = DateTime.Now.Date;
        public DateTime DateOfJoining { get; set; } = DateTime.Now;
        // Navigation property for the one-to-many relationship.
        // This allows you to access the department of a teacher.
        public Department? Department { get; set; }
        public bool Active { get; set; }
    }
}
