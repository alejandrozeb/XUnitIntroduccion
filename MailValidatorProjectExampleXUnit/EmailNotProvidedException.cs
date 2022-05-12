using System;
using System.Runtime.Serialization;

namespace MailValidatorProjectExampleXUnit
{
    [Serializable]
    internal class EmailNotProvidedException : Exception
    {
        public override string Message => "Email can't be empty";
    }
}