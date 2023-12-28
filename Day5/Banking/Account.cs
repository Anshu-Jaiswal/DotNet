namespace Banking;
using Notifications;
using Taxation;

public class Account
{
    public float Balance{get;set;}

    public event NotificationOperation underBalance;
    public event TaxOperation overBalance;

    public void Withdraw(float amount)
    {
        this.Balance-=amount; 
         if(this.Balance<=10000)
        {
           underBalance("Anshu","Mam bachat kare thoda...Account block ho gaya!!");
        }
        Console.WriteLine(this.Balance);
    }
    public void Deposit(float amount)
    {
         this.Balance+=amount;
        if(this.Balance>=250000)
        {
            overBalance(5000);
        }
        Console.WriteLine(this.Balance);   
    }
}