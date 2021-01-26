using System;

namespace D4O5
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<Word> kelimeler = new MyDictionary<Word>();

            Word[] temparray;
            
            Word word1 = new Word();
            word1.Id = 1;
            word1.Content = "kalem";
            temparray= kelimeler.Add(word1);


            Word word2 = new Word();
            word2.Id = 2;
            word2.Content = "pc";
            temparray = kelimeler.Add(word2);

            Word word3 = new Word();
            word3.Id = 3;
            word3.Content = "masa";
            temparray = kelimeler.Add(word3);


            foreach (Word item in temparray)
            {
                Console.WriteLine(item.Id + " lı "+ item.Content +" eklenmiştir.");
            }
            
        }
    }
}
