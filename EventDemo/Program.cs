using EventDemo;

internal class Program
{
    private static void Main(string[] args)
    {
        StudentTransfer student = new StudentTransfer();
        DepartmentClass departmentObject = new DepartmentClass(student);
        student.StudentRemove();
    }
}