using School.Services.Models;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

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
                string cmdText = "GetAllAndId";
                SqlCommand command = new SqlCommand(cmdText, connection);
                command.CommandType = CommandType.StoredProcedure;

                connection.Open();
                var Reader = command.ExecuteReader();

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

        public List<Student> GetById(int id)
        {
            var student = new List<Student>();
            using (var connection = new SqlConnection(connectionstring))
            {
                string cmdText = "GetAllAndId";

                var command = new SqlCommand(cmdText, connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("Id", id);

                connection.Open();

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var std = new Student
                        {
                            Id = (int)reader["Id"],
                            Name = (string)reader["Name"],
                            RollNo = (int)reader["RollNo"],
                            Address = (string)reader["Address"]
                        };
                        student.Add(std);
                    }
                }
            }
            return student;
        }

        public void Update(Student student)
        {
          
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
        
        }

        public void Delete(int id)
        {
            using (var connection = new SqlConnection(connectionstring))
            {
                string cmdText = "DeleteId";
                SqlCommand command  = new SqlCommand(cmdText, connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@Id", id);

                connection.Open();
                var reader = command.ExecuteReader();   
               
            }

        }
    }
}
