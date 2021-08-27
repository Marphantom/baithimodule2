using System;
using System.Collections.Generic;

namespace cau3
{
    public class Bank
    {
        private AccountList accountList = new AccountList();
        int count = 1;

        public void CreatAccount()
        {
            Account account = new Account();
            account.AccountId = count;
            Console.Write("Enter first name: ");
            account.Fristname = Console.ReadLine();
            Console.Write("Enter gender: ");
            account.Lastname = Console.ReadLine();
            accountList.accounts.Add(account);
            count++;
        }

        public void ShowData()
        {
            foreach(Account ac in accountList.accounts)
            {
                Console.WriteLine(ac.ShowInfo());
            }
        }
    }
}