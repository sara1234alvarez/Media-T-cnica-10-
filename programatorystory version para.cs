/******************************************************************************
Autor:          Sara Alvarez 
Fecha:          06-06-2024
Descripción:    Toy Story
     Los juguetes de Andy están 
     jugando a las escondidas. Pide al 
     usuario las ubicaciones donde buscar 
     y usa estructuras "si" para determinar 
     si los juguetes están en la ubicación 
     correcta o no. Reportar la cantidad 
     total de juguetes que fueron encontrados 
     al finalizar 4 rondas.
*******************************************************************************/

using System;
class HelloWorld {
  static void Main() {
    // variables
    int ubicacion = 0;
    int totaldejugetesencontrados = 0;

    // estructura repetitiva o ciclicla
    for (int i = 0; i < 4; i++) 
     {
              
                Console.WriteLine("Seleccionar la opción deseada:");
                Console.WriteLine("1. cama");
                Console.WriteLine("2. patio");
                Console.WriteLine("3 sala");
                Console.WriteLine("4 baño");
                Console.WriteLine("5 cochera");
                Console.WriteLine("6 sotano");
                  
                Console.WriteLine(" ubicacion donde se encuentran los jugetes");
                ubicacion =  Int32.Parse(Console.ReadLine());
                 
                if (ubicacion == 1){
               
                Console.WriteLine("encuentra a Rex "); 
                 totaldejugetesencontrados = totaldejugetesencontrados + 1;
                     
                }
                       
                 if (ubicacion ==2){
                 totaldejugetesencontrados = totaldejugetesencontrados + 1;
                 Console.WriteLine("encuentra a Hamm "); 
                 }
                   
                       
                 if (ubicacion == 3){
                 Console.WriteLine("encuentra a Bullseye"); 
                 totaldejugetesencontrados = totaldejugetesencontrados + 1;
                 }
                        
                        
                 if (ubicacion== 4){
                Console.WriteLine("encuentra a Slinky");
                 totaldejugetesencontrados = totaldejugetesencontrados + 1;
                 }
                      
                 if (ubicacion == 5){
                 Console.WriteLine(" no hay juguete" );
                 }
                if (ubicacion == 6){
                Console.WriteLine("no hay juguete");
                }           
                              
                 else {
                        Console.WriteLine("ubicacion no valida ");
                 }
                
                //mostrar juguetes encontrados
                Console.WriteLine(" total de juguetes encontrados:" + (totaldejugetesencontrados));
                     
                    
    }             
}
}