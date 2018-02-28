namespace HospitalLibrary.Models
{
    //Maps the result from database lookup
    public class SysUserModel
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
