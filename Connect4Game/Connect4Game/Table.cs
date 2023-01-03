using System;
using System.Linq;

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

		public Table MakeMove(int x, PlayerType player)
		{
			int y = FirstFreePosition(x);
			if (y == -1)
			{
				return null;
			}

			Table newTable = new Table(this);

			newTable.Cells[x, y].PlayerType = player;
			return newTable;
		}

        // TODO: use LINQ expressions
		private int FirstFreePosition(int x)
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

        // TODO: revisit the validation algorithm
        public int GetMaxPoints(PlayerType playerType, int col, int row)
        {
            int maxPoints = 0;

            // Check the row that contains the newly placed piece
            for (int i = col - 3; i <= col + 3; i++)
            {
                if (i >= 0 && i < Columns && Cells[i, row].PlayerType == playerType)
                {
                    int count = 1;
                    for (int j = i + 1; j <= col + 3; j++)
                    {
                        if (j >= 0 && j < Columns && Cells[j, row].PlayerType == playerType)
                        {
                            count++;
                        }
                        else
                        {
                            break;
                        }
                    }
                    for (int j = i - 1; j >= col - 3; j--)
                    {
                        if (j >= 0 && j < Columns && Cells[j, row].PlayerType == playerType)
                        {
                            count++;
                        }
                        else
                        {
                            break;
                        }
                    }

                    if (count >= maxPoints)
                    {
                        maxPoints = count;
                    }
                }
            }

            // Check the column that contains the newly placed piece
            for (int i = row - 3; i <= row + 3; i++)
            {
                if (i >= 0 && i < Rows && Cells[col, i].PlayerType == playerType)
                {
                    int count = 1;
                    for (int j = i + 1; j <= row + 3; j++)
                    {
                        if (j >= 0 && j < Rows && Cells[col, j].PlayerType == playerType)
                        {
                            count++;
                        }
                        else
                        {
                            break;
                        }
                    }
                    for (int j = i - 1; j >= row - 3; j--)
                    {
                        if (j >= 0 && j < Rows && Cells[col, j].PlayerType == playerType)
                        {
                            count++;
                        }
                        else
                        {
                            break;
                        }
                    }

                    if (count >= maxPoints)
                    {
                        maxPoints = count;
                    }
                }
            }

            // Check the positive diagonal that contains the newly placed piece
            for (int i = col - 3, j = row - 3; i <= col + 3; i++, j++)
            {
                if (i >= 0 && i < Columns && j >= 0 && j < Rows && Cells[i, j].PlayerType == playerType)
                {
                    int count = 1;
                    for (int k = i + 1, l = j + 1; k <= col + 3; k++, l++)
                    {
                        if (k >= 0 && k < Columns && l >= 0 && l < Rows && Cells[k, l].PlayerType == playerType)
                        {
                            count++;
                        }
                        else
                        {
                            break;
                        }
                    }
                    for (int k = i - 1, l = j - 1; k >= col - 3; k--, l--)
                    {
                        if (k >= 0 && k < Columns && l >= 0 && l < Rows && Cells[k, l].PlayerType == playerType)
                        {
                            count++;
                        }
                        else
                        {
                            break;
                        }
                    }

                    if (count >= maxPoints)
                    {
                        maxPoints = count;
                    }
                }
            }

            // Check the negative diagonal that contains the newly placed piece
            for (int i = col - 3, j = row - 3; i <= col + 3; i++, j++)
            {
                if (i >= 0 && i < Columns && j >= 0 && j < Rows && Cells[i, j].PlayerType == playerType)
                {
                    int count = 1;
                    for (int k = i + 1, l = j - 1; k <= col + 3; k++, l--)
                    {
                        if (k >= 0 && k < Columns && l >= 0 && l < Rows && Cells[k, l].PlayerType == playerType)
                        {
                            count++;
                        }
                        else
                        {
                            break;
                        }
                    }
                    for (int k = i - 1, l = j + 1; k >= col - 3; k--, l++)
                    {
                        if (k >= 0 && k < Columns && l >= 0 && l < Rows && Cells[k, l].PlayerType == playerType)
                        {
                            count++;
                        }
                        else
                        {
                            break;
                        }
                    }

                    if (count >= maxPoints)
                    {
                        maxPoints = count;
                    }
                }
            }

            return maxPoints;
        }

        public void FindDifferences(Table newTable, out int x, out int y)
        {
            for (int i = 0; i < Columns; i++)
            {
                for (int j = 0; j < Rows; j++)
                {
                    if (Cells[i, j].PlayerType == PlayerType.Empty &&
                        newTable.Cells[i, j].PlayerType != PlayerType.Empty)
                    {
                        x = i;
                        y = j;
                        return;
                    }
                }
            }
            x = -1;
            y = -1;
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
