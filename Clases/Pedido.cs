public class Pedido
{
    public int Id { get; set; }
    public DateTime Fecha { get; set; }
    public List<ItemPedido> Items { get; set; }
    public decimal Total => Items.Sum(item => item.SubTotal);

    public Pedido(int IdPedido)
    {
        Id = IdPedido;
        Items = new List<ItemPedido>();
    }

    public void AgregarItem(Producto Producto, int Cantidad)
    {
        if (Producto.Stock >= Cantidad)
        {
            //ItemPedido item = new ItemPedido(Producto, Cantidad);
            //Items.Add(item);
            Items.Add(new ItemPedido(Producto, Cantidad));
            Producto.DisminuirStock(Cantidad);
            Console.WriteLine($"El Producto {Producto.Nombre} con Cantidad {Cantidad} se ha agregado al pedido.");
            Console.WriteLine();
        } else
        {
            Console.WriteLine($"No hay suficiente stock de {Producto.Nombre}");
            Console.WriteLine();
        }
    }

    public void MostrarDetalles()
    {
        Console.WriteLine("------------------------------");
        Console.WriteLine($"Detalles del Pedido #{Id}");
        Console.WriteLine($"Fecha: {Fecha:dd/MM/yyyy hh:mm:ss tt}");

        foreach (ItemPedido item in Items)
        {
            Console.WriteLine($"Producto {item.Producto.Nombre}, Cantidad: {item.Cantidad}, SubTotal: {item.SubTotal:C}");
        }

        Console.WriteLine($"Total: {Total:C}");
        Console.WriteLine("------------------------------");
        Console.WriteLine();
    }
}