using System;
using System.Collections.Generic;
using System.Text;

namespace Kabone
{
    public class ComputadorComposite : computadorComponent
    {
        public List<computadorComponent> computador { get; set; }
        public ComputadorComposite()
        {
            computador = new List<computadorComponent>();
        }

        public void add(computadorComponent computador)
        {
            this.computador.Add(computador);
        }

        public override void view()
        {
            foreach(var item in computador)
            {
                item.view();
            }
        }

    }
}
