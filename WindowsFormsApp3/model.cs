using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    internal class model
    {
        public int number { get; set; }
        public string date { get; set; }
        public int invnumb { get; set; }
        public string objname { get; set; }
        public int count { get; set; }
        public double price { get; set; }
        public void save()
        {
            Console.WriteLine("Saved");
        }
            
    }
}
