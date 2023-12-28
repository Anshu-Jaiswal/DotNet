using Banking;
using System.Collections.Generic;

Account obj1 = new Account(150000);
Account obj2 = new Account(100000);

// obj.getBalance();
// obj.setBalance(50000);

// obj.withDraw(30000);
// obj.withDraw(30000);
// obj.deposit(10000);
// obj.deposit(20000);
// obj.checkBalance();

List<Account> ls = new List<Account>();

ls.Add(obj1);
ls.Add(obj2);

foreach(Account acc in ls)
{
    float result = acc.getBalance();
    Console.WriteLine("Current Balance{0}",result);
}