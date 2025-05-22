using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema
{
    class CadastroUsuario
    {
        
        //Cria um método estático com [](Alheio) para chamar classe 
        private static Usuario[] cliente =
        {
            new Usuario(){Nome = "admin", Senha = "1234"}
        };
        public static bool Login(string nome, string senha)
        {
            foreach (Usuario n in cliente)
            {
                if (n.Nome == nome && n.Senha == senha)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
