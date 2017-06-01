using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace WorkWithDB
{
    public class Context
    {
        private OleDbConnection conn;
        private Employees obj;

        public Context(string DbConnString)
        {
            //IDbConnection connection = new OleDbConnection(DbConnString); // IDbConnection- класс
            conn = new OleDbConnection(DbConnString);
        
        }

        public OleDbConnection ConnectionDb
        {
            get { return conn; }
        }

       public List<Employees> GetListOfEmployees()
        {
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Select * from Employees";

            // var result = cmd.ExecuteReader();
            // result.Close();


            List<Employees> employee = new List<Employees>();


            OleDbDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Employees emp = new Employees();

                emp.Name = reader.GetString(1);
                emp.Employee_ID = reader.GetInt32(0);
                emp.Department_IDREF = reader.GetInt32(2);

                employee.Add(emp);

            }

            return employee;


           


        }


    }
}
