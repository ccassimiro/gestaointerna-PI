using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SGI.PI.Data.Repository;
using SGI.PI.Service.Empresa;

namespace SGI.PI.Services
{
    class NucleoServices
    {
        public GenericRepository<Nucleo> NucleoRepository { get; set; }

        //public Nucleo BuscarPorSigla(string sigla)
        //{
        //    var Nucleo = NucleoRepository.EncontrarPorSigla(sigla);
        //    return Nucleo;
        //}
    }
}
