using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Data.SqlClient;
using Looking42.Modelo;
using System.Linq;

namespace Looking42.Controllers
{
    public class LocalizadorController : Controller
    {
        [HttpGet("localizador")]
        public IActionResult getCargas([FromHeader] string cnpj)
        {
            try
            {
                var empresas = new List<Empresa>();
                var cargas = new List<Carga>();
                var cargasStatus = new List<CargaStatus>();

                var conn = "Data Source=bing.cn1hoce5ecsw.sa-east-1.rds.amazonaws.com;User Id=admin;Password=bing2022;Initial Catalog=bing";
                var connection = new SqlConnection(conn);
                connection.Open();

                var queryEmpresa = $@"SELECT id_empresa, cnpj, nome_empresa FROM empresa";
                var queryCargas = $@"SELECT id_carga, nome_carga, descricao_carga, origem, destino, id_empresa FROM carga";
                var queryStatus = $@"SELECT id_carga_status, id_carga, id_status, horario FROM carga_status";
                
                SqlCommand cmd = new SqlCommand(queryEmpresa, connection);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    var empresa = new Empresa
                    {
                        Id = dr.GetInt32(0),
                        Cnpj = dr.GetString(1),
                        Nome = dr.GetString(2)                        
                    };
                    
                    empresas.Add(empresa);
                }
                dr.Close();

                SqlCommand cmd2 = new SqlCommand(queryCargas, connection);
                SqlDataReader dr2 = cmd2.ExecuteReader();
                while (dr2.Read())
                {
                    var carga = new Carga
                    {
                        Id = dr2.GetInt32(0),
                        Nome = dr2.GetString(1),
                        Descricao = dr2.GetString(2),
                        Origem = dr2.GetString(3),
                        Destino = dr2.GetString(4),
                        IdEmpresa = dr2.GetInt32(5)
                    };

                    cargas.Add(carga);
                }
                dr2.Close();


                SqlCommand cmd3 = new SqlCommand(queryStatus, connection);
                SqlDataReader dr3 = cmd3.ExecuteReader();
                while (dr3.Read())
                {
                    var cargaStatus = new CargaStatus
                    {
                        IdCargaSatus = dr3.GetInt32(0),
                        IdCarga = dr3.GetInt32(1),
                        IdStatus = dr3.GetInt32(2),
                        Horario = dr3.GetDateTime(3)
                    };  
                   
                    cargasStatus.Add(cargaStatus);

                }
                dr3.Close();
                                
                foreach (var e in empresas)
                {
                    e.Cargas = cargas.Where(c => c.IdEmpresa == e.Id);
                }

                foreach (var c in cargas)
                {
                    c.CargasStatus = cargasStatus.Where(cs => cs.IdCarga == c.Id);
                }

                return Ok(empresas);

            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}
