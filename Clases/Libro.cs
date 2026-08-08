public class Libro : Producto, IDescribible
{
    public string? ISBN { get; set; }
    public string? Autor { get; set; }
    public int NumeroPaginas { get; set; }

    public Libro() {}

    public Libro(string ISBN)
    {
        this.ISBN = ISBN;
    }

    public Libro(string ISBN, string Autor)
    {
        this.ISBN = ISBN;
        this.Autor = Autor;
    }

    public override void MostrarInformacion()
    {
        Console.WriteLine("******************** DATOS DEL PRODUCTO ********************");
        Console.WriteLine($"ID: {Id}");
        Console.WriteLine($"Nombre: {Nombre}");
        Console.WriteLine($"Precio: {Precio}");
        Console.WriteLine($"Cantidad Disponible: {Stock}");
        Console.WriteLine(ObtenerDescripcionCompleta());
        Console.WriteLine();
    }

    public string ObtenerDescripcionCompleta()
    {
        return $"ISBN: {ISBN}\nAutor: {Autor}\nNúmero de Páginas: {NumeroPaginas}";
    }
}