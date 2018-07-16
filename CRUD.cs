using system;
using System.Data.SqlClient;

namespace Crud
{
    public class Controlador
    {
        connection conn = new Connection();
        public Bool Crear (Estudiante, NuevoEstudiante)
        {
             var creacion = "Insert into Estudiantes (nombre) values ("jessie")";
             conn.open(creacion);
             var c = conn.execute(creacion);
             con.close(creacion);
             return transform(c);
        }
        public Estudiante Leer (int, id)
        {
             var consulta = "select * from Estudiantes Where id=1";
             conn.open(consulta);
             var r = conn.execute(consulta);
             con.close(consulta);
             return transform(r);
        }
        public bool delete (int, id)
        {
            var borrar = "delete from Estudiantes WHERE id = 2";
            conn.open(borrar);
            var d = conn.execute(borrar);
            con.close(borrar);
            return transform(d);
        }
        public Estudiante Update (Estudiante, Cambios)
        {
            var actualizar = "Update Estudiantes SET nombre = "julio" where id = 2";
            conn.open(actualizar);
            var t = conn.execute(actualizar);
            con.close(actualizar);
            return transform(t);
        }
       
    
}