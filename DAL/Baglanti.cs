using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL
{
    public class Baglanti
    {
        public static SqlConnection bgl= new SqlConnection (@"Data Source=DESKTOP-B4L6VS5\SQLEXPRESS; Initial Catalog = OOPliPersonelDB; Integrated Security = True");
    }
}
