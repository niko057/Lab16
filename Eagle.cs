using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab16
{
    internal class Eagle :Bird
    {
        public string Fly { get; set; }

        public void Info()
        {
            Console.WriteLine("Qartal uca bilir");
        }
    }
}
