namespace Reg.Controller
{
    internal class Scrypt
    {
        public string Generate(string pass)
        {
            return BCrypt.Net.BCrypt.HashPassword(pass);
        }

    }
}
