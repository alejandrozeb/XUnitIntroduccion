using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

using MailValidatorProjectExampleXUnit;
namespace UnitTestingXUnitIntro.Tests
{
    public class MailValidatorShould
    {
        [Fact]
        public void ValidateValidEmails()
        {
            //Arrange
            var mailValidator = new MailValidator();
            string emailAddress = "Alejandroasd@gmail.com";
            //Act
            bool isValid = mailValidator.IsValidEmail(emailAddress);
            //Assert
            Assert.True(isValid);
        }
    }
}
