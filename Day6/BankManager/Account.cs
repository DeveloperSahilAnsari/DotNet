namespace Banking;
using manager;

public class Account{
       public event Operation lessBalance;

    public double Balance{get;set;}

    public Account(double amount){
        this.Balance=amount;
    }
 
    public void Deposit(double amount){
        this.Balance+=amount;
    }
    public void Withdraw(double amount){
        this.Balance-=amount;
    }

    public override string ToString()
    {
        return base.ToString()+"Current Balance ="+ this.Balance;
    }
    
     public void DepricateAcc(){
        if(this.Balance<=5000){
            //raise an event   
            lessBalance(this.Balance);    
        }
    }

}


