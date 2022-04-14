using System;

namespace Reg.Model
{
    internal class UserData
    {
        public int id_user { get; set; }
        public string user_email { get;set; }
        public string user_password { get;set; }

        public override string ToString()
        {
            return String.Format("id - {0}\te-mail - {1}\tPassword - {2}\t",id_user,user_email,user_password);
        }
        public UserData ()
        {

        }
    }
}
