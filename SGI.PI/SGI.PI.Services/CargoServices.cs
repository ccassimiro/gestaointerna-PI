using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SGI.PI.Data.Repository;
using SGI.PI.Service.Empresa;

namespace SGI.PI.Services
{
    public class CargoServices
    {
        public GenericRepository<Cargo> CargoRepository { get; set; }

        public void InserirCargo(Cargo cargo)
        {
            CargoRepository.Adicionar(cargo);
        }

        public Cargo BuscarPorSigla(string sigla)
        {
            var Cargo = CargoRepository.EncontrarPorSigla(sigla);
            return Cargo;
        }
    }
}
