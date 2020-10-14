using Kabone.model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kabone.control
{
    class BancoCommand : IConexao
    {
        private BancoDeDados conexao;
        private ComputadorComposite computador;
        private string acao;

        public BancoCommand(BancoDeDados banco, string acao, ComputadorComposite computador = null)
        {
            this.conexao = banco;
            this.acao = acao;
            this.computador = computador;
        }

        public void executa()
        {

            switch (this.acao)
            {
                case "salvar":
                    this.conexao.salvar(this.computador);
                    break;
                case "visualizar":
                    this.conexao.visualizar();
                    break;
                default:
                    Console.WriteLine("Nenhuma opcao encontrada");
                    break;
            }
        }
    }
}
