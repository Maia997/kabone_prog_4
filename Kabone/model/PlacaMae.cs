using System;
using System.Collections.Generic;
using System.Text;

namespace Kabone
{
    public class PlacaMae : computadorComponent
    {
        public string marca { get; set; }
        public string modelo { get; set; }

        public override void view()
        {
            Console.WriteLine($"Placa Mae: \n Marca: {this.marca} - Modelo: {this.modelo}");
        }
    }
}
