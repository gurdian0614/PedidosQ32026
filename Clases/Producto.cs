public abstract class Producto
{
    public int Id { get; set; }
    public string? Nombre { get; set; } // ?: La Propiedad acepta valores nulos
    public decimal Precio {get; set; }
    public int Stock { get; set;}

    public abstract void MostrarInformacion();
    
    public void DisminuirStock(int Cantidad)
    {
        if (Stock >= Cantidad)
        {
            // Equivalente a Stock = Stock - Cantidad
            Stock -= Cantidad;
        } else
        {
            Console.WriteLine($"No hay suficiente stock de {Nombre}");
        }
    }
}