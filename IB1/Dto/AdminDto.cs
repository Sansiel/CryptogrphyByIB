using System;

namespace IB1.Dto
{
    [Serializable]
    public class AdminDto : Person
    {
        private static string adminName = "ADMIN";

        public AdminDto()
        {
            Login = AdminName;
            Password = "";
        }

        public static string AdminName { get => adminName; set => adminName = value; }
    }
}
