using Npgsql;
using System;
using System.Text.RegularExpressions;

namespace Library
{
    public class CheckClass
    {

        public static bool IsDBConnected(string connectionString)
        {
            var connection = new NpgsqlConnection(connectionString);
            try
            {
                connection.Open();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }


        public static bool IsEmailCorrect(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;
            
            return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }

        public static bool IsPhoneNumberCorrect(string number)
        {
            if (string.IsNullOrWhiteSpace(number))
                return false;

            return Regex.IsMatch(number, @"^8-9[0-9]{2}-[0-9]{3}-[0-9]{2}-[0-9]{2}$");
        }
    }
}
