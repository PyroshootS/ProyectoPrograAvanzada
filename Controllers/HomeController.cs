using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

public class HomeController : Controller
{
 

    public HomeController()
    {
      
    }

    public IActionResult Index()
    {
        var viewModel = new HomeViewModel
        {
            ProductosDestacados = ObtenerProductosDestacados(),
            CategoriasPopulares = ObtenerCategoriasPopulares(),
            OfertasEspeciales = ObtenerOfertasEspeciales()
        };

        return View(viewModel);
    }

    public IActionResult Producto(int id)
    {
        var producto = ObtenerProductoPorId(id);
        if (producto == null)
        {
            return NotFound();
        }
        return View(producto);
    }

    public IActionResult Categoria(int id)
    {
        var categoria = ObtenerCategoriaPorId(id);
        if (categoria == null)
        {
            return NotFound();
        }
        return View(categoria);
    }

    public IActionResult Buscar(string query)
    {
        var resultados = BuscarProductos(query);
        return View(resultados);
    }

    public IActionResult Carrito()
    {
        var carrito = ObtenerCarritoActual();
        return View(carrito);
    }

    [HttpPost]
    public IActionResult AgregarAlCarrito(int productoId, int cantidad)
    {
       
        return RedirectToAction(nameof(Carrito));
    }

    public IActionResult AcercaDe()
    {
        return View();
    }

    public IActionResult Contacto()
    {
        return View();
    }

    private List<Producto> ObtenerProductosDestacados()
    {
       
        return new List<Producto>
        {
            new Producto { Id = 1, Nombre = "Producto 1", DescripcionCorta = "Descripción corta 1", Precio = 19.99m, ImagenUrl = "/images/producto1.jpg" },
            new Producto { Id = 2, Nombre = "Producto 2", DescripcionCorta = "Descripción corta 2", Precio = 29.99m, ImagenUrl = "/images/producto2.jpg" },
            new Producto { Id = 3, Nombre = "Producto 3", DescripcionCorta = "Descripción corta 3", Precio = 39.99m, ImagenUrl = "/images/producto3.jpg" }
        };
    }

    private List<Categoria> ObtenerCategoriasPopulares()
    {
        return new List<Categoria>
        {
            new Categoria { Id = 1, Nombre = "Electrónica", Descripcion = "Gadgets y dispositivos electrónicos" },
            new Categoria { Id = 2, Nombre = "Ropa", Descripcion = "Moda para todas las edades" },
            new Categoria { Id = 3, Nombre = "Hogar", Descripcion = "Todo para tu casa" }
        };
    }

    private List<Oferta> ObtenerOfertasEspeciales()
    {
        return new List<Oferta>
        {
            new Oferta { Id = 1, Titulo = "Oferta de Verano", Descripcion = "Descuentos en productos de verano", PorcentajeDescuento = 20 },
            new Oferta { Id = 2, Titulo = "Liquidación", Descripcion = "Últimas unidades con grandes descuentos", PorcentajeDescuento = 50 }
        };
    }

    private Producto ObtenerProductoPorId(int id)
    {
        return ObtenerProductosDestacados().FirstOrDefault(p => p.Id == id);
    }

    private Categoria ObtenerCategoriaPorId(int id)
    {
        return ObtenerCategoriasPopulares().FirstOrDefault(c => c.Id == id);
    }

    private List<Producto> BuscarProductos(string query)
    {
        return ObtenerProductosDestacados().Where(p => p.Nombre.Contains(query, StringComparison.OrdinalIgnoreCase)).ToList();
    }

    private Carrito ObtenerCarritoActual()
    {
        
        return new Carrito
        {
            Items = new List<CarritoItem>
            {
                new CarritoItem { ProductoId = 1, Cantidad = 2, Precio = 19.99m },
                new CarritoItem { ProductoId = 2, Cantidad = 1, Precio = 29.99m }
            }
        };
    }
}

