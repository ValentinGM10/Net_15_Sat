using System;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;

namespace LeerCrearArchivoTexto
{
    public  class UsuarioAC
    {
        public static int CrearCuenta (string pUsuario, string pNombre, string pContraseña)
        {
            string strConexion = ConexionBD.CConexion;
            SqlConnection Conn = new SqlConnection(strConexion);

            int rowsAffected = 0;

            try
            {
                Conn.Open();

//                string sql = string.Format("Insert into Tblc_UsuariosCargaP (Login, Nombre, Password) Values ('{0}', '{1}',  PwdEncrypt('{2}'))", pUsuario, pNombre, pContraseña);
                string sql = string.Format("Insert into Tblc_UsuariosCargaAP (Login, Nombre, Password) Values ('{0}', '{1}',  '{2}')", pUsuario, pNombre, pContraseña);
                Console.Write(sql);

    //            SqlCommand Comando = new SqlCommand(string.Format("Insert into Tblc_UsuariosCarga (Login, Nombre, Password) Values ('{0}', '{1}',  PwdEncrypt('{2}'))", pUsuario, pNombre, pContraseña), Conn);
                SqlCommand Comando = new SqlCommand(sql, Conn);
                //  PwdEncrypt
                rowsAffected = Comando.ExecuteNonQuery();
                Conn.Close();
            }
            catch (Exception Error)
            {
                string MsgError = Error.Message;
                return rowsAffected;
            }
            return rowsAffected;

        }

        public static int Autentificar (string pUsuario, string pContraseña, ref string msg )
        {
            int resultado = -1;

            string strConexion = ConexionBD.CConexion;

            //          string sql =  string.Format("Select * from Tblc_UsuariosCargaAP Where Login = '{0}' and PwdCompare('{1}', Password) = 1", pUsuario, pContraseña);
            string sql = string.Format("Select * from Tblc_UsuariosCargaAP Where Login = '{0}' and Password = '{1}' ", pUsuario, pContraseña);

            Console.Write(sql);

            SqlConnection Conexion = new SqlConnection(strConexion);

            try
            {
                Conexion.Open();
                //  SqlConnection conexion = ConexionBD.CConexion();
                SqlCommand comando = new SqlCommand(sql, Conexion);
                //  "Select * from Tblc_UsuariosCarga Where Login = '{0}' and PwdCompare('{1}', Password) = 1", pUsuario, pContraseña), Conexion);

                SqlDataReader reader = comando.ExecuteReader();
                if (reader != null)
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            resultado = 50;
                        }
                    }
                    else
                    {
                        msg = " EL  LOGIN  O PASSWORD  SON INCORRECTOS...";
                    }
                }
                else
                {
                    msg = " EL  LOGIN  O PASSWORD  SON INCORRECTOS...";
                }
                Conexion.Close();
                
            }
            catch (Exception ex)
            {
                msg = ex.Message;
                return resultado;
                
            }

            return resultado;


            //using (SqlConnection con = new SqlConnection(strConexion))
            //{
            //    using (SqlCommand cmd = new SqlCommand("DELETE FROM RQp_Requerimientos_SAT_Aux", con))
            //    {
            //        cmd.CommandType = CommandType.Text;
            //        //   cmd.Parameters.AddWithValue("@Name", name);
            //        con.Open();
            //         rowsAffected = cmd.ExecuteNonQuery();
            //        con.Close();
            //    }
            //}


        }


        public string CodificarPassword(string originalPassword)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] originalBytes = ASCIIEncoding.Default.GetBytes(originalPassword);
            byte[] encodedBytes = md5.ComputeHash(originalBytes);
            return Convert.ToBase64String(encodedBytes);
        }


        //using (SqlConnection con = new SqlConnection(strConexion))
        //{
        //    using (SqlCommand cmd = new SqlCommand("DELETE FROM RQp_Requerimientos_SAT_Aux", con))
        //    {
        //        cmd.CommandType = CommandType.Text;
        //        //   cmd.Parameters.AddWithValue("@Name", name);
        //        con.Open();
        //         rowsAffected = cmd.ExecuteNonQuery();
        //        con.Close();
        //    }
        //}

    }
}
