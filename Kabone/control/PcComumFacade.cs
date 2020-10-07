using System;
using System.Collections.Generic;
using System.Text;

namespace Kabone.control
{
    public class PcComumFacede
    {
        private Processador processador = null;
        private DiscoRigido discoRigido = null;
        private MemoriaRAM memoriaRAM = null;
        private Fonte fonte = null;
        private Gabinete gabinete = null;
        private PlacaDeVideo placaDeVideo = null;
        private PlacaMae placaMae = null;

        public PcComumFacede()
        {
            this.processador = new Processador();
            this.discoRigido = new DiscoRigido();
            this.memoriaRAM = new MemoriaRAM();
            this.fonte = new Fonte();
            this.gabinete = new Gabinete();
            this.placaDeVideo = new PlacaDeVideo();
            this.placaMae = new PlacaMae();
        }

        public void criarPC()
        {
            this.processador.marca = "Intel";
            this.processador.modelo = "Core i5";
            this.discoRigido.marca = "WD";
            this.discoRigido.modelo = "WD10EZEX";
            this.discoRigido.tipo = "HD";
            this.discoRigido.tamanho = "500GB";
            this.fonte.marca = "Corsair";
            this.fonte.modelo = "500W";
            this.memoriaRAM.marca = "Kingston";
            this.memoriaRAM.modelo = "DDR4";
            this.memoriaRAM.tamanho = 4;
            this.gabinete.marca = "Positivo";
            this.gabinete.modelo = "Plunkton";
            this.placaMae.marca = "ASUS";
            this.placaMae.modelo = "M4A77TD";

            computadorComponent computador = new ComputadorComposite();

            ((ComputadorComposite)computador).add(this.processador);
            ((ComputadorComposite)computador).add(this.discoRigido);
            ((ComputadorComposite)computador).add(this.fonte);
            ((ComputadorComposite)computador).add(this.memoriaRAM);
            ((ComputadorComposite)computador).add(this.gabinete);
            ((ComputadorComposite)computador).add(this.placaMae);

        }


    }
}
