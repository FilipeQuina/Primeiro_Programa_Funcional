using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primeiro_programa_funcional
{
    class Usuarios
    {
        Util u = new Util();
        //*Operaçoes preparadas*//
        public const String strSelecionar = "SELECT COUNT(*) FROM tb_usuarios WHERE login = @login AND senha =@senha";
        //*Operaçoes preparadas*//

        //*Funçoes*//
        public bool VerificarLogin(String login, String senha)
        {
            using (SqlConnection objCnx = new SqlConnection(u.Bd_conexao))//Instancia uma nova conexão
            {
                using (SqlCommand objCmd = new SqlCommand(strSelecionar, objCnx))//Instancia um novo comando
                {
                    objCmd.Parameters.AddWithValue("@login", login);
                    objCmd.Parameters.AddWithValue("@senha", senha);
                    objCnx.Open();
                    int qte= (int)objCmd.ExecuteScalar();//(int) serve pra converter um objeto para uma int
                    if (qte > 0)
                    {
                        objCnx.Close();
                        return true;
                    }
                    else
                    {
                        objCnx.Close();
                        return false;
                    }
                    
                }
                
            }
        
        }
        //*Funçoes*//

    }
}

        


