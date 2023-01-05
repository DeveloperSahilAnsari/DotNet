namespace partname;
public class Part{
//parts of flower
public string name {get; set;}
public string descrip {get; set;}

public Part(){
    this.name="rose";
    this.descrip="red in color";
}
public Part(string n,string d)
{
this.name=n;
this. descrip=d;

}
public override string ToString(){
    return "name="+name+" descrip="+descrip;
}




}