using System.Security.Cryptography;
using System.Text;

namespace IB1.Service
{
    class PasswordService
    {
        public string doHash(string password)
        {
            // step 1, calculate MD5 hash from password
            MD5 md5 = MD5.Create();
            byte[] inputBytes = Encoding.ASCII.GetBytes(password);
            byte[] hash = md5.ComputeHash(inputBytes);

            // step 2, convert byte array to hex string
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            return sb.ToString();
        }

        public bool СheckPassword(string password)
        {
            bool isBigChar = false;
            bool isSmallChar = false;
            foreach (char c in password)
            {
                if (char.IsUpper(c))
                {
                    isBigChar = true;
                }
                else if (char.IsLower(c))
                {
                    isSmallChar = true;
                }
                if (isBigChar && isSmallChar)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
