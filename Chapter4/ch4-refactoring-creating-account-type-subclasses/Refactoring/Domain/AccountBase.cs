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

      
    }
}
