// creates the list of possible words and chooses one 
class WordBank {
    Random generator = new Random();

    public List<string> WordList = new List<string>{"bruh", "yuh", "gamer", "fortnite", "sock", "boot", "soup", 
    "blind", "laptop", "meme", "roblox", "panda", "quake", "pygmy", "ayo", "sixteen", "headache", "loaf", "zooted", "hedgehog"};

    public List<string> RightLetters = new List<string>();
    public String PickRandomWord() {
        int Index = generator.Next(WordList.Count);
        string randomWord = WordList[Index];
        WordList.RemoveAt(Index);
        return randomWord;
    }
    

}