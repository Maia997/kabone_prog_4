using System;
using System.Collections.Generic;
using System.Text;

namespace Kabone.control
{
    class ConexaoSingleton
    {
        private static BancoDeDados conexao = null;
        private ConexaoSingleton()
        {
        }

        public static BancoDeDados getConexao()
        {
            if(conexao == null)
            {
                conexao = new BancoDeDados();
                return conexao;
            }

            return conexao;
        }
    }
}
