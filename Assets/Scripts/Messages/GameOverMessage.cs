namespace Messages
{
    public struct GameOverMessage
    {

    }

    public struct ScoreMessage
    {
        public readonly int Score;

        public ScoreMessage(int score)
        {
            Score = score;
        }
    }

    public struct PassThroughObstacle
    {
        
    }

    public struct GameStartMessage
    {
        
    }

}