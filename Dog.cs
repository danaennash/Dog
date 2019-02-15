//CREATION OF DOG CLASS
class Dog
{

//CLARIFIES GENDER
  public enum Gender
  {
  Male, Female
  };

//VARIABLES
  public string name;
  public string owner;
  public int age;
  public Gender gender;
  
//DETERMINES GENDER
  public static string getGender(Gender gender)
    {
      if (gender == Gender.Male)
    {
      return "His";
    }
      return "Her";
    }

  

    public Dog(string name1,string owner1,int age1,Gender gender1)
    {
      name = name1;
      owner = owner1;
      age = age1;
      gender = gender1;
    }

//BARK

    public void bark(int num)
    {
      for (int i = 0; i < num; i++)
      {
        Console.Write("Woof!");

      }
     Console.WriteLine();
    }

//PRINTS ALL DETAILS
    public string getTag()
    {
      string hisOrher=getGender(gender).ToString();
 
      string heOrShe;
    
    if(hisOrher =="His")
    {
      heOrShe="he";
    }
      else  
    {
      heOrShe = "she";
    }
//PRINTS ALL DETAILS  
    return "If lost, call "+owner+ ". " + hisOrher+" name is "+ name+ " and "+ heOrShe + " is " + age+" old.";
    }

//MAIN PROGRAM
    static void Main(string[] args)
    {

      Dog puppy=new Dog("Orion", "Shawn", 1, Gender.Male);
      
      puppy.bark(3);

      Console.WriteLine(puppy.getTag());


      Dog myDog =new Dog("Lileu", "Dale", 4, Gender.Female);
      myDog.bark(1);
      Console.WriteLine(myDog.getTag());  


      Console.ReadKey();
      }
      }
