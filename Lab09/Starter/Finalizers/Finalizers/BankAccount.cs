
using System;
using System.Collections;

sealed class BankAccount : IDisposable
{
    long accNo;
    decimal accBal;
    AccountType accType;
    Queue tranQueue = new Queue();

    //--.
    static long nextAccNo = 123;

    //--.
    bool disposed = false;

    //--.
    public BankAccount()
    {
        this.accNo = NextNumber();
        this.accType = AccountType.Checking;
        this.accBal = 0;
    }

    //--.
    public BankAccount(AccountType aType)
    {
        this.accNo = NextNumber();
        this.accType = aType;
        this.accBal = 0;

    }
    
    //--.
    public BankAccount(decimal aBal)
    {
        this.accNo = NextNumber();
        this.accType = AccountType.Checking;
        this.accBal = aBal;
    }
    
    //--.
    public BankAccount(AccountType aType, decimal aBal)
    {
        this.accNo = NextNumber();
        this.accType = aType;
        this.accBal = aBal;
    }



    //--.
    public long Number()
    {
        return accNo;
    }

    //--.
    public decimal Ballance()
    {
        return accBal;
    }

    //--.
    public string Type()
    {
        return accType.ToString();
    }

    //--.
    static long NextNumber()
    {
        return nextAccNo++;
    }

    //--.
    public decimal Deposit(decimal amount ) 
    {
        accBal += amount;
        BankTransaction tran = new BankTransaction(amount);
        tranQueue.Enqueue(tran);
        return accBal;
    }

    //--.
    public bool Withdraw(decimal amount) 
    {
        //--.
        bool sufficientFunds = accBal >= amount;
        //--.
        if( sufficientFunds )
        {
            //--.
            accBal -= amount;
            //--.
            BankTransaction tran = new BankTransaction(-amount);
            tranQueue.Enqueue(tran);
        }
        //--.
        return sufficientFunds;
    }

    //--.
    public Queue Transactions()
    {
        return tranQueue;    
    }   

    //--.
    public void TransferFrom(BankAccount accFrom, decimal amount) 
    { 
        //--.
        if( accFrom.Withdraw(amount) )
        {
            this.Deposit(amount);
        }
    }

    //--.
    public void Dispose()
    {

        if (!disposed)
        {
            StreamWriter swFile = File.AppendText("Transactions.Dat");
            swFile.WriteLine("Account number is {0}", accNo);
            swFile.WriteLine("Account balance is {0}", accBal);
            swFile.WriteLine("Account type is {0}", accType);
            swFile.WriteLine("Transactions: ");
            //--.
            foreach (BankTransaction tran in tranQueue)
            {
                swFile.WriteLine("Date/Time: {0}\tAmount: {1}", tran.funcWhen(), tran.funcAmount());
            }
            swFile.Close();
            disposed = true;
            GC.SuppressFinalize(this);
        }

    }

    //--.
    ~BankAccount()
    {
        Dispose();
    }



}