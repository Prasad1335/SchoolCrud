using School.Services.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Services
{
    public class StudentServices
    {
        readonly string connectionstring = ConfigurationManager.ConnectionStrings["SchoolDatabase"].ConnectionString;

        public List<Student> GetAll()
        {
            var students = new List<Student>();
            using (var connection = new SqlConnection(connectionstring))
            {
                string cmdText = "select * from Students";
                SqlCommand command = new SqlCommand(cmdText, connection);  
                connection.Open();
                var Reader= command.ExecuteReader();

                while (Reader.Read())
                {
                    Student student = new Student
                    {
                        Id = (int)Reader["Id"],
                        Name = (string)Reader["Name"],
                        RollNo = (int)Reader["RollNo"],
                        Address = (string)Reader["Address"]
                    };
                    students.Add(student);
                }
            }
                return students;

        }

        public List<Student> Add(Student student)
        {
            var students = new List<Student>();
            using (var connection = new SqlConnection(connectionstring))
            {
                string cmdText = "InsertUpdate";
                SqlCommand command = new SqlCommand(cmdText, connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@Name", student.Name);
                command.Parameters.AddWithValue("@RollNo", student.RollNo);
                command.Parameters.AddWithValue("@Address", student.Address);

                connection.Open();
                var Reader = command.ExecuteNonQuery();
            }
            return students;
        }

        public List<Student> Update(Student student)
        {
            var students = new List<Student>();
            using (var connection = new SqlConnection(connectionstring))
            {
                string cmdText = "InsertUpdate";
                SqlCommand command = new SqlCommand(cmdText, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Id", student.Id);
                command.Parameters.AddWithValue("@Name", student.Name);
                command.Parameters.AddWithValue("@RollNo", student.RollNo);
                command.Parameters.AddWithValue("@Address", student.Address);

                connection.Open();
                var Reader = command.ExecuteNonQuery();
            }
            return students;
        }
    }
}
