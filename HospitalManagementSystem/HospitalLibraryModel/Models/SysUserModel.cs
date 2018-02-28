namespace HospitalLibrary.Models
{
    /// <summary>
    /// Properties of our system admin (the guy that has access)
    /// </summary>
    public class SysUserModel
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
