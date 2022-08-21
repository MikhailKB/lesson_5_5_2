using System;
using static System.Console;


namespace lesson_5_5_2

{
    class Program
    {        /// <summary>
    /// 
    /// </summary>
    /// <param name="words"></param> меняет слова наоборот
    /// <returns></returns>
        static string[] ReversWords(string[] words)
        {
            for (int i = words.Length - 1; i>=0; i--)
            {
                WriteLine($"{words[i]} ");
            }
            return words;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="text"></param> создание массива
        /// <returns></returns>
        static string[] ArrayCreation(string text)
        {
            string[] words = text.Split(' ');
            return words;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param> точка входа
        static void Main(string[] args)
        {
            WriteLine("Введите любое предложение, разделяя слова пробелами: ");
            string text = ReadLine();
            ArrayCreation(text);
            string[] words = ArrayCreation(text);
            ReversWords(words);
            ReadKey();
        }
    }
}
