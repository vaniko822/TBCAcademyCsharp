using Task2;

BankAccount p1_bankaccount = new BankAccount("034124512", "Vano Kukutchanashvili", 3000, "GEL");
BankAccount p2_bankaccount = new BankAccount("452123673", "Nino Mgaloblishvili", 2000, "GEL");

p1_bankaccount.BalanceCheck();

p1_bankaccount.Deposit(1000);
Console.WriteLine("Tanxis shetanis transzaqcia warmatebit shesrulda!");

p1_bankaccount.BalanceCheck();

p1_bankaccount.Withdraw(2000);
Console.WriteLine("Tanxis gatanis transzaqcia warmatebit shesrulda!");

p1_bankaccount.BalanceCheck();

p1_bankaccount.TransferFunds(p2_bankaccount, 1500);

p2_bankaccount.BalanceCheck();
p1_bankaccount.BalanceCheck();