using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayFun
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> vs = new List<string>();
            string account = "svcs-rch-00";

            for(int i = 0; i < 40; i++)
            {
                string newAccount = account + i.ToString();
                vs.Add(newAccount);
                //Console.WriteLine(newAccount);
            }




            Console.ReadKey(); 

        }
    }
}
