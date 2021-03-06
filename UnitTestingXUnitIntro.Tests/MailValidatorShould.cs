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

        [Fact]
        public void InvalidateInvalidEmails() {
            //Arrange
            var mailValidator = new MailValidator();
            string emailAddress = "Alejandroasd@gmail";
            //Act
            bool isValid = mailValidator.IsValidEmail(emailAddress);
            //Assert
            Assert.False(isValid);
        }

        //dos test distintos con diferentes tests cases
        [Theory]
        [InlineData("Alejandroasd@gmail", false)]
        [InlineData("Alejandroasd@gmail.com", true)]
        public void ValidateEmail2(string emailAddress, bool expected) {
            //arrange
            var mailValidator = new MailValidator();
            //act
            bool isValid = mailValidator.IsValidEmail(emailAddress);
            //Assert
            Assert.Equal(isValid, expected);
        }

        [Theory]
        [InlineData("Alejandroasd@gmail.com", "Imbox")]
        [InlineData("Alejandroasd@spam.com", "Spam")]
        public void IdentifySpam(string emailAddress, string expected)
        {
            //arrange
            var mailValidator = new MailValidator();
            //act
            string result = mailValidator.IsSpam(emailAddress);
            //Assert
            Assert.Equal(result, expected);
        }
        [Fact]
        public void RaiseErrorWhenEmailIsEmpty() {
            var mailValidator = new MailValidator();

            Assert.Throws<EmailNotProvidedException>(() => mailValidator.IsValidEmail(null));
        }

    }
}
