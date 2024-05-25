namespace FreelanceBridge.API.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string FullName { get; set; }
        public bool IsAdmin { get; set; }
        public bool IsFinder { get; set; }
        public string Email { get; set; }
    }
}
