using Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace UnitTestProject
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void IsDbConnected_true()
        {
            string con = "Host=localhost:5432; Username=postgres; Password=25481; Database=UserDatabase";
            bool expected = true;
            bool actual = CheckClass.IsDBConnected(con);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsDbConnected_false()
        {
            string con = "Host=localhost:5432; Username=postgres; Password=12345; Database=UserDatabase";
            bool expected = false;
            bool actual = CheckClass.IsDBConnected(con);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsEmailCorrect_true()
        {
            string email = "ivanov@mail.com";
            bool expected = true;
            bool actual = CheckClass.IsEmailCorrect(email);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsEmailCorrect_false()
        {
            string email = "ivanov_mail.com";
            bool expected = false;
            bool actual = CheckClass.IsEmailCorrect(email);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsPhoneNumberCorrect_true()
        {
            string number = "8-952-123-78-98";
            bool expected = true;
            bool actual = CheckClass.IsPhoneNumberCorrect(number);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsPhoneNumberCorrect_false()
        {
            string number = "+7 (950) 987 12 23";
            bool expected = false;
            bool actual = CheckClass.IsPhoneNumberCorrect(number);
            Assert.AreEqual(expected, actual);
        }
    }
}
