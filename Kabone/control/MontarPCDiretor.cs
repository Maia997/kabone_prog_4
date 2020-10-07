using Kabone.model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kabone.control
{
    public class MontarPCDiretor
    {
        private IMontarPC builder;

        public void setBuilder(IMontarPC b)
        {
            this.builder = b;
        }

        public void montarPCGamer(IMontarPC builder)
        {
            builder.montarPC();

        }

        public void montarPCComum(IMontarPC builder)
        {
            builder.montarPC();
        }
    }
}
