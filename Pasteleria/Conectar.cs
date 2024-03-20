using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace Conexion
{



    public class Conectar
    {
        public SqlConnection connect = new SqlConnection();
   

        public Conectar(String user, String pass)
        {
            try
            {

                connect = new SqlConnection("Server=JOSUEB;Database=PasteleriaBD;UID=" + user + ";PWD=" + pass);
                connect.Open();
            }
            catch (Exception)
            {


            }
        }




    }



}


