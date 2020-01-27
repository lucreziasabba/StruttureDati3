using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileCopia
{
    class Program
    {
        private const string file = "file.txt";
        static void Main(string[] args)
        {
            using (StreamReader x = new StreamReader(file, Encoding.UTF8))
            {

            }
        }
    }
}
