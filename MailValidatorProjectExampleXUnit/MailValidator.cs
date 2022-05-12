using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace MailValidatorProjectExampleXUnit
{
    public class MailValidator
    {
        public bool IsValidEmail(string emailAddress) {
            if (string.IsNullOrEmpty(emailAddress))
                throw new EmailNotProvidedException();

            Regex regex = new Regex(@"^[\w0-9._%+-]+\.[\w]{2,6}$");
            return regex.IsMatch(emailAddress);
        }

        public string IsSpam(string emailAddress)
        {
            if (string.IsNullOrEmpty(emailAddress))
                throw new EmailNotProvidedException();

            List<string> spammyDomains = new List<string>() { "spam.com", "dodgy.com", "donttrust.com"};

            if (spammyDomains.Contains("spam")) {
                return "Spam";
            }
            else {
                return "Imbox";
            }
        }
    }
}
