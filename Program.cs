
using arbolbb;

Arbolbb arbol = new Arbolbb();

arbol.Insertar(15);
arbol.Insertar(9);
arbol.Insertar(6);
arbol.Insertar(14);
arbol.Insertar(13);
arbol.Insertar(20);
arbol.Insertar(17);
arbol.Insertar(64);
arbol.Insertar(26);
arbol.Insertar(72);

Console.WriteLine("InOrden:");
arbol.InOrden();
Console.WriteLine("\nPreOrden:");
arbol.PreOrden();
Console.WriteLine("\nPostOrden:");
arbol.PostOrden();
Console.WriteLine("\nBuscar: 40");
arbol.Buscar(40);
Console.WriteLine("Buscar: 17");
arbol.Buscar(17);