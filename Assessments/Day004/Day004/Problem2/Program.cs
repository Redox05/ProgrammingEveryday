namespace Problem2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = {  };

            string[] result = FindMostFrequentWords(words);
            for(int i =0; i<result.Length;i++){
                Console.Write($"{result[i]} ");
            }


            string[] FindMostFrequentWords(string[] words){

                string[] wordsToLower = new string[words.Length];
                for(int i=0;i<words.Length;i++){
                    wordsToLower[i] = words[i].ToLower();
                }

                Dictionary<string, int> wordFrequency = new Dictionary<string, int>();
                for(int i=0;i<wordsToLower.Length;i++){
                    if (wordFrequency.ContainsKey(wordsToLower[i])) {
                        wordFrequency[wordsToLower[i]]++;
                    }
                    else{
                        wordFrequency[wordsToLower[i]] = 1;
                    }
                }

                int highestFrequency = 0;
                foreach(var kvp in wordFrequency){
                    if(kvp.Value>highestFrequency){
                        highestFrequency = kvp.Value;
                    }
                }

                HashSet<string> wordSameFrequency = new HashSet<string>();
                List<string> resultFrequency = new List<string>();
                for (int i = 0; i < wordsToLower.Length; i++)
                {
                    if(wordFrequency[wordsToLower[i]]==highestFrequency){
                        if(wordSameFrequency.Add(wordsToLower[i])){
                            resultFrequency.Add(wordsToLower[i]);
                        }
                    }
                }

                string[] result = new string[resultFrequency.Count];
                for(int i=0; i<resultFrequency.Count;i++){
                    result[i] = resultFrequency[i];
                }

                return result;
            }

        }
    }
}
