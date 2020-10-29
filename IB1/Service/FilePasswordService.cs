using IB1.Dto;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Xml.Serialization;

namespace IB1.Service
{
    class FilePasswordService
    {
        private const string filePersons = "persons.xml";
        private const string filePersonsDesCrypto = "desPersons.xml";
        private const string passwordKey = "qwerty123";
        private readonly DESCryptoServiceProvider desCryptoService;

        public FilePasswordService()
        {
            desCryptoService = new DESCryptoServiceProvider
            {
                Mode = CipherMode.CBC,
                Key = Encoding.UTF8.GetBytes(passwordKey).Take(8).ToArray(),
                IV = Encoding.UTF8.GetBytes(passwordKey).Take(8).ToArray()
            };
        }


        // temp xml file - filePersons
        public Dictionary<string, Person> GetAll()
        {
            List<Person> listPerson;
            Dictionary<string, Person> dictPerson = new Dictionary<string, Person>();
            var serializer = new XmlSerializer(typeof(List<Person>));

            using (var reader = new StreamReader(filePersons))
            {
                listPerson = (List<Person>)serializer.Deserialize(reader);
            }

            foreach (var v in listPerson)
            {
                dictPerson.Add(v.Login, v);
            }
            return dictPerson;
        }

        public bool SaveAll(Dictionary<string, Person> persons)
        {
            List<Person> listPerson = persons.Values.ToList();
            var serializer = new XmlSerializer(typeof(List<Person>));

            using (var fs = new FileStream(filePersons, FileMode.Create))
            {
                serializer.Serialize(fs, listPerson);
            }
            EncryptTextToFile();
            return true;

        }

        public void DeleteTempFile()
        {
            if (IsExistFile())
            {
                File.Delete(filePersons);
            }
        }


        // Crypto file
        public void EncryptTextToFile()
        {
            try
            {
                /// get all from temp file
                string data;
                using (var reader = new StreamReader(filePersons))
                {
                    data = reader.ReadToEnd();
                }

                FileStream fStream = File.Open(filePersonsDesCrypto, FileMode.Create);

                // Change crypto Mode
                DESCryptoServiceProvider cryptoProvider = new DESCryptoServiceProvider();
                cryptoProvider.Mode = CipherMode.CFB;

                // Шифровальный поток.
                CryptoStream cStream = new CryptoStream(fStream,
                    cryptoProvider.CreateEncryptor(desCryptoService.Key, desCryptoService.IV),
                    CryptoStreamMode.Write);

                StreamWriter sWriter = new StreamWriter(cStream);

                sWriter.WriteLine(data);

                sWriter.Close();
                cStream.Close();
                fStream.Close();
            }
            catch (CryptographicException e)
            {
                Console.WriteLine("A Cryptographic error occurred: {0}", e.Message);
            }
            catch (UnauthorizedAccessException e)
            {
                Console.WriteLine("A file error occurred: {0}", e.Message);
            }

        }

        public void DecryptTextFromFile()
        {
            try
            {
                //Поток памяти
                FileStream fStream = File.Open(filePersonsDesCrypto, FileMode.OpenOrCreate);

                //Change crypto mode
                SymmetricAlgorithm cryptoProvider = new DESCryptoServiceProvider();
                cryptoProvider.Mode = CipherMode.CFB;

                //Crypto stream
                CryptoStream cStream = new CryptoStream(fStream,
                    cryptoProvider.CreateDecryptor(desCryptoService.Key, desCryptoService.IV),
                    CryptoStreamMode.Read);

                StreamReader sReader = new StreamReader(cStream);

                string val = sReader.ReadToEnd();

                sReader.Close();
                cStream.Close();
                fStream.Close();

                ///save temp file
                StreamWriter sWriter = new StreamWriter(filePersons);
                sWriter.WriteLine(val);
                sWriter.Close();
            }
            catch (CryptographicException e)
            {
                Console.WriteLine("A Cryptographic error occurred: {0}", e.Message);
            }
            catch (UnauthorizedAccessException e)
            {
                Console.WriteLine("A file error occurred: {0}", e.Message);
            }
        }

        public bool IsExistFile()
        {
            return File.Exists(filePersonsDesCrypto);
        }
    }
}
