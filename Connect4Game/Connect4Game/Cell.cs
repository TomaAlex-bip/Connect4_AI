namespace Connect4Game
{
    public class Cell
    {
        public PlayerType PlayerType { get; set; }

        public Cell()
        {
            PlayerType = PlayerType.Empty;
        }

        public Cell(PlayerType playerType)
        {
            PlayerType = playerType;
        }
    }

    public enum PlayerType
    {
        Empty, Computer, Human
    }
}
