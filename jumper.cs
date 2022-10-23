class Jumper {

    static void Main(string[] args) {
        var game = new Game();
        Life player = new Life();
        var keepPlaying = true;
        while (keepPlaying){
        game.Play();
        keepPlaying = player.KeepPlaying();
        }
    }
}