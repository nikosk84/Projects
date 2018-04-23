namespace SQLConnector
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        /// <summary>
        /// Output view
        /// </summary>
        public string FullPersonInfo
        {
            get
            {
                return $"{FirstName}, {LastName}";
            }
        }
    }
}
