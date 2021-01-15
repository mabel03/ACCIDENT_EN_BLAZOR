using AccidenteTransito.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AccidenteTransito.Data.Dapper.Repositories
{
    public interface IInvolucradoRepositorio
    {
        Task<IEnumerable<Involucrado>> GetInvolucrados();
        Task<Involucrado> GetInvolucrado(int id);
        Task<bool> Insertar(Involucrado involucrado);
    }
}
