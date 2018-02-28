namespace HospitalLibrary.Models

{
    public class EmployeeModel
    {
        //Employee properties
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string HomeAddress { get; set; }
        public string EmailAddress { get; set; }
        public string CellNumber { get; set; }
        public string Position { get; set; }

        // Output string from lookup
        public string FullEmployeeInfo
        {
            get
            {
                return $"(ID: {Id}) {FirstName} {LastName}, {HomeAddress}, ({EmailAddress}), {CellNumber}, ({Position})";
            }
        }
    }
}
