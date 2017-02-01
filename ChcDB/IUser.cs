namespace ChcDB
{
    public interface IUser
    {
        int UserID { get; set; }
        string Username { get; set; }
        string Password { get; set; }
        int RoleID { get; set; }
    }
}