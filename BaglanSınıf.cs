using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
namespace EmlakOtomasyon
{
    class BaglanSınıf
    {
        public string Adres = System.IO.File.ReadAllText(@"C:\Sunucu.txt");
    }
}
