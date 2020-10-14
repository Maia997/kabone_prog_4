using System;
using System.Collections.Generic;
using System.Text;

namespace Kabone
{
    public class Fonte : computadorComponent
    {
        public string marca { get; set;}
        public string modelo { get; set; }

        public override void view()
        {
            Console.WriteLine($"Fonte: \n Marca: {this.marca} - Modelo: {this.modelo}");
        }
    }
}
