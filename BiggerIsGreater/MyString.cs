using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiggerIsGreater
{
    class MyString
    {
        public StringBuilder changableWord;
        public string myWord;

        public string[] wordLetterConbination()
        {
            int arraySize = Factorial(changableWord.Length);
            string[] resultArray = new string[arraySize];
            wordPermutation(changableWord, changableWord.Length, changableWord.Length, resultArray);
            return resultArray;
        }
        int Factorial(int number)
        {
            if (number == 1) return 1;
            else return number * Factorial(number - 1);

        }
        public bool isGreate(string first, string second)
        {
            bool isGreat = false;

            for (int i = 0; i < first.Length; i++)
            {
                if (first[i] > second[i])
                {
                    isGreat = true;
                    break;
                }
                else if (first[i] < second[i])
                {
                    break;
                }
                else
                {
                    continue;
                }
            }
            return isGreat;
        }
        public void wordPermutation(StringBuilder word, int length_changable, int length_unchangable, string[] permutations)
        {

            if (length_changable == 1)
            {
                ReplaceArrayElements(permutations, null, word.ToString());

            }

            for (int i = 0; i < length_changable; i++)
            {
                wordPermutation(word, length_changable - 1, length_unchangable, permutations);
                if (length_changable % 2 == 1)
                {
                    char term = word[0];
                    word[0] = word[length_changable - 1];
                    word[length_changable - 1] = term;
                }
                else
                {
                    char term = word[i];
                    word[i] = word[length_changable - 1];
                    word[length_changable - 1] = term;
                }
            }

        }

        public void ReplaceArrayElements(string[] array, object oldWord, string newWord)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == oldWord)
                {
                    array[i] = newWord;
                    break;
                }
            }


        }
        public string findGreaterWord(string[] array)
        {
            string result = null;
            for (int i = 0; i < array.Length; i++)
            {
                try
                {
                    if (array[i] == myWord)
                    {
                        result = array[i + 1];
                    }
                }
                catch
                {
                    result = null;
                }
            }
            return result;
        }

        public void sort(string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (isGreate(array[j], array[i]))
                    {
                        string term = array[i];
                        array[i] = array[j];
                        array[j] = term;
                    }
                }
            }
        }
    }
}
