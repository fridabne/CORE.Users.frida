using System;
using System.Collections.Generic;
using System.Text;

namespace CORE.Users.Models
{
    public class BaseModel
    { //tres atributos 
        private int user_id;
        private string user_nick;
        private string user_password;

        public int Identificador { get => user_id; set => user_id = value; }
        //identificador se puede a llamar como lo definí
        //generar un token y que determ. usuario con id se puede loggear
        public string Nick { get => user_nick; set => user_nick = value; }

        public string Password { get => user_password; set => user_password = value; }

    }
}
