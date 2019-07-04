using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SGI.PI.Service.Membro;

namespace SGI.PI.Services.Exportacao
{
    public class ExportacaoArquivos : IGeradorArquivos
    {
        private IGeradorArquivos _gerador;

        public ExportacaoArquivos(IGeradorArquivos gerador)
        {
            _gerador = gerador;
        }

        public void ExportarDados(List<Membro> ListaMembros)
        {
            ExportarDados(ListaMembros);
        }
    }
}
