//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OMB_V2.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Users_v3
    {
        public int ID_Usuario { get; set; }
        public string Nombres { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Contraseña { get; set; }
        public string Pregunta_seguridad { get; set; }
        public string Respuesta_seguridad { get; set; }
        public int ID_Rol { get; set; }
        public Nullable<System.DateTime> Fecha_de_creacion { get; set; }
    
        public virtual Roles Roles { get; set; }
    }
}