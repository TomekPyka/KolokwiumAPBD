using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolokwiumAPBD.Services
{
    interface SqlServerTeamsDbService : ITeamsDbService
    {
        private readonly string connectionString = "Data Source=db-mssql;Initial Catalog=s12343;Integrated Security=True";
        private SqlConnection SqlConnection => new SqlConnection(connectionString);

        private readonly SqlServerStudentDbContext _dbContext;

        public SqlServerStudentDbService(SqlServerStudentDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public int CreatePlayer(Player Player)
        {
            
        }
}
