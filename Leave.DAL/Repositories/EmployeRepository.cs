using Leave.DAL.Models;
using Leave.DAL.Models.Base;
using Leave.DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Leave.DAL.Repositories
{
    public class EmployeRepository : IEmployeRepository
    {
        public Task<ResultCode> AddAsync(EmployeModel entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<EmployeModel>> AllAsync()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<EmployeModel>> FindAllAsync(Expression<Func<EmployeModel, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public async Task<EmployeModel> FindAsync(Expression<Func<EmployeModel, bool>> predicate)
        {

            var connection = new SQLConnection("myConnectionString");

            try
            {
                connection.Open(); // synchronously open a connection to the database 

                var p = new DynamicParameters();
                p.Add("Id", Id, DbType.Guid);
                var people = c.Query<Person>(
                    sql: "sp_Person_GetById",
                    param: p,
                    commandType: CommandType.StoredProcedure);
                return people.FirstOrDefault();
            }
            catch
            {
                // handle exception
            }
            finally
            {
                // Close the connection explicitly, to make sure it gets closed.
                // Otherwise, we might start leaking connections.
                connection.Close();
            }

            string sql = "SELECT TOP 10 * FROM OrderDetails";

            using (var connection = new SqlCeConnection("Data Source=SqlCe_W3Schools.sdf"))
            {
                var orderDetails =await connection.QueryAsync<OrderDetail>(sql).Result.ToList();

                Console.WriteLine(orderDetails.Count());

                FiddleHelper.WriteTable(orderDetails);
            }

            throw new NotImplementedException();
        }

        public Task<EmployeModel> FindByIDAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<ResultCode> RemoveAsync(Guid id)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString;

            try

            {

                using (IDbConnection connection = new SqlConnection(connectionString))

                {

                    string speakerQuery = "DELETE FROM Speakers WHERE SpeakerId = @SpeakerId";

                    string eventQuery = "DELETE FROM Events WHERE SpeakerId = @SpeakerId";

                    IDbTransaction transaction = connection.BeginTransaction();

                    int rowsAffected = await connection.ExecuteAsync(speakerQuery, new { SpeakerId = speaker.SpeakerId }, transaction);

                    rowsAffected += await connection.ExecuteAsync(eventQuery, new { SpeakerId = speaker.SpeakerId }, transaction);

                    transaction.Commit();

                    return rowsAffected;

                }

            }

            catch (Exception ex)

            {

                Console.WriteLine(ex.Message);

                return -1;

            }

        }
    }

        public Task<ResultCode> UpdateAsync(EmployeModel entity)
        {


            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["myDbConnection"].ConnectionString))
            {
                string selectQuery = @"SELECT * FROM [dbo].[Customer] WHERE FirstName = @FirstName";

                var result = db.Query(selectQuery, new
                {
                    customerModel.FirstName
                });
            }


            throw new NotImplementedException();

        }
    }
}
