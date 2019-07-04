using SGI.PI.Service.Membro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGI.PI.Services.Exportacao
{
    public interface IGeradorArquivos
    {
        void ExportarDados(List<Membro> ListaMembros);
    }
}
