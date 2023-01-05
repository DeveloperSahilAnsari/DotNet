// See https://aka.ms/new-console-template for more information
using TimeSheet;
Console.WriteLine("Hello, World!");



BusinessEntity be1=new BusinessEntity{"Sahil","Ansari",23,184};
BusinessEntity be2=new BusinessEntity{"lakhan","kumar",20,154};
BusinessEntity be3=new BusinessEntity{"lakhan","kumar",20,154};
BusinessEntity be4=new BusinessEntity{"lakhan","kumar",20,154};

List <BusinessEntity> list=new List<BusinessEntity>();
 list.Add(be1);
 list.Add(be2);
 list.Add(be3);
 list.Add(be4);
Console.WriteLine(be1.ToString);
