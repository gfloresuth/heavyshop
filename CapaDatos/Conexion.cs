using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    class Conexion
    {
        //La base de datos e sql server se llama dbventas
        //La ubicación de la base de datos es local y la instancia que se llama MSSQLSERVER
        //Se conecta a la base de datos utilizando seguridad integrada
        public static string Cn = "Data Source=GNO-PC;Initial Catalog=dbventas;Integrated Security=True";
    }
}
