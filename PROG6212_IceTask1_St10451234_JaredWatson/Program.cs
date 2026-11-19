using System;

namespace PROG6212_IceTask1_St10451234_JaredWatson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            BankAccount[] accounts = new BankAccount[]
            {
                new BankAccount("Alice", 1000.00),
                new BankAccount("Bob", 500.00),
                new BankAccount("Charlie", 0.00),
                new BankAccount("Diana", 1500.00),
                new BankAccount("Eve", -50.00)
            };

            
            // DISPLAY ALL ACCOUNTS           
            Console.WriteLine("\nALL ACCOUNTS");
           
            foreach (BankAccount account in accounts)
            {
                Console.WriteLine(account.ToString());
            }

            // OPERATOR OVERLOADING              
            // --- > and < operators ---
            Console.WriteLine("\n--- Comparison Operators (> and <) ---");
            Console.WriteLine($"Is Alice's balance greater than Bob's? {accounts[0] > accounts[1]}");
            Console.WriteLine($"Is Alice's balance less than Bob's?    {accounts[0] < accounts[1]}");

            // --- true / false operators ---
            Console.WriteLine("\n--- true/false Operators ---");
            BankAccount alice = accounts[0];
            BankAccount charlie = accounts[2];

            if (alice)
                Console.WriteLine($"{alice.accountHolder} has money.");
            else
                Console.WriteLine($"{alice.accountHolder} does not have money.");

            if (charlie)
                Console.WriteLine($"{charlie.accountHolder} has money.");
            else
                Console.WriteLine($"{charlie.accountHolder} does not have money.");

            // --- + operator ---
            Console.WriteLine("\n--- Addition Operator (+) ---");
            BankAccount combined = accounts[0] + accounts[1];
            Console.WriteLine("Combining Alice and Bob's accounts:");
            Console.WriteLine(combined.ToString());

            // --- Implicit conversion: BankAccount -> string ---
            Console.WriteLine("\n--- Implicit Conversion: BankAccount -> string ---");
            string aliceBalanceString = alice;
            Console.WriteLine($"Alice's balance as a string: {aliceBalanceString}");

            // --- Implicit conversion: double -> BankAccount ---
            Console.WriteLine("\n--- Implicit Conversion: double -> BankAccount ---");
            BankAccount quickAccount = 750.00;
            Console.WriteLine("Quick account created from a double value:");
            Console.WriteLine(quickAccount.ToString());

           
            // EXTENSION METHODS DEMONSTRATION   
            Console.WriteLine("\nEXTENSION METHODS");
           

            // --- TotalBalance ---
            Console.WriteLine("--- TotalBalance ---");
            Console.WriteLine($"Total balance of all accounts: R{accounts.TotalBalance():F2}");

            // --- Richest ---
            Console.WriteLine("\n--- Richest ---");
            BankAccount richest = accounts.Richest();
            Console.WriteLine($"Richest account holder: {richest.accountHolder} with R{richest.accountBal:F2}");

            // --- WithMoney ---
            Console.WriteLine("\n--- WithMoney ---");
            Console.WriteLine("Accounts with a positive balance:");
            BankAccount[] withMoney = accounts.WithMoney();
            foreach (BankAccount account in withMoney)
            {
                Console.WriteLine(account.ToString());
            }

            // --- GiveBonus ---
            Console.WriteLine("\n--- GiveBonus ---");
            Console.WriteLine("Applying a R100.00 bonus to every account...");
            accounts.GiveBonus(100.00);
            Console.WriteLine("Updated accounts after bonus:");
            foreach (BankAccount account in accounts)
            {
                Console.WriteLine(account.ToString());
            }

            // --- AverageBalance ---
            Console.WriteLine("\n--- AverageBalance ---");
            Console.WriteLine($"Average balance across all accounts: R{accounts.AverageBalance():F2}");

            // --- FilterByBalance ---
            Console.WriteLine("\n--- FilterByBalance ---");
            Console.WriteLine("Accounts with a balance greater than R500.00:");
            BankAccount[] filtered = accounts.FilterByBalance(500.00);
            foreach (BankAccount account in filtered)
            {
                Console.WriteLine(account.ToString());
            }

            Console.WriteLine("\nEND");          
            Console.ReadKey();
        }
    }
}