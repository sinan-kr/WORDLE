using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace MemoWords
{
    internal class sqlbaglantısı
    {
public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=LAPTOP-LG5J83BT\\SQLEXPRESS;Initial Catalog=\"ingilizce kelime\";Integrated Security=True");
            baglan.Open();
            return baglan;
        }      
    }
}
