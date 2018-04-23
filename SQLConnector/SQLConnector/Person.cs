namespace SQLConnector
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        /// <summary>
        /// Output string from search result
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
