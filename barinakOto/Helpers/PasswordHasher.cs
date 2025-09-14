using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BCrypt.Net;

namespace barinakOto.Helpers
{
    public static class PasswordHasher
    {
        public static string HashPassword(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);
        }

        // Hash'lenmiş şifreyi verilen şifre ile doğrular
        public static bool VerifyPassword(string password, string hashedPassword)
        {
            try
            {
                return BCrypt.Net.BCrypt.Verify(password, hashedPassword);
            }
            catch (BCrypt.Net.SaltParseException)
            {
                // Hatalı bir hash formatı gelirse (örn. eski hash'ler)
                return false;
            }
        }
    }
}
