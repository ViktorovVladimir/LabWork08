
using System;
using System.Collections;

class BankAccount
{
    long accNo;
    decimal accBal;
    AccountType accType;
    Queue tranQueue = new Queue();

    //--.
    static long nextAccNo = 123;

    //--.


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

}