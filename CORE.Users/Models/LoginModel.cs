using System;
using System.Collections.Generic;
using System.Text;

namespace CORE.Users.Models
{
    public class LoginModel: BaseModel
    {
        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; } //id de una base de datos (tabla de token)
        public string RefreshToken { get; set; }//ya que caduque se haga un refresh
        public DateTime RefreshTokenExpiryTime { get; set; }
        public string Token { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
    }

    public class LoginMinModel:BaseModel
    {
        //public string Nick { get; set; }
        //public string Pass { get; set; }
    }
}
