using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityManagementApp.Model;

namespace UniversityManagementApp.DAL
{
    public class StudentGateway
    {
        string connectionString = ConfigurationManager.ConnectionStrings["UniversityConString"].ConnectionString;
        public Student GetStudentByRegNo(string regNo)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["UniversityConString"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);

            string query = "SELECT * FROM Students WHERE RegNo = '" + regNo + "'";

            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            Student student = null;


            while (reader.Read())
            {

                if (student == null)
                {
                    student = new Student();
                }

                student.Id = int.Parse(reader["ID"].ToString());
                student.Name = reader["Name"].ToString();
                student.RegNo = reader["RegNo"].ToString();
                student.Address = reader["Address"].ToString();
            }

            reader.Close();
            connection.Close();

            return student;
        }

        public Student GetStudentById(int studentId)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["UniversityConString"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);

            string query = "SELECT * FROM Students WHERE ID = '" + studentId + "'";

            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            Student student = null;


            while (reader.Read())
            {

                if (student == null)
                {
                    student = new Student();
                }

                student.Id = int.Parse(reader["ID"].ToString());
                student.Name = reader["Name"].ToString();
                student.RegNo = reader["RegNo"].ToString();
                student.Address = reader["Address"].ToString();
            }

            reader.Close();
            connection.Close();

            return student;
        }

        public int Insert(Student student)
        {
            
            SqlConnection connection = new SqlConnection(connectionString);

            string query = "INSERT INTO Students VALUES('" + student.Name + "', '" + student.RegNo + "', '" + student.Address + "', '" + student.DepartmentId + "')";
            //insert student
            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();

            int rowAffected = command.ExecuteNonQuery();

            connection.Close();

            return rowAffected;
        }

        public int Update(Student student)
        {

            SqlConnection connection = new SqlConnection(connectionString);

            string query = "UPDATE Students SET Name = '" + student.Name + "', Address= '" + student.Address +"', DepartmentId= '" + student.DepartmentId+ "' WHERE ID =" + student.Id;
            //insert student
            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();

            int rowAffected = command.ExecuteNonQuery();

            connection.Close();

            return rowAffected;
            
        }

        public List<Student> GetAllStudents()
        {
            SqlConnection connection = new SqlConnection(connectionString);

            string query = "SELECT * FROM Students";

            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();

            SqlDataReader reader = command.ExecuteReader();

            List<Student> students = new List<Student>();

            while (reader.Read())
            {
                Student student = new Student();
                student.Id = int.Parse(reader["ID"].ToString());
                student.Name = reader["Name"].ToString();
                student.RegNo = reader["RegNo"].ToString();
                student.Address = reader["Address"].ToString();
                student.DepartmentId =reader["DepartmentId"].ToString()=="" ? (int?) null: int.Parse(reader["DepartmentId"].ToString());
                students.Add(student);
            }
            reader.Close();
            connection.Close();

            return students;
        }

        public int Delete(Student student)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            string query = "DELETE FROM Students WHERE ID ='" + student.Id + "'";

            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            int rowAffected = command.ExecuteNonQuery();

            connection.Close();

            return rowAffected;
        }

        public List<Student> GetStudentsBySearchCriteria(string regNo, string name)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            string query = "SELECT * FROM Students";

            if (name!="" && regNo!="")
            {
                query = "SELECT * FROM Students WHERE RegNo = '" + regNo + "'"+"AND Name = '" + name + "'";
            }
            else if (name != "")
            {
                query = "SELECT * FROM Students WHERE Name = '" + name + "'";
            }
            else if (regNo != "")
            {
                query = "SELECT * FROM Students WHERE RegNo = '" + regNo + "'";
            }

            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();

            SqlDataReader reader = command.ExecuteReader();

            List<Student> students = new List<Student>();

            while (reader.Read())
            {
                Student student = new Student();
                student.Id = int.Parse(reader["ID"].ToString());
                student.Name = reader["Name"].ToString();
                student.RegNo = reader["RegNo"].ToString();
                student.Address = reader["Address"].ToString();
                student.DepartmentId = reader["DepartmentId"].ToString() == "" ? (int?)null : int.Parse(reader["DepartmentId"].ToString());

                students.Add(student);
            }
            reader.Close();
            connection.Close();

            return students;
        }

        public List<StudentDepartmentView> GetAllStudentDepartment()
        {
            SqlConnection connection = new SqlConnection(connectionString);

            string query = "SELECT * FROM StudentDepartment";

            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();

            SqlDataReader reader = command.ExecuteReader();

            List<StudentDepartmentView> students = new List<StudentDepartmentView>();

            while (reader.Read())
            {
                StudentDepartmentView student = new StudentDepartmentView();
                student.Id = int.Parse(reader["ID"].ToString());
                student.Name = reader["Name"].ToString();
                student.RegNo = reader["RegNo"].ToString();
                student.Address = reader["Address"].ToString();
                student.DepartmentId = reader["DepartmentId"].ToString() == "" ? (int?)null : int.Parse(reader["DepartmentId"].ToString());
                student.DepartmentName = reader["DepartmentName"].ToString();
                students.Add(student);
            }
            reader.Close();
            connection.Close();

            return students;
        }
    }
}
