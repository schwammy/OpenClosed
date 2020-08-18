using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
