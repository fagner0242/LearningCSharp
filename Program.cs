using LearningCSharp.Entities;

BusinessAccount account = new BusinessAccount(1802, "Bob", 100.0, 500.0);

Console.WriteLine(account.Balance);

account.Balance = 50.0;