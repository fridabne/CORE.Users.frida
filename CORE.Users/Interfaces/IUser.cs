using System;
using System.Collections.Generic;
using System.Text;

namespace CORE.Users.Interfaces
{
    public interface IUser: IDisposable
    { //todos los modelos
        List<Models.UserModel> GetUsers();
        Models.UserModel GetUser(int ID);
        long AddUser(Models.UserModel model);
        bool UpdateUser(Models.UserModel model);
        void DeleteUser(int ID);//plantilla
    }
}
