# Bienvenido al proyecto OMB V2.0
[![OMB Seguros](https://i.imgur.com/hEkB2Wz.png)](http://www.provision.com.co/)
[![Build Status](https://travis-ci.org/joemccann/dillinger.svg?branch=master)](https://github.com/RMdavidmatheus)

## Introduccion al proyecto
Me presento, soy estudiante en programación de software, este sistema esta pensado en el manejo en base de datos para una empresa basada en seguros.

***Este software es hecho unica y exclusivamente para uso de aprendizaje.***


## Cambios

| Diseño | Estructura |
|--|--|
| Implementacion de material design | Uso de entity framework |
|Cambio de colores principales en todo el aplicativo|Uso de MongoDB Atlas y SQL Server|
|Uso de bunifu UI |Uso de JSON para crear autocompletables|

> **Se encuentra aún en desarrollo.**

> **Tiempo estimado de finalización 6 meses.**

 - [x] Diseño
 - [ ] Logica
 - [ ] Bases de datos

## Codigo fuente para conexion con MongoDB Cluster

   

    // INICIO
    
    // TIPO DE DATO MONGO CLIENT CONNECTION CON SU GET Y SET
    
    private static MongoClient Conexion { get; set; }
    
    // TIPO DE DATO MONGO DATA BASE
    private static IMongoDatabase Base_de_datos { get; set; }
    
    // CADENA DE CONEXION TIPO DE DATO STRING
    private static string Cadena_Conexion = "mongodb+srv://"USUARIO":"CONTRASEÑA DEL USUARIO"@proyecto-xmrxf.azure.mongodb.net/test?retryWrites=true";
    
    // STRING QUE CONTIENE EL NOMBRE DE LA BASE DE DATOS
    private static string Base_Usuarios = "NOMBRE DE LA BASE DE DATOS";
    
    // COLECCION DE LA BASE DE DATOS CON SU GET Y SET ("SE NECESITA UNA CLASE USUARIOS CON SUS RESPECTIVOS CAMPOS GET Y SET PARA AÑADIR LOS DATOS A LA COLECCIÓN") 
    private static IMongoCollection<Usuarios> Usuarios_Coleccion { get; set; }
    
     // METODO DE CONEXION
        public void Conectar_base_de_datos()
        {
            try
            {
                Conexion = new MongoClient(Cadena_Conexion);
                Base_de_datos = Conexion.GetDatabase(Base_Usuarios);
                Usuarios_Coleccion = Base_de_datos.GetCollection<Usuarios>("Usuarios");
            }
            catch (MongoException e)
            {
                MessageBox.Show(e.ToString());
            }
        }
        // FIN
## Codigo clase que surtira la coleccion de Mongo

    class Usuarios
    {
	//CONSTRUCTOR DE LA CLASE
        public Usuarios(ObjectId id, string nombre_usuario, string contraseña, string email, long documento, long telefono, string rol)
        {
            _id = id;
            Nombre_usuario = nombre_usuario;
            Contraseña = contraseña;
            Email = email;
            Documento = documento;
            Telefono = telefono;
            Rol = rol;
        }
        // FIN CONSTRUCTOR

	// TIPO DE DATOS BSON
       [BsonId]
        public ObjectId _id { get; set; }
       [BsonElement]
        public string Nombre_usuario { get; set; }
       [BsonElement]
        public string Contraseña { get; set; }
       [BsonElement]
        public string Email { get; set; }
       [BsonElement]
        public long Documento { get; set; }
       [BsonElement]
        public long Telefono { get; set; }
       [BsonElement]
        public string Rol { get; set; }
        
        // FIN ELEMENTOS BSON
	  }
    }   
## Material de apoyo

[Connection Mongo DB Atlas cluster](https://www.youtube.com/watch?v=lEnUsePov4E)
[CRUD MongoDB ](https://www.youtube.com/watch?v=ZpEwre2TG7A&t=409s)
[Entity framework C#](https://www.youtube.com/watch?v=JAfg2j8qrsg)




