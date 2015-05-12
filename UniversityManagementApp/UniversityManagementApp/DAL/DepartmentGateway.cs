using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityManagementApp.Model;

namespace UniversityManagementApp.DAL
{
    public class DepartmentGateway
    {
        string connectionString = ConfigurationManager.ConnectionStrings["UniversityConString"].ConnectionString;
        public int Insert(Department department)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            string query = "INSERT INTO Departments VALUES('" + department.Name + "')";
            //insert student
            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();

            int rowAffected = command.ExecuteNonQuery();

            connection.Close();

            return rowAffected;
        }

        public List<Department> GetAllDepartments()
        {
            SqlConnection connection = new SqlConnection(connectionString);

            string query = "SELECT * FROM Departments";

            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();

            SqlDataReader reader = command.ExecuteReader();

            List<Department> departments = new List<Department>();

            while (reader.Read())
            {
                Department department = new Department();
                department.Id = int.Parse(reader["Id"].ToString());
                department.Name = reader["Name"].ToString();


                departments.Add(department);
            }
            reader.Close();
            connection.Close();

            return departments;
        }
    }
}
