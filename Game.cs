 
 class Game {
    Life player = new Life();
    man man = new man();
    public string CurrentWord;
    WordBank word = new WordBank();
        public Game(){
            CurrentWord = word.PickRandomWord();
        }
    public void Play() {
        int wrong = 0;
        int LettersRight = 0;
        Console.WriteLine($"the word is {CurrentWord.Length} long");
                while (wrong != 4 && LettersRight != CurrentWord.Length){
                var guess = player.Guess();
                if (CurrentWord.Contains(guess)){
                    LettersRight ++; 
                    word.RightLetters.Add(guess);
                    man.printjumper(wrong);
                    Console.Write("Correct letters:\n");
                    Console.Write(string.Join(System.Environment.NewLine, word.RightLetters));
                    Console.Write("\n");
                }
                else{
                    wrong ++;
                    man.printjumper(wrong);
                }

                }
        Console.WriteLine($"game over, the word was {CurrentWord}");



                

        }




 }