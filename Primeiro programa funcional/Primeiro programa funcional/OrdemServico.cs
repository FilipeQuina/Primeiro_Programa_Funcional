using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primeiro_programa_funcional
{
    class OrdemServico
    {
        Util u = new Util();

        public const string strVisualizarAbertos = "SELECT codOs, prioridade, dataAbertura, descricao, manutentor FROM ordemServico WHERE dataFechamento IS NULL";
        public string strAlterar = "UPDATE ordemServico SET prioridade=@prioridade, descricao=@descricao, manutentor=@manutentor WHERE codOs=@codOs";
        public const string strCriar = "INSERT INTO ordemServico (codOs,descricao,prioridade,manutentor) values(@codOs,@descricao,@prioridade,@manutentor)";

        public class OrdemDeServico
        {
            public int idOs { get; set; }
            public String codOs { get; set; }
            public String prioridade { get; set; }
            public String descricao { get; set; }
            public DateTime dataAbertura { get; set; }
            public DateTime dataFechamento { get; set; }
            public String manutentor { get; set; }
        }

        public List<OrdemDeServico> VisualizarAbertos()
        {
            List<OrdemDeServico> lstOrdemDeServico = new List<OrdemDeServico>();
            using (SqlConnection objCnx = new SqlConnection(u.Bd_conexao))
            {
                using (SqlCommand objCmd = new SqlCommand(strVisualizarAbertos, objCnx))
                {
                    objCnx.Open();

                    SqlDataReader objDataReader = objCmd.ExecuteReader();
                    if (objDataReader.HasRows)
                    {
                        while (objDataReader.Read())
                        {
                            OrdemDeServico objOrdemDeServico = new OrdemDeServico();
                            objOrdemDeServico.codOs = objDataReader["codOs"].ToString();
                            objOrdemDeServico.prioridade = objDataReader["prioridade"].ToString();
                            objOrdemDeServico.dataAbertura = Convert.ToDateTime(objDataReader["dataAbertura"]);
                            objOrdemDeServico.descricao = objDataReader["descricao"].ToString();
                            objOrdemDeServico.manutentor = objDataReader["manutentor"].ToString();

                            lstOrdemDeServico.Add(objOrdemDeServico);
                        }
                        objCnx.Close();
                    }
                    objCnx.Close();
                }
                return lstOrdemDeServico;
            }

        }

        public void AlterarOS(String cod, String prioridade, String descricao, String manutentor, String dataFechamento)
        {
            using (SqlConnection objCnx = new SqlConnection(u.Bd_conexao))
            {
                if (dataFechamento != "  /  /")
                {
                    strAlterar= "UPDATE ordemServico SET prioridade=@prioridade, descricao=@descricao, manutentor=@manutentor, dataFechamento = @dataFechamento WHERE codOs = @codOs";
                }
                using (SqlCommand objCmd = new SqlCommand(strAlterar, objCnx))
                {
                   
                
                    objCmd.Parameters.AddWithValue("@codOs", cod);
                    objCmd.Parameters.AddWithValue("@prioridade", prioridade);
                    objCmd.Parameters.AddWithValue("@descricao", descricao);
                    objCmd.Parameters.AddWithValue("@manutentor", manutentor);
                    if (dataFechamento != "  /  /")
                    {
                        DateTime df = Convert.ToDateTime(dataFechamento);
                        objCmd.Parameters.AddWithValue("@dataFechamento", df);
                    }
                    

                    objCnx.Open();
                    objCmd.ExecuteNonQuery();
                    objCnx.Close();
                }
            }
        }

        public void CriarOs(String cod, String prioridade, String descricao, String manutentor)
        {
            using (SqlConnection objCnx = new SqlConnection(u.Bd_conexao))
            {
                using (SqlCommand objCmd = new SqlCommand(strCriar, objCnx))
                {
                    objCmd.Parameters.AddWithValue("@codOs", cod);
                    objCmd.Parameters.AddWithValue("@prioridade", prioridade);
                    objCmd.Parameters.AddWithValue("@descricao", descricao);
                    objCmd.Parameters.AddWithValue("@manutentor", manutentor);

                    objCnx.Open();
                    objCmd.ExecuteNonQuery();
                    objCnx.Close();


                }
            }

        }
    }
}
