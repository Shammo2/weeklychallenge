 using System;
 
public class lockers{
        public void findlockers(){
        String[] doors = new String[100];
        for (int k =0; k<100;k++){
            doors[k] = "closed";
        }
        
        for (int i = 0;i<100;i++) {
            int opendoors = i + 1;
            for (int k=i;k < 101; k = k + opendoors){
                if (doors[k], "closed"){
                    doors[k] = "open";
                    
                }
                if ((doors[k], "open")){
                    doors[k] = "closed";
                }
            }
        
        
        for (int h =0; h < 100; h++){
            int count = 0;
            
            if (doors[h], "open"){
                counter++;
            }
            
        }
        }
        Console.WriteLine(doors);
        }
    
    

