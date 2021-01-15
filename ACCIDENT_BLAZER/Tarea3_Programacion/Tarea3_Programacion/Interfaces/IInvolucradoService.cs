using AccidenteTransito.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tarea3_Programacion.Interfaces
{
    public interface IInvolucradoService
    {
        Task<IEnumerable<Involucrado>> GetInvolucrados();
        Task<Involucrado> GetInvolucrado(int id);
        Task<bool> Cancelar(Involucrado involucrado);
        Task<bool> Enviar(Involucrado involucrado);
    }
}
