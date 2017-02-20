using System ; 
using System.Collections.Generic ; 

namespace example1 {
  public interface PersonDAO {
     void Save(Person p); 
      void Update(long id , Person p); 
      void Delete(long id); 
      Person FindById(long id); 
     List<Person> FindAll(); 
  }

  public class PersonDAOImpl: PersonDAO {
      private Dictionary<long , Person> container ; 

      public PersonDAOImpl() {
         if(container == null) 
		 container = new Dictionary<long , Person>(); 
      }
    public void Save(Person p) {
	    container.Add(p.Id, p); 
     }
     public  void Update(long id , Person p) {
          container.Remove(id); 
	  container.Add(id, p); 
     } 
     public  void Delete(long id) {
          container.Remove(id); 
     } 
     public  Person FindById(long id) {
            return container[id]; 
     }
     public  List<Person> FindAll() {
          List<Person> list = new List<Person>(); 
	   foreach(KeyValuePair<long , Person> pair in container)  {
             list.Add(pair.Value); 
	   }

	   return list; 
     }
  }
}
