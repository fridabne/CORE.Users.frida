using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CORE.Users.Configuration;
using CORE.Users.Interfaces;
using CORE.Users.Models;
using Users_CORE.Services;

namespace CORE.Users.Services
{
    public class FactorizerService
    {//dos servidores, podemos defirnir que servidor utilizar
       
        public static IUser Inicializar(EServer typeServer)
        {
            return typeServer switch
            {
                EServer.UDEFINED => throw new NullReferenceException(),
                EServer.LOCAL => new UserService(BridgeDBConnection<UserModel>.Create
                (ConnectionStrings.LocalServer, CORE.Connection.Models.DbEnum.Sql),
                ConnectionStrings.LocalServer),
                EServer.CLOUD => new UserService(BridgeDBConnection<UserModel>.Create
                (ConnectionStrings.CloudServer, CORE.Connection.Models.DbEnum.Sql),
                ConnectionStrings.CloudServer),
                _ => throw new NullReferenceException(),
            };

        }

        public static ILogin Login(EServer typeServer)
        {
            return typeServer switch
            {
                EServer.UDEFINED => throw new NullReferenceException(),
                EServer.LOCAL => new LoginService(BridgeDBConnection<LoginModel>.Create(ConnectionStrings.LocalServer, CORE.Connection.Models.DbEnum.Sql)),
                EServer.CLOUD => new LoginService(BridgeDBConnection<LoginModel>.Create(ConnectionStrings.CloudServer, CORE.Connection.Models.DbEnum.Sql)),
                _ => throw new NullReferenceException(),
            };

        }
    }
}
