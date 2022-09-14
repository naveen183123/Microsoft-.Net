using Dapper;
using SP_Practice.Common;
using SP_Practice.IServices;
using SP_Practice.Model;
using System.Data;
using System.Data.SqlClient;

namespace SP_Practice.Services
{
    public class StudentService : IStudentService
    {
        Student _oStudent = new Student();
        List<Student> _oStudents = new List<Student>();
        public Student Save(Student oStudent)
        {
            _oStudent = new Student();
            try
            {
                int OperationType = Convert.ToInt32(oStudent.StudentId == 0 ? OperationType.Insert : OperationType.Update);
               using (var con = new SqlConnection(Global.ConnectionString))
               {
                    if (con.State == ConnectionState.Closed) con.Open();
                    var oStudents = con.Query<Student>("SP_Student", this.SetParameters(oStudent, OperationType), commandType: CommandType.StoredProcedure);
                    if(oStudent!=null&&oStudent.Count()>0)
                    {
                        _oStudent = oStudents.FirstOrDefault();
                    }
               }
                return _oStudents;
            }
            catch(Exception e)
            {
                _oStudent.Message = e.Message;
            }
            return _oStudent;
        }

        private object SetParameters(Student oStudent, int operationType)
        {
            throw new NotImplementedException();
        }
    }
}
