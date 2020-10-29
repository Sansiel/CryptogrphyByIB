using System;
using System.Xml.Serialization;

namespace IB1.Dto
{
    [XmlInclude(typeof(AdminDto))]
    [XmlInclude(typeof(UserDto))]
    [Serializable]
    public abstract class Person
    {
        private bool isFirstTime = true;
        public string Login { get; set; }
        public string Password { get; set; }
        public bool IsFirstTime { get => isFirstTime; set => isFirstTime = value; }

        public override string ToString()
        {
            return "login = " + Login + "; password = " + Password;
        }
    }
}
