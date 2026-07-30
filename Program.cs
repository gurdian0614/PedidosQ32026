Producto producto1 = new Producto();
producto1.Id = 1;
producto1.Nombre = "Mouse";
producto1.Precio = 250.00m;
producto1.Stock = 50;
producto1.MostrarInformacion();

Producto producto2 = new Producto();
producto2.Id = 2;
producto2.Nombre = "Teclado";
producto2.Precio = 500.00m;
producto2.Stock = 30;
producto2.MostrarInformacion();

Pedido pedido1 = new Pedido(1);
pedido1.AgregarItem(producto1, 45);
pedido1.AgregarItem(producto2, 10);
pedido1.MostrarDetalles();

Console.WriteLine("****************************** ACTUALIZACIÓN DE STOCK ******************************");
producto1.MostrarInformacion();
producto2.MostrarInformacion();