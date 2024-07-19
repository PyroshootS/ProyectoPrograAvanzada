public class HomeViewModel
{
    public List<Producto> ProductosDestacados { get; set; }
    public List<Categoria> CategoriasPopulares { get; set; }
    public List<Oferta> OfertasEspeciales { get; set; }
}

public class Producto
{
    public string Nombre { get; set; }
    public string DescripcionCorta { get; set; }
    public decimal Precio { get; set; }
    public string ImagenUrl { get; set; }
}

public class Categoria
{
    public string Nombre { get; set; }
    public string Descripcion { get; set; }
}

public class Oferta
{
    public string Titulo { get; set; }
    public string Descripcion { get; set; }
    public int PorcentajeDescuento { get; set; }
}

public class Carrito
{
    public List<CarritoItem> Items { get; set; }
    public decimal Total => Items.Sum(item => item.Precio * item.Cantidad);
}

public class CarritoItem
{
    public int ProductoId { get; set; }
    public int Cantidad { get; set; }
    public decimal Precio { get; set; }
}