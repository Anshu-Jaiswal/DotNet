namespace Banking;

public class Account
{
    private float balance;

    public Account()
    {
        this.balance = 10000;
    }

    public Account(float balance)
    {
        this.balance = balance;
    }

    public float getBalance()
    {
        return balance;
    }

    public void setBalance(float balance)
    {
        this.balance = balance;
    }

    ~Account()
    {
        //this is a destructor
        Console.WriteLine("Destructor called");
    }

    public void withDraw(float amount){
        if(balance<amount || balance<1000){
         Console.WriteLine("minimum balance");
        }else{
        balance-=amount;
        Console.WriteLine("Withdraw successful...");
        Console.WriteLine("Balance : "+this.balance);
       }
    }

    public void deposit(float amount)
    {
        this.balance+=amount;
        Console.WriteLine("Deposit successful...");
        Console.WriteLine("Balance : "+this.balance);
    }

    public void checkBalance()
    {
        Console.WriteLine("Balance : "+this.balance);
    }
}
 