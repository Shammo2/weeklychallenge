using System.Collections.Generic;
using UI;
public class stack{

public void stackstart(){

    List<int> stack = new List<int>();
    Console.WriteLine("[1] push to stack");
    Console.WriteLine("[2] pop from stack");
    Console.WriteLine("[3] push to stack");
    string input = Console.ReadLine();
    switch(input){
        case "1":
        Console.WriteLine("you chose: push to stack");
        break; 
        case "2":
        Console.WriteLine("you chose: pop from stack");
        break; 
        case "3":
        Console.WriteLine("you chose: push to stack");
        break; 


    }



}




}