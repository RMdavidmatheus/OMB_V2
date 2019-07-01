using Bunifu.UI.WinForms;
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
        private static string Cadena_de_conexion = "mongodb+srv://DavidMatheus98:ALEJANDRO98@cluster0-d1k5y.azure.mongodb.net/test?retryWrites=true&w=majority";
        private static string Base_de_datos_string = "OMB_V2";
        private static IMongoCollection<Usuarios_Mongo_Login> Usuarios_coleccion { get; set; }
        // METODO PARA CONECTAR LA BASE DE DATOS
        #region
        public void Conectar_base_de_datos()
        {
            try
            {
                Conexion = new MongoClient(Cadena_de_conexion);
                Base_de_datos = Conexion.GetDatabase(Base_de_datos_string);
                Usuarios_coleccion = Base_de_datos.GetCollection<Usuarios_Mongo_Login>("Usuarios");
            }
            catch (MongoException e)
            {
                MessageBox.Show("Error al iniciar la conexion", e.Message );
            }
        }
        #endregion
        // FIN CONEXION
        // METODO LISTAR USUARIOS
        #region
        public void Listar_usuarios(BunifuDataGridView Datagrid)
        {
            try
            {
                Conectar_base_de_datos();
                List<Usuarios_Mongo_Login> Usuarios_lista = Usuarios_coleccion.AsQueryable().ToList<Usuarios_Mongo_Login>();
                Datagrid.DataSource = Usuarios_lista;
                Datagrid.Columns[0].Visible = false;
                Datagrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
        // FIN METODO
    }
}
