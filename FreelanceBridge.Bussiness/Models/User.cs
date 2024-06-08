namespace FreelanceBridge.Bussiness.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string UserType { get; set; }
    }

    public class UserReg
    {
        public string Password { get; set; }

        public string Email { get; set; }
        public string Username { get; set; }
        public string UserType { get; set; }
    }
}
