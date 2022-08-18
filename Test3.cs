namespace VSCode.Test
{
    public class Test3
    {

        public static void Main()  
    {  
        String sentence = "Beauty lies in the eyes of beholder";  
        int wordCount = 0;  
          
        for(int i = 0; i < sentence.Length-1; i++) {  
            //Counts all the spaces present in the string  
            //It doesn't include the first space as it won't be considered as a word  
            if(sentence[i] == ' ' && Char.IsLetter(sentence[i+1]) && (i > 0)) {  
                wordCount++;  
            }  
        }  
        //To count the last word present in the string, increment wordCount by 1  
        wordCount++;  
          
        //Displays the total number of words present in the given string  
        Console.WriteLine("Total number of words in the given string: " + wordCount);  
    }
    }
}
