using System;

namespace MyDictionaryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, int> myDictionary = new MyDictionary<string, int>();
            myDictionary.Add("Recep", 123654);
            myDictionary.Add("Ali",795646);
            myDictionary.Add("Emre",879466);
        }
    }
}
