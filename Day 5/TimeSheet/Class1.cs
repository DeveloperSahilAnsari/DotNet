namespace TimeSheet;
public class BusinessEntity
{
int Id{get;set;}
public string FirstName{get;set;}
public string LastName{get;set;}
public int HoursWorked{get;set;}
public int TotalDayWorked{get;set;}

BusinessEntity(){
    int count=100
    this.Id=count;
    count++; 
}
BusinessEntity:Base(string Fname,string Lname,int HrsWrk,int TotlDays){
    this.FirstName=Fname;
    this.LastName=Lname;
    this.HoursWorked=HrsWrk;
    this.TotalDayWorked=TotlDays;
}


}
/*
6.Use Serailizable attribute for business entity class.
7.Create objects of business entity class and add inside List<businessEntity> in Program.cs of Console Application
8.Use appropriate namespaces for Json Serialization in Program.cs file
9.Imlement logic to serialize and deserialize logic using JSON serialization.
10.Build Console based Menu Driven application to perform CRUD Operations against business entities of your domain.
11.Follow .net coding standards.
12.Use Proper Insert, Update ,Delete, GetById, GetAll methods  for 
*/