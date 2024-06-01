using System;

namespace ConstructorsBTNameSpace
{
    class Test
    {
        //--.
        static void Main()
        {
            BankAccount acc1, acc2, acc3, acc4;

            acc1 = new BankAccount();
            acc2 = new BankAccount(AccountType.Deposit);
            acc3 = new BankAccount(100);
            acc4 = new BankAccount(AccountType.Deposit, 500);

            acc1.Deposit(1000);
            acc2.Deposit(700);
            acc3.Deposit(400);
            acc4.Deposit(200);

            //--.
            Write(acc1);
            Write(acc2);
            Write(acc3);
            Write(acc4);

            acc1.Withdraw(49);
            acc2.Withdraw(48);
            acc3.Withdraw(47);
            acc4.Withdraw(46);

            //--.
            Write(acc1);
            Write(acc2);
            Write(acc3);
            Write(acc4);
        }

        //--.
        static void Write(BankAccount acc) 
        {
            Console.WriteLine("Account number is {0}", acc.Number() );
            Console.WriteLine("Account ballance is {0}", acc.Ballance());
            Console.WriteLine("Account type is {0}", acc.Type());

            Console.WriteLine("Transactions : " );
            foreach( BankTransaction tran in acc.Transactions() )
            {
                Console.WriteLine("Date/Time: {0}\tAmount: {1} ", tran.funcWhen(), tran.funcAmount());
            }
            Console.WriteLine();

        }
    }
}
