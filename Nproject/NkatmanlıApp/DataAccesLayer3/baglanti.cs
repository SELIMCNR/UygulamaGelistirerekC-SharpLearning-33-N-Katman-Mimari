using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DataAccesLayer3
{
    public  class baglanti
    {
      public static  SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-BC3LOP2\SELM;Initial Catalog=DbPersonel;Integrated Security=True;");
    }
}
