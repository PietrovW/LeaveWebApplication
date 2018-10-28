using Dapper;
using Leave.DAL.Context.Base;
using Leave.DAL.Models;
using Leave.DAL.Models.Base;
using Leave.DAL.Repositories.Base;
using Leave.DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Leave.DAL.Repositories
{
    public class EmployeRepository : BaseRepository, IEmployeRepository
    {
        public EmployeRepository(IDbContextBase dbContext, string tableName) :base(dbContext,tableName)
        {

        }

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
                connection.Close();
            }

            string sql = "SELECT TOP 10 * FROM OrderDetails";

            using (var connection = new SqlCeConnection("Data Source=SqlCe_W3Schools.sdf"))
            {
                var orderDetails = await connection.QueryAsync<OrderDetail>(sql).Result.ToList();

                Console.WriteLine(orderDetails.Count());

                FiddleHelper.WriteTable(orderDetails);
            }

            throw new NotImplementedException();
        }

        public Task<EmployeModel> FindByIDAsync(Guid id)
        {
            IDbConnection connection = null;
            IDbTransaction transaction = null;
            try
            {
                string speakerQuery = "DELETE FROM Events WHERE SpeakerId = @SpeakerId";
                connection = new SqlConnection(connectionString);

                transaction = connection.BeginTransaction();

                int rowsAffected = await connection.ExecuteAsync(speakerQuery, new { SpeakerId = id }, transaction);

                transaction.Commit();
                return new ResultCode();
            }
            catch (Exception ex)
            {
                try
                {
                    transaction.Rollback();
                    return new ResultCode(ex);
                }
                catch
                {
                    throw;
                }

            }
            finally
            {
                connection.Close();
                connection.Dispose();
                transaction.Dispose();
            }
        }

        public async Task<ResultCode> RemoveAsync(Guid id)
        {
            IDbConnection connection = null;
            IDbTransaction transaction = null;
            try
            {
                string speakerQuery = "DELETE FROM Events WHERE SpeakerId = @SpeakerId";
                connection = new SqlConnection(connectionString);

                transaction = connection.BeginTransaction();

                int rowsAffected = await connection.ExecuteAsync(speakerQuery, new { SpeakerId = id }, transaction);

                transaction.Commit();
                return new ResultCode();
            }
            catch (Exception ex)
            {
                try
                {
                    transaction.Rollback();
                    return new ResultCode(ex);
                }
                catch
                {
                    throw;
                }

            }
            finally
            {
                connection.Close();
                connection.Dispose();
                transaction.Dispose();
            }

        }
    }


    public Task<ResultCode> UpdateAsync(EmployeModel entity)
    {

        IDbConnection connection = null;
        IDbTransaction transaction = null;
        try
        {
            string speakerQuery = "DELETE FROM Events WHERE SpeakerId = @SpeakerId";
            connection = new SqlConnection(connectionString);

            transaction = connection.BeginTransaction();

            int rowsAffected = await connection.ExecuteAsync(speakerQuery, new { SpeakerId = id }, transaction);

            transaction.Commit();
            return new ResultCode();
        }
        catch (Exception ex)
        {
            try
            {
                transaction.Rollback();
                return new ResultCode(ex);
            }
            catch
            {
                throw;
            }

        }
        finally
        {
            connection.Close();
            connection.Dispose();
            transaction.Dispose();
        }
    }
}

