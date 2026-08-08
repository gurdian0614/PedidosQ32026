Electronico electronico2 = new Electronico();
electronico2.Id = 1;
electronico2.Nombre = "Mouse";
electronico2.Precio = 250.00m;
electronico2.Stock = 50;
electronico2.GarantiaMeses = 6;
electronico2.Voltaje = "110V";
electronico2.MostrarInformacion();

Electronico electronico3 = new Electronico();
electronico3.Id = 2;
electronico3.Nombre = "Teclado";
electronico3.Precio = 500.00m;
electronico3.Stock = 30;
electronico3.GarantiaMeses = 12;
electronico3.Voltaje = "110V";
electronico3.MostrarInformacion();

Pedido pedido1 = new Pedido(1);
pedido1.AgregarItem(electronico2, 45);
pedido1.AgregarItem(electronico3, 10);
pedido1.MostrarDetalles();

Electronico electronico = new Electronico();
electronico.Id = 3;
electronico.Nombre = "iPhone 17 Pro Max";
electronico.Precio = 50000.00m;
electronico.Stock = 60;
electronico.GarantiaMeses = 24;
electronico.Voltaje = "110V";
electronico.MostrarInformacion();

Libro libro1 = new Libro();
libro1.Id = 4;
libro1.Nombre = "Cipotes";
libro1.Precio = 250m;
libro1.Stock = 100;
libro1.ISBN = "24FGTY-5453";
libro1.Autor = "Ramón Amaya Amador";
libro1.NumeroPaginas = 200;
libro1.MostrarInformacion();

Libro libro2 = new Libro("RTFJDDJF8478");
libro2.Id = 5;
libro2.Nombre = "Popol Vuh";
libro2.Precio = 150m;
libro2.Stock = 80;
libro2.Autor = "Los Mayas";
libro2.NumeroPaginas = 150;
libro2.MostrarInformacion();

Pedido pedido2 = new Pedido(1);
pedido2.AgregarItem(electronico, 12);
pedido2.AgregarItem(libro1, 25);
pedido2.AgregarItem(libro2, 12);
pedido2.MostrarDetalles();

Console.WriteLine("****************************** ACTUALIZACIÓN DE STOCK ******************************");
electronico2.MostrarInformacion();
electronico3.MostrarInformacion();
electronico.MostrarInformacion();
libro1.MostrarInformacion();
libro2.MostrarInformacion();