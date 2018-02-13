namespace FileDownloader
{
    /// <summary>
    /// Model for user credentials that are used to connect to server
    /// </summary>
    public class UserModel
    {
        /// <summary>
        /// Returns the user name for access to the server
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        public string GetUserName(string userName)
        {
            return userName;
        }

        /// <summary>
        /// Returns the password for access to the server
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        public string GetPassword (string password)
        {
            return password;
        }
    }
}
