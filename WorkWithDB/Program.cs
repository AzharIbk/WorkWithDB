using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkWithDB
{
    class Program
    {
        static readonly string AppPath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
        static readonly string DbPath = Path.Combine(AppPath, "Data", "Products.accdb");
        static readonly string DbConnString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + DbPath + "';Persist Security Info=False;";



      
   
        static void Main(string[] args)
        {
         
            Context context = new Context(DbConnString);
            context.ConnectionDb.Open();
          


            






            Console.ReadKey();

        }
    }
}
