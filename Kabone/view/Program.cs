using Kabone.control;
using System;

namespace Kabone
{
    class Program
    {
        static void Main(string[] args)
        {

            MontarPCDiretor diretor = new MontarPCDiretor();
            MontarPcGamer pcgamer = new MontarPcGamer();
            MontarPcComum pccomum = new MontarPcComum();

            diretor.montarPCGamer(pcgamer);

            diretor.montarPCComum(pccomum);

            diretor.visualizarPc();

        }
    }
}
