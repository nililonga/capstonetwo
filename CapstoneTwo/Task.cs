using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapstoneTwo
{
    class Task
    {
        private string v1;
        private int v2;

        public string TaskName { get; set; }

        public int TaskNumber { get; set; }

        public DateTime DueDate { get; set; }

        public Task(string taskName, int taskNumber)
        {
            TaskNumber = taskNumber;
            TaskName = taskName;
            DueDate = DateTime.Now.AddDays(14);



        }
        /*
        public Task(string v1, int v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }
        */
    }
}
