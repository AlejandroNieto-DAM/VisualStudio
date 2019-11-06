using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp7
{
    class Persona
    {
        private String login;
        private String passwd;

        public Persona(string login, string passwd)
        {
            this.login = login;
            this.passwd = passwd;
        }

        public void setLogin(String login)
        {
            this.login = login;
        }

        public void setPasswd(String passwd)
        {
            this.passwd = passwd;
        }

        public String getLogin()
        {
            return this.login;
        }

        public String getPasswd()
        {
            return this.passwd;
        }
    }
}
