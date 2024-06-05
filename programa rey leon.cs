/******************************************************************************
AUTOR :  Sara Alvarez 
FECHA : 05-04 24 
DESCRIPCIÓN  El Rey León: 
    Las manadas de la Roca del Rey están compitiendo 
    por el control de las Tierras del Reino. 
    Pide al usuario la fuerza de al menos 5 
    clanes diferentes y usa estructuras "si" 
    para determinar clasificación de fuerza.

*******************************************************************************/
using System;
class HelloWorld {
  static void Main() {
   
   int fuerza = 0;
     
 
 
        for (int i = 0; i <= 4; i++) {
            
        
       
       
           Console.WriteLine("ingrese la fuerza "+ i + "luego presionar enter");
           fuerza =  Int32.Parse(Console.ReadLine());
      
           if (fuerza >= 0){
                if(fuerza <=20){
                 Console.WriteLine("Felicidades,eres un leon"); 
                 
                 
                 }   
                 }
               if (fuerza >=22){
                   if(fuerza<=30){
             
                Console.WriteLine("Felicidades,eres un rinoceronte"); 
                        
                   }
                   }
                  if (fuerza >= 32){
                      if(fuerza <=40){
                    
                    Console.WriteLine("Felicidades,eres un elefante"); 
                        
                        }
                        } 
                  if (fuerza >= 41){
                       if(fuerza <=50){
                    
                  Console.WriteLine("Felicidades,eres un elefante");
                      
                       }
                       }
                  if (fuerza >= 51){
                       if(fuerza <=99){
                  
                       Console.WriteLine("Felicidades,eres un elefante");
                       
                           }
                           }
                          
         
       }   
   }        
  }   
     
 
