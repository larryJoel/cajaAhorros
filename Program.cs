// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Cuenta ahorro = new Cuenta("Luis Medina");
ahorro.setCantidad(2850.45);
ahorro.datosCuenta();
ahorro.ingresar(2800.00);
ahorro.ingresar(-100);
ahorro.retirar(9000);
Console.WriteLine(ahorro.getCantidad()+" pesos en cuenta");
