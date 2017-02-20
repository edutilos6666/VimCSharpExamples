 using System ; 
namespace example1 {
  public class Person {
    public long Id {get; set; }
    public string Name {get; set; }
    public int Age {get; set; }
    public double Wage {get; set;}
    public bool Active {get; set; }

    public Person(long id , string name, int age, double wage, bool active) {
        this.Id = id ; 
	this.Name = name; 
	this.Age = age ; 
	this.Wage = wage; 
	this.Active = active ; 
    }


    public override String ToString() {
       return String.Format("id = {0}, name = {1}, age = {2}, wage = {3} , active = {4}", 
		       Id , Name, Age, Wage, Active); 
    }
  }
}
