class Program{// Defines the main class called Program 
  static void Main(String[] args){
    // The Main method gets run first
    // Static means I can call this without making a Program object
    int i = 1; // Initialize our loop counter variable 
    while(i < 101){// While loop
      if(i % 15 == 0){// if divisible by 3 and 5  
        Console.WriteLine("FizzBuzz");
      } else if(i % 3 == 0){
        Console.WriteLine("Fizz"); // If just 3 goes in evenly  
      } else if(i % 5 == 0){
        Console.WriteLine("Buzz");// Or if just 5 divides it 
      } else{
        Console.WriteLine(i); // Otherwise 
      }
      i++;//increment!
    }
  }
}