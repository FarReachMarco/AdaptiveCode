using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public abstract class AccountBase
    {
        protected decimal Balance
        {
            get;
            private set;
        }

        private int RewardPoints
        {
            get; set;
        }

        public void AddTransaction(decimal amount)
        {
            RewardPoints += CalculateRewardPoints(amount);
            Balance += amount;
        }

        protected abstract int CalculateRewardPoints(decimal amount);

        public static AccountBase CreateAccount(AccountType accountType)
        {
            AccountBase accountBase = null;
            switch (accountType)
            {
                case AccountType.Silver:
                    accountBase = new SilverAccount();
                    break;
                case AccountType.Gold:
                    accountBase = new GoldAccount();
                    break;
                case AccountType.Platinum:
                    accountBase = new PlatinumAccount();
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(accountType), accountType, null);
            }
            return accountBase;

        }
    }
}
