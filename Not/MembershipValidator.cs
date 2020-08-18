using Shared;
using System;

namespace Not
{
    public class MembershipValidator
    {
        public void ValidateUser(Account account)
        {
            //validate username
            if (account.UserName.Length < 5)
                throw new Exception("invalid username");
            if (!account.UserName.Contains("@"))
                throw new Exception("not an email address");
            //validate password
            if (account.Password.Length < 5)
                throw new Exception("invalid username");

        }
    }
}
