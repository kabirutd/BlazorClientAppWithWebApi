using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.Runtime.InteropServices;
using Dapper;

namespace Infrastructure.Data
{
    public class StudentRepository: IAsyncRepository<Student>
    {
        public Task<Student> AddAsync(Student entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> CountAsync(ISpecification<Student> spec)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Student entity)
        {
            throw new NotImplementedException();
        }

        //Task<Student> IAsyncRepository<Student>.GetByIdAsync(int id)
        //{
        //    throw new NotImplementedException();
        //}

        public async Task<Student> GetByIdAsync(int id)
        {
            var vdbconnectionstring = "";
            var sqlquery = "";
            var dbconnectionstring = "";
            string vsqlquery = " ";

            if (sqlquery != "" && sqlquery != null)
            {

                vsqlquery = sqlquery;

            }

            if (dbconnectionstring != "" && dbconnectionstring != null)
            {

                vdbconnectionstring = dbconnectionstring;

            }

            else
            {
                //To Do: Throw no connection error
                //vdbconnectionstring = DataUtility.GetDBConnectionString(site, devenvironment);
            }

            SqlConnection dbConnection = new SqlConnection(vdbconnectionstring);

            using (IDbConnection conn = dbConnection)

            {
                //TO DO - Get rid of VendorQualityPerformanceRepository.cs since it's doign the same
                conn.Open();
                var result = await conn.QueryAsync<Student>(vsqlquery, commandTimeout: conn.ConnectionTimeout);
                return result.ToList();

            }
        }

        public Task<IReadOnlyList<Student>> ListAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<Student>> ListAsync(ISpecification<Student> spec)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Student entity)
        {
            throw new NotImplementedException();
        }

      

        //Task<Student> IAsyncRepository<Student>.GetByIdAsync(int id)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
