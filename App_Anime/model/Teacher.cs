namespace App_Anime.model
{
    public class Teacher
    {
        public int Id { get; set; } = 1;
        public string Name { get; set; } = "";
        public string Email { get; set; } = "";
        public string Img { get; set; } = "";
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
        public bool Active { get; set; }
    }
}
