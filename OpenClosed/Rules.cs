using Shared;
using System;

namespace OpenClosed
{
    public abstract class Rule
    {
        public abstract void Validate(Account account);
    }

    public class UserNameLengthRule : Rule
    {
        public override void Validate(Account account)
        {
            if (account.UserName.Length < 5)
                throw new Exception("Invalid username");
        }
    }

    public class UsernameMustBeEmailRule: Rule
    {
        public override void Validate(Account account)
        {
            if (!account.UserName.Contains("@"))
                throw new Exception("Username is not an email");
        }
    }

    public class PasswordLengthRule : Rule
    {
        public override void Validate(Account account)
        {
            if (account.Password.Length < 5)
                throw new Exception("Password does not meet requirements");
        }
    }
}
