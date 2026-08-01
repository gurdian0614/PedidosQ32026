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

Electronico electronico = new Electronico();
electronico.Id = 3;
electronico.Nombre = "iPhone 17 Pro Max";
electronico.Precio = 50000.00m;
electronico.Stock = 60;
electronico.GarantiaMeses = 24;
electronico.Voltaje = "110V";
electronico.MostrarInformacion();

Libro libro = new Libro();
libro.Id = 4;
libro.Nombre = "Cipotes";
libro.Precio = 250m;
libro.Stock = 100;
libro.ISBN = "24FGTY-5453";
libro.Autor = "Ramón Amaya Amador";
libro.NumeroPaginas = 200;
libro.MostrarInformacion();

Pedido pedido2 = new Pedido(1);
pedido2.AgregarItem(electronico, 12);
pedido2.AgregarItem(libro, 25);
pedido2.MostrarDetalles();

Console.WriteLine("****************************** ACTUALIZACIÓN DE STOCK ******************************");
producto1.MostrarInformacion();
producto2.MostrarInformacion();
electronico.MostrarInformacion();
libro.MostrarInformacion();