using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace carService
{
    abstract class Timetable
    {
        public string time;
        public string Visit(string time)
        {
            time = File.ReadAllText(@"time.txt");
            this.time = time;
            return time;
        }
    }
}
