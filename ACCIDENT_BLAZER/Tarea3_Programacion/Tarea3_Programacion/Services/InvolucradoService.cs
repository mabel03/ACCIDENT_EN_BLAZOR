using AccidenteTransito.Data.Dapper.Repositories;
using AccidenteTransito.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tarea3_Programacion.Data;
using Tarea3_Programacion.Interfaces;

namespace Tarea3_Programacion.Services
{
    public class InvolucradoService : IInvolucradoService
    {
        private readonly SqlConfiguration sqlConfiguration;
        private IInvolucradoRepositorio involucradoRepositorio;

        public InvolucradoService(SqlConfiguration configuration)
        {
            sqlConfiguration = configuration;
            involucradoRepositorio = new InvolucradoRepositorio(configuration.ConnectionString);
        }

        public Task<bool> Cancelar(Involucrado involucrado)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Enviar(Involucrado involucrado)
        {
            if (involucrado.IdPersona == 0)
            {
                return involucradoRepositorio.Insertar(involucrado);
            }
            else
            {
                return null;
            }
        }

        public Task<Involucrado> GetInvolucrado(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Involucrado>> GetInvolucrados()
        {
            return involucradoRepositorio.GetInvolucrados();
        }
    }
}
