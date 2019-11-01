using AppG2.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppG2.Controller
{
    public class ContactService
    {
        public static List<Contact> GetAllContact(string pathDataFile)
        {
            if (File.Exists(pathDataFile))
            {
                List<Contact> listContact = new List<Contact>();
                //Mở file đọc hết toàn bộ các dòng tỏng file xong đóng file lại
                var listLines = File.ReadAllLines(pathDataFile);

                foreach (var lines in listLines)
                {
                    var rs = lines.Split(new char[] { '#' });
                    Contact contact = new Contact
                    {
                        Id = rs[0],
                        Name = rs[1],
                        Phone = rs[2],
                        Email = rs[3],
                    };
                    listContact.Add(contact);
                }
                return listContact;
            }
            else return null;
        }
        
        public static List<Contact> GetContactBySearch(string originalText, string pathDataFile)
        {
            string text = originalText.ToLower();
            List<Contact> newListContact = new List<Contact>();
            if (!text.Equals(""))
            {
                List<Contact> listContact = GetAllContact(pathDataFile);
                
                foreach (var item in listContact)
                {
                    if (item.Name.ToLower().Contains(text) || item.Phone.ToLower().Contains(text) || item.Email.ToLower().Contains(text))
                    {
                        newListContact.Add(item);
                    }
                }
                return newListContact;
            } else
            {
                return GetAllContact(pathDataFile);
            }

        }

        public static List<Contact> GetContactInAlphabetic(string text, string pathDataFile)
        {
            List<Contact> newListContact = new List<Contact>();
            if (!text.Equals("All"))
            {
                List<Contact> listContact = GetAllContact(pathDataFile);

                foreach (var item in listContact)
                {
                    if (String.Compare(item.FirstCharacter, text)>=0)
                    {
                        newListContact.Add(item);
                    }
                }
                return newListContact;
            }
            else
            {
                return GetAllContact(pathDataFile);
            }
        }
    }
}
