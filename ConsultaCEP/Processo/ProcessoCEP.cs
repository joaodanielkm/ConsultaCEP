using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultaCEP.Processo
{
    internal class ProcessoCEP
    {
        public bool EhValidoCEP(string CEP) =>
            !string.IsNullOrWhiteSpace(CEP) && !string.IsNullOrEmpty(CEP);

    }
}
