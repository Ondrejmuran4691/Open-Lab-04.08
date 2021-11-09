using System;
using System.Collections.Generic;

namespace Open_Lab_04._08
{
    public class StringTools
    {
        public string[] IsFourLetters(string[] strings)
        {
            var done = new List <string>();
          
            foreach (string s in strings)
            {
                
                if(s.Length == 4)
                {
                    done.Add(s);
                }
            }
            return done.ToArray();

        }
    }
}
