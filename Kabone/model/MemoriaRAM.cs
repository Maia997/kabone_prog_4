using System;
using System.Collections.Generic;
using System.Text;

namespace Kabone
{
    class MemoriaRAM : computadorComponent
    {
        public string marca { get; set; }
        public string modelo { get; set; }
        public int tamanho { get; set; }

        public override void view()
        {
            Console.WriteLine($"Memoria: \n Marca: {this.marca} - Modelo: {this.modelo} - Tamanho: {tamanho}");
        }
    }
}