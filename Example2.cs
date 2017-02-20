using System ; 
using System.Text.RegularExpressions; 
using System.Collections.Generic; 
namespace example1 {
  public class Example2 {
      public static void Main(string [] args) {
            //TestUserInput(); 
	    TestPersonDAO(); 
      }

      private static void TestUserInput() {
          long id; 
	  string name; 
	  int age ; 
	  double wage; 
	  bool active ; 

	  Console.WriteLine("insert id , name, age, wage, active : "); 
          string input = Console.ReadLine(); 
	  string [] splitted = Regex.Split(input , "\\s*,\\s*"); 
	  try {
              id = Convert.ToInt64(splitted[0]); 
	      name = splitted[1]; 
	      age = Convert.ToInt32(splitted[2]); 
	      wage = Convert.ToDouble(splitted[3]); 
	      active = Convert.ToBoolean(splitted[4]); 
	      Console.WriteLine("id = {0}", id); 
	      Console.WriteLine("name = {0}", name); 
	      Console.WriteLine("age = {0}", age); 
	      Console.WriteLine("wage = {0}", wage); 
	      Console.WriteLine("active = {0}", active); 
	  } catch(Exception ex) {
               Console.WriteLine(ex.Message); 
	  }
      }

       private static void TestPersonDAO() {
            string menu = @"1 -> Save Person 
2 -> Update Person 
3 -> Delete Person 
4 -> FindByID
5 -> FindAll
6 ->break"; 

	//LOOP: 	    
	bool exitingLoop = false ; 
	  while(true) {
            Console.WriteLine(menu); 
	    int answer = Convert.ToInt32(Console.ReadLine()); 
	    switch(answer) {
            case 1: Save(); break; 
	    case 2: Update(); break; 
	    case 3: Delete(); break; 
	    case 4: FindById(); break; 
	    case  5: FindAll(); break; 
	    case 6: exitingLoop = true ; break; 
	    }

	    if(exitingLoop) break; 
	  }		  
       }

       private static PersonDAO dao = new PersonDAOImpl(); 

       private static void Save() {
          Console.WriteLine("insert id, name, age, wage, active of new Person: "); 
	  String input = Console.ReadLine(); 
	  try {
           String [] splitted = Regex.Split(input , "\\s*,\\s*"); 
	    dao.Save(SplittedToPerson(splitted)); 
	  } catch(Exception ex) {
            Console.WriteLine(ex.Message); 
	  }
       }

       private static void Update() {
          Console.WriteLine("insert id, name, age, wage, active of Person to be updated : "); 
	  String input = Console.ReadLine(); 
	  try {
           String [] splitted = Regex.Split(input , "\\s*,\\s*"); 
	   Person p = SplittedToPerson(splitted); 
	    dao.Update(p.Id, p); 
	  } catch(Exception ex) {
            Console.WriteLine(ex.Message); 
	  }
       }

       private static void Delete() {
         Console.WriteLine("insert id of Person to be deleted: "); 
	  String input = Console.ReadLine(); 
	  try {
            long id = Convert.ToInt64(input); 
	    dao.Delete(id); 
	  } catch(Exception ex) {
            Console.WriteLine(ex.Message); 
	  }
       }

       private static void FindById() {
          Console.WriteLine("insert id of Person to be found: "); 
	  string input  = Console.ReadLine(); 
	  try {
            long id = Convert.ToInt64(input); 
	    Person p = dao.FindById(id); 
	    Console.WriteLine(p); 
	  } catch(Exception ex) {
              Console.WriteLine(ex.Message); 
	  }
       }

       private static void FindAll() {
           List<Person> personList = dao.FindAll(); 
	   foreach(var person in personList) 
		   Console.WriteLine(person); 
       }


       private static Person SplittedToPerson(String[] splitted) {
   long id = Convert.ToInt64(splitted[0]); 
   string name = splitted[1]; 
   int age = Convert.ToInt32(splitted[2]); 
   double wage = Convert.ToDouble(splitted[3]); 
   bool active = Convert.ToBoolean(splitted[4]); 
   return new Person(id, name, age, wage, active); 
       }



  }
}
