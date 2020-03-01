using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OMB_V2.Models;

namespace OMB_V2.Models.Metodos_Login
{
    class Metodos_login
    {
        private Users_v2 user;
        // LISTAR USUARIO
        private Bunifu.UI.WinForms.BunifuDataGridView Listar_usuarios(Bunifu.UI.WinForms.BunifuDataGridView receptor) 
        {
            try
            {
                DB_Entities_OMB db = new DB_Entities_OMB();
                var Listado_usuarios = from user in db.Vista_usuarios_v2 select user;
                receptor.DataSource = Listado_usuarios.ToList();
                return receptor;
            }
            catch (Exception)
            {

                return null;
            }
        }
        // CAMBIAR COLUMNAS USUARIO
        private Bunifu.UI.WinForms.BunifuDataGridView Cambiar_columns(Bunifu.UI.WinForms.BunifuDataGridView Datagrid_receptor)
        {
            try
            {
                Datagrid_receptor.Columns[0].HeaderText = "ID usuario";
                Datagrid_receptor.Columns[5].HeaderText = "Pregunta de seguridad";
                Datagrid_receptor.Columns[6].HeaderText = "Respuesta de seguridad";
                Datagrid_receptor.Columns[7].HeaderText = "Rol";
                Datagrid_receptor.Columns[8].HeaderText = "Fecha de creacion";

                return Datagrid_receptor;
            }
            catch (Exception)
            {

                return null;
            }
        }
        // Refrescar usuarios
        public void Refrescar_usuarios(Bunifu.UI.WinForms.BunifuDataGridView Datagrid_receptor) 
        {
            Listar_usuarios(Datagrid_receptor);
            Cambiar_columns(Datagrid_receptor);
            Datagrid_receptor.AutoResizeColumnHeadersHeight();
        }
        // AÑADIR USUARIO
        public void Añadir_Editar_Usuario(int? ID_user, Bunifu.UI.WinForms.BunifuDropdown Pregunta_drp, Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox Txb_nombres, Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox Txb_tel,
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox Txb_email, Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txb_pass, Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txb_resp)
        {
            using (DB_Entities_OMB db = new DB_Entities_OMB())
            {

                // SI LA CEDULA ES NULA NOS INICIALIZARA LA CLASE TOMADOR
                string Valor_drop = Pregunta_drp.SelectedItem.ToString();
                if (ID_user == null)
                {
                    user = new Users_v2();
                    user.Nombres = Txb_nombres.Text;
                    user.Telefono = Txb_tel.Text;
                    user.Email = Txb_email.Text;
                    user.Contraseña = txb_pass.Text;
                    user.Pregunta_seguridad = Valor_drop;
                    user.Respuesta_seguridad = txb_resp.Text;
                    user.ID_Rol = 1;
                    user.Fecha_creacion = DateTime.Now;
                }
                // SI LA CEDULA ES NULA AGREGARA LOS REGISTROS
                if (ID_user == null)
                {
                    db.Users_v2.Add(user);
                    MessageBox.Show("Usuario agregado");
                }
                else
                {
                    // SI LA CEDULA NO ES NULA NOS EDITARA LOS REGISTROS
                    user = new Users_v2();
                    user.Nombres = Txb_nombres.Text;
                    user.Telefono = Txb_tel.Text;
                    user.Email = Txb_email.Text;
                    user.Contraseña = txb_pass.Text;
                    user.Pregunta_seguridad = Valor_drop;
                    user.Respuesta_seguridad = txb_resp.Text;
                    user.ID_Rol = 1;
                    user.Fecha_creacion = DateTime.Now;
                    if (ID_user != null)
                    {
                        db.Users_v2.Add(user);
                        db.Entry(user).State = System.Data.Entity.EntityState.Modified;
                        MessageBox.Show("Edición de registros completada");
                    }
                }
                db.SaveChanges();
            }
        }
        public void Llenar_editar_usuario(int? ID_user, Bunifu.UI.WinForms.BunifuDropdown Pregunta_drp, Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox Txb_nombres, Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox Txb_tel,
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox Txb_email, Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txb_pass, Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txb_resp, Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox Txb_conf_p,
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox Txb_conf_e) 
        {
            DB_Entities_OMB db = new DB_Entities_OMB();
            Users_v2 Usuarios = new Users_v2();
            Usuarios = db.Users_v2.Find(ID_user);
            if (Usuarios.ID_Usuario == ID_user)
            {
                Txb_nombres.Text = Usuarios.Nombres;
                Txb_tel.Text = Usuarios.Telefono;
                Txb_email.Text = Usuarios.Email;
                txb_pass.Text = Usuarios.Contraseña;
                Pregunta_drp.SelectedItem = Usuarios.Pregunta_seguridad;
                txb_resp.Text = Usuarios.Respuesta_seguridad;
                Txb_conf_e.Text = Txb_email.Text;
                Txb_conf_p.Text = txb_pass.Text;
            }
            else
            {
                MessageBox.Show("No se encontraron registros");
            }
        }
    }
}
