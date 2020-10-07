using Kabone.model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kabone.control
{
    public class MontarPcGamer : IMontarPC
    {
        public void montarPC()
        {
            PcGamerFacede pcgamer = new PcGamerFacede();

            pcgamer.criarPC();
        }
    }
}
