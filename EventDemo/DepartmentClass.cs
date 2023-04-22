using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDemo
{
    internal class DepartmentClass
    {
        private StudentTransfer student1Transfer;
        public DepartmentClass(StudentTransfer student) 
        {
            this.student1Transfer = student;
            //Consume the events
            student1Transfer.StudentEvent1 += StudentDeptRemove;//Without data
            student1Transfer.StudentEvent2 += StudentMoveOffice;//With data
        }
        public void StudentDeptRemove(object? sender, EventArgs e) 
        {
            Console.WriteLine("Department: Student remove process relate to department");

        }
        public void StudentMoveOffice(object? sender,StudentData data)
        {
            Console.WriteLine($"Department: {data.Name} removed and move to office");
        }
    }
}
