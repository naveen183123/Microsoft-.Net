using SP_Practice.Model;

namespace SP_Practice.IServices
{
    public class IStudentService
    {
        Student Save(Student oStudent);
        List<Student> Gets();
        Student Get(int StudentId);

    }
}
