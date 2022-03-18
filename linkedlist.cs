using System;
using System.Collections.Generic;
using System.Collections;
using UI;

public class linked{
	int number;
    Boolean isEval;
    linked next;
    public linked(){
        number = 0;
        next = null;
        isEval = false;
    }
    linked(int val, linked n){
        number = val;
        next = n;
        isEval = false;
    }
	
	static linked findsame(linked A, linked B){
            while(A.next != null){
                A.isEval = true;
                A = A.next;
            }
            
            while(B.next != null){
                if (B.isEval == true)
                {return B;}
                B.isEval = true;
                B = B.next;
            }
			
            linked notNode = new linked();
			return notNode;

}
public void linkedlists(){

    }
}



/*
 Given two singly linked lists that intersect at some point, find the intersecting node.
 Assume the lists are non-cyclical.
For example, given A = 3 ➔ 7 ➔ 8 ➔ 10 and B = 99 ➔ 1 ➔ 8 ➔ 10, return the node with number 8.
In this example, assume nodes with the same value are the exact same node objects.
Do this in 0( m + n) time (where m and n are the lengths of the lists) and constant space.
*/