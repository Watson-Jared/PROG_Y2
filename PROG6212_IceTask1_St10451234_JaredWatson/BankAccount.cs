using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;
using System.Xml.Linq;

namespace PROG6212_IceTask1_St10451234_JaredWatson
{
    public class BankAccount
    {
        public string accountHolder;
        public double accountBal = 0.0;

        public BankAccount(string aH, double aB)
        {
            accountHolder = aH;
            accountBal = aB;
        }

        public override string ToString()
        {
            return $"\nAccount Holder:{accountHolder} Balance:R{accountBal}";
        }

        public static BankAccount operator +(BankAccount a, BankAccount b)
        {
            string name;
            double bal = 0.0;
            name = ""+a.accountHolder+ b.accountHolder;
            bal = a.accountBal + b.accountBal;
            BankAccount result = new BankAccount(name, bal);
            return result;
        }

        public static bool operator >(BankAccount a, BankAccount b)
        {
            return a.accountBal > b.accountBal;
        }


        public static bool operator <(BankAccount a, BankAccount b)
        {
            return a.accountBal < b.accountBal;
        }

        public static bool operator true(BankAccount account)
        {
            return account.accountBal > 0;
        }

        public static bool operator false(BankAccount account)
        {
            return account.accountBal <= 0;
        }

        public static implicit operator string(BankAccount account)
        {
            return $"R{account.accountBal:F2}";
        }

        public static implicit operator BankAccount(double balance)
        {
            return new BankAccount("Unknown", balance);
        }
    }
}
