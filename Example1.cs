 using System;
//  using System.Collections.Generic  ;
namespace example1 {
   public class Example1Runner {
        public static void Main(String[] args) {
            Console.WriteLine("Hello World"); 
	    Person p = new Person(1, "foo", 10 , 100.0 , true);
	    Console.WriteLine(p.ToString()); 
	  
	     PersonDAO dao = new PersonDAOImpl(); 
	    dao.Save(new Person(1, "foo", 10, 100.0, true)); 
	   dao.Save(new Person(2 , "bar", 20 , 200.0 , false)); 
	  dao.Save(new Person(3, "bim", 30, 300.0, true)); 

             var list  = dao.FindAll(); 
	     MyAssert.AssertEquals(3, list.Count); 

	     //test update 
	     dao.Update(1 , new Person(1, "newfoo", 66, 666.6 , false)); 
	      p = dao.FindById(1); 
	     MyAssert.AssertEquals(1, p.Id); 
	     MyAssert.AssertEquals("newfoo", p.Name); 
	     MyAssert.AssertEquals(66 , p.Age); 
	     MyAssert.AssertEquals(666.6, p.Wage); 
	     MyAssert.AssertEquals(false, p.Active); 

	
	     //test delete 
	     list = dao.FindAll(); 
	     MyAssert.AssertEquals(3, list.Count); 
	     dao.Delete(1); 
	     list = dao.FindAll(); 
	     MyAssert.AssertEquals(2, list.Count); 
	     dao.Delete(2); 
	     list = dao.FindAll(); 
	     MyAssert.AssertEquals(1, list.Count); 
	     dao.Delete(3); 
	     list = dao.FindAll(); 
	     MyAssert.AssertEquals(0, list.Count); 


	     Console.WriteLine("passed"); 	     
	     //Console.ReadLine();
	   
	}
   }
 }
