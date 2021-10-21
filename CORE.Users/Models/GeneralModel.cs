using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CORE.Users.Models
{
    public enum EServer : int
    {//servidor al que se va a conectar
        //servidores locales, nubes etc
        UDEFINED = 0,
        CLOUD = 1,
        LOCAL = 2,
    }
}
