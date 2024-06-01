using System;

class BankTransaction
{
    readonly decimal amount;
    readonly DateTime when;

    //--.
    public BankTransaction(decimal tranAmount)
    {
        amount = tranAmount;
        when = DateTime.Now;
    }

    //--.
    public decimal funcAmount()
    {
        return amount;
    }

    //--.
    public DateTime funcWhen() 
    { 
        return when;
    }

}
