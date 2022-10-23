class Life{

    public string Guess() {
        Console.WriteLine("guess a letter:");
        return Console.ReadLine() ??"";


    }
    public bool KeepPlaying() {
        Console.WriteLine("keep playing (y/n)");
        string response= Console.ReadLine()??"";
        return response == "y";


    }


}