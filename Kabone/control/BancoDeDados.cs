using System;
using System.Collections.Generic;
using System.Text;

namespace Kabone.control
{
    class BancoDeDados
    {
        private List<ComputadorComposite> basedados;

        public BancoDeDados()
        {
            this.basedados = new List<ComputadorComposite>();
        }

        public void salvar(ComputadorComposite computador)
        {
            basedados.Add(computador);
        }

        public List<ComputadorComposite> buscar()
        {
            return basedados;
        }

        public void visualizar()
        {            
            foreach(var pc in basedados)
            {
                pc.view();
                Console.WriteLine("-----------------------");
            }
        }
    }
}
