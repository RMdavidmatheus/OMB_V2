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
        public void Añadir_Editar_Usuario(int? ID_user, Bunifu.Framework.UI.BunifuDropdown Pregunta_drp, Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox Txb_nombres, Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox Txb_tel,
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox Txb_email, Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txb_pass, Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txb_resp)
        {
            using (DB_Entities_OMB db = new DB_Entities_OMB())
            {

                // SI LA CEDULA ES NULA NOS INICIALIZARA LA CLASE TOMADOR
                if (ID_user == null)
                {
                    user = new Users_v2();
                    user.Nombres = Txb_nombres.Text;
                    user.Telefono = Txb_tel.Text;
                    user.Email = Txb_email.Text;
                    user.Contraseña = txb_pass.Text;
                    user.Pregunta_seguridad = Pregunta_drp.selectedValue;
                    user.Respuesta_seguridad = txb_resp.Text;
                    user.ID_Rol = 1;
                    user.Fecha_creacion = DateTime.Now;

                }
                // SI LA CEDULA ES NULA AGREGARA LOS REGISTROS
                if (ID_user == null)
                {
                    db.Users_v2.Add(user);
                    MessageBox.Show("Registros agregados");
                }
                else
                {
                    // SI LA CEDULA NO ES NULA NOS EDITARA LOS REGISTROS
                    user = new Users_v2();
                    user.Nombres = Txb_nombres.Text;
                    user.Telefono = Txb_tel.Text;
                    user.Email = Txb_email.Text;
                    user.Contraseña = txb_pass.Text;
                    user.Pregunta_seguridad = Pregunta_drp.selectedValue;
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
    }
}
