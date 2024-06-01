
using System;

class BankAccount
{
    long accNo;
    decimal accBal;
    AccountType accType;
    //--.
    static long nextAccNo = 123;

    //--.
    public void Populate( decimal balance )
    {
        this.accNo = NextNumber();
        this.accBal = balance;
        this.accType = AccountType.Checking;
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
        return accBal;
    }

    //--.
    public bool Withdraw(decimal amount) 
    {
        //--.
        bool sufficientFunds = accBal >= amount;
        //--.
        if(sufficientFunds)
        {
            accBal -= amount;
        }
        //--.
        return sufficientFunds;
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