//****************************************************************************************************************************
//Problem 1 - Algorithm practice
//First non-repeating character

//string text = "Swiss";

//Console.WriteLine($"First Non-repeating character: {FindFirstNonRepeatingCharacter(text.ToLower())}");

//char? FindFirstNonRepeatingCharacter(string txt){
//    char? firstNonRepeatingChar = ' ';

//    //Count the appearance of every character
//    Dictionary<char, int> charCounter = new Dictionary<char, int>();

//    foreach (char c in txt)
//    {
//        if (charCounter.ContainsKey(c))
//        {
//            charCounter[c]++;
//        }
//        else
//        {
//            charCounter[c] = 1;
//        }
//    }

//    //Find the first char which value is = 1
//    foreach (var kvp in charCounter)
//    {
//        if (kvp.Value == 1)
//        {
//            firstNonRepeatingChar = kvp.Key;
//            break;
//        }
//        else
//        {
//            firstNonRepeatingChar = null;
//        }
//    }

//    //I don't know how to ignore spaces


//    return firstNonRepeatingChar;
//}



//****************************************************************************************************************************
//Problem 2 - Remove duplicates

int[] numbers = { 4, 2, 4, 1, 2, 8 };

Dictionary<int, int> noCounter = new Dictionary<int, int>();

//Remove duplicates
foreach(int i in numbers){
    if(!noCounter.ContainsKey(i)){
        noCounter[i] = 1;
    }
}

//Print the array without duplicates
foreach(var kvp in noCounter){
    Console.Write($"{kvp.Key}");
}

