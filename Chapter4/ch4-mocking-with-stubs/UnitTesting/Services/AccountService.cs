using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ServiceInterfaces;
using RepositoryInterfaces;

namespace Services
{
    public class AccountService : IAccountService
    {
        public AccountService(IAccountRepository repository)
        {
            if (repository == null)
                throw new ArgumentNullException(nameof(repository), "Must supply a valida Account Repository");
            this._repository = repository;
        }

        public void AddTransactionToAccount(string uniqueAccountName, decimal transactionAmount)
        {
            _repository.GetByName(uniqueAccountName)?.AddTransaction(transactionAmount);
        }

        private readonly IAccountRepository _repository;
    }
}
