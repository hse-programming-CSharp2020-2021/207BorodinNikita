using System;
using System.Collections.Generic;
using System.Text;

namespace MyLib
{
    public abstract class MyStrings
    {
        protected string str;
        protected static Random rnd = new Random();

        public abstract int CountLetter(char letter);

        public bool IsPalidrome()
        {
            if (str.Length > 0)
            {
                char[] tmp = str.ToCharArray();

                Array.Reverse(tmp);

                string tmpString = new string(tmp);

                if (str.CompareTo(tmpString) == 0)
                    return true;
            }

            return false;
        }

        public abstract bool Validate();
    }

    public class RusString : MyStrings
    {
        public RusString(char start, char finish, int n)
        {
            if (n < 0)
                throw new ArgumentOutOfRangeException();

            char[] letters = new char[n];

            for (int i = 0; i < letters.Length; i++)
            {
                letters[i] = (char)rnd.Next(start, finish + 1);
            }

            str = new string(letters);

            if (!Validate())
            {
                throw new ArgumentOutOfRangeException();
            }
        }

        public override int CountLetter(char letter)
        {
            if (letter < 'а' || letter > 'я')
                return 0;

            int start = 0, result = -1, res;

            do
            {
                res = str.IndexOf(letter, start);
                start = res + 1;
                result++;

            } while (res >= 0);

            return result;
        }

        public override bool Validate()
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] < 'а' || str[i] > 'я') return false;
            }

            return true;
        }
    }

    public class LatString : MyStrings
    {
        public LatString(char start, char finish, int n)
        {
            if (n < 0)
                throw new ArgumentOutOfRangeException();

            char[] letters = new char[n];

            for (int i = 0; i < letters.Length; i++)
            {
                letters[i] = (char)rnd.Next(start, finish + 1);
            }

            str = new string(letters);

            if (!Validate())
            {
                throw new ArgumentOutOfRangeException();
            }
        }

        public override int CountLetter(char letter)
        {
            if (letter < 'a' || letter > 'z')
                return 0;

            int start = 0, result = -1, res;

            do
            {
                res = str.IndexOf(letter, start);
                start = res + 1;
                result++;

            } while (res >= 0);

            return result;
        }

        public override bool Validate()
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] < 'a' || str[i] > 'z')
                    return false;
            }

            return true;
        }
    }
}