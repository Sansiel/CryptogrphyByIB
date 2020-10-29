using System;

namespace IB1.Dto
{
    [Serializable]
    public class UserDto : Person
    {
        private bool isBlocked;
        private bool haveRestrictionsPassword;

        public UserDto()
        { }

        public UserDto(string login)
        {
            Login = login;
            Password = "";
        }

        public UserDto(string login, bool isBlocked, bool haveRestrictionsPassword)
        {
            Login = login;
            IsBlocked = isBlocked;
            HaveRestrictionsPassword = haveRestrictionsPassword;
        }


        public bool IsBlocked { get => isBlocked; set => isBlocked = value; }
        public bool HaveRestrictionsPassword { get => haveRestrictionsPassword; set => haveRestrictionsPassword = value; }

        public override string ToString()
        {
            return base.ToString() + "isBlocked = " + isBlocked +
                " haveRestrictionsPassword = " + haveRestrictionsPassword;
        }
    }
}
