using LearningCSharp.Entities;

Account acc = new(1001, "Alex", 100.0);

BusinessAccount bacc = new(1002, "Maria", 0.0, 500.0);

//UPCASTING CONVERSÃO DA SUBCLASSE PARA SUPERCLASSE

Account acc1 = bacc;
Account acc2 = new BusinessAccount(1003, "Bob", 200.0, 200.0);
Account acc3 = new SavingsAccount(1004, "Anna", 100.0, 0.01);

//DOWNCASTING CONVERSÃO DA SUPERCLASSE PARA SUBCLASSE

BusinessAccount acc4 = (BusinessAccount)acc2;

if (acc3 is BusinessAccount)
{
    BusinessAccount acc5 = (BusinessAccount)acc3;
}

//if (acc3 is SavingsAccount)
//{
//    SavingsAccount? acc5 = acc3 as SavingsAccount;
//    acc5.UpdateBalnce();
//    //Console.WriteLine("Update!");
//    acc5.WithDraw(50.0);
//    Console.WriteLine(acc5.Balance);
//}

Account account = new(1055, "Maria2", 500.0);
Account account2 = new SavingsAccount(1006, "Maria3", 500.0, 0.01);

account.WithDraw(10.0);
account2.WithDraw(10.0);

Console.WriteLine(account.Balance);
Console.WriteLine(account2.Balance);
