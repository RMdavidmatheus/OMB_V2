using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_login
{
    public class Metodos_login
    {
        // CONSTANTES DE CONEXION
        private static MongoClient Conexion { get; set; }
        private static IMongoDatabase Base_de_datos { get; set; }
        private static string Cadena_de_conexion = "";
        private static string Base_de_usuarios = "";
        private static IMongoCollection<Usuarios_Mongo_Login> Usuarios_coleccion { get; set; } 
        public void Conectar_base_de_datos()
        {
            try
            {
            
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
