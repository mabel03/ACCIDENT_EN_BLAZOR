using AccidenteTransito.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AccidenteTransito.Data.Dapper.Repositories2
{
    public interface IRepositorioAccide
    {
        Task<IEnumerable<Accidente>> GetAccidenteTransito();
        Task<Accidente> GetInvolucrado(int id);
        Task<bool> Insertar(Accidente accidente);
    }
}
