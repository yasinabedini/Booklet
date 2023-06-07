using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_record_etc
{
    public sealed class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Family { get; }
        public  DateTime DateTime { get; set; }
    }

}
