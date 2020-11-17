using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionEntities
{
    public class LoginIsAlreadyUsedException : Exception
    {
        public LoginIsAlreadyUsedException() : base("Прользователь с таким логином уже существует")
        {

        }
    }
}
