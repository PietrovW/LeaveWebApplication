using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Dapper;
using Leave.DAL.Helper;
using Leave.DAL.Models.Base;

namespace Leave.DAL.Extensions
{
    public static class DapperExtensions
    {
        public async static Task<ReturnCode> ExecuteNonQueryAsync(
            this SqlConnection connection,
            string commandText, object param = null, IsolationLevel iso = IsolationLevel.Chaos)
        {

            ReturnCode result = ReturnCode.DEFAULT;
            if (connection == null)
            {
                throw new NullReferenceException("Please provide a connection");
            }


            if (connection.State != ConnectionState.Open)
            {
                await connection.OpenAsync();
            }

            var transaction = connection.BeginTransaction(iso);
            try
            {

                 await SqlMapper.ExecuteAsync(connection, commandText, param, transaction);
                transaction.Commit();
                result = ReturnCode.SUCCEEDED;
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
                try
                {
                    transaction.Rollback();
                }
                catch
                {
                    throw;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                result = ReturnCode.ERROR;
                try
                {
                    transaction.Rollback();
                }
                catch
                {
                    throw;
                }
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection.Dispose();
            }

            return result;
        }

        public async static Task<Tuple<ReturnCode, IEnumerable<T>>> SelectAsync<T>(
           this SqlConnection connection,
           string TableName, Expression<Func<T, bool>> predicate = null, string where = null, object param = null, IsolationLevel iso = IsolationLevel.Chaos)
        {

            ReturnCode resultCode = ReturnCode.DEFAULT;
            IEnumerable<T> results = null;
            QueryResult result = null;
            if (predicate != null)
            {
                result = DynamicQuery.GetDynamicQuery(TableName, predicate);
            }
            else if (predicate == null)
            {
                result = new QueryResult(string.Format("SELECT * FROM  {0}", TableName), null);
            }
            else if (where != null && param != null)
            {
                result = new QueryResult(string.Format("SELECT * FROM {0} WHERE ID=@ID", TableName), param);
            }


            if (connection == null)
            {
                throw new NullReferenceException("Please provide a connection");
            }


            if (connection.State != ConnectionState.Open)
            {
                await connection.OpenAsync();
            }

            var transaction = connection.BeginTransaction(iso);
            try
            {
                results = await SqlMapper.QueryAsync<T>(connection, result.Sql, (object)result.Param);
                transaction.Commit();
                resultCode = ReturnCode.SUCCEEDED;
            }
            catch (Exception ex)
            {

                resultCode = ReturnCode.ERROR;
                Console.WriteLine(ex.Message);
                try
                {
                    transaction.Rollback();
                }
                catch
                {
                    throw;
                }
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection.Dispose();
            }

            return new Tuple<ReturnCode, IEnumerable<T>>(resultCode, results);
        }

        public static async Task<Tuple<ReturnCode, T>> InsertAsync<T>(this SqlConnection connection, string tableName, dynamic param, IsolationLevel iso = IsolationLevel.Chaos)
        {
            ReturnCode resultCode = ReturnCode.DEFAULT;
            if (connection == null)
            {
                throw new NullReferenceException("Please provide a connection");
            }


            if (connection.State != ConnectionState.Open)
            {
                await connection.OpenAsync();
            }
            IEnumerable<T> result = null;
            var transaction = connection.BeginTransaction(iso);
            try
            {
                result = await SqlMapper.QueryAsync<T>(connection, sql: DynamicQuery.GetInsertQuery(tableName, param), param: transaction);
                transaction.Commit();
                resultCode = ReturnCode.SUCCEEDED;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                resultCode = ReturnCode.ERROR;
                try
                {
                    transaction.Rollback();
                }
                catch
                {
                    throw;
                }
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection.Dispose();
            }

            return new Tuple<ReturnCode,T>(resultCode,result.FirstOrDefault());
        }

        public static async Task<ReturnCode> UpdateAsync(this SqlConnection connection, string tableName, dynamic param, IsolationLevel iso = IsolationLevel.Chaos)
        {
            ReturnCode result = ReturnCode.DEFAULT;
            if (connection == null)
            {
                throw new NullReferenceException("Please provide a connection");
            }


            if (connection.State != ConnectionState.Open)
            {
                await connection.OpenAsync();
            }

            var transaction = connection.BeginTransaction(iso);
            try
            {
                SqlMapper.ExecuteAsync(connection, DynamicQuery.GetUpdateQuery(tableName, param), transaction);
                transaction.Commit();
                result = ReturnCode.SUCCEEDED;
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
                try
                {
                    transaction.Rollback();
                }
                catch
                {
                    throw;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                result = ReturnCode.ERROR;
                try
                {
                    transaction.Rollback();
                }
                catch
                {
                    throw;
                }
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection.Dispose();
            }
            return result;
        }
    }
}

