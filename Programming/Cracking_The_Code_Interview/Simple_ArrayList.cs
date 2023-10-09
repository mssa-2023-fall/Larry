using System.Collections.Generic;

namespace Cracking_The_Coding_Interview
{
    public class Simple_ArrayList
    {

        public List<string> Merge(string[] words, string[] more)
        {
            List<string> sentence = new List<string>();

            foreach (string w in words)
                sentence.Add(w);

            foreach (string w in more)
                sentence.Add(w);

            return sentence;
        }
    }
}