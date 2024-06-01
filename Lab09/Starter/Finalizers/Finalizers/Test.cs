using System;

namespace FinalizersNameSpace
{
    class Test
    {
        //--.
        static void Main()
        {
            using (BankAccount acc1 = new BankAccount())
            {
                acc1.Deposit(1000);
                acc1.Deposit(700);
                acc1.Deposit(400);
                acc1.Deposit(200);

                //--.
                Write(acc1);

                acc1.Withdraw(49);
                acc1.Withdraw(48);
                acc1.Withdraw(47);
                acc1.Withdraw(46);
                //--.
                Write(acc1);
            }
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
