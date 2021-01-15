using AccidenteTransito.Model;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using AccidenteTransito;

namespace AccidenteTransito.Data.Dapper.Repositories
{
    public class InvolucradoRepositorio : IInvolucradoRepositorio
    {
        private string ConnectionString;

        public InvolucradoRepositorio(string conectionString)
        {
            ConnectionString = conectionString;
        }
        protected SqlConnection dbConnection()
        {
            return new SqlConnection(ConnectionString);
        }


        public Task<Involucrado> GetInvolucrado(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Involucrado>> GetInvolucrados()
        {
            var db = dbConnection();

            var sql = @"SELECT * FROM Involucrado";
            return await db.QueryAsync<Involucrado>(sql.ToString(), new { });
        }

        public async Task<bool> Insertar(Involucrado involucrado)
        {
            var db = dbConnection();
            var sql = @"INSERT INTO Involucrado(Nombre,Apellido,Telefono,Correo,Cedula,CasoInvolucrado)
                 VALUES(@Nombre,@Apellido,@Telefono,@Correo,@Cedula,@CasoInvolucrado)";

            var resultado = await db.ExecuteAsync(sql.ToString(), new 
            {    involucrado.Nombre,
                involucrado.Apellido,
                involucrado.Telefono, 
                involucrado.Correo, 
                involucrado.Cedula,
                involucrado.CasoInvolucrado
            });

            return resultado > 0;
        }
    }
}
