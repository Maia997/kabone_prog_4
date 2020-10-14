using System;
using System.Collections.Generic;
using System.Text;

namespace Kabone
{
    public class PlacaDeVideo : computadorComponent
    {
        public string marca { get; set; }
        public string modelo { get; set; }
        public override void view()
        {
            Console.WriteLine($"Placa de Video: \n Marca: {this.marca} - Modelo: {this.modelo}");
        }
    }

}
