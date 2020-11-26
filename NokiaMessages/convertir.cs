using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NokiaMessages
{
    class Convertir
    {
        Dictionary<string, string[]> liste = new Dictionary<string, string[]>();

        public Convertir()
        {
            liste.Add("2", new string[] { "a", "b", "c" });
            liste.Add("3", new string[] { "d", "e", "f" });
            liste.Add("4", new string[] { "g", "h", "i" });
            liste.Add("5", new string[] { "j", "k", "l" });
            liste.Add("6", new string[] { "m", "n", "o" });
            liste.Add("7", new string[] { "p", "q", "r", "s" });
            liste.Add("8", new string[] { "t", "u", "v" });
            liste.Add("9", new string[] { "w", "x", "y", "z" });
            liste.Add("0", new string[] { " " });
        }

        public bool stringCaractereIdentique(string s) 
        {
            bool verify = true;
            char c = s[0];
            for (int i =0; i<s.Length;i++)
            {
                if (c != s[i]) { verify = false; }
            }
            return verify;
        }
        public string NumbersToLetters(string numbers) 
        {
            string results = "";
            foreach (string s in numbers.Split('-'))
            {
                try
                {
                    if (!stringCaractereIdentique(s)) { throw new Ex("verifier votre champ (correcte exemple : XXX-YYY-RRR)"); }
                }
                catch (Ex e)
                { }

                foreach (KeyValuePair<string, string[]> item in liste)
                {
                    if (item.Key.Equals(s[0].ToString()))
                    {
                        results += item.Value[s.Length - 1];
                    }

                }
            }
            return results;
        }

        public string LettersToNumbers(string message)
        {
            string results = "";
            foreach (char s in message)
            {
                foreach (KeyValuePair<string, string[]> item in liste)
                {
                    for (int i = 0; i < item.Value.Length; i++)
                    {
                        if (item.Value[i].Equals(s.ToString()))
                        {
                            int j = 0;
                            while (j <= i)
                            {
                                results += item.Key;
                                j++;
                            }
                            results += "-";
                        }
                    }


                }
            }
            results = results.Substring(0, results.Length - 1);//supprimer le dernier carractere '-'
            return results;
        }
    }
}
