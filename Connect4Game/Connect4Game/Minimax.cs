using System;

namespace Connect4Game
{
    internal class Minimax
    {

        public static Table FindNextTable(Table currentTable, out int affectedRow, out int affectedColumn)
        {
            var choosenTable = new Table(currentTable);
            
            Random rand = new Random();
            
            var x = rand.Next(0, currentTable.Columns);
            var y = currentTable.FirstFreePosition(x);

            while(y == -1)
            {
                x = rand.Next(0, currentTable.Columns);
                y = currentTable.FirstFreePosition(x);
            }

            choosenTable.Cells[x, y].PlayerType = PlayerType.Computer;
            affectedColumn = x;
            affectedRow = y;

            return choosenTable;
        }

    }
}
