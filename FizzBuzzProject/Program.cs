﻿class Program{
   static void Main(String[] args){
       int i = 0;
       while(i < 101){
           if(i % 15 == 0){
               Console.WriteLine("FizzBuzz"); 
           }
           else if(i % 3 == 0){
               Console.WriteLine("Fizz"); 
           }
           else if(i % 5 == 0){
               Console.WriteLine("Buzz"); 
           }
           else{
               Console.WriteLine(i); 
           }
           i++;
       }
   }
}