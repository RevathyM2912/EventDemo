using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDemo
{
    public class StudentData
    {
        public string? Name { get; set; }
    }
    internal class StudentTransfer
    {
        public event EventHandler? StudentEvent1;//Event without data
        public event EventHandler<StudentData>? StudentEvent2;//Event with data
        StudentData studentData = new StudentData { Name = "Rani Rejil" };
        public void StudentRemove()
        {
            //Invoke the events
            StudentEvent1?.Invoke(this, EventArgs.Empty);
            StudentEvent2?.Invoke(this, studentData);
        }
    }
}
