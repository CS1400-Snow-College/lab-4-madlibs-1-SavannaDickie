// See https://aka.ms/new-console-template for more information

//name: Savanna Dickie Date: 10/06/2024 lab: Lab 4 Madlibs #1
using System.Globalization;
using System.Security.Cryptography;
using Microsoft.VisualBasic;

Console.Title = "MADLIBS";
Console.WriteLine("This is Mad Libs. When you are done providing the requested words \nI will build them into a funny story for you\nEnter the requested word types.");
string originalStory = "A vacation is when you take a trip to some (adjective) place with your (adjective) family. Usually, you go to some place that is near a/an (noun) or up on a/an (noun). A good vacation place is one where you can ride (plural_noun) or play (game) or go hunting for (plural_noun). I like to spend my time (verb_ending_in_“ing”) or (verb_ending_in_“ing”). When parents go on a vacation, they spend their time eating three (plural_noun) a day, and fathers play golf, and mothers sit around (verb_ending_in_“ing”) Last summer, my little brother fell in a/an (noun) and got poison (plant) all over his (part_of_the_body) My family is going to go to (place) and I will practice (verb_ending_in_“ing”) Parents need vacations more than kids because parents are always very (adjective) and because they have to work (number) hours every day all year making enough (plural_noun) to pay for the vacation.";
//string originalStory = "A vacation is when you take a trip to some (adjective) place with your (adjective) family. Usually, you go to some place that is near a/an (noun) or up on a/an (noun ). A good vacation place is one where you can ride (plural_noun) or play (game) or go hunting for (plural noun). I like to spend my time (verb_ending_in_ing) or (verb_ending_in_"ing" ). When parents go on a vacation, they spend their time eating three (plural_noun) a day, and fathers play golf, and mothers sit around (verb_ending_in_ing) Last summer, my little brother fell in a/an (noun) and got poison (plant) all over his (part_of_the_body) My family is going to go to (place) and I will practice (verb_ending_in_ing) Parents need vacations more than kids because parents are always very (adjective) and because they have to work (number) hours every day all year making enough (plural_noun) to pay for the vacation.";

string[] storyWords = originalStory.Split(' ');
//Console.WriteLine(storyWords);
//string newStory;//end story
// storyWords;
string newStory = "";
foreach(string word in storyWords)//for(int i = 0; i < storyWords.Length; i++);
{
    //string storyWords; // SAVANNA keep string 21 as is so it shows all questions and 29 so it removes the few that have ).. 
    if(word.StartsWith("(")) //&& word.EndsWith(")")) //|| word.StartsWith("(") && word.EndsWith(").")) // || word.StartsWith("(") && word.EndsWith(").")) //&& word.Contains(" ")*/)
    {
        //bool replacementWord = word.StartsWith("(") && word.EndsWith(")");
        //string replacementWord = word.Trim(new string[] {'(',')'});
       string isolateWord = word.Trim(new char[] {'(',')'}); //KEEP
       //storyWords = storyWords.Replace('_', out " ");
       //replacementWord = replacementWord.Remove("_"," ");
       //string storyWords = 
       string isolateWordAgain = isolateWord.Replace(").", ""); //KEEP
       string requestedWord = isolateWordAgain.Replace("_"," ");// (")."," ") //isolateWord.Remove() //KEEP
       //0string requestedWord = isolated.Replace(")","");
       Console.WriteLine();
       if(requestedWord.Contains("adjective"))
       {
        Console.WriteLine($"Please give me an {requestedWord}: ");
       }
       else
       {
        Console.WriteLine($"Please give me a {requestedWord}: ");
       }
        
        string newWord = Console.ReadLine( );
        //storyWords = string.Join(" ");
        //string newStory = storyWords.Replace()
        newStory = newStory + newWord/*(" ")*/ + " ";
   }
   if(!word.StartsWith("("))
   {
        newStory = newStory + word + " " ; //add word to new story along with a space. Space " ". 
   }
   //if(!word.EndsWith('.'))
   //{
    //    newStory
   //}
} 
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Here is your Madlibs:");
Console.WriteLine("---------------------");
Console.WriteLine(newStory);

