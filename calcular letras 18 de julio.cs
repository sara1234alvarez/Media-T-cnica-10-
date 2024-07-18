/******************************************************************************
Autor: Sara Alvarez

fecha:  18 -07-24

Descrocion: calculadora frases que incluya un menu para ingresar a 
opcion debe permitir ingresar la frase y luego calcular
la cantidad de letras que tiene 

*******************************************************************************/
using System;
class HelloWorld {
    
     static void Main() {
      
      palabra();
      
  }
        static void palabra(){
        Console.WriteLine("ingrese una palabra");
        string frase = Console.ReadLine();
        int cantidadletras= frase.Length;
        
        Console.WriteLine("su frase tiene: " +  frase.Length   +    " letras" );
            
          
            
              
                

  }
}