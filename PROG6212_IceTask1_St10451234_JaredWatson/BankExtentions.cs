using System;
using System.Collections.Generic;
using System.Text;

using System;

namespace PROG6212_IceTask1_St10451234_JaredWatson
{
    public static class BankExtensions
    {
        // 1. TotalBalance — sums the balances of every account in the array
        public static double TotalBalance(this BankAccount[] accounts)
        {
            double total = 0.0;
            foreach (BankAccount account in accounts)
            {
                total += account.accountBal;
            }
            return total;
        }

        // 2. Richest — returns the account with the highest balance
        public static BankAccount Richest(this BankAccount[] accounts)
        {
            BankAccount richest = accounts[0];
            foreach (BankAccount account in accounts)
            {
                if (account.accountBal > richest.accountBal)
                {
                    richest = account;
                }
            }
            return richest;
        }

        // 3. WithMoney — returns only accounts with a positive balance
        public static BankAccount[] WithMoney(this BankAccount[] accounts)
        {
            int count = 0;
            foreach (BankAccount account in accounts)
            {
                if (account.accountBal > 0)
                {
                    count++;
                }
            }

            BankAccount[] result = new BankAccount[count];
            int index = 0;
            foreach (BankAccount account in accounts)
            {
                if (account.accountBal > 0)
                {
                    result[index] = account;
                    index++;
                }
            }

            return result;
        }

        // 4. GiveBonus — adds a bonus amount to every account's balance
        public static void GiveBonus(this BankAccount[] accounts, double amount)
        {
            foreach (BankAccount account in accounts)
            {
                account.accountBal += amount;
            }
        }

        // 5. AverageBalance — average balance across all accounts
        public static double AverageBalance(this BankAccount[] accounts)
        {
            double total = accounts.TotalBalance();
            return total / accounts.Length;
        }

        // 6. FilterByBalance — returns only accounts with balance greater than minBalance
        public static BankAccount[] FilterByBalance(this BankAccount[] accounts, double minBalance)
        {
            int count = 0;
            foreach (BankAccount account in accounts)
            {
                if (account.accountBal > minBalance)
                {
                    count++;
                }
            }

            BankAccount[] result = new BankAccount[count];
            int index = 0;
            foreach (BankAccount account in accounts)
            {
                if (account.accountBal > minBalance)
                {
                    result[index] = account;
                    index++;
                }
            }

            return result;
        }
    }
}
