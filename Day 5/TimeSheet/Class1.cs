namespace TimeSheet;
using System;

using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.ComponentModel.DataAnnotations;

[Serializable]
public class BusinessEntity
{
int Id{get;set;}
public string? FirstName{get;set;}
public string? LastName{get;set;}
public int HoursWorked{get;set;}
public int TotalDayWorked{get;set;}

// BusinessEntity()
// {}

// BusinessEntity(){
//     int count=100;
//     this.Id=count;
//     count++; 
//      this.FirstName="Sahil";
//     this.LastName="abc";
//     this.HoursWorked=10;
//     this.TotalDayWorked=2;
// }

public BusinessEntity(string Fname,string Lname,int HrsWrk,int TotlDays){
    this.FirstName=Fname;
    this.LastName=Lname;
    this.HoursWorked=HrsWrk;
    this.TotalDayWorked=TotlDays;
}
public override string ToString(){
    return FirstName+" "+LastName+" "+HoursWorked;
}

}
/*
8.Use appropriate namespaces for Json Serialization in Program.cs file
9.Imlement logic to serialize and deserialize logic using JSON serialization.
10.Build Console based Menu Driven application to perform CRUD Operations against business entities of your domain.
11.Follow .net coding standards.
12.Use Proper Insert, Update ,Delete, GetById, GetAll methods  for 
*/