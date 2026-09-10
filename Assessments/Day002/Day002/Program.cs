//****************************************************************************************************************************
//Problem 1 - Algorithm practice
//First non-repeating character

//string text = "Swiss";

//Console.WriteLine($"First Non-repeating character: {FindFirstNonRepeatingCharacter(text)}");

//char? FindFirstNonRepeatingCharacter(string txt)
//{
//    string txtToLower = txt.ToLower();
//    char? firstNonRepeatingChar = null;

//    //Count the appearance of every character
//    Dictionary<char, int> charCounter = new Dictionary<char, int>();

//    foreach (char c in txtToLower)
//    {
//        if (char.IsWhiteSpace(c))
//        {
//            continue;
//        }
//        else if (charCounter.ContainsKey(c))
//        {
//            charCounter[c]++;
//        }
//        else
//        {
//            charCounter[c] = 1;
//        }
//    }

//    //Find the first char which value is = 1
//    foreach (char c in txtToLower)
//    {
//        if(char.IsWhiteSpace(c)){
//            continue;
//        }
//        if (charCounter[c] == 1)
//        {
//            firstNonRepeatingChar = c;
//            break;
//        }
//    }

//    return firstNonRepeatingChar;
//}



//****************************************************************************************************************************
//Problem 2 - Remove duplicates

int[] numbers = { 4, 2, 4, 1, 2, 8 };

int[] uniqueNumbers = RemoveDuplicates(numbers);

foreach(int i in uniqueNumbers){
    Console.Write($"{i} ");
}

int[] RemoveDuplicates(int[] numbers){

    //Initialize HashSet
    HashSet<int> uniqueNumbers = new HashSet<int>();
    List<int> uniqueList = new List<int>();

    //Remove duplicates
    foreach (int i in numbers)
    {
        bool wasAdded = uniqueNumbers.Add(i);
        if(wasAdded){
            uniqueList.Add(i);
        }
        
    }

    //Convert the list to a int[]
    int[] result = uniqueList.ToArray();
    return result;
}



