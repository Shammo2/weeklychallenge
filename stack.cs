using System.Collections.Generic;
using System.Collections;
using UI;
using System;
public class stack{

public void stackstart(){
    
    Stack newStack = new Stack();
    bool exit = false; 
    while(!exit){
        Console.WriteLine("[1] push to stack");
        Console.WriteLine("[2] pop from stack");
        Console.WriteLine("[3] push to stack");
        Console.WriteLine("[x] exit");
        string input = Console.ReadLine();
        switch(input){
            case "1":
            Console.WriteLine("you chose: push to stack");
            Console.WriteLine("enter a number");
            string stackstring = Console.ReadLine();
            int stacknumber = Int32.Parse(input);
            newStack.Push(stacknumber);
            break; 
            case "2":
            Console.WriteLine("you chose: pop from stack");
            Console.WriteLine( "(Peek)\t\t{0}", newStack.Peek() );
            break; 
            case "3":
            Console.WriteLine("you chose: push to stack");
            break; 
            case "x":
            exit = true;
            break;

        }
    }
}

}


/*
Implement a stack that has the following methods:
• push ( v a 1 ) : push v a 1 onto the stack
• pop: pop off and return the topmost element of the stack.
If there are no elements in the stack, throw an error.
• max: return the maximum value in the stack currently.
If there are no elements in the stack, throw an error.
Each method should run in constant time.
*/