namespace EmpeEmp;
public class Employee{
public string Firstname{get; set;}
public string Lastname{get; set;}
public string Email{get; set;}
public string Contact{get; set;}
public string Password{get; set;}

public Employee(string Firstname,string Lastname,string Email,string Contact,string Password){

    this.Firstname=Firstname;
    this.Lastname=Lastname;
    this.Email=Email;
    this.Contact=Contact;
    this.Password=Password;

}




}