using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace BiggerIsGreater
{
    class Program
    {
        static void Main(string[] args)
        {
            MyString str = new MyString();
            str.changableWord = new StringBuilder();
            str.changableWord.Append(ReadLine());
            str.myWord = str.changableWord.ToString();
            string[] array = str.wordLetterConbination();
            str.sort(array);
            string myResultWord = str.findGreaterWord(array);
            if (myResultWord != null)
            {
                WriteLine(myResultWord);
            }
            else
            {
                WriteLine("No result");
            }
            ReadLine();
        }
    }
}
