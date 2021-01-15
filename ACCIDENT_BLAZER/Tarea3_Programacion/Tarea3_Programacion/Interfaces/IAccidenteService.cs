using AccidenteTransito.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tarea3_Programacion.Interfaces
{
    public interface IAccidenteService
    {
        Task<IEnumerable<Accidente>> GetAccidente();
        Task<Accidente> GetInvolucrado(int id);
        Task<bool> Cancelar(Accidente accidente);
        Task<bool> Enviar(Accidente accidente);
    }
}