//string finalStory = string.Join(" ", storyWords);
//Console.WriteLine(storyWords);
//string storyWords = string.Join(" ");
//if(storyWords.StartsWith("("));
//Console.WriteLine("")

//Console.WriteLine("Please Give me a/an adjective: ");
//string a = Console.ReadLine();
//Console.WriteLine("Please give me a/an adjective: ");
//string b = Console.ReadLine();
//storyWords = storyWords;

//0foreach(string word in storyWords)//for(int i = 0; i < storyWords.Length; i++);
//0{
    //string storyWords;
    //0if(word.StartsWith("(")/* && word.EndsWith(")")&& word.Contains(" ")*/)
    //0{
        //bool replacementWord = word.StartsWith("(") && word.EndsWith(")");
        //string replacementWord = word.Trim(new string[] {'(',')'});
       //0 string replacementWord = word.Trim(new char[] {'(',')'});
        //0Console.WriteLine($"Please give me a/an {replacementWord}");
        //0string newWord = Console.ReadLine();
   //0 }
//0} 
//if(storyWords.StartsWith("("));

/*Console.Title = "MADLIBS";
Console.WriteLine("This is Mad Libs. When you are done providing the requested words \nI will build them into a funny story for you\nEnter the requested word types.");

string originalStory = "A vacation is when you take a trip to some (adjective) place with your (adjective) family. Usually, you go to some place that is near a/an (noun) or up on a/an (noun). A good vacation place is one where you can ride (plural noun) or play (game) or go hunting for (plural noun). I like to spend my time (verb ending in ing) or (verb ending in ing). When parents go on a vacation, they spend their time eating three (plural noun) a day, and fathers play golf, and mothers sit around (verb ending in ing) Last summer, my little brother fell in a/an (noun) and got poison (plant) all over his (part of the body) My family is going to go to (place) and I will practice (verb ending in ing) Parents need vacations more than kids because parents are always very (adjective) and because they have to work (number) hours every day all year making enough (plural noun) to pay for the vacation.";
//if(orignalStory.Contains('(') && originalStory.Contains(')') originalStory.Join(" ", originalStory))
/*originalStory = originalStory.Replace("(plural noun)", "(plural_noun)");
originalStory = originalStory.Replace("(verb ending in ing)", "(verb_ending_in_ing)");
originalStory = originalStory.Replace("(Part of the body)", "(Part_of_the_body)"); */
//string originalStory.Contains('_') = Console.ForegroundColor = ConsoleColor.Black;
//if(originalStory.Contains('_'))
//{
   //0 Console.ForegroundColor = ConsoleColor.Black;
    //originalStory = originalStory.Replace("_", Console.ForegroundColor = ConsoleColor.Black(_));
//}
//string[] storyWords = originalStory.Split(' ');
//Console.WriteLine(storyWords); 
//if(originalStory.Contains("(plural noun), (noun ending in ing), (part of body)"))
//{
   // phrase = string.join("(plural noun)");
//}

//foreach(string word in storyWords)
//{
    //Console.WriteLine(word);
//}
//Console.WriteLine("")

//Console.WriteLine("Please Give me a/an adjective: ");
//string a = Console.ReadLine();
//Console.WriteLine("Please give me a/an adjective: ");
//string b = Console.ReadLine();
//storyWords = storyWords;

//0foreach(string word in storyWords)//for(int i = 0; i < storyWords.Length; i++);
//0{
    //string storyWords;
    //0if(word.StartsWith("(")/* && word.EndsWith(")")&& word.Contains(" ")*/)
    //0{
        //bool replacementWord = word.StartsWith("(") && word.EndsWith(")");
        //string replacementWord = word.Trim(new string[] {'(',')'});
       //0 string replacementWord = word.Trim(new char[] {'(',')'});
        //0Console.WriteLine($"Please give me a/an {replacementWord}");
        //0string newWord = Console.ReadLine();
   //0 }
//0} 
//if(storyWords.StartsWith("(")); 

//if(originalStory.Contains('_'))
//{
   // _ = Console.ForegroundColor = ConsoleColor.Black;
//}