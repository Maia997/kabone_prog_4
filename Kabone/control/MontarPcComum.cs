using Kabone.model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kabone.control
{
    public class MontarPcComum : IMontarPC
    {
        public void montarPC()
        {
            PcComumFacede pccomum = new PcComumFacede();

            pccomum.criarPC();
        }
    }
}
