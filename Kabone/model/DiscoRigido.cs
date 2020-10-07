using System;
using System.Collections.Generic;
using System.Text;

namespace Kabone
{
    public class DiscoRigido : computadorComponent
    {
        public string tipo { get; set; }
        public string marca { get; set; }
        public string modelo { get; set; }
        public string tamanho { get; set; }

        public override void view()
        {
            Console.WriteLine($"Marca: {this.marca} \n Modelo: {this.modelo}");
            Console.WriteLine($"Tipo: {tipo} \n Tamanho: {tamanho}");
        }
    }
}
