using System;

class MainClass {
  public static void Main (string[] args) {
string[] IdPedidos = {"B123", "C234", "A345", "C15",
"B177", "G3003", "C235", "B179"};
foreach (string iterar in IdPedidos)
{
    if (iterar.StartsWith("B"))
    {
        Console.WriteLine($"Estas podem ser fraudulentas: {iterar}");
    }
}

    
  }
}