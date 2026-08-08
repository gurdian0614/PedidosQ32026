public class Electronico : Producto, IDescribible
{
    public int GarantiaMeses { get; set; }
    public string? Voltaje { get; set; }

    public override void MostrarInformacion()
    {
        Console.WriteLine("******************** DATOS DEL PRODUCTO ********************");
        Console.WriteLine($"ID: {Id}");
        Console.WriteLine($"Nombre: {Nombre}");
        Console.WriteLine($"Precio: {Precio}");
        Console.WriteLine($"Cantidad Disponible: {Stock}");
        Console.WriteLine(ObtenerDescripcionCompleta(GarantiaMeses));
        Console.WriteLine();
    }

    public string ObtenerDescripcionCompleta()
    {
        return $"Garantía: {GarantiaMeses}\nVoltaje: {Voltaje}";
    }

    public string ObtenerDescripcionCompleta(int GarantiaMeses, string Voltaje)
    {
        return $"Garantía: {GarantiaMeses}\nVoltaje: {Voltaje}";
    }

    public string ObtenerDescripcionCompleta(int GarantiaMeses)
    {
        return $"Garantía: {GarantiaMeses}\nVoltaje: {Voltaje}";
    }

    public string ObtenerDescripcionCompleta(string Voltaje)
    {
        return $"Garantía: {GarantiaMeses}\nVoltaje: {Voltaje}";
    }
}