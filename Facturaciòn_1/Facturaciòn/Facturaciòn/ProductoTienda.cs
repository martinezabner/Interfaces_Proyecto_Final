using System;
namespace Facturaciòn
{
    public partial class ProductoTienda : Gtk.Window
    {
        public ProductoTienda() :
                base(Gtk.WindowType.Toplevel)
        {
            this.Build();
        }
    }
}
