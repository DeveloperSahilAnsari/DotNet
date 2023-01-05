using System.Collections.Generic;
using partname;
using TFLCollection;
// List<Object> allObject=new List<Object>();
// allObject.Add(12);
// allObject.Add(32);

// foreach(Object obj in allObject){
//     Console.WriteLine(obj+" ");
// }
//Part class
//Part p=new Part();


// List<Part> p=new List<Part>();
// p.Add(new Part(){name="chameli",descrip="white smell"});
// p.Add(new Part(){name="hibiscus",descrip="red sundar"});

// foreach(Object obj in p){
//     Console.WriteLine(obj+" ");
// }


// Stack<Part> SP=new Stack<Part>();
// SP.Push(new Part(){name="MOgra",descrip="pleasent"});
// SP.Push(new Part(){name="MOgra2",descrip="pleasent"});
//   Console.WriteLine("poped "+SP.Pop());
// foreach(Object obj in SP){
//     Console.WriteLine(obj+" ");
// }

// //employee clss 

// List<Employee> employees=new List<Employee>();
// employees.Add(new Employee(1, "Raghu",30000));
// employees.Add(new Employee(2, "Rajendra",67000));
// employees.Add(new Employee(4, "Sham",20000));

// Console.WriteLine("List of Employees before Sort");
// foreach(Employee emp in employees){
//     Console.WriteLine(emp.id + "--"+ emp.name + "--"+ emp.salary);
// }


// //Implement logic for Sorting
// EmpComparer ec = new EmpComparer();

// employees.Sort(ec);
// Console.WriteLine("List of Employees after Sort");
// foreach(Employee emp in employees){
//     Console.WriteLine(emp.id + "--"+ emp.name + "--"+ emp.salary);
// }
//player

Player p1= new Player("Sourav Ganguly",50, 300, 50000);
Player p2= new Player("Sachin Tendulkar",49, 350, 100000);
Player p3= new Player("Rahul Dravid",48, 250, 70000);

List<Player> indianPlayers=new List<Player>();
indianPlayers.Add(p1);
indianPlayers.Add(p2);
indianPlayers.Add(p3);

//indianPlayers.Sort();

foreach( Player currentPlayer in indianPlayers){
  Console.WriteLine(currentPlayer);
}
