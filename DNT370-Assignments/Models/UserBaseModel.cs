namespace DNT370_Assignments.Models
{
    public abstract class UserBaseModel
    {
        public int Id { get; set; }
        public string? UserName { get; set; }
        public string Password { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }

    }
}
