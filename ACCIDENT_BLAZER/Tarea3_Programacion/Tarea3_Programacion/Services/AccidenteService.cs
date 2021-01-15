using AccidenteTransito.Data.Dapper.Repositories2;
using AccidenteTransito.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tarea3_Programacion.Data;
using Tarea3_Programacion.Interfaces;

namespace Tarea3_Programacion.Services
{
    public class AccidenteService : IAccidenteService
    {
        private readonly SqlConfiguration sqlConfiguration;
        private IRepositorioAccide repositorio ;

        public AccidenteService(SqlConfiguration configuration)
        {
            sqlConfiguration = configuration;
            repositorio = new RepositorioAccide(configuration.ConnectionString);
        }

        public Task<IEnumerable<Accidente>> GetAccidente()
        {
            return repositorio.GetAccidenteTransito();
        }

        public Task<Accidente> GetInvolucrado(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Cancelar(Accidente accidente)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Enviar(Accidente accidente)
        {
            if (accidente.CodigoAccidentes == 0)
            { 
                return repositorio.Insertar(accidente);
            }
            else
            {
                return null;
            }
        }
    }
}
