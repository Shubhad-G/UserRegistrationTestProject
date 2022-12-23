using UserRegistrationTestProject;

namespace TestProject
{
    public class Tests
    {
       
        [Test]
        public void TestFirstName()
        {
            bool expected = true;
            Patterns patterns = new Patterns();
            string actual = "SHRIHARI";
            bool isMatchActual= patterns.ValidateFirstName(actual);
            patterns.Validate(isMatchActual);
            Assert.AreEqual(expected, isMatchActual);
        }

        [Test]
        public void TestLastName()
        {
            bool expected = true;
            Patterns patterns = new Patterns();
            string actual = "HEGDE";
            bool isMatchActual = patterns.ValidateFirstName(actual);
            patterns.Validate(isMatchActual);
            Assert.AreEqual(expected, isMatchActual);
        }

        [Test]

        public void TestEmail()
        {
            bool expected = true;
            Patterns patterns = new Patterns();
            string actual = "shubhadg@gmail.com";
            bool isMatchActual = patterns.ValidateEmail(actual);
            patterns.Validate(isMatchActual);
            Assert.AreEqual(expected, isMatchActual);
        }

        [Test]
        public void TestPhoneNumber()
        {
            bool expected = true;
            Patterns patterns = new Patterns();
            string actual = "9877799999";
            bool isMatchActual = patterns.ValidatePhone(actual);
            patterns.Validate(isMatchActual);
            Assert.AreEqual(expected, isMatchActual);
        }
    }
}