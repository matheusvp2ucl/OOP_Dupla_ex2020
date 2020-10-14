using System;

class MainClass {
  public static void Main () {

    // Letra: F
    Aeronave a747 = new Aeronave( "Boeing 747", 
                                  100, 
                                  50, 
                                  410, 
                                  5000, 
                                  0, 
                                  "Max Fercondini", "Guarulhos" 
                                );
    Console.WriteLine( a747.Voar(3000) );
  }
}