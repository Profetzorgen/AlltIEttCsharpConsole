using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamlingsBlahaAllaÖvningar
{
    internal class User
    {
        public string UserName;
        private string Password;
        private bool isAdmin;
        private int användarNr;
        public User(string uName, string pWord, bool admin, int listNummer)
        {
            isAdmin = admin;
            UserName = uName;
            Password = pWord;
            användarNr = listNummer;
        }

        public void ChangePassword(string newPw, string oldPw)
        {
            bool byterLösenordet = true;
            while (byterLösenordet)
            {
                if (oldPw == Password)
                {
                    Console.WriteLine("Det gamla lösenordet stämmer, " +
                                      " skriv in ditt nya lösenord: ");
                    newPw = Console.ReadLine();
                    Password = newPw;
                    Console.WriteLine("Nytt lösenord sparades!");
                    Thread.Sleep(800);
                    Console.Clear();
                    byterLösenordet =false;
                }
                else if (oldPw != Password) { Console.WriteLine("Det gamla lösenordet stämmer inte, försök igen!"); }
            }
            
        }

        public override string ToString()
        {
            return "Username: " + UserName + "|| Password: " + Password + "|| Is Admin? t/f: " + isAdmin + "|| Användarnr: " + användarNr;
        }
    }
}
