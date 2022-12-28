namespace Connect4Game
{
    public class Table
    {
        public int Rows { get; set; }
        public int Columns { get; set; }
        public Cell[,] Cells { get; set; }


        public Table()
        {
            Rows = 6;
            Columns = 7;
            Cells = new Cell[7, 6]
            {
                {new Cell(), new Cell(), new Cell(), new Cell(), new Cell(), new Cell() },
                {new Cell(), new Cell(), new Cell(), new Cell(), new Cell(), new Cell() },
                {new Cell(), new Cell(), new Cell(), new Cell(), new Cell(), new Cell() },
                {new Cell(), new Cell(), new Cell(), new Cell(), new Cell(), new Cell() },
                {new Cell(), new Cell(), new Cell(), new Cell(), new Cell(), new Cell() },
                {new Cell(), new Cell(), new Cell(), new Cell(), new Cell(), new Cell() },
                {new Cell(), new Cell(), new Cell(), new Cell(), new Cell(), new Cell() }
            };
        }

        public Table(Table table)
        {
            Rows = table.Rows;
            Columns = table.Columns;
            Cells = new Cell[Columns, Rows];

            for (int i = 0; i < Columns; i++)
            {
                for (int j = 0; j < Rows; j++)
                {
                    Cells[i, j] = new Cell(table.Cells[i, j].PlayerType);
                }
            }
        }

        public int FirstFreePosition(int x)
        {
            for (int i = 0; i < Rows; i++)
            {
                var currentCell = Cells[x, i];
                if (currentCell.PlayerType == PlayerType.Empty)
                {
                    return i;
                }
            }

            return -1;
        }

        public void InitializeDummyData()
        {
            Cells[0, 0].PlayerType = PlayerType.Human;
            Cells[0, 1].PlayerType = PlayerType.Human;
            Cells[0, 2].PlayerType = PlayerType.Human;
            Cells[0, 3].PlayerType = PlayerType.Human;
            Cells[0, 4].PlayerType = PlayerType.Human;
            Cells[0, 5].PlayerType = PlayerType.Human;
            Cells[1, 0].PlayerType = PlayerType.Computer;
            Cells[2, 0].PlayerType = PlayerType.Computer;
            Cells[3, 0].PlayerType = PlayerType.Computer;
            Cells[4, 0].PlayerType = PlayerType.Computer;
            Cells[5, 0].PlayerType = PlayerType.Computer;
            Cells[6, 0].PlayerType = PlayerType.Computer;
        }
    }
}
