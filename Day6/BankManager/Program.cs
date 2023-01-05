using Banking;
using manager;

//Account acct=new Account(5000);
//Console.WriteLine("enter amount to deposite");
//double amount=double.Parse(Console.ReadLine());
//Account acct1=new Account(amount);
//acct1.Deposit(amount);

StuffManager m1=new StuffManager();

Operation Delegate1=new Operation(m1.BlockAcc);
Operation Delegate2=new Operation(m1.EmailToAcc);
Operation Delegate3=new Operation(m1.SmsToAcc);

Account  acct1=new Account(6000);
//Event Registration
//Event Configuration

acct1.lessBalance+=Delegate1;
//acct1.lessBalance+=Delegate2;
Console.WriteLine("Enter Amount to be deposited");
double amount=double.Parse(Console.ReadLine());
acct1.Deposit(amount);

Console.WriteLine(acct1);
//performing action
acct1.DepricateAcc();
Console.WriteLine("After Tax processing");
Console.WriteLine(acct1);