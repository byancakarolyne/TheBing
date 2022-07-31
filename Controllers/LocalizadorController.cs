using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Data.SqlClient;
using Looking42.Modelo;

namespace Looking42.Controllers
{
    public class LocalizadorController : Controller
    {
        [HttpGet("localizador")]
        public IActionResult getCargas([FromHeader] string cnpj)
        {
            try
            {
                var cargas = new List<Carga>();
                var query = $@"
                    SELECT e.id_empresa, e.cnpj, e.nome_empresa, --empresa
                    c.id_carga, c.nome_carga, c.descricao_carga, c.origem, c.destino, --carga
                    s.status, s.id_status, st.id_carga-- status
                    FROM carga c
                    INNER JOIN empresa e ON e.id_empresa = c.id_empresa
                    INNER JOIN carga_status st ON st.id_carga = c.id_carga
                    INNER JOIN [status] s ON s.id_status = st.id_status                    
                ";
                var conn = "Data Source=bing.cn1hoce5ecsw.sa-east-1.rds.amazonaws.com;User Id=admin;Password=bing2022;Initial Catalog=bing";
                var connection = new SqlConnection(conn);
                connection.Open();

                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    var carga = new Carga
                    {
                        IdEmpresa = dr.GetInt32(0),
                        CnpjEmpresa = dr.GetString(1),
                        NomeEmpresa = dr.GetString(2),
                        IdCarga = dr.GetInt32(3),
                        NomeCarga = dr.GetString(4),
                        DescricaoCarga = dr.GetString(5),
                        Origem = dr.GetString(6),
                        Destino = dr.GetString(7),
                        Status = dr.GetString(8),
                        IdStatus = dr.GetInt32(9)
                    };

                    cargas.Add(carga);
                }

                return Ok(cargas);

            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}
