using LearningCSharp.Entities;

Account account = new(1055, "Maria2", 500.0);
Account account2 = new SavingsAccount(1006, "Maria3", 500.0, 0.01);

account.WithDraw(10.0);

//Chamando WithDraw(Saque) o compilador não sabe que tipo esta sendo chamado.
if (account2 is SavingsAccount)
{
    account2.WithDraw(10.0);
}

Console.WriteLine(account.Balance);
Console.WriteLine(account2.Balance);
