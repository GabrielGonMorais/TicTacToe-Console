using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogodavelha
{
     abstract class Jogadores
    {
        public string nome;
        public int vitorias;        
        public static string[] position = new string[9];

        public abstract void Escolha();
        public abstract void Verificar();

    }
}
