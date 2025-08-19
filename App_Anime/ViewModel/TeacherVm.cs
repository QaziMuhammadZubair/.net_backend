namespace App_Anime.ViewModel
{
    public class TeacherVm
    {
        public int Id { get; set; } = 0;
        public string Name { get; set; } = string.Empty;
        public string FatherName { get; set; } = string.Empty;
        public string CNIC { get; set; } = string.Empty;
        public DateTime DateOfBirth { get; set; } = DateTime.Now.Date;
        public string Gender { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string ProfilePicture { get; set; } = null;
        public string Qualification { get; set; } = string.Empty;
        public string Designation { get; set; } = string.Empty;
        public int DepartmentID { get; set; } = 0;
        public int ExperienceYears { get; set; } = 0;
        public DateTime JoiningDate { get; set; } = DateTime.Now;
        public bool Active { get; set; }
    }

}
