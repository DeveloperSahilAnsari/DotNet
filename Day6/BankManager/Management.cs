namespace manager;
public delegate void Operation(double amt);

public class StuffManager{
// public double Bal{get;set;}

public void BlockAcc(double amt){
    Console.WriteLine("blocking the account due to insufficient balance");
}
public void EmailToAcc(double amt){
    Console.WriteLine("Email:your account is depricated due to insufficient balance");
}
public void SmsToAcc(double amt){
    Console.WriteLine("SMS:your account is depricated due to insufficient balance");
}


}




