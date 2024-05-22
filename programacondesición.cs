/******************************************************************************
Autor:   Sara Alvarez 
Lenguje  usado :  c#
fecha:  2024-05-22
Descripción: Programa con  decisiones  para 
determinar el sexo de un usuario 

                    
*******************************************************************************/
using System;
class programa {
  static void Main() {
    //variables
    bool sexoMasculino;
    // capturar informacion del usuario
    Console.Write("Digite true si es hombre");
    sexoMasculino = Convert.ToBoolean (Console.ReadLine());
      // validación 
      if( sexoMasculino == true){
      
          Console.WriteLine("felicidades, es hombre");
      }
         
        else { 
              Console.WriteLine("felicidades, es mujer");
        }
              
              
            Console.WriteLine("finalizada la ejecución ");
            
             
         
      
    
    
  }
  
}