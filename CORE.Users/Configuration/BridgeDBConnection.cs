using CORE.Connection;
using CORE.Connection.Interfaces;
using CORE.Connection.Models; //es importante implementar
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CORE.Users.Tools;

namespace CORE.Users.Configuration
{
    public class BridgeDBConnection<T>
    {//recibo una cadena de conexion y hacia que origen 
        public static IConnectionDB<T> Create(string ConnectionString, DbEnum DB) //origen y que fuente de conexion me voy a conectar, llega encriptada y la desencripta
        {//
            return Factorizer<T>.Create(EncryptTool.Decrypt(ConnectionString), DB);
        }
    }
}
