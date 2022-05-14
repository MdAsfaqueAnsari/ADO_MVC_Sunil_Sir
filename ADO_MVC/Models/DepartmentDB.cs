using ADO_MVC.ViewModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ADO_MVC.Models
{
    public class DepartmentDB
    {
        private DbConfig db = new DbConfig();
        public List<Department> GetAllDepartment()
        {
            SqlCommand cmd = new SqlCommand("sp_department", db.sql);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter sqlpra = new SqlParameter();
            sqlpra.ParameterName = "@action";
            sqlpra.Value = "select";
            sqlpra.DbType = DbType.String;
            cmd.Parameters.Add(sqlpra);

            if (db.sql.State == ConnectionState.Closed)
                db.sql.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            List<Department> departmentlist = new List<Department>();
            while (reader.Read())
            {
                Department objdept = new Department();
                objdept.Id = (int)reader[0];
                objdept.Name = reader[1].ToString();
                departmentlist.Add(objdept);

            }
            db.sql.Close();
            return departmentlist;

        }
    }
}