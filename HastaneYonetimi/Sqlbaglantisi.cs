using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneYonetimi
{
    public class Sqlbaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-3HV2966;Initial Catalog=HastaneProje;Integrated Security=True;Trust Server Certificate=True");
            baglan.Open();
            return baglan;
        }
    }
}
