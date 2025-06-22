using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe7
{
    class Aluno
    {
        string[] nomes = new string[10];

        public string this[int i]
        {
            get
            {
                if (i >= 0 && i < nomes.Length)
                {
                    return nomes[i];
                }
                return "Erro!";
            }

            set
            {
                if (i >= 0 && i < nomes.Length)
                {
                    nomes[i] = value;
                }
            }
        }
    }
}
