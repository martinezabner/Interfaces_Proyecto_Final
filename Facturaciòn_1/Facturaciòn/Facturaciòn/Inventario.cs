using System;
namespace Facturaciòn
{
    public partial class Inventario : Gtk.Window
    {
        public Inventario() :
                base(Gtk.WindowType.Toplevel)
        {
            this.Build();
        }
    }
}
