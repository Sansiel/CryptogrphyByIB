using IB1.Dto;
using System;
using System.Collections.Generic;

namespace IB1.Service
{
    public class PersonService
    {

        FilePasswordService filePasswordService;

        PasswordService passwordService;

        private static readonly int countTry = 3;

        private static Person currentPerson;

        private static int numberTryOfLogIn = countTry;

        private static Dictionary<string, Person> dictPerson;

        public static Person CURRENT_PERSON { get => currentPerson; }

        public static Dictionary<string, Person> DICT_PERSONS { get => dictPerson; }

        public static int NUMBER_TRY_OF_LOGIN { get => numberTryOfLogIn; }

        public PersonService()
        {
            filePasswordService = new FilePasswordService();
            passwordService = new PasswordService();
        }

        public bool Login(string login, string password)
        {
            if (CheckPasswordInPerson(login, password))
            {
                numberTryOfLogIn = countTry;
                if (dictPerson[login] is UserDto &&
                    (dictPerson[login] as UserDto).IsBlocked)
                {
                    throw new Exception("Пользователь заблокирован");
                }
                currentPerson = dictPerson[login];
                return true;
            }
            else
            {
                numberTryOfLogIn--;
                return false;
            }
        }

        public void Logout()
        {
            currentPerson = null;
            numberTryOfLogIn = countTry;
        }

        public bool Add(Person person)
        {
            if (!CheckLoginExist(person.Login))
            {
                person.Password = passwordService.doHash(person.Password);
                dictPerson.Add(person.Login, person);
                return true;
            }
            return false;
        }

        public bool GetAll()
        {
            if (dictPerson != null)
            {
                return false;
            }
            if (filePasswordService.IsExistFile())
            {
                filePasswordService.DecryptTextFromFile();
                dictPerson = filePasswordService.GetAll();
                if (!CheckLoginExist(AdminDto.AdminName))
                {
                    dictPerson = null;
                }
            }
            else
            {
                dictPerson = new Dictionary<string, Person>();
                Person admin = new AdminDto();
                return Add(admin);
            }
            return false;
        }

        public bool SaveAll()
        {
            return CheckLoginExist(AdminDto.AdminName) ? filePasswordService.SaveAll(dictPerson) : false;
        }

        public void DeleteTempFile()
        {
            filePasswordService.DeleteTempFile();
        }

        public bool CheckLoginExist(string login)
        {
            return dictPerson.ContainsKey(login);
        }

        public bool SetPasswordForUser(string password)
        {
            if (password.Equals(""))
            {
                throw new Exception("Пароль не может быть пустым");
            }
            if (currentPerson is UserDto)
            {
                if ((currentPerson as UserDto).HaveRestrictionsPassword &&
                    !passwordService.СheckPassword(password))
                {
                    return false;
                }
            }
            dictPerson[currentPerson.Login].Password = passwordService.doHash(password);
            currentPerson = dictPerson[currentPerson.Login];
            return true;
        }

        public void SetBlockAndPasswordRestriction(UserDto user)
        {
            if (dictPerson[user.Login] is UserDto)
            {
                (dictPerson[user.Login] as UserDto).IsBlocked = user.IsBlocked;
                (dictPerson[user.Login] as UserDto).HaveRestrictionsPassword = user.HaveRestrictionsPassword;
            }
        }

        public void SetPersonNotFirstTime()
        {
            dictPerson[currentPerson.Login].IsFirstTime = false;
            currentPerson.IsFirstTime = false;
        }

        private bool CheckPasswordInPerson(string login, string password)
        {
            return CheckLoginExist(login) ?
               dictPerson[login].Password.Equals(passwordService.doHash(password)) : false;
        }

    }
}
