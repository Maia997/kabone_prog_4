using System;
using System.Collections.Generic;
using System.Text;

namespace Kabone.control
{
    public class PcGamerFacede
    {
        private Processador processador = null;
        private DiscoRigido discoRigido = null;
        private MemoriaRAM memoriaRAM = null;
        private Fonte fonte = null;
        private Gabinete gabinete = null;
        private PlacaDeVideo placaDeVideo = null;
        private PlacaMae placaMae = null;

        public PcGamerFacede()
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
            this.processador.modelo = "Core i9";
            this.discoRigido.marca = "WD Black";
            this.discoRigido.modelo = "WD10EZES";
            this.discoRigido.tipo = "SSD m.2";
            this.discoRigido.tamanho = "2TB";
            this.fonte.marca = "Corsair";
            this.fonte.modelo = "1000W";
            this.memoriaRAM.marca = "Corsair";
            this.memoriaRAM.modelo = "DDR4";
            this.memoriaRAM.tamanho = 128;
            this.gabinete.marca = "NZXT";
            this.gabinete.modelo = "PHANTOM";
            this.placaMae.marca = "GIGABYTE";
            this.placaMae.modelo = "M4A77TD77";
            this.placaDeVideo.marca = "NVIDIA Galax";
            this.placaDeVideo.modelo = "RTX 3090";
           
            computadorComponent computador = new ComputadorComposite();

            ((ComputadorComposite)computador).add(this.processador);
            ((ComputadorComposite)computador).add(this.discoRigido);
            ((ComputadorComposite)computador).add(this.fonte);
            ((ComputadorComposite)computador).add(this.memoriaRAM);
            ((ComputadorComposite)computador).add(this.gabinete);
            ((ComputadorComposite)computador).add(this.placaMae);
            ((ComputadorComposite)computador).add(this.placaDeVideo);

            var banco = new BancoCommand(ConexaoSingleton.getConexao(), "salvar", ((ComputadorComposite)computador));
            banco.executa();
        }

    }
}
