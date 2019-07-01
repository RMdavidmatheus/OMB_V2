using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_login
{
    class Usuarios_Mongo_Login
    {
        public Usuarios_Mongo_Login(ObjectId id, long documento, string tipo_de_documento, string nombres, string apellidos, long telefono, string email, string password, string rol)
        {
            _id = id;
            Documento = documento;
            Tipo_documento = tipo_de_documento ?? throw new ArgumentNullException(nameof(tipo_de_documento));
            Nombres = nombres ?? throw new ArgumentNullException(nameof(nombres));
            Apellidos = apellidos ?? throw new ArgumentNullException(nameof(apellidos));
            Telefono = telefono;
            Email = email ?? throw new ArgumentNullException(nameof(email));
            Password = password ?? throw new ArgumentNullException(nameof(password));
            Rol = rol ?? throw new ArgumentNullException(nameof(rol));
        }

        [BsonId]
        public ObjectId _id { get; set; }
        [BsonElement]
        public long Documento { get; set; }
        [BsonElement]
        public string Tipo_documento { get; set; }
        [BsonElement]
        public string Nombres { get; set; }
        [BsonElement]
        public string Apellidos { get; set; }
        [BsonElement]
        public long Telefono { get; set; }
        [BsonElement]
        public string Email { get; set; }
        [BsonElement]
        public string Password { get; set; }
        [BsonElement]
        public string Rol { get; set; }
    }
}
