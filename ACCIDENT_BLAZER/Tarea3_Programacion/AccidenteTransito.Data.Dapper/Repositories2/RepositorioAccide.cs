using AccidenteTransito.Model;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace AccidenteTransito.Data.Dapper.Repositories2
{
    public class RepositorioAccide : IRepositorioAccide
    {
        private string ConnectionString;
        public RepositorioAccide(string conectionString)
        {
            ConnectionString = conectionString;
        }
        protected SqlConnection dbConnection()
        {
            return new SqlConnection(ConnectionString);
        }

        Task<Accidente> IRepositorioAccide.GetInvolucrado(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Insertar (Accidente accidente)
        {
            var db = dbConnection();
            var sql = @"INSERT INTO Accidente(Fecha_Hora,Lugar,Latitud,Longitud)
                          VALUES (@Fecha_Hora,@Lugar,@Latitud,@Longitud)";

            var resultado = await db.ExecuteAsync(sql.ToString(), new
            {
                accidente.Fecha_Hora,
                accidente.Lugar,
                accidente.Latitud,
                accidente.Longitud,
            }) ;

            return resultado > 0;
        }

        public async Task<IEnumerable<Accidente>> GetAccidenteTransito()
        {
            var db = dbConnection();

            var sql = @"SELECT * FROM Accidente";
            return await db.QueryAsync<Accidente>(sql.ToString(), new { });
        }
    }
}
