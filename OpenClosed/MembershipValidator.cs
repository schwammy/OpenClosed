using Shared;
using System.Collections.Generic;

namespace OpenClosed
{
    public class MembershipValidator
    {
        private readonly List<Rule> _rules;
        public MembershipValidator(List<Rule> rules)
        {
            _rules = rules;
        }


        public void ValidateUser(Account account)
        {
            foreach (var rule in _rules)
            {
                rule.Validate(account);
            }
        }
    }

}
