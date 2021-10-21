using System;
using System.Collections.Generic;
using System.Text;

namespace CORE.Users.Interfaces
{
    public interface ILogin : IDisposable //clase para liberar memoria para cada metodo , siempre se tiene que liberar memoria
    {//modelo que se recibe para loggear un usuario 
        Models.LoginModel Login(Models.LoginMinModel user);
    }
}
