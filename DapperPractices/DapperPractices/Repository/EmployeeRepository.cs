using System;
using System.Collections.Generic;
using System.Data;
using DapperPractices.Models;
using Dapper;
using System.Linq;
using System.Data.SqlClient;
namespace DapperPractices.Repository
{
    public class EmployeeRepository
    {
        public SqlConnection con;
        private void Connection()
        {
            string cs = ConfigurationManager.ConnectionString["SUDHARSHAN"].ToString();
            con = new SqlConnection(cs);
        }
        public void AddEmployee(ErrorViewModel objEmp)
        {
            try
            {
                Connection();
                con.Open();
                con.Execute("AddNewEmpDetails", objEmp, commandType: CommandType.StoredProcedure);
                con.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        internal void AddEmployee(Employee emp)
        {
            throw new NotImplementedException();
        }

        public List<Employee> GetAllEmployees()
        {
            try
            {
                Connection();
                con.Open();
                IList<Employee> EmployeeList = SqlMapper.Query<Employee>(
                                  con, "GetEmployees").ToList();
                con.Close();
                return EmployeeList.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void UpdateEmployee(Employee objUpdate)
        {
            try
            {
                Connection();
                con.Open();
                con.Execute("UpdateEmpDetails", objUpdate, commandType: CommandType.StoredProcedure);
                con.Close();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public bool DeleteEmployee(int Id)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@EmployeeID", Id);
                Connection();
                con.Open();
                con.Execute("DeleteEmpById", param, commandType: CommandType.StoredProcedure);
                con.Close();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
