using System ; 
namespace example1 {
  public class MyAssert {
    public static bool AssertEquals(int x , int y)  {
         if(x == y ) return true ; 
	 throw new Exception(ConstructMsg(x, y)); 
    }

    public static bool AssertEquals(double x , double y)  {
         if(x == y ) return true ; 
	 throw new Exception(ConstructMsg(x, y)); 
    }


    public static bool AssertEquals(long x , long y)  {
         if(x == y ) return true ; 
	 throw new Exception(ConstructMsg(x, y)); 
    }


    public static bool AssertEquals(string x , string y)  {
         if(x == y ) return true ; 
	 throw new Exception(ConstructMsg(x, y)); 
    }


    public static bool AssertEquals(bool x , bool y)  {
         if(x == y ) return true ; 
	 throw new Exception(ConstructMsg(x, y)); 
    }




    private static string ConstructMsg(object x, object y) {
  return String.Format("{0} is not equal to {1}", x , y); 
    }
  }
}
