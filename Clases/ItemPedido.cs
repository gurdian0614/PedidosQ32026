public class ItemPedido
{
    public Producto Producto { get; set; }
    public int Cantidad { get; set; }
    public decimal SubTotal => Producto.Precio * Cantidad;

    public ItemPedido(Producto producto, int Cantidad)
    {
        Producto = producto;
        this.Cantidad = Cantidad;
    }
}